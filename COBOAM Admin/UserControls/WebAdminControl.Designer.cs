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
            this.Announcements = new COBOAM_Admin.UserControls.WebAdmin.Announcements();
            this.tpDevotion = new System.Windows.Forms.TabPage();
            this.Devotion = new COBOAM_Admin.UserControls.WebAdmin.Devotion();
            this.tpGreetings = new System.Windows.Forms.TabPage();
            this.Greetings = new COBOAM_Admin.UserControls.WebAdmin.Greetings();
            this.tpMembers = new System.Windows.Forms.TabPage();
            this.Members = new COBOAM_Admin.UserControls.WebAdmin.Members();
            this.tpNewsletter = new System.Windows.Forms.TabPage();
            this.tpSermons = new System.Windows.Forms.TabPage();
            this.Newsletter = new COBOAM_Admin.UserControls.WebAdmin.Newsletter();
            this.tabControl.SuspendLayout();
            this.tpActivity.SuspendLayout();
            this.tpAnnouncements.SuspendLayout();
            this.tpDevotion.SuspendLayout();
            this.tpGreetings.SuspendLayout();
            this.tpMembers.SuspendLayout();
            this.tpNewsletter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tpActivity);
            this.tabControl.Controls.Add(this.tpAnnouncements);
            this.tabControl.Controls.Add(this.tpDevotion);
            this.tabControl.Controls.Add(this.tpGreetings);
            this.tabControl.Controls.Add(this.tpMembers);
            this.tabControl.Controls.Add(this.tpNewsletter);
            this.tabControl.Controls.Add(this.tpSermons);
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
            this.tpAnnouncements.Controls.Add(this.Announcements);
            this.tpAnnouncements.Location = new System.Drawing.Point(4, 4);
            this.tpAnnouncements.Name = "tpAnnouncements";
            this.tpAnnouncements.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnnouncements.Size = new System.Drawing.Size(1042, 650);
            this.tpAnnouncements.TabIndex = 3;
            this.tpAnnouncements.Text = "Announcements";
            this.tpAnnouncements.UseVisualStyleBackColor = true;
            // 
            // Announcements
            // 
            this.Announcements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Announcements.Location = new System.Drawing.Point(3, 3);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(1036, 644);
            this.Announcements.TabIndex = 0;
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
            // tpGreetings
            // 
            this.tpGreetings.Controls.Add(this.Greetings);
            this.tpGreetings.Location = new System.Drawing.Point(4, 4);
            this.tpGreetings.Name = "tpGreetings";
            this.tpGreetings.Padding = new System.Windows.Forms.Padding(3);
            this.tpGreetings.Size = new System.Drawing.Size(1042, 650);
            this.tpGreetings.TabIndex = 2;
            this.tpGreetings.Text = "Greetings";
            this.tpGreetings.UseVisualStyleBackColor = true;
            // 
            // Greetings
            // 
            this.Greetings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Greetings.Location = new System.Drawing.Point(3, 3);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(1036, 644);
            this.Greetings.TabIndex = 0;
            // 
            // tpMembers
            // 
            this.tpMembers.Controls.Add(this.Members);
            this.tpMembers.Location = new System.Drawing.Point(4, 4);
            this.tpMembers.Name = "tpMembers";
            this.tpMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tpMembers.Size = new System.Drawing.Size(1042, 650);
            this.tpMembers.TabIndex = 4;
            this.tpMembers.Text = "Members";
            this.tpMembers.UseVisualStyleBackColor = true;
            // 
            // Members
            // 
            this.Members.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Members.Location = new System.Drawing.Point(3, 3);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(1036, 644);
            this.Members.TabIndex = 0;
            // 
            // tpNewsletter
            // 
            this.tpNewsletter.Controls.Add(this.Newsletter);
            this.tpNewsletter.Location = new System.Drawing.Point(4, 4);
            this.tpNewsletter.Name = "tpNewsletter";
            this.tpNewsletter.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewsletter.Size = new System.Drawing.Size(1042, 650);
            this.tpNewsletter.TabIndex = 5;
            this.tpNewsletter.Text = "Newsletter";
            this.tpNewsletter.UseVisualStyleBackColor = true;
            // 
            // tpSermons
            // 
            this.tpSermons.Location = new System.Drawing.Point(4, 4);
            this.tpSermons.Name = "tpSermons";
            this.tpSermons.Size = new System.Drawing.Size(1042, 650);
            this.tpSermons.TabIndex = 6;
            this.tpSermons.Text = "Sermons";
            this.tpSermons.UseVisualStyleBackColor = true;
            // 
            // Newsletter
            // 
            this.Newsletter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Newsletter.Location = new System.Drawing.Point(3, 3);
            this.Newsletter.Name = "Newsletter";
            this.Newsletter.Size = new System.Drawing.Size(1036, 644);
            this.Newsletter.TabIndex = 0;
            // 
            // WebAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "WebAdminControl";
            this.Size = new System.Drawing.Size(1050, 676);
            this.tabControl.ResumeLayout(false);
            this.tpActivity.ResumeLayout(false);
            this.tpAnnouncements.ResumeLayout(false);
            this.tpDevotion.ResumeLayout(false);
            this.tpGreetings.ResumeLayout(false);
            this.tpMembers.ResumeLayout(false);
            this.tpNewsletter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpActivity;
        private System.Windows.Forms.TabPage tpDevotion;
        private Activity Activity;
        private Devotion Devotion;
        private System.Windows.Forms.TabPage tpGreetings;
        private Greetings Greetings;
        private System.Windows.Forms.TabPage tpAnnouncements;
        private Announcements Announcements;
        private System.Windows.Forms.TabPage tpMembers;
        private Members Members;
        private System.Windows.Forms.TabPage tpNewsletter;
        private System.Windows.Forms.TabPage tpSermons;
        private Newsletter Newsletter;
    }
}
