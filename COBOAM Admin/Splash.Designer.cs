namespace COBOAM_Admin
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.BWLoad = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PBar
            // 
            this.PBar.Location = new System.Drawing.Point(194, 241);
            this.PBar.Name = "PBar";
            this.PBar.Size = new System.Drawing.Size(172, 23);
            this.PBar.Step = 0;
            this.PBar.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(263, 267);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // BWLoad
            // 
            this.BWLoad.WorkerReportsProgress = true;
            this.BWLoad.WorkerSupportsCancellation = true;
            this.BWLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWLoad_DoWork);
            this.BWLoad.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWLoad_ProgressChanged);
            this.BWLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWLoad_RunWorkerCompleted);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COBOAM_Admin.Properties.Resources.Splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(571, 321);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.PBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.ProgressBar PBar;
        private System.ComponentModel.BackgroundWorker BWLoad;
        private System.Windows.Forms.Label lblStatus;
    }
}