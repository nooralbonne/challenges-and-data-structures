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

            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            LinkedList mergedList = new LinkedList();
            mergedList = mergedList.MergeSortedLists(list1, list2);

            Console.Write("Merged List: ");
            mergedList.PrintList(); // Output: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null

        }
    }
}
