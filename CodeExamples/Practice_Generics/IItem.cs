using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Generics
{
    internal interface IItem
    {
        double Width { get; set; }
        double Length { get; set; }
        double Height { get; set; }
        double Weight { get; set; }
        
    }
}
