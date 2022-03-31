using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Triangle : IShape
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        private double S { get; set; }

        public Triangle(double a, double b , double c)
        {
            A = a;
            B = b;
            C = c;
            S = CalHalfPareimeter();

        }

        double IShape.CalculateArea()
        {
            return Math.Sqrt(S * (S - A) * (S - B) * (S - C));
        }

        double IShape.CalculatePerimeter()
        {
            return S = (A + B + C);
        }

        public double CalHalfPareimeter()
        {
            return  (A + B + C) / 2;
        }
    }
}
