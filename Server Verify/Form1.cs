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
            BackgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
            BackgroundWorker.WorkerReportsProgress = true;
            BackgroundWorker.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Já estou monitorando os servidores :)";
            notifyIcon1.BalloonTipText = "Para mais informações, clique com o botão direito ou de 2 cliques no icone.";
            this.WindowState = FormWindowState.Minimized;
            BackgroundWorker.RunWorkerAsync();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(100);
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object userObject = e.UserState;
            int percentage = e.ProgressPercentage;
        }

        int a = 1;
        int b = 1;
        int c = 1;
        int d = 1;
        int f = 1;
        int h = 1;
        int i = 1;

        private void sair_Click(object sender, EventArgs e)
        {
            BackgroundWorker.CancelAsync();
            Close();
        }

        private void status_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Ainda estou monitorando os servidores :D";
            notifyIcon1.BalloonTipText = "Para mais informações, clique com o botão direito ou de 2 cliques no icone.";
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(100);
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
                if (IsConnected())
                {                    
                    Ping g = new Ping();
                    PingReply gr;
                    try
                    {
                        gr = g.Send("suidhiahdbcsuhkdb.info");
                        if (gr.Status == IPStatus.Success)
                        {
                            gavea.Text = "Gávea Online";
                            lbgav.Text = "Online";
                            pgav.BackgroundImage = Max_Server.Properties.Resources.online;
                            b = 1;
                        }
                    }
                    catch (PingException)
                    {
                        b = b + 1;
                        if (b <= 2)
                        {
                            gavea.Text = "Gávea Offline";
                            lbgav.Text = "Offline";
                            pgav.BackgroundImage = Max_Server.Properties.Resources.warning;
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("email-ssl.com.br");
                            mail.From = new MailAddress("gnosis@institutognosis.com.br");
                            mail.To.Add("raphael@topinforj.com");
                            mail.Subject = "Servidor Gávea Offline";
                            mail.Body = "Servidor do Shopping da Gávea pode estar offline, favor verificar.";
                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("gnosis@institutognosis.com.br", "Gnosis102030");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);                           
                        }
                        else
                        {
                            gavea.Text = "Gávea Offline";
                            lbgav.Text = "Offline";
                            pgav.BackgroundImage = Max_Server.Properties.Resources.busy;
                        }
                    }
                    Ping s = new Ping();
                    PingReply sr;
                    try
                    {
                        sr = s.Send("google.com");
                        if (sr.Status == IPStatus.Success)
                        {
                            ska.Text = "SKA Online";
                            lbska.Text = "Online";
                            pska.BackgroundImage = Max_Server.Properties.Resources.online;
                            c = 1;
                        }
                    }
                    catch (PingException)
                    {
                        c = c + 1;
                        if (c <= 2)
                        {
                            ska.Text = "SKA Offline";
                            lbska.Text = "Offline";
                            pska.BackgroundImage = Max_Server.Properties.Resources.warning;
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                            mail.From = new MailAddress("raphael.presi@gmail.com");
                            mail.To.Add("suporte@topinforj.com");
                            mail.Subject = "Servidor SKA Offline";
                            mail.Body = "Servidor da SKA Adv pode estar offline, favor verificar.";
                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("raphael.presi", "32875304mp");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                        }
                        else
                        {
                            ska.Text = "SKA Offline";
                            lbska.Text = "Offline";
                            pska.BackgroundImage = Max_Server.Properties.Resources.busy;
                        }
                    }
                    Ping r = new Ping();
                    PingReply rr;
                    try
                    {
                        rr = r.Send("globo.com");
                        if (rr.Status == IPStatus.Success)
                        {
                            raposo.Text = "Raposo Online";
                            lbrap.Text = "Online";
                            prap.BackgroundImage = Max_Server.Properties.Resources.online;
                            d = 1;
                        }
                    }
                    catch (PingException)
                    {
                        d = d + 1;
                        if (d <= 2)
                        {
                            raposo.Text = "Raposo Offline Email Sent";
                            lbrap.Text = "Offline";
                            prap.BackgroundImage = Max_Server.Properties.Resources.warning;
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                            mail.From = new MailAddress("raphael.presi@gmail.com");
                            mail.To.Add("suporte@topinforj.com");
                            mail.Subject = "Storage Raposo Offline";
                            mail.Body = "O Storage(NAS) da Raposo Advocacia pode estar offline, favor verificar.";
                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("raphael.presi", "32875304mp");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                        }
                        else
                        {
                            raposo.Text = "Raposo Offline";
                            lbrap.Text = "Offline";
                            prap.BackgroundImage = Max_Server.Properties.Resources.busy;
                        }                        
                    }

                    Ping n = new Ping();
                    PingReply nr;
                    try
                    {
                        nr = n.Send("outlook.com");
                        if (nr.Status == IPStatus.Success)
                        {
                            gnosis.Text = "Gnosis Online";
                            lbgns.Text = "Online";
                            pgns.BackgroundImage = Max_Server.Properties.Resources.online;
                            f = 1;
                        }
                    }
                    catch (PingException)
                    {
                        f = f + 1;
                        if (f <= 2)
                        {
                            gnosis.Text = "Gnosis Offline";
                            lbgns.Text = "Offline";
                            pgns.BackgroundImage = Max_Server.Properties.Resources.warning;
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                            mail.From = new MailAddress("raphael.presi@gmail.com");
                            mail.To.Add("suporte@topinforj.com");
                            mail.Subject = "Servidor Gnosis Offline";
                            mail.Body = "Servidor da Gnosis pode estar offline, favor verificar.";
                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("raphael.presi", "32875304mp");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                        }
                        else
                        {
                            gnosis.Text = "Gnosis Offline";
                            lbgns.Text = "Offline";
                            pgns.BackgroundImage = Max_Server.Properties.Resources.busy;
                        }
                    }

                    Ping m = new Ping();
                    PingReply mr;
                    try
                    {
                        mr = m.Send("google.com");
                        if (mr.Status == IPStatus.Success)
                        {
                            mp.Text = "MP Online";
                            lbmpi.Text = "Online";
                            pmpi.BackgroundImage = Max_Server.Properties.Resources.online;
                            h = 1;
                        }
                    }
                    catch (PingException)
                    {
                        h = h + 1;
                        if (h <= 2)
                        {
                            mp.Text = "MP Offline";
                            lbmpi.Text = "Offline";
                            pmpi.BackgroundImage = Max_Server.Properties.Resources.warning;
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                            mail.From = new MailAddress("raphael.presi@gmail.com");
                            mail.To.Add("suporte@topinforj.com");
                            mail.Subject = "Servidor MP Offline";
                            mail.Body = "Servidor da MP Construtora pode estar offline, favor verificar.";
                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("raphael.presi", "32875304mp");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                        }
                        else
                        {
                            mp.Text = "MP Offline";
                            lbmpi.Text = "Offline";
                            pmpi.BackgroundImage = Max_Server.Properties.Resources.busy;
                        }
                    }

                    Ping j = new Ping();
                    PingReply jr;
                    try
                    {
                        jr = j.Send("google.com");
                        if (jr.Status == IPStatus.Success)
                        {
                            jds.Text = "JDS Online";
                            lbjds.Text = "Online";
                            pjds.BackgroundImage = Max_Server.Properties.Resources.online;
                            i = 1;
                        }
                    }
                    catch (PingException)
                    {
                        i = i + 1;
                        if (i <= 2)
                        {
                            jds.Text = "JDS Offline";
                            lbjds.Text = "Offline";
                            pjds.BackgroundImage = Max_Server.Properties.Resources.warning;
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                            mail.From = new MailAddress("raphael.presi@gmail.com");
                            mail.To.Add("suporte@topinforj.com");
                            mail.Subject = "Servidor JDS Offline";
                            mail.Body = "Servidor da JDS Contabilidade pode estar offline, favor verificar.";
                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("raphael.presi", "32875304mp");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                        }
                        else
                        {
                            jds.Text = "JDS Offline";
                            lbjds.Text = "Offline";
                            pjds.BackgroundImage = Max_Server.Properties.Resources.busy;
                        }
                    }

                    if (b >= 2 || c >= 2 || d >= 2 || f >= 2 || h >= 2 || i >= 2)
                    {
                        notifyIcon1.Icon = Max_Server.Properties.Resources.Gakuseisean_Ivista_Warning;
                    }
                    else
                    {
                        notifyIcon1.Icon = Max_Server.Properties.Resources.Status_user_online;
                    }
                    Thread.Sleep(1000);
                }
                else
                {
                    a = a + 1;
                    if (a <= 2)
                    {
                        notifyIcon1.BalloonTipTitle = "Servidor Offline D:";
                        notifyIcon1.BalloonTipText = "Favor, verificar a conexão do servidor ou a internet.";
                        notifyIcon1.ShowBalloonTip(100);
                        notifyIcon1.Icon = Max_Server.Properties.Resources.Status_user_busy;
                    }
                    else
                    {
                        internet.Text = "Offline";
                        Thread.Sleep(1000);
                    }
                }
                worker.ReportProgress(0);
            }
        }
    }
}
