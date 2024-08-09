using System;
using StackAndQueue;
using StackAndQueue.ReverseStackUsingQueue;
using StackAndQueue.DeleteMiddleElement;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Example for StackWithDeleteMiddle
            StackWithDeleteMiddle<int> stackWithDeleteMiddle = new StackWithDeleteMiddle<int>();
            stackWithDeleteMiddle.Push(7);
            stackWithDeleteMiddle.Push(14);
            stackWithDeleteMiddle.Push(3);
            stackWithDeleteMiddle.Push(8);
            stackWithDeleteMiddle.Push(5);

            Console.WriteLine("Stack before deleting middle:");
            Console.WriteLine(stackWithDeleteMiddle); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
            stackWithDeleteMiddle.DeleteMiddle();
            Console.WriteLine("Stack after deleting middle:");
            Console.WriteLine(stackWithDeleteMiddle); // Stack: Top -> 5 -> 8 -> 14 -> 7

            stackWithDeleteMiddle.Push(2);
            stackWithDeleteMiddle.Push(9);
            stackWithDeleteMiddle.Push(11);
            Console.WriteLine("Stack after pushing additional elements:");
            Console.WriteLine(stackWithDeleteMiddle); // Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
            stackWithDeleteMiddle.DeleteMiddle();
            Console.WriteLine("Stack after deleting middle again:");
            Console.WriteLine(stackWithDeleteMiddle); // Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7

            // Example for MinStack
            MinStack minStack = new MinStack();

            // Push elements
            minStack.Push(15);
            Console.WriteLine("After pushing 15:");
            minStack.PrintStack(); // Output: Top -> 15

            minStack.Push(7);
            Console.WriteLine("After pushing 7:");
            minStack.PrintStack(); // Output: Top -> 7 -> 15

            minStack.Push(12);
            Console.WriteLine("After pushing 12:");
            minStack.PrintStack(); // Output: Top -> 12 -> 7 -> 15

            minStack.Push(3);
            Console.WriteLine("After pushing 3:");
            minStack.PrintStack(); // Output: Top -> 3 -> 12 -> 7 -> 15

            // Get the minimum element
            int min = minStack.GetMin();
            Console.WriteLine("Current minimum: " + min); // Output: Current minimum: 3

            // Pop a node from the stack
            int popped = minStack.Pop();
            Console.WriteLine("Popped element: " + popped); // Output: Popped element: 3
            Console.WriteLine("After popping:");
            minStack.PrintStack(); // Output: Top -> 12 -> 7 -> 15

            // Get the new minimum element
            min = minStack.GetMin();
            Console.WriteLine("New minimum: " + min); // Output: New minimum: 7

            // Peek the top node
            int peeked = minStack.Top();
            Console.WriteLine("Top element: " + peeked); // Output: Top element: 12

            // Push another element
            minStack.Push(2);
            Console.WriteLine("After pushing 2:");
            minStack.PrintStack(); // Output: Top -> 2 -> 12 -> 7 -> 15

            // Get the new minimum element
            min = minStack.GetMin();
            Console.WriteLine("New minimum: " + min); // Output: New minimum: 2

            // Check if the stack is empty
            bool isEmpty = minStack.IsEmpty();
            Console.WriteLine("Is stack empty? " + isEmpty); // Output: Is stack empty? False
        }
    }
}
