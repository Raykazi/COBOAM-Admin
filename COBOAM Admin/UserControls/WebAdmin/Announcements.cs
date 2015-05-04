using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Caching;
using System.Web;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Announcements : UserControl
    {
        Tuple<List<string>[], int> _tuple = new Tuple<List<string>[], int>(null, -1);
        List<string>[] _dbData;
        private MemoryCache _cache;
        private bool _refreshCache;
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
            string title = HttpUtility.HtmlEncode(tbTitle.Text);
            string text = HttpUtility.HtmlEncode(tbText.Text);
            string start = dtpStart.Value.Year + "-" + dtpStart.Value.Month + "-" + dtpStart.Value.Day;
            string end = dtpStop.Value.Year + "-" + dtpStop.Value.Month + "-" + dtpStop.Value.Day;
            int order = (int) nudOrder.Value;
            if (index <= 0)
            {
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Announcement2, title, text, start, end, order);
                if (result != 1) return;
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 3, Program.uName + " has created the Announcement for \"" + title + "\".");
                if (result == 1)
                {
                    MessageBox.Show(String.Format(Resources.Announcements_Created,title));
                }
            }
            else
            {
                index -= 1;
                int ID = Convert.ToInt32(_dbData[0][index]);
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Announcement3, title, text, start, end, order, ID);
                if (result != 1) return;
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 3, Program.uName + " has updated the Announcement \"" + title + "\".");
                if (result == 1)
                {
                    MessageBox.Show(String.Format(Resources.Announcements_Updated,title));
                }
            }
            _refreshCache = true;
            Announcements_Load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(String.Format(Resources.MB_Announcements_Delete, tbTitle.Text), Resources.MB_Confirmation, MessageBoxButtons.YesNo);
            if (dialogresult != DialogResult.Yes) return;
            var result = Program.MySql.ExecuteNonQuery(QueryIndex.Announcement4, _dbData[0][lbAnnouncements.SelectedIndex - 1]);
            if (result == -1) return;
            result = Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 3, Program.uName + " has deleted the Announcement for  \"" + tbTitle.Text + "\".");
            if (result != 1) return;
            _refreshCache = true;
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
                    nudOrder.Value = Decimal.MinValue;
                    break;
                default:
                    index -= 1;
                    tbTitle.Text = HttpUtility.HtmlDecode(_dbData[2][index]);
                    tbText.Text = HttpUtility.HtmlDecode(_dbData[3][index]);
                    dtpStart.Value = DateTime.Parse(_dbData[4][index]);
                    dtpStop.Value = DateTime.Parse(_dbData[5][index]);
                    nudOrder.Value = Convert.ToDecimal(_dbData[1][index]);
                    break;
            }
        }

        public void Announcements_Load(object sender = null, EventArgs e = null)
        {
            if (_cache != null && !_refreshCache)
            {
                _dbData = _cache.Get("Announcement") as List<string>[];
            }
            else
            {
                _dbData = Program.MySql.ExecuteReader(QueryIndex.Announcement1);
                _refreshCache = false;
                if (lbAnnouncements.Items.Count > 0)
                {
                    lbAnnouncements.Items.Clear();
                }
                lbAnnouncements.Items.Add(Resources.LB_Create_New);
                for (int i = 0; i < _dbData[0].Count; i++)
                {
                    DateTime dbEDate = DateTime.Parse(_dbData[5][i]);
                    if (_cDate > dbEDate)
                        lbAnnouncements.Items.Add("(*) " + _dbData[2][i]);
                    else
                        lbAnnouncements.Items.Add(_dbData[2][i]);
                }
                _cache = new MemoryCache("Primary")
                {
                    {"Announcement", _dbData, (DateTimeOffset.Now + TimeSpan.FromMinutes(5))}
                };
                
            }

        }
    }
}
