namespace SicParvisMagna.Forms.Inventory
{
    partial class ucCustomerInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCustomerInvoice));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btn_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.mtcCusIV = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorProduct = new System.Windows.Forms.Label();
            this.gridCategories = new System.Windows.Forms.DataGridView();
            this.GridClm_CheckBox_Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSectionTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridCusInvoice = new System.Windows.Forms.DataGridView();
            this.GridClm_CheckBox_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.mtcCusIV.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCusInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.btn_Back);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(739, 115);
            this.panelToolBox.TabIndex = 17;
            this.panelToolBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToolBox_Paint);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Image = global::SicParvisMagna.Properties.Resources.Back_Arrow_48px;
            this.btn_Back.ImageActive = null;
            this.btn_Back.Location = new System.Drawing.Point(646, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(77, 48);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Back.TabIndex = 26;
            this.btn_Back.TabStop = false;
            this.btn_Back.Zoom = 10;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePosition = 17;
            this.btnSave.ImageZoom = 73;
            this.btnSave.LabelPosition = 34;
            this.btnSave.LabelText = "Save";
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 99);
            this.btnSave.TabIndex = 5;
            // 
            // mtcCusIV
            // 
            this.mtcCusIV.Controls.Add(this.metroTabPage1);
            this.mtcCusIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcCusIV.Location = new System.Drawing.Point(0, 115);
            this.mtcCusIV.Name = "mtcCusIV";
            this.mtcCusIV.SelectedIndex = 0;
            this.mtcCusIV.Size = new System.Drawing.Size(739, 591);
            this.mtcCusIV.TabIndex = 18;
            this.mtcCusIV.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(731, 549);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "CustomerInvoice";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, -6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 559);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorProduct);
            this.panel1.Controls.Add(this.gridCategories);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.lblSectionTitle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 239);
            this.panel1.TabIndex = 34;
            // 
            // lblErrorProduct
            // 
            this.lblErrorProduct.AutoSize = true;
            this.lblErrorProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorProduct.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorProduct.Location = new System.Drawing.Point(303, 22);
            this.lblErrorProduct.Name = "lblErrorProduct";
            this.lblErrorProduct.Size = new System.Drawing.Size(13, 16);
            this.lblErrorProduct.TabIndex = 216;
            this.lblErrorProduct.Text = "*";
            // 
            // gridCategories
            // 
            this.gridCategories.AllowUserToAddRows = false;
            this.gridCategories.AllowUserToDeleteRows = false;
            this.gridCategories.AllowUserToOrderColumns = true;
            this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridClm_CheckBox_Select});
            this.gridCategories.Location = new System.Drawing.Point(28, 64);
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.Size = new System.Drawing.Size(359, 162);
            this.gridCategories.TabIndex = 217;
            // 
            // GridClm_CheckBox_Select
            // 
            this.GridClm_CheckBox_Select.HeaderText = "Select";
            this.GridClm_CheckBox_Select.Name = "GridClm_CheckBox_Select";
            this.GridClm_CheckBox_Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClm_CheckBox_Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(101, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(184, 25);
            this.txtFirstName.TabIndex = 170;
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(27, 27);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(56, 17);
            this.lblSectionTitle.TabIndex = 23;
            this.lblSectionTitle.Text = "Product";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gridCusInvoice);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 248);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(722, 308);
            this.flowLayoutPanel2.TabIndex = 35;
            // 
            // gridCusInvoice
            // 
            this.gridCusInvoice.BackgroundColor = System.Drawing.Color.White;
            this.gridCusInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCusInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridClm_CheckBox_Remove});
            this.gridCusInvoice.Location = new System.Drawing.Point(3, 3);
            this.gridCusInvoice.Name = "gridCusInvoice";
            this.gridCusInvoice.Size = new System.Drawing.Size(716, 53);
            this.gridCusInvoice.TabIndex = 174;
            // 
            // GridClm_CheckBox_Remove
            // 
            this.GridClm_CheckBox_Remove.HeaderText = "";
            this.GridClm_CheckBox_Remove.Name = "GridClm_CheckBox_Remove";
            this.GridClm_CheckBox_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClm_CheckBox_Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSubTotal);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(3, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 36);
            this.panel2.TabIndex = 175;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(113, 6);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(184, 25);
            this.txtSubTotal.TabIndex = 170;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 17);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Sub Total";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDiscount);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Location = new System.Drawing.Point(3, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 36);
            this.panel3.TabIndex = 176;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(113, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(184, 25);
            this.txtDiscount.TabIndex = 174;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(4, 11);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(61, 17);
            this.bunifuCustomLabel3.TabIndex = 23;
            this.bunifuCustomLabel3.Text = "Discount";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.bunifuCustomLabel5);
            this.panel4.Location = new System.Drawing.Point(3, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(710, 36);
            this.panel4.TabIndex = 177;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(113, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(184, 25);
            this.txtTotal.TabIndex = 175;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(4, 11);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel5.TabIndex = 23;
            this.bunifuCustomLabel5.Text = "Total";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtCash);
            this.panel5.Controls.Add(this.bunifuCustomLabel7);
            this.panel5.Location = new System.Drawing.Point(3, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(710, 36);
            this.panel5.TabIndex = 178;
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(113, 6);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(184, 25);
            this.txtCash.TabIndex = 171;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(4, 9);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel7.TabIndex = 23;
            this.bunifuCustomLabel7.Text = "Cash";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtRemaining);
            this.panel6.Controls.Add(this.bunifuCustomLabel9);
            this.panel6.Location = new System.Drawing.Point(3, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(710, 36);
            this.panel6.TabIndex = 179;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemaining.Location = new System.Drawing.Point(113, 5);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(184, 25);
            this.txtRemaining.TabIndex = 183;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(4, 8);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(72, 17);
            this.bunifuCustomLabel9.TabIndex = 23;
            this.bunifuCustomLabel9.Text = "Remaining";
            // 
            // ucCustomerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtcCusIV);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucCustomerInvoice";
            this.Size = new System.Drawing.Size(739, 706);
            this.panelToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.mtcCusIV.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCusInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private MetroFramework.Controls.MetroTabControl mtcCusIV;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorProduct;
        private System.Windows.Forms.DataGridView gridCategories;
        private System.Windows.Forms.DataGridViewButtonColumn GridClm_CheckBox_Select;
        private System.Windows.Forms.TextBox txtFirstName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSectionTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView gridCusInvoice;
        private System.Windows.Forms.DataGridViewButtonColumn GridClm_CheckBox_Remove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSubTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDiscount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCash;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtRemaining;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuImageButton btn_Back;
    }
}
