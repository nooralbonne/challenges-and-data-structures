public class BinaryTree
{
    public Node Root { get; set; } // Add the public setter here

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

    public void InOrder(Node node)
    {
        if (node != null)
        {
            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
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
}
