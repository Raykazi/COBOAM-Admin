using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;

namespace COBOAM_Admin.UserControls
{
    public partial class WebAdminControl : UserControl
    {
        Tuple<List<string>[], int> _tuple;
        List<string>[] _devotionData;
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
            Activity.LoadLogs();
        }

        private void LoadDevotions()
        {
            cbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            _tuple = Program.MySql.ExecuteReader(Queries.ToString(QueryIndex.Devotion1));
            _devotionData = _tuple.Item1;
            int rowCount = _tuple.Item2;
            if (lbPrevDev.Items.Count > 0)
            {
                lbPrevDev.Items.Clear();
            }
            lbPrevDev.Items.Add("Create new...");
            nudYear.Maximum = DateTime.Now.Year + 5;
            for (int i = 0; i < rowCount; i++)
            {
                if (_devotionData[1][i].Length == 1)
                    _devotionData[1][i] = _devotionData[1][i].Insert(0, "0");
                lbPrevDev.Items.Add(String.Format("{0}/{1}", _devotionData[1][i], _devotionData[2][i]));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbQuote.Text == string.Empty)
            {
                MessageBox.Show("Please enter a quote.", "Error");
                return;
            }
            else if (tbScripture.Text == string.Empty)
            {
                MessageBox.Show("Please enter a scripture.", "Error");
                return;
            }
            else if (tbText.Text == string.Empty)
            {
                MessageBox.Show("Please enter text.", "Error");
                return;
            }
            int index = lbPrevDev.SelectedIndex;
            int result = -1;
            string query = string.Empty;
            int Month = cbMonth.SelectedIndex + 1;
            int Year = (int)nudYear.Value;
            string Quote = HttpUtility.HtmlEncode(tbQuote.Text);
            string Scripture = HttpUtility.HtmlEncode(tbScripture.Text);
            string Text = HttpUtility.HtmlEncode(tbText.Text);
            if (index == 0)
            {
                query = MySql.GetQuery(QueryIndex.Devotion2, Month, Year, Quote, Scripture, Text);
                result = Program.MySql.ExecuteNonQuery(query);
                query = MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has created the Devotion for " + Month + "/" + Year + ".");
                if (result == 1)
                {
                    result = Program.MySql.ExecuteNonQuery(query);
                    if (result == 1)
                    {
                        MessageBox.Show("Devotion added for " + Month + "/" + Year);
                    }
                }
            }
            else
            {
                index -= 1;
                int ID = Convert.ToInt32(_devotionData[0][index]);
                query = MySql.GetQuery(QueryIndex.Devotion3, ID, Quote, Scripture, Text, Month, Year);
                result = Program.MySql.ExecuteNonQuery(query);
                query = MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has updated the Devotion for " + Month + "/" + Year + ".");
                if (result == 1)
                {
                    result = Program.MySql.ExecuteNonQuery(query);
                    if (result == 1)
                    {
                        MessageBox.Show("Devotion updated for " + Month + "/" + Year);
                    }
                }
            }
            LoadLogs();
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
            int index = lbPrevDev.SelectedIndex;
            switch (index)
            {
                case 0:
                    tbQuote.Text = String.Empty;
                    tbScripture.Text = String.Empty;
                    tbText.Text = String.Empty;
                    cbMonth.SelectedIndex = -1;
                    nudYear.Value = DateTime.Now.Year;
                    break;

                default:
                    index -= 1;
                    tbQuote.Text = HttpUtility.HtmlDecode(_devotionData[3][index]);
                    tbScripture.Text = HttpUtility.HtmlDecode(_devotionData[4][index]);
                    tbText.Text = HttpUtility.HtmlDecode(_devotionData[5][index]);
                    cbMonth.SelectedIndex = Convert.ToInt32(_devotionData[1][index]) - 1;
                    nudYear.Value = Convert.ToInt32(_devotionData[2][index]);
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
