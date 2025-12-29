namespace Decorator;

/// <summary>
/// Component (As Interface)
/// </summary>
public interface IMailService
{
    bool SendEmail(string message);
}

/// <summary>
/// Concrete Component
/// </summary>
public class CloudMailService : IMailService
{
    public bool SendEmail(string message)
    {
        Console.WriteLine($"Message \"{message}\" " +
            $"sent via {nameof(CloudMailService)}");
        return true;
    }
}

/// <summary>
/// Concrete Component
/// </summary>
public class OnPremiseMailService : IMailService
{
    public bool SendEmail(string message)
    {
        Console.WriteLine($"Message \"{message}\" " +
            $"sent via {nameof(OnPremiseMailService)}");
        return true;
    }
}

/// <summary>
/// Decorator
/// </summary>
public abstract class MailServiceDecoratorBase : IMailService
{
    protected readonly IMailService _mailService;

    public MailServiceDecoratorBase(IMailService mailService)
        => _mailService = mailService;

    public virtual bool SendEmail(string message)
    {
        return _mailService.SendEmail(message);
    }
}

/// <summary>
/// Concrete Decorator
/// </summary>
public class StatisticsDecorator(IMailService mailService)
    : MailServiceDecoratorBase(mailService)
{
    public override bool SendEmail(string message)
    {
        Console.WriteLine($"Collection statistics in: {nameof(StatisticsDecorator)}");
        return base.SendEmail(message);
    }
}

/// <summary>
/// Concrete Decorator
/// </summary>
public class MessageDatabaseDecorator(IMailService mailService)
    : MailServiceDecoratorBase(mailService)
{
    public List<string> SentMessages { get; private set; } = [];

    public override bool SendEmail(string message)
    {
        if (base.SendEmail(message))
        {
            SentMessages.Add(message);
            return true;
        }

        return false;
    }
}