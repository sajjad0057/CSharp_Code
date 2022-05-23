using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Switch
    {
        public delegate void Trigger();

        public event Trigger On;
        public event Trigger Off;

        private bool _isON;

        public Switch()
        {
            _isON = false;
        }

        public void Toggle()
        {
            _isON = !_isON;

            if (_isON)
                On.Invoke();
            else
                Off.Invoke();

        }
    }
}
