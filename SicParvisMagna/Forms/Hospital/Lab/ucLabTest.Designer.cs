

namespace SicParvisMagna.Forms.Hospital.Lab
{
    partial class ucLabTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLabTest));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.mtcLabTest = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblError_Price = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbx_Lab = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Lab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbx_Test = new System.Windows.Forms.ComboBox();
            this.lblSectionTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Test = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gridLabTest = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.mtcLabTest.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLabTest)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.flowLayoutPanel3);
            this.panelToolBox.Controls.Add(this.txt_search);
            this.panelToolBox.Controls.Add(this.btn_Back);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(732, 115);
            this.panelToolBox.TabIndex = 20;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnSave);
            this.flowLayoutPanel3.Controls.Add(this.btnClear);
            this.flowLayoutPanel3.Controls.Add(this.btnDelete);
            this.flowLayoutPanel3.Controls.Add(this.btnSearch);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(295, 111);
            this.flowLayoutPanel3.TabIndex = 28;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePosition = 17;
            this.btnDelete.ImageZoom = 73;
            this.btnDelete.LabelPosition = 34;
            this.btnDelete.LabelText = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(146, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 99);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
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
            this.btnSearch.Location = new System.Drawing.Point(212, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 99);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(303, 42);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(258, 31);
            this.txt_search.TabIndex = 26;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Image = global::SicParvisMagna.Properties.Resources.Go_Back_50px3;
            this.btn_Back.ImageActive = null;
            this.btn_Back.Location = new System.Drawing.Point(651, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(77, 48);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Back.TabIndex = 25;
            this.btn_Back.TabStop = false;
            this.btn_Back.Zoom = 10;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // mtcLabTest
            // 
            this.mtcLabTest.Controls.Add(this.metroTabPage1);
            this.mtcLabTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcLabTest.Location = new System.Drawing.Point(0, 115);
            this.mtcLabTest.Name = "mtcLabTest";
            this.mtcLabTest.SelectedIndex = 0;
            this.mtcLabTest.Size = new System.Drawing.Size(732, 386);
            this.mtcLabTest.TabIndex = 21;
            this.mtcLabTest.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(724, 344);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Lab Test";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.panel4);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(724, 344);
            this.flowLayoutPanel.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblError_Price);
            this.panel4.Controls.Add(this.txt_Price);
            this.panel4.Controls.Add(this.bunifuCustomLabel3);
            this.panel4.Controls.Add(this.cmbx_Lab);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Controls.Add(this.lblError_Lab);
            this.panel4.Controls.Add(this.cmbx_Test);
            this.panel4.Controls.Add(this.lblSectionTitle);
            this.panel4.Controls.Add(this.lblError_Test);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 169);
            this.panel4.TabIndex = 15;
            // 
            // lblError_Price
            // 
            this.lblError_Price.AutoSize = true;
            this.lblError_Price.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Price.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Price.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Price.Location = new System.Drawing.Point(377, 117);
            this.lblError_Price.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Price.Name = "lblError_Price";
            this.lblError_Price.Size = new System.Drawing.Size(0, 20);
            this.lblError_Price.TabIndex = 17;
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Price.Location = new System.Drawing.Point(161, 116);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(210, 25);
            this.txt_Price.TabIndex = 16;
            this.txt_Price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Price_KeyUp);
            this.txt_Price.Leave += new System.EventHandler(this.txt_Price_Leave);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(100, 118);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Price";
            // 
            // cmbx_Lab
            // 
            this.cmbx_Lab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Lab.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbx_Lab.FormattingEnabled = true;
            this.cmbx_Lab.Location = new System.Drawing.Point(161, 63);
            this.cmbx_Lab.Name = "cmbx_Lab";
            this.cmbx_Lab.Size = new System.Drawing.Size(210, 25);
            this.cmbx_Lab.TabIndex = 14;
            this.cmbx_Lab.SelectedIndexChanged += new System.EventHandler(this.cmbx_Lab_SelectedIndexChanged);
            this.cmbx_Lab.SelectionChangeCommitted += new System.EventHandler(this.cmbx_Lab_SelectionChangeCommitted);
            this.cmbx_Lab.Leave += new System.EventHandler(this.cmbx_Lab_Leave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(110, 65);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(29, 17);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Lab";
            // 
            // lblError_Lab
            // 
            this.lblError_Lab.AutoSize = true;
            this.lblError_Lab.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Lab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Lab.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Lab.Location = new System.Drawing.Point(377, 69);
            this.lblError_Lab.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Lab.Name = "lblError_Lab";
            this.lblError_Lab.Size = new System.Drawing.Size(0, 20);
            this.lblError_Lab.TabIndex = 13;
            // 
            // cmbx_Test
            // 
            this.cmbx_Test.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Test.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbx_Test.FormattingEnabled = true;
            this.cmbx_Test.Location = new System.Drawing.Point(161, 15);
            this.cmbx_Test.Name = "cmbx_Test";
            this.cmbx_Test.Size = new System.Drawing.Size(210, 25);
            this.cmbx_Test.TabIndex = 11;
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.Black;
            this.lblSectionTitle.Location = new System.Drawing.Point(111, 17);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(32, 17);
            this.lblSectionTitle.TabIndex = 6;
            this.lblSectionTitle.Text = "Test";
            // 
            // lblError_Test
            // 
            this.lblError_Test.AutoSize = true;
            this.lblError_Test.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Test.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Test.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Test.Location = new System.Drawing.Point(377, 21);
            this.lblError_Test.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Test.Name = "lblError_Test";
            this.lblError_Test.Size = new System.Drawing.Size(0, 20);
            this.lblError_Test.TabIndex = 10;
            // 
            // gridLabTest
            // 
            this.gridLabTest.AllowUserToAddRows = false;
            this.gridLabTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLabTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridLabTest.Location = new System.Drawing.Point(0, 501);
            this.gridLabTest.Name = "gridLabTest";
            this.gridLabTest.Size = new System.Drawing.Size(732, 196);
            this.gridLabTest.TabIndex = 26;
            this.gridLabTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLabTest_CellClick);
            // 
            // ucLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtcLabTest);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.gridLabTest);
            this.Name = "ucLabTest";
            this.Size = new System.Drawing.Size(732, 697);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.mtcLabTest.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLabTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuImageButton btn_Back;
        private MetroFramework.Controls.MetroTabControl mtcLabTest;
        private System.Windows.Forms.DataGridView gridLabTest;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_Price;
        private System.Windows.Forms.TextBox txt_Price;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox cmbx_Lab;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_Lab;
        private System.Windows.Forms.ComboBox cmbx_Test;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSectionTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_Test;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        public Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
    }
}
