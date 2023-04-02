namespace UniqueList;

/// <summary>
/// Exception for a list data structure thrown when position argument is invalid. 
/// </summary>
public class InvalidPositionException : Exception
{
    public InvalidPositionException() {}

    public InvalidPositionException(string message) : base(message) {}
}

/// <summary>
/// Exception for a list data structure thrown when given value does not present in the list.
/// </summary>
public class RemovingNonExistingValueException : Exception
{
    public RemovingNonExistingValueException() {}

    public RemovingNonExistingValueException(string message) : base(message) {}
}

/// <summary>
/// Exception for a unique list data structure thrown when given value is already present in the list.
/// </summary>
public class AddingExistingValueException : Exception
{
    public AddingExistingValueException() {}

    public AddingExistingValueException(string message) : base(message) {}
}
