using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Members : UserControl
    {
        Tuple<List<string>[], int> _tuple;
        List<string>[] _DBData;
        public Members()
        {
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            _tuple = Program.MySql.ExecuteReader(Queries.ToString(QueryIndex.Login1));
            _DBData = _tuple.Item1;
            int rowCount = _tuple.Item2;
            if (lbMembers.Items.Count > 0)
            {
                lbMembers.Items.Clear();
            }
            lbMembers.Items.Add(Resources.LB_Create_New);
            for (int i = 0; i < rowCount; i++)
            {
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void tbNameFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
