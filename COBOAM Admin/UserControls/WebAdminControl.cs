﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;
using COBOAM_Admin.UserControls.WebAdmin;

namespace COBOAM_Admin.UserControls
{
    public partial class WebAdminControl : UserControl
    {
        public WebAdminControl()
        {
            InitializeComponent();
        }

        private void WebAdminControl_Load(object sender, EventArgs e)
        {
            LoadLogs();
            LoadAnnouncements();
            LoadDevotions();
            LoadGreetings();
        }

        private void LoadLogs()
        {
            Activity.Load();
        }

        private void LoadDevotions()
        {
            Devotion.Load();
        }

        private void LoadGreetings()
        {
            Greetings.Load();
        }
        private void LoadAnnouncements()
        {
            Announcements.Load();
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    LoadLogs();
                    break;
                case 1:
                    LoadAnnouncements();
                    break;
                case 2:
                    LoadDevotions();
                    break;
                case 3:
                    LoadGreetings();
                    break;
            }
        }

    }
}
