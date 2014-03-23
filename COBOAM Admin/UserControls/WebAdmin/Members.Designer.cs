namespace COBOAM_Admin.UserControls.WebAdmin
{
    partial class Members
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblUN = new System.Windows.Forms.Label();
            this.tbUN = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblAL = new System.Windows.Forms.Label();
            this.cbAL = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbNameFilter = new System.Windows.Forms.TextBox();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.lbMembers);
            this.panelSide.Controls.Add(this.tbNameFilter);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(142, 599);
            this.panelSide.TabIndex = 0;
            // 
            // lbMembers
            // 
            this.lbMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.Location = new System.Drawing.Point(0, 20);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(142, 579);
            this.lbMembers.TabIndex = 0;
            this.lbMembers.SelectedIndexChanged += new System.EventHandler(this.lbMembers_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(161, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(208, 8);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 2;
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(144, 37);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(58, 13);
            this.lblUN.TabIndex = 1;
            this.lblUN.Text = "Username:";
            // 
            // tbUN
            // 
            this.tbUN.Location = new System.Drawing.Point(208, 34);
            this.tbUN.Name = "tbUN";
            this.tbUN.Size = new System.Drawing.Size(156, 20);
            this.tbUN.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(167, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(208, 60);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(156, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // lblAL
            // 
            this.lblAL.AutoSize = true;
            this.lblAL.Location = new System.Drawing.Point(148, 89);
            this.lblAL.Name = "lblAL";
            this.lblAL.Size = new System.Drawing.Size(54, 13);
            this.lblAL.TabIndex = 3;
            this.lblAL.Text = "Privelege:";
            // 
            // cbAL
            // 
            this.cbAL.FormattingEnabled = true;
            this.cbAL.Location = new System.Drawing.Point(208, 86);
            this.cbAL.Name = "cbAL";
            this.cbAL.Size = new System.Drawing.Size(156, 21);
            this.cbAL.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbNameFilter
            // 
            this.tbNameFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNameFilter.Location = new System.Drawing.Point(0, 0);
            this.tbNameFilter.Name = "tbNameFilter";
            this.tbNameFilter.Size = new System.Drawing.Size(142, 20);
            this.tbNameFilter.TabIndex = 7;
            this.tbNameFilter.TextChanged += new System.EventHandler(this.tbNameFilter_TextChanged);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbAL);
            this.Controls.Add(this.lblAL);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbUN);
            this.Controls.Add(this.lblUN);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelSide);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(951, 599);
            this.Load += new System.EventHandler(this.Members_Load);
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNameFilter;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.TextBox tbUN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblAL;
        private System.Windows.Forms.ComboBox cbAL;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}
