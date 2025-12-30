namespace Memento;

public class Employee
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class Manager : Employee
{
    public List<Employee> Employees { get; private set; }

    public Manager(int id, string name)
        : base(id, name)
    {
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        if (employee == null) return;
        Employees.Add(employee);
    }

    public bool RemoveEmployee(Employee employee)
    {
        return employee != null && Employees.Remove(employee);
    }
}

/// <summary>
/// Receiver (interfaces)
/// </summary>
public interface IEmployeeManagerRepository
{
    void AddEmployee(int managerId, Employee employee);

    bool RemoveEmployee(int managerId, Employee employee);

    bool HasEmployee(int managerId, Employee employee);

    void WriteDataStore();
}

/// <summary>
/// Receiver (implementation)
/// </summary>
public class EmployeeManagerRepository : IEmployeeManagerRepository
{
    private readonly List<Manager> _managers;

    public EmployeeManagerRepository()
    {
        // demo: create two managers
        _managers =
        [
            new Manager(1, "Charlie"),
            new Manager(2, "Jose")
        ];
    }

    public void AddEmployee(int managerId, Employee employee)
    {
        if (employee is null) return;
        var manager = _managers.Find(m => m.Id == managerId);
        manager?.AddEmployee(employee);
    }

    public bool RemoveEmployee(int managerId, Employee employee)
    {
        if (employee is null) return false;
        var manager = _managers.Find(m => m.Id == managerId);
        return manager is not null && manager.Employees.Remove(employee);
    }

    public bool HasEmployee(int managerId, Employee employee)
    {
        if (employee is null) return false;
        var manager = _managers.Find(m => m.Id == managerId);
        return manager is not null && manager.Employees.Contains(employee);
    }

    public void WriteDataStore()
    {
        // simple demo output
        foreach (var manager in _managers)
        {
            Console.WriteLine($"Manager: {manager.Id} - {manager.Name}");
            foreach (var e in manager.Employees)
            {
                Console.WriteLine($"  Employee: {e.Id} - {e.Name}");
            }
        }
    }
}

/// <summary>
/// Command
/// </summary>
public interface ICommand
{
    void Execute();
    bool CanExecute();
}

/// <summary>
/// Memento
/// </summary
public class AddEmployeeMemento
{
    public int ManagerId { get; }
    public Employee Employee { get; }

    public AddEmployeeMemento(int managerId, Employee employee)
    {
        ManagerId = managerId;
        Employee = employee;
    }
}

/// <summary>
/// Concrete Command & Originator   
/// </summary>
public class AddEmployeeCommand
    (IEmployeeManagerRepository repository, int managerId, Employee employee)
    : ICommand
{
    private readonly IEmployeeManagerRepository _repository = repository;
    private int _managerId = managerId;
    private Employee _employee = employee;

    public AddEmployeeMemento CreateMemento()
    {
        return new AddEmployeeMemento(_managerId, _employee);
    }

    public void RestoreMemento(AddEmployeeMemento memento)
    {
        _managerId = memento.ManagerId;
        _employee = memento.Employee;
    }

    public void Execute()
    {
        if (CanExecute())
        {
            _repository.AddEmployee(_managerId, _employee);
        }
    }

    public bool CanExecute()
    {
        return !_repository.HasEmployee(_managerId, _employee);
    }
}

/// <summary>
/// Invoker & Caretaker
/// </summary>
public class EmployeeManagerInvoker
{
    private readonly Stack<AddEmployeeMemento> _mementos = [];
    private AddEmployeeCommand? _command;

    public void Invoke(ICommand command)
    {
        // if the command has not been stored yet, store it - we will
        // reuse it instead of storing multiple instances
        if (_command is null && command is AddEmployeeCommand addEmployeeCommand)
        {
            _command = addEmployeeCommand;
        }

        if (command.CanExecute())
        {
            command.Execute();
            if (_command is not null)
            {
                _mementos.Push(_command.CreateMemento());
            }
        }
    }

    public void Undo()
    {
        if (_command is null || _mementos.Count == 0) return;
        var memento = _mementos.Pop();
        _command.RestoreMemento(memento);
        // undo by removing the employee
        _command.Execute();
    }

    public void UndoAll()
    {
        while (_mementos.Count > 0)
        {
            Undo();
        }
    }
}