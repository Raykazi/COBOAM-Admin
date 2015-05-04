namespace COBOAM_Admin.UserControls.WebAdmin
{
    partial class Announcements
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.lblSDate = new System.Windows.Forms.Label();
            this.lblEDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nudOrder = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lbAnnouncements);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(135, 478);
            this.panelLeft.TabIndex = 9;
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.AllowDrop = true;
            this.lbAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.Location = new System.Drawing.Point(0, 0);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(135, 478);
            this.lbAnnouncements.TabIndex = 0;
            this.lbAnnouncements.SelectedIndexChanged += new System.EventHandler(this.lbAnnouncements_SelectedIndexChanged);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(183, 3);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(142, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title: ";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(183, 29);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(423, 152);
            this.tbText.TabIndex = 3;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(142, 36);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(34, 13);
            this.lblText.TabIndex = 11;
            this.lblText.Text = "Text: ";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(183, 187);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 4;
            // 
            // dtpStop
            // 
            this.dtpStop.Location = new System.Drawing.Point(183, 213);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(200, 20);
            this.dtpStop.TabIndex = 5;
            // 
            // lblSDate
            // 
            this.lblSDate.AutoSize = true;
            this.lblSDate.Location = new System.Drawing.Point(142, 194);
            this.lblSDate.Name = "lblSDate";
            this.lblSDate.Size = new System.Drawing.Size(35, 13);
            this.lblSDate.TabIndex = 11;
            this.lblSDate.Text = "Start: ";
            // 
            // lblEDate
            // 
            this.lblEDate.AutoSize = true;
            this.lblEDate.Location = new System.Drawing.Point(142, 220);
            this.lblEDate.Name = "lblEDate";
            this.lblEDate.Size = new System.Drawing.Size(35, 13);
            this.lblEDate.TabIndex = 11;
            this.lblEDate.Text = "Stop: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nudOrder
            // 
            this.nudOrder.Location = new System.Drawing.Point(345, 4);
            this.nudOrder.Name = "nudOrder";
            this.nudOrder.Size = new System.Drawing.Size(38, 20);
            this.nudOrder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Order: ";
            // 
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblEDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSDate);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.panelLeft);
            this.Name = "Announcements";
            this.Size = new System.Drawing.Size(636, 478);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.Label lblSDate;
        private System.Windows.Forms.Label lblEDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nudOrder;
        private System.Windows.Forms.Label label1;
    }
}
