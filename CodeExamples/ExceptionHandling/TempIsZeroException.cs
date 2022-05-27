using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class TempIsZeroException : Exception
    {

        public TempIsZeroException(string message) : base(message)
        {

        }
    }
}
