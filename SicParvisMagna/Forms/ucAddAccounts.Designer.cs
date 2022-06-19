namespace SicParvisMagna.Forms
{
    partial class ucAddAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddAccounts));
            this.gridAccounts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorAccountTitle = new System.Windows.Forms.Label();
            this.txtAccountTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccountTypes = new MetroFramework.Controls.MetroTabControl();
            this.tabUserAccounts = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chkBx_Edit = new System.Windows.Forms.CheckBox();
            this.chkBx_View = new System.Windows.Forms.CheckBox();
            this.chkBx_Del = new System.Windows.Forms.CheckBox();
            this.chkBx_Add = new System.Windows.Forms.CheckBox();
            this.chkBx_SelectAll = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Account = new System.Windows.Forms.ComboBox();
            this.gridPermission = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblErrorExpertiesTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpertiesTitle = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gridExperties = new System.Windows.Forms.DataGridView();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabAccountTypes.SuspendLayout();
            this.tabUserAccounts.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPermission)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExperties)).BeginInit();
            this.panelToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAccounts
            // 
            this.gridAccounts.AllowUserToAddRows = false;
            this.gridAccounts.AllowUserToDeleteRows = false;
            this.gridAccounts.AllowUserToOrderColumns = true;
            this.gridAccounts.AllowUserToResizeColumns = false;
            this.gridAccounts.AllowUserToResizeRows = false;
            this.gridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAccounts.Location = new System.Drawing.Point(0, 302);
            this.gridAccounts.Name = "gridAccounts";
            this.gridAccounts.Size = new System.Drawing.Size(746, 245);
            this.gridAccounts.TabIndex = 19;
            this.gridAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAccounts_CellClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 1);
            this.panel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorAccountTitle);
            this.panel1.Controls.Add(this.txtAccountTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 46);
            this.panel1.TabIndex = 31;
            // 
            // lblErrorAccountTitle
            // 
            this.lblErrorAccountTitle.AutoSize = true;
            this.lblErrorAccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.lblErrorAccountTitle.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorAccountTitle.Location = new System.Drawing.Point(301, 6);
            this.lblErrorAccountTitle.Name = "lblErrorAccountTitle";
            this.lblErrorAccountTitle.Size = new System.Drawing.Size(11, 13);
            this.lblErrorAccountTitle.TabIndex = 224;
            this.lblErrorAccountTitle.Text = "*";
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountTitle.Location = new System.Drawing.Point(96, 10);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(202, 25);
            this.txtAccountTitle.TabIndex = 223;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 211;
            this.label1.Text = "Account Title";
            // 
            // tabAccountTypes
            // 
            this.tabAccountTypes.Controls.Add(this.tabUserAccounts);
            this.tabAccountTypes.Controls.Add(this.metroTabPage1);
            this.tabAccountTypes.Controls.Add(this.metroTabPage2);
            this.tabAccountTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAccountTypes.Location = new System.Drawing.Point(0, 99);
            this.tabAccountTypes.Name = "tabAccountTypes";
            this.tabAccountTypes.SelectedIndex = 2;
            this.tabAccountTypes.Size = new System.Drawing.Size(754, 589);
            this.tabAccountTypes.TabIndex = 17;
            this.tabAccountTypes.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabAccountTypes.UseSelectable = true;
            this.tabAccountTypes.SelectedIndexChanged += new System.EventHandler(this.tabAccountTypes_SelectedIndexChanged);
            // 
            // tabUserAccounts
            // 
            this.tabUserAccounts.Controls.Add(this.flowLayoutPanel);
            this.tabUserAccounts.Controls.Add(this.gridAccounts);
            this.tabUserAccounts.HorizontalScrollbarBarColor = true;
            this.tabUserAccounts.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUserAccounts.HorizontalScrollbarSize = 10;
            this.tabUserAccounts.Location = new System.Drawing.Point(4, 38);
            this.tabUserAccounts.Name = "tabUserAccounts";
            this.tabUserAccounts.Size = new System.Drawing.Size(746, 547);
            this.tabUserAccounts.TabIndex = 0;
            this.tabUserAccounts.Text = "User Accounts";
            this.tabUserAccounts.VerticalScrollbarBarColor = true;
            this.tabUserAccounts.VerticalScrollbarHighlightOnWheel = false;
            this.tabUserAccounts.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.panel1);
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Controls.Add(this.panel5);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(746, 302);
            this.flowLayoutPanel.TabIndex = 18;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtDescription);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 153);
            this.panel5.TabIndex = 33;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(96, 11);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(217, 108);
            this.txtDescription.TabIndex = 213;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 212;
            this.label3.Text = "Description";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel8);
            this.metroTabPage1.Controls.Add(this.gridPermission);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 547);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Role Permissions";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.chkBx_Edit);
            this.panel8.Controls.Add(this.chkBx_View);
            this.panel8.Controls.Add(this.chkBx_Del);
            this.panel8.Controls.Add(this.chkBx_Add);
            this.panel8.Controls.Add(this.chkBx_SelectAll);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.cbx_Account);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(746, 128);
            this.panel8.TabIndex = 263;
            // 
            // chkBx_Edit
            // 
            this.chkBx_Edit.AutoSize = true;
            this.chkBx_Edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_Edit.Location = new System.Drawing.Point(148, 74);
            this.chkBx_Edit.Name = "chkBx_Edit";
            this.chkBx_Edit.Size = new System.Drawing.Size(105, 23);
            this.chkBx_Edit.TabIndex = 261;
            this.chkBx_Edit.Text = "Select Edit";
            this.chkBx_Edit.UseVisualStyleBackColor = true;
            this.chkBx_Edit.CheckStateChanged += new System.EventHandler(this.chkBx_Edit_CheckStateChanged);
            // 
            // chkBx_View
            // 
            this.chkBx_View.AutoSize = true;
            this.chkBx_View.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_View.Location = new System.Drawing.Point(276, 74);
            this.chkBx_View.Name = "chkBx_View";
            this.chkBx_View.Size = new System.Drawing.Size(116, 23);
            this.chkBx_View.TabIndex = 260;
            this.chkBx_View.Text = "Select View";
            this.chkBx_View.UseVisualStyleBackColor = true;
            this.chkBx_View.CheckedChanged += new System.EventHandler(this.chkBx_View_CheckedChanged_1);
            // 
            // chkBx_Del
            // 
            this.chkBx_Del.AutoSize = true;
            this.chkBx_Del.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_Del.Location = new System.Drawing.Point(411, 74);
            this.chkBx_Del.Name = "chkBx_Del";
            this.chkBx_Del.Size = new System.Drawing.Size(103, 23);
            this.chkBx_Del.TabIndex = 259;
            this.chkBx_Del.Text = "Select Del";
            this.chkBx_Del.UseVisualStyleBackColor = true;
            this.chkBx_Del.CheckedChanged += new System.EventHandler(this.chkBx_Del_CheckedChanged_1);
            // 
            // chkBx_Add
            // 
            this.chkBx_Add.AutoSize = true;
            this.chkBx_Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_Add.Location = new System.Drawing.Point(19, 74);
            this.chkBx_Add.Name = "chkBx_Add";
            this.chkBx_Add.Size = new System.Drawing.Size(112, 23);
            this.chkBx_Add.TabIndex = 258;
            this.chkBx_Add.Text = "Select Add";
            this.chkBx_Add.UseVisualStyleBackColor = true;
            this.chkBx_Add.CheckedChanged += new System.EventHandler(this.chkBx_Add_CheckedChanged_1);
            // 
            // chkBx_SelectAll
            // 
            this.chkBx_SelectAll.AutoSize = true;
            this.chkBx_SelectAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_SelectAll.Location = new System.Drawing.Point(619, 25);
            this.chkBx_SelectAll.Name = "chkBx_SelectAll";
            this.chkBx_SelectAll.Size = new System.Drawing.Size(98, 23);
            this.chkBx_SelectAll.TabIndex = 257;
            this.chkBx_SelectAll.Text = "Select All";
            this.chkBx_SelectAll.UseVisualStyleBackColor = true;
            this.chkBx_SelectAll.CheckedChanged += new System.EventHandler(this.chkBx_SelectAll_CheckedChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(46, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 247;
            this.label5.Text = "Roles";
            // 
            // cbx_Account
            // 
            this.cbx_Account.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbx_Account.FormattingEnabled = true;
            this.cbx_Account.Location = new System.Drawing.Point(113, 21);
            this.cbx_Account.Name = "cbx_Account";
            this.cbx_Account.Size = new System.Drawing.Size(217, 25);
            this.cbx_Account.TabIndex = 248;
            this.cbx_Account.SelectionChangeCommitted += new System.EventHandler(this.cbx_Account_SelectionChangeCommitted_1);
            // 
            // gridPermission
            // 
            this.gridPermission.AllowUserToAddRows = false;
            this.gridPermission.AllowUserToDeleteRows = false;
            this.gridPermission.AllowUserToResizeColumns = false;
            this.gridPermission.AllowUserToResizeRows = false;
            this.gridPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPermission.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPermission.Location = new System.Drawing.Point(0, 147);
            this.gridPermission.Name = "gridPermission";
            this.gridPermission.Size = new System.Drawing.Size(746, 400);
            this.gridPermission.TabIndex = 262;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage2.Controls.Add(this.gridExperties);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 547);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Add User Experties";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 223);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblErrorExpertiesTitle);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtExpertiesTitle);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 46);
            this.panel3.TabIndex = 31;
            // 
            // lblErrorExpertiesTitle
            // 
            this.lblErrorExpertiesTitle.AutoSize = true;
            this.lblErrorExpertiesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.lblErrorExpertiesTitle.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorExpertiesTitle.Location = new System.Drawing.Point(339, 4);
            this.lblErrorExpertiesTitle.Name = "lblErrorExpertiesTitle";
            this.lblErrorExpertiesTitle.Size = new System.Drawing.Size(11, 13);
            this.lblErrorExpertiesTitle.TabIndex = 224;
            this.lblErrorExpertiesTitle.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 223;
            this.label2.Text = "Experties Title";
            // 
            // txtExpertiesTitle
            // 
            this.txtExpertiesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpertiesTitle.Location = new System.Drawing.Point(121, 16);
            this.txtExpertiesTitle.Name = "txtExpertiesTitle";
            this.txtExpertiesTitle.Size = new System.Drawing.Size(217, 25);
            this.txtExpertiesTitle.TabIndex = 222;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 1);
            this.panel4.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 155);
            this.panel6.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 108);
            this.textBox1.TabIndex = 223;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(24, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 222;
            this.label4.Text = "Description";
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 223);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 46);
            this.panel7.TabIndex = 35;
            // 
            // gridExperties
            // 
            this.gridExperties.AllowUserToAddRows = false;
            this.gridExperties.AllowUserToDeleteRows = false;
            this.gridExperties.AllowUserToResizeColumns = false;
            this.gridExperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridExperties.Location = new System.Drawing.Point(0, 223);
            this.gridExperties.Name = "gridExperties";
            this.gridExperties.Size = new System.Drawing.Size(746, 324);
            this.gridExperties.TabIndex = 42;
            this.gridExperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridExperties_CellClick_1);
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
            this.panelToolBox.TabIndex = 16;
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
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucAddAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabAccountTypes);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucAddAccounts";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucAddAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabAccountTypes.ResumeLayout(false);
            this.tabUserAccounts.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPermission)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExperties)).EndInit();
            this.panelToolBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAccounts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tabAccountTypes;
        private MetroFramework.Controls.MetroTabPage tabUserAccounts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Label lblErrorAccountTitle;
        private System.Windows.Forms.TextBox txtAccountTitle;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox chkBx_Edit;
        private System.Windows.Forms.CheckBox chkBx_View;
        private System.Windows.Forms.CheckBox chkBx_Del;
        private System.Windows.Forms.CheckBox chkBx_Add;
        private System.Windows.Forms.CheckBox chkBx_SelectAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Account;
        private System.Windows.Forms.DataGridView gridPermission;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblErrorExpertiesTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpertiesTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView gridExperties;
    }
}
