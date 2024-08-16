# MirrorTree Challenge

## Problem Domain
A mirror tree of a binary tree is a tree that looks exactly like the original binary tree but with all the left and right children swapped at every node. The task is to convert the given binary tree into its mirror tree and perform an inorder traversal to verify the conversion.

## Inputs and Expected Outputs

### Input
- A binary tree with nodes containing integer values.
  
### Expected Outputs
- A binary tree where every left child is swapped with its corresponding right child.
- The inorder traversal list before and after mirroring.

### Example

**Input Binary Tree:**
      4
     / \
    8   7
   / \
 12   9
 
**Original InOrder Traversal:**
[12, 8, 9, 4, 7]

**Mirrored Binary Tree:**
  4
 / \
7   8
   / \
  9  12
  
**Mirrored InOrder Traversal:**
[7, 4, 9, 8, 12]


## Edge Cases
- **Empty Tree**: When the binary tree is empty, the mirror operation should handle it gracefully and return an empty traversal.
- **Single Node Tree**: A binary tree with only one node should remain unchanged after the mirror operation.

## Visual
Here's a visual representation of the mirror operation:

### Before Mirroring:
      4
     / \
    8   7
   / \
 12   9
 
### After Mirroring:
  4
 / \
7   8
   / \
  9  12

  
## Algorithm
1. Start at the root of the binary tree.
2. Traverse the tree recursively:
   - Swap the left and right children of the current node.
   - Recursively mirror the left subtree.
   - Recursively mirror the right subtree.
3. Return the mirrored tree.
4. Perform an inorder traversal on the mirrored tree to verify the conversion.

## Big O Time/Space Complexity
- **Time Complexity**: `O(n)`, where `n` is the number of nodes in the binary tree. Each node is visited exactly once.
- **Space Complexity**: `O(h)`, where `h` is the height of the tree. This is due to the recursion stack during the traversal.
