namespace SicParvisMagna.Forms.PointOfSale
{
    partial class ucSaleOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSaleOrder));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new MetroFramework.Controls.MetroDateTime();
            this.dtpEndDate = new MetroFramework.Controls.MetroDateTime();
            this.rdPending = new System.Windows.Forms.RadioButton();
            this.rdPaidAndSold = new System.Windows.Forms.RadioButton();
            this.rdSold = new System.Windows.Forms.RadioButton();
            this.rdPaid = new System.Windows.Forms.RadioButton();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.Lbl_Party = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_Customer = new System.Windows.Forms.ComboBox();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.gridSales = new Telerik.WinControls.UI.RadGridView();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.label1);
            this.panelToolBox.Controls.Add(this.label4);
            this.panelToolBox.Controls.Add(this.dtpStartDate);
            this.panelToolBox.Controls.Add(this.dtpEndDate);
            this.panelToolBox.Controls.Add(this.rdPending);
            this.panelToolBox.Controls.Add(this.rdPaidAndSold);
            this.panelToolBox.Controls.Add(this.rdSold);
            this.panelToolBox.Controls.Add(this.rdPaid);
            this.panelToolBox.Controls.Add(this.rdAll);
            this.panelToolBox.Controls.Add(this.Lbl_Party);
            this.panelToolBox.Controls.Add(this.cbx_Customer);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.bunifuTileButton1);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(768, 115);
            this.panelToolBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(408, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 66;
            this.label1.Tag = "Code";
            this.label1.Text = "End Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(398, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 65;
            this.label4.Tag = "Code";
            this.label4.Text = "Start Date  : ";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(511, 11);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 29);
            this.dtpStartDate.TabIndex = 64;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(511, 46);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 29);
            this.dtpEndDate.TabIndex = 63;
            // 
            // rdPending
            // 
            this.rdPending.AutoSize = true;
            this.rdPending.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPending.Location = new System.Drawing.Point(348, 88);
            this.rdPending.Name = "rdPending";
            this.rdPending.Size = new System.Drawing.Size(76, 21);
            this.rdPending.TabIndex = 62;
            this.rdPending.TabStop = true;
            this.rdPending.Text = "Pending";
            this.rdPending.UseVisualStyleBackColor = true;
            this.rdPending.CheckedChanged += new System.EventHandler(this.rdPending_CheckedChanged);
            // 
            // rdPaidAndSold
            // 
            this.rdPaidAndSold.AutoSize = true;
            this.rdPaidAndSold.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPaidAndSold.Location = new System.Drawing.Point(556, 88);
            this.rdPaidAndSold.Name = "rdPaidAndSold";
            this.rdPaidAndSold.Size = new System.Drawing.Size(111, 21);
            this.rdPaidAndSold.TabIndex = 61;
            this.rdPaidAndSold.TabStop = true;
            this.rdPaidAndSold.Text = "Paid And Sold";
            this.rdPaidAndSold.UseVisualStyleBackColor = true;
            this.rdPaidAndSold.CheckedChanged += new System.EventHandler(this.rdPaidAndRecieved_CheckedChanged);
            // 
            // rdSold
            // 
            this.rdSold.AutoSize = true;
            this.rdSold.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSold.Location = new System.Drawing.Point(488, 88);
            this.rdSold.Name = "rdSold";
            this.rdSold.Size = new System.Drawing.Size(52, 21);
            this.rdSold.TabIndex = 60;
            this.rdSold.TabStop = true;
            this.rdSold.Text = "Sold";
            this.rdSold.UseVisualStyleBackColor = true;
            this.rdSold.CheckedChanged += new System.EventHandler(this.rdRecieved_CheckedChanged);
            // 
            // rdPaid
            // 
            this.rdPaid.AutoSize = true;
            this.rdPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPaid.Location = new System.Drawing.Point(430, 88);
            this.rdPaid.Name = "rdPaid";
            this.rdPaid.Size = new System.Drawing.Size(52, 21);
            this.rdPaid.TabIndex = 59;
            this.rdPaid.TabStop = true;
            this.rdPaid.Text = "Paid";
            this.rdPaid.UseVisualStyleBackColor = true;
            this.rdPaid.CheckedChanged += new System.EventHandler(this.rdPaid_CheckedChanged);
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAll.Location = new System.Drawing.Point(301, 88);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(41, 21);
            this.rdAll.TabIndex = 58;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "All";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // Lbl_Party
            // 
            this.Lbl_Party.AutoSize = true;
            this.Lbl_Party.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Party.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Party.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Party.Location = new System.Drawing.Point(223, 18);
            this.Lbl_Party.Name = "Lbl_Party";
            this.Lbl_Party.Size = new System.Drawing.Size(67, 17);
            this.Lbl_Party.TabIndex = 57;
            this.Lbl_Party.Text = "Customer";
            // 
            // cbx_Customer
            // 
            this.cbx_Customer.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbx_Customer.FormattingEnabled = true;
            this.cbx_Customer.Location = new System.Drawing.Point(226, 38);
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.Size = new System.Drawing.Size(152, 27);
            this.cbx_Customer.TabIndex = 56;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImagePosition = 16;
            this.btnClear.ImageZoom = 73;
            this.btnClear.LabelPosition = 32;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(82, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 99);
            this.btnClear.TabIndex = 52;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 16;
            this.bunifuTileButton1.ImageZoom = 73;
            this.bunifuTileButton1.LabelPosition = 32;
            this.bunifuTileButton1.LabelText = "Add New";
            this.bunifuTileButton1.Location = new System.Drawing.Point(159, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(67, 99);
            this.bunifuTileButton1.TabIndex = 51;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSearch.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImagePosition = 16;
            this.btnSearch.ImageZoom = 73;
            this.btnSearch.LabelPosition = 32;
            this.btnSearch.LabelText = "Search";
            this.btnSearch.Location = new System.Drawing.Point(5, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 99);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridSales
            // 
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.Location = new System.Drawing.Point(0, 115);
            // 
            // 
            // 
            this.gridSales.MasterTemplate.AllowAddNewRow = false;
            this.gridSales.MasterTemplate.AllowCellContextMenu = false;
            this.gridSales.MasterTemplate.AllowColumnChooser = false;
            this.gridSales.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridSales.MasterTemplate.AllowColumnReorder = false;
            this.gridSales.MasterTemplate.AllowColumnResize = false;
            this.gridSales.MasterTemplate.AllowDeleteRow = false;
            this.gridSales.MasterTemplate.AllowDragToGroup = false;
            this.gridSales.MasterTemplate.AllowEditRow = false;
            this.gridSales.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.gridSales.MasterTemplate.AllowRowResize = false;
            this.gridSales.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridSales.Name = "gridSales";
            this.gridSales.Size = new System.Drawing.Size(768, 509);
            this.gridSales.TabIndex = 25;
            this.gridSales.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridPurchase_CellClick);
            // 
            // ucSaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSales);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucSaleOrder";
            this.Size = new System.Drawing.Size(768, 624);
            this.Load += new System.EventHandler(this.ucReturnOrder_Load);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Telerik.WinControls.UI.RadGridView gridSales;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Party;
        private System.Windows.Forms.ComboBox cbx_Customer;
        private System.Windows.Forms.RadioButton rdPending;
        private System.Windows.Forms.RadioButton rdPaidAndSold;
        private System.Windows.Forms.RadioButton rdSold;
        private System.Windows.Forms.RadioButton rdPaid;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroDateTime dtpStartDate;
        private MetroFramework.Controls.MetroDateTime dtpEndDate;
    }
}
