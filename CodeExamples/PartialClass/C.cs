using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Product
    {
        public string Name { get; set; } = "sajjad"; // initialize auto property 
        public static int Count { get; set; } = 1; 
        public virtual double CalculatePriceAfterDiscount(double percent)
        {
            return Price - CalculateDiscount(percent);
        }
    }
}
