using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Rectangle : IShape
    {
        private double Length{ get; set; }
        private double Width { get; set; }

        public Rectangle(double l, double w)
        {
            Length = l;
            Width = w;
        }

        double IShape.CalculateArea()
        {
            return Length * Width;
        }

        double IShape.CalculatePerimeter()
        {
            return 2*(Length + Width);
        }
    }
}
