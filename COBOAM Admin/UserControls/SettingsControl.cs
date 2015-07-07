using System;
using System.Windows.Forms;
using System.Xml;
using COBOAM_Admin.Classes;

namespace COBOAM_Admin.UserControls
{
    public partial class SettingsControl : TUserControl
    {
        private XmlWriterSettings _settings;
        private XmlWriter _writer;
        public SettingsControl()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            _settings = new XmlWriterSettings { Indent = true };
            _writer = XmlWriter.Create(Application.StartupPath + "\\" + Program.CFileName, _settings);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _writer.WriteStartDocument();
            _writer.WriteStartElement("Database");
            _writer.WriteAttributeString("Host", tbDHost.Text);
            _writer.WriteAttributeString("Port", tbDPort.Text);
            _writer.WriteAttributeString("DB", tbDDB.Text);
            _writer.WriteAttributeString("Username", tbDUN.Text);
            _writer.WriteAttributeString("Password", tbDPW.Text);
            _writer.WriteEndElement();

            _writer.WriteStartElement("FTP");
            _writer.WriteAttributeString("Host", tbFHost.Text);
            _writer.WriteAttributeString("Port", tbFPort.Text);
            _writer.WriteAttributeString("Username", tbFUN.Text);
            _writer.WriteAttributeString("Password", tbFPW.Text);
            _writer.WriteEndElement();

            _writer.WriteStartElement("Email");
            _writer.WriteAttributeString("Host", tbEHost.Text);
            _writer.WriteAttributeString("Port", tbEPort.Text);
            _writer.WriteAttributeString("Username", tbEUN.Text);
            _writer.WriteAttributeString("Password", tbEPW.Text);
            _writer.WriteEndElement();

            _writer.WriteStartElement("AutoLogin");
            if (cbALE.Checked)
            {
                _writer.WriteAttributeString("Enabled", "1");
                _writer.WriteAttributeString("Username", Program.aUN);
                _writer.WriteAttributeString("Password", Program.aPW);
            }
            else
            {
                _writer.WriteAttributeString("Enabled", "0");
                _writer.WriteAttributeString("Username", string.Empty);
                _writer.WriteAttributeString("Password", string.Empty);
            }
            _writer.WriteEndElement();
            _writer.WriteEndDocument();
            _writer.Flush();
            _writer.Close();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
