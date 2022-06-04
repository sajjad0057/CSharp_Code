using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{

    /*
    This class / method Examples are violate open close principles 
    */
    public class Geometry
    {
        public double CalCulateArea(string shapeType , object[] parameters)
        {
            if (shapeType == "circle")
                return Math.PI * (double)parameters[0] * (double)parameters[0];
            else if (shapeType == "square")
                return (double)parameters[0] * (double)parameters[0];
            else if (shapeType == "rectangle")
                return (double)parameters[0] * (double)parameters[1];
            else
                return 0;

        }
    }
}
