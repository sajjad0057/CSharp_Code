using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Examples
{
    public class AsyncTest
    {
        /// <summary>
        /// Examples of Synchronous code , Synchronous code are executed sequentially and next code will waiting untill finishing previous code executions .
        /// </summary>
        public void PrintEvenAsync()
        {
            Thread.Sleep(7000);
            Console.WriteLine("This method has taken 7 sec already !");
        }

        public void  PrintOddAsync()
        {
            Console.WriteLine("After 7+ sec method 2 has executed ! ");
        }

    }
}
