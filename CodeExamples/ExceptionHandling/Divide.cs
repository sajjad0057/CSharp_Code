using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Divide
    {
        public int Calculate(int x, int y)
        {
            if(y == 0)
            {
                throw new InvalidInputException();
            }

            return x / y;
        }
    }
}
