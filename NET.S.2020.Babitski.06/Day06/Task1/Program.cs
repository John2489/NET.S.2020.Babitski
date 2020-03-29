using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial p0 = new Polynomial(new double[] { 2, 3, 4, 5 });
            Polynomial p1 = new Polynomial(new double[] { 3, 4, 5 });
            Polynomial p3 = p0 + p1;
            Polynomial p3t = p1 + p0;
            Polynomial p4 = p0 - p1;
            Polynomial p5 = p0 * p1;
            Console.WriteLine(p1);
            Console.WriteLine(p0);
            Console.WriteLine(p3);
            Console.WriteLine(p3t);
            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p0.Equals(p1));
            Console.WriteLine(p0 == p1);
            Console.ReadLine();
        }
    }
}
