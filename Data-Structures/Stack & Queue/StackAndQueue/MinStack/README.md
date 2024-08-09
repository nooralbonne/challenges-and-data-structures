# MinStack Implementation

## Overview

The `MinStack` class implements a stack that supports the following operations in constant time complexity:
- `Push(int x)`: Add an element to the stack.
- `Pop()`: Remove and return the top element from the stack.
- `Top()`: Return the top element from the stack without removing it.
- `IsEmpty()`: Check if the stack is empty.
- `GetMin()`: Return the minimum element in the stack.
- `PrintStack()`: Print the contents of the stack.

## Whiteboard Image

![MinStack Image](https://github.com/nooralbonne/challenges-and-data-structures1/blob/Min-Stack/Data-Structures/Stack%20%26%20Queue/StackAndQueue/MinStack/MinStacks.jpg)

## Problem Domain

The problem involves implementing a stack that not only supports basic stack operations but also allows retrieving the minimum element in constant time. This is achieved by maintaining two stacks: one for the actual data and another to keep track of the minimum values.

## Inputs and Expected Outputs

### Inputs
- **Push(int x)**: An integer `x` to be pushed onto the stack.
- **Pop()**: Removes the top element from the stack.
- **Top()**: Returns the top element of the stack without removing it.
- **GetMin()**: Retrieves the minimum element from the stack.
- **PrintStack()**: Prints the elements of the stack from top to bottom.

### Expected Outputs
- **Push(int x)**: No output. Modifies the stack.
- **Pop()**: Returns the removed top element.
- **Top()**: Returns the current top element.
- **GetMin()**: Returns the current minimum element.
- **PrintStack()**: Outputs the stack contents in a readable format.

## Edge Cases

- **Popping from an empty stack**: Should throw an `InvalidOperationException`.
- **Getting minimum from an empty stack**: Should throw an `InvalidOperationException`.
- **Handling duplicate elements**: Ensure that duplicates do not affect the correctness of the `GetMin()` method.
- **Push and Pop operations**: Ensure that the stack updates correctly and maintains the correct minimum value.

## Visual

The visual representation of the stack and minimum tracking:
1. **Push**: Adds an element to the top of the stack and updates the minimum stack.
2. **Pop**: Removes the top element from the stack and, if it's the current minimum, also removes it from the minimum stack.
3. **GetMin**: Retrieves the top element of the minimum stack, which is the current minimum in the main stack.

## Algorithm

1. **Push(int x)**
   - Push `x` onto the `stack`.
   - If `minStack` is empty or `x` is less than or equal to the top of `minStack`, push `x` onto `minStack`.

2. **Pop()**
   - Pop the top element from the `stack`.
   - If the popped element is equal to the top of `minStack`, pop from `minStack`.

3. **Top()**
   - Return the top element of the `stack`.

4. **GetMin()**
   - Return the top element of `minStack`.

5. **PrintStack()**
   - Iterate through the `stack` and print its elements from top to bottom.

## MinStack Class Complexity

- Time Complexity for Push, Pop, Top, IsEmpty, and GetMin operations is O(1).
- Space Complexity is O(n) for Push, where n is the number of elements in the stack. For other operations, the space complexity is O(1) beyond the existing stack size.