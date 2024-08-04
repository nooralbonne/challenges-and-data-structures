using System;
using System.Collections.Generic;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle<T> : Stack<T>
    {
        public void DeleteMiddle()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            int middleIndex = (Count - 1) / 2; // Correct calculation for zero-based index

            // Use a temporary stack to hold elements
            Stack<T> tempStack = new Stack<T>();

            // Move elements to tempStack until the middle element
            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(Pop());
            }

            // Remove the middle element
            Pop();

            // Move elements back to the original stack
            while (tempStack.Count > 0)
            {
                Push(tempStack.Pop());
            }
        }
        public override string ToString()
        {
            var stackArray = this.ToArray();
            Array.Reverse(stackArray);
            return "Stack: Top -> " + string.Join(" -> ", stackArray) + " -> End";
        }

    }
}