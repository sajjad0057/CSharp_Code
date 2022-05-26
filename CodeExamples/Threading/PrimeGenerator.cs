using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class PrimeGenerator
    {
        public List<int> Generate(int start , int end)
        {   
            List<int> primes = new List<int>();

            for(int i = start; i <= end; i++)
            {
                if (_isPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
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
