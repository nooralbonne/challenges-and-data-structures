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
}