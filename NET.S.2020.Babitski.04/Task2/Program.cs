using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -255.255;
            Console.WriteLine(x.ConvertToBitString());
            Console.ReadLine();
        }
    }
    public static class FunWithBits
    {
        public static string BitConverter64bitIEEE754notAllWork(this Double number)
        {
            string returnableString = String.Empty;
            int[] result = new int[64];
            if (number < 0)
                result[0] = 1;
            else
                result[0] = 0;

            int[] absolutNumInBitWay = new int[] { };

            double exponentialForm = Math.Truncate(Math.Abs(number));
            Console.WriteLine(exponentialForm);
            int Exp = 0;
            if (number > 1 || number < -1)
                absolutNumInBitWay = BitHelper(exponentialForm);


            int[] forMantissa = MantissaHelper(number);
            int[] mantissa = new int[absolutNumInBitWay.Length + 52];
            for (int i = 0; i < absolutNumInBitWay.Length; i++)
            {
                mantissa[i] = absolutNumInBitWay[i];
            }
            for (int i = 0, j = absolutNumInBitWay.Length; i < forMantissa.Length; i++, j++)
            {
                mantissa[j] = forMantissa[i];
            }
            foreach (var item in forMantissa)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            if(exponentialForm == 0)
            {
                for (int i = 0; i < mantissa.Length; i++)
                {
                    if(mantissa[i] == 0)
                    {
                        Exp--;
                    }
                    else
                    {
                        Exp--;
                        break;
                    }
                }
            }
            else if (exponentialForm >= 2)
            {
                Exp = absolutNumInBitWay.Length - 1;
            }

            int[] exponentShift = BitHelper(1023 + Exp);
            for (int i = 1, j = 0; j < exponentShift.Length; i++, j++)
            {
                result[i] = exponentShift[j];
            }
            for (int i = 12, j = 1; i < result.Length && j < mantissa.Length; i++, j++)
            {
                result[i] = mantissa[j];
            }
            foreach (var item in exponentShift)
            {
                Console.Write(item);
            }
            Console.WriteLine();



            int[] MantissaHelper(double num)
            {
                int quantityOfDigitAfterDot = 0;
                if(num.ToString().Contains('.'))
                //if (num % 1 != 0)
                    quantityOfDigitAfterDot = num.ToString().Split('.')[1].Length; //this is crutch))
                num = Math.Abs(num);
                num -= Math.Truncate(Math.Abs(num));
                if(quantityOfDigitAfterDot > 15)
                    num = Math.Round(num, 15);
                else
                    num = Math.Round(num, quantityOfDigitAfterDot);

                int[] arrayOfBitsForMantissa = new int[52];
                for (int i = 0; i < arrayOfBitsForMantissa.Length; i++)
                {
                    num *= 2;
                    if(num > 1)
                    {
                        arrayOfBitsForMantissa[i] = 1;
                        num -= 1;
                    }
                    else
                    {
                        arrayOfBitsForMantissa[i] = 0;
                    }
                }
                return arrayOfBitsForMantissa;
            }
            int [] BitHelper(double num)
            {
                long a = (long)num;
                List<int> absNumberBit = new List<int>();
                while (true)
                {
                    if (absNumberBit.Count > 62) break;
                    if (a == 1)
                    {
                        absNumberBit.Add(1);
                        break;
                    }
                    if (a % 2 == 0)
                    {
                        absNumberBit.Add(0);
                        a /= 2;
                    }
                    else
                    {
                        absNumberBit.Add(1);
                        a /= 2;
                    }
                }
                absNumberBit.Reverse();
                return absNumberBit.ToArray();
            }
            foreach (int item in result)
            {
                returnableString += item;
            }
            return returnableString;
        }
    }
}
