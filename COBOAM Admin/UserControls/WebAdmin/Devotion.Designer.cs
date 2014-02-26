namespace COBOAM_Admin.UserControls.WebAdmin
{
    partial class Devotion
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbScripture = new System.Windows.Forms.TextBox();
            this.tbQuote = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblScripture = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.lbPrevDev = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(343, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(262, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(396, 27);
            this.nudYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(56, 20);
            this.nudYear.TabIndex = 15;
            this.nudYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(262, 26);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbMonth.TabIndex = 14;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(262, 154);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(457, 300);
            this.tbText.TabIndex = 11;
            // 
            // tbScripture
            // 
            this.tbScripture.Location = new System.Drawing.Point(262, 110);
            this.tbScripture.Name = "tbScripture";
            this.tbScripture.Size = new System.Drawing.Size(190, 20);
            this.tbScripture.TabIndex = 12;
            // 
            // tbQuote
            // 
            this.tbQuote.Location = new System.Drawing.Point(262, 71);
            this.tbQuote.Name = "tbQuote";
            this.tbQuote.Size = new System.Drawing.Size(190, 20);
            this.tbQuote.TabIndex = 13;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(210, 154);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Text:";
            // 
            // lblScripture
            // 
            this.lblScripture.AutoSize = true;
            this.lblScripture.Location = new System.Drawing.Point(189, 117);
            this.lblScripture.Name = "lblScripture";
            this.lblScripture.Size = new System.Drawing.Size(52, 13);
            this.lblScripture.TabIndex = 8;
            this.lblScripture.Text = "Scripture:";
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Location = new System.Drawing.Point(202, 78);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(39, 13);
            this.lblQuote.TabIndex = 9;
            this.lblQuote.Text = "Quote:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(208, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date:";
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.lbPrevDev);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(126, 502);
            this.panelSide.TabIndex = 6;
            // 
            // lbPrevDev
            // 
            this.lbPrevDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrevDev.FormattingEnabled = true;
            this.lbPrevDev.Location = new System.Drawing.Point(0, 0);
            this.lbPrevDev.Name = "lbPrevDev";
            this.lbPrevDev.Size = new System.Drawing.Size(126, 502);
            this.lbPrevDev.TabIndex = 0;
            this.lbPrevDev.SelectedIndexChanged += new System.EventHandler(this.lbPrevDev_SelectedIndexChanged);
            // 
            // Devotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbScripture);
            this.Controls.Add(this.tbQuote);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblScripture);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panelSide);
            this.Name = "Devotion";
            this.Size = new System.Drawing.Size(771, 502);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbScripture;
        private System.Windows.Forms.TextBox tbQuote;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblScripture;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.ListBox lbPrevDev;

    }
}
