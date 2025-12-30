namespace Visitor;

/// <summary>
/// Concrete Element
/// </summary>
public class Customer : IElement
{
    public decimal AmountOrdered { get; private set; }
    public decimal Discount { get; set; }
    public string Name { get; private set; }

    public Customer(string name, decimal amountOrdered)
    {
        Name = name;
        AmountOrdered = amountOrdered;
    }

    public void Accept(IVisitor visitor)
    {
        //visitor.VisitCustomer(this);
        visitor.Visit(this);
        Console.WriteLine($"Visited {nameof(Customer)} {Name}, " +
            $"has a discount of {Discount:C}");
    }
}

/// <summary>
/// Concrete Element
/// </summary>
public class Employee : IElement
{
    public int YearEmployed { get; private set; }
    public decimal Discount { get; set; }
    public string Name { get; private set; }

    public Employee(string name, int yearEmployed)
    {
        Name = name;
        YearEmployed = yearEmployed;
    }

    public void Accept(IVisitor visitor)
    {
        //visitor.VisitEmployee(this);
        visitor.Visit(this);
        Console.WriteLine($"Visited {nameof(Employee)} {Name}, " +
            $"has a discount of {Discount:C}");
    }
}

///// <summary>
///// Visitor
///// </summary>
//public interface IVisitor
//{
//    void VisitCustomer(Customer customer);
//    void VisitEmployee(Employee employee);
//}

/// <summary>
/// Visitor (alternative)
/// </summary>
public interface IVisitor
{
    void Visit(IElement element);
}

/// <summary>
/// Element
/// </summary>
public interface IElement
{
    void Accept(IVisitor visitor);
}

/// <summary>
/// Concrete Visitor
/// </summary>
public class DiscountVisitor : IVisitor
{
    public decimal TotalDiscountGiven { get; private set; }

    public void Visit(IElement element)
    {
        switch (element)
        {
            case Customer customer:
                VisitCustomer(customer);
                break;
            case Employee employee:
                VisitEmployee(employee);
                break;
            default:
                throw new ArgumentException("Unknown element type", nameof(element));
        }
    }

    private void VisitCustomer(Customer customer)
    {
        customer.Discount = customer.AmountOrdered > 1000
            ? customer.AmountOrdered * 0.10M
            : customer.AmountOrdered * 0.05M;
        TotalDiscountGiven += customer.Discount;
    }

    private void VisitEmployee(Employee employee)
    {
        int yearsEmployed = DateTime.Now.Year - employee.YearEmployed;
        employee.Discount = yearsEmployed > 5 ? 200 : 100;
        TotalDiscountGiven += employee.Discount;
    }
}

/// <summary>
/// Object Structure
/// </summary>
public class Container
{
    public List<Employee> Employees { get; set; } = [];
    public List<Customer> Customers { get; set; } = [];

    public void Accept(IVisitor visitor)
    {
        foreach (var employee in Employees)
        {
            employee.Accept(visitor);
        }
        foreach (var customer in Customers)
        {
            customer.Accept(visitor);
        }
    }
}