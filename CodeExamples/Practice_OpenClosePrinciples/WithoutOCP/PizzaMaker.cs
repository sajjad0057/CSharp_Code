using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.WithoutOCP
{
    public class PizzaMaker
    {
        public static Pizza Make (int option)
        {
            if (option == 1)
                return new Pizza { HasMeat = false, IsSpicy = true };
            else if (option == 2)
                return new Pizza { HasMeat = true, IsSpicy = false };
            else
                return null;
        }
    }
}
