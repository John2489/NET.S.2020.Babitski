using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test1 = new List<int>();
            test1.Add(7);
            test1.Add(1);
            test1.Add(2);
            test1.Add(17);
            test1.Add(770);
            test1.Add(4000347);
            test1.Add(400034);
            foreach (var item in test1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in FunWithDigits.FilterDigit(test1, 7))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    public class FunWithDigits
    {
        /// <summary>
        /// This method take list of numbers and return list without numbers witch contains specific digit. 
        /// </summary>
        /// <param name="listOfDigits">Inbound list</param>
        /// <param name="preferredNumber">Specific digit witch is shoudn't be in number.</param>
        /// <returns></returns>
        public static List<int> FilterDigit(List<int> listOfDigits, int preferredNumber)
        {
            int[] intermediateArray = new int[listOfDigits.Count];
            listOfDigits.CopyTo(intermediateArray);
            List<int> result = new List<int>();

            for (int i = 0; i < intermediateArray.Length; i++)
            {
                string temp = intermediateArray[i].ToString();
                if (!temp.Contains(preferredNumber.ToString()))
                    result.Add(intermediateArray[i]);              
            }
            return result;
        }
    }
}
