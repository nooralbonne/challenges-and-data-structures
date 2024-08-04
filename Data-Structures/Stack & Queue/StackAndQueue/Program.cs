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
        }
    }
}
