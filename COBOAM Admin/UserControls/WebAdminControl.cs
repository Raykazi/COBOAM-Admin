﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;

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
            LoadDevotions();

        }

        private void LoadLogs()
        {
            Activity.Load();
        }

        private void LoadDevotions()
        {
            Devotion.Load();
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    LoadLogs();
                    break;
                case 1:
                    LoadDevotions();
                    break;
            }
        }

        private void lbPrevDev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
