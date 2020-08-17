using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMonitor.Métodos
{
    class OSystem
    {
        public static string Bits()
        {
            if (Environment.Is64BitOperatingSystem == true) return "64 bits";
            else return "32 bits";
        }

        public static List<string> Users()
        {
            var LstUsers = new List<string>();
            DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName);
            DirectoryEntry admGroup = localMachine.Children.Find("users", "group");
            object members = admGroup.Invoke("members", null);

            foreach (object groupMember in (IEnumerable)members)
            {
                DirectoryEntry member = new DirectoryEntry(groupMember);
                LstUsers.Add(member.Name);
            }

            return LstUsers;
        }
    }
}
