using System;
using System.Linq;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            //This little pies of code in method Main is only to show
            //result in console
            int[] myArr = new int[] { 11, 9, 1, 5, 18, 17, 7, 2, 6, 0 };
            foreach (int item in Quicksort(myArr, 0, myArr.Length - 1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            int[] myArr2 = new int[] { 11, 9, 1, 5, 18, 17, 7, 2, 6, 0 };
            foreach (int item in MergeSort(myArr2))
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
        public static int[] Quicksort(int[] array, int start, int end)
        {
            int[] sortingArray = array;
            if (start >= end)
            {
                return array;
            }
            int pivot = Partition(sortingArray, start, end);
            Quicksort(sortingArray, start, pivot - 1);
            Quicksort(sortingArray, pivot + 1, end);
            return sortingArray;
        }
        static int Partition(int[] array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker++;
                }
            }
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        public static int[] MergeSort(int[] array)
        {
            if (array.Length == 1 || array.Length == 0)
            {
                return array;
            }

            int middle = array.Length / 2;
            return Merge(MergeSort(array.Take(middle).ToArray()), MergeSort(array.Skip(middle).ToArray()));
        }

        static int[] Merge(int[] arr1, int[] arr2)
        {
            int ptr1 = 0, ptr2 = 0;
            int[] merged = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }
            return merged;
        }
    }
}