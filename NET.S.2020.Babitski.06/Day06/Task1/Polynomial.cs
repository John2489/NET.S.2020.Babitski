using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public sealed class Polynomial
    {
        public int Degree { get; private set; }
        public double [] Coefficients { get; private set; }
        public Polynomial(double [] coefficients)
        {
            Degree = coefficients.Length -1;
            Coefficients = coefficients;
        }
        public override bool Equals(object coefficients)
        {
            if (!(coefficients is Polynomial))
                return false;
            Polynomial pol = (Polynomial)coefficients;
            if (Degree != pol.Degree || Coefficients.Length != pol.Coefficients.Length)
                return false;
            for (int i = 0; i < Coefficients.Length; i++)
            {
                if (Coefficients[i] != pol.Coefficients[i])
                    return false;
            }
            return true;
        }
        public override string ToString()
        {
            string result = $"Degree is : {Degree}" +
                            $"\nCoefficients are :";
            foreach (var item in Coefficients)
            {
                result += " " + item;
            }
            result += ".";
            return result;
        }
        public override int GetHashCode()
        {
            int hash = Degree.GetHashCode();
            for (int i = 0; i < Coefficients.Length; i++)
            {
                hash += Coefficients[i].GetHashCode();
            }
            return base.GetHashCode();
        }
        public static Polynomial operator + (Polynomial p1, Polynomial p2)
        {
            double[] result = new double[]{};
            if(p1.Coefficients.Length > p2.Coefficients.Length)
            {
                result = new double[p1.Coefficients.Length];
                p1.Coefficients.CopyTo(result, 0);
                for (int i = 0; i < p2.Coefficients.Length; i++)
			    {
                    result[i] += p2.Coefficients[i];
			    }
            }
            else
            {
                result = new double[p2.Coefficients.Length];
                p2.Coefficients.CopyTo(result, 0);
                for (int i = 0; i < p1.Coefficients.Length; i++)
			    {
                    result[i] += p1.Coefficients[i];
			    }
            }
            return new Polynomial(result);
        }
        public static Polynomial operator - (Polynomial p1, Polynomial p2)
        {
            double[] result = new double[]{};
            if(p1.Coefficients.Length > p2.Coefficients.Length)
            {
                result = new double[p1.Coefficients.Length];
                p1.Coefficients.CopyTo(result, 0);
                for (int i = 0; i < p2.Coefficients.Length; i++)
			    {
                    result[i] -= p2.Coefficients[i];
			    }
            }
            else
            {
                result = new double[p2.Coefficients.Length];
                p2.Coefficients.CopyTo(result, 0);
                for (int i = 0; i < p1.Coefficients.Length; i++)
			    {
                    result[i] -= p1.Coefficients[i];
			    }
            }
            return new Polynomial(result);
        }
        public static Polynomial operator * (Polynomial p1, Polynomial p2)
        {
            double [] result = new double[p1.Coefficients.Length + p2.Coefficients.Length -1];
            for (int i = 0; i < p2.Coefficients.Length; i++)
			{
                for (int j = 0; j < p1.Coefficients.Length; j++)
                {
                    result[j + i] += p1.Coefficients[j] * p2.Coefficients[i];
                }
            }
            return new Polynomial(result);
        }
        public static bool operator == (Polynomial p1, Polynomial p2) => p1.Equals(p2);
        public static bool operator != (Polynomial p1, Polynomial p2) => !(p1.Equals(p2));
    }
}