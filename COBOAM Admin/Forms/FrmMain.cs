using System;
using System.Windows.Forms;
using COBOAM_Admin.Classes;

namespace COBOAM_Admin.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SBLAccount.Text = Program.uFName + @" (" + Program.uEmail + @") | Access Level: " + Program.uLvl + @" | Last IP: " + Program.uLIP;
        }

        private void btnWAC_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in panelMain.Controls)
            {
                uc.Visible = uc.Name == "WAC";
            }
            Text = "Website Control Panel";
        }

        private void btnMSC_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in panelMain.Controls)
            {
                uc.Visible = uc.Name == "MSC";
            }
            Text = "Media Sales";

        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in panelMain.Controls)
            {
                uc.Visible = uc.Name == "SC";
            }
            Text = "Settings";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
