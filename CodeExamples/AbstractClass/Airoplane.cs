﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Airoplane : Vehicle , IMovable
    {


        public override void StratEngine()
        {

        }


        public override void StopEngine()
        {

        }
        public void TakeOff()
        {

        }

        public void pullWheels()
        {

        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
