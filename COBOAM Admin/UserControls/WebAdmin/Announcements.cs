using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Announcements : UserControl
    {
        Tuple<List<string>[], int> _tuple;
        List<string>[] _announcementData;
        private DateTime _cDate = DateTime.Now;
        public Announcements()
        {
            InitializeComponent();
        }

        public void Load()
        {
            _tuple = Program.MySql.ExecuteReader(Queries.ToString(QueryIndex.Announcement1));
            _announcementData = _tuple.Item1;
            int rowCount = _tuple.Item2;
            if (lbAnnouncements.Items.Count > 0)
            {
                lbAnnouncements.Items.Clear();
            }
            lbAnnouncements.Items.Add(Resources.Listbox_Create_New);
            for (int i = 0; i < rowCount; i++)
            {
                DateTime dbEDate = DateTime.Parse(_announcementData[5][i]);
                if (_cDate > dbEDate)
                    lbAnnouncements.Items.Add("(*) " + _announcementData[2][i]);
                else
                    lbAnnouncements.Items.Add(_announcementData[2][i]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == String.Empty)
            {
                MessageBox.Show("Please enter a title.", Resources.MB_Caption_Error);
                return;
            }
            if (tbText.Text == String.Empty)
            {
                MessageBox.Show("Please enter text for the announcement.", Resources.MB_Caption_Error);
                return;
            }
            int index = lbAnnouncements.SelectedIndex;
            int result = -1;
            string query;
            string title = HttpUtility.HtmlEncode(tbTitle.Text);
            string text = HttpUtility.HtmlEncode(tbText.Text);
            DateTime Start = dtpStart.Value;
            DateTime End = dtpStop.Value;
            if (index == 0)
            {
                query = MySql.GetQuery(QueryIndex.Announcement2, title, text, Start, End);
                result = Program.MySql.ExecuteNonQuery(query);
                if(result != 1) return;
                query = MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has created the Announcement for \"" + title + "\".");
                result = Program.MySql.ExecuteNonQuery(query);
                if (result == 1)
                {
                    MessageBox.Show("Announcement \"" + title + "\" created.");
                }
            }
            else
            {
                index -= 1;
                int ID = Convert.ToInt32(_announcementData[0][index]);
                query = MySql.GetQuery(QueryIndex.Announcement3, title, text, Start, End, ID);
                result = Program.MySql.ExecuteNonQuery(query);
                if (result != 1) return;
                query = MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has updated the Announcement \"" + title + "\".");
                result = Program.MySql.ExecuteNonQuery(query);
                if (result == 1)
                {
                    MessageBox.Show("Announcement \"" + title + "\" updated.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete Announcement \"" + tbTitle + "\"?", Resources.MB_Confirmation, MessageBoxButtons.YesNo);
            if (dialogresult != DialogResult.Yes) return;
            string query = MySql.GetQuery(QueryIndex.Announcement4, _announcementData[0][lbAnnouncements.SelectedIndex-1]);
            var result = Program.MySql.ExecuteNonQuery(query);
            if (result == -1) return;
            query = MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has deleted the Announcement for  \"" + tbTitle + "\".");
            result = Program.MySql.ExecuteNonQuery(query);
            if (result != 1) return;
            //MessageBox.Show("Devotion deleted for " + month + "/" + year);
            Load();
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
                case 1:
                    index -= 1;
                    tbTitle.Text = HttpUtility.HtmlDecode(_announcementData[2][index]);
                    tbText.Text = HttpUtility.HtmlDecode(_announcementData[3][index]);
                    dtpStart.Value = DateTime.Parse(_announcementData[4][index]);
                    dtpStop.Value = DateTime.Parse(_announcementData[5][index]);
                    break;
            }
        }
    }
}
