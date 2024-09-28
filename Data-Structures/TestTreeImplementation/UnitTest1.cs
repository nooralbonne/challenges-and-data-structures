using System.Collections.Generic;
using Xunit;
using Trees.TreeImplementation; // Adjust the namespace according to your project

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

            [Fact]
            public void TestMirrorTreeInorderTraversal()
            {
                // Arrange
                var binaryTree = new BinaryTree();
                binaryTree.Root = new Node(4);
                binaryTree.Root.Left = new Node(8);
                binaryTree.Root.Right = new Node(7);
                binaryTree.Root.Left.Left = new Node(12);
                binaryTree.Root.Left.Right = new Node(9);

                // Act
                var originalInorder = binaryTree.InOrder(binaryTree.Root);
                binaryTree.Mirror(binaryTree.Root);
                var mirroredInorder = binaryTree.InOrder(binaryTree.Root);

                // Assert
                Assert.Equal(new List<int> { 12, 8, 9, 4, 7 }, originalInorder);
                Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
            }

            [Fact]
            public void TestSingleNodeTree()
            {
                // Arrange
                var binaryTree = new BinaryTree();
                binaryTree.Root = new Node(1);

                // Act
                binaryTree.Mirror(binaryTree.Root);
                var inorder = binaryTree.InOrder(binaryTree.Root);

                // Assert
                Assert.Equal(new List<int> { 1 }, inorder);
            }

            [Fact]
            public void TestEmptyTree()
            {
                // Arrange
                var binaryTree = new BinaryTree();

                // Act
                binaryTree.Mirror(binaryTree.Root);
                var inorder = binaryTree.InOrder(binaryTree.Root);

                // Assert
                Assert.Empty(inorder);
            }

            // New Tests for Maximum Value in Binary Tree

            [Fact]
            public void Test_FindMaxValue_InBinaryTree_ExampleTree()
            {
                // Arrange
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

                // Act
                int maxValue = FindMaxValue(binaryTree.Root);

                // Assert
                Assert.Equal(5, maxValue);
            }

            [Fact]
            public void Test_FindMaxValue_InBinaryTree_FewerThanTwoUniqueValues()
            {
                // Arrange
                var binaryTree = new BinaryTree();
                binaryTree.Root = new Node(2)
                {
                    Left = new Node(2),
                    Right = new Node(2)
                };

                // Act
                int maxValue = FindMaxValue(binaryTree.Root);

                // Assert
                Assert.Equal(2, maxValue);
            }

            [Fact]
            public void Test_FindMaxValue_InBinaryTree_NegativeValues()
            {
                // Arrange
                var binaryTree = new BinaryTree();
                binaryTree.Root = new Node(-10)
                {
                    Left = new Node(-20)
                    {
                        Left = new Node(-30),
                        Right = new Node(-25)
                    },
                    Right = new Node(-15)
                };

                // Act
                int maxValue = FindMaxValue(binaryTree.Root);

                // Assert
                Assert.Equal(-10, maxValue);
            }

            // Helper method to find the maximum value in a binary tree
            private int FindMaxValue(Node node)
            {
                if (node == null)
                    return int.MinValue;

                int maxValue = node.Data;
                int leftMax = FindMaxValue(node.Left);
                int rightMax = FindMaxValue(node.Right);

                if (leftMax > maxValue)
                    maxValue = leftMax;

                if (rightMax > maxValue)
                    maxValue = rightMax;

                return maxValue;
            }
            [Fact]
            public void Test_LeafSum_WithPositiveLeafNodes()
            {
                // Arrange
                var binaryTree = new BinaryTree();
                binaryTree.Root = new Node(9);
                binaryTree.Root.Left = new Node(8);
                binaryTree.Root.Right = new Node(12);
                binaryTree.Root.Left.Left = new Node(3);
                binaryTree.Root.Left.Right = new Node(7);
                binaryTree.Root.Right.Left = new Node(17);
                binaryTree.Root.Right.Right = new Node(23);
                binaryTree.Root.Left.Left.Right = new Node(4);

                // Act
                int leafSum = binaryTree.LeafSum();

                // Assert
                Assert.Equal(51, leafSum);
            }

            [Fact]
            public void Test_LeafSum_WithNegativeLeafNodes()
            {
                // Arrange
                var binaryTree = new BinaryTree();
                binaryTree.Root = new Node(-10);
                binaryTree.Root.Left = new Node(-20);
                binaryTree.Root.Right = new Node(-30);
                binaryTree.Root.Left.Left = new Node(-40);
                binaryTree.Root.Left.Right = new Node(-50);
                binaryTree.Root.Right.Left = new Node(-60);

                // Act
                int leafSum = binaryTree.LeafSum();

                // Assert
                Assert.Equal(-150, leafSum);
            }

            [Fact]
            public void LargestValueEachLevel_ShouldReturnCorrectValues()
            {
                var binaryTree = new BinaryTree();
                binaryTree.Root = new Node(5)
                {
                    Left = new Node(13)
                    {
                        Left = new Node(3)
                        {
                            Left = new Node(1),
                            Right = new Node(4)
                        },
                        Right = new Node(7)
                    },
                    Right = new Node(7)
                    {
                        Left = new Node(12)
                        {
                            Right = new Node(11)
                        },
                        Right = new Node(20)
                    }
                };

                var result = binaryTree.LargestValueEachLevel();
                var expected = new List<int> { 5, 13, 20, 11 };

                Assert.Equal(expected, result);
            }

            [Fact]
            public void LargestValueEachLevel_ShouldHandleEmptyTree()
            {
                var binaryTree = new BinaryTree();
                var result = binaryTree.LargestValueEachLevel();
                Assert.Empty(result);
            }

            public class RightViewTest
            {
                [Fact]
                public void TestRightView_CorrectOutput()
                {
                    // Arrange
                    BinaryTree tree = new BinaryTree();
                    tree.Root = new Node(2);
                    tree.Root.Left = new Node(3);
                    tree.Root.Right = new Node(5);
                    tree.Root.Left.Left = new Node(4);
                    tree.Root.Right.Right = new Node(6);
                    tree.Root.Left.Left.Right = new Node(7);

                    // Act & Assert
                    using (var sw = new StringWriter())
                    {
                        Console.SetOut(sw);
                        tree.PrintRightView();

                        var expected = string.Join(" ", new int[] { 2, 5, 6, 7 }) + Environment.NewLine;
                        Assert.Equal(expected, sw.ToString());
                    }
                }

                [Fact]
                public void TestRightView_AllRightNodes()
                {
                    // Arrange
                    BinaryTree tree = new BinaryTree();
                    tree.Root = new Node(1);
                    tree.Root.Right = new Node(2);
                    tree.Root.Right.Right = new Node(3);
                    tree.Root.Right.Right.Right = new Node(4);

                    // Act & Assert
                    using (var sw = new StringWriter())
                    {
                        Console.SetOut(sw);
                        tree.PrintRightView();

                        var expected = string.Join(" ", new int[] { 1, 2, 3, 4 }) + Environment.NewLine;
                        Assert.Equal(expected, sw.ToString());
                    }
                }

                private string GetConsoleOutput(Action action)
                {
                    using (var consoleOutput = new StringWriter())
                    {
                        Console.SetOut(consoleOutput);
                        action();
                        return consoleOutput.ToString();
                    }
                }

                [Fact]
                public void TestRightView_EmptyTree()
                {
                    // Arrange
                    BinaryTree emptyTree = new BinaryTree();

                    // Act and Assert
                    var output = GetConsoleOutput(() => emptyTree.PrintRightView());
                    Assert.Equal("Tree is empty.\r\n", output);
                }

         
        }
        }
    }
}
    

