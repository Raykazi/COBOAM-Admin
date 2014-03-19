using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using COBOAM_Admin.UserControls;
using COBOAM_Admin.UserControls.WebAdmin;
using System.Xml;

namespace COBOAM_Admin
{
    public partial class Splash : Form
    {
        private readonly FrmLogin _frmLogin;
        private readonly FrmConfig _frmConfig;
        private XmlReader _reader;

        public Splash()
        {
            InitializeComponent();
            _frmLogin = new FrmLogin(this);
            _frmConfig = new FrmConfig();
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
            if (!Program.ConfigExist)
                ShowConfig();
            _reader = XmlReader.Create(Application.StartupPath + "\\" + Program.CFileName);
            BWLoad.RunWorkerAsync();
        }

        private void ShowConfig()
        {
            var result = MessageBox.Show("Config file cannot be found. Would you like to create it now?",
                "Create Config", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) Application.Exit();
            bool doConfig = true;
            while (doConfig)
            {
                doConfig = false;
                _frmConfig.ShowDialog();
            }
        }

        private void BWLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_reader.Read())
            {
                if (_reader.NodeType != XmlNodeType.Element || _reader.Name != "Database") continue;
                Program.mUN = _reader.GetAttribute(0);
                Program.mPW = _reader.GetAttribute(1);
                Program.mHost = _reader.GetAttribute(2);
                Program.mPort = _reader.GetAttribute(3);
                Program.mDB = _reader.GetAttribute(4);
                BWLoad.ReportProgress((100 / _reader.AttributeCount) * _reader.AttributeCount);
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
