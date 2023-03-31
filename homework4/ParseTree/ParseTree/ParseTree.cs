namespace ParseTree;

/// <summary>
/// Class for building, calculation and printing parse tree.
/// </summary>
public class ParseTree
{
    private INode root;

    /// <summary>
    /// Initializes parse tree.
    /// </summary>
    /// <param name="expression">expression for parse tree.</param>
    public ParseTree(string expression)
    {
        Build(expression);
    }

    private void Build(string expression)
    {
        var values = expression.Split(new char[] { ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        var position = -1;
        root = NewNode();

        INode NewNode()
        {
            position++;
            if (int.TryParse(values[position], out int number))
            {
                return new Operand(number);
            }

            Operation newNode = values[position] switch
            {
                "+" => new Addition(),
                "-" => new Subtraction(),
                "*" => new Multiplication(),
                "/" => new Subtraction(),
            };

            newNode.LeftChild = NewNode();
            newNode.RightChild = NewNode();
            return newNode;
        }
    }

    /// <summary>
    /// Prints parse tree.
    /// </summary>
    public void Print()
    {
        root.Print();
    }

    /// <summary>
    /// Calculates value of parse tree.
    /// </summary>
    /// <returns>result of calculation.</returns>
    public int Calculate()
    {
        return root.Calculate();
    }
}