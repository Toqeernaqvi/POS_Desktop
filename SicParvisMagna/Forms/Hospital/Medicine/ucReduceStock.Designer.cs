namespace SicParvisMagna.Forms.Hospital.Medicine
{
    partial class ucReduceStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReduceStock));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btn_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_valueIncludingTax = new System.Windows.Forms.TextBox();
            this.txt_salestaxPayable = new System.Windows.Forms.TextBox();
            this.txt_rateofTax = new System.Windows.Forms.TextBox();
            this.txt_ValueExclusiveTax = new System.Windows.Forms.TextBox();
            this.grid_Medicine = new System.Windows.Forms.DataGridView();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblError_Party = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_Catagory = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblErrorName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbx_Medicine = new System.Windows.Forms.ComboBox();
            this.lblErrorMed = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Medicine)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.flowLayoutPanel3);
            this.panelToolBox.Controls.Add(this.btn_Back);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(727, 115);
            this.panelToolBox.TabIndex = 23;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Image = global::SicParvisMagna.Properties.Resources.Long_Arrow_Left_26px;
            this.btn_Back.ImageActive = null;
            this.btn_Back.Location = new System.Drawing.Point(646, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(77, 48);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Back.TabIndex = 25;
            this.btn_Back.TabStop = false;
            this.btn_Back.Zoom = 10;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txt_valueIncludingTax);
            this.panel1.Controls.Add(this.txt_salestaxPayable);
            this.panel1.Controls.Add(this.txt_rateofTax);
            this.panel1.Controls.Add(this.txt_ValueExclusiveTax);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 58);
            this.panel1.TabIndex = 30;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(135, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(44, 20);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "Total";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // txt_valueIncludingTax
            // 
            this.txt_valueIncludingTax.BackColor = System.Drawing.SystemColors.Control;
            this.txt_valueIncludingTax.Location = new System.Drawing.Point(499, 19);
            this.txt_valueIncludingTax.Name = "txt_valueIncludingTax";
            this.txt_valueIncludingTax.ReadOnly = true;
            this.txt_valueIncludingTax.Size = new System.Drawing.Size(100, 20);
            this.txt_valueIncludingTax.TabIndex = 35;
            this.txt_valueIncludingTax.Visible = false;
            // 
            // txt_salestaxPayable
            // 
            this.txt_salestaxPayable.Location = new System.Drawing.Point(395, 19);
            this.txt_salestaxPayable.Name = "txt_salestaxPayable";
            this.txt_salestaxPayable.ReadOnly = true;
            this.txt_salestaxPayable.Size = new System.Drawing.Size(103, 20);
            this.txt_salestaxPayable.TabIndex = 34;
            this.txt_salestaxPayable.Visible = false;
            // 
            // txt_rateofTax
            // 
            this.txt_rateofTax.Location = new System.Drawing.Point(293, 19);
            this.txt_rateofTax.Name = "txt_rateofTax";
            this.txt_rateofTax.ReadOnly = true;
            this.txt_rateofTax.Size = new System.Drawing.Size(100, 20);
            this.txt_rateofTax.TabIndex = 33;
            this.txt_rateofTax.Visible = false;
            // 
            // txt_ValueExclusiveTax
            // 
            this.txt_ValueExclusiveTax.Location = new System.Drawing.Point(191, 19);
            this.txt_ValueExclusiveTax.Name = "txt_ValueExclusiveTax";
            this.txt_ValueExclusiveTax.ReadOnly = true;
            this.txt_ValueExclusiveTax.Size = new System.Drawing.Size(100, 20);
            this.txt_ValueExclusiveTax.TabIndex = 32;
            this.txt_ValueExclusiveTax.Visible = false;
            // 
            // grid_Medicine
            // 
            this.grid_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Medicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_Medicine.Location = new System.Drawing.Point(0, 440);
            this.grid_Medicine.Name = "grid_Medicine";
            this.grid_Medicine.Size = new System.Drawing.Size(727, 196);
            this.grid_Medicine.TabIndex = 31;
            this.grid_Medicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Medicine_CellClick);
            this.grid_Medicine.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Medicine_CellValueChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 115);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(727, 328);
            this.metroTabControl1.TabIndex = 32;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(719, 286);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Controls.Add(this.panel3);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(719, 286);
            this.flowLayoutPanel.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblError_Party);
            this.panel2.Controls.Add(this.cbx_Catagory);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.lblErrorName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 77);
            this.panel2.TabIndex = 0;
            // 
            // lblError_Party
            // 
            this.lblError_Party.AutoSize = true;
            this.lblError_Party.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Party.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Party.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Party.Location = new System.Drawing.Point(434, 31);
            this.lblError_Party.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Party.Name = "lblError_Party";
            this.lblError_Party.Size = new System.Drawing.Size(0, 21);
            this.lblError_Party.TabIndex = 68;
            // 
            // cbx_Catagory
            // 
            this.cbx_Catagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Catagory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Catagory.FormattingEnabled = true;
            this.cbx_Catagory.Location = new System.Drawing.Point(104, 25);
            this.cbx_Catagory.Name = "cbx_Catagory";
            this.cbx_Catagory.Size = new System.Drawing.Size(324, 29);
            this.cbx_Catagory.TabIndex = 67;
            this.cbx_Catagory.SelectionChangeCommitted += new System.EventHandler(this.cbx_Catagory_SelectionChangeCommitted);
            this.cbx_Catagory.Leave += new System.EventHandler(this.cbx_Catagory_Leave);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(28, 33);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(77, 20);
            this.bunifuCustomLabel3.TabIndex = 62;
            this.bunifuCustomLabel3.Text = "Category ";
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorName.Location = new System.Drawing.Point(386, 34);
            this.lblErrorName.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 20);
            this.lblErrorName.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbx_Medicine);
            this.panel3.Controls.Add(this.lblErrorMed);
            this.panel3.Controls.Add(this.bunifuCustomLabel7);
            this.panel3.Location = new System.Drawing.Point(3, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 84);
            this.panel3.TabIndex = 1;
            // 
            // cbx_Medicine
            // 
            this.cbx_Medicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Medicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Medicine.FormattingEnabled = true;
            this.cbx_Medicine.Location = new System.Drawing.Point(104, 24);
            this.cbx_Medicine.Name = "cbx_Medicine";
            this.cbx_Medicine.Size = new System.Drawing.Size(324, 29);
            this.cbx_Medicine.TabIndex = 74;
            this.cbx_Medicine.SelectionChangeCommitted += new System.EventHandler(this.cbx_Medicine_SelectionChangeCommitted);
            this.cbx_Medicine.Leave += new System.EventHandler(this.cbx_Medicine_Leave);
            // 
            // lblErrorMed
            // 
            this.lblErrorMed.AutoSize = true;
            this.lblErrorMed.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMed.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorMed.Location = new System.Drawing.Point(434, 29);
            this.lblErrorMed.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblErrorMed.Name = "lblErrorMed";
            this.lblErrorMed.Size = new System.Drawing.Size(0, 21);
            this.lblErrorMed.TabIndex = 73;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(28, 29);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(72, 20);
            this.bunifuCustomLabel7.TabIndex = 72;
            this.bunifuCustomLabel7.Text = "Medicine";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnSave);
            this.flowLayoutPanel3.Controls.Add(this.btnClear);
            this.flowLayoutPanel3.Controls.Add(this.btnSearch);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(243, 111);
            this.flowLayoutPanel3.TabIndex = 28;
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
            this.btnSave.Location = new System.Drawing.Point(5, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 99);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
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
            this.btnClear.ImagePosition = 17;
            this.btnClear.ImageZoom = 73;
            this.btnClear.LabelPosition = 34;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(78, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 99);
            this.btnClear.TabIndex = 6;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
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
            this.btnSearch.ImagePosition = 17;
            this.btnSearch.ImageZoom = 73;
            this.btnSearch.LabelPosition = 34;
            this.btnSearch.LabelText = "Search";
            this.btnSearch.Location = new System.Drawing.Point(146, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 99);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // ucReduceStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.grid_Medicine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucReduceStock";
            this.Size = new System.Drawing.Size(727, 694);
            this.panelToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Medicine)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuImageButton btn_Back;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txt_valueIncludingTax;
        private System.Windows.Forms.TextBox txt_salestaxPayable;
        private System.Windows.Forms.TextBox txt_rateofTax;
        private System.Windows.Forms.TextBox txt_ValueExclusiveTax;
        private System.Windows.Forms.DataGridView grid_Medicine;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblErrorName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbx_Medicine;
        private Bunifu.Framework.UI.BunifuCustomLabel lblErrorMed;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox cbx_Catagory;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_Party;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
    }
}
