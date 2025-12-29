using Bridge;

Console.Title = "Bridge pattern";

NoCoupon noCoupon = new();
OneEuroCoupon oneEuroCoupon = new();

MeatBasedMenu meatMenu = new(noCoupon);
Console.WriteLine($"Meat based menu, no coupon: {meatMenu.CalculatePrice()} EUR");

meatMenu = new(oneEuroCoupon);
Console.WriteLine($"Meat based menu, 1 euro coupon: {meatMenu.CalculatePrice()} EUR");

VegetarianMenu vegMenu = new(noCoupon);
Console.WriteLine($"Vegetarian menu, no coupon: {vegMenu.CalculatePrice()} EUR");

vegMenu = new(oneEuroCoupon);
Console.WriteLine($"Vegetarian menu, 1 euro coupon: {vegMenu.CalculatePrice()} EUR");

Console.ReadKey();