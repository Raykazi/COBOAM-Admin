using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace COBOAM_Admin
{
    public partial class FrmLogin : Form
    {
        private readonly Splash _splash;

        public FrmLogin(Splash splash)
        {
            InitializeComponent();
            _splash = splash;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _splash.Status = @"Logging In.";
            string lUN = tbUsername.Text.ToLower();
            string lPW = tbPassword.Text.ToLower();
            lPW = Encryption.GetPassword(lPW, lUN);

            if (HandleLogin(MySql.GetQuery(QueryIndex.Login2, lUN, lPW)) == 1)
            {
                _splash.LoginStatus = true;
                _splash.Status = @"Success. Welcome " + lUN + ".";
                Close();
            }
            else
            {
                _splash.LoginStatus = false;
                _splash.Status = @"Log in failed. Please Try again.";
                tbUsername.Text = "";
                tbPassword.Text = "";
                tbUsername.Focus();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _splash.LoginStatus = false;
            Application.Exit();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private int HandleLogin(string query)
        {
            Tuple<List<string>[], int> tuple = Program.MySql.ExecuteReader(query);
            List<string>[] userInfo = tuple.Item1;
            int loginResult = tuple.Item2;
            string ipAddress;
            if (loginResult != 1) return loginResult;
            Program.uName = userInfo[1][0];
            Program.uLvl = Convert.ToInt32(userInfo[4][0]);
            Program.uFName = userInfo[5][0];
            Program.uEmail = userInfo[6][0];
            Program.uLIP = userInfo[9][0];
            using (WebClient wc = new WebClient())
            {
                ipAddress = wc.DownloadString("http://channelofblessings.com/includes/IP.php");
            }
            if (string.IsNullOrEmpty(ipAddress)) return loginResult;
            Program.uCIP = ipAddress;
            return loginResult;
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            tbUsername.SelectAll();
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.SelectAll();
        }
    }
}
