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
                if (array == null || array.Length < 2) return;

                int n = array.Length;

                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                int i;

                for (i = 0; i < left.Length; i++)
                    left[i] = array[i];

                for (i = mid; i < array.Length; i++)
                    right[i - mid] = array[i];

                MergeSort(left);
                MergeSort(right);

                Merge(left, right, array);

            }
            private static void Merge(int[] left, int[] right, int[] array)
            {
                int i = 0, j = 0, k = 0;

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

                while (i < left.Length)
                {
                    array[k] = left[i];
                    i++; k++;
                }
                while (j < right.Length)
                {
                    array[k] = right[j];
                    j++; k++;
                }
            }
            /// <summary>
            /// Sorts a given array of integers, using QuickSort algorithm. Also can be used as int[].QuickSort();
            /// </summary>
            /// <param name="array"></param>
            public static void QuickSort(this int[] array)
            {
                if (array == null)
                    return;

                QuickSort(array, 0, array.Length - 1);
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
