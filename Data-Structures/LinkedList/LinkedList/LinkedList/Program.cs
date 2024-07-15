namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // Add nodes
            list.Add(5);
            list.Add(20);
            list.Add(20);
            list.Add(10);
            list.Add(5);
            list.Add(10);

            // Print initial list
            Console.Write("Initial List: ");
            list.PrintList(); // Output: 5 -> 20 -> 20 -> 10 -> 5 -> 10 -> Null

            // Remove duplicates
            list.RemoveDuplicates();

            // Print list after removing duplicates
            Console.Write("List after removing duplicates: ");
            list.PrintList(); // Output: 5 -> 20 -> 10 -> Null
        }
    }
}
