namespace StackCalculator;

/// <summary>
///     Interface to work with stack.
/// </summary>
public interface IStack
{
    /// <summary>
    ///     Checks if the stack is empty.
    /// </summary>
    /// <returns>true if the stack is empty, else false.</returns>
    bool IsEmpty();

    /// <summary>
    ///     Adds element to the stack.
    /// </summary>
    /// <param name="value">is element you want to add.</param>
    void Push(float value);

    /// <summary>
    ///     Gets element from the stack.
    /// </summary>
    /// <returns>element from the stack.</returns>
    float Pop();

    /// <summary>
    ///     Empties the stack.
    /// </summary>
    void Clear();
}