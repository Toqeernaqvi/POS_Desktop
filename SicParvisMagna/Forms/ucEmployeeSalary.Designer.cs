namespace SicParvisMagna.Forms
{
    partial class ucEmployeeSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmployeeSalary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.dtp_SalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbx_Dept = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Month = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gridEmployee = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblError_Department = new System.Windows.Forms.Label();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.lblError_Department);
            this.panelToolBox.Controls.Add(this.dtp_SalaryMonth);
            this.panelToolBox.Controls.Add(this.bunifuCustomLabel12);
            this.panelToolBox.Controls.Add(this.cmbx_Dept);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Controls.Add(this.bunifuCustomLabel17);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 23;
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
            this.btnSearch.Location = new System.Drawing.Point(77, 0);
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
            // dtp_SalaryMonth
            // 
            this.dtp_SalaryMonth.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtp_SalaryMonth.Location = new System.Drawing.Point(547, 34);
            this.dtp_SalaryMonth.Name = "dtp_SalaryMonth";
            this.dtp_SalaryMonth.Size = new System.Drawing.Size(200, 26);
            this.dtp_SalaryMonth.TabIndex = 110;
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.bunifuCustomLabel17.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(416, 35);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(104, 20);
            this.bunifuCustomLabel17.TabIndex = 109;
            this.bunifuCustomLabel17.Text = "Salary Month";
            // 
            // cmbx_Dept
            // 
            this.cmbx_Dept.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbx_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Dept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Dept.FormattingEnabled = true;
            this.cmbx_Dept.Location = new System.Drawing.Point(545, 66);
            this.cmbx_Dept.Name = "cmbx_Dept";
            this.cmbx_Dept.Size = new System.Drawing.Size(202, 28);
            this.cmbx_Dept.TabIndex = 108;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(416, 69);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(97, 20);
            this.bunifuCustomLabel12.TabIndex = 106;
            this.bunifuCustomLabel12.Text = "Department";
            // 
            // lblError_Month
            // 
            this.lblError_Month.AutoSize = true;
            this.lblError_Month.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Month.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblError_Month.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Month.Location = new System.Drawing.Point(356, 162);
            this.lblError_Month.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Month.Name = "lblError_Month";
            this.lblError_Month.Size = new System.Drawing.Size(0, 20);
            this.lblError_Month.TabIndex = 107;
            // 
            // gridEmployee
            // 
            this.gridEmployee.AllowUserToAddRows = false;
            this.gridEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmployee.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployee.DoubleBuffered = true;
            this.gridEmployee.EnableHeadersVisualStyles = false;
            this.gridEmployee.HeaderBgColor = System.Drawing.Color.Silver;
            this.gridEmployee.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.gridEmployee.Location = new System.Drawing.Point(0, 99);
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridEmployee.RowTemplate.Height = 24;
            this.gridEmployee.Size = new System.Drawing.Size(754, 589);
            this.gridEmployee.TabIndex = 108;
            this.gridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmployee_CellClick);
            this.gridEmployee.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmployee_CellLeave);
            // 
            // lblError_Department
            // 
            this.lblError_Department.AutoSize = true;
            this.lblError_Department.Location = new System.Drawing.Point(305, 34);
            this.lblError_Department.Name = "lblError_Department";
            this.lblError_Department.Size = new System.Drawing.Size(10, 13);
            this.lblError_Department.TabIndex = 111;
            this.lblError_Department.Text = " ";
            // 
            // ucEmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.lblError_Month);
            this.Name = "ucEmployeeSalary";
            this.Size = new System.Drawing.Size(754, 688);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.DateTimePicker dtp_SalaryMonth;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.ComboBox cmbx_Dept;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_Month;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridEmployee;
        private System.Windows.Forms.Label lblError_Department;
    }
}
