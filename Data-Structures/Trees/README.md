# Binary Tree and Binary Search Tree

This repository contains implementations of Binary Tree and Binary Search Tree in C#. It includes the core classes for tree structures, traversal methods, and basic operations such as adding, removing, and checking for nodes.

## Whiteboard Image

![Whiteboard Diagram](path/to/whiteboard-image.png)  
*(Include a path to your whiteboard image here)*

## Problem Domain

The problem domain involves implementing two types of tree data structures:
- **Binary Tree**: A tree data structure where each node has at most two children.
- **Binary Search Tree (BST)**: A binary tree where the left child of a node contains only nodes with values less than the node’s value, and the right child contains only nodes with values greater than the node’s value.

## Inputs and Expected Outputs

### Binary Search Tree Operations

- **Adding a Node**:
  - **Input**: A value to be added to the BST.
  - **Output**: The BST with the new node added at the correct position.

- **Checking Node Existence**:
  - **Input**: A value to check for existence in the BST.
  - **Output**: `true` if the value exists, `false` otherwise.

- **Removing a Node**:
  - **Input**: A value to be removed from the BST.
  - **Output**: The BST with the specified node removed.

### Traversal Methods for Binary Tree

- **PreOrder Traversal**:
  - **Input**: A starting node of the tree.
  - **Output**: Nodes are visited in the order: Root -> Left -> Right.

- **InOrder Traversal**:
  - **Input**: A starting node of the tree.
  - **Output**: Nodes are visited in the order: Left -> Root -> Right.

- **PostOrder Traversal**:
  - **Input**: A starting node of the tree.
  - **Output**: Nodes are visited in the order: Left -> Right -> Root.

## Edge Cases

- **Empty Tree**: Operations on an empty tree should handle cases where no nodes exist.
- **Single Node Tree**: Ensure that operations such as removal work correctly for a tree with only one node.
- **Removing Node with Two Children**: The node should be replaced with its in-order successor or predecessor.
- **Duplicate Values**: The implementation should handle or reject duplicate values as specified.

## Visual

### Binary Tree
    10
   /  \
  5    15
 / \   / \
2   7 12  20


### Binary Search Tree Operations

- **Adding Node**: Inserting nodes while maintaining the BST property.
- **Checking Node Existence**: Searching for nodes based on BST rules.
- **Removing Node**: Removing nodes while preserving the BST property.

## Algorithm

### Binary Search Tree Add Operation

1. **Start at the root**.
2. **Recursively find the correct position** for the new node:
   - If the value is less than the current node, move to the left child.
   - If the value is greater, move to the right child.
3. **Insert the node** when a `null` position is reached.

### Binary Search Tree Remove Operation

1. **Find the node** to be removed.
2. **Handle different cases**:
   - Node has no children: Simply remove the node.
   - Node has one child: Replace the node with its child.
   - Node has two children: Replace the node with its in-order successor, then remove the successor.

### Tree Traversals

- **PreOrder**: Visit root, left, right.
- **InOrder**: Visit left, root, right.
- **PostOrder**: Visit left, right, root.

## Real Code

Refer to the `BinaryTree.cs` and `BinarySearchTree.cs` files for the actual implementation of the data structures and their operations.

## Big O Time/Space Complexity

- **Add Operation**: O(h) time, where h is the height of the tree. O(1) space if done iteratively.
- **Contains Operation**: O(h) time, where h is the height of the tree. O(1) space if done iteratively.
- **Remove Operation**: O(h) time, where h is the height of the tree. O(1) space if done iteratively.
- **Traversal Operations**: O(n) time, where n is the number of nodes. O(h) space for recursion stack.


