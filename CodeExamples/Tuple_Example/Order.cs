using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Example
{
    internal class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double TotalAmount { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
