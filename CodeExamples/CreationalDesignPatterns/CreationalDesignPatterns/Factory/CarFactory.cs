using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.CreationalDesignPatterns.Factory
{
    /// <summary>
    /// Example for Factory Method design pattern
    /// </summary>
    public class CarFactory
    {
        public static ICar CreateCar(string name)
        {
            if (name == "Toyota")
            {
                return new Toyota() { Model = "X Corolla", Color = "Black" };
            }
            else if (name == "BMW")
            {
                return new BMW() { Model = "X 2000", Color = "White" };
            }
            else
            {
                return null;
            }
        }
    }
}
