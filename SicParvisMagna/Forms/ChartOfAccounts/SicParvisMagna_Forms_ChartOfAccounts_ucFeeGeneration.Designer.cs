namespace SicParvisMagna.Forms
{
    partial class ucFeeGeneration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFeeGeneration));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.dtp_Due = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_Given = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabState = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCmbBranch = new System.Windows.Forms.Panel();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCmbOrganization = new System.Windows.Forms.Panel();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMovLeft = new System.Windows.Forms.Button();
            this.btnMovRight = new System.Windows.Forms.Button();
            this.gridSelHeads = new System.Windows.Forms.DataGridView();
            this.btnFilter = new Bunifu.Framework.UI.BunifuTileButton();
            this.gridHeads = new System.Windows.Forms.DataGridView();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.tabState.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCmbBranch.SuspendLayout();
            this.pnlCmbOrganization.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.dtp_Due);
            this.panelToolBox.Controls.Add(this.label8);
            this.panelToolBox.Controls.Add(this.dtp_Given);
            this.panelToolBox.Controls.Add(this.label9);
            this.panelToolBox.Controls.Add(this.dtp_Date);
            this.panelToolBox.Controls.Add(this.lblDate);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnDelete);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 22;
            this.panelToolBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToolBox_Paint);
            // 
            // dtp_Due
            // 
            this.dtp_Due.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Due.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Due.Location = new System.Drawing.Point(544, 70);
            this.dtp_Due.Name = "dtp_Due";
            this.dtp_Due.Size = new System.Drawing.Size(200, 26);
            this.dtp_Due.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(459, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Due Date";
            // 
            // dtp_Given
            // 
            this.dtp_Given.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Given.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Given.Location = new System.Drawing.Point(544, 38);
            this.dtp_Given.Name = "dtp_Given";
            this.dtp_Given.Size = new System.Drawing.Size(200, 26);
            this.dtp_Given.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(444, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Given Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(544, 6);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 26);
            this.dtp_Date.TabIndex = 38;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(411, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(127, 20);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "Fee Month/Year";
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
            // tabState
            // 
            this.tabState.Controls.Add(this.metroTabPage1);
            this.tabState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabState.Location = new System.Drawing.Point(0, 99);
            this.tabState.Name = "tabState";
            this.tabState.SelectedIndex = 0;
            this.tabState.Size = new System.Drawing.Size(754, 454);
            this.tabState.TabIndex = 24;
            this.tabState.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabState.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 412);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Generate Fee";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 412);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlCmbBranch);
            this.panel2.Controls.Add(this.pnlCmbOrganization);
            this.panel2.Controls.Add(this.cmbType);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbSession);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbClass);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbSection);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbDepartment);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 287);
            this.panel2.TabIndex = 50;
            // 
            // pnlCmbBranch
            // 
            this.pnlCmbBranch.Controls.Add(this.cmbBranch);
            this.pnlCmbBranch.Controls.Add(this.label2);
            this.pnlCmbBranch.Location = new System.Drawing.Point(2, 58);
            this.pnlCmbBranch.Name = "pnlCmbBranch";
            this.pnlCmbBranch.Size = new System.Drawing.Size(342, 38);
            this.pnlCmbBranch.TabIndex = 52;
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(98, 9);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(236, 21);
            this.cmbBranch.TabIndex = 52;
            this.cmbBranch.SelectionChangeCommitted += new System.EventHandler(this.cmbBranch_SelectionChangeCommitted_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(43, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 51;
            this.label2.Tag = "Code";
            this.label2.Text = "Branch";
            // 
            // pnlCmbOrganization
            // 
            this.pnlCmbOrganization.Controls.Add(this.cmbOrganization);
            this.pnlCmbOrganization.Controls.Add(this.label1);
            this.pnlCmbOrganization.Location = new System.Drawing.Point(3, 19);
            this.pnlCmbOrganization.Name = "pnlCmbOrganization";
            this.pnlCmbOrganization.Size = new System.Drawing.Size(342, 38);
            this.pnlCmbOrganization.TabIndex = 51;
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(97, 9);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(236, 21);
            this.cmbOrganization.TabIndex = 50;
            this.cmbOrganization.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganization_SelectionChangeCommitted_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 49;
            this.label1.Tag = "Code";
            this.label1.Text = "Organization";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(100, 219);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(236, 21);
            this.cmbType.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(57, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 39;
            this.label6.Tag = "Code";
            this.label6.Text = "Type";
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(100, 258);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(236, 21);
            this.cmbSession.TabIndex = 38;
            this.cmbSession.SelectionChangeCommitted += new System.EventHandler(this.cmbSession_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(40, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 37;
            this.label7.Tag = "Code";
            this.label7.Text = "Session";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(100, 141);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(236, 21);
            this.cmbClass.TabIndex = 36;
            this.cmbClass.SelectionChangeCommitted += new System.EventHandler(this.cmbClass_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(55, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 35;
            this.label5.Tag = "Code";
            this.label5.Text = "Class";
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(100, 180);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(236, 21);
            this.cmbSection.TabIndex = 34;
            this.cmbSection.SelectionChangeCommitted += new System.EventHandler(this.cmbSection_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(41, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 33;
            this.label3.Tag = "Code";
            this.label3.Text = "Section";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(100, 102);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(236, 21);
            this.cmbDepartment.TabIndex = 32;
            this.cmbDepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartment_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 31;
            this.label4.Tag = "Code";
            this.label4.Text = "Department";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 10);
            this.panel1.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMovLeft);
            this.panel3.Controls.Add(this.btnMovRight);
            this.panel3.Controls.Add(this.gridSelHeads);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.gridHeads);
            this.panel3.Location = new System.Drawing.Point(3, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 175);
            this.panel3.TabIndex = 52;
            // 
            // btnMovLeft
            // 
            this.btnMovLeft.BackColor = System.Drawing.Color.Gray;
            this.btnMovLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovLeft.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMovLeft.Location = new System.Drawing.Point(329, 94);
            this.btnMovLeft.Name = "btnMovLeft";
            this.btnMovLeft.Size = new System.Drawing.Size(63, 38);
            this.btnMovLeft.TabIndex = 39;
            this.btnMovLeft.Text = "<-------";
            this.btnMovLeft.UseVisualStyleBackColor = false;
            this.btnMovLeft.Click += new System.EventHandler(this.btnMovLeft_Click);
            // 
            // btnMovRight
            // 
            this.btnMovRight.BackColor = System.Drawing.Color.Gray;
            this.btnMovRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovRight.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMovRight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMovRight.Location = new System.Drawing.Point(329, 133);
            this.btnMovRight.Name = "btnMovRight";
            this.btnMovRight.Size = new System.Drawing.Size(63, 38);
            this.btnMovRight.TabIndex = 40;
            this.btnMovRight.Text = "--->";
            this.btnMovRight.UseVisualStyleBackColor = false;
            this.btnMovRight.Click += new System.EventHandler(this.btnMovRight_Click);
            // 
            // gridSelHeads
            // 
            this.gridSelHeads.AllowUserToAddRows = false;
            this.gridSelHeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSelHeads.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridSelHeads.Location = new System.Drawing.Point(400, 0);
            this.gridSelHeads.Name = "gridSelHeads";
            this.gridSelHeads.Size = new System.Drawing.Size(320, 175);
            this.gridSelHeads.TabIndex = 1;
            this.gridSelHeads.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnFilter.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImagePosition = 17;
            this.btnFilter.ImageZoom = 40;
            this.btnFilter.LabelPosition = 34;
            this.btnFilter.LabelText = " ";
            this.btnFilter.Location = new System.Drawing.Point(329, 7);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 92);
            this.btnFilter.TabIndex = 43;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // gridHeads
            // 
            this.gridHeads.AllowUserToAddRows = false;
            this.gridHeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHeads.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridHeads.Location = new System.Drawing.Point(0, 0);
            this.gridHeads.Name = "gridHeads";
            this.gridHeads.Size = new System.Drawing.Size(320, 175);
            this.gridHeads.TabIndex = 0;
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToAddRows = false;
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFees.Location = new System.Drawing.Point(0, 553);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.Size = new System.Drawing.Size(754, 135);
            this.dgvFees.TabIndex = 20;
            this.dgvFees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_CellClick);
            this.dgvFees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_CellContentClick);
            this.dgvFees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_CellDoubleClick);
            // 
            // ucFeeGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabState);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.dgvFees);
            this.Name = "ucFeeGeneration";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucFeeGeneration_Load);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.tabState.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCmbBranch.ResumeLayout(false);
            this.pnlCmbBranch.PerformLayout();
            this.pnlCmbOrganization.ResumeLayout(false);
            this.pnlCmbOrganization.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSelHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private System.Windows.Forms.DateTimePicker dtp_Due;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_Given;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lblDate;
        private MetroFramework.Controls.MetroTabControl tabState;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMovLeft;
        private System.Windows.Forms.Button btnMovRight;
        private System.Windows.Forms.DataGridView gridSelHeads;
        private System.Windows.Forms.DataGridView gridHeads;
        private Bunifu.Framework.UI.BunifuTileButton btnFilter;
        private System.Windows.Forms.Panel pnlCmbOrganization;
        private System.Windows.Forms.ComboBox cmbOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCmbBranch;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label2;
    }
}
