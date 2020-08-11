namespace Server_Verify
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.servidores = new System.Windows.Forms.ToolStripMenuItem();
            this.gavea = new System.Windows.Forms.ToolStripMenuItem();
            this.ska = new System.Windows.Forms.ToolStripMenuItem();
            this.raposo = new System.Windows.Forms.ToolStripMenuItem();
            this.gnosis = new System.Windows.Forms.ToolStripMenuItem();
            this.mp = new System.Windows.Forms.ToolStripMenuItem();
            this.jds = new System.Windows.Forms.ToolStripMenuItem();
            this.internet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.status = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbgav = new System.Windows.Forms.Label();
            this.lbska = new System.Windows.Forms.Label();
            this.lbrap = new System.Windows.Forms.Label();
            this.lbgns = new System.Windows.Forms.Label();
            this.lbmpi = new System.Windows.Forms.Label();
            this.lbjds = new System.Windows.Forms.Label();
            this.pgav = new System.Windows.Forms.Panel();
            this.pska = new System.Windows.Forms.Panel();
            this.prap = new System.Windows.Forms.Panel();
            this.pgns = new System.Windows.Forms.Panel();
            this.pmpi = new System.Windows.Forms.Panel();
            this.pjds = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MaxServer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servidores,
            this.internet,
            this.toolStripSeparator2,
            this.status,
            this.toolStripSeparator1,
            this.sair});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 104);
            // 
            // servidores
            // 
            this.servidores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gavea,
            this.ska,
            this.raposo,
            this.gnosis,
            this.mp,
            this.jds});
            this.servidores.Name = "servidores";
            this.servidores.Size = new System.Drawing.Size(136, 22);
            this.servidores.Text = "Servidores";
            // 
            // gavea
            // 
            this.gavea.Name = "gavea";
            this.gavea.Size = new System.Drawing.Size(180, 22);
            this.gavea.Text = "toolStripMenuItem1";
            // 
            // ska
            // 
            this.ska.Name = "ska";
            this.ska.Size = new System.Drawing.Size(180, 22);
            this.ska.Text = "toolStripMenuItem1";
            // 
            // raposo
            // 
            this.raposo.Name = "raposo";
            this.raposo.Size = new System.Drawing.Size(180, 22);
            this.raposo.Text = "toolStripMenuItem1";
            // 
            // gnosis
            // 
            this.gnosis.Name = "gnosis";
            this.gnosis.Size = new System.Drawing.Size(180, 22);
            this.gnosis.Text = "toolStripMenuItem1";
            // 
            // mp
            // 
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(180, 22);
            this.mp.Text = "mp";
            // 
            // jds
            // 
            this.jds.Name = "jds";
            this.jds.Size = new System.Drawing.Size(180, 22);
            this.jds.Text = "toolStripMenuItem1";
            // 
            // internet
            // 
            this.internet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.internet.Name = "internet";
            this.internet.Size = new System.Drawing.Size(136, 22);
            this.internet.Text = "Internet";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(120, 23);
            this.toolStripTextBox1.Text = "Não Implementado";
            this.toolStripTextBox1.ToolTipText = "Não Implementado Ainda";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // status
            // 
            this.status.AccessibleName = "Status";
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(136, 22);
            this.status.Text = "Status Geral";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // sair
            // 
            this.sair.AccessibleName = "Sair";
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(136, 22);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(4, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(179, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "MaxServer\r\nVersão 1.7.2.0\r\nCopyleft © 2016 - Raphael Aracelli";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servidor Gávea -------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servidor SKA ---------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Servidor Raposo -------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Servidor Gnosis --------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Servidor MP -------------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Servidor JDS -----------------------------------";
            // 
            // lbgav
            // 
            this.lbgav.AutoSize = true;
            this.lbgav.Location = new System.Drawing.Point(168, 14);
            this.lbgav.Name = "lbgav";
            this.lbgav.Size = new System.Drawing.Size(35, 13);
            this.lbgav.TabIndex = 9;
            this.lbgav.Text = "label7";
            // 
            // lbska
            // 
            this.lbska.AutoSize = true;
            this.lbska.Location = new System.Drawing.Point(168, 42);
            this.lbska.Name = "lbska";
            this.lbska.Size = new System.Drawing.Size(35, 13);
            this.lbska.TabIndex = 10;
            this.lbska.Text = "label7";
            // 
            // lbrap
            // 
            this.lbrap.AutoSize = true;
            this.lbrap.Location = new System.Drawing.Point(168, 69);
            this.lbrap.Name = "lbrap";
            this.lbrap.Size = new System.Drawing.Size(35, 13);
            this.lbrap.TabIndex = 11;
            this.lbrap.Text = "label7";
            // 
            // lbgns
            // 
            this.lbgns.AutoSize = true;
            this.lbgns.Location = new System.Drawing.Point(168, 96);
            this.lbgns.Name = "lbgns";
            this.lbgns.Size = new System.Drawing.Size(35, 13);
            this.lbgns.TabIndex = 12;
            this.lbgns.Text = "label7";
            // 
            // lbmpi
            // 
            this.lbmpi.AutoSize = true;
            this.lbmpi.Location = new System.Drawing.Point(168, 123);
            this.lbmpi.Name = "lbmpi";
            this.lbmpi.Size = new System.Drawing.Size(35, 13);
            this.lbmpi.TabIndex = 13;
            this.lbmpi.Text = "label7";
            // 
            // lbjds
            // 
            this.lbjds.AutoSize = true;
            this.lbjds.Location = new System.Drawing.Point(168, 150);
            this.lbjds.Name = "lbjds";
            this.lbjds.Size = new System.Drawing.Size(35, 13);
            this.lbjds.TabIndex = 14;
            this.lbjds.Text = "label7";
            // 
            // pgav
            // 
            this.pgav.BackgroundImage = global::Max_Server.Properties.Resources.warning;
            this.pgav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pgav.Location = new System.Drawing.Point(4, 12);
            this.pgav.Name = "pgav";
            this.pgav.Size = new System.Drawing.Size(18, 18);
            this.pgav.TabIndex = 15;
            // 
            // pska
            // 
            this.pska.BackgroundImage = global::Max_Server.Properties.Resources.warning;
            this.pska.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pska.Location = new System.Drawing.Point(4, 37);
            this.pska.Name = "pska";
            this.pska.Size = new System.Drawing.Size(18, 18);
            this.pska.TabIndex = 16;
            // 
            // prap
            // 
            this.prap.BackgroundImage = global::Max_Server.Properties.Resources.warning;
            this.prap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prap.Location = new System.Drawing.Point(4, 64);
            this.prap.Name = "prap";
            this.prap.Size = new System.Drawing.Size(18, 18);
            this.prap.TabIndex = 16;
            // 
            // pgns
            // 
            this.pgns.BackgroundImage = global::Max_Server.Properties.Resources.warning;
            this.pgns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pgns.Location = new System.Drawing.Point(4, 91);
            this.pgns.Name = "pgns";
            this.pgns.Size = new System.Drawing.Size(18, 18);
            this.pgns.TabIndex = 16;
            // 
            // pmpi
            // 
            this.pmpi.BackgroundImage = global::Max_Server.Properties.Resources.warning;
            this.pmpi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pmpi.Location = new System.Drawing.Point(4, 118);
            this.pmpi.Name = "pmpi";
            this.pmpi.Size = new System.Drawing.Size(18, 18);
            this.pmpi.TabIndex = 16;
            // 
            // pjds
            // 
            this.pjds.BackgroundImage = global::Max_Server.Properties.Resources.warning;
            this.pjds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pjds.Location = new System.Drawing.Point(4, 145);
            this.pjds.Name = "pjds";
            this.pjds.Size = new System.Drawing.Size(18, 18);
            this.pjds.TabIndex = 16;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 231);
            this.Controls.Add(this.pjds);
            this.Controls.Add(this.pmpi);
            this.Controls.Add(this.pgns);
            this.Controls.Add(this.prap);
            this.Controls.Add(this.pska);
            this.Controls.Add(this.pgav);
            this.Controls.Add(this.lbjds);
            this.Controls.Add(this.lbmpi);
            this.Controls.Add(this.lbgns);
            this.Controls.Add(this.lbrap);
            this.Controls.Add(this.lbska);
            this.Controls.Add(this.lbgav);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "MaxServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem servidores;
        private System.Windows.Forms.ToolStripMenuItem internet;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button button1;        
        private System.Windows.Forms.ToolStripMenuItem gavea;
        private System.Windows.Forms.ToolStripMenuItem ska;
        private System.Windows.Forms.ToolStripMenuItem raposo;
        private System.Windows.Forms.ToolStripMenuItem gnosis;
        private System.Windows.Forms.ToolStripMenuItem mp;
        private System.Windows.Forms.ToolStripMenuItem jds;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbgav;
        private System.Windows.Forms.Label lbska;
        private System.Windows.Forms.Label lbrap;
        private System.Windows.Forms.Label lbgns;
        private System.Windows.Forms.Label lbmpi;
        private System.Windows.Forms.Label lbjds;
        private System.Windows.Forms.Panel pgav;
        private System.Windows.Forms.Panel pska;
        private System.Windows.Forms.Panel prap;
        private System.Windows.Forms.Panel pgns;
        private System.Windows.Forms.Panel pmpi;
        private System.Windows.Forms.Panel pjds;
    }
}

