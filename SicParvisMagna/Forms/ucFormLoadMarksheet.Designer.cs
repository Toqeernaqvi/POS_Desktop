namespace SicParvisMagna.Forms
{
    partial class ucFormLoadMarksheet
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
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.tabState = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gridloadMarksheet = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlcmbOrganization = new System.Windows.Forms.Panel();
            this.lblError_Org = new System.Windows.Forms.Label();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlcmbBranch = new System.Windows.Forms.Panel();
            this.lblError_Branch = new System.Windows.Forms.Label();
            this.cmbOrganizationBranch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmb_session = new System.Windows.Forms.ComboBox();
            this.lblError_session = new System.Windows.Forms.Label();
            this.Organization = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblError_section = new System.Windows.Forms.Label();
            this.cmb_section = new System.Windows.Forms.ComboBox();
            this.state = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError_Class = new System.Windows.Forms.Label();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblError_sub = new System.Windows.Forms.Label();
            this.cmb_sub = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_load = new System.Windows.Forms.Button();
            this.tabState.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridloadMarksheet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlcmbOrganization.SuspendLayout();
            this.pnlcmbBranch.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(740, 78);
            this.panelToolBox.TabIndex = 22;
            // 
            // tabState
            // 
            this.tabState.Controls.Add(this.metroTabPage1);
            this.tabState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabState.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabState.Location = new System.Drawing.Point(0, 78);
            this.tabState.Name = "tabState";
            this.tabState.SelectedIndex = 0;
            this.tabState.Size = new System.Drawing.Size(740, 603);
            this.tabState.TabIndex = 23;
            this.tabState.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabState.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.gridloadMarksheet);
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 34);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(732, 565);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Load Marksheet";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gridloadMarksheet
            // 
            this.gridloadMarksheet.AllowUserToAddRows = false;
            this.gridloadMarksheet.AllowUserToDeleteRows = false;
            this.gridloadMarksheet.BackgroundColor = System.Drawing.Color.Gray;
            this.gridloadMarksheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridloadMarksheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnUpdate});
            this.gridloadMarksheet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridloadMarksheet.Location = new System.Drawing.Point(0, 386);
            this.gridloadMarksheet.Name = "gridloadMarksheet";
            this.gridloadMarksheet.ReadOnly = true;
            this.gridloadMarksheet.Size = new System.Drawing.Size(732, 179);
            this.gridloadMarksheet.TabIndex = 47;
            this.gridloadMarksheet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridloadMarksheet_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.HeaderText = "Update";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ReadOnly = true;
            this.btnUpdate.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pnlcmbOrganization);
            this.flowLayoutPanel1.Controls.Add(this.pnlcmbBranch);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(732, 565);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // pnlcmbOrganization
            // 
            this.pnlcmbOrganization.Controls.Add(this.lblError_Org);
            this.pnlcmbOrganization.Controls.Add(this.cmbOrganization);
            this.pnlcmbOrganization.Controls.Add(this.label4);
            this.pnlcmbOrganization.Location = new System.Drawing.Point(3, 3);
            this.pnlcmbOrganization.Name = "pnlcmbOrganization";
            this.pnlcmbOrganization.Size = new System.Drawing.Size(548, 51);
            this.pnlcmbOrganization.TabIndex = 47;
            // 
            // lblError_Org
            // 
            this.lblError_Org.AutoSize = true;
            this.lblError_Org.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_Org.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Org.Location = new System.Drawing.Point(376, 12);
            this.lblError_Org.Name = "lblError_Org";
            this.lblError_Org.Size = new System.Drawing.Size(11, 15);
            this.lblError_Org.TabIndex = 232;
            this.lblError_Org.Text = "*";
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(101, 11);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(235, 21);
            this.cmbOrganization.TabIndex = 32;
            this.cmbOrganization.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganization_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 31;
            this.label4.Tag = "Code";
            this.label4.Text = "Organization";
            // 
            // pnlcmbBranch
            // 
            this.pnlcmbBranch.Controls.Add(this.lblError_Branch);
            this.pnlcmbBranch.Controls.Add(this.cmbOrganizationBranch);
            this.pnlcmbBranch.Controls.Add(this.label8);
            this.pnlcmbBranch.Location = new System.Drawing.Point(3, 60);
            this.pnlcmbBranch.Name = "pnlcmbBranch";
            this.pnlcmbBranch.Size = new System.Drawing.Size(548, 51);
            this.pnlcmbBranch.TabIndex = 44;
            // 
            // lblError_Branch
            // 
            this.lblError_Branch.AutoSize = true;
            this.lblError_Branch.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_Branch.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Branch.Location = new System.Drawing.Point(377, 12);
            this.lblError_Branch.Name = "lblError_Branch";
            this.lblError_Branch.Size = new System.Drawing.Size(11, 15);
            this.lblError_Branch.TabIndex = 232;
            this.lblError_Branch.Text = "*";
            // 
            // cmbOrganizationBranch
            // 
            this.cmbOrganizationBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganizationBranch.FormattingEnabled = true;
            this.cmbOrganizationBranch.Location = new System.Drawing.Point(101, 11);
            this.cmbOrganizationBranch.Name = "cmbOrganizationBranch";
            this.cmbOrganizationBranch.Size = new System.Drawing.Size(235, 21);
            this.cmbOrganizationBranch.TabIndex = 32;
            this.cmbOrganizationBranch.SelectionChangeCommitted += new System.EventHandler(this.combo_Branch_SelectionChangeCommitted_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 31;
            this.label8.Tag = "Code";
            this.label8.Text = "Branch";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cmb_session);
            this.panel7.Controls.Add(this.lblError_session);
            this.panel7.Controls.Add(this.Organization);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(3, 117);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 46);
            this.panel7.TabIndex = 45;
            // 
            // cmb_session
            // 
            this.cmb_session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_session.FormattingEnabled = true;
            this.cmb_session.Location = new System.Drawing.Point(101, 15);
            this.cmb_session.Name = "cmb_session";
            this.cmb_session.Size = new System.Drawing.Size(235, 21);
            this.cmb_session.TabIndex = 230;
            this.cmb_session.SelectionChangeCommitted += new System.EventHandler(this.cmb_session_SelectionChangeCommitted);
            // 
            // lblError_session
            // 
            this.lblError_session.AutoSize = true;
            this.lblError_session.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_session.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_session.Location = new System.Drawing.Point(374, 12);
            this.lblError_session.Name = "lblError_session";
            this.lblError_session.Size = new System.Drawing.Size(11, 15);
            this.lblError_session.TabIndex = 229;
            this.lblError_session.Text = "*";
            // 
            // Organization
            // 
            this.Organization.AutoSize = true;
            this.Organization.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Organization.Location = new System.Drawing.Point(11, 15);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(53, 17);
            this.Organization.TabIndex = 40;
            this.Organization.Text = "Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(353, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblError_section);
            this.panel1.Controls.Add(this.cmb_section);
            this.panel1.Controls.Add(this.state);
            this.panel1.Location = new System.Drawing.Point(3, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 46);
            this.panel1.TabIndex = 38;
            // 
            // LblError_section
            // 
            this.LblError_section.AutoSize = true;
            this.LblError_section.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.LblError_section.ForeColor = System.Drawing.Color.Tomato;
            this.LblError_section.Location = new System.Drawing.Point(374, 12);
            this.LblError_section.Name = "LblError_section";
            this.LblError_section.Size = new System.Drawing.Size(11, 15);
            this.LblError_section.TabIndex = 231;
            this.LblError_section.Text = "*";
            // 
            // cmb_section
            // 
            this.cmb_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_section.FormattingEnabled = true;
            this.cmb_section.Location = new System.Drawing.Point(101, 10);
            this.cmb_section.Name = "cmb_section";
            this.cmb_section.Size = new System.Drawing.Size(235, 21);
            this.cmb_section.TabIndex = 231;
            this.cmb_section.SelectionChangeCommitted += new System.EventHandler(this.cmb_section_SelectionChangeCommitted);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.state.Location = new System.Drawing.Point(9, 10);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(52, 17);
            this.state.TabIndex = 40;
            this.state.Text = "Section";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblError_Class);
            this.panel3.Controls.Add(this.comboBox_class);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 51);
            this.panel3.TabIndex = 46;
            // 
            // lblError_Class
            // 
            this.lblError_Class.AutoSize = true;
            this.lblError_Class.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblError_Class.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Class.Location = new System.Drawing.Point(378, 14);
            this.lblError_Class.Name = "lblError_Class";
            this.lblError_Class.Size = new System.Drawing.Size(11, 15);
            this.lblError_Class.TabIndex = 233;
            this.lblError_Class.Text = "*";
            // 
            // comboBox_class
            // 
            this.comboBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(101, 11);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(235, 21);
            this.comboBox_class.TabIndex = 32;
            this.comboBox_class.SelectionChangeCommitted += new System.EventHandler(this.comboBox_class_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 31;
            this.label1.Tag = "Code";
            this.label1.Text = "Class";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblError_sub);
            this.panel4.Controls.Add(this.cmb_sub);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(3, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 51);
            this.panel4.TabIndex = 49;
            // 
            // LblError_sub
            // 
            this.LblError_sub.AutoSize = true;
            this.LblError_sub.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.LblError_sub.ForeColor = System.Drawing.Color.Tomato;
            this.LblError_sub.Location = new System.Drawing.Point(378, 14);
            this.LblError_sub.Name = "LblError_sub";
            this.LblError_sub.Size = new System.Drawing.Size(11, 15);
            this.LblError_sub.TabIndex = 233;
            this.LblError_sub.Text = "*";
            // 
            // cmb_sub
            // 
            this.cmb_sub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sub.FormattingEnabled = true;
            this.cmb_sub.Location = new System.Drawing.Point(101, 11);
            this.cmb_sub.Name = "cmb_sub";
            this.cmb_sub.Size = new System.Drawing.Size(235, 21);
            this.cmb_sub.TabIndex = 32;
            this.cmb_sub.SelectionChangeCommitted += new System.EventHandler(this.cmb_sub_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 31;
            this.label5.Tag = "Code";
            this.label5.Text = "Subjects";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_load);
            this.panel5.Location = new System.Drawing.Point(3, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 51);
            this.panel5.TabIndex = 50;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_load.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_load.Location = new System.Drawing.Point(3, 7);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(187, 36);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load Records";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // ucFormLoadMarksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabState);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucFormLoadMarksheet";
            this.Size = new System.Drawing.Size(740, 681);
            this.Load += new System.EventHandler(this.ucFormLoadMarksheet_Load);
            this.tabState.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridloadMarksheet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlcmbOrganization.ResumeLayout(false);
            this.pnlcmbOrganization.PerformLayout();
            this.pnlcmbBranch.ResumeLayout(false);
            this.pnlcmbBranch.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private MetroFramework.Controls.MetroTabControl tabState;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView gridloadMarksheet;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlcmbOrganization;
        private System.Windows.Forms.Label lblError_Org;
        private System.Windows.Forms.ComboBox cmbOrganization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlcmbBranch;
        private System.Windows.Forms.Label lblError_Branch;
        private System.Windows.Forms.ComboBox cmbOrganizationBranch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cmb_session;
        private System.Windows.Forms.Label lblError_session;
        private System.Windows.Forms.Label Organization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblError_section;
        private System.Windows.Forms.ComboBox cmb_section;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError_Class;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblError_sub;
        private System.Windows.Forms.ComboBox cmb_sub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_load;
    }
}
