# Binary Tree: Largest Value at Each Level

## Problem Domain
Using your binary tree implementation, find the largest value at each level of the binary tree.

## Challenge Description
Implement a method `LargestValueEachLevel()` that returns a list of the largest values at each level of the binary tree. Traverse the tree level by level and keep track of the maximum value at each level. Ensure all exceptions are handled during execution.

## Inputs and Expected Outputs
- **Input:** A binary tree with various integer nodes.
- **Output:** A list of integers representing the largest value at each level of the tree.

## Example

Given the binary tree:
    10
   /  \
  5    20
 / \   / \
3   7 15  25

The method `LargestValueEachLevel()` would return `[10, 20, 25]`.

- **Output:** [5, 13, 20, 11]

## Edge Cases
- A tree with a single node should return a list with that node's value.
- An empty tree should return an empty list.
- Trees with duplicate values should correctly handle and return the largest value at each level.

## Visual Representation
Here's a visual representation of the binary tree used in the example:

        10
       /  \
      5    20
     / \   / \
    3   7 15  25

 ## Algorithm
1. Initialize a queue with the root node.
2. Traverse the tree level by level.
3. For each level, determine the maximum value.
4. Store the maximum value in a list.
5. Return the list after completing the traversal.

## Big O Time/Space Complexity
- **Time Complexity:** O(n), where n is the number of nodes in the tree. The method traverses each node once.
- **Space Complexity:** O(m), where m is the maximum number of nodes at any level (the width of the tree). This space is needed to store nodes in the queue during the traversal.
