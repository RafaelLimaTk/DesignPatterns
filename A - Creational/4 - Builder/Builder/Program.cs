using Builder;

Console.Title = "Builder pattern";

var garage = new Garage();

var miniBuilder = new MiniBuilder();
var bmwBuilder = new BMWBuilder();

garage.Construct(miniBuilder);
Console.WriteLine(miniBuilder.Car.ToString());

garage.Construct(bmwBuilder);
Console.WriteLine(bmwBuilder.Car.ToString());

Console.ReadKey();