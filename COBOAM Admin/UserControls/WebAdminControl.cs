using System;
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
            LoadLogs(sender, e);
            LoadAnnouncements();
            LoadDevotions();
            LoadGreetings();
        }

        private void LoadLogs(object s, EventArgs e)
        {
            Activity.Activity_Load(s,e);
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
                    LoadLogs(sender,e);
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
