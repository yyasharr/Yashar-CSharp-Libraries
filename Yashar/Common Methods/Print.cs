using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yashar.DataStructures;

namespace Yashar
{
    namespace Common
    {
        public static class Print
        {
            /// <summary>
            /// Prints collection of integers on Console. Also can be used as int[].ToConsole() or List<int>.ToConsole();
            /// </summary>
            /// <param name="array"></param>
            public static void ToConsole(this ICollection<int> list)
            {
                int i = 0;
                foreach (var item in list)
                {
                    Console.Write(item);
                    if (i++ < list.Count - 1)
                        Console.Write(',');
                }
                Console.WriteLine();
            }

            /// <summary>
            /// Prints collection of strings on Console. Also can be used as string[].ToConsole() or List<string>.ToConsole();
            /// </summary>
            /// <param name="array"></param>
            public static void ToConsole(this ICollection<string> list)
            {
                int i = 0;
                foreach (var item in list)
                {
                    Console.Write(item);
                    if (i++ < list.Count - 1)
                        Console.Write(',');
                }
                Console.WriteLine();
            }

            /// <summary>
            /// Prints collection of character on Console. Also can be used as char[].ToConsole() or List<char>.ToConsole();
            /// </summary>
            /// <param name="array"></param>
            public static void ToConsole(this ICollection<char> list)
            {
                int i = 0;
                foreach (var item in list)
                {
                    Console.Write(item);
                    if (i++ < list.Count - 1)
                        Console.Write(',');
                }
                Console.WriteLine();
            }

            /// <summary>
            /// Prints a 2D array of integers. Also can be used as int[,].ToConsole();
            /// </summary>
            /// <param name="matrix"></param>
            public static void ToConsole(this int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            /// <summary>
            /// Prints a 2D array of strings. Also can be used as string[,].ToConsole();
            /// </summary>
            /// <param name="matrix"></param>
            public static void ToConsole(this string[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            /// <summary>
            /// Prints a 2D array of characters. Also can be used as char[,].ToConsole();
            /// </summary>
            /// <param name="matrix"></param>
            public static void ToConsole(this char[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            /// <summary>
            /// Prints a list of list of integers. Also can be used a List<List<int>>.ToConsole();
            /// </summary>
            /// <param name="list"></param>
            public static void ToConsole(this List<List<int>> list)
            {
                foreach (List<int> temp in list)
                {
                    foreach (int num in temp)
                    {
                        Console.Write(num + "\t");
                    }
                    Console.WriteLine();
                }
            }

            /// <summary>
            /// Prints a list of list of strings. Also can be used a List<List<string>>.ToConsole();
            /// </summary>
            /// <param name="list"></param>
            public static void ToConsole(this List<List<string>> list)
            {
                foreach (List<string> temp in list)
                {
                    foreach (string s in temp)
                    {
                        Console.Write(s+ "\t");
                    }
                    Console.WriteLine();
                }
            }

            /// <summary>
            /// Prints a list of list of characters. Also can be used a List<List<char>>.ToConsole();
            /// </summary>
            /// <param name="list"></param>
            public static void ToConsole(this List<List<char>> list)
            {
                foreach (List<char> temp in list)
                {
                    foreach (char c in temp)
                    {
                        Console.Write(c+ "\t");
                    }
                    Console.WriteLine();
                }
            }

            /// <summary>
            /// Prints the tree on a Windows Form.
            /// </summary>
            /// <param name="root"></param>
            public static void ToForm(this Treenode root)
            {
                root.Print();
            }

        }
    }
}
