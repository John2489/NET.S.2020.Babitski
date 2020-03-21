using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = FunWithMathematics.GreatestCommonDivisor(false, 852, 4,0,0,0, -8,  256, 8, 16);
            Console.WriteLine(a);           
            int b = FunWithMathematics.GreatestCommonDivisorBinary(false, 852, 0,0,0,0, -8,  256, 8, 16);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }

    public class FunWithMathematics
    {
        /// <summary>
        /// This method return greatest common divisor or the time which need for find this number. This method based on Euclidean algorithm.
        /// </summary>
        /// <param name="optionTimer">True if you need to return spent time, False return greatest common devisor</param>
        /// <param name="nums">Numbers to find greatest common devisor</param>
        /// <returns></returns>
        public static int GreatestCommonDivisor(bool optionTimer, params int[] nums)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Math.Abs(nums[i]);
            }
            int temp = nums[0];
            for (int i = 0, j = 1; j < nums.Length; i++, j++)
            {
                if (temp == 0)
                    temp = nums[j];
                else
                {
                    while (nums[j] != 0)
                    {
                        if (nums[i] > nums[j])
                        {
                            nums[i] -= nums[j];
                        }
                        else
                        {
                            nums[j] -= nums[i];
                        }
                    }
                    nums[j] = nums[i];
                    temp = nums[i];
                }
            }

            stopwatch.Stop();
            if(optionTimer) return stopwatch.Elapsed.Milliseconds;
            return temp;
        }
        /// <summary>
        /// This method return greatest common divisor or the time which need for find this number. This method based on binary GCD algorithm.
        /// </summary>
        /// <param name="optionTimer">True if you need to return spent time, False return greatest common devisor</param>
        /// <param name="nums">Numbers to find greatest common devisor</param>
        /// <returns></returns>
        public static int GreatestCommonDivisorBinary(bool optionTimer, params int[] nums)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Math.Abs(nums[i]);
            }
            int temp = nums[0];
            for (int i = 0, j = 1; j < nums.Length; i++, j++)
            {
                nums[j] = DcdBinaryHelper(temp, nums[j]);
                temp = nums[j];
            }
            stopwatch.Stop();

            stopwatch.Stop();
            if (optionTimer) return stopwatch.Elapsed.Milliseconds;
            return temp;
        }
        /// <summary>
        /// This method finds greatest common divisor and based on binary GCD algorithm.
        /// </summary>
        /// <param name="a">Must be only the absolute value.</param>
        /// <param name="b">Must be only the absolute value.</param>
        /// <returns></returns>
        static int DcdBinaryHelper(int a, int b)
        {
            if (a == 0)
                return b;                        
            if (b == 0)
                return a;                        
            if (a == b)
                return a;                        
            if (a == 1 || b == 1)
                return 1;                        
            if ((a & 1) == 0)                    
                return ((b & 1) == 0)
                    ? DcdBinaryHelper(a >> 1, b >> 1) << 1   
                    : DcdBinaryHelper(a >> 1, b);            
            else                                     
                return ((b & 1) == 0)
                    ? DcdBinaryHelper(a, b >> 1)                 
                    : DcdBinaryHelper(b, a > b ? a - b : b - a); 
        }
    }
}