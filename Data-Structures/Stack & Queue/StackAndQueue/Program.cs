using System;
using StackAndQueue;
using StackAndQueue.ReverseStackUsingQueue;

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
            Console.WriteLine("Initial Stack:");
            stack.Print(); // Prints: 5 -> 10
            Console.WriteLine($"Popped: {stack.Pop()}"); // Popped: 5
            Console.WriteLine($"Peeked: {stack.Peek()}"); // Peeked: 10
            Console.WriteLine($"Is Empty: {stack.IsEmpty()}"); // Is Empty: False
            Console.WriteLine("Stack after pop:");
            stack.Print(); // Prints: 10

            // Example for Queue
            Queue queue = new Queue();
            queue.Enqueue(10); // Queue: 10
            queue.Enqueue(5);  // Queue: 10 -> 5
            Console.WriteLine("Initial Queue:");
            queue.Print(); // Prints: 10 -> 5
            Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Dequeued: 10
            Console.WriteLine($"Peeked: {queue.Peek()}"); // Peeked: 5
            Console.WriteLine($"Is Empty: {queue.IsEmpty()}"); // Is Empty: False
            Console.WriteLine("Queue after dequeue:");
            queue.Print(); // Prints: 5

            // Example for StackWithReverse
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.Push(1);
            stackWithReverse.Push(2);
            stackWithReverse.Push(3);
            stackWithReverse.Push(4);
            stackWithReverse.Push(5);

            Console.WriteLine("Stack before reversing:");
            stackWithReverse.Print(); // Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1
            stackWithReverse.ReverseStack();
            Console.WriteLine("Stack after reversing:");
            stackWithReverse.Print(); // Stack: Top -> 1 -> 2 -> 3 -> 4 -> 5

            stackWithReverse.Push(6);
            stackWithReverse.Push(7);
            Console.WriteLine("Stack after pushing additional elements:");
            stackWithReverse.Print(); // Stack: Top -> 7 -> 6 -> 1 -> 2 -> 3 -> 4 -> 5
            stackWithReverse.ReverseStack();
            Console.WriteLine("Stack after reversing again:");
            stackWithReverse.Print(); // Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1 -> 6 -> 7
        }
    }
}
