# BinaryTreeToBST Function

## Problem Domain

The `BinaryTreeToBST` function takes a binary tree (BT) as input and rearranges it to form a binary search tree (BST) with the same set of nodes. In a BST, each node's left subtree only contains nodes with values less than the node's value, and the right subtree only contains nodes with values greater than the node's value. This conversion maintains the structure of a BST while preserving all the values from the original binary tree.

## Inputs and Expected Outputs

- **Input**: A binary tree with unsorted node values.
- **Output**: A binary search tree containing the same values from the original binary tree, but rearranged to satisfy BST properties.

### Example

- **Input**:
    ```
         10
       /    \
      5      20
     / \    /  \
    3   7  15  25
    ```

- **Output**:
    ```
         15
       /    \
      5      20
     / \    /  \
    3   7  10  25
    ```
  - The in-order traversal of this BST would yield: `[3, 5, 7, 10, 15, 20, 25]`.

## Edge Cases

1. **Empty Tree**: If the input binary tree is `null`, the function should return `null`.
2. **Single Node**: If the binary tree contains only one node, the BST should also be a single-node tree with the same value.
3. **All Nodes with Same Value**: If all nodes have identical values, the BST will simply mirror the structure of the original tree since all values satisfy BST properties.
4. **Already a BST**: If the input tree is already a BST, the output should remain structurally the same.

## Visual

- **Binary Tree**:
    ```
         10
       /    \
      5      20
     / \    /  \
    3   7  15  25
    ```

- **Converted BST**:
    ```
         15
       /    \
      5      20
     / \    /  \
    3   7  10  25
    ```

## Algorithm

1. **Traverse and Collect**:
   - Perform an in-order traversal of the binary tree and collect all node values into a list.
2. **Sort Values**:
   - Sort the list of values. Sorting ensures that when values are inserted back, they satisfy the BST properties.
3. **Reconstruct BST**:
   - Using the sorted list, recursively build the BST by selecting the middle element of the list as the root, left of the middle for the left subtree, and right of the middle for the right subtree.
4. **Return the BST Root**:
   - Return the root of the newly constructed BST.


## Big O Time/Space Complexity

- **Time Complexity**: `O(n log n)`
  - Traversing the binary tree takes `O(n)`, where `n` is the number of nodes.
  - Sorting the values takes `O(n log n)`.
  - Reconstructing the BST from the sorted list also takes `O(n)`.

- **Space Complexity**: `O(n)`
  - The space complexity is `O(n)` due to the additional list that stores node values during traversal and the recursion stack during BST reconstruction.
