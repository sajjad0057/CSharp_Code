using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Examples
{
    public class Coordinate<T, Q> : ICoordinate<T, Q, bool>  where T : struct       // For using constrain here T must be struct ;
    {
        public T X { get; set; }
        public Q Y { get; set; }
        public bool Z { get; set; } = true;




        // using generic typed in methods

        public T DoSomething<A, B>(Q q, A a, B b)  // parameter type Q 
        {
            if (true)
            {
                return X;

            }
            else
            {
                return default(T);
            }



        }


    }
}
