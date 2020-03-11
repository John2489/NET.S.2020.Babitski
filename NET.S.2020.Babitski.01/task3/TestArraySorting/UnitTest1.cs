using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace TestArraySorting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] test1 = new int[] { 1 };
            int[] expect = new int[] { 1 };

            Program.Quicksort(test1, 0, test1.Length - 1);
            Assert.AreEqual(expect, test1);  
        }
    }
}
