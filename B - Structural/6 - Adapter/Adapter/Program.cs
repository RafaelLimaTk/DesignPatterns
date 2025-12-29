using Adapter;

Console.Title = "Adapter pattern";

ICityAdapter cityAdapter = new CityAdapter();
City city = cityAdapter.GetCity();

Console.WriteLine($"City: {city.FullName}, Inhabitants: {city.Inhabitants}");
Console.ReadKey();