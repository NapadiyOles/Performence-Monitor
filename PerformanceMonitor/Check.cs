using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMonitor
{
    static class Check
    {
        public static bool String(string String)
        {
            if (string.IsNullOrEmpty(String))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(String))
            {
                return false;
            }
            if (String == "-") 
            {
                return false;
            }
            return true;
        }
    }
}
