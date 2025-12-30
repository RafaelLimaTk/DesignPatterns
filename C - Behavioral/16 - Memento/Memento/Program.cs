using Memento;

Console.Title = "Memento pattern";

EmployeeManagerInvoker managerInvoker = new();
EmployeeManagerRepository repository = new();

static void PrintSeparator(string title)
{
    Console.WriteLine();
    Console.WriteLine("=== " + title + " ===");
}

// Initial state
PrintSeparator("Initial state");
repository.WriteDataStore();

// Add a series of employees using commands
PrintSeparator("Adding employees");
var addKaty = new AddEmployeeCommand(repository, 1, new Employee(1, "Katy"));
var addBob = new AddEmployeeCommand(repository, 1, new Employee(2, "Bob"));
var addAna = new AddEmployeeCommand(repository, 2, new Employee(3, "Ana"));

managerInvoker.Invoke(addKaty);
managerInvoker.Invoke(addBob);
managerInvoker.Invoke(addAna);

repository.WriteDataStore();

// Try to add a duplicate (should not be added because CanExecute should fail)
PrintSeparator("Attempt to add duplicate Katy to manager 1");
var addKatyAgain = new AddEmployeeCommand(repository, 1, new Employee(1, "Katy"));
managerInvoker.Invoke(addKatyAgain);
repository.WriteDataStore();

// Undo last operation (should remove Ana from manager 2)
PrintSeparator("Undo last operation");
managerInvoker.Undo();
repository.WriteDataStore();

// Undo all operations (should remove all added employees)
PrintSeparator("Undo all operations");
managerInvoker.UndoAll();
repository.WriteDataStore();

Console.WriteLine();
Console.WriteLine("Demo finished - press any key to exit");
Console.ReadKey();
