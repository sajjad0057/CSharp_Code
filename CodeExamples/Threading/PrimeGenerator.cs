using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class PrimeGenerator
    {
        public void Generate(int start , int end)
        {   

            for(int i = start; i <= end; i++)
            {
                if (_isPrime(i))
                {
                    Console.WriteLine($"{i} is a prime number ");
                }
            }
            
        }

        
        private bool _isPrime(int x)
        {
            if( x == 0 || x == 1 )
                return false;

            for(int i = 2; i < Math.Sqrt(x); i++)
            {
                if(x % i == 0)
                    return false;
            }

            return true;

        }



    }
}
