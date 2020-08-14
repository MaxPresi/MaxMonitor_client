using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace MaxMonitor.Métodos
{
    class Mobo
    {   
        public static (string Manu, string Model) Name()
        {
            ManagementObjectSearcher ObjPC = new ManagementObjectSearcher("\\root\\cimv2", "SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject Mobject in ObjPC.Get())
            {
                try
                {
                    string x = (string)Mobject["Manufacturer"];
                    x = x.Replace("Technology", "").Replace("Co", "").Replace("Ltd", "").Replace(".", "").Replace(",", "").Replace("Inc", "")
                        .Replace("To Be Filled By O.E.M", "Desconhecido").Replace("To Be Filled By OEM", "Desconhecido")
                        .Replace("ASUSTeK COMPUTER INC", "Asus").Replace("To be filled by OEM", "Desconhecido");

                    string y = (string)Mobject["Model"];
                    y = y.Replace("Technology", "").Replace("Co", "").Replace("Ltd", "").Replace(".", "").Replace(",", "").Replace("Inc", "")
                        .Replace("To Be Filled By O.E.M", "Desconhecido").Replace("To Be Filled By OEM", "Desconhecido")
                        .Replace("ASUSTeK COMPUTER INC", "Asus").Replace("To be filled by OEM", "Desconhecido");

                    return (x,y);
                }
                catch (Exception e)
                {
                    return (e.ToString(), e.ToString());
                }
            }
            return ("GNER","GNER");
        }

        public static (string Version, string Tag) Bios()
        {
            ManagementObjectSearcher ObjBios = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            foreach (ManagementObject biobject in ObjBios.Get())
            {
                try
                {
                    string Bios = biobject["SMBIOSBIOSVersion"].ToString();
                    string Tag = biobject["SerialNumber"].ToString();
                    return (Bios, Tag);
                }
                catch (Exception e)
                {
                    return (e.ToString(), e.ToString());
                }
            }
            return ("GNER", "GNER");
        }
    }
}
