using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yashar
{

    namespace DataStructures
    {
        public class Treenode : IComparable
        {
            int _data;
            Treenode _left;
            Treenode _right;

            public int Data { get => _data; set => _data = value; }
            public Treenode Left { get => _left; set => _left = value; }
            public Treenode Right { get => _right; set => _right = value; }

            /// <summary>
            /// Creates a binary Treenode with the given integar as its value.
            /// </summary>
            /// <param name="data"></param>
            public Treenode(int data)
            {
                _data = data;
            }

            /// <summary>
            /// Returns a list of Treenodes, sorted as inorder traversal.
            /// </summary>
            /// <returns></returns>
            public List<int> InOrderTraversal()
            {
                List<int> nodes = new List<int>();
                this.InOrderTraversal_Helper(nodes);
                return nodes;
            }
            private void InOrderTraversal_Helper(List<int> nodes)
            {
                if (this == null) return;

                if (this.Left != null)
                    this.Left.InOrderTraversal_Helper(nodes);

                nodes.Add(this.Data);

                if (this.Right != null)
                    this.Right.InOrderTraversal_Helper(nodes);
            }

            /// <summary>
            /// Returns a list of Treenodes, sorted as preorder traversal.
            /// </summary>
            /// <returns></returns>
            public List<int> PreOrderTraversal()
            {
                List<int> nodes = new List<int>();
                this.PreOrderTraversal_Helper(nodes);
                return nodes;
            }

            private void PreOrderTraversal_Helper(List<int> nodes)
            {
                if (this == null) return;

                nodes.Add(this.Data);

                if (this.Left != null)
                    this.Left.PreOrderTraversal_Helper(nodes);

                if (this.Right != null)
                    this.Right.PreOrderTraversal_Helper(nodes);
            }

            /// <summary>
            /// Returns a list of Treenodes, sorted as postorder traversal.
            /// </summary>
            /// <returns></returns>
            public List<int> PostOrderTraversal()
            {
                List<int> nodes = new List<int>();
                this.PostOrderTraversal_Helper(nodes);
                return nodes;
            }
            private void PostOrderTraversal_Helper(List<int> nodes)
            {
                if (this == null)
                    return;

                if (this.Left != null)
                    this.Left.PostOrderTraversal_Helper(nodes);

                if (this.Right != null)
                    this.Right.PostOrderTraversal_Helper(nodes);

                nodes.Add(this.Data);
            }

            /// <summary>
            /// Returns the height (depth) of the binary tree. (0 if null)
            /// </summary>
            /// <returns></returns>
            public int Height()
            {
                return Height(this);
            }
            static int Height(Treenode root)
            {
                if (root == null)
                    return 0;
                return Math.Max(Height(root.Left), Height(root.Right)) + 1;
            }


            /// <summary>
            /// Compares the data of this node with another given node. If this is greater than other, return 1. Otherwise 0 and 1 for equal or smaller respectively.
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public int CompareTo(Treenode other)
            {
                return this.Data.CompareTo(other.Data);
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Returns true if the tree starting at this Treenode is a Binary Search Tree.
            /// </summary>
            /// <returns></returns>
            public bool ValidateBST()
            {
                return ValidateBST(this, int.MinValue, int.MaxValue);
            }
            private bool ValidateBST(Treenode root, int minValue, int maxValue)
            {
                if (root == null) return true;

                if (root.Data >= maxValue || root.Data < minValue) return false;

                return ValidateBST(root.Left, minValue, root.Data) && ValidateBST(root.Right, root.Data, maxValue);
            }

            /// <summary>
            /// Deletes a node with the data of the given key from the BST and returns the new root. Returns the current root if it's not a binary search tree.
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public Treenode DeleteNode_BST(int key)
            {
                if (this == null || this.ValidateBST() == false) return this;

                if (key > this.Data)
                    this.Right = this.Right.DeleteNode_BST(key);

                else if (key < this.Data)
                    this.Left = this.Left.DeleteNode_BST(key);

                else
                {
                    if (this.Left == null)
                        return this.Right;

                    if (this.Right == null)
                        return this.Left;

                    this.Data = this.Left.FindBiggestOnLeft();

                    this.Left = this.Left.DeleteNode_BST(this.Data);
                }
                return this;
            }
            private int FindBiggestOnLeft()
            {
                if (this.Right == null) return this.Data;

                return this.Right.FindBiggestOnLeft();
            }

            /// <summary>
            /// Returns true if the tree starting at this node is balanced, false otherwise.
            /// </summary>
            /// <returns></returns>
            public bool IsBalanced()
            {
                return IsBalanced(this);
            }
            bool IsBalanced(Treenode root)
            {
                if (root == null) return true;

                int left_height = Height(root.Left);
                int right_height = Height(root.Right);

                if (Math.Abs(left_height - right_height) > 1) return false;

                return IsBalanced(root.Left) && IsBalanced(root.Right);
            }

            /// <summary>
            /// Returns the lowest common ancestor of a binary search tree. Will throw an exception if it's not BST.
            /// </summary>
            /// <param name="n1"></param>
            /// <param name="n2"></param>
            /// <returns></returns>
            public Treenode LowestCommonAncestor_BST(Treenode n1, Treenode n2)
            {
                if (this.ValidateBST() == false) throw new InvalidOperationException("This is not a BST. You can use the regular Lowest Common Ancestor API.");

                return LowestCommonAncestor_BST_helper(n1, n2);

            }
            private Treenode LowestCommonAncestor_BST_helper(Treenode n1, Treenode n2)
            {
                if (this.Data > n1.Data && this.Data > n2.Data) //we should go right
                    return this.Left.LowestCommonAncestor_BST_helper(n1, n2);

                else if (this.Data < n1.Data && this.Data < n2.Data)
                    return this.Right.LowestCommonAncestor_BST(n1, n2);

                else
                    return this;

            }

            /// <summary>
            /// Returns the lowest common ancestor of a binary tree. Will return null if either of the nodes do not exist in the tree.
            /// </summary>
            /// <param name="n1"></param>
            /// <param name="n2"></param>
            /// <returns></returns>
            public Treenode LowestCommonAncestor(Treenode n1, Treenode n2)
            {
                if (!this.FindNode(n1) || !this.FindNode(n2)) return null;

                return LowestCommonAncestor_Helper(n1, n2);
            }
            private Treenode LowestCommonAncestor_Helper(Treenode n1, Treenode n2)
            {
                if (this == null) return null;

                if (this.Data == n1.Data) return n1;
                if (this.Data == n2.Data) return n2;

                bool IsN1Left = this.Left.FindNode(n1);
                bool IsN2Left = this.Left.FindNode(n2);

                if (IsN1Left && IsN2Left) return this.Left.LowestCommonAncestor_Helper(n1, n2);
                else if (!IsN1Left && !IsN2Left) return this.Right.LowestCommonAncestor_Helper(n1, n2);
                else return this;
            }
            private bool FindNode(Treenode n)
            {
                if (this == null) return false;
                if (this.Data == n.Data) return true;

                return this.Left.FindNode(n) || this.Right.FindNode(n);
            }

            /// <summary>
            /// Diameter of this binary tree, which is the longest path between any two node inside the tree.
            /// </summary>
            /// <returns></returns>
            public int Diameter()
            {
                return Diameter(this);
            }
            private int Diameter(Treenode root)
            {
                if (root == null) return 0;

                int leftheight = Height(root.Left);
                int rightheight = Height(root.Right);
                
                int curr = leftheight + rightheight;

                int leftdiameter = Diameter(root.Left);
                int rightdiameter = Diameter(root.Right);

                return Math.Max(curr, Math.Max(leftdiameter, rightdiameter));
            }

            /// <summary>
            /// Prints the entire tree on a Windows Form.
            /// </summary>
            public void Print()
            {
                TreeView tv = FillTreeView();
                Yashar.UI.TreeUIForm tf = new UI.TreeUIForm(tv);
                Application.Run(tf);
            }
            private TreeView FillTreeView()
            {
                TreeView treeview = new TreeView();

                Queue<Treenode> treenodeQ = new Queue<Treenode>();
                treenodeQ.Enqueue(this);

                Queue<TreeNode> treeviewQ = new Queue<TreeNode>();
                TreeNode first = new TreeNode(this.Data.ToString());
                treeview.Nodes.Add(first);
                treeviewQ.Enqueue(first);

                treeview.BeginUpdate();

                while (treenodeQ.Any())
                {
                    Treenode tempnode = treenodeQ.Dequeue();
                    TreeNode tempNode = treeviewQ.Dequeue();

                    if (tempnode.Left != null)
                    {
                        treenodeQ.Enqueue(tempnode.Left);

                        TreeNode left = new TreeNode("L:" + tempnode.Left.Data);
                        tempNode.Nodes.Add(left);
                        treeviewQ.Enqueue(left);
                    }
                    if (tempnode.Right != null)
                    {
                        treenodeQ.Enqueue(tempnode.Right);

                        TreeNode right = new TreeNode("R:" + tempnode.Right.Data);
                        tempNode.Nodes.Add(right);
                        treeviewQ.Enqueue(right);
                    }
                }

                treeview.EndUpdate();
                return treeview;
            }
        }
    }
}
