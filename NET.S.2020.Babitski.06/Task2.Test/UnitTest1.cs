using NUnit.Framework;
using System;
using Task2;
namespace Task2.Test
{
    public class Tests
    {
        static int[][] common = new int[4][] {
                                new int[]{ 2, 198, 667 },
                                new int[]{ 5 },
                                new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4},
                                new int[]{ 3, -5585, 148, 666, 1} };
        static int[][] maxSortAscending = new int[4][] {
                                new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4},
                                new int[]{ 2, 198, 667 },
                                new int[]{ 3, -5585, 148, 666, 1},
                                new int[]{ 5 } };
        static int[][] maxSortDescending = new int[4][] {
                                new int[]{ 5 },
                                new int[]{ 3, -5585, 148, 666, 1},
                                new int[]{ 2, 198, 667 },
                                new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4} };
        static int[][] minSortAscending = new int[4][] {
                                new int[]{ 5 },
                                new int[]{ 2, 198, 667 },
                                new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4},
                                new int[]{ 3, -5585, 148, 666, 1} };
        static int[][] minSortDescending = new int[4][] {
                                new int[]{ 3, -5585, 148, 666, 1},
                                new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4},
                                new int[]{ 2, 198, 667 },
                                new int[]{ 5 } };
        static int[][] sumSortAscending = new int[4][] {
                                new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4},
                                new int[]{ 2, 198, 667 },
                                new int[]{ 5 },
                                new int[]{ 3, -5585, 148, 666, 1} };
        static int[][] sumSortDescending = new int[4][] {
                                new int[]{ 3, -5585, 148, 666, 1},
                                new int[]{ 5 },
                                new int[]{ 2, 198, 667 },
                                new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4} };
        static int[][] testExp1 = new int[4][] {
                                new int[]{ 3, -5585, 148, 666, 1},
                                null,
                                new int[]{ 2, 198, 667 },
                                new int[]{ 1, 561, 561561, 561561, 561, 56, 15616511, 5, 25, 4} };
        static int[][] testExp2 = null;
        [Test]
        public void SortingByMaxValueInLinesInJaggedArrayAscendingWay()
        {
            Assert.IsTrue(EquilityArray(SortingJaggedArray.SortByMaxValueInLines(common,true), maxSortAscending));
        }        
        [Test]
        public void SortingByMaxValueInLinesInJaggedArrayDescendingWay()
        {
            Assert.IsTrue(EquilityArray(SortingJaggedArray.SortByMaxValueInLines(common,false), maxSortDescending));
        }
        [Test]
        public void SortingByMinValueInLinesInJaggedArrayAscendingWay()
        {
            Assert.IsTrue(EquilityArray(SortingJaggedArray.SortByMinValueInLines(common, true), minSortAscending));
        }       
        [Test]
        public void SortingByMinValueInLinesInJaggedArrayDescendingWay()
        {
            Assert.IsTrue(EquilityArray(SortingJaggedArray.SortByMinValueInLines(common, false), minSortDescending));
        }
        [Test]
        public void SortingBySumValueInLinesInJaggedArrayAscendingWay()
        {
            Assert.IsTrue(EquilityArray(SortingJaggedArray.SortBySumValueInLines(common, true), sumSortAscending));
        }
        [Test]
        public void SortingBySumValueInLinesInJaggedArrayDescendingWay()
        {
            Assert.IsTrue(EquilityArray(SortingJaggedArray.SortBySumValueInLines(common, false), sumSortDescending));
        }
        [Test]
        public void TestNullExeptionMaxValueInLinesInJaggedArray()
        {
            Assert.Throws<NullReferenceException>(() => SortingJaggedArray.SortBySumValueInLines(testExp1, true));
        }
        [Test]
        public void TestNullExeptionMSumValueInLinesInJaggedArray()
        {
            Assert.Throws<NullReferenceException>(() => SortingJaggedArray.SortBySumValueInLines(testExp2, true));
        }

        static bool EquilityArray(int[][] a, int [][] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] != b[i][j]) return false;
                }
            }
            return true;
        }
    }
}