using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class RoboCop : Robot
    {
        public double possition = 0;
        public override void Move(double amount)
        {
            possition += amount;
        }
    }
}
