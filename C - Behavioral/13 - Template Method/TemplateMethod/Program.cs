using TemplateMethod;

Console.Title = "Template method pattern";

ExchangeMailParser exchangeMailParser = new();
Console.WriteLine(exchangeMailParser.ParseMailBody("37CE15D0-2EB9-49C4-8D69-CE6A8C53FA80"));
Console.WriteLine();

ApacheMailParser apacheMailParser = new();
Console.WriteLine(apacheMailParser.ParseMailBody("C2FBB3F8-42D2-4757-9475-7DFDB583AB10"));
Console.WriteLine();

EudoraMailParser eudoraMailParser = new();
Console.WriteLine(eudoraMailParser.ParseMailBody("6168889C-0292-4D98-825B-B442C3691CB3"));

Console.ReadKey();