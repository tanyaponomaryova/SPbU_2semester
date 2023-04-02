namespace UniqueList;

/// <summary>
/// Class that implements the unique list data structure - list without repeating values.
/// </summary>
public class UniqueList : OrdinaryList
{
    /// <summary>
    /// Adds value that is not present in the list.
    /// </summary>
    /// <param name="value">value of element to add.</param>
    /// <param name="position">position of element to add.</param>
    /// <exception cref="AddingExistingValueException">thrown when given value is already in the list.</exception>
    public override void AddByPosition(int value, int position)
    {
        if (Contains(value))
        {
            throw new AddingExistingValueException($"Value {value} is already in the list.");
        }
        
        base.AddByPosition(value, position);
    }

    /// <summary>
    /// Changes value of element on given position.
    /// </summary>
    /// <param name="newValue">new value to set.</param>
    /// <param name="position">position of element which value is to be changed.</param>
    /// <exception cref="AddingExistingValueException">thrown when given value is already in the list.</exception>
    public override void ChangeValueByPosition(int newValue, int position)
    {
        if (Contains(newValue))
        {
            if (position == PositionOf(newValue))
            {
                return;
            }

            throw new AddingExistingValueException($"Value {newValue} is already in the list.");
        }
        
        base.ChangeValueByPosition(newValue, position);
    }
}