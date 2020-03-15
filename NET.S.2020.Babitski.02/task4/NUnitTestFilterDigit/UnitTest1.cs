using NUnit.Framework;
using System.Collections.Generic;
using Task4;

namespace NUnitTestFilterDigit
{
    public class Tests
    {
        List<int> test1 = new List<int>() { 7, 17, 10, 11, 14457};
        List<int> test2 = new List<int>() { 7 };
        List<int> test3 = new List<int>() { 1, 24578, 3, 46434, 5, 65671, 7543, 8, 9 };
        List<int> test4 = new List<int>() { 2 };
        List<int> test5 = new List<int>() { 8, 9, 8, 9, 8, 9, 8, 9 };
        List<int> result1 = new List<int>() { 10, 11 };
        List<int> result2 = new List<int>() {  };
        List<int> result3 = new List<int>() { 1, 24578, 5, 65671, 8, 9 };
        List<int> result4 = new List<int>() { 2 };
        List<int> result5 = new List<int>() { 9, 9, 9, 9 };

        [Test]
        public void Test1()
        {
            Assert.AreEqual(FunWithDigits.FilterDigit(test1, 7), result1);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(FunWithDigits.FilterDigit(test2, 7), result2);
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(FunWithDigits.FilterDigit(test3, 3), result3);
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(FunWithDigits.FilterDigit(test4, 3), result4);
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(FunWithDigits.FilterDigit(test5, 8), result5);
        }
    }
}