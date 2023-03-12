namespace StackCalculator;

using System;

/// <summary>
///     Stack data structure based on array.
/// </summary>
public class StackArray : IStack
{
    private int amount;
    private float[] stackElements;

    /// <summary>
    ///     Creates a new object of class <see cref="StackArray" />.
    /// </summary>
    public StackArray()
    {
        stackElements = new float [16];
    }

    /// <summary>
    ///     Checks if the stack is empty.
    /// </summary>
    /// <returns>true if the stack is empty, else false.</returns>
    public bool IsEmpty()
    {
        return amount == 0;
    }

    /// <summary>
    ///     Adds element to the stack.
    /// </summary>
    /// <param name="value">is element you want to add.</param>
    public void Push(float value)
    {
        if (amount == stackElements.Length) Resize();

        stackElements[amount] = value;
        amount++;
    }

    /// <summary>
    ///     Gets element from the stack.
    /// </summary>
    /// <returns>element from the stack.</returns>
    /// <exception cref="InvalidOperationException">If the stack is empty.</exception>
    public float Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException();
        amount--;
        var value = stackElements[amount];
        stackElements[amount] = 0;
        return value;
    }

    /// <summary>
    ///     Empties the stack.
    /// </summary>
    public void Clear()
    {
        stackElements = new float[16];
        amount = 0;
    }

    private void Resize()
    {
        Array.Resize(ref stackElements, stackElements.Length * 2);
    }
}