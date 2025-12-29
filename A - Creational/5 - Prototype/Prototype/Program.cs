using Prototype;

Console.Title = "Prototype pattern";

var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Clone();
Console.WriteLine($"Manager was cloned: {managerClone.Name}");

var employee = new Employee("Rafael", manager);
var employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"Employee was cloned: {employeeClone.Name}," +
    $" with manager {employeeClone.Manager.Name}");

// change the original manager name
managerClone.Name = "Karen";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, " +
    $"with manager {employeeClone.Manager.Name}");

Console.ReadKey();