using Xunit;
using System;
using System.IO;
using System.Collections.Generic;

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

        [Fact]
        public void Merge_WhenOneListIsEmpty_ShouldReturnTheOtherList()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list2.Add(1);

            LinkedList mergedList = new LinkedList();
            mergedList = mergedList.MergeSortedLists(list1, list2);

            Assert.NotNull(mergedList.head);
            Assert.Equal(1, mergedList.head.Data);
        }

        [Fact]
        public void Merge_WhenBothListsAreEmpty_ShouldReturnEmptyList()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            LinkedList mergedList = new LinkedList();
            mergedList = mergedList.MergeSortedLists(list1, list2);

            Assert.Null(mergedList.head);
        }

        [Fact]
        public void Merge_WhenListsAreSorted_ShouldReturnMergedSortedList()
        {
            LinkedList list1 = new LinkedList();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            LinkedList mergedList = new LinkedList();
            mergedList = mergedList.MergeSortedLists(list1, list2);

            Assert.Equal(2, mergedList.head.Data);
            Assert.Equal(3, mergedList.head.Next.Data);
            Assert.Equal(5, mergedList.head.Next.Next.Data);
            Assert.Equal(10, mergedList.head.Next.Next.Next.Data);
            Assert.Equal(15, mergedList.head.Next.Next.Next.Next.Data);
            Assert.Equal(20, mergedList.head.Next.Next.Next.Next.Next.Data);
        }

        [Fact]
        public void RotateLeft_Zero_ShouldRemainUnchanged()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            list.RotateLeft(0);

            // Assert
            Assert.Equal("1 -> 2 -> 3 -> Null", list.ToString());
        }

        [Fact]
        public void RotateLeft_ValueGreaterThanLength_ShouldWrapAround()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            // Act
            list.RotateLeft(7); // Length is 4, so 7 % 4 = 3

            // Assert
            Assert.Equal("4 -> 1 -> 2 -> 3 -> Null", list.ToString());
        }
    }
}

