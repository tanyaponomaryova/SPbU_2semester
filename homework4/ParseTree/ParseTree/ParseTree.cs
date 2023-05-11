namespace ParseTree;

/// <summary>
///     Class for building, calculation and printing parse tree.
/// </summary>
public class ParseTree
{
    private INode root;

    /// <summary>
    ///     Initializes parse tree.
    /// </summary>
    /// <param name="expression">expression for parse tree.</param>
    public ParseTree(string expression)
    {
        var tokens = expression.Split(new[] { ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        var position = -1;
        root = NewNode();

        INode NewNode()
        {
            position++;
            if (position >= tokens.Length) throw new ArgumentException("Expression is not full.");

            if (int.TryParse(tokens[position], out var number)) return new Operand(number);

            Operation newNode = tokens[position] switch
            {
                "+" => new Addition(),
                "-" => new Subtraction(),
                "*" => new Multiplication(),
                "/" => new Division(),
                _ => throw new ArgumentException("There are incorrect symbols in the expression. It can only contain integers, signs of operations and round brackets")
            };

            newNode.LeftChild = NewNode();
            newNode.RightChild = NewNode();
            return newNode;
        }

        if (position != tokens.Length - 1)
            throw new ArgumentException("The expression contains extra operations and operands that were not included in the parse tree.");
    }

    /// <summary>
    ///     Prints parse tree.
    /// </summary>
    public void Print()
    {
        root.Print();
    }

    /// <summary>
    ///     Calculates value of parse tree.
    /// </summary>
    /// <returns>result of calculation.</returns>
    public float Calculate()
    {
        return root.Calculate();
    }
}