using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Generics
{
    internal class B : IItem
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public B(double width,double lenght, double height,double weight)
        {
            Width = width;
            Length = lenght;
            Height = height;
            Weight = weight;
        }
    }
}
