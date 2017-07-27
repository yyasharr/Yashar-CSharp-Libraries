# Yashar-CSharp-Libraries
Some useful C# libraries developed by me with implementing useful methods.
Below are the list of classes and methods provided in the project.

# Table of contents
  * [Data Structures](#data-structures)
    * [LinkedList Node](#linkedlist_node)
    * [Max Heap](#maxheap)
    * [Min Heap](#minheap)
    * [Trie](#trie)
    * [Trie Node](#trienode)
    

# Data Structures
### LinkedList_Node
A singly LinkedList data structure of generic type.
- `public LinkedList_Node(T data)` - Creates a LinkedList node with the given data (constructor).
- `public void Print()` - Prints the LinkedList to Console.
- `public override string ToString()` - Prints the LinkedList to string.
- `public List<LinkedList_Node<T>> ToList()` - Inserts nodes of the LinkedList to a list and returns it.
- `public void AddToEnd(T data)` - Creates a new LinkedList node and puts in at the end of the LinkedList.
- `public void AddToEnd(LinkedList_Node<T> new_node)` - Puts the given LinkedList node at the end of the LinkedList.
- `public LinkedList_Node<T> AddToFront(T data)` - Creates a new LinkedList node and puts it in front of the LinkedList as the first node and returns it.
- `public LinkedList_Node<T> AddToFront(LinkedList_Node<T> new_node)` - Puts the new LinkedList node in front of the list and returns it.
- `public LinkedList_Node<T> Reverse()` - Reverses the whole LinkedList and returns the current head of the list.
### MaxHeap
A MaxHeap data structures which implements a complete tree for which each root is bigger or equal than both the children.
- `public MaxHeap()` - Creates an empty MaxHeap of generic type (Constructor).
- `public T Max` - Returns the maximum value of the MaxHeap, throws null exception if empty.
- `public bool IsEmpty()` - Returns true if the heap is empty, false otherwise.
- `public int Count` - Returns number of elements in the heap. 0 if empty.
- `public void Insert(T data)` - Inserts a new value to the MaxHeap and reforms the heap by maintaining the MaxHeap properties.
- `public T ExtractMax()` - Removes the maximum element of the MaxHeap, reforms the heap and returns the maximum element.
### MinHeap
A MinHeap data structure which implements a complete tree for which each root is bigger or equal than both the children.
- `public MinHeap()` - Creates an empty MinHeap of generic type (constructor).
- `public T Min` - Returns the minimum value of the MinHeap, throws null exception of empty.
- `public bool IsEmpty()` - Returns true if the heap is empty, false otherwise.
- `public int Count` - Returns the number of elements in the heap. 0 if empty.
- `public void Insert(T data)` - Inserts a new value to the MinHeap and reforms the heap by maintaining the MinHeap properties.
- `public T ExtractMin()` - Removes the minimum element of the MinHeap, reforms the heap and returns the minimum element.
### Trie
The Trie data structure implementation, which only supports small characters (a-z).
- `public Trie()` - Creates a new Trie data structure and creates an empty TrieNode as root which doens't hold any character (constructor).
- `public void Insert(string word)` - Inserts a word into the trie.
- `public bool Search(string word)` - Retruns true if the given word is found in the trie, false otherwise.
- `public List<string> Suggestions(string prefix)` - Generates and returns the list of the suggestions, which are the words that can be created with the given prefix.
- `public bool StartsWith(string prefix)` - Returns true if there is any word in the trie that starts with the given prefix, false otherwise.
### TrieNode
A node of the Trie data structure. Each node can either have no character (root of the trie) or have small letters assigned to it (a-z).
- `public TrieNode()` - Creates a new TrieNode which doesn't have any character and only used as the root of the trie (constructor).
- `public TrieNode(char ch)` - Creates a new TrieNode and assigns the character ch to the node (constructor).
- `public char C` - Gets the character assigned to this node.
- `public TrieNode[] Children` - Gets the list of the children mappings for this node.
- `public bool IsLeaf` - Return true if this current node (character) ends up to a complete word.
