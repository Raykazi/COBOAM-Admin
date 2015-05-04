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
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.panelBNav = new System.Windows.Forms.Panel();
            this.bnOrder = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.tpSermons = new System.Windows.Forms.TabPage();
            this.tpPreachers = new System.Windows.Forms.TabPage();
            this.dS_Main = new COBOAM_Admin.DS_Main();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtOwedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderTableAdapter = new COBOAM_Admin.DS_MainTableAdapters.orderTableAdapter();
            this.tcMS.SuspendLayout();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            this.panelBNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrder)).BeginInit();
            this.bnOrder.SuspendLayout();
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
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIDDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.sIDDataGridViewTextBoxColumn,
            this.dateOrderedDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.discountsDataGridViewTextBoxColumn,
            this.amtOwedDataGridViewTextBoxColumn,
            this.amtPaidDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn});
            this.dgvCustomer.DataSource = this.bsOrder;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(3, 28);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(1326, 581);
            this.dgvCustomer.TabIndex = 1;
            // 
            // bsOrder
            // 
            this.bsOrder.DataMember = "order";
            this.bsOrder.DataSource = this.dS_Main;
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
            this.toolStripButton1,
            this.bindingNavigatorEditItem,
            this.btnDeleteOrder,
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
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton1.Text = "New Order";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(111, 22);
            this.bindingNavigatorEditItem.Text = "Edit Selected Order";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(77, 22);
            this.btnDeleteOrder.Text = "Delete Order";
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
            // dS_Main
            // 
            this.dS_Main.DataSetName = "DS_Main";
            this.dS_Main.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "OID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "OID";
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // dateOrderedDataGridViewTextBoxColumn
            // 
            this.dateOrderedDataGridViewTextBoxColumn.DataPropertyName = "dateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.HeaderText = "dateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.Name = "dateOrderedDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "Type";
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // discountsDataGridViewTextBoxColumn
            // 
            this.discountsDataGridViewTextBoxColumn.DataPropertyName = "Discounts";
            this.discountsDataGridViewTextBoxColumn.HeaderText = "Discounts";
            this.discountsDataGridViewTextBoxColumn.Name = "discountsDataGridViewTextBoxColumn";
            // 
            // amtOwedDataGridViewTextBoxColumn
            // 
            this.amtOwedDataGridViewTextBoxColumn.DataPropertyName = "AmtOwed";
            this.amtOwedDataGridViewTextBoxColumn.HeaderText = "AmtOwed";
            this.amtOwedDataGridViewTextBoxColumn.Name = "amtOwedDataGridViewTextBoxColumn";
            // 
            // amtPaidDataGridViewTextBoxColumn
            // 
            this.amtPaidDataGridViewTextBoxColumn.DataPropertyName = "AmtPaid";
            this.amtPaidDataGridViewTextBoxColumn.HeaderText = "AmtPaid";
            this.amtPaidDataGridViewTextBoxColumn.Name = "amtPaidDataGridViewTextBoxColumn";
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            this.panelBNav.ResumeLayout(false);
            this.panelBNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrder)).EndInit();
            this.bnOrder.ResumeLayout(false);
            this.bnOrder.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton btnDeleteOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtOwedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private DS_Main dS_Main;
        private DS_MainTableAdapters.orderTableAdapter orderTableAdapter;

    }
}
