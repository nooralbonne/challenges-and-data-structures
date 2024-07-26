using StackAndQueue;

public class Queue
{
    private Node front;
    private Node rear;

    public Queue()
    {
        front = rear = null;
    }

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (rear != null)
        {
            rear.Next = newNode;
        }
        rear = newNode;
        if (front == null)
        {
            front = rear;
        }
    }

    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty.");

        int data = front.Data;
        front = front.Next;
        if (front == null)
        {
            rear = null;
        }
        return data;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty.");

        return front.Data;
    }

    public bool IsEmpty()
    {
        return front == null;
    }

    public void Print()
    {
        Node current = front;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}
