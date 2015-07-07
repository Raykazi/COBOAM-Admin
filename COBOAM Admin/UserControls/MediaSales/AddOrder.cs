using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBOAM_Admin.UserControls.MediaSales
{
    public partial class AddOrder : UserControl
    {
        private decimal _quantity = 0;
        private decimal _discounts;
        private decimal _amtOwed;
        private decimal _amtPaid;
        private bool _paid;
        public AddOrder()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void lbPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPName.SelectedValue == null) return;
            int preacherId = (int)lbPName.SelectedValue;
            sermonsTA.SBP2(preacherId);
        }

        private void nudQty_Changed(object sender, EventArgs e)
        {
            _quantity = nudQty.Value;
            Calculate();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            preachersTA.Fill(dS_Main.preachers);
            customerTA.Fill(dS_Main.customer);
            typesTA.Fill(dS_Main.types);
        }

        private void Calculate()
        {
            int selectedType = cbType.SelectedIndex;
            if (selectedType < 0 && tbDiscounts.Text.Length == 0) return;
            decimal price = Convert.ToDecimal(typesTA.GetPrice(selectedType));
            _amtOwed = (price * _quantity) - (_discounts + _amtPaid);
            tbAmtOwed.Text = String.Format("{0:c}", _amtOwed);
            tbDiscounts.Text = String.Format("{0:c}", _discounts);
            tbAmtPaid.Text = String.Format("{0:c}", _amtPaid);
        }
    }
}
