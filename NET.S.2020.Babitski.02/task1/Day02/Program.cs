using System;
using System.Collections;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintBitWay(8);
            PrintBitWay(15);
            PrintBitWay(FunWithBits.InsertNumber(8, 15, 0, 0));
            Console.WriteLine(FunWithBits.InsertNumber(8, 15, 0, 0));
            Console.WriteLine();

            PrintBitWay(8);
            PrintBitWay(15);
            PrintBitWay(FunWithBits.InsertNumber(8, 15, 3, 8));
            Console.WriteLine(FunWithBits.InsertNumber(8, 15, 3, 8));
            Console.WriteLine();

            PrintBitWay(398_040);
            PrintBitWay(110_759_790);
            PrintBitWay(FunWithBits.InsertNumber(398_040, 110_759_790, 10, 20));
            Console.WriteLine(FunWithBits.InsertNumber(398_040, 110_759_790, 10, 20));

            Console.ReadLine();
        }

        /// <summary>
        /// Method to show integer in bit way on Console.
        /// </summary>
        static void PrintBitWay(int a)
        {
            BitArray bitArray = new BitArray(new int[] { a });
            for (int i = bitArray.Length -1; i >= 0 ; i--)
            {
                if (bitArray[i])
                    Console.Write(1);
                else
                    Console.Write(0);
            }
            //foreach (bool item in bitArray)
            //{
            //    if (item)
            //        Console.Write(1);
            //    else
            //        Console.Write(0);
            //}
            Console.WriteLine();
        }
    }
    public class FunWithBits
    {
        public static int InsertNumber(int numberSourse, int numberIn, Byte start, Byte end)
        {
            if (start > 32 || end > 32 || end - start < 0)
                throw new ArgumentException(@"Argument length shall be at most 32 bits and argument" + 
                                            " 'end' must be more then argument 'start'.");

            BitArray bitArrayA = new BitArray(new int[] { numberSourse });
            BitArray bitArrayB = new BitArray(new int[] { numberIn });
            int i = start;
            int j = 0;
            do
            {
                bitArrayA[i] = bitArrayB[j];
                i++;
                j++;
            } while (i <= end);

            int[] result = new int[1];
            bitArrayA.CopyTo(result, 0);
            return result[0];
        }
    }
}