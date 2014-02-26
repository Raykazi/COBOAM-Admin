﻿using System;
using COBOAM_Admin.UserControls.WebAdmin;

namespace COBOAM_Admin.UserControls
{
    partial class WebAdminControl
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpActivity = new System.Windows.Forms.TabPage();
            this.Activity = new COBOAM_Admin.UserControls.WebAdmin.Activity();
            this.tpAnnouncements = new System.Windows.Forms.TabPage();
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
            this.tabControl.SuspendLayout();
            this.tpActivity.SuspendLayout();
            this.tpAnnouncements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tpActivity);
            this.tabControl.Controls.Add(this.tpAnnouncements);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1050, 676);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpActivity
            // 
            this.tpActivity.BackColor = System.Drawing.SystemColors.Control;
            this.tpActivity.Controls.Add(this.Activity);
            this.tpActivity.Location = new System.Drawing.Point(4, 4);
            this.tpActivity.Name = "tpActivity";
            this.tpActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tpActivity.Size = new System.Drawing.Size(1042, 650);
            this.tpActivity.TabIndex = 0;
            this.tpActivity.Text = "Activity";
            // 
            // Activity
            // 
            this.Activity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Activity.Location = new System.Drawing.Point(3, 3);
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(1036, 644);
            this.Activity.TabIndex = 0;
            // 
            // tpAnnouncements
            // 
            this.tpAnnouncements.BackColor = System.Drawing.SystemColors.Control;
            this.tpAnnouncements.Controls.Add(this.btnDelete);
            this.tpAnnouncements.Controls.Add(this.btnSave);
            this.tpAnnouncements.Controls.Add(this.nudYear);
            this.tpAnnouncements.Controls.Add(this.cbMonth);
            this.tpAnnouncements.Controls.Add(this.tbText);
            this.tpAnnouncements.Controls.Add(this.tbScripture);
            this.tpAnnouncements.Controls.Add(this.tbQuote);
            this.tpAnnouncements.Controls.Add(this.lblText);
            this.tpAnnouncements.Controls.Add(this.lblScripture);
            this.tpAnnouncements.Controls.Add(this.lblQuote);
            this.tpAnnouncements.Controls.Add(this.lblDate);
            this.tpAnnouncements.Controls.Add(this.panelSide);
            this.tpAnnouncements.Location = new System.Drawing.Point(4, 4);
            this.tpAnnouncements.Name = "tpAnnouncements";
            this.tpAnnouncements.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnnouncements.Size = new System.Drawing.Size(1042, 650);
            this.tpAnnouncements.TabIndex = 1;
            this.tpAnnouncements.Text = "Announcements";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(211, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(345, 27);
            this.nudYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(56, 20);
            this.nudYear.TabIndex = 4;
            this.nudYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(211, 26);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbMonth.TabIndex = 3;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(211, 154);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(457, 300);
            this.tbText.TabIndex = 2;
            // 
            // tbScripture
            // 
            this.tbScripture.Location = new System.Drawing.Point(211, 110);
            this.tbScripture.Name = "tbScripture";
            this.tbScripture.Size = new System.Drawing.Size(190, 20);
            this.tbScripture.TabIndex = 2;
            // 
            // tbQuote
            // 
            this.tbQuote.Location = new System.Drawing.Point(211, 71);
            this.tbQuote.Name = "tbQuote";
            this.tbQuote.Size = new System.Drawing.Size(190, 20);
            this.tbQuote.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(159, 154);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text:";
            // 
            // lblScripture
            // 
            this.lblScripture.AutoSize = true;
            this.lblScripture.Location = new System.Drawing.Point(138, 117);
            this.lblScripture.Name = "lblScripture";
            this.lblScripture.Size = new System.Drawing.Size(52, 13);
            this.lblScripture.TabIndex = 1;
            this.lblScripture.Text = "Scripture:";
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Location = new System.Drawing.Point(151, 78);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(39, 13);
            this.lblQuote.TabIndex = 1;
            this.lblQuote.Text = "Quote:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(157, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.lbPrevDev);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(3, 3);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(126, 644);
            this.panelSide.TabIndex = 0;
            // 
            // lbPrevDev
            // 
            this.lbPrevDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrevDev.FormattingEnabled = true;
            this.lbPrevDev.Location = new System.Drawing.Point(0, 0);
            this.lbPrevDev.Name = "lbPrevDev";
            this.lbPrevDev.Size = new System.Drawing.Size(126, 644);
            this.lbPrevDev.TabIndex = 0;
            this.lbPrevDev.SelectedIndexChanged += new System.EventHandler(this.lbPrevDev_SelectedIndexChanged);
            // 
            // WebAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "WebAdminControl";
            this.Size = new System.Drawing.Size(1050, 676);
            this.Load += new System.EventHandler(this.WebAdminControl_Load);
            this.tabControl.ResumeLayout(false);
            this.tpActivity.ResumeLayout(false);
            this.tpAnnouncements.ResumeLayout(false);
            this.tpAnnouncements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpActivity;
        private System.Windows.Forms.TabPage tpAnnouncements;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.ListBox lbPrevDev;
        private System.Windows.Forms.Label lblScripture;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbScripture;
        private System.Windows.Forms.TextBox tbQuote;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private Activity Activity;
    }
}
