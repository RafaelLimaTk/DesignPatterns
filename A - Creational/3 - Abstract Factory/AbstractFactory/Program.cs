using AbstractFactory;

Console.Title = "Abstract factory pattern";

var brazilShoppingCartPurchaseFactory = new BrazilShoppingCartPurchaseFactory();
var shoppingCartForBrazil = new ShoppingCart(brazilShoppingCartPurchaseFactory);
shoppingCartForBrazil.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

Console.ReadKey();