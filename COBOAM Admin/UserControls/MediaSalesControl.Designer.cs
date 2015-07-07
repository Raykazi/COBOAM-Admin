namespace COBOAM_Admin.UserControls
{
    partial class MediaSalesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcMS = new System.Windows.Forms.TabControl();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panelBNav = new System.Windows.Forms.Panel();
            this.bnOrder = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNO = new System.Windows.Forms.ToolStripButton();
            this.btnEO = new System.Windows.Forms.ToolStripButton();
            this.btnDO = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.tpSermons = new System.Windows.Forms.TabPage();
            this.tpPreachers = new System.Windows.Forms.TabPage();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Main = new COBOAM_Admin.DS_Main();
            this.orderTableAdapter = new COBOAM_Admin.DS_MainTableAdapters.orderTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtOwedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tcMS.SuspendLayout();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panelBNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrder)).BeginInit();
            this.bnOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMS
            // 
            this.tcMS.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcMS.Controls.Add(this.tpOrders);
            this.tcMS.Controls.Add(this.tpCustomers);
            this.tcMS.Controls.Add(this.tpSermons);
            this.tcMS.Controls.Add(this.tpPreachers);
            this.tcMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMS.Location = new System.Drawing.Point(0, 0);
            this.tcMS.Name = "tcMS";
            this.tcMS.SelectedIndex = 0;
            this.tcMS.Size = new System.Drawing.Size(1340, 641);
            this.tcMS.TabIndex = 0;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.dgvCustomer);
            this.tpOrders.Controls.Add(this.panelBNav);
            this.tpOrders.Location = new System.Drawing.Point(4, 25);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(1332, 612);
            this.tpOrders.TabIndex = 0;
            this.tpOrders.Text = "Orders";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.discountsDataGridViewTextBoxColumn,
            this.amtOwedDataGridViewTextBoxColumn,
            this.amtPaidDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn});
            this.dgvCustomer.DataSource = this.bsOrder;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(3, 28);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(1326, 581);
            this.dgvCustomer.TabIndex = 1;
            // 
            // panelBNav
            // 
            this.panelBNav.Controls.Add(this.bnOrder);
            this.panelBNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBNav.Location = new System.Drawing.Point(3, 3);
            this.panelBNav.Name = "panelBNav";
            this.panelBNav.Size = new System.Drawing.Size(1326, 25);
            this.panelBNav.TabIndex = 0;
            // 
            // bnOrder
            // 
            this.bnOrder.AddNewItem = null;
            this.bnOrder.CountItem = null;
            this.bnOrder.DeleteItem = null;
            this.bnOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNO,
            this.btnEO,
            this.btnDO,
            this.toolStripSeparator1});
            this.bnOrder.Location = new System.Drawing.Point(0, 0);
            this.bnOrder.MoveFirstItem = null;
            this.bnOrder.MoveLastItem = null;
            this.bnOrder.MoveNextItem = null;
            this.bnOrder.MovePreviousItem = null;
            this.bnOrder.Name = "bnOrder";
            this.bnOrder.PositionItem = null;
            this.bnOrder.Size = new System.Drawing.Size(1326, 25);
            this.bnOrder.TabIndex = 3;
            // 
            // btnNO
            // 
            this.btnNO.Name = "btnNO";
            this.btnNO.RightToLeftAutoMirrorImage = true;
            this.btnNO.Size = new System.Drawing.Size(68, 22);
            this.btnNO.Text = "New Order";
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnEO
            // 
            this.btnEO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEO.Name = "btnEO";
            this.btnEO.Size = new System.Drawing.Size(111, 22);
            this.btnEO.Text = "Edit Selected Order";
            // 
            // btnDO
            // 
            this.btnDO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDO.Name = "btnDO";
            this.btnDO.Size = new System.Drawing.Size(77, 22);
            this.btnDO.Text = "Delete Order";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tpCustomers
            // 
            this.tpCustomers.Location = new System.Drawing.Point(4, 25);
            this.tpCustomers.Name = "tpCustomers";
            this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomers.Size = new System.Drawing.Size(1332, 612);
            this.tpCustomers.TabIndex = 1;
            this.tpCustomers.Text = "Customers";
            this.tpCustomers.UseVisualStyleBackColor = true;
            // 
            // tpSermons
            // 
            this.tpSermons.Location = new System.Drawing.Point(4, 25);
            this.tpSermons.Name = "tpSermons";
            this.tpSermons.Size = new System.Drawing.Size(1332, 612);
            this.tpSermons.TabIndex = 2;
            this.tpSermons.Text = "Sermons";
            this.tpSermons.UseVisualStyleBackColor = true;
            // 
            // tpPreachers
            // 
            this.tpPreachers.Location = new System.Drawing.Point(4, 25);
            this.tpPreachers.Name = "tpPreachers";
            this.tpPreachers.Size = new System.Drawing.Size(1332, 612);
            this.tpPreachers.TabIndex = 3;
            this.tpPreachers.Text = "Preachers";
            this.tpPreachers.UseVisualStyleBackColor = true;
            // 
            // bsOrder
            // 
            this.bsOrder.DataMember = "order";
            this.bsOrder.DataSource = this.dS_Main;
            // 
            // dS_Main
            // 
            this.dS_Main.DataSetName = "DS_Main";
            this.dS_Main.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountsDataGridViewTextBoxColumn
            // 
            this.discountsDataGridViewTextBoxColumn.DataPropertyName = "Discounts";
            this.discountsDataGridViewTextBoxColumn.HeaderText = "Discounts";
            this.discountsDataGridViewTextBoxColumn.Name = "discountsDataGridViewTextBoxColumn";
            this.discountsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amtOwedDataGridViewTextBoxColumn
            // 
            this.amtOwedDataGridViewTextBoxColumn.DataPropertyName = "AmtOwed";
            this.amtOwedDataGridViewTextBoxColumn.HeaderText = "AmtOwed";
            this.amtOwedDataGridViewTextBoxColumn.Name = "amtOwedDataGridViewTextBoxColumn";
            this.amtOwedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amtPaidDataGridViewTextBoxColumn
            // 
            this.amtPaidDataGridViewTextBoxColumn.DataPropertyName = "AmtPaid";
            this.amtPaidDataGridViewTextBoxColumn.HeaderText = "AmtPaid";
            this.amtPaidDataGridViewTextBoxColumn.Name = "amtPaidDataGridViewTextBoxColumn";
            this.amtPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            this.paidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // MediaSalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMS);
            this.Name = "MediaSalesControl";
            this.Size = new System.Drawing.Size(1340, 641);
            this.tcMS.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panelBNav.ResumeLayout(false);
            this.panelBNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrder)).EndInit();
            this.bnOrder.ResumeLayout(false);
            this.bnOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMS;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.Panel panelBNav;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TabPage tpCustomers;
        private System.Windows.Forms.TabPage tpSermons;
        private System.Windows.Forms.TabPage tpPreachers;
        private System.Windows.Forms.BindingSource bsOrder;
        private System.Windows.Forms.BindingNavigator bnOrder;
        private System.Windows.Forms.ToolStripButton btnNO;
        private System.Windows.Forms.ToolStripButton btnEO;
        private System.Windows.Forms.ToolStripButton btnDO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderedDataGridViewTextBoxColumn;
        private DS_Main dS_Main;
        private DS_MainTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtOwedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;

    }
}
