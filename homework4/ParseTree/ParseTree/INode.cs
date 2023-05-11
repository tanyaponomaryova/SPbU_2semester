namespace ParseTree;

/// <summary>
///     Interface for nodes of tree.
/// </summary>
public interface INode
{
    /// <summary>
    ///     Prints node to console.
    /// </summary>
    void Print();

    /// <summary>
    ///     Calculates value of node.
    /// </summary>
    /// <returns>result of calculations. </returns>
    float Calculate();
}