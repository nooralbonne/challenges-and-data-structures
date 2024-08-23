# Binary Tree Leaf Sum

## Problem Domain
Implement a method `LeafSum()` that calculates the sum of all leaf nodes in a binary tree. A leaf node is defined as a node that does not have any children.

### Example:
Given the binary tree:

        9
       / \
      8   12
     / \  / \
    3   7 17 23
     \
      4

The leaf nodes are `4, 7, 17, and 23`.  
The sum of the leaf nodes is `4 + 7 + 17 + 23 = 51`.

## Inputs and Expected Outputs

| Input                | Expected Output |
|----------------------|-----------------|
| A binary tree object | Sum of leaf nodes (integer) |

## Edge Cases
- The binary tree is empty (no nodes).  
- The binary tree has only one node (the root is the only leaf).  
- The binary tree has negative values in the leaf nodes.

## Visual
Here's a visual representation of the binary tree used in the example:

        9
       / \
      8   12
     / \  / \
    3   7 17 23
     \
      4

The leaf nodes are `4, 7, 17, and 23`. The sum is `51`.

## Algorithm
1. Start from the root node.
2. Recursively traverse the tree to find all leaf nodes.
3. If a node is a leaf (i.e., both left and right children are null), add its value to a sum accumulator.
4. Return the sum of all leaf nodes.

## Real Code

```csharp
public int SumOfLeafNodes()
{
    return SumOfLeafNodesHelper(Root);
}

private int SumOfLeafNodesHelper(Node node)
{
    if (node == null)
    {
        return 0;
    }

    // If node is a leaf
    if (node.Left == null && node.Right == null)
    {
        return node.Data;
    }

    // Recursively sum the leaves
    return SumOfLeafNodesHelper(node.Left) + SumOfLeafNodesHelper(node.Right);
}
```

## Big O Time/Space Complexity:

Time Complexity: O(n) where n is the number of nodes in the tree. The algorithm visits each node once.
Space Complexity: O(h) where h is the height of the tree, due to the recursive call stack.