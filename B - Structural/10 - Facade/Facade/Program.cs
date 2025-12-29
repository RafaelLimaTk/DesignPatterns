using Facade;

Console.Title = "Facade pattern";

var discountFacade = new DiscountFacade();
int[] customerIds = [1, 10];
foreach (var customerId in customerIds)
{
    var discount = discountFacade.CalculateDiscountPercentage(customerId);
    Console.WriteLine($"Discount percetage for customer with id {customerId}: {discount}%");
}

Console.ReadKey();
