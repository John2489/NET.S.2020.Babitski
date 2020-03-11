using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace UnitTestSortingArray
{
    public class Ar
    {
        public static int[] test0 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        public static int[] expect0 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static int[] test1 = new int[] { 11, 9, 1, 5, 18, 17, 7, 2, 6, 0 };
        public static int[] expect1 = new int[] { 0, 1, 2, 5, 6, 7, 9, 11, 17, 18 };
        public static int[] test2 = new int[] { 0 };
        public static int[] expect2 = new int[] { 0 };
        public static int[] test3 = new int[] { };
        public static int[] expect3 = new int[] { };
        public static int[] test4 = new int[] { 1, -3 };
        public static int[] expect4 = new int[] { -3, 1 };
        public static int[] test5 = new int[] { 9, 9, 1 };
        public static int[] expect5 = new int[] { 1, 9, 9 };
    }
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void OneToTen()
        {
            CollectionAssert.AreEqual(Ar.expect0, Program.Quicksort(Ar.test0, 0, Ar.test0.Length - 1));
        }
        [TestMethod]
        public void Random()
        {
            CollectionAssert.AreEqual(Ar.expect1, Program.Quicksort(Ar.test1, 0, Ar.test1.Length - 1));
        }
        [TestMethod]
        public void OnlyZero()
        {
            CollectionAssert.AreEqual(Ar.expect2, Program.Quicksort(Ar.test2, 0, Ar.test2.Length - 1));
        }
        [TestMethod]
        public void Empty()
        {
            CollectionAssert.AreEqual(Ar.expect3, Program.Quicksort(Ar.test3, 0, Ar.test3.Length - 1));
        }
        [TestMethod]
        public void NegativeNumbers()
        {
            CollectionAssert.AreEqual(Ar.expect4, Program.Quicksort(Ar.test4, 0, Ar.test4.Length - 1));
        }
        [TestMethod]
        public void EasyNumbers()
        {
            CollectionAssert.AreEqual(Ar.expect5, Program.Quicksort(Ar.test5, 0, Ar.test5.Length -1));
        }
    }
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void OneToTen2()
        {
            CollectionAssert.AreEqual(Ar.expect0, Program.MergeSort(Ar.test0));
        }
        [TestMethod]
        public void Random2()
        {
            CollectionAssert.AreEqual(Ar.expect1, Program.MergeSort(Ar.test1));
        }
        [TestMethod]
        public void OnlyZero2()
        {
            CollectionAssert.AreEqual(Ar.expect2, Program.MergeSort(Ar.test2));
        }
        [TestMethod]
        public void Empty2()
        {
            CollectionAssert.AreEqual(Ar.expect3, Program.MergeSort(Ar.test3));
        }
        [TestMethod]
        public void NegativeNumbers2()
        {
            CollectionAssert.AreEqual(Ar.expect4, Program.MergeSort(Ar.test4));
        }
        [TestMethod]
        public void EasyNumbers2()
        {
            CollectionAssert.AreEqual(Ar.expect5, Program.MergeSort(Ar.test5));
        }
    }
}
