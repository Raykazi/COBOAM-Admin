using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Activity : UserControl
    {

        Tuple<List<string>[], int> _tuple;
        public Activity()
        {
            InitializeComponent();
        }

        public void Load()
        {
            cbTypes.SelectedIndex = (int)Logs.All;
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            switch ((Logs)cbTypes.SelectedIndex)
            {
                default:
                    query = MySql.GetQuery(QueryIndex.Logs1);
                    break;
                case Logs.Security:
                    query = MySql.GetQuery(QueryIndex.Logs2, Logs.Security);
                    break;
                case Logs.Announcements:
                    query = MySql.GetQuery(QueryIndex.Logs2, Logs.Announcements);
                    break;
                case Logs.Devotion:
                    query = MySql.GetQuery(QueryIndex.Logs2, Logs.Devotion);
                    break;
                case Logs.Greetings:
                    query = MySql.GetQuery(QueryIndex.Logs2, Logs.Greetings);
                    break;
                case Logs.Users:
                    query = MySql.GetQuery(QueryIndex.Logs2, Logs.Users);
                    break;
                case Logs.Sermons:
                    query = MySql.GetQuery(QueryIndex.Logs2, Logs.Sermons);
                    break;
                case Logs.Testimony:
                    query = MySql.GetQuery(QueryIndex.Logs2, Logs.Testimony);
                    break;
            }
            _tuple = Program.MySql.ExecuteReader(query);
            List<string>[] logs = _tuple.Item1;
            int rowCount = _tuple.Item2;
            rtbLogs.Text = string.Empty;
            for (int i = 0; i < rowCount; i++)
            {
                if (rowCount == 0)
                    rtbLogs.AppendText("No logs for this category");
                rtbLogs.AppendText(string.Format("{0}\t{1}\t{2}\r\n", logs[2][i], logs[3][i], logs[4][i]));
            }
            _tuple = null;

        }
    }
}
