namespace ParseTree;

/// <summary>
/// Abstract class for operations.
/// </summary>
public abstract class Operation : INode
{
    /// <summary>
    /// Gets and sets the left child node for this node.
    /// </summary>
    public INode LeftChild { get; set; }
    
    /// <summary>
    /// Gets and sets the right child node for this node.
    /// </summary>
    public INode RightChild { get; set; }

    /// <summary>
    /// Prints node to console.
    /// </summary>
    public virtual void Print()
    {
        LeftChild.Print();
        RightChild.Print();
    }

    /// <summary>
    /// Calculates value of node.
    /// </summary>
    /// <returns>result of calculations. </returns>
    public abstract int Calculate();
}

/// <summary>
/// Class for addition operation.
/// </summary>
public class Addition : Operation
{
    /// <summary>
    /// Prints node to console.
    /// </summary>
    public override void Print()
    {
        Console.Write("( + ");
        base.Print();
        Console.Write(") ");
    }

    /// <summary>
    /// Calculates value of node.
    /// </summary>
    /// <returns>result of calculations. </returns>
    public override int Calculate()
    {
        return LeftChild.Calculate() + RightChild.Calculate();
    }
    
}

/// <summary>
/// Class for subtraction operation.
/// </summary>
public class Subtraction : Operation
{
    /// <summary>
    /// Prints node to console.
    /// </summary>
    public override void Print()
    {
        Console.Write("( - ");
        base.Print();
        Console.Write(") ");
    }
    
    /// <summary>
    /// Calculates value of node.
    /// </summary>
    /// <returns>result of calculations. </returns>
    public override int Calculate()
    {
        return LeftChild.Calculate() - RightChild.Calculate();
    }
}

/// <summary>
/// Class for multiplication operation.
/// </summary>
public class Multiplication : Operation
{
    /// <summary>
    /// Prints node to console.
    /// </summary>
    public override void Print()
    {
        Console.Write("( * ");
        base.Print();
        Console.Write(") ");
    }
    
    /// <summary>
    /// Calculates value of node.
    /// </summary>
    /// <returns>result of calculations. </returns>
    public override int Calculate()
    {
        return LeftChild.Calculate() * RightChild.Calculate();
    }
}

/// <summary>
/// Class for division operation.
/// </summary>
public class Division : Operation
{
    /// <summary>
    /// Prints node to console.
    /// </summary>
    public override void Print()
    {
        Console.Write("( / ");
        base.Print();
        Console.Write(") ");
    }
    
    /// <summary>
    /// Calculates value of node.
    /// </summary>
    /// <returns>result of calculations. </returns>
    public override int Calculate()
    {
        return LeftChild.Calculate() / RightChild.Calculate();
    }
}