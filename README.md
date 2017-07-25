# Yashar-CSharp-Libraries
Some useful C# libraries developed by me with implementing useful methods.
Below are the list of classes and methods provided in the project:

# Data Structures
- ### LinkedList_Node
A singly LinkedList data structure of generic type.
- public LinkedList_Node(T data)` - Creates a LinkedList node with the given data (constructor).
- `public void Print()` - Prints the LinkedList to Console.
- `public override string ToString()` - Prints the LinkedList to string.
- `public List<LinkedList_Node<T>> ToList()` - Inserts nodes of the LinkedList to a list and returns it.
- `public void AddToEnd(T data)` - Creates a new LinkedList node and puts in at the end of the LinkedList.
- `public void AddToEnd(LinkedList_Node<T> new_node)` - Puts the given LinkedList node at the end of the LinkedList.
- `public LinkedList_Node<T> AddToFront(T data)` - Creates a new LinkedList node and puts it in front of the LinkedList as the first node and returns it.
- `public LinkedList_Node<T> AddToFront(LinkedList_Node<T> new_node)` - Puts the new LinkedList node in front of the list and returns it.
- `public LinkedList_Node<T> Reverse()` - Reverses the whole LinkedList and returns the current head of the list.
