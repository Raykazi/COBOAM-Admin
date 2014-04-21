using System;
using System.Collections.Generic;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Activity : UserControl
    {

        Tuple<List<string>[], int> _tuple;
        readonly List<DBItem> _list = new List<DBItem>();
        private DBItem cbi;

        public Activity()
        {
            InitializeComponent();
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            Logs type = (Logs)((DBItem) cbTypes.SelectedItem).Value;
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
            _tuple = Program.MySql.ExecuteReader(query);
            List<string>[] logs = _tuple.Item1;
            int rowCount = _tuple.Item2;
            rtbLogs.Text = string.Empty;
            for (int i = 0; i < rowCount; i++)
            {
                if (rowCount == 0)
                    rtbLogs.AppendText(Resource.Format(Resources.Activity_No_Logs, cbTypes.SelectedText));
                rtbLogs.AppendText(string.Format("{0}\t{1}\t{2}\r\n", logs[2][i], logs[3][i], logs[4][i]));
            }
            _tuple = null;

        }

        public void Activity_Load(object sender = null, EventArgs e = null)
        {
            cbTypes.DisplayMember = "Text";
            cbTypes.ValueMember = "Value";
            if (_list.Capacity == 0)
            {
                cbi = new DBItem ("All",0);
                _list.Add(cbi);
                cbi = new DBItem ("Announcment",2);
                _list.Add(cbi);
                cbi = new DBItem ("Devotion",3);
                _list.Add(cbi);
                cbi = new DBItem ("Greetings",4);
                _list.Add(cbi);
                cbi = new DBItem ("Security",1);
                _list.Add(cbi);
                cbi = new DBItem ("Sermons",6);
                _list.Add(cbi);
                cbi = new DBItem ("Testimony",7);
                _list.Add(cbi);
                cbi = new DBItem ("Users",5);
                _list.Add(cbi);
            }
            cbTypes.DataSource = _list;
            cbTypes.SelectedItem = Logs.All;
        }
    }
}
