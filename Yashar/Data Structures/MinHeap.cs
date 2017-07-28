using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yashar
{
    namespace DataStructures
    {
        public class MinHeap<T> where T : IComparable<T>
        {
            private List<T> Heap;

            /// <summary>
            /// Creates an empty MinHeap of generic type.
            /// </summary>
            public MinHeap()
            {
                Heap = new List<T>();
            }

            /// <summary>
            /// Returns the minimum value of the MinHeap, throws null exception of empty.
            /// </summary>
            public T Min
            {
                get
                {
                    if (Heap.Count == 0) throw new NullReferenceException();
                    else return Heap[0];
                }
            }

            /// <summary>
            /// Returns true if the heap is empty, false otherwise.
            /// </summary>
            /// <returns></returns>
            public bool IsEmpty()
            {
                return Heap == null || Heap.Count == 0;
            }

            /// <summary>
            /// Returns the number of elements in the heap. 0 if empty.
            /// </summary>
            public int Count
            {
                get
                {
                    if (Heap == null) return 0;
                    else
                    {
                        return Heap.Count;
                    }
                }
            }

            /// <summary>
            /// Inserts a new value to the MinHeap and reforms the heap by maintaining the MinHeap properties.
            /// </summary>
            /// <param name="data"></param>
            public void Insert(T data)
            {
                Heap.Add(data);

                int ch = Heap.Count - 1; //ch for child
                while (ch > 0)
                {
                    int p = (ch - 1) / 2; //p for parent

                    if (Heap[ch].CompareTo(Heap[p]) < 0) //meaning child is smaller than parent -> Swap'm
                    {
                        Swap(p, ch);
                        ch = p;
                    }
                    else
                        break;
                }
            }
            private void Swap(int p, int ch)
            {
                T temp = Heap[p];
                Heap[p] = Heap[ch];
                Heap[ch] = temp;
            }

            /// <summary>
            /// Removes the minimum element of the MinHeap, reforms the heap and returns the minimum element.
            /// </summary>
            /// <returns></returns>
            public T ExtractMin()
            {
                if (Heap == null || Heap.Count == 0) throw new NullReferenceException();
                T ret = Heap[0];

                Heap[0] = Heap[Heap.Count - 1];
                Heap.RemoveAt(Heap.Count - 1);

                Heapify(0);

                return ret;
            }
            private void Heapify(int i) //i is parent
            {
                int ch1 = 2 * i + 1; //left child
                int ch2 = 2 * i + 2; // right child

                if (ch1 >= Heap.Count && ch2 >= Heap.Count) return;

                int smaller = (ch2 >= Heap.Count) ? ch1 : (Heap[ch1].CompareTo(Heap[ch2]) < 0) ? ch1 : ch2;
                //if ch2 is out of boundary, ch1 is smaller, don't check rest, otherwise, see which one has smaller data

                if (Heap[i].CompareTo(Heap[smaller]) > 0)
                {
                    Swap(i, smaller);
                    Heapify(smaller);
                }
            }
        }
    }
    
}
