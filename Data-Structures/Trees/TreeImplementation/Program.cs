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

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);

            int maxLevel = Btree.FindMaxLevelNodes();
            Console.WriteLine("The level with the maximum number of nodes is: " + maxLevel);

            //=========================================
            // First example
            BinaryTree Btree1 = new BinaryTree();
            Btree1.Root = new Node(1);
            Btree1.Root.Left = new Node(2);
            Btree1.Root.Right = new Node(3);
            Btree1.Root.Left.Left = new Node(4);
            Btree1.Root.Left.Right = new Node(5);

            Console.WriteLine("Minimum depth of the first tree: " + Btree1.FindMinimumDepth()); // Output: 2


            // Second example
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(1);
            Btree2.Root.Left = new Node(2);
            Btree2.Root.Right = new Node(3);
            Btree2.Root.Left.Right = new Node(5);
            Btree2.Root.Right.Right = new Node(6);

            Console.WriteLine("Minimum depth of the second tree: " + Btree2.FindMinimumDepth()); // Output: 3
        
       }
    }
}