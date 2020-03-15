using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day02;
using System;

namespace MSUnitTestDay02
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertNumberTest1()
        {
            //i = 0;
            //j = 0;
            //in       15  0000 0000 0000 0000 0000 0000 0000 0000 1111
            //from     15  0000 0000 0000 0000 0000 0000 0000 0000 1111
            //expect   15  0000 0000 0000 0000 0000 0000 0000 0000 1111
            Assert.IsTrue(FunWithBits.InsertNumber(15, 15, 0, 0) == 15);
        }
        [TestMethod]
        public void InsertNumberTest2()
        {
            //i = 0;
            //j = 0;
            //in              8  0000 0000 0000 0000 0000 0000 0000 0000 1000
            //from           15  0000 0000 0000 0000 0000 0000 0000 0000 1111
            //expect          9  0000 0000 0000 0000 0000 0000 0000 0000 1001
            Assert.IsTrue(FunWithBits.InsertNumber(8, 15, 0, 0) == 9);
        }
        [TestMethod]
        public void InsertNumberTest3()
        {
            //i = 3;
            //j = 8;
            //in              8  0000 0000 0000 0000 0000 0000 0000 0000 1000
            //from           15  0000 0000 0000 0000 0000 0000 0000 0000 1111
            //expect        120  0000 0000 0000 0000 0000 0000 0000 0111 1000
            Assert.IsTrue(FunWithBits.InsertNumber(8, 15, 3, 8) == 120);
        }
        [TestMethod]
        public void InsertNumberTest4()
        {
            //i = 9;
            //j = 17;                                            98 7654 3210   
            //in      1_157_651  0000 0000 0000 0001 0001 1010 1010 0001 0011‬
            //from    7_012_142  0000 0000 0000 0110 1010 1111 1111 0010 1110‬
            //expect  1_203_219  0000 0000 0000 0001 0010 0101 110‬0 0001 0011‬
            Assert.IsTrue(FunWithBits.InsertNumber(1_157_651, 7_012_142, 9, 17) == 1_203_219);
        }
        [TestMethod]
        public void InsertNumberTest5()
        {
            //i = 10;
            //j = 20;
            //in        398_040  0000 0000 0000 0000 0110 0001 0010 1101 1000
            //from  110_759_790  0000 0000 0110 1001 1010 0000 1111 0110 1110
            //expect    899_800  0000 0000 0000 0001 1101 1011 1010 1101 1000
            Assert.IsTrue(FunWithBits.InsertNumber(398_040, 110_759_790, 10, 20) == 1_948_376);
        }
        [TestMethod]
        public void CheckingInvalidArguments1()
        {
            bool result = false;
            try
            {
                FunWithBits.InsertNumber(398_040, 110_759_790, 20, 10);
            }
            catch (ArgumentException)
            {
                result = true;
            }
            catch
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckingInvalidArguments2()
        {
            bool result = false;
            try
            {
                FunWithBits.InsertNumber(398_040, 110_759_790, 10, 33);
            }
            catch (ArgumentException)
            {
                result = true;
            }
            catch
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}