using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExamples
{
    public enum PaymentStatus
    {
        complete = 1,
        partial ,    // if we don't assign value here , then assingvalue here sequentially
        cancel = 3
    }
}
