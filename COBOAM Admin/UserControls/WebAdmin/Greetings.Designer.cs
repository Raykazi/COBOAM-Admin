namespace COBOAM_Admin.UserControls.WebAdmin
{
    partial class Greetings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbPart1 = new System.Windows.Forms.TextBox();
            this.tbPart2 = new System.Windows.Forms.TextBox();
            this.cbCurrent = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPart1 = new System.Windows.Forms.Label();
            this.lblPart2 = new System.Windows.Forms.Label();
            this.lbGreetings = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(181, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(263, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(181, 3);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(266, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // tbPart1
            // 
            this.tbPart1.Location = new System.Drawing.Point(181, 29);
            this.tbPart1.Multiline = true;
            this.tbPart1.Name = "tbPart1";
            this.tbPart1.Size = new System.Drawing.Size(375, 200);
            this.tbPart1.TabIndex = 3;
            // 
            // tbPart2
            // 
            this.tbPart2.Location = new System.Drawing.Point(181, 236);
            this.tbPart2.Multiline = true;
            this.tbPart2.Name = "tbPart2";
            this.tbPart2.Size = new System.Drawing.Size(375, 200);
            this.tbPart2.TabIndex = 4;
            // 
            // cbCurrent
            // 
            this.cbCurrent.AutoSize = true;
            this.cbCurrent.Location = new System.Drawing.Point(453, 5);
            this.cbCurrent.Name = "cbCurrent";
            this.cbCurrent.Size = new System.Drawing.Size(103, 17);
            this.cbCurrent.TabIndex = 5;
            this.cbCurrent.Text = "Current Greeting";
            this.cbCurrent.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(140, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title:";
            // 
            // lblPart1
            // 
            this.lblPart1.AutoSize = true;
            this.lblPart1.Location = new System.Drawing.Point(140, 36);
            this.lblPart1.Name = "lblPart1";
            this.lblPart1.Size = new System.Drawing.Size(38, 13);
            this.lblPart1.TabIndex = 6;
            this.lblPart1.Text = "Part 1:";
            // 
            // lblPart2
            // 
            this.lblPart2.AutoSize = true;
            this.lblPart2.Location = new System.Drawing.Point(140, 239);
            this.lblPart2.Name = "lblPart2";
            this.lblPart2.Size = new System.Drawing.Size(35, 13);
            this.lblPart2.TabIndex = 6;
            this.lblPart2.Text = "Part 2";
            // 
            // lbGreetings
            // 
            this.lbGreetings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGreetings.FormattingEnabled = true;
            this.lbGreetings.Location = new System.Drawing.Point(0, 0);
            this.lbGreetings.Name = "lbGreetings";
            this.lbGreetings.Size = new System.Drawing.Size(135, 484);
            this.lbGreetings.TabIndex = 7;
            this.lbGreetings.SelectedIndexChanged += new System.EventHandler(this.lbGreetings_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbGreetings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 484);
            this.panel1.TabIndex = 8;
            // 
            // Greetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPart2);
            this.Controls.Add(this.lblPart1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbCurrent);
            this.Controls.Add(this.tbPart2);
            this.Controls.Add(this.tbPart1);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "Greetings";
            this.Size = new System.Drawing.Size(599, 484);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbPart1;
        private System.Windows.Forms.TextBox tbPart2;
        private System.Windows.Forms.CheckBox cbCurrent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPart1;
        private System.Windows.Forms.Label lblPart2;
        private System.Windows.Forms.ListBox lbGreetings;
        private System.Windows.Forms.Panel panel1;
    }
}
