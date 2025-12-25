namespace AbstractFactory;

/// <summary>
/// Abstract Factory
/// </summary>
public interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}

/// <summary>
/// Abstract Product
/// </summary>
public interface IDiscountService
{
    int DiscountPercentage { get; }
}

/// <summary>
/// Concrete Product
/// </summary>
public class BrazilDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}

/// <summary>
/// Concrete Product
/// </summary>
public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}

/// <summary>
/// Abstract Product
/// </summary>
public interface IShippingCostsService
{
    decimal ShippingCosts { get; }
}

/// <summary>
/// Concrete Product
/// </summary>
public class BrazilShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 20;
}

/// <summary>
/// Concrete Product
/// </summary>
public class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 25;
}

/// <summary>
/// Concrete Factory
/// </summary>
public class BrazilShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
        => new BrazilDiscountService();

    public IShippingCostsService CreateShippingCostsService()
        => new BrazilShippingCostsService();
}

/// <summary>
/// Concrete Factory
/// </summary>
public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
        => new FranceDiscountService();

    public IShippingCostsService CreateShippingCostsService()
        => new FranceShippingCostsService();
}

/// <summary>
/// Client class
/// </summary>
public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;
    private readonly int _orderCosts;

    // ctor
    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();
        _orderCosts = 200;
    }

    public void CalculateCosts()
        => Console.WriteLine($"Total costs = " +
            $"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
}