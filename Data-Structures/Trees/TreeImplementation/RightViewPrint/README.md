
```markdown
# Binary Tree Right View Challenge

## Problem Domain

In this challenge, you need to implement a method `PrintRightView()` that prints the **right view** of a binary tree. The right view of a binary tree contains the nodes visible when the tree is viewed from the right side.

You are tasked with:
- Traversing the binary tree to capture the rightmost node at each level.
- Handling edge cases, such as an empty tree, a tree with only one node, or a tree where all nodes are on one side.

## Inputs and Expected Outputs

### Example 1:
**Input:**
```plaintext
      2
     / \
    3   5
   /     \
  4       6
   \
    7
```

**Expected Output:**
```plaintext
2 5 6 7
```

### Example 2:
**Input:** (Empty tree)
```plaintext
(None)
```

**Expected Output:**
```plaintext
Tree is empty.
```

### Example 3:
**Input:**
```plaintext
      1
       \
        2
         \
          3
           \
            4
```

**Expected Output:**
```plaintext
1 2 3 4
```

## Edge Cases

1. **Empty Tree**: The binary tree is null or does not contain any nodes. The function should handle this by printing `"Tree is empty."`.
2. **Single Node Tree**: A tree that only has a root node should return just the root node.
3. **Right-Skewed Tree**: A tree where every node only has a right child. The function should print all nodes.
4. **Left-Skewed Tree**: A tree where every node only has a left child. The function should print only the top node as the right view.

## Visual

### Right View Example:
The right view of this tree:

```plaintext
      2
     / \
    3   5
   /     \
  4       6
   \
    7
```

Will output:
```plaintext
2 5 6 7
```

### Empty Tree:
If the tree is empty:

```plaintext
(None)
```

Will output:
```plaintext
Tree is empty.
```

## Algorithm

1. Start from the root node.
2. Traverse the binary tree level by level (similar to breadth-first search).
3. For each level, print the **rightmost node**.
4. Use a queue to store the nodes while traversing the tree level by level.
5. For each level, dequeue all nodes and enqueue their left and right children (if they exist), but make sure to track the last node at each level.
6. At the end of the traversal for a level, print the rightmost node.

## Real Code

```csharp
public class BinaryTree
{
    public Node Root { get; set; }

    public void PrintRightView()
    {
        if (Root == null)
        {
            Console.WriteLine("Tree is empty.");
            return;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            Node rightMostNode = null;

            for (int i = 0; i < levelSize; i++)
            {
                Node currentNode = queue.Dequeue();

                // Keep track of the last node in this level
                rightMostNode = currentNode;

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            // Print the rightmost node of this level
            Console.Write(rightMostNode.Data + " ");
        }
    }
}

public class Node
{
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}
```

## Big O Time/Space Complexity

- **Time Complexity**: O(n), where `n` is the number of nodes in the binary tree. The method traverses each node once.
- **Space Complexity**: O(n) for the queue, which holds all the nodes at the largest level in the tree.
```

