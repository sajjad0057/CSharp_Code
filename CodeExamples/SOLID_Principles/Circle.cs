using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class Circle : IShape
    {   
        public double Radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
