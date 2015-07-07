namespace COBOAM_Admin.UserControls
{
    partial class SettingsControl
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
            this.gbDB = new System.Windows.Forms.GroupBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblUN = new System.Windows.Forms.Label();
            this.tbDDB = new System.Windows.Forms.TextBox();
            this.tbDPort = new System.Windows.Forms.TextBox();
            this.tbDHost = new System.Windows.Forms.TextBox();
            this.tbDPW = new System.Windows.Forms.TextBox();
            this.tbDUN = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbSMTP = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEPort = new System.Windows.Forms.TextBox();
            this.tbEHost = new System.Windows.Forms.TextBox();
            this.tbEPW = new System.Windows.Forms.TextBox();
            this.tbEUN = new System.Windows.Forms.TextBox();
            this.gbFTP = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFPort = new System.Windows.Forms.TextBox();
            this.tbFHost = new System.Windows.Forms.TextBox();
            this.tbFPW = new System.Windows.Forms.TextBox();
            this.tbFUN = new System.Windows.Forms.TextBox();
            this.gbALogin = new System.Windows.Forms.GroupBox();
            this.cbALE = new System.Windows.Forms.CheckBox();
            this.gbDB.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbSMTP.SuspendLayout();
            this.gbFTP.SuspendLayout();
            this.gbALogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDB
            // 
            this.gbDB.Controls.Add(this.lblDB);
            this.gbDB.Controls.Add(this.lblPort);
            this.gbDB.Controls.Add(this.lblHost);
            this.gbDB.Controls.Add(this.lblPW);
            this.gbDB.Controls.Add(this.lblUN);
            this.gbDB.Controls.Add(this.tbDDB);
            this.gbDB.Controls.Add(this.tbDPort);
            this.gbDB.Controls.Add(this.tbDHost);
            this.gbDB.Controls.Add(this.tbDPW);
            this.gbDB.Controls.Add(this.tbDUN);
            this.gbDB.Location = new System.Drawing.Point(3, 3);
            this.gbDB.Name = "gbDB";
            this.gbDB.Size = new System.Drawing.Size(191, 167);
            this.gbDB.TabIndex = 0;
            this.gbDB.TabStop = false;
            this.gbDB.Text = "Database";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(8, 131);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(56, 13);
            this.lblDB.TabIndex = 1;
            this.lblDB.Text = "Database:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(35, 105);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(32, 79);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(8, 53);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(56, 13);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "Password:";
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(6, 27);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(58, 13);
            this.lblUN.TabIndex = 1;
            this.lblUN.Text = "Username:";
            // 
            // tbDDB
            // 
            this.tbDDB.Location = new System.Drawing.Point(69, 131);
            this.tbDDB.Name = "tbDDB";
            this.tbDDB.Size = new System.Drawing.Size(100, 20);
            this.tbDDB.TabIndex = 4;
            // 
            // tbDPort
            // 
            this.tbDPort.Location = new System.Drawing.Point(69, 105);
            this.tbDPort.Name = "tbDPort";
            this.tbDPort.Size = new System.Drawing.Size(100, 20);
            this.tbDPort.TabIndex = 3;
            // 
            // tbDHost
            // 
            this.tbDHost.Location = new System.Drawing.Point(69, 79);
            this.tbDHost.Name = "tbDHost";
            this.tbDHost.Size = new System.Drawing.Size(100, 20);
            this.tbDHost.TabIndex = 2;
            // 
            // tbDPW
            // 
            this.tbDPW.Location = new System.Drawing.Point(69, 53);
            this.tbDPW.Name = "tbDPW";
            this.tbDPW.Size = new System.Drawing.Size(100, 20);
            this.tbDPW.TabIndex = 1;
            // 
            // tbDUN
            // 
            this.tbDUN.Location = new System.Drawing.Point(69, 27);
            this.tbDUN.Name = "tbDUN";
            this.tbDUN.Size = new System.Drawing.Size(100, 20);
            this.tbDUN.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(84, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gbDB);
            this.flowLayoutPanel1.Controls.Add(this.gbSMTP);
            this.flowLayoutPanel1.Controls.Add(this.gbFTP);
            this.flowLayoutPanel1.Controls.Add(this.gbALogin);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(403, 395);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // gbSMTP
            // 
            this.gbSMTP.Controls.Add(this.label2);
            this.gbSMTP.Controls.Add(this.label3);
            this.gbSMTP.Controls.Add(this.label4);
            this.gbSMTP.Controls.Add(this.label5);
            this.gbSMTP.Controls.Add(this.tbEPort);
            this.gbSMTP.Controls.Add(this.tbEHost);
            this.gbSMTP.Controls.Add(this.tbEPW);
            this.gbSMTP.Controls.Add(this.tbEUN);
            this.gbSMTP.Location = new System.Drawing.Point(200, 3);
            this.gbSMTP.Name = "gbSMTP";
            this.gbSMTP.Size = new System.Drawing.Size(191, 167);
            this.gbSMTP.TabIndex = 7;
            this.gbSMTP.TabStop = false;
            this.gbSMTP.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Host:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username:";
            // 
            // tbEPort
            // 
            this.tbEPort.Location = new System.Drawing.Point(69, 105);
            this.tbEPort.Name = "tbEPort";
            this.tbEPort.Size = new System.Drawing.Size(100, 20);
            this.tbEPort.TabIndex = 3;
            // 
            // tbEHost
            // 
            this.tbEHost.Location = new System.Drawing.Point(69, 79);
            this.tbEHost.Name = "tbEHost";
            this.tbEHost.Size = new System.Drawing.Size(100, 20);
            this.tbEHost.TabIndex = 2;
            // 
            // tbEPW
            // 
            this.tbEPW.Location = new System.Drawing.Point(69, 53);
            this.tbEPW.Name = "tbEPW";
            this.tbEPW.Size = new System.Drawing.Size(100, 20);
            this.tbEPW.TabIndex = 1;
            // 
            // tbEUN
            // 
            this.tbEUN.Location = new System.Drawing.Point(69, 27);
            this.tbEUN.Name = "tbEUN";
            this.tbEUN.Size = new System.Drawing.Size(100, 20);
            this.tbEUN.TabIndex = 0;
            // 
            // gbFTP
            // 
            this.gbFTP.Controls.Add(this.label7);
            this.gbFTP.Controls.Add(this.label8);
            this.gbFTP.Controls.Add(this.label9);
            this.gbFTP.Controls.Add(this.label10);
            this.gbFTP.Controls.Add(this.tbFPort);
            this.gbFTP.Controls.Add(this.tbFHost);
            this.gbFTP.Controls.Add(this.tbFPW);
            this.gbFTP.Controls.Add(this.tbFUN);
            this.gbFTP.Location = new System.Drawing.Point(3, 176);
            this.gbFTP.Name = "gbFTP";
            this.gbFTP.Size = new System.Drawing.Size(191, 167);
            this.gbFTP.TabIndex = 8;
            this.gbFTP.TabStop = false;
            this.gbFTP.Text = "FTP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Host:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Username:";
            // 
            // tbFPort
            // 
            this.tbFPort.Location = new System.Drawing.Point(69, 105);
            this.tbFPort.Name = "tbFPort";
            this.tbFPort.Size = new System.Drawing.Size(100, 20);
            this.tbFPort.TabIndex = 3;
            // 
            // tbFHost
            // 
            this.tbFHost.Location = new System.Drawing.Point(69, 79);
            this.tbFHost.Name = "tbFHost";
            this.tbFHost.Size = new System.Drawing.Size(100, 20);
            this.tbFHost.TabIndex = 2;
            // 
            // tbFPW
            // 
            this.tbFPW.Location = new System.Drawing.Point(69, 53);
            this.tbFPW.Name = "tbFPW";
            this.tbFPW.Size = new System.Drawing.Size(100, 20);
            this.tbFPW.TabIndex = 1;
            // 
            // tbFUN
            // 
            this.tbFUN.Location = new System.Drawing.Point(69, 27);
            this.tbFUN.Name = "tbFUN";
            this.tbFUN.Size = new System.Drawing.Size(100, 20);
            this.tbFUN.TabIndex = 0;
            // 
            // gbALogin
            // 
            this.gbALogin.Controls.Add(this.cbALE);
            this.gbALogin.Location = new System.Drawing.Point(200, 176);
            this.gbALogin.Name = "gbALogin";
            this.gbALogin.Size = new System.Drawing.Size(191, 66);
            this.gbALogin.TabIndex = 9;
            this.gbALogin.TabStop = false;
            this.gbALogin.Text = "Auto Login";
            // 
            // cbALE
            // 
            this.cbALE.AutoSize = true;
            this.cbALE.Location = new System.Drawing.Point(11, 30);
            this.cbALE.Name = "cbALE";
            this.cbALE.Size = new System.Drawing.Size(106, 17);
            this.cbALE.TabIndex = 0;
            this.cbALE.Text = "Save Credentials";
            this.cbALE.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(403, 395);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbDB.ResumeLayout(false);
            this.gbDB.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbSMTP.ResumeLayout(false);
            this.gbSMTP.PerformLayout();
            this.gbFTP.ResumeLayout(false);
            this.gbFTP.PerformLayout();
            this.gbALogin.ResumeLayout(false);
            this.gbALogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDB;
        private System.Windows.Forms.TextBox tbDDB;
        private System.Windows.Forms.TextBox tbDPort;
        private System.Windows.Forms.TextBox tbDHost;
        private System.Windows.Forms.TextBox tbDPW;
        private System.Windows.Forms.TextBox tbDUN;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gbSMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEPort;
        private System.Windows.Forms.TextBox tbEHost;
        private System.Windows.Forms.TextBox tbEPW;
        private System.Windows.Forms.TextBox tbEUN;
        private System.Windows.Forms.GroupBox gbFTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFPort;
        private System.Windows.Forms.TextBox tbFHost;
        private System.Windows.Forms.TextBox tbFPW;
        private System.Windows.Forms.TextBox tbFUN;
        private System.Windows.Forms.GroupBox gbALogin;
        private System.Windows.Forms.CheckBox cbALE;

    }
}
