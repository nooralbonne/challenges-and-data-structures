using Xunit;
using System;
using System.IO;

namespace LinkedList.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void RemoveLastNodeTest()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            int initialLength = linkedList.GetLength();

            // Act
            linkedList.Remove(4);
            int finalLength = linkedList.GetLength();

            // Assert
            Assert.Equal(initialLength - 1, finalLength);
        }

        [Fact]
        public void PrintListTest()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);

            string expectedOutput = "1 -> 2 -> 3 -> 4 -> Null\r\n";

            // Act
            var sw = new StringWriter();
            Console.SetOut(sw);
            linkedList.PrintList();
            string actualOutput = sw.ToString();

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void RemoveDuplicates_ShouldKeepUniqueNodes_WhenNoDuplicates()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            list.RemoveDuplicates();

            // Assert
            string expectedOutput = "1 -> 2 -> 3 -> Null";
            Assert.Equal(expectedOutput, list.ToString());
        }

        [Fact]
        public void RemoveDuplicates_ShouldRemoveDuplicates_KeepUniqueNodes()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            list.Add(4);

            // Act
            list.RemoveDuplicates();

            // Assert
            string expectedOutput = "1 -> 2 -> 3 -> 4 -> Null";
            Assert.Equal(expectedOutput, list.ToString());
        }

        [Fact]
        public void RemoveDuplicates_ShouldReduceToOneNode_WhenAllDuplicates()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.Add(5);

            // Act
            list.RemoveDuplicates();

            // Assert
            string expectedOutput = "5 -> Null";
            Assert.Equal(expectedOutput, list.ToString());
        }
    }
}

