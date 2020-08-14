using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace MaxMonitor.Métodos
{
    class RAM
    {
        public static string Slots()
        {
            try
            {
                ManagementObjectSearcher objmem = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemoryArray");
                foreach (ManagementObject m in objmem.Get())
                {
                    long memdev = Convert.ToInt64(m["MemoryDevices"]);
                    return memdev.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "GNER";
        }

        public static (string Form, string Type, string Size, string Speed) Info()
        {
            string MemType = "";
            try
            {
                ManagementObjectSearcher objmem2 = new ManagementObjectSearcher("\\root\\cimv2", "SELECT * FROM Win32_PhysicalMemory");
                foreach (ManagementObject m in objmem2.Get())
                {
                    long Speed = Convert.ToInt64(m["ConfiguredClockSpeed"]);
                    long Type = Convert.ToInt64(m["MemoryType"]);
                    string Form = m["FormFactor"].ToString();
                    long Size = ((Convert.ToInt64(m["Capacity"])) * 2) / 1073741824;
                    if (Type == 20) MemType = "DDR";
                    if (Type == 21) MemType = "DDR2";
                    if (Type == 24) MemType = "DDR3";
                    if (Type >= 25 || Type == 0) MemType = "DDR4";
                    if (Form == "8") Form = "DIMM";
                    if (Form == "12") Form = "SODIMM";

                    return (Form, MemType, Size.ToString() + "GB", Speed.ToString() + "Mhz");
                }
            }
            catch (Exception ex)
            {
                return (ex.ToString(), ex.ToString(), ex.ToString(), ex.ToString());
            }

            return ("GNER", "GNER", "GNER", "GNER");
        }

        public static (string Slot, string Name, string Model, string Size) Devices()
        {
            try
            {
                ConnectionOptions connection = new ConnectionOptions
                {
                    Impersonation = ImpersonationLevel.Impersonate
                };
                ManagementObjectSearcher objmem2 = new ManagementObjectSearcher("\\root\\cimv2", "SELECT * FROM Win32_PhysicalMemory");
                ManagementScope scope = new ManagementScope("\\root\\CIMV2", connection);
                scope.Connect();
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection allmem = searcher.Get();
                foreach (ManagementObject m in allmem)
                {

                    long Size = ((Convert.ToInt64(m["Capacity"])) * 2) / 1073741824;
                    string Slot = m["DeviceLocator"].ToString();
                    string Name = m["Manufacturer"].ToString();
                    string Model = m["Model"].ToString();

                    return (Slot, Name, Model, Size.ToString() + "GB");
                }
                
            }
            catch (Exception ex)
            {
                return (ex.ToString(), ex.ToString(), ex.ToString(), ex.ToString());
            }

            return ("GNER", "GNER", "GNER", "GNER");
        }

        
    }


}
