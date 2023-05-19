using PriorityQueue;

namespace PriorityQueueTests;

public class Tests
{
    [Test]
    public void CorrectWorkOfEnqueue()
    {
        PriorityQueue<string> priorityQueue = new PriorityQueue<string>();
        
        priorityQueue.Enqueue("large", 10);
        priorityQueue.Enqueue("little", 1);
        priorityQueue.Enqueue("middle", 5);
        priorityQueue.Enqueue("largest", 100);
        
        Assert.True(priorityQueue.Dequeue() == "largest");
        Assert.True(priorityQueue.Dequeue() == "large");
        Assert.True(priorityQueue.Dequeue() == "middle");
        Assert.True(priorityQueue.Dequeue() == "little");
    }

    [Test]
    public void DequeueThrowsExceptionWhenQueueIsEmpty()
    {
        PriorityQueue<string> priorityQueue = new PriorityQueue<string>();
        Assert.Throws<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}