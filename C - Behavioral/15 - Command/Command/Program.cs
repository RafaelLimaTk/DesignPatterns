using Command;

Console.Title = "Template method pattern";

EmployeeManagerInvoker managerInvoker = new();
EmployeeManagerRepository repository = new();

AddEmployeeCommand command = new(repository, 1, new Employee(1, "Katy"));
managerInvoker.Invoke(command);
repository.WriteDataStore();

Console.ReadKey();
