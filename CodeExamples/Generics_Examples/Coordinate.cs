using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Examples
{
    public class Coordinate<T, Q> : ICoordinate<T,Q>   // Uses <T,Q> generic datatype in ICoordinate interface from Coordinate class . 
    {
        public T X { get; set; }
        public Q Y { get; set; }


        // using generic typed in methods

        public void DoSomething<A, B>(Q q, A a, B b)  // parameter type Q , that Passes in Struct 
        {
            Console.WriteLine($"q : {q.GetType()} ; a : {a.GetType()} ; b : {b.GetType()}");


        }
    }
}
