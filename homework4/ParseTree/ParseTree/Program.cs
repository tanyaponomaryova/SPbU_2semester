namespace ParseTree;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter path to file with expression for parse tree: ");
        var path = Console.ReadLine();
        if (path == null)
        {
            Console.WriteLine("Input error occured.");
            return;
        }

        if (!File.Exists(path))
        {
            Console.WriteLine("File path is invalid.");
            return;
        }

        var expressionForParseTree = File.ReadAllText(path);
        Console.WriteLine("Expression from file: " + expressionForParseTree);
        try
        {
            var parseTree = new ParseTree(expressionForParseTree);
            var resultOfCalculation = parseTree.Calculate();
            Console.WriteLine($"Result of calculation {resultOfCalculation}.");
            Console.Write("Parse tree: ");
            parseTree.Print();
        }
        catch (Exception e)
        {
            Console.WriteLine("Following error occured: " + e.Message);
        }
    }
}