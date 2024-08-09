using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    public class MinStack
    {
        private Stack<int> stack;
        private Stack<int> minStack;

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
            if (minStack.Count == 0 || x <= minStack.Peek())
            {
                minStack.Push(x);
            }
        }

        public int Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            int popped = stack.Pop();
            if (popped == minStack.Peek())
            {
                minStack.Pop();
            }
            return popped;
        }

        public int Top()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return stack.Peek();
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return minStack.Peek();
        }

        public void PrintStack()
        {
            Console.Write("Top -> ");
            foreach (var item in stack)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine();
        }
    }
}
