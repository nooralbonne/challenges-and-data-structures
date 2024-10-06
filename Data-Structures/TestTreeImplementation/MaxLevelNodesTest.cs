using System;
using Xunit;

namespace Test
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void Test_FindLevelWithMaxNodes_SingleMaxLevel()
        {
            // Arrange: Create the tree
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            // Act: Get the level with the maximum number of nodes
            int maxLevel = tree.FindMaxLevelNodes();

            // Assert: Level 1 (the root) has 1 node, Level 2 has 2 nodes, Level 3 has 4 nodes
            Assert.Equal(2, maxLevel);
        }

        [Fact]
        public void Test_FindLevelWithMaxNodes_EmptyTree()
        {
            // Arrange: Create an empty tree
            BinaryTree tree = new BinaryTree();

            // Act & Assert: Expect an InvalidOperationException for empty tree
            Assert.Throws<InvalidOperationException>(() => tree.FindMaxLevelNodes());
        }

        [Fact]
        public void Test_FindLevelWithMaxNodes_OnlyRootNode()
        {
            // Arrange: Create a tree with only the root node
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);

            // Act: Get the level with the maximum number of nodes
            int maxLevel = tree.FindMaxLevelNodes();

            // Assert: The only node is at level 0
            Assert.Equal(0, maxLevel);
        }
    }
}
