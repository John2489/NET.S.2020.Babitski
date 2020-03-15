using System;
using System.Diagnostics;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(12, true));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(513, true));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(2017, true));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(414, true));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(144, true));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(1234321, true));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(987654321, true));

            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(12, false));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(513, false));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(2017, false));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(414, false));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(144, false));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(1234321, false));
            Console.WriteLine(FunWithNumbers.FindNextBiggerNumber(987654321, false));
            Console.ReadLine();
        }
    }
    public class FunWithNumbers
    {
        /// <summary>
        /// Incseasing number to next larger number or get time needed to inmliment this operation.
        /// </summary>
        /// <param name="number">Number which you want to increase to next larger number  only with use itself numbers of this number.</param>
        /// <param name="mode">Choose True if you need get next larger number of False to  get time needed to inmliment this operation.</param>
        /// <returns></returns>
        public static int FindNextBiggerNumber(int number, bool mode)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string helpToConvert = number.ToString();
            int[] arrOfNumber = new int [helpToConvert.Length];
            for (int i = 0; i < arrOfNumber.Length; i++)
                arrOfNumber[i] = (int)char.GetNumericValue(helpToConvert[i]);

            int temp = 0;
            for (int i = arrOfNumber.Length -1; i > 0 ; i--)
            {
                if (arrOfNumber[i] > arrOfNumber[i -1])
                {
                    temp = arrOfNumber[i];
                    arrOfNumber[i] = arrOfNumber[i - 1];
                    arrOfNumber[i - 1] = temp;
                    temp = i;
                    break;
                }
            }

            if (temp == 0)
            {
                stopwatch.Stop();
                if (!mode) return stopwatch.Elapsed.Milliseconds;
                return -1;
            }
            Array.Sort(arrOfNumber, temp, arrOfNumber.Length - temp);
            temp = Convert.ToInt32(String.Join("", arrOfNumber));

            stopwatch.Stop();
            if (!mode) return stopwatch.Elapsed.Milliseconds;
            return temp;
        }
    }
}
