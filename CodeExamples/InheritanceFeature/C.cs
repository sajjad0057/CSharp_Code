using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeature
{
    sealed class C : B    // As a C class in sealed , so it doesn't inherit by other class 
    {
        //public override void Name()  // can't override this methods, cz its sealed method in class B .
        //{

        //}

        public C()
        {
            Console.WriteLine("Class C constructor is Called");
        }

        public void Mname()
        {
            Console.WriteLine("From Class C");
        }
    }
}
