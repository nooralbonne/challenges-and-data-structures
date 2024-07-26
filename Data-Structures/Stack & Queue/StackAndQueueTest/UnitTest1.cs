using Xunit;

namespace StackAndQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void Stack_TestPush()
        {
            Stack stack = new Stack();
            stack.Push(10);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void Stack_TestPop()
        {
            Stack stack = new Stack();
            stack.Push(10);
            int poppedValue = stack.Pop();
            Assert.Equal(10, poppedValue);
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void Stack_TestIsEmpty()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
            stack.Push(10);
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void Queue_TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void Queue_TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            int dequeuedValue = queue.Dequeue();
            Assert.Equal(10, dequeuedValue);
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void Queue_TestIsEmpty()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
            queue.Enqueue(10);
            Assert.False(queue.IsEmpty());
        }
    }
}
