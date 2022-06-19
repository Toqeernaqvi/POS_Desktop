namespace SicParvisMagna.Forms
{
    partial class FormPromoteStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPromoteStud));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabCountry = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblError_NewSection = new System.Windows.Forms.Label();
            this.lblError_NewClass = new System.Windows.Forms.Label();
            this.lblError_NewSession = new System.Windows.Forms.Label();
            this.lblError_PreviousSection = new System.Windows.Forms.Label();
            this.lblError_PreviousClass = new System.Windows.Forms.Label();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_NewSection = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_NextClass = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_NextSession = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_PreviousSection = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_PreviousClass = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_PreviousSession = new System.Windows.Forms.ComboBox();
            this.LblError_PreSession = new System.Windows.Forms.Label();
            this.lblError_Name = new System.Windows.Forms.Label();
            this.gridPromoteStud = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.tabCountry.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromoteStud)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 18;
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
            this.btnSearch.Location = new System.Drawing.Point(145, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 99);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.tabCountry.Size = new System.Drawing.Size(754, 559);
            this.tabCountry.TabIndex = 19;
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
            this.metroTabPage1.Size = new System.Drawing.Size(746, 517);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Promote Students";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.gridPromoteStud);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 517);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblError_NewSection);
            this.panel4.Controls.Add(this.lblError_NewClass);
            this.panel4.Controls.Add(this.lblError_NewSession);
            this.panel4.Controls.Add(this.lblError_PreviousSection);
            this.panel4.Controls.Add(this.lblError_PreviousClass);
            this.panel4.Controls.Add(this.bunifuCustomLabel6);
            this.panel4.Controls.Add(this.cbx_NewSection);
            this.panel4.Controls.Add(this.bunifuCustomLabel9);
            this.panel4.Controls.Add(this.cbx_NextClass);
            this.panel4.Controls.Add(this.bunifuCustomLabel11);
            this.panel4.Controls.Add(this.cbx_NextSession);
            this.panel4.Controls.Add(this.bunifuCustomLabel4);
            this.panel4.Controls.Add(this.cbx_PreviousSection);
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Controls.Add(this.cbx_PreviousClass);
            this.panel4.Controls.Add(this.bunifuCustomLabel7);
            this.panel4.Controls.Add(this.cbx_PreviousSession);
            this.panel4.Controls.Add(this.LblError_PreSession);
            this.panel4.Controls.Add(this.lblError_Name);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(726, 197);
            this.panel4.TabIndex = 36;
            // 
            // lblError_NewSection
            // 
            this.lblError_NewSection.AutoSize = true;
            this.lblError_NewSection.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_NewSection.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_NewSection.Location = new System.Drawing.Point(465, 156);
            this.lblError_NewSection.Name = "lblError_NewSection";
            this.lblError_NewSection.Size = new System.Drawing.Size(11, 15);
            this.lblError_NewSection.TabIndex = 256;
            this.lblError_NewSection.Text = "*";
            // 
            // lblError_NewClass
            // 
            this.lblError_NewClass.AutoSize = true;
            this.lblError_NewClass.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_NewClass.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_NewClass.Location = new System.Drawing.Point(465, 106);
            this.lblError_NewClass.Name = "lblError_NewClass";
            this.lblError_NewClass.Size = new System.Drawing.Size(11, 15);
            this.lblError_NewClass.TabIndex = 255;
            this.lblError_NewClass.Text = "*";
            // 
            // lblError_NewSession
            // 
            this.lblError_NewSession.AutoSize = true;
            this.lblError_NewSession.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_NewSession.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_NewSession.Location = new System.Drawing.Point(465, 56);
            this.lblError_NewSession.Name = "lblError_NewSession";
            this.lblError_NewSession.Size = new System.Drawing.Size(11, 15);
            this.lblError_NewSession.TabIndex = 254;
            this.lblError_NewSession.Text = "*";
            // 
            // lblError_PreviousSection
            // 
            this.lblError_PreviousSection.AutoSize = true;
            this.lblError_PreviousSection.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_PreviousSection.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_PreviousSection.Location = new System.Drawing.Point(135, 154);
            this.lblError_PreviousSection.Name = "lblError_PreviousSection";
            this.lblError_PreviousSection.Size = new System.Drawing.Size(11, 15);
            this.lblError_PreviousSection.TabIndex = 253;
            this.lblError_PreviousSection.Text = "*";
            // 
            // lblError_PreviousClass
            // 
            this.lblError_PreviousClass.AutoSize = true;
            this.lblError_PreviousClass.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_PreviousClass.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_PreviousClass.Location = new System.Drawing.Point(135, 104);
            this.lblError_PreviousClass.Name = "lblError_PreviousClass";
            this.lblError_PreviousClass.Size = new System.Drawing.Size(11, 15);
            this.lblError_PreviousClass.TabIndex = 252;
            this.lblError_PreviousClass.Text = "*";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(365, 131);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(83, 17);
            this.bunifuCustomLabel6.TabIndex = 250;
            this.bunifuCustomLabel6.Text = "New Section";
            // 
            // cbx_NewSection
            // 
            this.cbx_NewSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NewSection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NewSection.FormattingEnabled = true;
            this.cbx_NewSection.Location = new System.Drawing.Point(468, 129);
            this.cbx_NewSection.Name = "cbx_NewSection";
            this.cbx_NewSection.Size = new System.Drawing.Size(162, 24);
            this.cbx_NewSection.TabIndex = 251;
            this.cbx_NewSection.SelectionChangeCommitted += new System.EventHandler(this.cbx_NewSection_SelectionChangeCommitted);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(365, 81);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel9.TabIndex = 248;
            this.bunifuCustomLabel9.Text = "New Class";
            // 
            // cbx_NextClass
            // 
            this.cbx_NextClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NextClass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NextClass.FormattingEnabled = true;
            this.cbx_NextClass.Location = new System.Drawing.Point(468, 79);
            this.cbx_NextClass.Name = "cbx_NextClass";
            this.cbx_NextClass.Size = new System.Drawing.Size(162, 24);
            this.cbx_NextClass.TabIndex = 249;
            this.cbx_NextClass.SelectionChangeCommitted += new System.EventHandler(this.cbx_NextClass_SelectionChangeCommitted);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(365, 31);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(84, 17);
            this.bunifuCustomLabel11.TabIndex = 246;
            this.bunifuCustomLabel11.Text = "New Session";
            // 
            // cbx_NextSession
            // 
            this.cbx_NextSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NextSession.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NextSession.FormattingEnabled = true;
            this.cbx_NextSession.Location = new System.Drawing.Point(468, 29);
            this.cbx_NextSession.Name = "cbx_NextSession";
            this.cbx_NextSession.Size = new System.Drawing.Size(162, 24);
            this.cbx_NextSession.TabIndex = 247;
            this.cbx_NextSession.SelectionChangeCommitted += new System.EventHandler(this.cbx_NextSession_SelectionChangeCommitted);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 127);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(108, 17);
            this.bunifuCustomLabel4.TabIndex = 244;
            this.bunifuCustomLabel4.Text = "Previous Section";
            // 
            // cbx_PreviousSection
            // 
            this.cbx_PreviousSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_PreviousSection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PreviousSection.FormattingEnabled = true;
            this.cbx_PreviousSection.Location = new System.Drawing.Point(138, 127);
            this.cbx_PreviousSection.Name = "cbx_PreviousSection";
            this.cbx_PreviousSection.Size = new System.Drawing.Size(176, 24);
            this.cbx_PreviousSection.TabIndex = 245;
            this.cbx_PreviousSection.SelectionChangeCommitted += new System.EventHandler(this.cbx_PreviousSection_SelectionChangeCommitted);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 79);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(94, 17);
            this.bunifuCustomLabel2.TabIndex = 242;
            this.bunifuCustomLabel2.Text = "Previous Class";
            // 
            // cbx_PreviousClass
            // 
            this.cbx_PreviousClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_PreviousClass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PreviousClass.FormattingEnabled = true;
            this.cbx_PreviousClass.Location = new System.Drawing.Point(138, 77);
            this.cbx_PreviousClass.Name = "cbx_PreviousClass";
            this.cbx_PreviousClass.Size = new System.Drawing.Size(176, 24);
            this.cbx_PreviousClass.TabIndex = 243;
            this.cbx_PreviousClass.SelectionChangeCommitted += new System.EventHandler(this.cbx_PreviousClass_SelectionChangeCommitted);
            this.cbx_PreviousClass.SelectedValueChanged += new System.EventHandler(this.cbx_PreviousClass_SelectedValueChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(8, 28);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(109, 17);
            this.bunifuCustomLabel7.TabIndex = 240;
            this.bunifuCustomLabel7.Text = "Previous Session";
            // 
            // cbx_PreviousSession
            // 
            this.cbx_PreviousSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_PreviousSession.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PreviousSession.FormattingEnabled = true;
            this.cbx_PreviousSession.Location = new System.Drawing.Point(138, 27);
            this.cbx_PreviousSession.Name = "cbx_PreviousSession";
            this.cbx_PreviousSession.Size = new System.Drawing.Size(176, 24);
            this.cbx_PreviousSession.TabIndex = 241;
            // 
            // LblError_PreSession
            // 
            this.LblError_PreSession.AutoSize = true;
            this.LblError_PreSession.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.LblError_PreSession.ForeColor = System.Drawing.Color.Tomato;
            this.LblError_PreSession.Location = new System.Drawing.Point(134, 54);
            this.LblError_PreSession.Name = "LblError_PreSession";
            this.LblError_PreSession.Size = new System.Drawing.Size(11, 15);
            this.LblError_PreSession.TabIndex = 239;
            this.LblError_PreSession.Text = "*";
            this.LblError_PreSession.Click += new System.EventHandler(this.lblError_PreviousSession);
            // 
            // lblError_Name
            // 
            this.lblError_Name.AutoSize = true;
            this.lblError_Name.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblError_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lblError_Name.Location = new System.Drawing.Point(172, -3);
            this.lblError_Name.Name = "lblError_Name";
            this.lblError_Name.Size = new System.Drawing.Size(0, 19);
            this.lblError_Name.TabIndex = 238;
            // 
            // gridPromoteStud
            // 
            this.gridPromoteStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPromoteStud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPromoteStud.Location = new System.Drawing.Point(3, 206);
            this.gridPromoteStud.Name = "gridPromoteStud";
            this.gridPromoteStud.Size = new System.Drawing.Size(754, 313);
            this.gridPromoteStud.TabIndex = 41;
            // 
            // FormPromoteStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCountry);
            this.Controls.Add(this.panelToolBox);
            this.Name = "FormPromoteStud";
            this.Size = new System.Drawing.Size(754, 658);
            this.Load += new System.EventHandler(this.FormPromoteStud_Load);
            this.panelToolBox.ResumeLayout(false);
            this.tabCountry.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromoteStud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private MetroFramework.Controls.MetroTabControl tabCountry;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblError_PreSession;
        private System.Windows.Forms.Label lblError_Name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.ComboBox cbx_NewSection;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox cbx_NextClass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.ComboBox cbx_NextSession;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox cbx_PreviousSection;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cbx_PreviousClass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox cbx_PreviousSession;
        private System.Windows.Forms.DataGridView gridPromoteStud;
        private System.Windows.Forms.Label lblError_NewSection;
        private System.Windows.Forms.Label lblError_NewClass;
        private System.Windows.Forms.Label lblError_NewSession;
        private System.Windows.Forms.Label lblError_PreviousSection;
        private System.Windows.Forms.Label lblError_PreviousClass;
    }
}
