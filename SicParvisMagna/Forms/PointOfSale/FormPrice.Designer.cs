namespace SicParvisMagna.Forms.PointOfSale
{
    partial class FormPrice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrice));
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPrice = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblError_Rs = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblErrorCategory = new System.Windows.Forms.Label();
            this.lblSectionTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panel13.Controls.Add(this.btnSave);
            this.panel13.Controls.Add(this.btnClear);
            this.panel13.Controls.Add(this.btnDelete);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(494, 98);
            this.panel13.TabIndex = 64;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePosition = 16;
            this.btnSave.ImageZoom = 73;
            this.btnSave.LabelPosition = 32;
            this.btnSave.LabelText = "Save";
            this.btnSave.Location = new System.Drawing.Point(7, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 99);
            this.btnSave.TabIndex = 27;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImagePosition = 16;
            this.btnClear.ImageZoom = 73;
            this.btnClear.LabelPosition = 32;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(73, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 99);
            this.btnClear.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePosition = 16;
            this.btnDelete.ImageZoom = 73;
            this.btnDelete.LabelPosition = 32;
            this.btnDelete.LabelText = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(139, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 99);
            this.btnDelete.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridPrice);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlProduct);
            this.panel1.Controls.Add(this.pnlCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 343);
            this.panel1.TabIndex = 65;
            // 
            // gridPrice
            // 
            this.gridPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrice.Location = new System.Drawing.Point(7, 145);
            this.gridPrice.Name = "gridPrice";
            this.gridPrice.Size = new System.Drawing.Size(482, 186);
            this.gridPrice.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.lblError_Rs);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(8, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 45);
            this.panel4.TabIndex = 51;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(58, 12);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel2.TabIndex = 58;
            this.bunifuCustomLabel2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(121, 9);
            this.txtPrice.Mask = "00000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 25);
            this.txtPrice.TabIndex = 57;
            this.txtPrice.ValidatingType = typeof(int);
            // 
            // lblError_Rs
            // 
            this.lblError_Rs.AutoSize = true;
            this.lblError_Rs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Rs.ForeColor = System.Drawing.Color.Crimson;
            this.lblError_Rs.Location = new System.Drawing.Point(285, 12);
            this.lblError_Rs.Name = "lblError_Rs";
            this.lblError_Rs.Size = new System.Drawing.Size(0, 17);
            this.lblError_Rs.TabIndex = 56;
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.cmbProduct);
            this.pnlProduct.Controls.Add(this.label1);
            this.pnlProduct.Controls.Add(this.bunifuCustomLabel1);
            this.pnlProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProduct.Location = new System.Drawing.Point(8, 54);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(481, 36);
            this.pnlProduct.TabIndex = 3;
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(121, 11);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(209, 25);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.SelectionChangeCommitted += new System.EventHandler(this.cmbProduct_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(334, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "*";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Product";
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.cmbCategory);
            this.pnlCategory.Controls.Add(this.lblErrorCategory);
            this.pnlCategory.Controls.Add(this.lblSectionTitle);
            this.pnlCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCategory.Location = new System.Drawing.Point(7, 16);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(482, 36);
            this.pnlCategory.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(121, 5);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(209, 25);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // lblErrorCategory
            // 
            this.lblErrorCategory.AutoSize = true;
            this.lblErrorCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblErrorCategory.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorCategory.Location = new System.Drawing.Point(334, 10);
            this.lblErrorCategory.Name = "lblErrorCategory";
            this.lblErrorCategory.Size = new System.Drawing.Size(13, 16);
            this.lblErrorCategory.TabIndex = 2;
            this.lblErrorCategory.Text = "*";
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(39, 8);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(64, 17);
            this.lblSectionTitle.TabIndex = 2;
            this.lblSectionTitle.Text = "Category";
            // 
            // FormPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel13);
            this.Name = "FormPrice";
            this.Text = "FormPrice";
            this.Load += new System.EventHandler(this.FormPrice_Load);
            this.panel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        public Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        public Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblErrorCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSectionTitle;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.Label lblError_Rs;
        private System.Windows.Forms.DataGridView gridPrice;
    }
}