using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConvert
{
    public class Clock
    {
        public string Convert(string twelveHourTime)
        {
            DateTime dt = DateTime.Parse(twelveHourTime);
            return dt.ToString("HH:mm");
        }
    }
}
