# Linked List Rotation

## Problem Domain
Given a singly linked list and an integer `k`, rotate the linked list to the left by `k` places. After rotating, the node which was originally at position `k` will now become the head of the list, and the remaining nodes will follow.

### Requirements
- Use your existing `Node` and `LinkedList` classes.
- Implement a method `RotateLeft(int k)` in your `LinkedList` class.
- Ensure the `PrintList()` method displays the rotated list.
- **Hint**: You need to traverse the list to calculate its length first.

## Inputs and Expected Outputs
- **Input**: 
  - A singly linked list (e.g., `5 -> 20 -> 20 -> 10 -> 5 -> 10 -> Null`)
  - An integer `k` (e.g., `2`)

- **Output**:
  - A rotated linked list after moving the head to the node at position `k`:
    - For `k = 2`: The output will be `20 -> 20 -> 10 -> 5 -> 10 -> 5 -> Null`
    - For `k = 0`: The output will remain unchanged: `5 -> 20 -> 20 -> 10 -> 5 -> 10 -> Null`
    - For `k = 7` (greater than the length): The output will still correctly reflect the rotated list due to modulo operation.

## Edge Cases
- Rotating the list by `0` should leave the list unchanged.
- Rotating the list by a value greater than the length of the list should correctly wrap around and still function as expected.
- An empty linked list should not throw an error and should remain unchanged.

## Visual
![ Code](https://github.com/nooralbonne/challenges-and-data-structures/blob/Linked-List-Rotate-K/Data-Structures/LinkedList/LinkedList/LinkedList/RotateLinkedList/LinkedListRotation.jpg)

## Algorithm
1. **Calculate Length**: Traverse the linked list to determine its length.
2. **Adjust `k`**: If `k` is greater than the length, use `k = k % length` to avoid unnecessary rotations.
3. **Find the New Head**:
   - Traverse to the `k`-th node and keep a reference to it as the new head.
4. **Reconnect Nodes**: 
   - Traverse to the end of the list and link the last node to the original head.
   - Set the `k`-th node's `Next` pointer to `null` to terminate the rotated list.
5. **Update Head**: Assign the new head to the linked list.


## Big O Time/Space Complexity
- **RotateLeft**: 
  - **Time Complexity**: O(n) 
    - Where n is the length of the linked list. The method requires a traversal of the list to calculate its length and to find the `k`-th node.
  - **Space Complexity**: O(1) 
    - The algorithm uses a fixed amount of space for pointers and does not create any new data structures based on input size.


