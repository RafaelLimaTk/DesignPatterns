namespace Flyweight;

/// <summary>
/// Flyweight interface
/// </summary>
public interface ICharacter
{
    void Draw(string fontFamily, int fontSize);
}

/// <summary>
/// Concrete Flyweight
/// </summary>
public class CharacterA : ICharacter
{
    private readonly char _actualCaracter = 'a';
    private string _fontFamily = string.Empty;
    private int _fontSize;

    public void Draw(string fontFamily, int fontSize)
    {
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        Console.WriteLine($"Drawing '{_actualCaracter}' with font '{fontFamily}' and size {fontSize}");
    }
}

/// <summary>
/// Concrete Flyweight
/// </summary>
public class CharacterB : ICharacter
{
    private readonly char _actualCaracter = 'b';
    private string _fontFamily = string.Empty;
    private int _fontSize;

    public void Draw(string fontFamily, int fontSize)
    {
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        Console.WriteLine($"Drawing '{_actualCaracter}' with font '{fontFamily}' and size {fontSize}");
    }
}

/// <summary>
/// Flyweight Factory
/// </summary>
public class CharacterFactory
{
    private readonly Dictionary<char, ICharacter> _characters = [];

    public ICharacter GetCharacter(char key)
    {
        if (!_characters.TryGetValue(key, out ICharacter? value))
        {
            ICharacter character = key switch
            {
                'a' => new CharacterA(),
                'b' => new CharacterB(),
                _ => throw new NotSupportedException($"Character '{key}' is not supported.")
            };
            value = character;
            _characters[key] = value;
        }
        return value;
    }

    public ICharacter CreateParagraph(int location, List<ICharacter> characters)
        => new Paragraph(location, characters);
}

/// <summary>
/// Flyweight Factory
/// </summary>
public class Paragraph : ICharacter
{
    private readonly int _location;
    private readonly List<ICharacter> _characters = [];

    public Paragraph(int location, List<ICharacter> characters)
    {
        _location = location;
        _characters = characters;
    }

    public void Draw(string fontFamily, int fontSize)
    {
        Console.WriteLine($"Drawing in paragraph at location {_location}");
        _characters.ForEach(c => c.Draw(fontFamily, fontSize));
    }
}