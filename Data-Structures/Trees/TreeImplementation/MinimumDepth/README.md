## Problem Domain
Given a binary tree, find its minimum depth. The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

## Inputs and Expected Outputs

| Input                                 | Expected Output |
|---------------------------------------|-----------------|
| Empty tree                            | 0               |
| Tree with a single node               | 1               |
| Binary tree with multiple nodes       | Integer representing the minimum depth |

### Example

**Tree Example 1:**
     1
   /   \
  2     3
 / \
4   5


Expected Output: `2` (The minimum depth is along the right subtree from node 1 to node 3)

**Tree Example 2:**

     1
   /   \
  2     3
   \     \
    5     6

    
Expected Output: `3` (Both left and right subtrees have a depth of 3)

## Edge Cases
- The tree is empty: the minimum depth is `0`.
- The tree consists of only one node: the minimum depth is `1`.
- The tree has multiple nodes with the same depth for left and right subtrees.
- The tree is highly unbalanced (one side is much deeper than the other).

## Visual

![Tree Diagram](https://github.com/nooralbonne/challenges-and-data-structures/blob/Max-Level-Nodes/Data-Structures/Trees/TreeImplementation/MaxLevelNodes/maxNumberOfNodes.jpg)

## Algorithm
1. **Base case**: If the root is `null`, the tree is empty, return `0`.
2. **Recursion**:
   - If a node is a leaf node (i.e., both left and right children are `null`), return `1`.
   - Otherwise, recursively find the minimum depth of the left and right subtrees.
   - Take the smaller depth of the two subtrees and add `1` for the current node.
3. Return the minimum depth of the tree.


## Big O Time/Space Complexity

- **Time Complexity**: `O(n)` where `n` is the number of nodes in the tree. We traverse each node once to determine the minimum depth.
- **Space Complexity**: `O(h)` where `h` is the height of the tree. This is due to the recursion stack during tree traversal, and in the worst case (for a skewed tree), this can be `O(n)`.

