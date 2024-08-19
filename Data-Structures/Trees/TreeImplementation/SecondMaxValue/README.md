# Binary Tree and Binary Search Tree Implementation

This project involves implementing and testing Binary Tree and Binary Search Tree (BST) data structures in C#. The implementations include methods for adding, removing, and traversing nodes in the trees, as well as unit tests to verify their correctness.

## Problem Domain

The problem is to implement Binary Tree and Binary Search Tree data structures with common operations like adding, removing, and searching for nodes. Additionally, you need to provide tree traversal methods (PreOrder, InOrder, and PostOrder) and validate them using unit tests.

### Binary Tree
- A Binary Tree is a tree data structure where each node has at most two children (referred to as the left and right child).
- Traversal methods (PreOrder, InOrder, PostOrder) should be implemented.

### Binary Search Tree (BST)
- A Binary Search Tree is a binary tree where each node has a value greater than or equal to the values in its left subtree and less than or equal to the values in its right subtree.
- Methods for adding, removing, and searching nodes should be implemented.

## Inputs and Expected Outputs

### Inputs
- **Adding Node**: Insert a node with a specific value into the Binary Search Tree.
- **Removing Node**: Remove a node with a specific value from the Binary Search Tree.
- **Traversals**: Perform PreOrder, InOrder, and PostOrder traversals on the Binary Tree.

### Expected Outputs
- **Adding Node**: The node should be added in the correct position according to the BST properties.
- **Removing Node**: The node should be removed, and the tree should remain a valid BST.
- **Traversals**: The traversal methods should return the nodes in the correct order.

## Edge Cases

- **Empty Tree**: Operations on an empty tree should be handled gracefully.
- **Single Node Tree**: Test the operations on a tree with a single node.
- **Removing Root Node**: Ensure that removing the root node works correctly, especially when the tree has multiple levels.

## Algorithm

### Adding Node to BST
1. Start at the root node.
2. Compare the value to be added with the current node.
3. If the value is less, move to the left child; if greater, move to the right child.
4. Repeat the process until you find a suitable position to insert the new node.
5. Insert the node at the correct position, ensuring the BST properties are maintained.

### Removing Node from BST
1. Find the node to be removed.
2. If the node has no children, simply remove it.
3. If the node has one child, replace it with its child.
4. If the node has two children, find the in-order successor (smallest value in the right subtree) and replace the node with the successor.
5. Remove the successor node from its original position.

### Traversal Methods
- **PreOrder**: Visit the root node, then recursively visit the left subtree, followed by the right subtree.
- **InOrder**: Recursively visit the left subtree, visit the root node, then recursively visit the right subtree.
- **PostOrder**: Recursively visit the left subtree, then the right subtree, and finally visit the root node.

## Big O Time/Space Complexity

- **Adding Node**: 
  - Time Complexity: O(log n) on average for a balanced BST, O(n) in the worst case for an unbalanced tree.
  - Space Complexity: O(1) for iterative insertion, O(h) where h is the height of the tree for recursive insertion.

- **Removing Node**: 
  - Time Complexity: O(log n) on average for a balanced BST, O(n) in the worst case.
  - Space Complexity: O(1) for iterative removal, O(h) for recursive removal.

- **Traversal Methods**: 
  - Time Complexity: O(n) for all traversal methods (PreOrder, InOrder, PostOrder).
  - Space Complexity: O(h) where h is the height of the tree, due to the recursive call stack.
