using Strategy;

Console.Title = "Strategy pattern";
Order order = new("John Doe", 100, "Order001", "Sample order description");

order.Export(new CSVExportService());
order.Export(new JsonExportService());
order.Export(new XMLExportService());

Console.ReadKey();