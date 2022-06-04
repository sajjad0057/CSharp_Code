using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class Rectangle : Square
    {
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
