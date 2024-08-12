namespace Trees.TreeImplementation
{
    public class Program
    {
        static void Main()
        {
            // Binary Tree Example
            var binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1)
            {
                Left = new Node(2)
                {
                    Left = new Node(4),
                    Right = new Node(5)
                },
                Right = new Node(3)
            };

            Console.WriteLine("Binary Tree Traversal:");
            Console.Write("PreOrder: ");
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.Write("InOrder: ");
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine();

            Console.Write("PostOrder: ");
            binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("\nPrint Binary Tree:");
            binaryTree.Print(binaryTree.Root);

            // Binary Search Tree Example
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            Console.WriteLine("\nBinary Search Tree Operations:");
            Console.WriteLine("Contains 7: " + bst.Contains(7));
            Console.WriteLine("Contains 5: " + bst.Contains(5));

            bst.Remove(5);
            Console.WriteLine("Contains 5 after removal: " + bst.Contains(5));
        }
    }
}