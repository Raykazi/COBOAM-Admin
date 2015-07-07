using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBOAM_Admin.UserControls.MediaSales
{
    public partial class FrmGeneric : Form
    {
        public FrmGeneric(int formCode)
        {
            InitializeComponent();
            foreach (UserControl userControl in Controls )
            {
                userControl.Visible = false;
            }
            switch (formCode)
            {
                case 1:
                    addOrder.Visible = true;
                    break;


            }
        }

        private void Generic_Load(object sender, EventArgs e)
        {

        }
    }
}
