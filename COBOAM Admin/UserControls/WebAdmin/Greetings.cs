using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Web;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Greetings : UserControl
    {
        List<string>[] _dbData;
        private MemoryCache _cache;
        private bool _refreshCache;
        public Greetings()
        {
            InitializeComponent();
        }

        public void LoadGreeting()
        {
            if (_cache != null && !_refreshCache)
            {
                _dbData = _cache.Get("Greetings") as List<string>[];
            }
            else
            {
                _dbData = Program.MySql.ExecuteReader(QueryIndex.Greetings1);
                _refreshCache = false;
                if (lbGreetings.Items.Count > 0)
                {
                    lbGreetings.Items.Clear();
                }
                lbGreetings.Items.Add(Resources.LB_Create_New);
                for (int i = 0; i < _dbData[0].Count; i++)
                {
                    lbGreetings.Items.Add(_dbData[2][i]);
                }
                _cache = new MemoryCache("Primary")
                {
                    {"Greetings", _dbData, (DateTimeOffset.Now + TimeSpan.FromMinutes(5))}
                };
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == String.Empty)
            {
                MessageBox.Show("Please enter a title.", Resources.MB_Caption_Error);
                return;
            }
            if (tbPart1.Text == String.Empty)
            {
                MessageBox.Show("Please enter text for Part 1.", Resources.MB_Caption_Error);
                return;
            }
            if (tbPart2.Text == String.Empty)
            {
                MessageBox.Show("Please enter text for Part 2.", Resources.MB_Caption_Error);
                return;
            }
            int index = lbGreetings.SelectedIndex;
            int result = -1;
            string title = HttpUtility.HtmlEncode(tbTitle.Text);
            string part1 = HttpUtility.HtmlEncode(tbPart1.Text);
            string part2 = HttpUtility.HtmlEncode(tbPart2.Text);
            int current = cbCurrent.Checked ? 1 : 0;
            if (current == 1)
            {
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Greetings2);
            }
            if (index == 0)
            {
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Greetings3, current, title, part1, part2);
                if (result != 1) return;
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 3, Program.uName + " has created the Greeting \"" + title + "\".");
                if (result == 1)
                {
                    MessageBox.Show("Greeting \"" + title + "\" added.");
                }
            }
            else
            {
                index -= 1;
                int ID = Convert.ToInt32(_dbData[0][index]);
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Greetings4, current, title, part1, part2, ID);
                if (result != 1) return;
                result = Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 3, Program.uName + " has updated the Greeting \"" + title + "\".");
                if (result == 1)
                {
                    MessageBox.Show("Greeting \"" + title + "\" updated.");
                }
            }
            LoadGreeting();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string title = lblTitle.Text;
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete \"" + title + "\"", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogresult != DialogResult.Yes) return;
            var ID = _dbData[0][lbGreetings.SelectedIndex - 1];
            var result = Program.MySql.ExecuteNonQuery(QueryIndex.Greetings5, ID);
            if (result == -1) return;
            result = Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 3, Program.uName + " has deleted the Greeting \"" + title + "\".");
            if (result != 1) return;
            LoadGreeting();
            MessageBox.Show("Greeting \"" + title + "\".");
        }

        private void lbGreetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbGreetings.SelectedIndex;
            switch (index)
            {
                case 0:
                    tbTitle.Text = String.Empty;
                    tbPart1.Text = String.Empty;
                    tbPart2.Text = String.Empty;
                    cbCurrent.Checked = false;
                    break;
                default:
                    index -= 1;
                    cbCurrent.Checked = _dbData[1][index] == "1" ? true : false;
                    tbTitle.Text = HttpUtility.HtmlDecode(_dbData[2][index]);
                    tbPart1.Text = HttpUtility.HtmlDecode(_dbData[3][index]);
                    tbPart2.Text = HttpUtility.HtmlDecode(_dbData[4][index]);
                    break;

            }
        }

    }
}
