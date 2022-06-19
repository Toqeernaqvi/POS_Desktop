namespace SicParvisMagna.Forms
{
    partial class ucManualAttendenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManualAttendenceForm));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabState = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError_Session = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_section = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_class = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlCmbBranch = new System.Windows.Forms.Panel();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCmbOrganization = new System.Windows.Forms.Panel();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbtn_leave = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbtn_absent = new System.Windows.Forms.RadioButton();
            this.rdbtn_present = new System.Windows.Forms.RadioButton();
            this.rdbtn_all = new System.Windows.Forms.RadioButton();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLeaves = new System.Windows.Forms.Label();
            this.lblAbsentees = new System.Windows.Forms.Label();
            this.lblPresents = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_Attendance = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.tabState.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCmbBranch.SuspendLayout();
            this.pnlCmbOrganization.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Attendance)).BeginInit();
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
            this.tabState.Size = new System.Drawing.Size(754, 589);
            this.tabState.TabIndex = 26;
            this.tabState.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabState.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.Controls.Add(this.dataGridView_Attendance);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 547);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Student Manual Attendence";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 397);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblError_Session);
            this.panel1.Controls.Add(this.lblError_section);
            this.panel1.Controls.Add(this.lblError_class);
            this.panel1.Controls.Add(this.pnlCmbBranch);
            this.panel1.Controls.Add(this.pnlCmbOrganization);
            this.panel1.Controls.Add(this.cmbSession);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbClass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbSection);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbDepartment);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 252);
            this.panel1.TabIndex = 51;
            // 
            // lblError_Session
            // 
            this.lblError_Session.AutoSize = true;
            this.lblError_Session.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Session.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Session.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Session.Location = new System.Drawing.Point(358, 135);
            this.lblError_Session.Name = "lblError_Session";
            this.lblError_Session.Size = new System.Drawing.Size(0, 20);
            this.lblError_Session.TabIndex = 65;
            // 
            // lblError_section
            // 
            this.lblError_section.AutoSize = true;
            this.lblError_section.BackColor = System.Drawing.Color.Transparent;
            this.lblError_section.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_section.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_section.Location = new System.Drawing.Point(346, 217);
            this.lblError_section.Name = "lblError_section";
            this.lblError_section.Size = new System.Drawing.Size(0, 20);
            this.lblError_section.TabIndex = 64;
            // 
            // lblError_class
            // 
            this.lblError_class.AutoSize = true;
            this.lblError_class.BackColor = System.Drawing.Color.Transparent;
            this.lblError_class.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_class.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_class.Location = new System.Drawing.Point(344, 177);
            this.lblError_class.Name = "lblError_class";
            this.lblError_class.Size = new System.Drawing.Size(0, 20);
            this.lblError_class.TabIndex = 63;
            // 
            // pnlCmbBranch
            // 
            this.pnlCmbBranch.Controls.Add(this.cmbBranch);
            this.pnlCmbBranch.Controls.Add(this.label2);
            this.pnlCmbBranch.Location = new System.Drawing.Point(6, 45);
            this.pnlCmbBranch.Name = "pnlCmbBranch";
            this.pnlCmbBranch.Size = new System.Drawing.Size(389, 38);
            this.pnlCmbBranch.TabIndex = 62;
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(96, 9);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(236, 21);
            this.cmbBranch.TabIndex = 52;
            this.cmbBranch.SelectionChangeCommitted += new System.EventHandler(this.cmbBranch_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(44, 9);
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
            this.pnlCmbOrganization.Location = new System.Drawing.Point(7, 6);
            this.pnlCmbOrganization.Name = "pnlCmbOrganization";
            this.pnlCmbOrganization.Size = new System.Drawing.Size(388, 38);
            this.pnlCmbOrganization.TabIndex = 61;
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(95, 11);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(236, 21);
            this.cmbOrganization.TabIndex = 50;
            this.cmbOrganization.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganization_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 49;
            this.label1.Tag = "Code";
            this.label1.Text = "Organization";
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(102, 137);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(236, 21);
            this.cmbSession.TabIndex = 58;
            this.cmbSession.SelectionChangeCommitted += new System.EventHandler(this.cmbSession_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(41, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 57;
            this.label7.Tag = "Code";
            this.label7.Text = "Session";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(102, 176);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(236, 21);
            this.cmbClass.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(56, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 55;
            this.label5.Tag = "Code";
            this.label5.Text = "Class";
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(102, 215);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(236, 21);
            this.cmbSection.TabIndex = 54;
            this.cmbSection.DropDown += new System.EventHandler(this.cmbSection_DropDown);
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            this.cmbSection.SelectionChangeCommitted += new System.EventHandler(this.cmbSection_SelectionChangeCommitted_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(42, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 53;
            this.label3.Tag = "Code";
            this.label3.Text = "Section";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(102, 92);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(236, 21);
            this.cmbDepartment.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 51;
            this.label4.Tag = "Code";
            this.label4.Text = "Department";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 10);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbtn_leave);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.rdbtn_absent);
            this.panel3.Controls.Add(this.rdbtn_present);
            this.panel3.Controls.Add(this.rdbtn_all);
            this.panel3.Controls.Add(this.dtp_Date);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblLeaves);
            this.panel3.Controls.Add(this.lblAbsentees);
            this.panel3.Controls.Add(this.lblPresents);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(3, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 118);
            this.panel3.TabIndex = 54;
            // 
            // rdbtn_leave
            // 
            this.rdbtn_leave.AutoSize = true;
            this.rdbtn_leave.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbtn_leave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_leave.Location = new System.Drawing.Point(446, 83);
            this.rdbtn_leave.Name = "rdbtn_leave";
            this.rdbtn_leave.Size = new System.Drawing.Size(100, 24);
            this.rdbtn_leave.TabIndex = 82;
            this.rdbtn_leave.TabStop = true;
            this.rdbtn_leave.Text = "On Leave";
            this.rdbtn_leave.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(220, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 81;
            this.label10.Text = "SMS Type :";
            // 
            // rdbtn_absent
            // 
            this.rdbtn_absent.AutoSize = true;
            this.rdbtn_absent.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbtn_absent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_absent.Location = new System.Drawing.Point(446, 55);
            this.rdbtn_absent.Name = "rdbtn_absent";
            this.rdbtn_absent.Size = new System.Drawing.Size(78, 24);
            this.rdbtn_absent.TabIndex = 80;
            this.rdbtn_absent.TabStop = true;
            this.rdbtn_absent.Text = "Absent";
            this.rdbtn_absent.UseVisualStyleBackColor = true;
            // 
            // rdbtn_present
            // 
            this.rdbtn_present.AutoSize = true;
            this.rdbtn_present.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbtn_present.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_present.Location = new System.Drawing.Point(307, 83);
            this.rdbtn_present.Name = "rdbtn_present";
            this.rdbtn_present.Size = new System.Drawing.Size(81, 24);
            this.rdbtn_present.TabIndex = 79;
            this.rdbtn_present.TabStop = true;
            this.rdbtn_present.Text = "Present";
            this.rdbtn_present.UseVisualStyleBackColor = true;
            // 
            // rdbtn_all
            // 
            this.rdbtn_all.AutoSize = true;
            this.rdbtn_all.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbtn_all.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_all.Location = new System.Drawing.Point(307, 55);
            this.rdbtn_all.Name = "rdbtn_all";
            this.rdbtn_all.Size = new System.Drawing.Size(97, 24);
            this.rdbtn_all.TabIndex = 78;
            this.rdbtn_all.TabStop = true;
            this.rdbtn_all.Text = "All Active";
            this.rdbtn_all.UseVisualStyleBackColor = true;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(324, 9);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 26);
            this.dtp_Date.TabIndex = 77;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(181, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(137, 18);
            this.lblDate.TabIndex = 76;
            this.lblDate.Text = "Attendance Day :";
            // 
            // lblLeaves
            // 
            this.lblLeaves.AutoSize = true;
            this.lblLeaves.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLeaves.Location = new System.Drawing.Point(106, 77);
            this.lblLeaves.Name = "lblLeaves";
            this.lblLeaves.Size = new System.Drawing.Size(0, 20);
            this.lblLeaves.TabIndex = 75;
            // 
            // lblAbsentees
            // 
            this.lblAbsentees.AutoSize = true;
            this.lblAbsentees.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsentees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAbsentees.Location = new System.Drawing.Point(106, 43);
            this.lblAbsentees.Name = "lblAbsentees";
            this.lblAbsentees.Size = new System.Drawing.Size(0, 20);
            this.lblAbsentees.TabIndex = 74;
            // 
            // lblPresents
            // 
            this.lblPresents.AutoSize = true;
            this.lblPresents.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPresents.Location = new System.Drawing.Point(106, 9);
            this.lblPresents.Name = "lblPresents";
            this.lblPresents.Size = new System.Drawing.Size(0, 20);
            this.lblPresents.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(30, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Leaves :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "Absentees :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(19, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Presents : ";
            // 
            // dataGridView_Attendance
            // 
            this.dataGridView_Attendance.AllowUserToAddRows = false;
            this.dataGridView_Attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Attendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Attendance.Location = new System.Drawing.Point(0, 397);
            this.dataGridView_Attendance.Name = "dataGridView_Attendance";
            this.dataGridView_Attendance.Size = new System.Drawing.Size(746, 150);
            this.dataGridView_Attendance.TabIndex = 55;
            this.dataGridView_Attendance.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Attendance_CellEndEdit);
            this.dataGridView_Attendance.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Attendance_CellEnter_1);
            this.dataGridView_Attendance.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Attendance_CellLeave);
            // 
            // ucManualAttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabState);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucManualAttendenceForm";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucManualAttendenceForm_Load);
            this.panelToolBox.ResumeLayout(false);
            this.tabState.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCmbBranch.ResumeLayout(false);
            this.pnlCmbBranch.PerformLayout();
            this.pnlCmbOrganization.ResumeLayout(false);
            this.pnlCmbOrganization.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Attendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private MetroFramework.Controls.MetroTabControl tabState;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCmbBranch;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCmbOrganization;
        private System.Windows.Forms.ComboBox cmbOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbtn_leave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbtn_absent;
        private System.Windows.Forms.RadioButton rdbtn_present;
        private System.Windows.Forms.RadioButton rdbtn_all;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLeaves;
        private System.Windows.Forms.Label lblAbsentees;
        private System.Windows.Forms.Label lblPresents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_Attendance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_Session;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_section;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_class;
    }
}
