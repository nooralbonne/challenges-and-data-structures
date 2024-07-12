namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // Add nodes
            list.Add(5);
            list.Add(10);
            list.Add(20);

            // Print initial list
            Console.Write("Initial List: ");
            list.PrintList(); // Output: 5 -> 10 -> 20 -> Null

            // Remove a node
            list.Remove(10);

            // Print list after removal
            Console.Write("List after removing 10: ");
            list.PrintList(); // Output: 5 -> 20 -> Null
        }
    }
}