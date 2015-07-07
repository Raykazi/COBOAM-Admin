namespace COBOAM_Admin.UserControls.MediaSales
{
    partial class AddOrder
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
            this.lbSTitle = new System.Windows.Forms.ListBox();
            this.sermonsBS = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Main = new COBOAM_Admin.DS_Main();
            this.lbPName = new System.Windows.Forms.ListBox();
            this.preachersBS = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddSermons = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbAmtPaid = new System.Windows.Forms.TextBox();
            this.tbAmtOwed = new System.Windows.Forms.TextBox();
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.tbDiscounts = new System.Windows.Forms.TextBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.customerBS = new System.Windows.Forms.BindingSource(this.components);
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmtOwed = new System.Windows.Forms.Label();
            this.lblAmtPaid = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.preachersTA = new COBOAM_Admin.DS_MainTableAdapters.preachersTableAdapter();
            this.customerTA = new COBOAM_Admin.DS_MainTableAdapters.customerTableAdapter();
            this.sermonsTA = new COBOAM_Admin.DS_MainTableAdapters.sermonsTableAdapter();
            this.typesTA = new COBOAM_Admin.DS_MainTableAdapters.typesTableAdapter();
            this.typesBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sermonsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preachersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBS)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSTitle
            // 
            this.lbSTitle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sermonsBS, "SID", true));
            this.lbSTitle.DataSource = this.sermonsBS;
            this.lbSTitle.DisplayMember = "Title";
            this.lbSTitle.FormattingEnabled = true;
            this.lbSTitle.Location = new System.Drawing.Point(197, 81);
            this.lbSTitle.Name = "lbSTitle";
            this.lbSTitle.Size = new System.Drawing.Size(214, 95);
            this.lbSTitle.TabIndex = 94;
            this.lbSTitle.ValueMember = "SID";
            // 
            // sermonsBS
            // 
            this.sermonsBS.DataMember = "sermons";
            this.sermonsBS.DataSource = this.dS_Main;
            // 
            // dS_Main
            // 
            this.dS_Main.DataSetName = "DS_Main";
            this.dS_Main.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbPName
            // 
            this.lbPName.DataSource = this.preachersBS;
            this.lbPName.DisplayMember = "Name";
            this.lbPName.FormattingEnabled = true;
            this.lbPName.Location = new System.Drawing.Point(33, 81);
            this.lbPName.Name = "lbPName";
            this.lbPName.Size = new System.Drawing.Size(158, 95);
            this.lbPName.TabIndex = 93;
            this.lbPName.ValueMember = "PID";
            this.lbPName.SelectedIndexChanged += new System.EventHandler(this.lbPName_SelectedIndexChanged);
            // 
            // preachersBS
            // 
            this.preachersBS.DataMember = "preachers";
            this.preachersBS.DataSource = this.dS_Main;
            // 
            // btnAddSermons
            // 
            this.btnAddSermons.Location = new System.Drawing.Point(325, 42);
            this.btnAddSermons.Name = "btnAddSermons";
            this.btnAddSermons.Size = new System.Drawing.Size(84, 23);
            this.btnAddSermons.TabIndex = 92;
            this.btnAddSermons.Text = "Add Sermon";
            this.btnAddSermons.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 91;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 90;
            this.btnSave.Text = "Add Order";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbType
            // 
            this.cbType.DisplayMember = "Types";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(70, 182);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 21);
            this.cbType.TabIndex = 85;
            this.cbType.ValueMember = "ID";
            // 
            // tbAmtPaid
            // 
            this.tbAmtPaid.Location = new System.Drawing.Point(262, 213);
            this.tbAmtPaid.Name = "tbAmtPaid";
            this.tbAmtPaid.Size = new System.Drawing.Size(100, 20);
            this.tbAmtPaid.TabIndex = 88;
            this.tbAmtPaid.Text = "0";
            this.tbAmtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAmtOwed
            // 
            this.tbAmtOwed.Location = new System.Drawing.Point(198, 248);
            this.tbAmtOwed.Name = "tbAmtOwed";
            this.tbAmtOwed.ReadOnly = true;
            this.tbAmtOwed.Size = new System.Drawing.Size(100, 20);
            this.tbAmtOwed.TabIndex = 89;
            this.tbAmtOwed.Text = "0";
            this.tbAmtOwed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.Location = new System.Drawing.Point(235, 42);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(84, 23);
            this.btnCustAdd.TabIndex = 83;
            this.btnCustAdd.Text = "Add Customer";
            this.btnCustAdd.UseVisualStyleBackColor = true;
            // 
            // tbDiscounts
            // 
            this.tbDiscounts.Location = new System.Drawing.Point(262, 183);
            this.tbDiscounts.Name = "tbDiscounts";
            this.tbDiscounts.Size = new System.Drawing.Size(100, 20);
            this.tbDiscounts.TabIndex = 87;
            this.tbDiscounts.Text = "0";
            this.tbDiscounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(70, 213);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(100, 20);
            this.nudQty.TabIndex = 86;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_Changed);
            this.nudQty.Leave += new System.EventHandler(this.nudQty_Changed);
            // 
            // cbName
            // 
            this.cbName.DataSource = this.customerBS;
            this.cbName.DisplayMember = "fName";
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(70, 44);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(159, 21);
            this.cbName.TabIndex = 84;
            this.cbName.ValueMember = "CID";
            // 
            // customerBS
            // 
            this.customerBS.DataMember = "customer";
            this.customerBS.DataSource = this.dS_Main;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpOrderDate.Location = new System.Drawing.Point(70, 13);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(182, 20);
            this.dtpOrderDate.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Discounts:";
            // 
            // lblAmtOwed
            // 
            this.lblAmtOwed.AutoSize = true;
            this.lblAmtOwed.Location = new System.Drawing.Point(129, 255);
            this.lblAmtOwed.Name = "lblAmtOwed";
            this.lblAmtOwed.Size = new System.Drawing.Size(62, 13);
            this.lblAmtOwed.TabIndex = 78;
            this.lblAmtOwed.Text = "Amt. Owed:";
            // 
            // lblAmtPaid
            // 
            this.lblAmtPaid.AutoSize = true;
            this.lblAmtPaid.Location = new System.Drawing.Point(200, 220);
            this.lblAmtPaid.Name = "lblAmtPaid";
            this.lblAmtPaid.Size = new System.Drawing.Size(52, 13);
            this.lblAmtPaid.TabIndex = 77;
            this.lblAmtPaid.Text = "Amt Paid:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(11, 220);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 13);
            this.lblQty.TabIndex = 76;
            this.lblQty.Text = "Quantity:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(26, 190);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 75;
            this.lblType.Text = "Type:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(27, 20);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(33, 13);
            this.lblOrderDate.TabIndex = 80;
            this.lblOrderDate.Text = "Date:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 81;
            this.lblName.Text = "Name:";
            // 
            // preachersTA
            // 
            this.preachersTA.ClearBeforeFill = true;
            // 
            // customerTA
            // 
            this.customerTA.ClearBeforeFill = true;
            // 
            // sermonsTA
            // 
            this.sermonsTA.ClearBeforeFill = true;
            // 
            // typesTA
            // 
            this.typesTA.ClearBeforeFill = true;
            // 
            // typesBS
            // 
            this.typesBS.DataMember = "types";
            this.typesBS.DataSource = this.dS_Main;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSTitle);
            this.Controls.Add(this.lbPName);
            this.Controls.Add(this.btnAddSermons);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbAmtPaid);
            this.Controls.Add(this.tbAmtOwed);
            this.Controls.Add(this.btnCustAdd);
            this.Controls.Add(this.tbDiscounts);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAmtOwed);
            this.Controls.Add(this.lblAmtPaid);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblName);
            this.Name = "AddOrder";
            this.Size = new System.Drawing.Size(427, 319);
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sermonsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preachersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSTitle;
        private System.Windows.Forms.ListBox lbPName;
        private System.Windows.Forms.Button btnAddSermons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbAmtPaid;
        private System.Windows.Forms.TextBox tbAmtOwed;
        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.TextBox tbDiscounts;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmtOwed;
        private System.Windows.Forms.Label lblAmtPaid;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.BindingSource preachersBS;
        private DS_Main dS_Main;
        private System.Windows.Forms.BindingSource customerBS;
        private DS_MainTableAdapters.preachersTableAdapter preachersTA;
        private DS_MainTableAdapters.customerTableAdapter customerTA;
        private System.Windows.Forms.BindingSource sermonsBS;
        private DS_MainTableAdapters.sermonsTableAdapter sermonsTA;
        private DS_MainTableAdapters.typesTableAdapter typesTA;
        private System.Windows.Forms.BindingSource typesBS;
    }
}
