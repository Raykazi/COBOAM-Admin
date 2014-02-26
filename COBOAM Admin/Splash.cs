using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace COBOAM_Admin
{
    public partial class Splash : Form
    {
        private readonly FrmLogin _frmLogin;
        private readonly string[] _config;

        public Splash(string[] config)
        {
            InitializeComponent();
            _frmLogin = new FrmLogin(this);
            _config = config;
        }

        public bool LoginStatus { get; set; }

        public string Status
        {
            set
            {
                lblStatus.Text = value;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void ShowLogin()
        {
            bool doLogin = true;
            while (doLogin)
            {
                doLogin = false;
                _frmLogin.ShowDialog();
                Close();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            BWLoad.RunWorkerAsync();
        }

        private void BWLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < _config.Length; i++)
            {
                if (_config[i].StartsWith("["))
                    continue;
                if (_config[i].StartsWith("Username"))
                    Program.mUN = _config[i].Substring(_config[i].IndexOf('=') + 1);
                if (_config[i].StartsWith("Password"))
                    Program.mPW = _config[i].Substring(_config[i].IndexOf('=') + 1);
                if (_config[i].StartsWith("Host"))
                    Program.mHost = _config[i].Substring(_config[i].IndexOf('=') + 1);
                if (_config[i].StartsWith("Port"))
                    Program.mPort = _config[i].Substring(_config[i].IndexOf('=') + 1);
                if (_config[i].StartsWith("DB"))
                    Program.mDB = _config[i].Substring(_config[i].IndexOf('=') + 1);
                BWLoad.ReportProgress((100 / _config.Length) * i);
                Thread.Sleep(100);
            }
            Program.MySql = new MySql(Program.mHost, Program.mPort, Program.mDB, Program.mUN, Program.mPW);
        }

        private void BWLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (PBar.Value >= 0 && PBar.Value < 21)
            {
                Status = @"Starting Up";
            }
            else if (PBar.Value > 20 && PBar.Value < 49)
            {
                Status = @"Loading Config";
            }
            //else switch (PBar.Value)
            //    {
            //        case 50:
            //            PTimer = true;
            //            break;
            //        case 100:
            //            PTimer = true;
            //            Timer.Enabled = false;
            //            break;
            //    }
            PBar.Value = e.ProgressPercentage;
        }

        private void BWLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled))
            {
                lblStatus.Text = @"Cancelled!";
            }
            else if (e.Error != null)
            {
                lblStatus.Text = (@"Error: " + e.Error.Message);
            }
            else
            {
                PBar.Value = 100;
                Status = @"Requesting User Login";
                ShowLogin();
            }
        }
    }
}
