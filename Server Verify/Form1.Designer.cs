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
            this.BARIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SairBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.LogoPnl = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BARIcon
            // 
            this.BARIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.BARIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("BARIcon.Icon")));
            this.BARIcon.Text = "MaxMonitor";
            this.BARIcon.Visible = true;
            this.BARIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BARIcon_MouseDoubleClick_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.UpdateBtn,
            this.toolStripSeparator1,
            this.SairBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 60);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AccessibleName = "Status";
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(171, 22);
            this.UpdateBtn.Text = "Forçar Atualização";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // SairBtn
            // 
            this.SairBtn.AccessibleName = "Sair";
            this.SairBtn.Name = "SairBtn";
            this.SairBtn.Size = new System.Drawing.Size(171, 22);
            this.SairBtn.Text = "Sair";
            this.SairBtn.Click += new System.EventHandler(this.SairBtn_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.SystemColors.Control;
            this.StatusBox.Location = new System.Drawing.Point(12, 171);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.ShortcutsEnabled = false;
            this.StatusBox.Size = new System.Drawing.Size(256, 47);
            this.StatusBox.TabIndex = 1;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "MaxServer\r\nVersão 1.7.2.0\r\nCopyleft © 2020 - Raphael Aracelli";
            this.StatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // LogoPnl
            // 
            this.LogoPnl.BackgroundImage = global::MaxMonitor.Properties.Resources.LogoBack;
            this.LogoPnl.Location = new System.Drawing.Point(12, 12);
            this.LogoPnl.Name = "LogoPnl";
            this.LogoPnl.Size = new System.Drawing.Size(256, 144);
            this.LogoPnl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 230);
            this.Controls.Add(this.LogoPnl);
            this.Controls.Add(this.StatusBox);
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

        private System.Windows.Forms.NotifyIcon BARIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem UpdateBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SairBtn;
        private System.Windows.Forms.TextBox StatusBox;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Panel LogoPnl;
    }
}

