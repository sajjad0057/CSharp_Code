using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    public class Product2
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product2(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public double GetDiscount(double parcent)
        {
            return Price * parcent / 100;
        }
    }
}
