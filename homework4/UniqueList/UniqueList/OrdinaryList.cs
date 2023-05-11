namespace UniqueList;

/// <summary>
/// Class that implements the list data structure.
/// </summary>
public class OrdinaryList
{
    private Node? head;

    private class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public Node? Next { get; set; }
    }

    /// <summary>
    /// Number of elements in the list.
    /// </summary>
    public int Size { get; private set; }

    /// <summary>
    /// Adds element to the list by position.
    /// </summary>
    /// <param name="value">element to add.</param>
    /// <param name="position">position of new element.</param>
    /// <exception cref="InvalidPositionException">if position is negative or
    /// greater than the number of element in the list.</exception>
    public virtual void AddByPosition(int value, int position)
    {
        if (position < 0 || position > Size)
        {
            throw new InvalidPositionException("Position of element to add cannot be negative or bigger than size of the list.");
        }

        Size++;

        Node? previousNode = null;
        var currentNode = head;
        for (var i = 0; i < position; i++)
        {
            previousNode = currentNode;
            currentNode = currentNode!.Next;
        }

        var newNode = new Node(value);
        if (previousNode != null)
        {
            previousNode.Next = newNode;
            newNode.Next = currentNode;
        }
        else
        {
            head = newNode;
            newNode.Next = currentNode;
        }
    }

    /// <summary>
    /// Removes element by value.
    /// </summary>
    /// <param name="value">value to remove.</param>
    /// <returns>true if value was removed, else false.</returns>
    public void RemoveByValue(int value)
    {
        var currentNode = head;
        if (currentNode == null)
        {
            throw new RemovingNonExistingValueException("You cannot remove elements from an empty list.");
        }

        if (currentNode.Value == value)
        {
            head = currentNode.Next;
            Size--;
            return;
        }

        while (currentNode!.Next != null)
        {
            if (currentNode.Next.Value == value)
            {
                currentNode.Next = currentNode.Next.Next;
                Size--;
                return;
            }

            currentNode = currentNode.Next;
        }

        throw new RemovingNonExistingValueException($"List doesn't contain {value}.");
    }

    /// <summary>
    /// Removes value by given position.
    /// </summary>
    /// <param name="position">position of value to remove.</param>
    /// <exception cref="InvalidPositionException">if position is negative or
    /// greater than size of the list - 1.</exception>
    public void RemoveByPosition(int position)
    {
        if (position < 0 || position > Size - 1)
        {
            throw new InvalidPositionException("Position of element to remove cannot be negative or bigger than size of the list - 1.");
        }

        Size--;
        if (position == 0)
        {
            head = head!.Next;
            return;
        }

        var currentNode = head;
        for (var i = 0; i < position - 1; i++) currentNode = currentNode!.Next;

        currentNode!.Next = currentNode.Next!.Next;
    }

    /// <summary>
    /// Changes value of element on given position.
    /// </summary>
    /// <param name="newValue">new value.</param>
    /// <param name="position">position of element which value is to be changed.</param>
    /// <returns></returns>
    /// <exception cref="InvalidPositionException">if position is negative or
    /// greater than size of the list.</exception>
    public virtual void ChangeValueByPosition(int newValue, int position)
    {
        if (position < 0 || position > Size - 1)
        {
            throw new InvalidPositionException("Position of element to change cannot be negative or bigger than size of the list - 1.");
        }

        var currentNode = head;
        for (var i = 0; i < position; i++) currentNode = currentNode!.Next;

        currentNode!.Value = newValue;
    }

    /// <summary>
    /// Checks if element with given value is in the list.
    /// </summary>
    /// <param name="value">value to check for presence.</param>
    /// <returns>true if element with given value is in the list, else false.</returns>
    public bool Contains(int value)
    {
        var currentNode = head;
        for (var i = 0; i < Size; i++)
        {
            if (currentNode!.Value == value)
            {
                return true;
            }

            currentNode = currentNode.Next;
        }

        return false;
    }

    /// <summary>
    /// Determines position of element with given value.
    /// </summary>
    /// <param name="value">value of element which position to determine.</param>
    /// <returns>position of value if value is in the list, else -1.</returns>
    public int PositionOf(int value)
    {
        var currentNode = head;
        for (var i = 0; i < Size; i++)
        {
            if (currentNode!.Value == value) return i;

            currentNode = currentNode.Next;
        }

        return -1;
    }
}