using Decorator;

Console.Title = "Decorator pattern";

// implementation mail services
CloudMailService cloudMailService = new();
cloudMailService.SendEmail("Hello World!");

OnPremiseMailService onPremiseMailService = new();
onPremiseMailService.SendEmail("Hello World!");

// add decorated mail services
var cloudMailServiceWithStats =
    new StatisticsDecorator(cloudMailService);
cloudMailServiceWithStats.SendEmail($"Hi there via {nameof(StatisticsDecorator)} wrapper.");

// add decorated mail services
var cloudMailServiceWithDatabase =
    new MessageDatabaseDecorator(cloudMailService);
cloudMailServiceWithDatabase.SendEmail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper 1.");
cloudMailServiceWithDatabase.SendEmail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper 2.");

foreach (var message in cloudMailServiceWithDatabase.SentMessages)
{
    Console.WriteLine($"Storage message: \"{message}\"");
}

Console.ReadKey();