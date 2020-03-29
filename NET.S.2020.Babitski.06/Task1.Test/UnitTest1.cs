using NUnit.Framework;
using Task1;

namespace Task1.Test
{
    public class Tests
    {

        [TestCase(new double []{ 2, 3, 4, 5}, new double[] { 3, 4, 5 }, ExpectedResult = new double[] { 5, 7, 9, 5 })]
        [TestCase(new double []{ 3, 4, 5 }, new double[] { 2, 3, 4, 5 }, ExpectedResult = new double[] { 5, 7, 9, 5 })]
        [TestCase(new double []{ 4, 5 }, new double[] { 0, 0, 1, 5 }, ExpectedResult = new double[] { 4, 5, 1, 5 })]
        public double[] PolinomPlus(double [] arrInst1, double[] arrInst2)
        {
            Polynomial p1 = new Polynomial(arrInst1); 
            Polynomial p2 = new Polynomial(arrInst2);
            return (p1 + p2).Coefficients;
        }
        [TestCase(new double[] { 2, 3, 4, 5 }, new double[] { 3, 4, 5 }, ExpectedResult = new double[] { -1, -1, -1, 5 })]
        [TestCase(new double[] { 3, 4, 5 }, new double[] { 2, 3, 4, 5 }, ExpectedResult = new double[] { -1, -1, -1, 5 })]
        [TestCase(new double[] { 4, 5 }, new double[] { 0, 0, 1, 5 }, ExpectedResult = new double[] { -4, -5 , 1, 5 })]
        public double[] PolinomMinus(double[] arrInst1, double[] arrInst2)
        {
            Polynomial p1 = new Polynomial(arrInst1);
            Polynomial p2 = new Polynomial(arrInst2);
            return (p1 - p2).Coefficients;
        }
    }
}