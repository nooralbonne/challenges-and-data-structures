public class BinarySearchTree
{
    public Node Root { get; private set; }

    public BinarySearchTree()
    {
        Root = null;
    }

    public void Add(int data)
    {
        Root = AddRecursive(Root, data);
    }

    private Node AddRecursive(Node node, int data)
    {
        if (node == null)
        {
            return new Node(data);
        }

        if (data < node.Data)
        {
            node.Left = AddRecursive(node.Left, data);
        }
        else if (data > node.Data)
        {
            node.Right = AddRecursive(node.Right, data);
        }

        return node;
    }

    public bool Contains(int data)
    {
        return ContainsRecursive(Root, data);
    }

    private bool ContainsRecursive(Node node, int data)
    {
        if (node == null)
        {
            return false;
        }

        if (data == node.Data)
        {
            return true;
        }

        if (data < node.Data)
        {
            return ContainsRecursive(node.Left, data);
        }

        return ContainsRecursive(node.Right, data);
    }

    public void Remove(int data)
    {
        Root = RemoveRecursive(Root, data);
    }

    private Node RemoveRecursive(Node node, int data)
    {
        if (node == null)
        {
            return null;
        }

        if (data < node.Data)
        {
            node.Left = RemoveRecursive(node.Left, data);
        }
        else if (data > node.Data)
        {
            node.Right = RemoveRecursive(node.Right, data);
        }
        else
        {
            if (node.Left == null && node.Right == null)
            {
                return null;
            }

            if (node.Left == null)
            {
                return node.Right;
            }

            if (node.Right == null)
            {
                return node.Left;
            }

            Node smallestNode = GetSmallestNode(node.Right);
            node.Data = smallestNode.Data;
            node.Right = RemoveRecursive(node.Right, smallestNode.Data);
        }

        return node;
    }

    private Node GetSmallestNode(Node node)
    {
        return node.Left == null ? node : GetSmallestNode(node.Left);
    }
}
