namespace SicParvisMagna.Forms
{
    partial class ucEmployeeAttendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmployeeAttendence));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeType = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblFather = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rdbtn_HalfLeave = new System.Windows.Forms.RadioButton();
            this.rdbtn_Overtime = new System.Windows.Forms.RadioButton();
            this.rdbtn_TempIn = new System.Windows.Forms.RadioButton();
            this.rdbtn_TempOut = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbtn_TimeOut = new System.Windows.Forms.RadioButton();
            this.rdbtn_TimeIn = new System.Windows.Forms.RadioButton();
            this.lblError = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.chkSystemDate = new MetroFramework.Controls.MetroCheckBox();
            this.chkSystemTime = new MetroFramework.Controls.MetroCheckBox();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.radDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.radTimePicker1 = new Telerik.WinControls.UI.RadTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panelToolBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            this.pnlDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).BeginInit();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePicker1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(34, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Current Time:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panelToolBox.Controls.Add(this.panel1);
            this.panelToolBox.Controls.Add(this.label4);
            this.panelToolBox.Controls.Add(this.label3);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 50);
            this.panelToolBox.MinimumSize = new System.Drawing.Size(0, 58);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 100);
            this.panelToolBox.TabIndex = 13;
            this.panelToolBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToolBox_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pnlDateTime);
            this.panel1.Controls.Add(this.chkSystemTime);
            this.panel1.Controls.Add(this.chkSystemDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 100);
            this.panel1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Designation:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(32, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimeType
            // 
            this.lblTimeType.AutoSize = true;
            this.lblTimeType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeType.Location = new System.Drawing.Point(60, 262);
            this.lblTimeType.Name = "lblTimeType";
            this.lblTimeType.Size = new System.Drawing.Size(68, 21);
            this.lblTimeType.TabIndex = 21;
            this.lblTimeType.Text = "Time In:";
            this.lblTimeType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentName.Location = new System.Drawing.Point(34, 186);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(92, 21);
            this.lblStudentName.TabIndex = 20;
            this.lblStudentName.Text = "First Name:";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClass.Location = new System.Drawing.Point(147, 310);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 21);
            this.lblClass.TabIndex = 28;
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeIn.Location = new System.Drawing.Point(147, 272);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(0, 21);
            this.lblTimeIn.TabIndex = 27;
            this.lblTimeIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFather.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFather.Location = new System.Drawing.Point(147, 234);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(0, 21);
            this.lblFather.TabIndex = 26;
            this.lblFather.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(147, 196);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 21);
            this.lblName.TabIndex = 25;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbtn_HalfLeave
            // 
            this.rdbtn_HalfLeave.AutoSize = true;
            this.rdbtn_HalfLeave.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rdbtn_HalfLeave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_HalfLeave.Location = new System.Drawing.Point(404, 246);
            this.rdbtn_HalfLeave.Name = "rdbtn_HalfLeave";
            this.rdbtn_HalfLeave.Size = new System.Drawing.Size(110, 25);
            this.rdbtn_HalfLeave.TabIndex = 45;
            this.rdbtn_HalfLeave.TabStop = true;
            this.rdbtn_HalfLeave.Text = "Half Leave";
            this.rdbtn_HalfLeave.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Overtime
            // 
            this.rdbtn_Overtime.AutoSize = true;
            this.rdbtn_Overtime.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rdbtn_Overtime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_Overtime.Location = new System.Drawing.Point(549, 246);
            this.rdbtn_Overtime.Name = "rdbtn_Overtime";
            this.rdbtn_Overtime.Size = new System.Drawing.Size(102, 25);
            this.rdbtn_Overtime.TabIndex = 44;
            this.rdbtn_Overtime.TabStop = true;
            this.rdbtn_Overtime.Text = "Overtime";
            this.rdbtn_Overtime.UseVisualStyleBackColor = true;
            // 
            // rdbtn_TempIn
            // 
            this.rdbtn_TempIn.AutoSize = true;
            this.rdbtn_TempIn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rdbtn_TempIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_TempIn.Location = new System.Drawing.Point(404, 184);
            this.rdbtn_TempIn.Name = "rdbtn_TempIn";
            this.rdbtn_TempIn.Size = new System.Drawing.Size(91, 25);
            this.rdbtn_TempIn.TabIndex = 43;
            this.rdbtn_TempIn.TabStop = true;
            this.rdbtn_TempIn.Text = "Temp In";
            this.rdbtn_TempIn.UseVisualStyleBackColor = true;
            // 
            // rdbtn_TempOut
            // 
            this.rdbtn_TempOut.AutoSize = true;
            this.rdbtn_TempOut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rdbtn_TempOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_TempOut.Location = new System.Drawing.Point(549, 184);
            this.rdbtn_TempOut.Name = "rdbtn_TempOut";
            this.rdbtn_TempOut.Size = new System.Drawing.Size(107, 25);
            this.rdbtn_TempOut.TabIndex = 42;
            this.rdbtn_TempOut.TabStop = true;
            this.rdbtn_TempOut.Text = "Temp Out";
            this.rdbtn_TempOut.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(404, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 27);
            this.textBox1.TabIndex = 40;
            // 
            // rdbtn_TimeOut
            // 
            this.rdbtn_TimeOut.AutoSize = true;
            this.rdbtn_TimeOut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rdbtn_TimeOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_TimeOut.Location = new System.Drawing.Point(549, 215);
            this.rdbtn_TimeOut.Name = "rdbtn_TimeOut";
            this.rdbtn_TimeOut.Size = new System.Drawing.Size(59, 25);
            this.rdbtn_TimeOut.TabIndex = 38;
            this.rdbtn_TimeOut.TabStop = true;
            this.rdbtn_TimeOut.Text = "Out";
            this.rdbtn_TimeOut.UseVisualStyleBackColor = true;
            // 
            // rdbtn_TimeIn
            // 
            this.rdbtn_TimeIn.AutoSize = true;
            this.rdbtn_TimeIn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rdbtn_TimeIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_TimeIn.Location = new System.Drawing.Point(404, 215);
            this.rdbtn_TimeIn.Name = "rdbtn_TimeIn";
            this.rdbtn_TimeIn.Size = new System.Drawing.Size(43, 25);
            this.rdbtn_TimeIn.TabIndex = 37;
            this.rdbtn_TimeIn.TabStop = true;
            this.rdbtn_TimeIn.Text = "In";
            this.rdbtn_TimeIn.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Tomato;
            this.lblError.Location = new System.Drawing.Point(467, 421);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(227, 28);
            this.lblError.TabIndex = 36;
            this.lblError.Text = "Record Not Found!";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "       Mark Attendance";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 66D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(695, 281);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(42, 39);
            this.bunifuFlatButton1.TabIndex = 41;
            this.bunifuFlatButton1.Text = "       Mark Attendance";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSearch
            // 
            this.btnSearch.Active = false;
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "              Mark Attendance";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.DimGray;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 66D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(404, 330);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(324, 74);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "              Mark Attendance";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.Silver;
            this.btnSearch.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.lblMainHeader);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.GradientBottomLeft = System.Drawing.Color.White;
            this.panelTop.GradientBottomRight = System.Drawing.Color.White;
            this.panelTop.GradientTopLeft = System.Drawing.Color.White;
            this.panelTop.GradientTopRight = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.MaximumSize = new System.Drawing.Size(0, 50);
            this.panelTop.MinimumSize = new System.Drawing.Size(0, 50);
            this.panelTop.Name = "panelTop";
            this.panelTop.Quality = 10;
            this.panelTop.Size = new System.Drawing.Size(754, 50);
            this.panelTop.TabIndex = 5;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblMainHeader.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeader.Location = new System.Drawing.Point(10, 12);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(125, 22);
            this.lblMainHeader.TabIndex = 4;
            this.lblMainHeader.Text = "Attendance";
            // 
            // chkSystemDate
            // 
            this.chkSystemDate.AutoSize = true;
            this.chkSystemDate.BackColor = System.Drawing.Color.Silver;
            this.chkSystemDate.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkSystemDate.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkSystemDate.Location = new System.Drawing.Point(7, 14);
            this.chkSystemDate.Name = "chkSystemDate";
            this.chkSystemDate.Size = new System.Drawing.Size(134, 25);
            this.chkSystemDate.TabIndex = 37;
            this.chkSystemDate.Text = "System Date";
            this.chkSystemDate.UseSelectable = true;
            this.chkSystemDate.CheckedChanged += new System.EventHandler(this.chkSystemDate_CheckedChanged);
            // 
            // chkSystemTime
            // 
            this.chkSystemTime.AutoSize = true;
            this.chkSystemTime.BackColor = System.Drawing.Color.Transparent;
            this.chkSystemTime.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkSystemTime.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkSystemTime.Location = new System.Drawing.Point(7, 55);
            this.chkSystemTime.Name = "chkSystemTime";
            this.chkSystemTime.Size = new System.Drawing.Size(136, 25);
            this.chkSystemTime.TabIndex = 38;
            this.chkSystemTime.Text = "System Time";
            this.chkSystemTime.UseSelectable = true;
            this.chkSystemTime.CheckedChanged += new System.EventHandler(this.chkSystemTime_CheckedChanged);
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.Controls.Add(this.pnlDate);
            this.pnlDateTime.Controls.Add(this.pnlTime);
            this.pnlDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDateTime.Location = new System.Drawing.Point(241, 0);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(513, 100);
            this.pnlDateTime.TabIndex = 39;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.radDateTimePicker2);
            this.pnlDate.Controls.Add(this.label6);
            this.pnlDate.Location = new System.Drawing.Point(0, 3);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(513, 47);
            this.pnlDate.TabIndex = 50;
            // 
            // radDateTimePicker2
            // 
            this.radDateTimePicker2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radDateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.radDateTimePicker2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radDateTimePicker2.Location = new System.Drawing.Point(141, 15);
            this.radDateTimePicker2.Name = "radDateTimePicker2";
            // 
            // 
            // 
            this.radDateTimePicker2.RootElement.ControlBounds = new System.Drawing.Rectangle(141, 15, 164, 20);
            this.radDateTimePicker2.RootElement.StretchVertically = true;
            this.radDateTimePicker2.Size = new System.Drawing.Size(290, 25);
            this.radDateTimePicker2.TabIndex = 39;
            this.radDateTimePicker2.TabStop = false;
            this.radDateTimePicker2.Value = new System.DateTime(((long)(0)));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Current Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.radTimePicker1);
            this.pnlTime.Controls.Add(this.label7);
            this.pnlTime.Location = new System.Drawing.Point(0, 51);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(513, 46);
            this.pnlTime.TabIndex = 51;
            // 
            // radTimePicker1
            // 
            this.radTimePicker1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.radTimePicker1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radTimePicker1.Location = new System.Drawing.Point(146, 13);
            this.radTimePicker1.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.radTimePicker1.MinValue = new System.DateTime(((long)(0)));
            this.radTimePicker1.Name = "radTimePicker1";
            // 
            // 
            // 
            this.radTimePicker1.RootElement.ControlBounds = new System.Drawing.Rectangle(146, 13, 100, 20);
            this.radTimePicker1.RootElement.StretchVertically = true;
            this.radTimePicker1.Size = new System.Drawing.Size(290, 25);
            this.radTimePicker1.TabIndex = 40;
            this.radTimePicker1.TabStop = false;
            this.radTimePicker1.Value = new System.DateTime(2019, 1, 10, 21, 36, 21, 949);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(26, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Current Time:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ucEmployeeAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.rdbtn_HalfLeave);
            this.Controls.Add(this.rdbtn_Overtime);
            this.Controls.Add(this.rdbtn_TempIn);
            this.Controls.Add(this.rdbtn_TempOut);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdbtn_TimeOut);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdbtn_TimeIn);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.lblFather);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimeType);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.panelTop);
            this.Name = "ucEmployeeAttendence";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucEmployeeAttendence_Load);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).EndInit();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePicker1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelTop;
        private System.Windows.Forms.Label lblMainHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeType;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rdbtn_HalfLeave;
        private System.Windows.Forms.RadioButton rdbtn_Overtime;
        private System.Windows.Forms.RadioButton rdbtn_TempIn;
        private System.Windows.Forms.RadioButton rdbtn_TempOut;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbtn_TimeOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.RadioButton rdbtn_TimeIn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroCheckBox chkSystemTime;
        private MetroFramework.Controls.MetroCheckBox chkSystemDate;
        private System.Windows.Forms.Panel pnlDateTime;
        private System.Windows.Forms.Panel pnlDate;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlTime;
        private Telerik.WinControls.UI.RadTimePicker radTimePicker1;
        private System.Windows.Forms.Label label7;
    }
}
