using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.WithOCP
{
    public class SpicyPizza : Pizza
    {
        public SpicyPizza()
        {
            IsSpicy = true;
            HasMeat = false;
        }
    }
}
