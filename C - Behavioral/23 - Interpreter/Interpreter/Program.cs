using Interpreter;

Console.Title = "Interpreter pattern";

List<RomanExpression> expression =
[
    new RomanHundredExpression(),
    new RomanTenExpression(),
    new RomanOneExpression(),
];

RomanContext context = new(5);
expression.ForEach(exp => exp.Interpret(context));
Console.WriteLine($"Translating Arabic numerals to Roman numerals: 5 = {context.Output}");

context = new(81);
expression.ForEach(exp => exp.Interpret(context));
Console.WriteLine($"Translating Arabic numerals to Roman numerals: 81 = {context.Output}");

context = new(764);
expression.ForEach(exp => exp.Interpret(context));
Console.WriteLine($"Translating Arabic numerals to Roman numerals: 764 = {context.Output}");

Console.ReadKey();