using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Greetings : UserControl
    {
        Tuple<List<string>[], int> _tuple;
        List<string>[] _greetingData;
        public Greetings()
        {
            InitializeComponent();
        }

        public void Load()
        {
            _tuple = Program.MySql.ExecuteReader(Queries.ToString(QueryIndex.Greetings1));
            _greetingData = _tuple.Item1;
            int rowCount = _tuple.Item2;
            if (lbGreetings.Items.Count > 0)
            {
                lbGreetings.Items.Clear();
            }
            lbGreetings.Items.Add(Resources.LB_Create_New);
            for (int i = 0; i < rowCount; i++)
            {
                lbGreetings.Items.Add(_greetingData[2][i]);
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
            string query;
            string title = HttpUtility.HtmlEncode(tbTitle.Text);
            string part1 = HttpUtility.HtmlEncode(tbPart1.Text);
            string part2 = HttpUtility.HtmlEncode(tbPart2.Text);
            int current = cbCurrent.Checked ? 1 : 0;
            if (current == 1)
            {
                query = Classes.MySql.GetQuery(QueryIndex.Greetings2);
                result = Program.MySql.ExecuteNonQuery(query);
            }
            if (index == 0)
            {
                query = Classes.MySql.GetQuery(QueryIndex.Greetings3, current, title, part1, part2);
                result = Program.MySql.ExecuteNonQuery(query);
                if (result != 1) return;
                query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has created the Greeting \"" + title+ "\".");
                result = Program.MySql.ExecuteNonQuery(query); 
                if (result == 1)
                {
                    MessageBox.Show("Greeting \"" + title+"\" added.");
                }
            }
            else
            {
                index -= 1;
                int ID = Convert.ToInt32(_greetingData[0][index]);
                query = Classes.MySql.GetQuery(QueryIndex.Greetings4, current, title, part1, part2, ID);
                result = Program.MySql.ExecuteNonQuery(query);
                if (result != 1) return;
                query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has updated the Greeting \"" + title+ "\".");
                result = Program.MySql.ExecuteNonQuery(query);
                if (result == 1)
                {
                    MessageBox.Show("Greeting \"" + title + "\" updated.");
                }
            }
            Load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string title = lblTitle.Text;
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete \"" + title + "\"","Confirmation", MessageBoxButtons.YesNo);
            if (dialogresult != DialogResult.Yes) return;
            var ID = _greetingData[0][lbGreetings.SelectedIndex - 1];
            string query = Classes.MySql.GetQuery(QueryIndex.Greetings5, ID);
            var result = Program.MySql.ExecuteNonQuery(query);
            query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has deleted the Greeting \"" + title + "\".");
            if (result == -1) return;
            result = Program.MySql.ExecuteNonQuery(query);
            if (result != 1) return;
            Load();
            MessageBox.Show("Greeting \"" +title+"\".");
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
                    cbCurrent.Checked = _greetingData[1][index] == "1" ? true : false;
                    tbTitle.Text = HttpUtility.HtmlDecode(_greetingData[2][index]);
                    tbPart1.Text = HttpUtility.HtmlDecode(_greetingData[3][index]);
                    tbPart2.Text = HttpUtility.HtmlDecode(_greetingData[4][index]);
                    break;

            }
        }

    }
}
