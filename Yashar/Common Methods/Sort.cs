using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yashar
{
    namespace Common
    {
        public static class Sort
        {
            /// <summary>
            /// Sorts a given array of integers, using MergeSort algorithm. Also can be used as int[].MergeSort();
            /// </summary>
            /// <param name="array"></param>
            public static void MergeSort(this int[] array)
            {
                if (array == null)
                {
                    return;
                }

                int n = array.Length;
                if (n < 2) return;
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < mid; i++)
                {
                    left[i] = array[i];
                }
                for (int i = mid; i < n; i++)
                {
                    right[i - mid] = array[i];
                }

                MergeSort(right);
                MergeSort(left);
                Merge(left, right, array);
            }

            /// <summary>
            /// Async Sorts a given array of integers, using MergeSort algorithm. Also can be used as int[].MergeSort();
            /// </summary>
            /// <param name="array"></param>
            /// <returns></returns>
            public static Task<int[]> MergeSortAsync(int[] array)
            {
                int[] temp = array;
                return Task.Factory.StartNew(() =>
                {
                    MergeSort(temp);
                    return temp;
                });
            }

            private static void Merge(int[] left, int[] right, int[] array)
            {
                int i = 0; int j = 0; int k = 0;

                while (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                    {
                        array[k] = left[i];
                        i++; k++;
                    }
                    else
                    {
                        array[k] = right[j];
                        j++; k++;
                    }
                }
                if (i >= left.Length)
                {
                    while (j < right.Length)
                    {
                        array[k] = right[j];
                        j++; k++;
                    }
                }

                if (j >= right.Length)
                {
                    while (i < left.Length)
                    {
                        array[k] = left[i];
                        i++; k++;
                    }
                }
            }

            /// <summary>
            /// Sorts a given array of integers, using QuickSort algorithm. Also can be used as int[].QuickSort();
            /// </summary>
            /// <param name="array"></param>
            public static void QuickSort(this int[] array)
            {
                if(array == null)
                {
                    return;
                }

                QuickSort(array, 0, array.Length - 1);
            }

            public static Task<int[]> QuickSortAsync(this int[] array)
            {
                int[] temp = array;

                return Task.Factory.StartNew(() =>
                {
                    if (temp == null)
                    {
                        return null;
                    }

                    QuickSort(temp, 0, temp.Length - 1);

                    return temp;
                });
            }

            private static void QuickSort(int[] array, int min, int max)
            {
                int index = Partition(array, min, max);
                if (min < index - 1)
                    QuickSort(array, 0, index - 1);
                if (max > index)
                    QuickSort(array, index + 1, max);
            }

            private static int Partition(int[] array, int min, int max)
            {
                int pivot = array[(min + max) / 2];
                while (min <= max)
                {
                    while (array[min] < pivot)
                    {
                        min++;
                    }
                    while (array[max] > pivot)
                    {
                        max--;
                    }
                    if (min <= max)
                    {
                        Swap(array, min, max);
                        min++;
                        max--;
                    }
                }
                return min;
            }
            private static void Swap(int[] array, int n1, int n2)
            {
                int temp = array[n1];
                array[n1] = array[n2];
                array[n2] = temp;
            }
        } 
    }
}
