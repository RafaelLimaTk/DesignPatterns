namespace Composite;

/// <summary>
/// Component
/// </summary>
public abstract class FileSystemItem
{
    public string Name { get; set; }
    public abstract long GetSize();

    protected FileSystemItem(string name)
    {
        Name = name;
    }
}

/// <summary>
/// Leaf
/// </summary>
public class File : FileSystemItem
{
    private readonly long _size;

    public File(string name, long size)
        : base(name)
    {
        _size = size;
    }

    public override long GetSize()
    {
        return _size;
    }
}

/// <summary>
/// Composite
/// </summary>
public class Directory : FileSystemItem
{
    private readonly List<FileSystemItem> _fileSystemItems = [];

    private readonly long _size;

    public Directory(string name, long size)
        : base(name)
    {
        _size = size;
    }

    public void Add(FileSystemItem fileSystemItem)
        => _fileSystemItems.Add(fileSystemItem);

    public void Remove(FileSystemItem fileSystemItem)
        => _fileSystemItems.Remove(fileSystemItem);

    public override long GetSize()
    {
        var treeSize = _size;
        _fileSystemItems.ForEach(file => treeSize += file.GetSize());
        return treeSize;
    }
}