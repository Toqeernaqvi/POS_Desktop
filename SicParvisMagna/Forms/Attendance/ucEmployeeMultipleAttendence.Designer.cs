namespace SicParvisMagna.Forms
{
    partial class ucEmployeeMultipleAttendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmployeeMultipleAttendence));
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn6 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMultipleAttendence = new Telerik.WinControls.UI.RadDateTimePicker();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bunifuCustomLabel37 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel36 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbOfficeSection = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel34 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel35 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbDeptOfficce = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel33 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbOrgBranch = new System.Windows.Forms.ComboBox();
            this.cmbOrg = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel32 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel31 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.label36 = new System.Windows.Forms.Label();
            this.gridMultipleAttendence = new Telerik.WinControls.UI.RadGridView();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpMultipleAttendence)).BeginInit();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultipleAttendence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultipleAttendence.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.label1);
            this.panelToolBox.Controls.Add(this.dtpMultipleAttendence);
            this.panelToolBox.Controls.Add(this.panelEmployee);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 149);
            this.panelToolBox.TabIndex = 16;
            this.panelToolBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToolBox_Paint);
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
            this.btnClear.Location = new System.Drawing.Point(135, 1);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 99);
            this.btnClear.TabIndex = 21;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Current Date";
            // 
            // dtpMultipleAttendence
            // 
            this.dtpMultipleAttendence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpMultipleAttendence.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtpMultipleAttendence.Location = new System.Drawing.Point(4, 120);
            this.dtpMultipleAttendence.Name = "dtpMultipleAttendence";
            // 
            // 
            // 
            this.dtpMultipleAttendence.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 164, 20);
            this.dtpMultipleAttendence.RootElement.StretchVertically = true;
            this.dtpMultipleAttendence.Size = new System.Drawing.Size(185, 25);
            this.dtpMultipleAttendence.TabIndex = 19;
            this.dtpMultipleAttendence.TabStop = false;
            this.dtpMultipleAttendence.Text = "Tuesday, May 14, 2019";
            this.dtpMultipleAttendence.Value = new System.DateTime(2019, 5, 14, 4, 0, 55, 636);
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.lblStatus);
            this.panelEmployee.Controls.Add(this.bunifuCustomLabel37);
            this.panelEmployee.Controls.Add(this.bunifuCustomLabel36);
            this.panelEmployee.Controls.Add(this.cmbDept);
            this.panelEmployee.Controls.Add(this.cmbOfficeSection);
            this.panelEmployee.Controls.Add(this.bunifuCustomLabel34);
            this.panelEmployee.Controls.Add(this.bunifuCustomLabel35);
            this.panelEmployee.Controls.Add(this.cmbDeptOfficce);
            this.panelEmployee.Controls.Add(this.bunifuCustomLabel33);
            this.panelEmployee.Controls.Add(this.cmbOrgBranch);
            this.panelEmployee.Controls.Add(this.cmbOrg);
            this.panelEmployee.Controls.Add(this.txtName);
            this.panelEmployee.Controls.Add(this.bunifuCustomLabel32);
            this.panelEmployee.Controls.Add(this.txtReg);
            this.panelEmployee.Controls.Add(this.bunifuCustomLabel31);
            this.panelEmployee.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEmployee.Location = new System.Drawing.Point(195, 0);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(559, 149);
            this.panelEmployee.TabIndex = 16;
            this.panelEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmployee_Paint);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(8, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 21);
            this.lblStatus.TabIndex = 239;
            // 
            // bunifuCustomLabel37
            // 
            this.bunifuCustomLabel37.AutoSize = true;
            this.bunifuCustomLabel37.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel37.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel37.Location = new System.Drawing.Point(262, 43);
            this.bunifuCustomLabel37.Name = "bunifuCustomLabel37";
            this.bunifuCustomLabel37.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel37.TabIndex = 238;
            this.bunifuCustomLabel37.Text = "Dept";
            // 
            // bunifuCustomLabel36
            // 
            this.bunifuCustomLabel36.AutoSize = true;
            this.bunifuCustomLabel36.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel36.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel36.Location = new System.Drawing.Point(247, 106);
            this.bunifuCustomLabel36.Name = "bunifuCustomLabel36";
            this.bunifuCustomLabel36.Size = new System.Drawing.Size(52, 17);
            this.bunifuCustomLabel36.TabIndex = 236;
            this.bunifuCustomLabel36.Text = "Section";
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(305, 39);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(168, 25);
            this.cmbDept.TabIndex = 237;
            this.cmbDept.SelectionChangeCommitted += new System.EventHandler(this.cmbDept_SelectionChangeCommitted);
            // 
            // cmbOfficeSection
            // 
            this.cmbOfficeSection.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbOfficeSection.FormattingEnabled = true;
            this.cmbOfficeSection.Location = new System.Drawing.Point(305, 103);
            this.cmbOfficeSection.Name = "cmbOfficeSection";
            this.cmbOfficeSection.Size = new System.Drawing.Size(168, 25);
            this.cmbOfficeSection.TabIndex = 232;
            // 
            // bunifuCustomLabel34
            // 
            this.bunifuCustomLabel34.AutoSize = true;
            this.bunifuCustomLabel34.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel34.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel34.Location = new System.Drawing.Point(249, 11);
            this.bunifuCustomLabel34.Name = "bunifuCustomLabel34";
            this.bunifuCustomLabel34.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel34.TabIndex = 234;
            this.bunifuCustomLabel34.Text = "Branch";
            // 
            // bunifuCustomLabel35
            // 
            this.bunifuCustomLabel35.AutoSize = true;
            this.bunifuCustomLabel35.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel35.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel35.Location = new System.Drawing.Point(257, 74);
            this.bunifuCustomLabel35.Name = "bunifuCustomLabel35";
            this.bunifuCustomLabel35.Size = new System.Drawing.Size(42, 17);
            this.bunifuCustomLabel35.TabIndex = 235;
            this.bunifuCustomLabel35.Text = "Office";
            // 
            // cmbDeptOfficce
            // 
            this.cmbDeptOfficce.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeptOfficce.FormattingEnabled = true;
            this.cmbDeptOfficce.Location = new System.Drawing.Point(305, 71);
            this.cmbDeptOfficce.Name = "cmbDeptOfficce";
            this.cmbDeptOfficce.Size = new System.Drawing.Size(168, 25);
            this.cmbDeptOfficce.TabIndex = 231;
            this.cmbDeptOfficce.SelectionChangeCommitted += new System.EventHandler(this.cmbDeptOfficce_SelectionChangeCommitted);
            // 
            // bunifuCustomLabel33
            // 
            this.bunifuCustomLabel33.AutoSize = true;
            this.bunifuCustomLabel33.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel33.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel33.Location = new System.Drawing.Point(38, 73);
            this.bunifuCustomLabel33.Name = "bunifuCustomLabel33";
            this.bunifuCustomLabel33.Size = new System.Drawing.Size(31, 17);
            this.bunifuCustomLabel33.TabIndex = 233;
            this.bunifuCustomLabel33.Text = "Org";
            // 
            // cmbOrgBranch
            // 
            this.cmbOrgBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrgBranch.FormattingEnabled = true;
            this.cmbOrgBranch.Location = new System.Drawing.Point(305, 7);
            this.cmbOrgBranch.Name = "cmbOrgBranch";
            this.cmbOrgBranch.Size = new System.Drawing.Size(168, 25);
            this.cmbOrgBranch.TabIndex = 230;
            this.cmbOrgBranch.SelectionChangeCommitted += new System.EventHandler(this.cmbOrgBranch_SelectionChangeCommitted);
            // 
            // cmbOrg
            // 
            this.cmbOrg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrg.FormattingEnabled = true;
            this.cmbOrg.Location = new System.Drawing.Point(75, 71);
            this.cmbOrg.Name = "cmbOrg";
            this.cmbOrg.Size = new System.Drawing.Size(170, 25);
            this.cmbOrg.TabIndex = 227;
            this.cmbOrg.SelectedIndexChanged += new System.EventHandler(this.cmbOrg_SelectedIndexChanged);
            this.cmbOrg.SelectionChangeCommitted += new System.EventHandler(this.cmbOrg_SelectionChangeCommitted);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(75, 40);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 25);
            this.txtName.TabIndex = 225;
            // 
            // bunifuCustomLabel32
            // 
            this.bunifuCustomLabel32.AutoSize = true;
            this.bunifuCustomLabel32.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel32.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel32.Location = new System.Drawing.Point(21, 43);
            this.bunifuCustomLabel32.Name = "bunifuCustomLabel32";
            this.bunifuCustomLabel32.Size = new System.Drawing.Size(48, 17);
            this.bunifuCustomLabel32.TabIndex = 224;
            this.bunifuCustomLabel32.Text = " Name";
            // 
            // txtReg
            // 
            this.txtReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtReg.Location = new System.Drawing.Point(75, 7);
            this.txtReg.Multiline = true;
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(170, 25);
            this.txtReg.TabIndex = 222;
            this.txtReg.TextChanged += new System.EventHandler(this.txtReg_TextChanged);
            // 
            // bunifuCustomLabel31
            // 
            this.bunifuCustomLabel31.AutoSize = true;
            this.bunifuCustomLabel31.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel31.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel31.Location = new System.Drawing.Point(13, 11);
            this.bunifuCustomLabel31.Name = "bunifuCustomLabel31";
            this.bunifuCustomLabel31.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel31.TabIndex = 221;
            this.bunifuCustomLabel31.Text = "Reg No.";
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
            this.btnSearch.Location = new System.Drawing.Point(68, 1);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 99);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnSave.Location = new System.Drawing.Point(1, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 99);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Crimson;
            this.label36.Location = new System.Drawing.Point(573, 132);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(0, 17);
            this.label36.TabIndex = 228;
            // 
            // gridMultipleAttendence
            // 
            this.gridMultipleAttendence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMultipleAttendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMultipleAttendence.Location = new System.Drawing.Point(0, 149);
            // 
            // 
            // 
            this.gridMultipleAttendence.MasterTemplate.AllowAddNewRow = false;
            this.gridMultipleAttendence.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridMultipleAttendence.MasterTemplate.AllowColumnReorder = false;
            this.gridMultipleAttendence.MasterTemplate.AllowDeleteRow = false;
            this.gridMultipleAttendence.MasterTemplate.AutoExpandGroups = true;
            gridViewCheckBoxColumn1.HeaderText = "Select Employees";
            gridViewCheckBoxColumn1.Name = "column1";
            gridViewCheckBoxColumn1.Width = 100;
            gridViewDateTimeColumn1.CustomFormat = "HH:MM :tt";
            gridViewDateTimeColumn1.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn1.FormatString = " hh:mm tt";
            gridViewDateTimeColumn1.HeaderText = "Temp In";
            gridViewDateTimeColumn1.Name = "column9";
            gridViewDateTimeColumn1.Width = 80;
            gridViewDateTimeColumn2.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.FormatString = "  hh:mm tt";
            gridViewDateTimeColumn2.HeaderText = "Temp Out";
            gridViewDateTimeColumn2.Name = "column2";
            gridViewDateTimeColumn2.Width = 80;
            gridViewDateTimeColumn3.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn3.FormatString = "  hh:mm tt";
            gridViewDateTimeColumn3.HeaderText = "In";
            gridViewDateTimeColumn3.Name = "column3";
            gridViewDateTimeColumn3.Width = 80;
            gridViewDateTimeColumn4.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn4.FormatString = "  hh:mm tt";
            gridViewDateTimeColumn4.HeaderText = "Out";
            gridViewDateTimeColumn4.Name = "column4";
            gridViewDateTimeColumn4.Width = 80;
            gridViewDateTimeColumn5.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn5.FormatString = " hh:mm tt";
            gridViewDateTimeColumn5.HeaderText = "Half Leave";
            gridViewDateTimeColumn5.Name = "column5";
            gridViewDateTimeColumn5.Width = 80;
            gridViewDateTimeColumn6.EditorType = Telerik.WinControls.UI.GridViewDateTimeEditorType.TimePicker;
            gridViewDateTimeColumn6.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn6.FormatString = "  hh:mm tt";
            gridViewDateTimeColumn6.HeaderText = "OverTime";
            gridViewDateTimeColumn6.Name = "column6";
            gridViewDateTimeColumn6.Width = 80;
            this.gridMultipleAttendence.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDateTimeColumn3,
            gridViewDateTimeColumn4,
            gridViewDateTimeColumn5,
            gridViewDateTimeColumn6});
            this.gridMultipleAttendence.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridMultipleAttendence.Name = "gridMultipleAttendence";
            // 
            // 
            // 
            this.gridMultipleAttendence.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 240, 150);
            this.gridMultipleAttendence.Size = new System.Drawing.Size(754, 539);
            this.gridMultipleAttendence.TabIndex = 229;
            this.gridMultipleAttendence.Click += new System.EventHandler(this.gridMultipleAttendence_Click);
            // 
            // ucEmployeeMultipleAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridMultipleAttendence);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.label36);
            this.Name = "ucEmployeeMultipleAttendence";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucMultipleEmployeeSalary_Load);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpMultipleAttendence)).EndInit();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultipleAttendence.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultipleAttendence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Panel panelEmployee;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel37;
        private System.Windows.Forms.ComboBox cmbDept;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel36;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel35;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel34;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel33;
        private System.Windows.Forms.ComboBox cmbOfficeSection;
        private System.Windows.Forms.ComboBox cmbDeptOfficce;
        private System.Windows.Forms.ComboBox cmbOrgBranch;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbOrg;
        private System.Windows.Forms.TextBox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel32;
        private System.Windows.Forms.TextBox txtReg;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel31;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Telerik.WinControls.UI.RadGridView gridMultipleAttendence;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpMultipleAttendence;
        private System.Windows.Forms.Label lblStatus;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
    }
}
