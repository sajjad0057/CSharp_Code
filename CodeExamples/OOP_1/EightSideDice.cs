using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
<<<<<<< HEAD
    internal class EightSideDice : Dice  // inheritance 
=======
    internal class EightSideDice : Dice
>>>>>>> 612de7de7eb64e668199a552049fccaa97a6d359
    {
        public EightSideDice()
        {
            Sides = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Sides[i] = i+1;

            }
        }

        public override void Roll()
        {
            Console.WriteLine("Rolling logic for 8 sides dice");
        }
    }
}
