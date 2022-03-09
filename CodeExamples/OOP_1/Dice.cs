using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Dice
    {
        public int[] Sides { get; protected set; } // auto property field must be start with capital letter . 
        public int FaceValue { get; protected set; } // protected set means, this property could be writable for it's child classes. 

        public Dice()
        {
            Sides = new int[6];
            Sides[0] = 1;
            Sides[1] = 2;
            Sides[2] = 3;
            Sides[3] = 4;
            Sides[4] = 5;
            Sides[5] = 6;           
        }

        //public Dice(int sides)
        //{
        //    Sides = new int[sides];
        //    for (int i = 0; i < sides; i++)
        //    {
        //        Sides[i] = i+1;
        //    }
        //}


        public virtual void Roll()
        {
            Console.WriteLine("Rolling logic for 6 sides dice");
        }
    }
}
