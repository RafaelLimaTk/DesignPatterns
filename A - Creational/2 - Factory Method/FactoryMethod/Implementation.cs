namespace FactoryMethod;

/// <summary>
/// Product
/// </summary>
public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }
    public override string ToString() => GetType().Name;
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class CountryDiscountService : DiscountService
{
    private readonly string _countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
        => _countryIdentifier = countryIdentifier;

    public override int DiscountPercentage
        => _countryIdentifier switch
        {
            // if you're from Brazil, you get a better discount!
            "BR" => 20,
            _ => 10
        };
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class CodeDiscountService : DiscountService
{
    private readonly string _discountCode;

    public CodeDiscountService(string discountCode)
        => _discountCode = discountCode;

    public override int DiscountPercentage
        => _discountCode switch
        {
            // BLACKFRIDAY gives a huge discount!
            "BLACKFRIDAY" => 30,
            _ => 15
        };
}

/// <summary>
/// Creator
/// </summary>
public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}

/// <summary>
/// ConcreteCreator
/// </summary>
public class CountryDiscountFactory : DiscountFactory
{
    private readonly string _countryIdentifier;

    public CountryDiscountFactory(string countryIdentifier)
        => _countryIdentifier = countryIdentifier;

    public override DiscountService CreateDiscountService()
        => new CountryDiscountService(_countryIdentifier);
}

/// <summary>
/// ConcreteCreator
/// </summary>
public class CodeDiscountFactory : DiscountFactory
{
    private readonly string _discountCode;

    public CodeDiscountFactory(string discountCode)
        => _discountCode = discountCode;

    public override DiscountService CreateDiscountService()
        => new CodeDiscountService(_discountCode);
}