using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{

    //// We can write code in record , like as all class features, 
    public record Product1
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product1(string name , double price)
        {
            Name = name;
            Price = price;
        }
        public double GetDiscount (double parcent)
        {
            return Price * parcent / 100 ;
        } 

    }
}
