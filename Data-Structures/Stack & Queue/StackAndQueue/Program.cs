namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Example for Stack
            Stack stack = new Stack();
            stack.Push(10); // Stack: Top -> 10
            stack.Push(5);  // Stack: Top -> 5 -> 10
            Console.WriteLine($"Popped: {stack.Pop()}"); // Popped: 5
            Console.WriteLine($"Peeked: {stack.Peek()}"); // Peeked: 10
            Console.WriteLine($"Is Empty: {stack.IsEmpty()}"); // Is Empty: False
            stack.Print(); // Prints: 10

            // Example for Queue
            Queue queue = new Queue();
            queue.Enqueue(10); // Queue: 10
            queue.Enqueue(5);  // Queue: 10 -> 5
            Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Dequeued: 10
            Console.WriteLine($"Peeked: {queue.Peek()}"); // Peeked: 5
            Console.WriteLine($"Is Empty: {queue.IsEmpty()}"); // Is Empty: False
            queue.Print(); // Prints: 5
        }
    }
}
