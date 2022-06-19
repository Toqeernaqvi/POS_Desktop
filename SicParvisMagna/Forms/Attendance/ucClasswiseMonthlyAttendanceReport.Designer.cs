namespace SicParvisMagna.Forms.Attendance
{
    partial class ucClasswiseMonthlyAttendanceReport
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
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
            this.btn_LoadREcords = new Telerik.WinControls.UI.RadButton();
            this.panelToolBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCmbBranch.SuspendLayout();
            this.pnlCmbOrganization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LoadREcords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.label6);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(648, 49);
            this.label6.TabIndex = 0;
            this.label6.Text = "Classwise Monthly Attendance Report";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_Date);
            this.panel1.Controls.Add(this.lblDate);
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
            this.panel1.Location = new System.Drawing.Point(107, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 325);
            this.panel1.TabIndex = 52;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(305, 271);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 26);
            this.dtp_Date.TabIndex = 79;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(162, 277);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(137, 18);
            this.lblDate.TabIndex = 78;
            this.lblDate.Text = "Attendance Day :";
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
            this.cmbClass.SelectionChangeCommitted += new System.EventHandler(this.cmbClass_SelectionChangeCommitted);
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
            this.cmbSection.SelectionChangeCommitted += new System.EventHandler(this.cmbSection_SelectionChangeCommitted);
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
            this.cmbDepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartment_SelectionChangeCommitted);
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
            // btn_LoadREcords
            // 
            this.btn_LoadREcords.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_LoadREcords.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadREcords.ForeColor = System.Drawing.Color.Black;
            this.btn_LoadREcords.Location = new System.Drawing.Point(411, 541);
            this.btn_LoadREcords.Name = "btn_LoadREcords";
            this.btn_LoadREcords.Size = new System.Drawing.Size(245, 41);
            this.btn_LoadREcords.TabIndex = 54;
            this.btn_LoadREcords.Text = "Load Records ";
            this.btn_LoadREcords.Click += new System.EventHandler(this.btn_LoadREcords_Click);
            // 
            // ucClasswiseMonthlyAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_LoadREcords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucClasswiseMonthlyAttendanceReport";
            this.Size = new System.Drawing.Size(754, 688);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCmbBranch.ResumeLayout(false);
            this.pnlCmbBranch.PerformLayout();
            this.pnlCmbOrganization.ResumeLayout(false);
            this.pnlCmbOrganization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LoadREcords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_class;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lblDate;
        private Telerik.WinControls.UI.RadButton btn_LoadREcords;
    }
}
