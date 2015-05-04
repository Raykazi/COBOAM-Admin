namespace COBOAM_Admin.UserControls.WebAdmin
{
    partial class Newsletter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdNewsletter = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbCI = new System.Windows.Forms.CheckBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lblVolume = new System.Windows.Forms.Label();
            this.cbVolume = new System.Windows.Forms.ComboBox();
            this.tbFileLocation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbUpload = new System.Windows.Forms.GroupBox();
            this.lblUStatus = new System.Windows.Forms.Label();
            this.gbDistrubute = new System.Windows.Forms.GroupBox();
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.lblDStatus = new System.Windows.Forms.Label();
            this.pBarDistribute = new System.Windows.Forms.ProgressBar();
            this.btnDistribute = new System.Windows.Forms.Button();
            this.bwUpload = new System.ComponentModel.BackgroundWorker();
            this.bwDistribute = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.gbUpload.SuspendLayout();
            this.gbDistrubute.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(165, 19);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 50);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year:";
            // 
            // cbCI
            // 
            this.cbCI.AutoSize = true;
            this.cbCI.Location = new System.Drawing.Point(149, 81);
            this.cbCI.Name = "cbCI";
            this.cbCI.Size = new System.Drawing.Size(88, 17);
            this.cbCI.TabIndex = 4;
            this.cbCI.Text = "Current Issue";
            this.cbCI.UseVisualStyleBackColor = true;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(60, 48);
            this.nudYear.Maximum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(83, 20);
            this.nudYear.TabIndex = 3;
            this.nudYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(6, 82);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(48, 13);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Volume: ";
            // 
            // cbVolume
            // 
            this.cbVolume.FormattingEnabled = true;
            this.cbVolume.Location = new System.Drawing.Point(60, 79);
            this.cbVolume.Name = "cbVolume";
            this.cbVolume.Size = new System.Drawing.Size(83, 21);
            this.cbVolume.TabIndex = 5;
            // 
            // tbFileLocation
            // 
            this.tbFileLocation.Location = new System.Drawing.Point(9, 22);
            this.tbFileLocation.Name = "tbFileLocation";
            this.tbFileLocation.Size = new System.Drawing.Size(150, 20);
            this.tbFileLocation.TabIndex = 2;
            this.tbFileLocation.Text = "Click to browse for newsletter.";
            this.tbFileLocation.Click += new System.EventHandler(this.tbFileLocation_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbUpload
            // 
            this.gbUpload.Controls.Add(this.lblUStatus);
            this.gbUpload.Controls.Add(this.btnUpload);
            this.gbUpload.Controls.Add(this.tbFileLocation);
            this.gbUpload.Controls.Add(this.btnSave);
            this.gbUpload.Controls.Add(this.cbVolume);
            this.gbUpload.Controls.Add(this.lblYear);
            this.gbUpload.Controls.Add(this.lblVolume);
            this.gbUpload.Controls.Add(this.cbCI);
            this.gbUpload.Controls.Add(this.nudYear);
            this.gbUpload.Location = new System.Drawing.Point(3, 3);
            this.gbUpload.Name = "gbUpload";
            this.gbUpload.Size = new System.Drawing.Size(246, 149);
            this.gbUpload.TabIndex = 8;
            this.gbUpload.TabStop = false;
            this.gbUpload.Text = "Upload";
            // 
            // lblUStatus
            // 
            this.lblUStatus.AutoSize = true;
            this.lblUStatus.Location = new System.Drawing.Point(162, 50);
            this.lblUStatus.Name = "lblUStatus";
            this.lblUStatus.Size = new System.Drawing.Size(0, 13);
            this.lblUStatus.TabIndex = 8;
            // 
            // gbDistrubute
            // 
            this.gbDistrubute.Controls.Add(this.tbLogs);
            this.gbDistrubute.Controls.Add(this.lblDStatus);
            this.gbDistrubute.Controls.Add(this.pBarDistribute);
            this.gbDistrubute.Controls.Add(this.btnDistribute);
            this.gbDistrubute.Location = new System.Drawing.Point(3, 158);
            this.gbDistrubute.Name = "gbDistrubute";
            this.gbDistrubute.Size = new System.Drawing.Size(246, 223);
            this.gbDistrubute.TabIndex = 9;
            this.gbDistrubute.TabStop = false;
            this.gbDistrubute.Text = "Distribute";
            // 
            // tbLogs
            // 
            this.tbLogs.Location = new System.Drawing.Point(9, 48);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.Size = new System.Drawing.Size(218, 140);
            this.tbLogs.TabIndex = 10;
            // 
            // lblDStatus
            // 
            this.lblDStatus.AutoSize = true;
            this.lblDStatus.Location = new System.Drawing.Point(96, 96);
            this.lblDStatus.Name = "lblDStatus";
            this.lblDStatus.Size = new System.Drawing.Size(0, 13);
            this.lblDStatus.TabIndex = 4;
            // 
            // pBarDistribute
            // 
            this.pBarDistribute.Location = new System.Drawing.Point(9, 194);
            this.pBarDistribute.Name = "pBarDistribute";
            this.pBarDistribute.Size = new System.Drawing.Size(218, 23);
            this.pBarDistribute.TabIndex = 3;
            this.pBarDistribute.Visible = false;
            // 
            // btnDistribute
            // 
            this.btnDistribute.Location = new System.Drawing.Point(68, 19);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(75, 23);
            this.btnDistribute.TabIndex = 2;
            this.btnDistribute.Text = "Distribute";
            this.btnDistribute.UseVisualStyleBackColor = true;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // bwUpload
            // 
            this.bwUpload.WorkerReportsProgress = true;
            this.bwUpload.WorkerSupportsCancellation = true;
            this.bwUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpload_DoWork);
            this.bwUpload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpload_RunWorkerCompleted);
            // 
            // bwDistribute
            // 
            this.bwDistribute.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDistribute_DoWork);
            this.bwDistribute.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwDistribute_ProgressChanged);
            this.bwDistribute.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDistribute_RunWorkerCompleted);
            // 
            // Newsletter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDistrubute);
            this.Controls.Add(this.gbUpload);
            this.Name = "Newsletter";
            this.Size = new System.Drawing.Size(273, 393);
            this.Load += new System.EventHandler(this.Newsletter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.gbUpload.ResumeLayout(false);
            this.gbUpload.PerformLayout();
            this.gbDistrubute.ResumeLayout(false);
            this.gbDistrubute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdNewsletter;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.CheckBox cbCI;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ComboBox cbVolume;
        private System.Windows.Forms.TextBox tbFileLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbUpload;
        private System.Windows.Forms.GroupBox gbDistrubute;
        private System.ComponentModel.BackgroundWorker bwUpload;
        private System.Windows.Forms.Label lblUStatus;
        private System.ComponentModel.BackgroundWorker bwDistribute;
        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.ProgressBar pBarDistribute;
        private System.Windows.Forms.Label lblDStatus;
        private System.Windows.Forms.TextBox tbLogs;
    }
}
