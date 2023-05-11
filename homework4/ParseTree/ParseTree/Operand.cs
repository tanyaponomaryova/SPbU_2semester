namespace ParseTree;

/// <summary>
///     Class for operands.
/// </summary>
public class Operand : INode
{
    /// <summary>
    ///     Initializes operand node.
    /// </summary>
    /// <param name="value">value of operand node.</param>
    public Operand(int value)
    {
        Value = value;
    }

    /// <summary>
    ///     Gets and sets operand's value.
    /// </summary>
    public float Value { get; set; }

    /// <summary>
    ///     Prints node's value.
    /// </summary>
    public void Print()
    {
        Console.Write($"{Value} ");
    }

    /// <summary>
    ///     Calculates value of node.
    /// </summary>
    /// <returns>value of operand.</returns>
    public float Calculate()
    {
        return Value;
    }
}