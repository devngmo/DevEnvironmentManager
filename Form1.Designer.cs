namespace DevEnvironmentManager
{
    partial class FrmSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnuFluter = new ToolStripMenuItem();
            mnuNPM = new ToolStripMenuItem();
            mnuClose = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mnuFluter, mnuNPM, mnuClose });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(109, 70);
            // 
            // mnuFluter
            // 
            mnuFluter.Name = "mnuFluter";
            mnuFluter.Size = new Size(108, 22);
            mnuFluter.Text = "Flutter";
            // 
            // mnuNPM
            // 
            mnuNPM.Name = "mnuNPM";
            mnuNPM.Size = new Size(108, 22);
            mnuNPM.Text = "NPM";
            // 
            // mnuClose
            // 
            mnuClose.Name = "mnuClose";
            mnuClose.Size = new Size(108, 22);
            mnuClose.Text = "Close";
            mnuClose.Click += mnuClose_Click;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmSettings";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuFluter;
        private ToolStripMenuItem mnuNPM;
        private ToolStripMenuItem mnuClose;
    }
}
