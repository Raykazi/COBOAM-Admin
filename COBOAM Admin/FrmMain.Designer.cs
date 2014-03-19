using System.Windows.Forms;
using COBOAM_Admin.UserControls;

namespace COBOAM_Admin
{
    partial class FrmMain
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
            this.btnMSC = new System.Windows.Forms.Button();
            this.btnWAC = new System.Windows.Forms.Button();
            this.btnSC = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.SBLAccount = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.MSC = new COBOAM_Admin.UserControls.MediaSalesControl();
            this.WAC = new COBOAM_Admin.UserControls.WebAdminControl();
            this.SC = new COBOAM_Admin.UserControls.Settings();
            this.statusStrip.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMSC
            // 
            this.btnMSC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMSC.Location = new System.Drawing.Point(12, 19);
            this.btnMSC.Name = "btnMSC";
            this.btnMSC.Size = new System.Drawing.Size(88, 25);
            this.btnMSC.TabIndex = 0;
            this.btnMSC.Text = "Media Sales";
            this.btnMSC.UseVisualStyleBackColor = true;
            this.btnMSC.Click += new System.EventHandler(this.btnMSC_Click);
            // 
            // btnWAC
            // 
            this.btnWAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWAC.Location = new System.Drawing.Point(12, 50);
            this.btnWAC.Name = "btnWAC";
            this.btnWAC.Size = new System.Drawing.Size(88, 25);
            this.btnWAC.TabIndex = 1;
            this.btnWAC.Text = "Website";
            this.btnWAC.UseVisualStyleBackColor = true;
            this.btnWAC.Click += new System.EventHandler(this.btnWAC_Click);
            // 
            // btnSC
            // 
            this.btnSC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSC.Location = new System.Drawing.Point(12, 81);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(88, 25);
            this.btnSC.TabIndex = 2;
            this.btnSC.Text = "Settings";
            this.btnSC.UseVisualStyleBackColor = true;
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(12, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SBLAccount});
            this.statusStrip.Location = new System.Drawing.Point(0, 646);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1242, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // SBLAccount
            // 
            this.SBLAccount.Name = "SBLAccount";
            this.SBLAccount.Size = new System.Drawing.Size(0, 17);
            // 
            // gbButtons
            // 
            this.gbButtons.BackColor = System.Drawing.Color.Transparent;
            this.gbButtons.Controls.Add(this.btnMSC);
            this.gbButtons.Controls.Add(this.btnSC);
            this.gbButtons.Controls.Add(this.btnWAC);
            this.gbButtons.Controls.Add(this.btnExit);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbButtons.Location = new System.Drawing.Point(0, 0);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(112, 646);
            this.gbButtons.TabIndex = 5;
            this.gbButtons.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.MSC);
            this.panelMain.Controls.Add(this.WAC);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(112, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1130, 646);
            this.panelMain.TabIndex = 6;
            // 
            // MSC
            // 
            this.MSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSC.Location = new System.Drawing.Point(0, 0);
            this.MSC.Name = "MSC";
            this.MSC.Size = new System.Drawing.Size(1130, 646);
            this.MSC.TabIndex = 0;
            this.MSC.Visible = false;
            // 
            // WAC
            // 
            this.WAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WAC.Location = new System.Drawing.Point(0, 0);
            this.WAC.Name = "WAC";
            this.WAC.Size = new System.Drawing.Size(1130, 646);
            this.WAC.TabIndex = 0;
            this.WAC.Visible = false;
            // 
            // SC
            // 
            this.SC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC.Location = new System.Drawing.Point(0, 0);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(1130, 646);
            this.SC.TabIndex = 0;
            this.SC.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1242, 668);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMSC;
        private System.Windows.Forms.Button btnWAC;
        private System.Windows.Forms.Button btnSC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel SBLAccount;
        private System.Windows.Forms.GroupBox gbButtons;
        private Panel panelMain;
        private MediaSalesControl MSC;
        private WebAdminControl WAC;
        private Settings SC;
    }
}