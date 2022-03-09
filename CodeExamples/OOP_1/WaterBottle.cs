using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class WaterBottle
    {
        string color;
        double capacity;
        double height;
        bool capOpen;
        double content;

        public string Color
        {
            get { return color; }
        }

        public WaterBottle()
        {
            color = "blue";
            capacity = 1000;
            height = 300.5;
            capOpen = false;
            content = 0;
        }


        // Constructor Overloading
        public WaterBottle(string color,double capacity, double height)
        {
            this.color = color;
            this.capacity = capacity;
            this.height = height;
            capOpen = false;
            content = 0;

        }

        public void OpenCap()
        {
            capOpen = true;
        }

        public void CloseCap()
        {
            capOpen = false;
        }

        public void AddWater(double amount)
        {
            if (capOpen)
            {
                if (content + amount > capacity)
                    content = capacity;
                else
                    content += amount;
            }
        }

        public void RemoveWater(double amount)
        {
            if (capOpen)
            {
                if (content - amount < 0)
                    content = 0;
                else
                    content -= amount;
            }

        }
    }
}
