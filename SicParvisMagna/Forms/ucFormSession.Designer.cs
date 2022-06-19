namespace SicParvisMagna.Forms
{
    partial class ucFormSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFormSession));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabState = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gridSessions = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblError_Org = new System.Windows.Forms.Label();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblError_Branch = new System.Windows.Forms.Label();
            this.cmbOrganizationBranch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LlblError_class = new System.Windows.Forms.Label();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblError_ClassTitle = new System.Windows.Forms.Label();
            this.txtbSession_Name = new System.Windows.Forms.TextBox();
            this.lbl_sess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_urdu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelToolBox.SuspendLayout();
            this.tabState.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSessions)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.lblStatus);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnDelete);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 21;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblStatus.ForeColor = System.Drawing.Color.Tomato;
            this.lblStatus.Location = new System.Drawing.Point(349, 81);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(11, 15);
            this.lblStatus.TabIndex = 233;
            this.lblStatus.Text = "*";
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
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
            // tabState
            // 
            this.tabState.Controls.Add(this.metroTabPage1);
            this.tabState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabState.Location = new System.Drawing.Point(0, 99);
            this.tabState.Name = "tabState";
            this.tabState.SelectedIndex = 0;
            this.tabState.Size = new System.Drawing.Size(754, 589);
            this.tabState.TabIndex = 22;
            this.tabState.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabState.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.gridSessions);
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 547);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Add Sessions";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gridSessions
            // 
            this.gridSessions.AllowUserToAddRows = false;
            this.gridSessions.AllowUserToDeleteRows = false;
            this.gridSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSessions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSessions.Location = new System.Drawing.Point(0, 329);
            this.gridSessions.Name = "gridSessions";
            this.gridSessions.Size = new System.Drawing.Size(746, 218);
            this.gridSessions.TabIndex = 47;
            this.gridSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSession_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 547);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblError_Org);
            this.panel2.Controls.Add(this.cmbOrganization);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 51);
            this.panel2.TabIndex = 50;
            // 
            // lblError_Org
            // 
            this.lblError_Org.AutoSize = true;
            this.lblError_Org.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_Org.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Org.Location = new System.Drawing.Point(342, 16);
            this.lblError_Org.Name = "lblError_Org";
            this.lblError_Org.Size = new System.Drawing.Size(11, 15);
            this.lblError_Org.TabIndex = 232;
            this.lblError_Org.Text = "*";
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(100, 10);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(236, 21);
            this.cmbOrganization.TabIndex = 32;
            this.cmbOrganization.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganization_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 31;
            this.label4.Tag = "Code";
            this.label4.Text = "Organization";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblError_Branch);
            this.panel6.Controls.Add(this.cmbOrganizationBranch);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(3, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 51);
            this.panel6.TabIndex = 48;
            // 
            // lblError_Branch
            // 
            this.lblError_Branch.AutoSize = true;
            this.lblError_Branch.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_Branch.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Branch.Location = new System.Drawing.Point(342, 12);
            this.lblError_Branch.Name = "lblError_Branch";
            this.lblError_Branch.Size = new System.Drawing.Size(11, 15);
            this.lblError_Branch.TabIndex = 232;
            this.lblError_Branch.Text = "*";
            // 
            // cmbOrganizationBranch
            // 
            this.cmbOrganizationBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganizationBranch.FormattingEnabled = true;
            this.cmbOrganizationBranch.Location = new System.Drawing.Point(100, 10);
            this.cmbOrganizationBranch.Name = "cmbOrganizationBranch";
            this.cmbOrganizationBranch.Size = new System.Drawing.Size(236, 21);
            this.cmbOrganizationBranch.TabIndex = 32;
            this.cmbOrganizationBranch.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganizationBranch_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 31;
            this.label8.Tag = "Code";
            this.label8.Text = "Branch";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LlblError_class);
            this.panel1.Controls.Add(this.cmb_class);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 51);
            this.panel1.TabIndex = 51;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LlblError_class
            // 
            this.LlblError_class.AutoSize = true;
            this.LlblError_class.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.LlblError_class.ForeColor = System.Drawing.Color.Tomato;
            this.LlblError_class.Location = new System.Drawing.Point(342, 12);
            this.LlblError_class.Name = "LlblError_class";
            this.LlblError_class.Size = new System.Drawing.Size(11, 15);
            this.LlblError_class.TabIndex = 232;
            this.LlblError_class.Text = "*";
            // 
            // cmb_class
            // 
            this.cmb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(100, 10);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(236, 21);
            this.cmb_class.TabIndex = 32;
            this.cmb_class.SelectionChangeCommitted += new System.EventHandler(this.cmb_class_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 31;
            this.label3.Tag = "Code";
            this.label3.Text = "Class";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblError_ClassTitle);
            this.panel7.Controls.Add(this.txtbSession_Name);
            this.panel7.Controls.Add(this.lbl_sess);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(3, 174);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 56);
            this.panel7.TabIndex = 45;
            // 
            // lblError_ClassTitle
            // 
            this.lblError_ClassTitle.AutoSize = true;
            this.lblError_ClassTitle.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_ClassTitle.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_ClassTitle.Location = new System.Drawing.Point(346, 12);
            this.lblError_ClassTitle.Name = "lblError_ClassTitle";
            this.lblError_ClassTitle.Size = new System.Drawing.Size(11, 15);
            this.lblError_ClassTitle.TabIndex = 229;
            this.lblError_ClassTitle.Text = "*";
            // 
            // txtbSession_Name
            // 
            this.txtbSession_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSession_Name.Location = new System.Drawing.Point(95, 12);
            this.txtbSession_Name.MaxLength = 20;
            this.txtbSession_Name.Name = "txtbSession_Name";
            this.txtbSession_Name.Size = new System.Drawing.Size(249, 27);
            this.txtbSession_Name.TabIndex = 226;
            // 
            // lbl_sess
            // 
            this.lbl_sess.AutoSize = true;
            this.lbl_sess.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_sess.Location = new System.Drawing.Point(18, 15);
            this.lbl_sess.Name = "lbl_sess";
            this.lbl_sess.Size = new System.Drawing.Size(33, 17);
            this.lbl_sess.TabIndex = 40;
            this.lbl_sess.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(357, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_urdu);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 56);
            this.panel3.TabIndex = 52;
            // 
            // txt_urdu
            // 
            this.txt_urdu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_urdu.Location = new System.Drawing.Point(91, 12);
            this.txt_urdu.MaxLength = 20;
            this.txt_urdu.Name = "txt_urdu";
            this.txt_urdu.Size = new System.Drawing.Size(249, 27);
            this.txt_urdu.TabIndex = 226;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Urdu Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(353, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 39;
            // 
            // ucFormSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabState);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucFormSession";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucAddClasses_Load);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.tabState.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSessions)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_sess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridSessions;
        private System.Windows.Forms.TextBox txtbSession_Name;
        private System.Windows.Forms.Label lblError_ClassTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblError_Org;
        private System.Windows.Forms.ComboBox cmbOrganization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblError_Branch;
        private System.Windows.Forms.ComboBox cmbOrganizationBranch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LlblError_class;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_urdu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
