namespace SicParvisMagna.Forms.Inventory
{
    partial class ucManageDepartmentClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageDepartmentClasses));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabBranches = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlCmbOrganization = new System.Windows.Forms.Panel();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.Organization = new System.Windows.Forms.Label();
            this.pnlCmbBranch = new System.Windows.Forms.Panel();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridDeptClasses = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.tabBranches.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PnlCmbOrganization.SuspendLayout();
            this.pnlCmbBranch.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeptClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.btnDelete);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 22;
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
            // tabBranches
            // 
            this.tabBranches.Controls.Add(this.metroTabPage1);
            this.tabBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBranches.Location = new System.Drawing.Point(0, 99);
            this.tabBranches.Name = "tabBranches";
            this.tabBranches.SelectedIndex = 0;
            this.tabBranches.Size = new System.Drawing.Size(754, 589);
            this.tabBranches.TabIndex = 23;
            this.tabBranches.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabBranches.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.Controls.Add(this.gridDeptClasses);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 547);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Manage Department Classes";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.PnlCmbOrganization);
            this.flowLayoutPanel1.Controls.Add(this.pnlCmbBranch);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 315);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // PnlCmbOrganization
            // 
            this.PnlCmbOrganization.Controls.Add(this.cmbOrganization);
            this.PnlCmbOrganization.Controls.Add(this.Organization);
            this.PnlCmbOrganization.Location = new System.Drawing.Point(3, 3);
            this.PnlCmbOrganization.Name = "PnlCmbOrganization";
            this.PnlCmbOrganization.Size = new System.Drawing.Size(548, 46);
            this.PnlCmbOrganization.TabIndex = 60;
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(121, 14);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(217, 21);
            this.cmbOrganization.TabIndex = 279;
            this.cmbOrganization.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganization_SelectionChangeCommitted);
            // 
            // Organization
            // 
            this.Organization.AutoSize = true;
            this.Organization.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Organization.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Organization.Location = new System.Drawing.Point(14, 18);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(86, 17);
            this.Organization.TabIndex = 278;
            this.Organization.Text = "Organization";
            // 
            // pnlCmbBranch
            // 
            this.pnlCmbBranch.Controls.Add(this.cmbBranch);
            this.pnlCmbBranch.Controls.Add(this.label1);
            this.pnlCmbBranch.Location = new System.Drawing.Point(3, 55);
            this.pnlCmbBranch.Name = "pnlCmbBranch";
            this.pnlCmbBranch.Size = new System.Drawing.Size(548, 46);
            this.pnlCmbBranch.TabIndex = 61;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(121, 17);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(217, 21);
            this.cmbBranch.TabIndex = 259;
            this.cmbBranch.SelectionChangeCommitted += new System.EventHandler(this.cmbBranch_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 258;
            this.label1.Text = "Branch";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbDepartment);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(3, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 46);
            this.panel4.TabIndex = 58;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(121, 17);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(217, 21);
            this.cmbDepartment.TabIndex = 259;
            this.cmbDepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartment_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 258;
            this.label7.Text = "Department";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbClass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 46);
            this.panel2.TabIndex = 57;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(121, 14);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(217, 21);
            this.cmbClass.TabIndex = 279;
            this.cmbClass.SelectionChangeCommitted += new System.EventHandler(this.cmbClass_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 278;
            this.label3.Text = "Class";
            // 
            // gridDeptClasses
            // 
            this.gridDeptClasses.AllowUserToAddRows = false;
            this.gridDeptClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDeptClasses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridDeptClasses.Location = new System.Drawing.Point(0, 315);
            this.gridDeptClasses.Name = "gridDeptClasses";
            this.gridDeptClasses.Size = new System.Drawing.Size(746, 232);
            this.gridDeptClasses.TabIndex = 58;
            this.gridDeptClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHead_CellClick);
            // 
            // ucManageDepartmentClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabBranches);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucManageDepartmentClasses";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucManageDepartmentClasses_Load);
            this.panelToolBox.ResumeLayout(false);
            this.tabBranches.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PnlCmbOrganization.ResumeLayout(false);
            this.PnlCmbOrganization.PerformLayout();
            this.pnlCmbBranch.ResumeLayout(false);
            this.pnlCmbBranch.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeptClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private MetroFramework.Controls.MetroTabControl tabBranches;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PnlCmbOrganization;
        private System.Windows.Forms.ComboBox cmbOrganization;
        private System.Windows.Forms.Label Organization;
        private System.Windows.Forms.Panel pnlCmbBranch;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridDeptClasses;
    }
}
