public class BinaryTree
{
    public Node Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void PreOrder(Node node)
    {
        if (node != null)
        {
            Console.Write(node.Data + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
    }

    public List<int> InOrder(Node node)
    {
        List<int> result = new List<int>();
        InOrder(node, result);
        return result;
    }

    private void InOrder(Node node, List<int> result)
    {
        if (node != null)
        {
            InOrder(node.Left, result);
            result.Add(node.Data);
            InOrder(node.Right, result);
        }
    }

    public void PostOrder(Node node)
    {
        if (node != null)
        {
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }
    }

    public void Print(Node node, string indent = "", bool last = true)
    {
        if (node != null)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("R----");
                indent += "   ";
            }
            else
            {
                Console.Write("L----");
                indent += "|  ";
            }

            Console.WriteLine(node.Data);
            Print(node.Left, indent, false);
            Print(node.Right, indent, true);
        }
    }

    // Mirror the tree
    public void Mirror(Node node)
    {
        try
        {
            if (node == null)
                return;

            Mirror(node.Left);
            Mirror(node.Right);

            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while mirroring the tree: " + ex.Message);
        }
    }

    // Find the second maximum value in the Binary Tree
    public int FindSecondMax()
    {
        if (Root == null)
        {
            throw new InvalidOperationException("Tree is empty.");
        }

        return FindSecondMaxHelper(Root, int.MinValue, int.MinValue);
    }

    private int FindSecondMaxHelper(Node node, int max, int secondMax)
    {
        if (node == null)
        {
            return secondMax;
        }

        if (node.Data > max)
        {
            secondMax = max;
            max = node.Data;
        }
        else if (node.Data > secondMax && node.Data < max)
        {
            secondMax = node.Data;
        }

        secondMax = FindSecondMaxHelper(node.Left, max, secondMax);
        secondMax = FindSecondMaxHelper(node.Right, max, secondMax);

        return secondMax;
    }

    // Method to calculate the sum of all leaf nodes
    public int LeafSum()
    {
        return LeafSumHelper(Root);
    }

    private int LeafSumHelper(Node node)
    {
        if (node == null)
        {
            return 0;
        }

        // Check if the node is a leaf node
        if (node.Left == null && node.Right == null)
        {
            return node.Data;
        }

        // Recursively sum the leaves in the left and right subtrees
        return LeafSumHelper(node.Left) + LeafSumHelper(node.Right);
    }

    public List<int> LargestValueEachLevel()
    {
        List<int> largestValues = new List<int>();
        if (Root == null)
            return largestValues;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            int maxAtLevel = int.MinValue;

            for (int i = 0; i < levelSize; i++)
            {
                Node current = queue.Dequeue();
                maxAtLevel = Math.Max(maxAtLevel, current.Data);

                if (current.Left != null)
                    queue.Enqueue(current.Left);
                if (current.Right != null)
                    queue.Enqueue(current.Right);
            }

            largestValues.Add(maxAtLevel);
        }

        return largestValues;
    }

    // Method to find the level with the maximum number of nodes
    public int FindMaxLevelNodes()
    {
        if (Root == null)
        {
            throw new InvalidOperationException("Tree is empty.");
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        int maxLevel = 0;
        int maxNodes = 0;
        int currentLevel = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count; // Number of nodes at the current level

            if (levelSize > maxNodes)
            {
                maxNodes = levelSize;
                maxLevel = currentLevel;
            }

            for (int i = 0; i < levelSize; i++)
            {
                Node currentNode = queue.Dequeue();

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            currentLevel++; // Move to the next level
        }

        return maxLevel;
    }

    // Method to find the minimum depth of the binary tree
    public int FindMinimumDepth()
    {
        if (Root == null)
        {
            return 0; // An empty tree has a depth of 0
        }

        return FindMinimumDepthHelper(Root);
    }

    // Helper method using recursion to find the minimum depth
    private int FindMinimumDepthHelper(Node node)
    {
        // Base case: if the node is null, return a large number (infinity)
        if (node == null)
        {
            return int.MaxValue;
        }

        // If it's a leaf node, return 1
        if (node.Left == null && node.Right == null)
        {
            return 1;
        }

        // Recur for the left and right subtrees and take the minimum depth
        int leftDepth = FindMinimumDepthHelper(node.Left);
        int rightDepth = FindMinimumDepthHelper(node.Right);

        // Return the minimum depth of the subtrees + 1 (for the current node)
        return Math.Min(leftDepth, rightDepth) + 1;
    }


}