using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeature
{
    internal class A
    {
        public int Id { get; set; }

        public virtual void Name()
        {
            Console.WriteLine("Called From Class A");
        }
    }
}
