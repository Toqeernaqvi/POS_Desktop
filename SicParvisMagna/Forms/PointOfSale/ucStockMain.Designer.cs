namespace SicParvisMagna.Forms.PointOfSale
{
    partial class ucStockMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStockMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblErrorCategory = new System.Windows.Forms.Label();
            this.lblSectionTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.gridStock = new System.Windows.Forms.DataGridView();
            this.lblMsg = new System.Windows.Forms.Label();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.lblMsg);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.bunifuTileButton1);
            this.panelToolBox.Controls.Add(this.txtName);
            this.panelToolBox.Controls.Add(this.label1);
            this.panelToolBox.Controls.Add(this.bunifuCustomLabel1);
            this.panelToolBox.Controls.Add(this.cbxCategory);
            this.panelToolBox.Controls.Add(this.lblErrorCategory);
            this.panelToolBox.Controls.Add(this.lblSectionTitle);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(743, 115);
            this.panelToolBox.TabIndex = 23;
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
            this.btnClear.Location = new System.Drawing.Point(409, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 99);
            this.btnClear.TabIndex = 43;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
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
            this.bunifuTileButton1.Location = new System.Drawing.Point(486, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(67, 99);
            this.bunifuTileButton1.TabIndex = 42;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(96, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 27);
            this.txtName.TabIndex = 41;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.ImeModeChanged += new System.EventHandler(this.txtName_ImeModeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(309, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "*";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(52, 54);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(38, 20);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "Title";
            // 
            // cbxCategory
            // 
            this.cbxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(96, 17);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(209, 23);
            this.cbxCategory.TabIndex = 32;
            this.cbxCategory.SelectionChangeCommitted += new System.EventHandler(this.cbxCategory_SelectionChangeCommitted);
            // 
            // lblErrorCategory
            // 
            this.lblErrorCategory.AutoSize = true;
            this.lblErrorCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCategory.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorCategory.Location = new System.Drawing.Point(309, 20);
            this.lblErrorCategory.Name = "lblErrorCategory";
            this.lblErrorCategory.Size = new System.Drawing.Size(15, 20);
            this.lblErrorCategory.TabIndex = 33;
            this.lblErrorCategory.Text = "*";
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(18, 20);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(72, 20);
            this.lblSectionTitle.TabIndex = 34;
            this.lblSectionTitle.Text = "Category";
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
            this.btnSearch.Location = new System.Drawing.Point(332, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 99);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // gridStock
            // 
            this.gridStock.AllowUserToAddRows = false;
            this.gridStock.AllowUserToDeleteRows = false;
            this.gridStock.AllowUserToOrderColumns = true;
            this.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStock.Location = new System.Drawing.Point(0, 115);
            this.gridStock.Name = "gridStock";
            this.gridStock.ReadOnly = true;
            this.gridStock.Size = new System.Drawing.Size(743, 466);
            this.gridStock.TabIndex = 31;
            this.gridStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellClick);
            this.gridStock.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentDoubleClick);
            this.gridStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellDoubleClick);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(561, 20);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(15, 20);
            this.lblMsg.TabIndex = 44;
            this.lblMsg.Text = "*";
            // 
            // ucStockMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridStock);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucStockMain";
            this.Size = new System.Drawing.Size(743, 581);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.DataGridView gridStock;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblErrorCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSectionTitle;
        private System.Windows.Forms.TextBox txtName;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private System.Windows.Forms.Label lblMsg;
    }
}
