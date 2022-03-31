using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class Robot
    {
        public double Speed { get; set; }
        public enum status
        {
            On,
            Off,
        }

        public status Status { get; set; }

        public abstract void Move(double amount);

    }
}
