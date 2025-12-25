namespace Singleton;

/// <summary>
/// Singleton
/// </summary>
public class Logger
{
    // Lazy<T>
    private static readonly Lazy<Logger> _lazyLogger
        = new(() => new Logger());

    //private static Logger? _instance;

    /// <summary>
    /// Instance
    /// </summary>
    public static Logger Instance => _lazyLogger.Value;

    protected Logger()
    {
    }

    /// <summary>
    /// SingletonOperation
    /// </summary>
    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}