namespace Functions;

/// <summary>
/// Class containing function Map, Filter and Fold.
/// </summary>
public static class Functions
{
    /// <summary>
    /// Returns new list of elements from given list applying given function to all elements.
    /// </summary>
    /// <param name="list">list to modify.</param>
    /// <param name="operation">function to appply.</param>
    /// <typeparam name="T">type of list element.</typeparam>
    /// <typeparam name="TResult">return type of given function and type of elements in modified list.</typeparam>
    /// <returns>modified list.</returns>
    public static List<TResult> Map<T, TResult>(List<T> list, Func<T, TResult> operation)
    {
        var modifiedList = new List<TResult>();
        foreach (var element in list)
        {
            modifiedList.Add(operation(element));
        }

        return modifiedList;
    }
    
    /// <summary>
    /// Creates new listof elements from given list for which given function returned true.
    /// </summary>
    /// <param name="list">list to modify.</param>
    /// <param name="condition">function that returns boolean value.</param>
    /// <typeparam name="T">type of elements in initial list.</typeparam>
    /// <returns>modified list.</returns>
    public static List<T> Filter<T>(List<T> list, Predicate<T> condition)
    {
        var modifiedList = new List<T>();
        foreach (var element in list)
        {
            if (condition(element))
            {
                modifiedList.Add(element);
            }
        }

        return modifiedList;
    }
    
    /// <summary>
    /// Returns the accumulated value after the entire list pass.
    /// </summary>
    /// <param name="list">list to pass.</param>
    /// <param name="initialValue">initial value.</param>
    /// <param name="operation">function that returns new accumulated value.</param>
    /// <typeparam name="T">type of elements in list.</typeparam>
    /// <typeparam name="TValue">type of initial and accumulated value.</typeparam>
    /// <returns>accumulated value.</returns>
    public static TValue Fold<T, TValue>(List<T> list, TValue initialValue, Func<TValue, T, TValue> operation)
    {
        TValue result = initialValue;
        foreach (var element in list)
        {
            result = operation(result, element);
        }

        return result;
    }
}