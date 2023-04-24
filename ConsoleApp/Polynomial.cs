using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    internal class Polynomial
    {
        private List<int> coefficients;

        public Polynomial(params int[] coefficients)
        {
            this.coefficients = new List<int>(coefficients);
        }

        public string ToString()
        {
            string str = "";
            for (int i = 0; i < coefficients.Count; i++)
            {
                if (coefficients[i] == 0) continue;

                if (i == 0)
                {
                    str += coefficients[i];
                }
                else
                {
                    str += (coefficients[i] > 0) ? " + " : " - ";
                    str += Math.Abs(coefficients[i]);
                }

                if (i > 0) str += $"x^{i}";
            }
            return str;
        }

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            int len = Math.Max(p1.coefficients.Count, p2.coefficients.Count);
            int[] resultCoefficients = new int[len];

            for (int i = 0; i < len; i++)
            {
                int coeff1 = (i < p1.coefficients.Count) ? p1.coefficients[i] : 0;
                int coeff2 = (i < p2.coefficients.Count) ? p2.coefficients[i] : 0;
                resultCoefficients[i] = coeff1 + coeff2;
            }

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            int len = Math.Max(p1.coefficients.Count, p2.coefficients.Count);
            int[] resultCoefficients = new int[len];

            for (int i = 0; i < len; i++)
            {
                int coeff1 = (i < p1.coefficients.Count) ? p1.coefficients[i] : 0;
                int coeff2 = (i < p2.coefficients.Count) ? p2.coefficients[i] : 0;
                resultCoefficients[i] = coeff1 - coeff2;
            }

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            int len = p1.coefficients.Count + p2.coefficients.Count - 1;
            int[] resultCoefficients = new int[len];

            for (int i = 0; i < p1.coefficients.Count; i++)
            {
                for (int j = 0; j < p2.coefficients.Count; j++)
                {
                    resultCoefficients[i + j] += p1.coefficients[i] * p2.coefficients[j];
                }
            }

            return new Polynomial(resultCoefficients);
        }
    }
}
