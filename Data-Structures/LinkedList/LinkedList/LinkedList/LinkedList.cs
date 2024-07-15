using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        private Node head;

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

        public bool Contains(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty.");
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new InvalidOperationException("Node not found.");
            }

            current.Next = current.Next.Next;
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
    }
}
