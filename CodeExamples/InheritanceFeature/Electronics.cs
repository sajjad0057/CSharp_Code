using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeature
{
    public sealed class  Electronics : Product
    {
        public new double CalculateDiscount(double percent)
        {
            Console.WriteLine("Called From Electronics !");
            
            if (percent > 20)
                percent = 20;

            return Price * percent / 100;
        }
    }
}
