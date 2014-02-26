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
            this.tpDevotion = new System.Windows.Forms.TabPage();
            this.Devotion = new COBOAM_Admin.UserControls.WebAdmin.Devotion();
            this.tabControl.SuspendLayout();
            this.tpActivity.SuspendLayout();
            this.tpDevotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tpActivity);
            this.tabControl.Controls.Add(this.tpDevotion);
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
            // tpDevotion
            // 
            this.tpDevotion.BackColor = System.Drawing.SystemColors.Control;
            this.tpDevotion.Controls.Add(this.Devotion);
            this.tpDevotion.Location = new System.Drawing.Point(4, 4);
            this.tpDevotion.Name = "tpDevotion";
            this.tpDevotion.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevotion.Size = new System.Drawing.Size(1042, 650);
            this.tpDevotion.TabIndex = 1;
            this.tpDevotion.Text = "Devotions";
            // 
            // Devotion
            // 
            this.Devotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Devotion.Location = new System.Drawing.Point(3, 3);
            this.Devotion.Name = "Devotion";
            this.Devotion.Size = new System.Drawing.Size(1036, 644);
            this.Devotion.TabIndex = 0;
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
            this.tpDevotion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpActivity;
        private System.Windows.Forms.TabPage tpDevotion;
        private Activity Activity;
        private Devotion Devotion;
    }
}
