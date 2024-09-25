using System;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Remove(int data)
        {
            if (head == null)
                return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public void RemoveDuplicates()
        {
            Node current = head;
            while (current != null)
            {
                Node runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == current.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }

        public override string ToString()
        {
            Node current = head;
            StringBuilder result = new StringBuilder();
            while (current != null)
            {
                result.Append($"{current.Data} -> ");
                current = current.Next;
            }
            result.Append("Null");
            return result.ToString();
        }

        // Method to rotate the linked list to the left by k positions
        public void RotateLeft(int k)
        {
            if (head == null || k == 0)
            {
                return; // No rotation needed
            }

            // Get the length of the linked list
            int length = GetLength();
            k = k % length; // In case k is larger than the length of the list
            if (k == 0) return; // No need to rotate if k is 0 or a multiple of length

            // Find the kth node and its previous node
            Node current = head;
            int count = 1;
            while (count < k && current != null)
            {
                current = current.Next;
                count++;
            }

            // The kth node becomes the new head
            Node kthNode = current;

            // Traverse to the end of the list
            while (current.Next != null)
            {
                current = current.Next;
            }

            // Connect the end of the list to the original head
            current.Next = head;

            // The new head becomes the (k+1)th node
            head = kthNode.Next;

            // Set the kth node's next to null to mark the end of the new list
            kthNode.Next = null;
        }

        public int GetLength()
        {
            int length = 0;
            Node current = head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }

        public LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            Node dummy = new Node(0);
            Node tail = dummy;

            Node current1 = list1.head;
            Node current2 = list2.head;

            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)
                {
                    tail.Next = new Node(current1.Data);
                    current1 = current1.Next;
                }
                else
                {
                    tail.Next = new Node(current2.Data);
                    current2 = current2.Next;
                }
                tail = tail.Next;
            }

            while (current1 != null)
            {
                tail.Next = new Node(current1.Data);
                current1 = current1.Next;
                tail = tail.Next;
            }

            while (current2 != null)
            {
                tail.Next = new Node(current2.Data);
                current2 = current2.Next;
                tail = tail.Next;
            }

            LinkedList mergedList = new LinkedList();
            mergedList.head = dummy.Next;
            return mergedList;
        }
    }
}
