namespace Strategy;

/// <summary>
/// Strategy
/// </summary>
public interface IExportService
{
    void Export(Order order);
}

/// <summary>
/// Cncrete Strategy
/// </summary>
public class JsonExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} in JSON format.");
    }
}

/// <summary>
/// Concrete Strategy
/// </summary>
public class XMLExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} in XML format.");
    }
}

/// <summary>
/// Concrete Strategy
/// </summary>
public class CSVExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} in CSV format.");
    }
}

/// <summary>
/// Context
/// </summary>
public class Order
{
    public string Customer { get; private set; }
    public int Amount { get; private set; }
    public string Name { get; private set; }
    public string? Description { get; private set; }

    public Order(
        string customer,
        int amount,
        string name,
        string? description = null)
    {
        Customer = customer;
        Amount = amount;
        Name = name;
        Description = description;
    }

    public void Export(IExportService exportService)
        => exportService.Export(this);
}