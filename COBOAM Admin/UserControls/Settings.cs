using System;
using System.Windows.Forms;
using System.Xml;
using COBOAM_Admin.Classes;

namespace COBOAM_Admin.UserControls
{
    public partial class Settings : UserControl
    {
        private XmlWriterSettings _settings;
        private XmlWriter _writer;
        public Settings()
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
            _writer.WriteAttributeString("Username", tbUN.Text);
            _writer.WriteAttributeString("Password", tbPW.Text);
            _writer.WriteAttributeString("Host", tbHost.Text);
            _writer.WriteAttributeString("Port", tbPort.Text);
            _writer.WriteAttributeString("DB", tbDB.Text);
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
