using System.Diagnostics;
using System.Runtime.Caching;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Members : TUserControl
    {
        private List<string>[] _dbData;
        private readonly BindingSource _source = new BindingSource();
        private readonly BindingSource _fSource = new BindingSource();
        private bool _isFiltering;
        private bool _enabled;
        private bool _creating;
        private Email _email;


        public Members()
        {
            InitializeComponent();
            _source.DataSource = typeof(DBItem);
            _fSource.DataSource = typeof(DBItem);
        }

        private void DbLoad(object prevSelected = null)
        {
            _dbData = Program.MySql.ExecuteReader(QueryIndex.Members1);
            if (_source.Count > 0)
            {
                _source.Clear();
                _fSource.Clear();
                lbMembers.DataSource = _source;
            }
            for (int i = 0; i < _dbData[0].Count; i++)
            {
                string name = string.Format("{0} {1}", _dbData[6][i], _dbData[5][i]);
                _source.Add(new DBItem(name, _dbData[0][i]));
                _fSource.Add(new DBItem(name, _dbData[0][i]));
            }
            _source.Insert(0, new DBItem(Resources.LB_Create_New, 0));
            lbMembers.DataSource = _source;
            lbMembers.DisplayMember = "Text";
            lbMembers.ValueMember = "Value";
            lbMembers.SelectedValue = prevSelected ?? -1;

        }
        public void Members_Load(object sender = null, EventArgs e = null)
        {
            List<DBItem> privelegeList = new List<DBItem>
            {
                new DBItem("Normal Member",0),
                new DBItem("Babes In Christ",1),
                new DBItem("Online Bible Study",2),
                new DBItem("Level 3",3),
                new DBItem("Managers",4),
                new DBItem("Admin",5),
                new DBItem("Sys Admin",6),
            };
            cbAL.DataSource = privelegeList;
            cbAL.DisplayMember = "Text";
            cbAL.ValueMember = "Value";
            cbAL.SelectedValue = 0;
            DbLoad();
        }

        private void lbMembers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbMembers.SelectedValue == null) return;
            int value = Convert.ToInt32(((DBItem)(lbMembers.SelectedItem)).Value.ToString());
            int dbIndex = -1;
            if (!_isFiltering)
                for (int i = 0; i < lbMembers.Items.Count; i++)
                {
                    int sValue = Convert.ToInt32(((DBItem)(lbMembers.Items[i])).Value.ToString());
                    if (sValue == value)
                    {
                        dbIndex = (i - 1);
                    }
                }
            else
            {
                for (int i = 0; i < _dbData[0].Count; i++)
                {
                    if (value.ToString() == _dbData[0][i])
                    {
                        dbIndex = i;
                    }
                }
            }
            tbEmail.BackColor = SystemColors.Window;
            lblSEmail.Text = "";
            switch (dbIndex)
            {
                case -1:
                    _creating = true;
                    tbEmail.Text = string.Empty;
                    tbName.Text = string.Empty;
                    tbUN.Text = string.Empty;
                    cbAL.SelectedIndex = 0;
                    btnSC.Enabled = false;
                    btnSave.Text = "Sign Up";
                    if (!_enabled)
                    {
                        tbEmail.Enabled = tbName.Enabled = cbAL.Enabled = true;
                    }
                    break;
                default:
                    _creating = false;
                    tbEmail.Text = _dbData[7][dbIndex];
                    tbName.Text = string.Concat(_dbData[5][dbIndex], " ", _dbData[6][dbIndex]);
                    tbUN.Text = _dbData[1][dbIndex];
                    cbAL.SelectedValue = Convert.ToInt32(_dbData[4][dbIndex]);
                    btnSave.Text = "Update";
                    _enabled = _dbData[11][dbIndex] != "1";
                    if (_enabled)
                    {
                        tbEmail.Enabled = tbName.Enabled = cbAL.Enabled = true;
                        btnSC.Text = "Disable Account";
                    }
                    else
                    {
                        tbEmail.Enabled = tbName.Enabled = cbAL.Enabled = false;
                        btnSC.Text = "Enable Account";
                    }
                    btnSC.Enabled = true;
                    break;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbEmail.BackColor != Color.GreenYellow && lbMembers.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please correct the email.", Resources.MB_Caption_Error);
            }
            int value = Convert.ToInt32(((DBItem)lbMembers.SelectedItem).Value.ToString());
            string userName = tbUN.Text;
            string email = tbEmail.Text;
            string[] name = tbName.Text.Split(' ');
            int level = Convert.ToInt32(((DBItem)cbAL.SelectedItem).Value.ToString());
            switch (value)
            {
                case -1:
                    string password;
                    using (WebClient wc = new WebClient())
                    {
                        password = wc.DownloadString("http://channelofblessings.com/includes/crypt.php?u=" + userName + "&p=12345");
                    }
                    if (Program.MySql.ExecuteNonQuery(QueryIndex.Members2, userName, password, email, name[0], name[1], level) != 1) return;
                    _email = new Email(email, "Channel Of Blessings Registration", String.Format(Resources.New_Member_Email, tbName.Text, userName, "coboam"));
                    _email.Send();
                    if (Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 5, Program.uName + " created " + userName + "\'s account.") == 1)
                    {
                        MessageBox.Show(_email.Status
                            ? String.Format(Resources.Member_Created + " Registration email sent.", userName)
                            : String.Format(Resources.Member_Created + " Registration email NOT sent.", userName));
                    }
                    break;

                default:
                    if (Program.MySql.ExecuteNonQuery(QueryIndex.Members3, userName, email, name[0], name[1], level, value) != 1) return;
                    if (Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 5, Program.uName + " updated the information of " + userName + ".") == 1)
                    {
                        MessageBox.Show(String.Format(Resources.Member_Updated, userName));
                    }
                    break;

            }
            DbLoad(value == -1 ? null : lbMembers.SelectedValue);
        }
        private void tbNameFilter_TextChanged(object sender, EventArgs e)
        {
            string lower = tbNameFilter.Text.ToLower();
            BindingSource filterSource = new BindingSource { DataSource = typeof(DBItem) };
            lbMembers.DataSource = null;
            lbMembers.BeginUpdate();
            if (string.IsNullOrEmpty(lower))
            {
                _isFiltering = false;
                DbLoad();
            }
            else
            {
                _isFiltering = true;
                lbMembers.Items.Clear();
                foreach (DBItem dBItem in _fSource)
                {
                    if (dBItem.Text.ToLower().Contains(lower))
                    {
                        filterSource.Add(new DBItem(dBItem.Text, dBItem.Value));
                    }
                }
                lbMembers.DataSource = filterSource;
                lbMembers.DisplayMember = "Text";
                lbMembers.ValueMember = "Value";
            }
            lbMembers.EndUpdate();
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            string userName = tbUN.Text;
            int ID = Convert.ToInt32(((DBItem)lbMembers.SelectedItem).Value.ToString());
            int value = _enabled ? 1 : 0;
            string text = value == 1 ? "disabled" : "enabled";
            if (Program.MySql.ExecuteNonQuery(QueryIndex.Members4, ID, value) != 1) return;
            if (Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 5, Program.uName + " has " + text + " " + userName + "\'s account.") != 1) return;
            MessageBox.Show(String.Format(Resources.Member_SC, tbUN.Text, text) + Program.uCIP);
            DbLoad(lbMembers.SelectedValue);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == string.Empty)
            {
                MessageBox.Show("Pleas enter a email", Resources.MB_Caption_Error);
                return;
            }
            string email = tbEmail.Text;
            bool validEmail = RegexUtilities.IsValidEmail(email);
            if (!validEmail)
            {
                lblSEmail.Text = "Invalid Email";
                tbEmail.BackColor = Color.IndianRed;
                return;
            }
            int result = Convert.ToInt32(Program.MySql.ExecuteScalar(QueryIndex.Members6, email));
            if (result != 0)
            {
                lblSEmail.Text = "Email already in use.";
                tbEmail.BackColor = Color.IndianRed;
                return;
            }
            lblSEmail.Text = string.Empty;
            tbEmail.BackColor = Color.GreenYellow;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a name.", Resources.MB_Caption_Error);
                return;
            }
            if (!tbName.Text.Contains(' '))
            {
                MessageBox.Show("Please enter a first and last name.", Resources.MB_Caption_Error);
                return;
            }
            if (!_creating)
            {
                return;
            }
            string[] name = tbName.Text.Split(' ');
            var fName = name[0].ToCharArray();
            bool unique = false;
            int number = 0;
            while (!unique)
            {
                string username = number == 0 ? string.Concat(fName[0], name[1]).ToLower() : string.Concat(fName[0], name[1], number).ToLower();
                var result = Program.MySql.ExecuteScalar(QueryIndex.Members5, username);
                if (Convert.ToInt32(result) != 0)
                {
                    number += 1;
                }
                else
                {
                    tbUN.Text = username;
                    unique = true;
                    break;
                }
            }
        }

    }
}