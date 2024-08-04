using StackAndQueue.DeleteMiddleElement;
using StackAndQueue.ReverseStackUsingQueue;
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

        [Fact]
        public void ReverseStack_MultipleElements_ReversesCorrectly()
        {
            // Arrange
            var stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(5, stack.Pop());
        }

        [Fact]
        public void ReverseStack_OneElement_DoesNotChange()
        {
            // Arrange
            var stack = new StackWithReverse();
            stack.Push(1);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void ReverseStack_EmptyStack_DoesNotChange()
        {
            // Arrange
            var stack = new StackWithReverse();

            // Act
            stack.ReverseStack();

            // Assert
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void DeleteMiddle_OddSizedStack_RemovesCorrectElement()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle<int>();
            stack.Push(5);  
            stack.Push(8);  
            stack.Push(3);  
            stack.Push(14); 
            stack.Push(7);  

            // Act
            stack.DeleteMiddle();

            // Assert
            // Stack after removing the middle element 3:
            // Stack: Top -> 5 -> 8 -> 14 -> 7
            Assert.Equal("Stack: Top -> 5 -> 8 -> 14 -> 7 -> End", stack.ToString());
        }

        [Fact]
        public void DeleteMiddle_EvenSizedStack_RemovesCorrectElement()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle<int>();
            stack.Push(8);  
            stack.Push(14); 
            stack.Push(3);  
            stack.Push(7);  

            // Act
            stack.DeleteMiddle();

            // Assert
            // Stack after removing the lower middle element 3:
            // Stack: Top -> 8 -> 14 -> 7
            Assert.Equal("Stack: Top -> 8 -> 14 -> 7 -> End", stack.ToString());
        }
    }
}