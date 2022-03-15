using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeature
{
    public class Product
    {

        public double Price { get; set; }

        public double CalculateDiscount(double percent)
        {

            Console.WriteLine("Called from  Product class !");
            return Price * percent / 100;
        }
    }
}
