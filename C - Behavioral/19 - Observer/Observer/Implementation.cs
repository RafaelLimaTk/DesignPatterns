namespace Observer;

public class TicketChange(int amount, int artistId)
{
    public int Amount { get; private set; } = amount;
    public int ArtistId { get; private set; } = artistId;
}

/// <summary>
/// Subject
/// </summary>
public abstract class TicketChangeNotifier
{
    private readonly List<ITicketChangeListener> _observers = [];

    public void AddObserver(ITicketChangeListener observer)
        => _observers.Add(observer);

    public void RemoveObserver(ITicketChangeListener observer)
        => _observers.Remove(observer);

    public void Notify(TicketChange ticketChange)
        => _observers.ForEach(o => o.ReceiveTicketChangeNotification(ticketChange));
}

/// <summary>
/// Observer
/// </summary>
public interface ITicketChangeListener
{
    void ReceiveTicketChangeNotification(TicketChange ticketChange);
}

/// <summary>
/// ConcreteSubject
/// </summary>
public class OrderService : TicketChangeNotifier
{
    public void ChangeTicketAmount(int amount, int artistId)
    {
        Console.WriteLine($"{nameof(OrderService)} is changing its state");
        // notify observers about the state change
        Console.WriteLine($"{nameof(OrderService)} is notifying observers...");
        Notify(new TicketChange(amount, artistId));
    }
}

/// <summary>
/// ConcreteObserver
/// </summary>
public class TicketResellerService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        // update internal state
        Console.WriteLine($"{nameof(TicketResellerService)} notified " +
            $"of ticket change: amount {ticketChange.Amount} " +
            $"for artist with ID {ticketChange.ArtistId}");
    }
}

/// <summary>
/// ConcreteObserver
/// </summary>
public class TicketStockService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        // update internal state
        Console.WriteLine($"{nameof(TicketStockService)} notified " +
            $"of ticket change: amount {ticketChange.Amount} " +
            $"for artist with ID {ticketChange.ArtistId}");
    }
}