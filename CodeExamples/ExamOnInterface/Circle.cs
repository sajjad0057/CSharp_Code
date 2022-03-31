using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Circle : IShape
    {

        private double Radius { get; set; }

        public Circle(double r)
        {
            Radius= r;
        }

        double IShape.CalculateArea()
        {
            return 3.1416 *(Radius*Radius);
        }


        double IShape.CalculatePerimeter()
        {
            return 2 * 3.1416 * Radius;
        }
    }
}
