using Memento;

Console.Title = "Memento pattern";

EmployeeManagerInvoker managerInvoker = new();
EmployeeManagerRepository repository = new();

AddEmployeeCommand command = new(repository, 1, new Employee(1, "Katy"));
managerInvoker.Invoke(command);

managerInvoker.Undo();
repository.WriteDataStore();

//if many commands were executed
//managerInvoker.UndoAll();

Console.ReadKey();