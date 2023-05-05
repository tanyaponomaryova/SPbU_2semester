using System.Collections;

namespace SkipList;

public class SkipList<T> : IList<T> where T : IComparable<T>
{
    private class Node
    {
        public Node(T value, Node[] nextNodes)
        {
            Value = value;
            this.nextNodes = nextNodes;
        }
        public T Value { get; set; }
        public Node[] nextNodes;
    }
    
    private Node header;
    private Node tail;
    public SkipList()
    {
        tail = new Node(default, Array.Empty<Node>());
        header = new Node(default, new Node[1] { tail });
    }
    public int Count { get; private set; }

    private Node[] GetPreviousNodes(T value)
    {
        var currentNode = header;
        var lastNodeOnCurrentLevel = new Node[header.nextNodes.Length]; // последний узел на текущем уровне (количество = количество уровней во всем листе)

        for (int currentLevel = header.nextNodes.Length - 1; currentLevel >= 0; currentLevel--)
        {
            var compareResult = value.CompareTo(currentNode.nextNodes[currentLevel].Value);
            while (compareResult == 1 && currentNode.nextNodes[currentLevel] != tail)
            {
                currentNode = currentNode.nextNodes[currentLevel];
                compareResult = value.CompareTo(currentNode.nextNodes[currentLevel].Value);
            }

            lastNodeOnCurrentLevel[currentLevel] = currentNode;
        }

        return lastNodeOnCurrentLevel;
    }

    private int GetRandomNodeHeight()
    {
        var random = new Random();
        int currentHeight = 1;
        while (currentHeight <= header.nextNodes.Length)
        {
            int increase = random.Next(0, 2);
            if (increase == 0)
            {
                break;
            }

            currentHeight++;
        }

        return currentHeight;
    }
    
    public bool Contains(T value)
    {
        Node[] previousNodes = GetPreviousNodes(value);
        return previousNodes[0].nextNodes[0] != tail && value.CompareTo(previousNodes[0].nextNodes[0].Value) == 0;
    }

    public void Add(T value)
    {
        Node[] previousNodes = GetPreviousNodes(value);
        int newNodeHeight = GetRandomNodeHeight();
        var newNode = new Node(value, new Node[newNodeHeight]);
        for (int i = 0; i < newNodeHeight && i < header.nextNodes.Length; i++)
        {
            newNode.nextNodes[i] = previousNodes[i].nextNodes[i];
            previousNodes[i].nextNodes[i] = newNode.nextNodes[i];
        }

        if (newNodeHeight > header.nextNodes.Length)
        {
            newNode.nextNodes[newNodeHeight - 1] = tail;
        }

        Count++;
    }

    public void Clear()
    {
        header.nextNodes = new Node[1]{ tail };
        Count = 0;
    }
    
    public bool Remove(T value)
    {
        var previousNodes = GetPreviousNodes(value);
        var nextNode = previousNodes[0].nextNodes[0];
        
        if (nextNode != tail && value.CompareTo(nextNode.Value) == 0)
        {
            for (int i = 0; i < nextNode.nextNodes.Length; ++i)
            {
                previousNodes[i].nextNodes[i] = nextNode.nextNodes[i];
            }

            --Count;
            return true;
        }

        return false;
    }
    
    public void CopyTo(T[] array, int arrayIndex)
    {
        if (array.Length - arrayIndex < Count)
        {
            throw new ArgumentException(); // сщщбщение
        }

        var currentNode = header;
        for (var currentIndex = arrayIndex; currentNode != tail; currentIndex++)
        {
            array[currentIndex] = currentNode.Value;
            currentNode = currentNode.nextNodes[0];
        }
    }

    public void Insert(int index, T item)
    {
        throw new NotSupportedException();
    }

    public bool IsReadOnly
    {
        get => false;
    }

    public T this[int index]
    {
        get
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var currentNode = header;
            for (var i = 0; i < index; i++)
            {
                currentNode = currentNode.nextNodes[0];
            }

            return currentNode.Value;
        }
        
        set => throw new NotSupportedException();
    }

    public int IndexOf(T value)
    {
        var currentNode = header.nextNodes[0];
        
        for (int i = 0; i < Count; i++)
        {
            if (value.CompareTo(currentNode.Value) == 0)
            {
                return i;
            }

            currentNode = currentNode.nextNodes[0];
        }

        return -1;
    }
    
    public void RemoveAt(int index)
    {
        Remove(this[index]);
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        return new SkipListEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public class SkipListEnumerator : IEnumerator<T>
    {
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public T Current { get; }

        object IEnumerator.Current => Current; // происходит распаковка??

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}