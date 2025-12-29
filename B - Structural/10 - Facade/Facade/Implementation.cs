namespace Facade;

/// <summary>
/// Subsystem Class
/// </summary>
public class OrderService
{
    public bool HasEnoughOrders(int customerId)
    {
        // does the customer have enough orders?
        // fake calculation for demo purposes
        return customerId % 2 == 0;
    }
}

/// <summary>
/// Subsystem Class
/// </summary>
public class CustomerDiscountBaseService
{
    public double CalculateDiscountBase(int customerId)
    {
        // fake calculation for demo purposes
        return (customerId > 8) ? 10 : 20;
    }
}

/// <summary>
/// Subsystem Class
/// </summary>
public class DayOfTheWeekFactorService
{
    public double CalculateDayOfTheWeekFactor()
        => DateTime.UtcNow.DayOfWeek switch
        {
            DayOfWeek.Saturday or DayOfWeek.Sunday => 0.8,
            _ => 1.2,
        };
}

/// <summary>
/// Facade
/// </summary>
public class DiscountFacade
{
    private readonly OrderService _orderService = new();
    private readonly CustomerDiscountBaseService _customerDiscountBaseService = new();
    private readonly DayOfTheWeekFactorService _dayOfTheWeekFactorService = new();

    public double CalculateDiscountPercentage(int customerId)
    {
        return !_orderService.HasEnoughOrders(customerId)
            ? 0
            : _customerDiscountBaseService.CalculateDiscountBase(customerId)
               * _dayOfTheWeekFactorService.CalculateDayOfTheWeekFactor();
    }
}