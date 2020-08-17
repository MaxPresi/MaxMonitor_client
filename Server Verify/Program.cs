using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaxMonitor.Controles;

namespace Server_Verify
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (NotifyIcon icon = new NotifyIcon())
            {
                icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                icon.MouseDoubleClick += MouseDoubleClick;
                icon.ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Forçar Atualização", (s, e) => {new About().Show();}),
                new MenuItem("Sobre...", (s, e) => {new About().Show();}),
                new MenuItem("Exit", (s, e) => { Application.Exit(); }),
            });
                icon.Visible = true;

                Application.Run();
                icon.Visible = false;
            }
        }
        private static void MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new About().Show();
        }
    }
}
