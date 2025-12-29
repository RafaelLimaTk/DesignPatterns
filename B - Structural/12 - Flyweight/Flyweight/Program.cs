using Flyweight;

Console.Title = "Flyweight pattern";

string aBunchOfCharacters = "abba";
var factory = new CharacterFactory();

//get the flyweight(s)
var characters = aBunchOfCharacters
    .Select(c => factory.GetCharacter(c))
    .ToList();
characters.ForEach(draw =>
{
    string[] font = ["Arial", "Times New Roman", "Courier New"];
    int[] sizes = [10, 12, 14, 16, 18];

    var random = new Random();
    draw.Draw(
        fontFamily: font[random.Next(0, font.Length)],
        fontSize: sizes[random.Next(0, sizes.Length)]);
});

//create unshared concrete flyweights (paragraph)
var paragraph = factory.CreateParagraph(
    location: 1,
    characters: characters);

paragraph.Draw("Verdana", 20);

Console.ReadKey();