namespace PriorityQueue;

/// <summary>
/// Claas that implements a priority queue based on a binary heap data structure.
/// </summary>
/// <typeparam name="TValue"> type of values in priority queue. </typeparam>
public class PriorityQueue<TValue>
{
    private class Element
    {
        public TValue Value { get; set; }
        public int Priority { get; set; }

        public Element(TValue value, int priority)
        {
            Value = value;
            Priority = priority;
        }
    }

    private List<Element> list = new List<Element>();
    /// <summary>
    /// Number of elements in priority queue.
    /// </summary>
    public int HeapSize
    {
        get { return list.Count; }
    }

    /// <summary>
    /// Is priority queue empty.
    /// </summary>
    public bool Empty
    {
        get { return HeapSize == 0; }
    }

    /// <summary>
    /// Method for adding elements in priority queue.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="priority"></param>
    public void Enqueue(TValue value, int priority)
    {
        list.Add(new Element(value, priority)); // добаивли элемент в конец очереди на позицию Size
        int addedElementIndex = HeapSize - 1;
        int parentNodeIndex = (addedElementIndex - 1) / 2;
        while (addedElementIndex > 0 && list[parentNodeIndex].Priority < list[addedElementIndex].Priority)
        {
            // меняем местами роидтеля и ребенка
            (list[addedElementIndex], list[parentNodeIndex]) = (list[parentNodeIndex], list[addedElementIndex]);
            

            addedElementIndex = parentNodeIndex;
            parentNodeIndex = (addedElementIndex - 1) / 2;
        }
    }
    
    /// <summary>
    /// Method for getting element with max priority from priority queue.
    /// </summary>
    /// <returns>value of element with max priority.</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public TValue Dequeue()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Priority queue is empty.");
        }
        
        TValue valueToReturn = list[0].Value;
        list[0] = list[HeapSize - 1];
        list.RemoveAt(HeapSize - 1);
        
        //headify для корня
        int currentAddedNodeIndex = 0;
        for (;;)
        {
            int largestNodeIndex = currentAddedNodeIndex;
            int leftChildIndex = 2 * largestNodeIndex + 1;
            int rightChildIndex = 2 * largestNodeIndex + 2;
            if (leftChildIndex < HeapSize && list[leftChildIndex].Priority > list[largestNodeIndex].Priority)
            {
                largestNodeIndex = leftChildIndex;
            }
            
            if (rightChildIndex < HeapSize && list[rightChildIndex].Priority > list[largestNodeIndex].Priority)
            {
                largestNodeIndex = rightChildIndex;
            }

            if (largestNodeIndex == currentAddedNodeIndex)
            {
                break;
            }

            (list[currentAddedNodeIndex], list[largestNodeIndex]) = (list[largestNodeIndex], list[currentAddedNodeIndex]);
            currentAddedNodeIndex = largestNodeIndex;
        }
        
        return valueToReturn;
    }
}