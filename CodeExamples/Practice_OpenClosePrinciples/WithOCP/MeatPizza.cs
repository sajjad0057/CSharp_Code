using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.WithOCP
{
    public class MeatPizza : Pizza
    {
        public MeatPizza()
        {
            HasMeat = true;
            IsSpicy = false;
        }
    }
}
