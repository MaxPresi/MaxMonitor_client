using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Server_Verify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            BackgroundWorker.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            BackgroundWorker.RunWorkerAsync();
            notifyIcon1.ShowBalloonTip(100);
        }
        string PCName, PCTag, PCInfo, OSVersion, RAMInfo, RAMTotal, RAMUsage, CPUInfo, CPUUsage, 
            DISKInfo, DISKTotal, DISKFree, DISKUsage, EventErrors, AVReport, Softwares, Users;

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            BackgroundWorker.CancelAsync();
            Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                
                worker.ReportProgress(0);
            }
        }
    }
}
