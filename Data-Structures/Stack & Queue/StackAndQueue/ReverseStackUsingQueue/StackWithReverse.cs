using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.ReverseStackUsingQueue
{
    public class StackWithReverse : Stack
    {
        public void ReverseStack()
        {
            Queue queue = new Queue();

            // Step 1: Transfer elements from stack to queue
            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            // Step 2: Transfer elements from queue back to stack
            while (!queue.IsEmpty())
            {
                Push(queue.Dequeue());
            }
        }
    }
}
