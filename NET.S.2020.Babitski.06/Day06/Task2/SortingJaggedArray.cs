using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SortingJaggedArray
    {
        static void Main()
        {
            int[][] common = new int[4][] {
                             new int[]{ 1, 198, 667 },
                             new int[]{ 1 },
                             new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4},
                             new int[]{ 1, -5585, 148, 666, 1} };
            int[][] maxSortA = new int[4][] {
                             new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4},
                             new int[]{ 1, 198, 667 },
                             new int[]{ 1, -5585, 148, 666, 1},
                             new int[]{ 1 } };
            int[][] maxSortB = new int[4][] {
                             new int[]{ 1 },
                             new int[] { 1, -5585, 148, 666, 1 },
                             new int[] { 1, 198, 667 },
                             new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4} };
            int[][] minSort = new int[4][] {
                              new int[]{ 1, -5585, 148, 666, 1},
                              new int[]{ 1, 198, 667 },
                              new int[]{ 1 },
                              new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4} };
            int[][] test = SortByMaxValueInLines(common, false);
            foreach (var item in common)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }

            foreach (var item in maxSortB)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
            foreach (var item in test)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        /// <summary>
        /// This method needs to change two arrays among themselves.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(ref int [] a, ref int [] b)
        {
            int[] temp = (int[])a.Clone();
            a = b;
            b = temp;
        }
        /// <summary>
        /// Method is sorting jagged array by max value in line.
        /// </summary>
        /// <param name="jaggedArray">Entering jagged array.</param>
        /// <param name="mode">Choose True if you need to sort in ascending order or False if in descending.</param>
        /// <returns>Return new sorted jagged array.</returns>
        public static int[][] SortByMaxValueInLines(int[][] jaggedArray, bool mode)
        {
            int len = jaggedArray.Length;
            int[][] ja = (int[][])jaggedArray.Clone();
            if (mode)
            {
                for (int i = 1; i < len; i++)
                {
                    for (int j = 0; j < len - i; j++)
                    {
                        if (MaxValueInLine(ja[j]) < MaxValueInLine(ja[j + 1]))
                        {
                            Swap(ref ja[j], ref ja[j + 1]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i < len; i++)
                {
                    for (int j = 0; j < len - i; j++)
                    {
                        if (MaxValueInLine(ja[j]) > MaxValueInLine(ja[j + 1]))
                        {
                            Swap(ref ja[j], ref ja[j + 1]);
                        }
                    }
                }
            }
            int MaxValueInLine(int[] a)
            {
                int result = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > result)
                    {
                        result = a[i];
                    }
                }
                return result;
            }
            return ja;
        }
        /// <summary>
        /// Method is sorting jagged array by min value in line.
        /// </summary>
        /// <param name="jaggedArray">Entering jagged array.</param>
        /// <param name="mode">Choose True if you need to sort in ascending order or False if in descending.</param>
        /// <returns>Return new sorted jagged array.</returns>
        public static int[][] SortByMinValueInLines(int[][] jaggedArray, bool mode)
        {
            int len = jaggedArray.Length;
            int[][] ja = (int[][])jaggedArray.Clone();
            if (mode)
            {
                for (int i = 1; i < len; i++)
                {
                    for (int j = 0; j < len - i; j++)
                    {
                        if (MinValueInLine(ja[j]) < MinValueInLine(ja[j + 1]))
                        {
                            Swap(ref ja[j], ref ja[j + 1]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i < len; i++)
                {
                    for (int j = 0; j < len - i; j++)
                    {
                        if (MinValueInLine(ja[j]) > MinValueInLine(ja[j + 1]))
                        {
                            Swap(ref ja[j], ref ja[j + 1]);
                        }
                    }
                }
            }
            int MinValueInLine(int[] a)
            {
                int result = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] < result)
                    {
                        result = a[i];
                    }
                }
                return result;
            }
            return ja;
        }
        /// <summary>
        /// Method is sorting jagged array by sum of lines.
        /// </summary>
        /// <param name="jaggedArray">Entering jagged array.</param>
        /// <param name="mode">Choose True if you need to sort in ascending order or False if in descending.</param>
        /// <returns>Return new sorted jagged array.</returns>
        public static int[][] SortBySumValueInLines(int[][] jaggedArray, bool mode)
        {
            int len = jaggedArray.Length;
            int[][] ja = (int[][])jaggedArray.Clone();
            if (mode)
            {
                for (int i = 1; i < len; i++)
                {
                    for (int j = 0; j < len - i; j++)
                    {
                        if (SumValueInLine(ja[j]) < SumValueInLine(ja[j + 1]))
                        {
                            Swap(ref ja[j], ref ja[j + 1]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i < len; i++)
                {
                    for (int j = 0; j < len - i; j++)
                    {
                        if (SumValueInLine(ja[j]) > SumValueInLine(ja[j + 1]))
                        {
                            Swap(ref ja[j], ref ja[j + 1]);
                        }
                    }
                }
            }
            long SumValueInLine(int[] a)
            {
                long result = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (result + a[i] > long.MaxValue || result + a[i] < long.MinValue)
                        throw new OverflowException("Values in array is very big to sum them.");
                        result += a[i];
                }
                return result;
            }
            return ja;
        }
    }
}