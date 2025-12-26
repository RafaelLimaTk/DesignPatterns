namespace Builder;

/// <summary>
/// Product
/// </summary>
public class Car
{
    private readonly List<string> _parts = new();
    private readonly string _type;

    public Car(string type)
        => _type = type;

    public void AddPart(string part)
        => _parts.Add(part);

    public override string ToString()
        => $"Car of type {_type} has parts {string.Join(", ", _parts)}";
}

/// <summary>
/// Builder
/// </summary>
public abstract class CarBuilder
{
    public Car Car;

    public CarBuilder(string type)
        => Car = new Car(type);

    public abstract void BuildEngine();
    public abstract void BuildFrame();
}

/// <summary>
/// Concrete Builder
/// </summary>
public class MiniBuilder : CarBuilder
{
    public MiniBuilder()
        : base("Mini")
    {
    }

    public override void BuildEngine()
        => Car.AddPart("not a V8'");

    public override void BuildFrame()
        => Car.AddPart("'3-door with stripes'");
}

/// <summary>
/// Concrete Builder
/// </summary>
public class BMWBuilder : CarBuilder
{
    public BMWBuilder()
        : base("BMW")
    {
    }

    public override void BuildEngine()
        => Car.AddPart("'a fancy V8 engine'");

    public override void BuildFrame()
        => Car.AddPart("'5-door with metalic finish'");
}

/// <summary>
/// Director
/// </summary>
public class Garage
{
    private CarBuilder? _builder;

    public void Construct(CarBuilder builder)
    {
        _builder = builder;
        _builder.BuildEngine();
        _builder.BuildFrame();
    }
}