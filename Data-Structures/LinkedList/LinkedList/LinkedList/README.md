# Table of Contents
[Linked-List-Code](Data-Structures/LinkedList/LinkedList/LinkedList/Linked-List.jpg)

[Linked-List-Explanation](Data-Structures/LinkedList/LinkedList/LinkedList/Linked-List-Explanation.jpg)

# LinkedList Implementation

This project implements a basic singly linked list data structure in C#.

## Classes

- `Node`: Represents a node in the linked list with properties for data and the next node reference.
- `LinkedList`: Represents the linked list with methods for adding nodes, removing nodes, checking for the existence of a node, and printing the list.

## Methods

- `Add(int data)`: Adds a node with the specified data to the end of the list.
- `Includes(int data)`: Checks if the list contains a node with the specified data.
- `Remove(int data)`: Removes the first node with the specified data from the list.
- `PrintList()`: Prints the contents of the list in order.

## Example

```csharp
LinkedList list = new LinkedList();
list.Add(5);
list.Add(10);
list.Add(20);
list.PrintList(); // Output: Head -> 5 -> 10 -> 20 -> Null

list.Remove(10);
list.PrintList(); // Output: Head -> 5 -> 20 -> Null
