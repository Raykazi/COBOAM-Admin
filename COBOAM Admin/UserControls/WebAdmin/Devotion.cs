using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Web;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Devotion : UserControl
    {
        Tuple<List<string>[], int> _tuple;
        List<string>[] _devotionData;
        public Devotion()
        {
            InitializeComponent();
        }
        public void Load()
        {
            if (cbMonth.Items.Count != 12)
            {
                cbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
                nudYear.Minimum = DateTime.Now.Year;
                nudYear.Maximum = DateTime.Now.Year + 5;
            }
            _tuple = Program.MySql.ExecuteReader(Queries.ToString(QueryIndex.Devotion1));
            _devotionData = _tuple.Item1;
            int rowCount = _tuple.Item2;
            if (lbDevotions.Items.Count > 0)
            {
                lbDevotions.Items.Clear();
            }
            lbDevotions.Items.Add(Resources.LB_Create_New);
            for (int i = 0; i < rowCount; i++)
            {
                if (_devotionData[1][i].Length == 1)
                    _devotionData[1][i] = _devotionData[1][i].Insert(0, "0");
                lbDevotions.Items.Add(String.Format("{0}/{1}", _devotionData[1][i], _devotionData[2][i]));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbQuote.Text == string.Empty)
            {
                MessageBox.Show(Resources.Devotion_Need_Quote, Resources.MB_Caption_Error);
                return;
            }
            if (tbScripture.Text == string.Empty)
            {
                MessageBox.Show(Resources.Devotion_Need_Scripture, Resources.MB_Caption_Error);
                return;
            }
            if (tbText.Text == string.Empty)
            {
                MessageBox.Show(Resources.General_Need_Text, Resources.MB_Caption_Error);
                return;
            }
            int index = lbDevotions.SelectedIndex;
            int result;
            string query;
            int month = cbMonth.SelectedIndex + 1;
            int year = (int)nudYear.Value;
            string quote = HttpUtility.HtmlEncode(tbQuote.Text);
            string scripture = HttpUtility.HtmlEncode(tbScripture.Text);
            string text = HttpUtility.HtmlEncode(tbText.Text);
            if (index == 0)
            {
                query = Classes.MySql.GetQuery(QueryIndex.Devotion2, month, year, quote, scripture, text);
                result = Program.MySql.ExecuteNonQuery(query);
                if (result != 1) return;
                query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has created the Devotion for " + month + "/" + year + ".");
                result = Program.MySql.ExecuteNonQuery(query);
                if (result == 1)
                {
                    MessageBox.Show(Resource.Format(Resources.Devotion_Added, month,year));
                }
            }
            else
            {
                index -= 1;
                int ID = Convert.ToInt32(_devotionData[0][index]);
                query = Classes.MySql.GetQuery(QueryIndex.Devotion3, ID, quote, scripture, text, month, year);
                result = Program.MySql.ExecuteNonQuery(query); 
                if (result != 1) return;
                query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has updated the Devotion for " + month + "/" + year + ".");
                result = Program.MySql.ExecuteNonQuery(query);
                if (result == 1)
                {
                    MessageBox.Show(Resource.Format(Resources.Devotion_Updated, month, year));
                }
            }

        }

        private void lbPrevDev_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbDevotions.SelectedIndex;
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
            DialogResult dialogresult =
                MessageBox.Show(
                    "Are you sure you want to delete Devotion " + cbMonth.SelectedItem + " " + nudYear.Value,
                    Resources.MB_Confirmation, MessageBoxButtons.YesNo);
            if (dialogresult != DialogResult.Yes) return;
            int month = cbMonth.SelectedIndex + 1;
            int year = (int)nudYear.Value;
            string query = Classes.MySql.GetQuery(QueryIndex.Devotion4, month, year);
            var result = Program.MySql.ExecuteNonQuery(query);
            query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has deleted the Devotion for " + month + "/" + year + ".");
            if (result == -1) return;
            result = Program.MySql.ExecuteNonQuery(query);
            if (result != 1) return;
            Load();
            MessageBox.Show(Resource.Format(Resources.Devotion_Deleted, month, year));
        }
    }
}
