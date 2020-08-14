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
            BARIcon.ShowBalloonTip(100);
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnected()
        {
            return InternetGetConnectedState(out int Description, 0);
        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            BackgroundWorker.CancelAsync();
            Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            BackgroundWorker.CancelAsync();
            Thread.Sleep(2000);
            BackgroundWorker.RunWorkerAsync();
        }

        private void BARIcon_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                
                
            }
        }
    }
}
