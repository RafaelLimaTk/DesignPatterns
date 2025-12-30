using Visitor;

Console.Title = "Visitor pattern";

// create container and add elements
Container container = new();

container.Customers.Add(new Customer("Alice", 1200));
container.Customers.Add(new Customer("Bob", 800));
container.Customers.Add(new Customer("Charlie", 1500));
container.Employees.Add(new Employee("David", 2015));
container.Employees.Add(new Employee("Eve", 2010));

// create visitor and accept it
DiscountVisitor visitor = new();

// pass it through
container.Accept(visitor);

Console.WriteLine($"Total discount: {visitor.TotalDiscountGiven:C}");

Console.ReadKey();