using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Announcements : UserControl
    {
        Tuple<List<string>[], int> _tuple = new Tuple<List<string>[], int>(null,-1);
        List<string>[] _announcementData;
        private readonly DateTime _cDate = DateTime.Now;
        public Announcements()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == String.Empty)
            {
                MessageBox.Show(Resources.Announcements_Need_Title, Resources.MB_Caption_Error);
                return;
            }
            if (tbText.Text == String.Empty)
            {
                MessageBox.Show(Resources.General_Need_Text, Resources.MB_Caption_Error);
                return;
            }
            int index = lbAnnouncements.SelectedIndex;
            int result = -1;
            string query;
            string title = HttpUtility.HtmlEncode(tbTitle.Text);
            string text = HttpUtility.HtmlEncode(tbText.Text);
            string Start = dtpStart.Value.Year + "-" + dtpStart.Value.Month + "-" + dtpStart.Value.Day;
            string End = dtpStop.Value.Year + "-" + dtpStop.Value.Month + "-" + dtpStop.Value.Day;
            if (index <= 0)
            {
                query = Classes.MySql.GetQuery(QueryIndex.Announcement2, title, text, Start, End);
                result = Program.MySql.ExecuteNonQuery(query);
                if(result != 1) return;
                query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has created the Announcement for \"" + title + "\".");
                result = Program.MySql.ExecuteNonQuery(query);
                if (result == 1)
                {
                    MessageBox.Show(Resources.Announcements_Created);
                }
            }
            else
            {
                index -= 1;
                int ID = Convert.ToInt32(_announcementData[0][index]);
                query = Classes.MySql.GetQuery(QueryIndex.Announcement3, title, text, Start, End, ID);
                result = Program.MySql.ExecuteNonQuery(query);
                if (result != 1) return;
                query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has updated the Announcement \"" + title + "\".");
                result = Program.MySql.ExecuteNonQuery(query);
                if (result == 1)
                {
                    MessageBox.Show(Resources.Announcements_Updated);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(String.Format(Resources.MB_Announcements_Delete, tbTitle.Text), Resources.MB_Confirmation, MessageBoxButtons.YesNo);
            if (dialogresult != DialogResult.Yes) return;
            string query = Classes.MySql.GetQuery(QueryIndex.Announcement4, _announcementData[0][lbAnnouncements.SelectedIndex-1]);
            var result = Program.MySql.ExecuteNonQuery(query);
            if (result == -1) return;
            query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has deleted the Announcement for  \"" + tbTitle + "\".");
            result = Program.MySql.ExecuteNonQuery(query);
            if (result != 1) return;
            Announcements_Load();
        }

        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbAnnouncements.SelectedIndex;
            switch (index)
            {
                case 0:
                    tbTitle.Text = String.Empty;
                    tbText.Text = String.Empty;
                    dtpStart.Value = DateTime.Now;
                    dtpStop.Value = DateTime.Now.AddDays(7);
                    break;
                default:
                    index -= 1;
                    tbTitle.Text = HttpUtility.HtmlDecode(_announcementData[2][index]);
                    tbText.Text = HttpUtility.HtmlDecode(_announcementData[3][index]);
                    dtpStart.Value = DateTime.Parse(_announcementData[4][index]);
                    dtpStop.Value = DateTime.Parse(_announcementData[5][index]);
                    break;
            }
        }

        public void Announcements_Load(object sender = null, EventArgs e = null)
        {
            _tuple = Program.MySql.ExecuteReader(Queries.Value(QueryIndex.Announcement1));
            _announcementData = _tuple.Item1;
            int rowCount = _tuple.Item2;
            if (lbAnnouncements.Items.Count > 0)
            {
                lbAnnouncements.Items.Clear();
            }
            lbAnnouncements.Items.Add(Resources.LB_Create_New);
            for (int i = 0; i < rowCount; i++)
            {
                DateTime dbEDate = DateTime.Parse(_announcementData[5][i]);
                if (_cDate > dbEDate)
                    lbAnnouncements.Items.Add("(*) " + _announcementData[2][i]);
                else
                    lbAnnouncements.Items.Add(_announcementData[2][i]);
            }

        }
    }
}
