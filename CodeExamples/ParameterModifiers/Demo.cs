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
        
        public int  v = 0;
        public Demo()
        {
           X = sum(2, 2);
           Y = sum(2, 2, 3);
           Z = sum(new int[] { 1, 2, 3, 4, 5, 6, 7 });

           Print2(out v);

        }

        public int sum(params int[] items)   //In c# params modifier like as args keyword in python . 
        {
            int sum = 0;
            foreach(int item in items)
            {
                sum += item;
            }
            return sum;
        }


        public void Print(in int Value)
        {
            //Value = 5;   // produce error ; coz we cannot modify
        }

        public void Print2(out int Value)
        {
            Value = 5;  // if we don't set value in method , throw an exception
        }


    }
}
