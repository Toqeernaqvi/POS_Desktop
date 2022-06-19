namespace SicParvisMagna.Forms.Hospital.Patient
{
    partial class ucPatientBasicInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPatientBasicInfo));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabCountry = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblError_RecordNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_RecordNo = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Date_of_Birth_Picker = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel28 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Age_month = new System.Windows.Forms.TextBox();
            this.lblError_PatientName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combo_Patient_Gender = new System.Windows.Forms.ComboBox();
            this.txt_Age_year = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Patient_Name = new System.Windows.Forms.TextBox();
            this.lblSectionTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridPatient = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.tabCountry.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.txt_search);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnDelete);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(727, 99);
            this.panelToolBox.TabIndex = 20;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(306, 48);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(258, 31);
            this.txt_search.TabIndex = 27;
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
            // tabCountry
            // 
            this.tabCountry.Controls.Add(this.metroTabPage1);
            this.tabCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCountry.Location = new System.Drawing.Point(0, 99);
            this.tabCountry.Name = "tabCountry";
            this.tabCountry.SelectedIndex = 0;
            this.tabCountry.Size = new System.Drawing.Size(727, 595);
            this.tabCountry.TabIndex = 21;
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
            this.metroTabPage1.Size = new System.Drawing.Size(719, 553);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Branches";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.gridPatient);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(719, 553);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblError_RecordNo);
            this.panel4.Controls.Add(this.txt_RecordNo);
            this.panel4.Controls.Add(this.bunifuCustomLabel5);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 46);
            this.panel4.TabIndex = 36;
            // 
            // lblError_RecordNo
            // 
            this.lblError_RecordNo.AutoSize = true;
            this.lblError_RecordNo.BackColor = System.Drawing.Color.Transparent;
            this.lblError_RecordNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_RecordNo.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_RecordNo.Location = new System.Drawing.Point(377, 10);
            this.lblError_RecordNo.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_RecordNo.Name = "lblError_RecordNo";
            this.lblError_RecordNo.Size = new System.Drawing.Size(0, 17);
            this.lblError_RecordNo.TabIndex = 105;
            // 
            // txt_RecordNo
            // 
            this.txt_RecordNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RecordNo.Location = new System.Drawing.Point(159, 10);
            this.txt_RecordNo.MaxLength = 20;
            this.txt_RecordNo.Name = "txt_RecordNo";
            this.txt_RecordNo.Size = new System.Drawing.Size(202, 23);
            this.txt_RecordNo.TabIndex = 103;
            this.txt_RecordNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_RecordNo_KeyDown);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(15, 10);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(119, 17);
            this.bunifuCustomLabel5.TabIndex = 104;
            this.bunifuCustomLabel5.Text = "Patient Record No";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 10);
            this.panel1.TabIndex = 41;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Date_of_Birth_Picker);
            this.panel7.Controls.Add(this.bunifuCustomLabel3);
            this.panel7.Controls.Add(this.bunifuCustomLabel28);
            this.panel7.Controls.Add(this.bunifuCustomLabel4);
            this.panel7.Controls.Add(this.txt_Age_month);
            this.panel7.Controls.Add(this.lblError_PatientName);
            this.panel7.Controls.Add(this.combo_Patient_Gender);
            this.panel7.Controls.Add(this.txt_Age_year);
            this.panel7.Controls.Add(this.bunifuCustomLabel2);
            this.panel7.Controls.Add(this.bunifuCustomLabel1);
            this.panel7.Controls.Add(this.txt_Patient_Name);
            this.panel7.Controls.Add(this.lblSectionTitle);
            this.panel7.Location = new System.Drawing.Point(3, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 202);
            this.panel7.TabIndex = 39;
            // 
            // Date_of_Birth_Picker
            // 
            this.Date_of_Birth_Picker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_of_Birth_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_of_Birth_Picker.Location = new System.Drawing.Point(163, 159);
            this.Date_of_Birth_Picker.Name = "Date_of_Birth_Picker";
            this.Date_of_Birth_Picker.Size = new System.Drawing.Size(202, 23);
            this.Date_of_Birth_Picker.TabIndex = 117;
            this.Date_of_Birth_Picker.ValueChanged += new System.EventHandler(this.Date_of_Birth_Picker_ValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(8, 162);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(132, 17);
            this.bunifuCustomLabel3.TabIndex = 118;
            this.bunifuCustomLabel3.Text = "Patient Date of Birth";
            // 
            // bunifuCustomLabel28
            // 
            this.bunifuCustomLabel28.AutoSize = true;
            this.bunifuCustomLabel28.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel28.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel28.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel28.Location = new System.Drawing.Point(318, 125);
            this.bunifuCustomLabel28.Name = "bunifuCustomLabel28";
            this.bunifuCustomLabel28.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel28.TabIndex = 116;
            this.bunifuCustomLabel28.Text = "Month(s)";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(228, 125);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(48, 17);
            this.bunifuCustomLabel4.TabIndex = 115;
            this.bunifuCustomLabel4.Text = "Year(s)";
            // 
            // txt_Age_month
            // 
            this.txt_Age_month.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Age_month.Location = new System.Drawing.Point(281, 122);
            this.txt_Age_month.MaxLength = 2;
            this.txt_Age_month.Name = "txt_Age_month";
            this.txt_Age_month.Size = new System.Drawing.Size(31, 23);
            this.txt_Age_month.TabIndex = 114;
            this.txt_Age_month.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Age_month_KeyDown);
            // 
            // lblError_PatientName
            // 
            this.lblError_PatientName.AutoSize = true;
            this.lblError_PatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblError_PatientName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_PatientName.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_PatientName.Location = new System.Drawing.Point(380, 14);
            this.lblError_PatientName.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_PatientName.Name = "lblError_PatientName";
            this.lblError_PatientName.Size = new System.Drawing.Size(0, 17);
            this.lblError_PatientName.TabIndex = 113;
            // 
            // combo_Patient_Gender
            // 
            this.combo_Patient_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Patient_Gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Patient_Gender.FormattingEnabled = true;
            this.combo_Patient_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combo_Patient_Gender.Location = new System.Drawing.Point(162, 66);
            this.combo_Patient_Gender.Name = "combo_Patient_Gender";
            this.combo_Patient_Gender.Size = new System.Drawing.Size(202, 25);
            this.combo_Patient_Gender.TabIndex = 108;
            this.combo_Patient_Gender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_Patient_Gender_KeyDown);
            // 
            // txt_Age_year
            // 
            this.txt_Age_year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Age_year.Location = new System.Drawing.Point(162, 122);
            this.txt_Age_year.MaxLength = 3;
            this.txt_Age_year.Name = "txt_Age_year";
            this.txt_Age_year.Size = new System.Drawing.Size(65, 23);
            this.txt_Age_year.TabIndex = 109;
            this.txt_Age_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Age_year_KeyDown);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(58, 122);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 17);
            this.bunifuCustomLabel2.TabIndex = 112;
            this.bunifuCustomLabel2.Text = "Patient Age";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(38, 68);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(99, 17);
            this.bunifuCustomLabel1.TabIndex = 111;
            this.bunifuCustomLabel1.Text = "Patient Gender";
            // 
            // txt_Patient_Name
            // 
            this.txt_Patient_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Patient_Name.Location = new System.Drawing.Point(162, 14);
            this.txt_Patient_Name.MaxLength = 20;
            this.txt_Patient_Name.Name = "txt_Patient_Name";
            this.txt_Patient_Name.Size = new System.Drawing.Size(202, 23);
            this.txt_Patient_Name.TabIndex = 107;
            this.txt_Patient_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Patient_Name_KeyDown);
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionTitle.ForeColor = System.Drawing.Color.Black;
            this.lblSectionTitle.Location = new System.Drawing.Point(49, 14);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(91, 17);
            this.lblSectionTitle.TabIndex = 110;
            this.lblSectionTitle.Text = "Patient Name";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 10);
            this.panel2.TabIndex = 44;
            // 
            // gridPatient
            // 
            this.gridPatient.AllowUserToAddRows = false;
            this.gridPatient.AllowUserToDeleteRows = false;
            this.gridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPatient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPatient.Location = new System.Drawing.Point(3, 295);
            this.gridPatient.Name = "gridPatient";
            this.gridPatient.Size = new System.Drawing.Size(713, 233);
            this.gridPatient.TabIndex = 46;
            this.gridPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPatient_CellClick);
            this.gridPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPatient_CellContentClick);
            // 
            // ucPatientBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCountry);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucPatientBasicInfo";
            this.Size = new System.Drawing.Size(727, 694);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.tabCountry.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatient)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_RecordNo;
        private System.Windows.Forms.TextBox txt_RecordNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel28;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txt_Age_month;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_PatientName;
        private System.Windows.Forms.ComboBox combo_Patient_Gender;
        private System.Windows.Forms.TextBox txt_Age_year;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txt_Patient_Name;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSectionTitle;
        private System.Windows.Forms.DataGridView gridPatient;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DateTimePicker Date_of_Birth_Picker;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}
