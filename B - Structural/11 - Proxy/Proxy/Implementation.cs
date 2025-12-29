namespace Proxy;

/// <summary>
/// Subject
/// </summary>
public interface IDocument
{
    void Display();
}

/// <summary>
/// Realsubject
/// </summary>
public class Document : IDocument
{
    public string? Title { get; private set; }
    public string? Content { get; private set; }
    public int AuthorId { get; private set; }
    public DateTimeOffset LastAccessed { get; private set; }
    private readonly string _fileName;

    public Document(string fileName)
    {
        _fileName = fileName;
        LoadDocument(fileName);
    }

    private void LoadDocument(string fileName)
    {
        Console.WriteLine($"Executing expensive action: loading a {fileName} from disk...");
        Thread.Sleep(1000); // Simulate delay
        // For demonstration purposes, we'll just set some dummy data
        Title = "An expensive document";
        Content = "This is the content of the sample document.";
        AuthorId = 1;
        LastAccessed = DateTimeOffset.Now;
    }

    public void Display()
        => Console.WriteLine($"Title: {Title}, content: {Content}");
}

/// <summary>
/// Proxy
/// </summary>
public class DocumentProxy : IDocument
{
    private readonly Lazy<Document> _document;
    private readonly string _fileName;

    public DocumentProxy(string fileName)
    {
        _fileName = fileName;
        _document = new Lazy<Document>(() => new Document(_fileName));
    }

    public void Display()
        => _document.Value.Display();
}

/// <summary>
/// Proxy
/// </summary>
public class ProtectedDocumentProxy : IDocument
{
    private readonly string _fileName;
    private readonly string _userRole;
    private readonly DocumentProxy _documentProxy;

    public ProtectedDocumentProxy(string fileName, string userRole)
    {
        _fileName = fileName;
        _userRole = userRole;
        _documentProxy = new DocumentProxy(fileName);
    }

    public void Display()
    {
        Console.WriteLine("Entering DisplayDocument " +
            $"in {nameof(ProtectedDocumentProxy)}.");

        if (!_userRole.Equals("Viewer"))
            throw new UnauthorizedAccessException();

        _documentProxy.Display();

        Console.WriteLine("Existing DisplayDocument " +
            $"in {nameof(ProtectedDocumentProxy)}.");
    }
}