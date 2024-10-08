using Xunit;

public class MinimumDepthTests
{
    [Fact]
    public void TestMinimumDepth_EmptyTree()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();

        // Act
        int minDepth = Btree.FindMinimumDepth();

        // Assert
        Assert.Equal(0, minDepth); // Empty tree should have depth 0
    }

    [Fact]
    public void TestMinimumDepth_SingleNodeTree()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(1);

        // Act
        int minDepth = Btree.FindMinimumDepth();

        // Assert
        Assert.Equal(1, minDepth); // Tree with only one node should have depth 1
    }

    [Fact]
    public void TestMinimumDepth_MultiNodeTree_VariedDepths()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(1);
        Btree.Root.Left = new Node(2);
        Btree.Root.Right = new Node(3);
        Btree.Root.Left.Left = new Node(4);
        Btree.Root.Left.Right = new Node(5);

        // Act
        int minDepth = Btree.FindMinimumDepth();

        // Assert
        Assert.Equal(2, minDepth); // The minimum depth should be 2
    }

    [Fact]
    public void TestMinimumDepth_MultiNodeTree_SameDepth()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(1);
        Btree.Root.Left = new Node(2);
        Btree.Root.Right = new Node(3);
        Btree.Root.Left.Right = new Node(5);
        Btree.Root.Right.Right = new Node(6);

        // Act
        int minDepth = Btree.FindMinimumDepth();

        // Assert
        Assert.Equal(3, minDepth); // Both paths have depth 3, so the minimum depth should be 3
    }
}
