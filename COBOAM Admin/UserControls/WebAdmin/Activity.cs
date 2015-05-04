using System;
using System.Collections.Generic;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;
using System.Runtime.Caching;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Activity : UserControl
    {
        private List<string>[] _dbData;
        private MemoryCache _aCache;

        public Activity()
        {
            InitializeComponent();
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_aCache != null && (_aCache.Get("Activity|" + _aCache.Get("Activity")) != null))
            {
                _dbData = _aCache.Get("Activity") as List<string>[];
            }
            else
            {
                Logs type = (Logs)((DBItem)cbTypes.SelectedItem).Value;
                switch (type)
                {
                    default:
                        _dbData = Program.MySql.ExecuteReader(QueryIndex.Logs1);
                        break;
                    case Logs.Announcements:
                    case Logs.Devotion:
                    case Logs.Greetings:
                    case Logs.Security:
                    case Logs.Sermons:
                    case Logs.Testimony:
                    case Logs.Users:
                        _dbData = Program.MySql.ExecuteReader(QueryIndex.Logs2, (int)type);
                        break;
                }
                _aCache = new MemoryCache("Primary")
                {
                    
                    {"Activity|"+cbTypes.SelectedItem, _dbData, (DateTimeOffset.Now + TimeSpan.FromMinutes(5))}
                };
            }
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
