using System;
using System.Collections.Generic;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Activity : UserControl
    {
        private List<string>[] _dbData;

        public Activity()
        {
            InitializeComponent();
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            Logs type = (Logs)((DBItem)cbTypes.SelectedItem).Value;
            switch (type)
            {
                default:
                    query = Classes.MySql.GetQuery(QueryIndex.Logs1);
                    break;
                case Logs.Announcements:
                    query = Classes.MySql.GetQuery(QueryIndex.Logs2, (int)Logs.Announcements);
                    break;
                case Logs.Devotion:
                    query = Classes.MySql.GetQuery(QueryIndex.Logs2, (int)Logs.Devotion);
                    break;
                case Logs.Greetings:
                    query = Classes.MySql.GetQuery(QueryIndex.Logs2, (int)Logs.Greetings);
                    break;
                case Logs.Security:
                    query = Classes.MySql.GetQuery(QueryIndex.Logs2, (int)Logs.Security);
                    break;
                case Logs.Sermons:
                    query = Classes.MySql.GetQuery(QueryIndex.Logs2, (int)Logs.Sermons);
                    break;
                case Logs.Testimony:
                    query = Classes.MySql.GetQuery(QueryIndex.Logs2, (int)Logs.Testimony);
                    break;
                case Logs.Users:
                    query = Classes.MySql.GetQuery(QueryIndex.Logs2, (int)Logs.Users);
                    break;
            }
            _dbData = Program.MySql.ExecuteReader(query);
            int rowCount = _dbData[0].Count;
            rtbLogs.Text = string.Empty;
            for (int i = 0; i < rowCount; i++)
            {
                if (rowCount == 0)
                    rtbLogs.AppendText(String.Format(Resources.Activity_No_Logs, cbTypes.SelectedText));
                rtbLogs.AppendText(string.Format("{0}\t{1}\t{2}\r\n", _dbData[2][i], _dbData[3][i], _dbData[4][i]));
            }

        }

        public void Activity_Load(object sender = null, EventArgs e = null)
        {
            DBItem cbi;
            List<DBItem> list = new List<DBItem>();
            cbTypes.DisplayMember = "Text";
            cbTypes.ValueMember = "Value";
            if (list.Capacity == 0)
            {
                cbi = new DBItem("All", 0);
                list.Add(cbi);
                cbi = new DBItem("Announcment", 2);
                list.Add(cbi);
                cbi = new DBItem("Devotion", 3);
                list.Add(cbi);
                cbi = new DBItem("Greetings", 4);
                list.Add(cbi);
                cbi = new DBItem("Security", 1);
                list.Add(cbi);
                cbi = new DBItem("Sermons", 6);
                list.Add(cbi);
                cbi = new DBItem("Testimony", 7);
                list.Add(cbi);
                cbi = new DBItem("Users", 5);
                list.Add(cbi);
            }
            cbTypes.DataSource = list;
            cbTypes.SelectedItem = Logs.All;
        }
    }
}
