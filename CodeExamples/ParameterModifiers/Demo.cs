using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    internal class Demo
    {

        public int X { get; set; }
        public int Y { get; set; }

        public int Z { get; set; }  
        public Demo()
        {
           X = sum(2, 2);
           Y = sum(2, 2, 3);
           Z = sum(new int[] { 1, 2, 3, 4, 5, 6, 7 });

        }

        public int sum(int a, int b)
        {
            return a + b;
        }


        // overloading sum method  
        public int sum(int a, int b, int c)
        {
            return (a + b) + c;
        }

        // overloding sum method 

        public int sum(int[] items)
        {
            int sum = 0;
            foreach(int item in items)
            {
                sum += item;
            }
            return sum;
        }
    }
}
