namespace ParseTree;

internal class Program
{
    public static void Main()
    {
        string expressionForParseTree = File.ReadAllText(@"..\..\..\expression.txt");
        Console.WriteLine($"Expression from file: " + expressionForParseTree);
        ParseTree parseTree = new ParseTree(expressionForParseTree);
        var resultOfCalculation = parseTree.Calculate();
        Console.WriteLine($"Result of calculation {resultOfCalculation}.");
        Console.Write("Parse tree: ");
        parseTree.Print();
    }
}