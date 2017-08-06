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
    * [Tree Node](#treenode)
* [Common Methods](#common-methods)
    * [Print](#print)
        * [ToConsole](#toconsole)
        * [ToForm](#toform)
    * [Sort](#sort)
        * [MergeSort()](#mergesort)
        * [QuickSort()](#quicksort)
    

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
### Treenode
Implementation of a node of a binary tree, where each node can have a left or right child node.
- `public Treenode(int data)` - Creates a binary Treenode with the given integar as its value.
- `public List<int> InOrderTraversal()` - Returns a list of Treenodes, sorted as inorder traversal.
- `public List<int> PreOrderTraversal()` - Returns a list of Treenodes, sorted as preorder traversal.
- `public List<int> PostOrderTraversal()` - Returns a list of Treenodes, sorted as postorder traversal.
- `public int Height()` - Returns the height (depth) of the binary tree. (0 if null)
- `public int CompareTo(Treenode other)` - Compares the data of this node with another given node. If this is greater than other, return 1. Otherwise 0 and 1 for equal or smaller respectively.
- `public bool ValidateBST()` - Returns true if the tree starting at this Treenode is a Binary Search Tree.
- `public Treenode DeleteNode_BST(int key)` - Deletes a node with the data of the given key from the BST and returns the new root.
- `public void Print()` - Prints the entire tree on a Windows Form.
Returns the current root if it's not a binary search tree.
- `public bool IsBalanced()` - Returns true if the tree starting at this node is balanced, false otherwise.
- `public Treenode LowestCommonAncestor_BST(Treenode n1, Treenode n2)` - Returns the lowest common ancestor of a binary search tree. Will throw an exception if it's not BST.
- `public Treenode LowestCommonAncestor(Treenode n1, Treenode n2)` - Returns the lowest common ancestor of a binary tree. Will return null if either of the nodes do not exist in the tree.
- `public int Diameter()` - Diameter of this binary tree, which is the longest path between any two node inside the tree.

# Common Methods
The method has been declared as an '*extension method*' which allows the use of the method on the DataType or Collection itself.

For example, below code can be written:
```
int[] array = { 3, 7, 5, 2, 10 };
array.QuickSort();
array.ToConsole();
```
### Print
Implementation of printing different collections and 2D arrays. Contains below functions:
##### ToConsole()
This method currently overloads 9 types:
- ICollection<int> | ICollection<string> | ICollection<char>
- int[,] | string[,] | char[,]
- List<List<int>> | List<List<string>> | List<List<char>>
##### ToForm()
This method currently overloads 1 type:
- Treenode; i.e. Yashar.DataStructures.Treenode
 
### Sort
Implementatoin of sorting algorithms and perform on array of integers. Contains below functions:
##### MergeSort()
Sorts a given array of integers, using MergeSort algorithm. Also can be used as int[].MergeSort().
##### QuickSort()
Sorts a given array of integers, using QuickSort algorithm. Also can be used as int[].QuickSort().
