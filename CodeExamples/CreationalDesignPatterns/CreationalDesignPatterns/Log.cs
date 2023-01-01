using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.CreationalDesignPatterns
{
    /// <summary>
    /// Example for Singleton design pattern 
    /// </summary>
    public class Log
    {
        public static Log _log;
        private Log()
        {
        }

        public static Log GetLogger()
        {
            if(_log == null)
            {
                _log = new Log();
            }

            return _log;
        }
    }
}
