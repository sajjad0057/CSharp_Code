using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Examples
{
    public interface ICoordinate<A,B,C>            // here declare <A,B,C> Generic datatype with interface . 
    {
        A X { get; set; }
        B Y { get; set; }
        C Z { get; set; }
    }
}
