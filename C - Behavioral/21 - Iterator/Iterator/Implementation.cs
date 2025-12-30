namespace Iterator;

public class Person
{
    public string Name { get; set; }
    public string Country { get; set; }

    public Person(string name, string country)
    {
        Name = name;
        Country = country;
    }
}

/// <summary>
/// Iterator
/// </summary>
public interface IPeopleIterator
{
    Person First();
    Person Next();
    bool IsDone { get; }
    Person CurrentItem { get; }
}

/// <summary>
/// Aggregate
/// </summary>
public interface IPeopleCollection
{
    IPeopleIterator CreateIterator();
}

/// <summary>
/// Concrete Aggregate
/// </summary>
public class PeopleCollection : List<Person>, IPeopleCollection
{
    public IPeopleIterator CreateIterator()
        => new PeopleIterator(this);
}

/// <summary>
/// Concrete Iterator
/// </summary>
public class PeopleIterator(PeopleCollection peopleCollection)
    : IPeopleIterator
{
    private readonly PeopleCollection _peopleCollection = peopleCollection;
    private int _current = 0;

    public Person First()
    {
        _current = 0;
        return _peopleCollection
            .OrderBy(p => p.Name).ToList()[_current];
    }

    public Person Next()
    {
        _current++;
        return !IsDone ? _peopleCollection
            .OrderBy(p => p.Name).ToList()[_current] : null!;
    }

    public bool IsDone => _current >= _peopleCollection.Count;

    public Person CurrentItem => _peopleCollection
        .OrderBy(p => p.Name).ToList()[_current];
}