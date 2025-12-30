namespace Mediator;

/// <summary>
/// Mediator
/// </summary>
public interface IChatRoom
{
    void Register(TeamMember teamMember);
    void Send(string from, string message);
}

/// <summary>
/// Colleague
/// </summary>
public abstract class TeamMember
{
    private IChatRoom? _chatRoom;
    public string Name { get; set; }

    public TeamMember(string name)
    {
        Name = name;
    }

    internal void SetChatroom(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public void Send(string message)
    {
        _chatRoom?.Send(Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"{from} to {Name}: {message}");
    }
}

public class Lawyer(string name)
    : TeamMember(name)
{
    public override void Receive(string from, string message)
    {
        Console.WriteLine($"{nameof(Lawyer)} {Name} received: ");
        base.Receive(from, message);
    }
}

public class AccountManager(string name)
    : TeamMember(name)
{
    public override void Receive(string from, string message)
    {
        Console.WriteLine($"{nameof(AccountManager)} {Name} received: ");
        base.Receive(from, message);
    }
}

/// <summary>
/// Concrete Mediator
/// </summary>
public class TeamChatRoom : IChatRoom
{
    private readonly Dictionary<string, TeamMember> _teamMembers = [];

    public void Register(TeamMember teamMember)
    {
        teamMember.SetChatroom(this);
        _teamMembers.TryAdd(teamMember.Name, teamMember);
    }

    public void Send(string from, string message)
        => _teamMembers.Values
            .Where(member => member.Name != from)
            .ToList()
            .ForEach(member => member.Receive(from, message));
}