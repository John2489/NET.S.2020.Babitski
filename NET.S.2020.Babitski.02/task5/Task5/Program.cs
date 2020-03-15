using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FunWithNewton.SqrtN(1, 5, 0.0001));
            Console.WriteLine(FunWithNewton.SqrtN(8, 3, 0.0001));
            Console.WriteLine(FunWithNewton.SqrtN(0.001, 3, 0.0001));
            Console.WriteLine(FunWithNewton.SqrtN(0.004241979, 9, 0.00000001));
            Console.ReadLine();
        }
    }

    public class FunWithNewton
    {
        public static double SqrtN(double number, int degree, double precision)
        {
            if (degree < 2 || (degree % 2 == 0 && number < 0) || precision > 1 || precision <= 0)
                throw new ArgumentOutOfRangeException();
            double result = number;
            double prev = 0;
            while (Math.Abs(prev - result) >= precision)
            {
                prev = result;
                result = (1.0 / degree) * ((degree - 1) * result + number / (Math.Pow(result, degree - 1)));
            }
            return Math.Round(result, 3);
        }
        static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }
    }
}
