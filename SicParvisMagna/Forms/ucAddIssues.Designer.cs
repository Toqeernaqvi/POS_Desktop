namespace SicParvisMagna.Forms
{
    partial class ucAddIssues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddIssues));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabCountry = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblError_Name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DT1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_dept = new Bunifu.Framework.UI.BunifuDropdown();
            this.LblError_dept = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.grid_selectedLabels = new System.Windows.Forms.DataGridView();
            this.grid_Assignlabels = new System.Windows.Forms.DataGridView();
            this.gridIssues = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panelToolBox.SuspendLayout();
            this.tabCountry.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_selectedLabels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Assignlabels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnDelete);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 17;
            this.panelToolBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToolBox_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSearch.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImagePosition = 17;
            this.btnSearch.ImageZoom = 73;
            this.btnSearch.LabelPosition = 34;
            this.btnSearch.LabelText = "Search";
            this.btnSearch.Location = new System.Drawing.Point(231, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 99);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePosition = 17;
            this.btnDelete.ImageZoom = 73;
            this.btnDelete.LabelPosition = 34;
            this.btnDelete.LabelText = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(154, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 99);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImagePosition = 17;
            this.btnClear.ImageZoom = 73;
            this.btnClear.LabelPosition = 34;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(77, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 99);
            this.btnClear.TabIndex = 6;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabCountry
            // 
            this.tabCountry.Controls.Add(this.metroTabPage1);
            this.tabCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCountry.Location = new System.Drawing.Point(0, 99);
            this.tabCountry.Name = "tabCountry";
            this.tabCountry.SelectedIndex = 0;
            this.tabCountry.Size = new System.Drawing.Size(754, 308);
            this.tabCountry.TabIndex = 18;
            this.tabCountry.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabCountry.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 266);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Issues";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 266);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblErrorName);
            this.panel4.Controls.Add(this.lblError_Name);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_Name);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 46);
            this.panel4.TabIndex = 36;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblErrorName.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorName.Location = new System.Drawing.Point(334, 2);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(11, 15);
            this.lblErrorName.TabIndex = 239;
            this.lblErrorName.Text = "*";
            // 
            // lblError_Name
            // 
            this.lblError_Name.AutoSize = true;
            this.lblError_Name.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblError_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lblError_Name.Location = new System.Drawing.Point(337, 26);
            this.lblError_Name.Name = "lblError_Name";
            this.lblError_Name.Size = new System.Drawing.Size(0, 19);
            this.lblError_Name.TabIndex = 238;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 237;
            this.label4.Text = "Title";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(88, 15);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(249, 27);
            this.txt_Name.TabIndex = 236;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.txt_Description);
            this.panel7.Location = new System.Drawing.Point(3, 55);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 168);
            this.panel7.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 31;
            this.label7.Tag = "Code";
            this.label7.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Description.Location = new System.Drawing.Point(88, 9);
            this.txt_Description.MaxLength = 250;
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(249, 147);
            this.txt_Description.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DT1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 46);
            this.panel1.TabIndex = 40;
            // 
            // DT1
            // 
            this.DT1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DT1.BorderRadius = 0;
            this.DT1.ForeColor = System.Drawing.Color.White;
            this.DT1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DT1.FormatCustom = null;
            this.DT1.Location = new System.Drawing.Point(96, 11);
            this.DT1.Name = "DT1";
            this.DT1.Size = new System.Drawing.Size(231, 23);
            this.DT1.TabIndex = 240;
            this.DT1.Value = new System.DateTime(2019, 4, 22, 0, 57, 22, 913);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(337, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 238;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 237;
            this.label3.Text = "DueDate";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmb_dept);
            this.panel2.Controls.Add(this.LblError_dept);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 46);
            this.panel2.TabIndex = 41;
            // 
            // cmb_dept
            // 
            this.cmb_dept.BackColor = System.Drawing.Color.Transparent;
            this.cmb_dept.BorderRadius = 3;
            this.cmb_dept.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_dept.ForeColor = System.Drawing.Color.White;
            this.cmb_dept.Location = new System.Drawing.Point(96, 10);
            this.cmb_dept.Name = "cmb_dept";
            this.cmb_dept.NomalColor = System.Drawing.SystemColors.GrayText;
            this.cmb_dept.onHoverColor = System.Drawing.Color.Silver;
            this.cmb_dept.selectedIndex = -1;
            this.cmb_dept.Size = new System.Drawing.Size(232, 29);
            this.cmb_dept.TabIndex = 240;
            // 
            // LblError_dept
            // 
            this.LblError_dept.AutoSize = true;
            this.LblError_dept.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.LblError_dept.ForeColor = System.Drawing.Color.Tomato;
            this.LblError_dept.Location = new System.Drawing.Point(334, 2);
            this.LblError_dept.Name = "LblError_dept";
            this.LblError_dept.Size = new System.Drawing.Size(11, 15);
            this.LblError_dept.TabIndex = 239;
            this.LblError_dept.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(337, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 238;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 237;
            this.label8.Text = "Dept ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_remove);
            this.panel3.Controls.Add(this.btn_select);
            this.panel3.Controls.Add(this.grid_selectedLabels);
            this.panel3.Controls.Add(this.grid_Assignlabels);
            this.panel3.Location = new System.Drawing.Point(3, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 206);
            this.panel3.TabIndex = 42;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_remove.Location = new System.Drawing.Point(228, 99);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(97, 34);
            this.btn_remove.TabIndex = 79;
            this.btn_remove.Text = "<<";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_select.Location = new System.Drawing.Point(228, 59);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(97, 34);
            this.btn_select.TabIndex = 78;
            this.btn_select.Text = ">>";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // grid_selectedLabels
            // 
            this.grid_selectedLabels.AllowUserToAddRows = false;
            this.grid_selectedLabels.AllowUserToDeleteRows = false;
            this.grid_selectedLabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_selectedLabels.Location = new System.Drawing.Point(343, 21);
            this.grid_selectedLabels.Name = "grid_selectedLabels";
            this.grid_selectedLabels.Size = new System.Drawing.Size(187, 164);
            this.grid_selectedLabels.TabIndex = 77;
            // 
            // grid_Assignlabels
            // 
            this.grid_Assignlabels.AllowUserToAddRows = false;
            this.grid_Assignlabels.AllowUserToDeleteRows = false;
            this.grid_Assignlabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Assignlabels.Location = new System.Drawing.Point(21, 21);
            this.grid_Assignlabels.Name = "grid_Assignlabels";
            this.grid_Assignlabels.Size = new System.Drawing.Size(193, 164);
            this.grid_Assignlabels.TabIndex = 76;
            // 
            // gridIssues
            // 
            this.gridIssues.AllowUserToAddRows = false;
            this.gridIssues.AllowUserToDeleteRows = false;
            this.gridIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIssues.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridIssues.Location = new System.Drawing.Point(0, 407);
            this.gridIssues.Name = "gridIssues";
            this.gridIssues.Size = new System.Drawing.Size(754, 251);
            this.gridIssues.TabIndex = 40;
            this.gridIssues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCountries_CellClick);
            this.gridIssues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCountries_CellContentClick);
            // 
            // ucAddIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCountry);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.gridIssues);
            this.Name = "ucAddIssues";
            this.Size = new System.Drawing.Size(754, 658);
            this.Load += new System.EventHandler(this.ucAddCountry_Load);
            this.panelToolBox.ResumeLayout(false);
            this.tabCountry.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_selectedLabels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Assignlabels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIssues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private MetroFramework.Controls.MetroTabControl tabCountry;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblError_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.DataGridView gridIssues;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker DT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDropdown cmb_dept;
        private System.Windows.Forms.Label LblError_dept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView grid_selectedLabels;
        private System.Windows.Forms.DataGridView grid_Assignlabels;
    }
}
