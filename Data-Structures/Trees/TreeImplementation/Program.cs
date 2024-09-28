namespace Trees.TreeImplementation
{
    public class Program
    {
        static void Main()
        {
            // Binary Tree Example
            var binaryTree = new BinaryTree();
            binaryTree.Root = new Node(10)
            {
                Left = new Node(5)
                {
                    Left = new Node(3),
                    Right = new Node(7)
                },
                Right = new Node(20)
                {
                    Left = new Node(15),
                    Right = new Node(25)
                }
            };

            Console.WriteLine("Binary Tree Traversal:");
            Console.Write("PreOrder: ");
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.Write("InOrder: ");
            var inorder = binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine(string.Join(", ", inorder));

            Console.Write("PostOrder: ");
            binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("\nPrint Binary Tree:");
            binaryTree.Print(binaryTree.Root);

            // Find the second maximum value
            try
            {
                int secondMax = binaryTree.FindSecondMax();
                Console.WriteLine("\nThe second maximum value in the binary tree is: " + secondMax);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Mirror Tree Example
            Console.WriteLine("=============== Mirror Tree Example ===============");
            BinaryTree mirrorTree = new BinaryTree();
            mirrorTree.Root = new Node(4);
            mirrorTree.Root.Left = new Node(8);
            mirrorTree.Root.Right = new Node(7);
            mirrorTree.Root.Left.Left = new Node(12);
            mirrorTree.Root.Left.Right = new Node(9);

            Console.WriteLine("Original InOrder Traversal:");
            List<int> originalInorder = mirrorTree.InOrder(mirrorTree.Root);
            Console.WriteLine(string.Join(", ", originalInorder));

            Console.WriteLine("Original Binary Tree:");
            mirrorTree.Print(mirrorTree.Root);

            Console.WriteLine("\nMirroring the Binary Tree...");
            mirrorTree.Mirror(mirrorTree.Root);

            Console.WriteLine("\nMirrored Binary Tree:");
            mirrorTree.Print(mirrorTree.Root);

            Console.WriteLine("Mirrored InOrder Traversal:");
            List<int> mirroredInorder = mirrorTree.InOrder(mirrorTree.Root);
            Console.WriteLine(string.Join(", ", mirroredInorder));

            // Calculate the sum of leaf nodes
            int leafSum = binaryTree.LeafSum();
            Console.WriteLine("Sum of all leaf nodes: " + leafSum); // Output: 51


            // Find the largest value at each level
            List<int> largestValues = binaryTree.LargestValueEachLevel();
            Console.WriteLine("Largest values at each level: " + string.Join(", ", largestValues));
            // Expected output: [5, 13, 20, 11]


            // Example Binary Tree setup
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            // Print the right view of the binary tree
            Console.WriteLine("Right view of the binary tree:");
            Btree.PrintRightView();  // Expected Output: 2 5 6 7
        }
    }
}