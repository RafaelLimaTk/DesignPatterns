using FactoryMethod;

Console.Title = "Factory method pattern";

List<DiscountFactory> factories =
[
    new CodeDiscountFactory("BLACKFRIDAY"),
    new CountryDiscountFactory("BR")
];

foreach (DiscountFactory factory in factories)
{
    DiscountService service = factory.CreateDiscountService();
    Console.WriteLine($"Discount Percentage: {service.DiscountPercentage}% "
        + $"coming from {service}");
}

Console.ReadKey();