using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Important_BuiltIn_Interface
{
    public class WaterBottle
    {
        public int Capacity { get;private set; }

        public int WaterAmount { get;private set; }

        public string Color { get;private set; }

        public WaterBottle(int capacity,int waterAmount , string color)
        {
            Capacity = capacity;
            WaterAmount = waterAmount;
            Color = color;
        }

        public void ReleaseWater(int amount)
        {
            WaterAmount -= amount;
        }

        public void AddWater(int amount)
        {
            if(WaterAmount < Capacity)
                WaterAmount += amount;
        }


        // this method can be used for copying this class object 
        public WaterBottle Copy()
        {
            return new WaterBottle(Capacity,WaterAmount,Color);
        }

    }
}
