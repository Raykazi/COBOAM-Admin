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
        List<string>[] _dbData;
        private readonly BindingSource _source = new BindingSource();
        public Devotion()
        {
            InitializeComponent();
            _source.DataSource = typeof(DBItem);
        }

        private void DbLoad()
        {
            _tuple = Program.MySql.ExecuteReader(Queries.ToString(QueryIndex.Devotion1));
            _dbData = _tuple.Item1;
            int rowCount = _tuple.Item2;
            if (_source.Count > 0)
            {
                _source.Clear();
                lbDevotions.DataSource = _source;
            }
            _source.Add(new DBItem(Resources.LB_Create_New, -1));
            for (int i = 0; i < rowCount; i++)
            {
                if (_dbData[1][i].Length == 1)
                    _dbData[1][i] = _dbData[1][i].Insert(0, "0");
                string name = String.Format("{0}/{1}", _dbData[1][i], _dbData[2][i]);
                _source.Add(new DBItem(name, _dbData[0][i]));
            }
            lbDevotions.DisplayMember = "Text";
            lbDevotions.ValueMember = "Value";
            lbDevotions.SelectedValue = -1;
        }

        public void Devotion_Load(object sender = null, EventArgs e = null)
        {
            List<DBItem> monthList = new List<DBItem>
            {
                new DBItem("January",1),
                new DBItem("February",2),
                new DBItem("March",3),
                new DBItem("April",4),
                new DBItem("May",5),
                new DBItem("June",6),
                new DBItem("July",7),
                new DBItem("August",8),
                new DBItem("September",9),
                new DBItem("October",10),
                new DBItem("November",11),
                new DBItem("December",12),
            };
            cbMonth.DataSource = monthList;
            cbMonth.DisplayMember = "Text";
            cbMonth.ValueMember = "Value";
            nudYear.Minimum = 2000;
            nudYear.Maximum = DateTime.Now.Year + 5;
            DbLoad();
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
            int index = Convert.ToInt32(((DBItem)lbDevotions.SelectedItem).Value.ToString());
            int result;
            string query;
            int month = Convert.ToInt32(((DBItem)cbMonth.SelectedItem).Value.ToString());
            int year = (int)nudYear.Value;
            string quote = HttpUtility.HtmlEncode(tbQuote.Text);
            string scripture = HttpUtility.HtmlEncode(tbScripture.Text);
            string text = HttpUtility.HtmlEncode(tbText.Text);
            if (index == -1)
            {
                query = Classes.MySql.GetQuery(QueryIndex.Devotion2, month, year, quote, scripture, text);
                result = Program.MySql.ExecuteNonQuery(query);
                if (result != 1) return;
                query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has created the Devotion for " + month + "/" + year + ".");
                result = Program.MySql.ExecuteNonQuery(query);
                if (result == 1)
                {
                    MessageBox.Show(Resource.Format(Resources.Devotion_Added, month, year));
                }
            }
            else
            {
                index -= 1;
                int ID = Convert.ToInt32(_dbData[0][index]);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(Resource.Format(Resources.MB_Devotion_Delete, ((DBItem)cbMonth.SelectedItem).Text, nudYear.Value), Resources.MB_Confirmation, MessageBoxButtons.YesNo);
            if (dialogresult != DialogResult.Yes) return;
            int month = Convert.ToInt32(((DBItem)lbDevotions.SelectedValue).Value);
            int year = (int)nudYear.Value;
            string query = Classes.MySql.GetQuery(QueryIndex.Devotion4, month, year);
            var result = Program.MySql.ExecuteNonQuery(query);
            query = Classes.MySql.GetQuery(QueryIndex.Logs3, 3, DateTime.Now.ToString(), Program.uCIP, Program.uName + " has deleted the Devotion for " + month + "/" + year + ".");
            if (result == -1) return;
            result = Program.MySql.ExecuteNonQuery(query);
            if (result != 1) return;
            Devotion_Load();
            MessageBox.Show(Resource.Format(Resources.Devotion_Deleted, month, year));
        }

        private void lbDevotions_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbDevotions.SelectedValue == null) return;
            int value = Convert.ToInt32(((DBItem)(lbDevotions.SelectedItem)).Value.ToString());
            int dbIndex = -1;
            for (int i = 0; i < lbDevotions.Items.Count; i++)
            {
                int sValue = Convert.ToInt32(((DBItem)(lbDevotions.Items[i])).Value.ToString());
                if (sValue == value)
                {
                    dbIndex = (i - 1);
                }
            }
            switch (dbIndex)
            {
                case -1:
                    tbQuote.Text = String.Empty;
                    tbScripture.Text = String.Empty;
                    tbText.Text = String.Empty;
                    cbMonth.SelectedIndex = 0;
                    nudYear.Value = DateTime.Now.Year;
                    break;

                default:
                    tbQuote.Text = HttpUtility.HtmlDecode(_dbData[3][dbIndex]);
                    tbScripture.Text = HttpUtility.HtmlDecode(_dbData[4][dbIndex]);
                    tbText.Text = HttpUtility.HtmlDecode(_dbData[5][dbIndex]);
                    cbMonth.SelectedValue = Convert.ToInt32(_dbData[1][dbIndex]);
                    nudYear.Value = Convert.ToInt32(_dbData[2][dbIndex]);
                    break;
            }
        }
    }
}
