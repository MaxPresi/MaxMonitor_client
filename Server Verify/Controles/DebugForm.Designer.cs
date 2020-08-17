namespace MaxMonitor.Controles
{
    partial class DebugForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dskBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dskBox
            // 
            this.dskBox.BackColor = System.Drawing.SystemColors.Control;
            this.dskBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dskBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dskBox.Location = new System.Drawing.Point(12, 12);
            this.dskBox.Multiline = true;
            this.dskBox.Name = "dskBox";
            this.dskBox.ReadOnly = true;
            this.dskBox.Size = new System.Drawing.Size(860, 623);
            this.dskBox.TabIndex = 59;
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 647);
            this.Controls.Add(this.dskBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DebugForm";
            this.Text = "Debug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dskBox;
    }
}