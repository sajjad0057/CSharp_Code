using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeature
{
    internal class B : A
    {
        sealed public override void Name()  // other classes can not use this methods
        {   
            base.Name(); // also print Base/ Parrent class Info for this methods

            Console.WriteLine("Called From Class B");
        }
    }
}
