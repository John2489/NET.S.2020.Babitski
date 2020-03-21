using NUnit.Framework;
using System;
using Task1;

namespace Task1.Tests
{
    public class Tests
    {
        [TestCase(2, 4, 6, 8, 10, ExpectedResult = 2)]
        [TestCase(4, 8, 16, ExpectedResult = 4)]
        [TestCase(81, 6561, 729, ExpectedResult = 81)]
        [TestCase(-564, 344, 0, -1, 4534336, -6557, 54, ExpectedResult = 1)]
        [TestCase(64, 128, 256, 512, 1024, -2048, 4096, -32, ExpectedResult = 32)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        public int GreatestCommonDivisor_DiffirentNumbers_GCD(params int[] nums)
        {
            return FunWithMathematics.GreatestCommonDivisor(false, nums);
        }

        [TestCase(2, 4, 6, 8, 10, ExpectedResult = 2)]
        [TestCase(4, 8, 16, ExpectedResult = 4)]
        [TestCase(81, 6561, 729, ExpectedResult = 81)]
        [TestCase(-564, 344, 0, -1, 4534336, -6557, 54, ExpectedResult = 1)]
        [TestCase(64, 128, 256, 512, 1024, -2048, 4096, -32, ExpectedResult = 32)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        public int GreatestCommonDivisorBinary_DiffirentNumbers_GCD(params int[] nums)
        {
            return FunWithMathematics.GreatestCommonDivisorBinary(false, nums);
        }

        [TestCase(25)]
        public void GreatestCommonDivisor_BigArrayOfRandom_TimeSpent(int maxMillisecond)
        {
            Random rn = new Random();
            int[] arrayTest = new int[5];
            for (int i = 0; i < arrayTest.Length; i++)
            {
                arrayTest[i] = rn.Next(int.MinValue, int.MaxValue);
            }
            Assert.IsTrue(FunWithMathematics.GreatestCommonDivisor(true, arrayTest) < maxMillisecond); 
        }
        [TestCase(25)]
        public void GreatestCommonDivisorBinary_BigArrayOfRandom_TimeSpent(int maxMillisecond)
        {
            Random rn = new Random();
            int[] arrayTest = new int[5];
            for (int i = 0; i < arrayTest.Length; i++)
            {
                arrayTest[i] = rn.Next(int.MinValue, int.MaxValue);
            }
            Assert.IsTrue(FunWithMathematics.GreatestCommonDivisorBinary(true, arrayTest) < maxMillisecond);
        }
    }
}