using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace TestTreeImplementation
{
    public class UnitTest1
    {
        public class BinarySearchTreeTests
        {
            [Fact]
            public void AddingNode()
            {
                // Arrange
                var bst = new BinarySearchTree();
                bst.Add(10);
                bst.Add(5);
                bst.Add(15);
                bst.Add(3);
                bst.Add(7);
                bst.Add(12);
                bst.Add(18);

                // Act
                bool contains3 = bst.Contains(3);
                bool contains7 = bst.Contains(7);
                bool contains12 = bst.Contains(12);
                bool contains18 = bst.Contains(18);
                bool contains20 = bst.Contains(20);

                // Assert
                Assert.True(contains3);
                Assert.True(contains7);
                Assert.True(contains12);
                Assert.True(contains18);
                Assert.False(contains20);
            }

            [Fact]
            public void CheckNodeExists()
            {
                // Arrange
                var bst = new BinarySearchTree();
                bst.Add(10);
                bst.Add(5);
                bst.Add(15);
                bst.Add(2);
                bst.Add(7);
                bst.Add(12);
                bst.Add(20);

                // Act & Assert
                Assert.True(bst.Contains(15));
            }

            [Fact]
            public void RemovingNode()
            {
                // Arrange
                var bst = new BinarySearchTree();
                bst.Add(10);
                bst.Add(5);
                bst.Add(15);
                bst.Add(3);
                bst.Add(7);
                bst.Add(12);
                bst.Add(18);

                // Act
                bst.Remove(15);
                bool contains15 = bst.Contains(15);
                bool contains18 = bst.Contains(18);

                // Assert
                Assert.False(contains15);
                Assert.True(contains18);
            }
        }

        public class BinaryTreeTests
        {
            [Fact]
            public void PreOrderTraversal()
            {
                // Arrange
                var b = new BinaryTree();
                b.Root = new Node(10)
                {
                    Left = new Node(5)
                    {
                        Left = new Node(2),
                        Right = new Node(7)
                    },
                    Right = new Node(15)
                    {
                        Left = new Node(12),
                        Right = new Node(20)
                    }
                };

                List<int> expectedOutput = new List<int> { 10, 5, 2, 7, 15, 12, 20 };
                List<int> actualOutput = new List<int>();

                // Act
                void PreOrder(Node node)
                {
                    if (node == null) return;
                    actualOutput.Add(node.Data);
                    PreOrder(node.Left);
                    PreOrder(node.Right);
                }

                PreOrder(b.Root);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }

            [Fact]
            public void InOrderTraversal()
            {
                // Arrange
                var b = new BinaryTree();
                b.Root = new Node(10)
                {
                    Left = new Node(5)
                    {
                        Left = new Node(2),
                        Right = new Node(7)
                    },
                    Right = new Node(15)
                    {
                        Left = new Node(12),
                        Right = new Node(20)
                    }
                };

                List<int> expectedOutput = new List<int> { 2, 5, 7, 10, 12, 15, 20 };
                List<int> actualOutput = new List<int>();

                // Act
                void InOrder(Node node)
                {
                    if (node == null) return;
                    InOrder(node.Left);
                    actualOutput.Add(node.Data);
                    InOrder(node.Right);
                }

                InOrder(b.Root);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }

            [Fact]
            public void PostOrderTraversal()
            {
                // Arrange
                var b = new BinaryTree();
                b.Root = new Node(10)
                {
                    Left = new Node(5)
                    {
                        Left = new Node(2),
                        Right = new Node(7)
                    },
                    Right = new Node(15)
                    {
                        Left = new Node(12),
                        Right = new Node(20)
                    }
                };

                List<int> expectedOutput = new List<int> { 2, 7, 5, 12, 20, 15, 10 };
                List<int> actualOutput = new List<int>();

                // Act
                void PostOrder(Node node)
                {
                    if (node == null) return;
                    PostOrder(node.Left);
                    PostOrder(node.Right);
                    actualOutput.Add(node.Data);
                }

                PostOrder(b.Root);

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
        }
    }
}
