## Problem Domain
The task is to implement various methods for a BinaryTree class in C#, including finding the level with the most nodes, calculating the sum of leaf nodes, and identifying the second maximum node in the tree.

## Inputs and Expected Outputs
- **Input:** A binary tree.
- **Output:** 
  - `FindMaxLevelNodes`: The level with the maximum number of nodes.
  - `LeafSum`: The sum of all leaf nodes.
  - `FindSecondMax`: The second largest node in the tree.

## Edge Cases
- Empty tree.
- Tree with only one node.
- Tree with multiple levels, but unevenly distributed.

## Visual
Here’s a visual representation of a sample binary tree:

      10
     /  \
    5    20
   / \   / \
  3   7 15  25


- Leaf nodes are 3, 7, 15, 25.
- The second maximum value is 20.
- The level with the maximum nodes is level 2.

## Algorithm
- **FindMaxLevelNodes:** Traverse each level and count the nodes, track the level with the most nodes.
- **LeafSum:** Traverse the tree recursively, summing up the leaf node values.
- **FindSecondMax:** Traverse the tree to find the maximum, then remove it and find the next largest value.

## Real Code
![Max Level Nodes](https://github.com/nooralbonne/challenges-and-data-structures/blob/Max-Level-Nodes/Data-Structures/Trees/TreeImplementation/MaxLevelNodes/maxNumberOfNodes.jpg)


## Big O Time/Space Complexity
- **Time Complexity:**
  - `FindMaxLevelNodes`: O(n), where n is the number of nodes.
  - `LeafSum`: O(n), where n is the number of nodes.
  - `FindSecondMax`: O(n), where n is the number of nodes.
  
- **Space Complexity:**
  - All methods: O(h), where h is the height of the tree, due to recursion stack space.
