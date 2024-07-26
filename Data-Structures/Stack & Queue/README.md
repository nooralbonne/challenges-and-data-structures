# Problem Domain
Implement basic stack and queue data structures in C#.

---

# Inputs and Expected Outputs

## Stack
- `Push(int data)`: Adds a node with the specified data to the top of the stack.
  - **Input**: `stack.Push(10)`
  - **Output**: Stack: Top -> 10
- `Pop()`: Removes and returns the top node from the stack.
  - **Input**: `stack.Pop()`
  - **Output**: 10
- `Peek()`: Returns the top node from the stack without removing it.
  - **Input**: `stack.Peek()`
  - **Output**: 10
- `IsEmpty()`: Checks if the stack is empty.
  - **Input**: `stack.IsEmpty()`
  - **Output**: true/false

## Queue
- `Enqueue(int data)`: Adds a node with the specified data to the end of the queue.
  - **Input**: `queue.Enqueue(10)`
  - **Output**: Queue: 10
- `Dequeue()`: Removes and returns the front node from the queue.
  - **Input**: `queue.Dequeue()`
  - **Output**: 10
- `Peek()`: Returns the front node from the queue without removing it.
  - **Input**: `queue.Peek()`
  - **Output**: 10
- `IsEmpty()`: Checks if the queue is empty.
  - **Input**: `queue.IsEmpty()`
  - **Output**: true/false

---

# Edge Cases
- **Stack**:
  - Popping from an empty stack should throw an exception.
  - Peeking into an empty stack should throw an exception.
- **Queue**:
  - Dequeuing from an empty queue should throw an exception.
  - Peeking into an empty queue should throw an exception.

---

# Visual
Push(10) Push(20) Pop() Peek() IsEmpty()
____ ____ ____
Top -> | 10 | -> | 20 | 10 | -> | 10 | -> | 10 | -> true/false



## Queue
Enqueue(10) Enqueue(20) Dequeue() Peek() IsEmpty()
____ ____ ____
Front -> | 10 | -> | 10 | 20 | -> | 20 | -> | 20 | -> true/false
---

# Algorithm

## Stack
1. Initialize the `top` to `null`.
2. To `Push`:
   - Create a new node.
   - Point the new node's `Next` to the current `top`.
   - Update `top` to the new node.
3. To `Pop`:
   - Check if the stack is empty.
   - Store the `top` node's data.
   - Update `top` to `top.Next`.
   - Return the stored data.
4. To `Peek`:
   - Check if the stack is empty.
   - Return `top` node's data.
5. To `IsEmpty`:
   - Return `true` if `top` is `null`, else `false`.

## Queue
1. Initialize `front` and `rear` to `null`.
2. To `Enqueue`:
   - Create a new node.
   - If `rear` is not `null`, set `rear.Next` to the new node.
   - Update `rear` to the new node.
   - If `front` is `null`, set `front` to `rear`.
3. To `Dequeue`:
   - Check if the queue is empty.
   - Store the `front` node's data.
   - Update `front` to `front.Next`.
   - If `front` is `null`, set `rear` to `null`.
   - Return the stored data.
4. To `Peek`:
   - Check if the queue is empty.
   - Return `front` node's data.
5. To `IsEmpty`:
   - Return `true` if `front` is `null`, else `false`.


## Big O Time/Space Complexity

Stack
Push: O(1) time, O(1) space
Pop: O(1) time, O(1) space
Peek: O(1) time, O(1) space
IsEmpty: O(1) time, O(1) space
Queue
Enqueue: O(1) time, O(1) space
Dequeue: O(1) time, O(1) space
Peek: O(1) time, O(1) space
IsEmpty: O(1) time, O(1) space