using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace MaxMonitor.Métodos
{
    class CPU
    {

        public static (string Name, string Clock, string L2, string L3, string Core, string Thread) Info()
        {
            ManagementObjectSearcher ObjCPU = new ManagementObjectSearcher("\\root\\cimv2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject c in ObjCPU.Get())
            {
                try
                {
                    string Name = c["Name"].ToString();
                    Name = Name.Replace("(TM)", "").Replace("(tm)", "").Replace("(R)", "").Replace("(r)", "")
                    .Replace("(C)", "").Replace("(c)", "").Replace("    ", " ").Replace("  ", " ").Replace("APU with Radeon Graphics ", "")
                    .Replace("™", "").Replace("®", "").Replace("©", "").Replace("CPU ", "").Replace("CPU", "")
                    .Replace("APU with Radeon Graphics", "").Replace("Eight-Core ", "").Replace("Six-Core ", "").Replace("Quad-Core ", "")
                    .Replace("Processor ", "").Replace("Eight-Core", "").Replace("Six-Core", "").Replace("Quad-Core", "").Replace("Genuine ", "").Replace("Genuine", "")
                    .Replace("Processor", "");
                    int index = Name.IndexOf("@");
                    if (index > 0)
                        Name = Name.Substring(0, index);
                    string Clock = (Convert.ToDecimal(c["MaxClockSpeed"]) / 1000).ToString() + "Ghz";
                    string L3 = ((Convert.ToInt64(c["L3CacheSize"]) * 2) / 1024).ToString() + "MB";
                    long Nucleos = Convert.ToInt64(c["NumberOfCores"]);
                    string Thread = Convert.ToInt64(c["NumberOfLogicalProcessors"]).ToString();
                    string L2 = (Convert.ToInt64(c["L2CacheSize"]) * Nucleos).ToString() + "MB";
                    string Core = Nucleos.ToString();
                    return (Name, Clock, L2, L3, Core, Thread);
                }
                catch (Exception ex)
                {
                    return (ex.ToString(), ex.ToString(), ex.ToString(), ex.ToString(), ex.ToString(), ex.ToString());
                }

            }

            return ("GNER","GNER", "GNER", "GNER", "GNER", "GNER");
        }
    }
}
