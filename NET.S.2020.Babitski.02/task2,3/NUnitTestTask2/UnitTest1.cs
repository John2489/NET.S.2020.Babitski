using NUnit.Framework;
using Task2;

namespace NUnitTestTask2
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(21, FunWithNumbers.FindNextBiggerNumber(12, true));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(531, FunWithNumbers.FindNextBiggerNumber(513, true));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(2071, FunWithNumbers.FindNextBiggerNumber(2017, true));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(441, FunWithNumbers.FindNextBiggerNumber(414, true));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(414, FunWithNumbers.FindNextBiggerNumber(144, true));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(1241233, FunWithNumbers.FindNextBiggerNumber(1234321, true));
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(1234162, FunWithNumbers.FindNextBiggerNumber(1234126, true));
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(3462345, FunWithNumbers.FindNextBiggerNumber(3456432, true));
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(-1, FunWithNumbers.FindNextBiggerNumber(10, true));
        }
        [Test]
        public void Test10()
        {
            Assert.AreEqual(-1, FunWithNumbers.FindNextBiggerNumber(20, true));
        }
    }
    public class TestPerfomans
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(12, false) <= 1);
        }
        [Test]
        public void Test2()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(513, false) <= 1);
        }
        [Test]
        public void Test3()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(2017, false) <= 1);
        }
        [Test]
        public void Test4()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(356435346, false) <= 1);
        }
        [Test]
        public void Test5()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(98765432, false) <= 1);
        }
        [Test]
        public void Test6()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(1111111111, false) <= 1);
        }
        [Test]
        public void Test7()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(565443535, false) <= 1);
        }
        [Test]
        public void Test8()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(1234321, false) <= 1);
        }
        [Test]
        public void Test9()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(987654321, false) <= 1);
        }
        [Test]
        public void Test10()
        {
            Assert.IsTrue(FunWithNumbers.FindNextBiggerNumber(20, false) <= 1);
        }
    }
}