using System;
using System.Data;
using System.Runtime.Caching;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using COBOAM_Admin.UserControls.MediaSales;

namespace COBOAM_Admin.UserControls
{
    public partial class MediaSalesControl : UserControl
    {
        private FrmGeneric _frmGeneric;
        public MediaSalesControl()
        {
            InitializeComponent();

        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            _frmGeneric = new FrmGeneric(1);
            _frmGeneric.ShowDialog(this);

        }
    }
}
