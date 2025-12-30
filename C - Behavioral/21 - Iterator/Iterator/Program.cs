using Iterator;

Console.Title = "Iterator pattern";

PeopleCollection people =
[
    new Person("Kevin Dockx", "Belgium"),
    new Person("Anna", "UK"),
    new Person("Hans", "Germany"),
    new Person("Maria", "Italy"),
];

// create iterator
var peopleIterator = people.CreateIterator();

// use the  iterator to run through the collection
// in the collection; thay should come out
// in alphabetical order by name
for (var person = peopleIterator.First();
     !peopleIterator.IsDone;
     person = peopleIterator.Next())
{
    Console.WriteLine($"{person.Name} from {person.Country}");
}

Console.ReadKey();
