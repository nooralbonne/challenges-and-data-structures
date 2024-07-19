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
