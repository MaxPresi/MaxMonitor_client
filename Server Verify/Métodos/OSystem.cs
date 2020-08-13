using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMonitor.Métodos
{
    class OSystem
    {
        static string PCName = Environment.MachineName;
        public static string GetOSType()
        {
            if (Environment.Is64BitOperatingSystem == true) return "64 bits";
            else return "32 bits";
        }
    }
}
