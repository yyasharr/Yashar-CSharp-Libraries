using System;
using System.Collections.Generic;

namespace Yashar
{
    namespace DataStructures
    {
        public class LinkedList_Node<T> where T : IComparable
        {
            T _data;
            LinkedList_Node<T> _next;

            /// <summary>
            /// Creates a LinkedList node with the given data.
            /// </summary>
            /// <param name="data"></param>
            public LinkedList_Node(T data)
            {
                _data = data;
                _next = null;
            }

            public T Data
            {
                get { return _data; }
                set { _data = value; }
            }

            public LinkedList_Node<T> Next
            {
                get { return _next; }
                set { _next = value; }
            }


            /// <summary>
            /// Prints the LinkedList to Console.
            /// </summary>
            public void Print()
            {
                if (this == null)
                    Console.WriteLine("null");
                else
                {
                    Console.Write(this._data + "->");
                    this.Next.Print();
                }
            }


            /// <summary>
            /// Prints the LinkedList to string.
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return this.ToStringHelper("");
            }

            private string ToStringHelper(string str)
            {
                if (this == null)
                {
                    str += this.Data;

                }
                else
                {
                    str += this.Data + "->";
                    this.Next.ToStringHelper(str);
                }
                return str;
            }


            /// <summary>
            /// Inserts nodes of the LinkedList to a list and returns it.
            /// </summary>
            /// <returns></returns>
            public List<LinkedList_Node<T>> ToList()
            {
                return this.ToListHelper(new List<LinkedList_Node<T>>());
            }

            private List<LinkedList_Node<T>> ToListHelper(List<LinkedList_Node<T>> list)
            {
                if (this != null)
                {
                    list.Add(this);
                    this.Next.ToListHelper(list);
                }
                return list;
            }

            /// <summary>
            /// Creates a new LinkedList node and puts in at the end of the LinkedList.
            /// </summary>
            /// <param name="data"></param>
            public void AddToEnd(T data)
            {
                LinkedList_Node<T> new_node = new LinkedList_Node<T>(data);

                LinkedList_Node<T> current = this;

                while(current.Next!=null)
                {
                    current = current.Next;
                }

                current.Next = new_node;
            }

            /// <summary>
            /// Put the given LinkedList node at the end of the LinkedList.
            /// </summary>
            /// <param name="data"></param>
            public void AddToEnd(LinkedList_Node<T> new_node)
            {
                LinkedList_Node<T> current= this;

                while (current.Next != null)
                    current = current.Next;

                current.Next = new_node;
            }

            /// <summary>
            /// Creates a new LinkedList node and puts it in front of the LinkedList as the first node and returns it.
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            public LinkedList_Node<T> AddToFront(T data)
            {
                LinkedList_Node<T> new_node = new LinkedList_Node<T>(data);
                new_node.Next = this;
                return new_node;
            }

            /// <summary>
            /// Puts the new LinkedList node in front of the list and returns it.
            /// </summary>
            /// <param name="new_node"></param>
            /// <returns></returns>
            public LinkedList_Node<T> AddToFront(LinkedList_Node<T> new_node)
            {
                new_node.Next = this;
                return new_node;
            }

            /// <summary>
            /// Reverses the whole LinkedList and returns the current head of the list.
            /// </summary>
            /// <returns></returns>
            public LinkedList_Node<T> Reverse()
            {
                LinkedList_Node<T> head = this;
                LinkedList_Node<T> prev = null;

                while(head!=null)
                {
                    LinkedList_Node<T> next = head.Next;
                    head.Next = prev;
                    prev = head;
                    head = next;
                }
                return prev;
            }

        }
        
    }

}
