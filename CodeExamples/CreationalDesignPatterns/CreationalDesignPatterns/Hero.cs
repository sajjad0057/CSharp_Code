using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.CreationalDesignPatterns
{
    /// <summary>
    /// Example for Prototype design pattern
    /// </summary>
    public class Hero : ICloneable
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public double? Speed { get; set; }
        public int? Power { get; set; }

        public object Clone()     //// Implement from ICloneable Interface
        {
            return Copy();
        }

        public Hero Copy()
        {
            return new Hero { Name = Name, Color = Color, Speed = Speed, Power = Power };
        }
    }
}
