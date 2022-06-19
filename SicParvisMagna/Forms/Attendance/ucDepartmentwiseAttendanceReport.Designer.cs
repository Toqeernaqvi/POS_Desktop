namespace SicParvisMagna.Forms.Attendance
{
    partial class ucDepartmentwiseAttendanceReport
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
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btn_LoadREcords = new Telerik.WinControls.UI.RadButton();
            this.rptDailyReport = new Telerik.WinControls.UI.RadCheckBox();
            this.rptMonthlyReport = new Telerik.WinControls.UI.RadCheckBox();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LoadREcords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDailyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptMonthlyReport)).BeginInit();
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
            this.panelToolBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(718, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = " Departmentwise Attendance Report";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(309, 266);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 26);
            this.dtp_Date.TabIndex = 81;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(236, 272);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 18);
            this.lblDate.TabIndex = 80;
            this.lblDate.Text = "Date  :";
            // 
            // btn_LoadREcords
            // 
            this.btn_LoadREcords.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_LoadREcords.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadREcords.ForeColor = System.Drawing.Color.Black;
            this.btn_LoadREcords.Location = new System.Drawing.Point(353, 398);
            this.btn_LoadREcords.Name = "btn_LoadREcords";
            this.btn_LoadREcords.Size = new System.Drawing.Size(245, 41);
            this.btn_LoadREcords.TabIndex = 82;
            this.btn_LoadREcords.Text = "Load Records ";
            this.btn_LoadREcords.Click += new System.EventHandler(this.btn_LoadREcords_Click);
            // 
            // rptDailyReport
            // 
            this.rptDailyReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptDailyReport.Location = new System.Drawing.Point(309, 339);
            this.rptDailyReport.Name = "rptDailyReport";
            this.rptDailyReport.Size = new System.Drawing.Size(96, 21);
            this.rptDailyReport.TabIndex = 83;
            this.rptDailyReport.Text = "Daily Report";
            // 
            // rptMonthlyReport
            // 
            this.rptMonthlyReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptMonthlyReport.Location = new System.Drawing.Point(418, 339);
            this.rptMonthlyReport.Name = "rptMonthlyReport";
            this.rptMonthlyReport.Size = new System.Drawing.Size(117, 21);
            this.rptMonthlyReport.TabIndex = 84;
            this.rptMonthlyReport.Text = "Monthly Report";
            // 
            // ucDepartmentwiseAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rptMonthlyReport);
            this.Controls.Add(this.rptDailyReport);
            this.Controls.Add(this.btn_LoadREcords);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucDepartmentwiseAttendanceReport";
            this.Size = new System.Drawing.Size(754, 688);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LoadREcords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDailyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptMonthlyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lblDate;
        private Telerik.WinControls.UI.RadButton btn_LoadREcords;
        private Telerik.WinControls.UI.RadCheckBox rptDailyReport;
        private Telerik.WinControls.UI.RadCheckBox rptMonthlyReport;
    }
}
