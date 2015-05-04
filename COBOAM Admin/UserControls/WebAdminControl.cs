using System;
using System.Windows.Forms;
using System.Runtime.Caching;
using COBOAM_Admin.UserControls.WebAdmin;

namespace COBOAM_Admin.UserControls
{
    public partial class WebAdminControl : TUserControl
    {
        public WebAdminControl()
        {
            InitializeComponent();
        }

        private void LoadLogs()
        {
            Activity.Activity_Load();
        }

        private void LoadDevotions()
        {
            Devotion.Devotion_Load();
        }

        private void LoadGreetings()
        {
            Greetings.LoadGreeting();
        }
        private void LoadAnnouncements()
        {
            Announcements.Announcements_Load();
        }

        private void LoadMembers()
        {
            Members.Members_Load();
        }

        private void LoadNewsLetter()
        {
            Newsletter.Newsletter_Load();
        }

        private void LoadSermons()
        {

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
                case 4:
                    LoadMembers();
                    break;
                case 5:
                    LoadNewsLetter();
                    break;
                case 6:
                    LoadSermons();
                    break;
            }
        }

    }
}
