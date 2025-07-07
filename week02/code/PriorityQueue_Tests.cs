using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 4 items with varying priorities: D (priority 4), N (priority 2), A (priority 4), Y (priority 1). 
    // Expected Result: ("D, "A", "N", "Y") Dequeue should return item with the highest priority first and if multiples items have the same priority, return the one added earliest.
    // Defect(s) Found: The original Dequeue method skipped checking the last item (`index < _queue.Count -1`) and incorrectly updated the index when priorities were equal, breaking FIFO order or logic.
    // Fix: I removed the off-by-one loop condition (`index < _queue.Count -1`) and changed it to `index < _queue.Count` so all items are checked. I also changed the comparison from 
    // `>=` to just `>` so that when priorities are equal , the first added (earlier) item is preserved.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("D", 4);
        priorityQueue.Enqueue("N", 2);
        priorityQueue.Enqueue("A", 4);
        priorityQueue.Enqueue("Y", 1);

        Assert.AreEqual("D", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("N", priorityQueue.Dequeue());
        Assert.AreEqual("Y", priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: Add 4 items with the same priority to verify FIFO Behavior among equals: L (priority 10), O (priority 10), R (priority 10), D (priority 10). As we see all have equal priority and therefore, Dequeue should return items in their original insertion order.
    // Expected Result: Dequeue returns "L", then "O", then "R", and then "D".
    // Defect(s) Found: The original Dequeue logic used `>=` which updated the index even when priorities were equal, causing later items to be dequeued first and breaking FIFO order or logic.
    // Fix: I changed the comparison from `>=` to `>` so that if priorities are equal, the earlier-added item remains selected.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("L", 10);
        priorityQueue.Enqueue("O", 10);
        priorityQueue.Enqueue("R", 10);
        priorityQueue.Enqueue("D", 10);

        Assert.AreEqual("L", priorityQueue.Dequeue());
        Assert.AreEqual("O", priorityQueue.Dequeue());
        Assert.AreEqual("R", priorityQueue.Dequeue());
        Assert.AreEqual("D", priorityQueue.Dequeue());


    }

    // Add more test cases as needed below.
}