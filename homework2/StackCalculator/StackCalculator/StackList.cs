namespace StackCalculator;

using System;

/// <summary>
///     Stack data structure based on linked list.
/// </summary>
public class StackList : IStack
{
    private StackElement? top;

    /// <summary>
    ///     Checks if the stack is empty.
    /// </summary>
    /// <returns>true if the stack is empty, else false.</returns>
    public bool IsEmpty()
    {
        return top == null;
    }

    /// <summary>
    ///     Adds element to the stack.
    /// </summary>
    /// <param name="value">is element you want to add.</param>
    public void Push(float value)
    {
        top = new StackElement(value, top);
    }

    /// <summary>
    ///     Gets element from the stack.
    /// </summary>
    /// <returns>element from the stack.</returns>
    /// <exception cref="InvalidOperationException">If the stack is empty.</exception>
    public float Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException();
        var value = top!.Value;
        top = top.Next;
        return value;
    }

    /// <summary>
    ///     Empties the stack.
    /// </summary>
    public void Clear()
    {
        top = null;
    }

    private class StackElement
    {
        public StackElement(float value, StackElement? next)
        {
            Value = value;
            Next = next;
        }

        public float Value { get; }
        public StackElement? Next { get; }
    }
}