using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.Forms
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
            var result = MessageBox.Show(Resources.MB_Show_Config,
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
            int i = 0;
            int[] settingCount = { 5, 4, 4 ,3};
            int elementCount = settingCount.Length;
            int sectionPercent = ((PBar.Maximum / elementCount));
            while (_reader.Read())
            {

                #region Database
                if (_reader.Name == "Database")
                {
                    while (_reader.NodeType != XmlNodeType.EndElement)
                    {
                        _reader.Read();
                        switch (_reader.Name)
                        {
                            case "Host":
                                while (_reader.NodeType != XmlNodeType.EndElement)
                                {
                                    _reader.Read();
                                    if (_reader.NodeType != XmlNodeType.Text) continue;
                                    Program.mHost = _reader.Value;
                                    BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                                }
                                _reader.Read();
                                break;
                            case "Port":
                                while (_reader.NodeType != XmlNodeType.EndElement)
                                {
                                    _reader.Read();
                                    if (_reader.NodeType != XmlNodeType.Text) continue;
                                    Program.mPort = _reader.Value;
                                    BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                                }
                                _reader.Read();
                                break;
                            case "DB":
                                while (_reader.NodeType != XmlNodeType.EndElement)
                                {
                                    _reader.Read();
                                    if (_reader.NodeType != XmlNodeType.Text) continue;
                                    Program.mDB = _reader.Value;
                                    BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                                }
                                _reader.Read();
                                break;
                            case "Username":
                                while (_reader.NodeType != XmlNodeType.EndElement)
                                {
                                    _reader.Read();
                                    if (_reader.NodeType != XmlNodeType.Text) continue;
                                    Program.mUN = _reader.Value;
                                    BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                                }
                                _reader.Read();
                                break;
                            case "Password":
                                while (_reader.NodeType != XmlNodeType.EndElement)
                                {
                                    _reader.Read();
                                    if (_reader.NodeType != XmlNodeType.Text) continue;
                                    Program.mPW = _reader.Value;
                                    BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                                }
                                _reader.Read();
                                break;
                        }
                    }
                }
                #endregion
                #region FTP
                if (_reader.Name == "FTP")
                {
                    i++;
                    while (_reader.NodeType != XmlNodeType.EndElement)
                    {
                        _reader.Read();
                        if (_reader.Name == "Host")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.fHost = _reader.Value;
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                        if (_reader.Name == "Port")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.fPort = Convert.ToInt32(_reader.Value);
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                        if (_reader.Name == "Username")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.fUN = _reader.Value;
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                        if (_reader.Name == "Password")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.fPW = _reader.Value;
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                    }
                }
                #endregion
                #region Email
                if (_reader.Name == "Email")
                {
                    i++;
                    while (_reader.NodeType != XmlNodeType.EndElement)
                    {
                        _reader.Read();
                        if (_reader.Name == "Host")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.sHost = _reader.Value;
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                        if (_reader.Name == "Port")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.sPort = Convert.ToInt32(_reader.Value);
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                        if (_reader.Name == "Username")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.sUN = _reader.Value;
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                        if (_reader.Name == "Password")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.sPW = _reader.Value;
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                    }
                }
                #endregion
                #region Autolog
                if (_reader.Name == "AutoLogin")
                {
                    i++;
                    while (_reader.NodeType != XmlNodeType.EndElement)
                    {
                        _reader.Read();
                        if (_reader.Name == "Enabled")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.aLE = Convert.ToInt32(_reader.Value);
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                        if (_reader.Name == "Username")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.aUN = _reader.Value;
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                        if (_reader.Name == "Password")
                        {
                            while (_reader.NodeType != XmlNodeType.EndElement)
                            {
                                _reader.Read();
                                if (_reader.NodeType != XmlNodeType.Text) continue;
                                Program.aPW = _reader.Value;
                                BWLoad.ReportProgress((sectionPercent / settingCount[i]) * 1);
                            }
                            _reader.Read();
                        }
                    }
                }
                #endregion
            }
            _reader.Close();
            Program.MySql = new Classes.MySql(Program.mHost, Program.mPort, Program.mDB, Program.mUN, Program.mPW);
        }

        private void BWLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int min = PBar.Value;
            int max = PBar.Value + e.ProgressPercentage;
            do
            {
                min = PBar.Value += 1;
                Thread.Sleep(25);
            } while (min != max);

        }

        private void BWLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Status = @"Error: " + e.Error.Message;
            }
            else
            {
                ShowLogin();
            }
        }
    }
}
