using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibility;

public class Document
{
    public string Title { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public bool ApprovedByLitigation { get; set; }
    public bool ApprovedByManagement { get; set; }

    public Document(
        string title,
        DateTimeOffset lastModified,
        bool approvedByLitigation,
        bool approvedByManagement)
    {
        Title = title;
        LastModified = lastModified;
        ApprovedByLitigation = approvedByLitigation;
        ApprovedByManagement = approvedByManagement;
    }
}

/// <summary>
/// Handler
/// </summary>
public interface IHandler<T> where T : class
{
    IHandler<T> SetSuccessor(IHandler<T> successor);
    void Handle(T request);
}

/// <summary>
/// Concrete Handler
/// </summary>
public class DocumentTitleHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;

    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return successor;
    }

    public void Handle(Document document)
    {
        if (string.IsNullOrEmpty(document.Title))
        {
            // validation doesn't check out
            throw new ValidationException(
                new ValidationResult(
                    "Title must be filled out",
                    ["Title"]), null, null);
        }
        // go to the next handler
        _successor?.Handle(document);
    }
}

/// <summary>
/// Concrete Handler
/// </summary>
public class DocumentLastModifiedHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;

    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return successor;
    }

    public void Handle(Document document)
    {
        if (document.LastModified < DateTimeOffset.UtcNow.AddDays(-30))
        {
            // validation doesn't check out
            throw new ValidationException(
                new ValidationResult(
                    "Document is outdated",
                    ["LastModified"]), null, null);
        }
        // go to the next handler
        _successor?.Handle(document);
    }
}

/// <summary>
/// Concrete Handler
/// </summary>
public class DocumentLitigationApprovalHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;

    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return successor;
    }

    public void Handle(Document document)
    {
        if (!document.ApprovedByLitigation)
        {
            // validation doesn't check out
            throw new ValidationException(
                new ValidationResult(
                    "Document must be approved by litigation",
                    ["ApprovedByLitigation"]), null, null);
        }
        // go to the next handler
        _successor?.Handle(document);
    }
}

/// <summary>
/// Concrete Handler
/// </summary>
public class DocumentManagementApprovalHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;

    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return successor;
    }

    public void Handle(Document document)
    {
        if (!document.ApprovedByManagement)
        {
            // validation doesn't check out
            throw new ValidationException(
                new ValidationResult(
                    "Document must be approved by management",
                    ["ApprovedByManagement"]), null, null);
        }
        // go to the next handler
        _successor?.Handle(document);
    }
}