namespace SicParvisMagna.Forms.ChartOfAccounts
{
    partial class ucManageArrearAndDiscounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageArrearAndDiscounts));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabState = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbChallanNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dgvStudFees = new System.Windows.Forms.DataGridView();
            this.rdbtn_unpaid = new System.Windows.Forms.RadioButton();
            this.rdbtn_All = new System.Windows.Forms.RadioButton();
            this.rdbtn_paid = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelToolBox.SuspendLayout();
            this.tabState.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudFees)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.panel2);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 24;
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
            this.btnSearch.Location = new System.Drawing.Point(154, 0);
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
            this.metroTabPage1.Controls.Add(this.dgvStudFees);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 547);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Manage Arrear And Discounts";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 233);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbChallanNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtp_Date);
            this.panel1.Controls.Add(this.cmbSession);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbClass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbSection);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 224);
            this.panel1.TabIndex = 51;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(160, 61);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(236, 21);
            this.cmbClass.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 63);
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
            this.cmbSection.Location = new System.Drawing.Point(160, 102);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(236, 21);
            this.cmbSection.TabIndex = 54;
            this.cmbSection.DropDown += new System.EventHandler(this.cmbSection_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 53;
            this.label3.Tag = "Code";
            this.label3.Text = "Section";
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(160, 20);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(236, 21);
            this.cmbSession.TabIndex = 60;
            this.cmbSession.SelectionChangeCommitted += new System.EventHandler(this.cmbSession_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 59;
            this.label7.Tag = "Code";
            this.label7.Text = "Session";
            // 
            // txtbChallanNo
            // 
            this.txtbChallanNo.Location = new System.Drawing.Point(160, 189);
            this.txtbChallanNo.Name = "txtbChallanNo";
            this.txtbChallanNo.Size = new System.Drawing.Size(236, 20);
            this.txtbChallanNo.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 65;
            this.label2.Tag = "Code";
            this.label2.Text = "Fee Month/Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 64;
            this.label4.Tag = "Code";
            this.label4.Text = "Challan No.";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(160, 143);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(219, 26);
            this.dtp_Date.TabIndex = 63;
            // 
            // dgvStudFees
            // 
            this.dgvStudFees.AllowUserToAddRows = false;
            this.dgvStudFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudFees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudFees.Location = new System.Drawing.Point(0, 233);
            this.dgvStudFees.Name = "dgvStudFees";
            this.dgvStudFees.Size = new System.Drawing.Size(746, 314);
            this.dgvStudFees.TabIndex = 53;
            this.dgvStudFees.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudFees_CellEndEdit);
            // 
            // rdbtn_unpaid
            // 
            this.rdbtn_unpaid.AutoSize = true;
            this.rdbtn_unpaid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_unpaid.ForeColor = System.Drawing.Color.Black;
            this.rdbtn_unpaid.Location = new System.Drawing.Point(174, 46);
            this.rdbtn_unpaid.Name = "rdbtn_unpaid";
            this.rdbtn_unpaid.Size = new System.Drawing.Size(80, 24);
            this.rdbtn_unpaid.TabIndex = 55;
            this.rdbtn_unpaid.TabStop = true;
            this.rdbtn_unpaid.Text = "Unpaid";
            this.rdbtn_unpaid.UseVisualStyleBackColor = true;
            this.rdbtn_unpaid.CheckedChanged += new System.EventHandler(this.rdbtn_unpaid_CheckedChanged);
            // 
            // rdbtn_All
            // 
            this.rdbtn_All.AutoSize = true;
            this.rdbtn_All.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_All.ForeColor = System.Drawing.Color.Black;
            this.rdbtn_All.Location = new System.Drawing.Point(3, 46);
            this.rdbtn_All.Name = "rdbtn_All";
            this.rdbtn_All.Size = new System.Drawing.Size(88, 24);
            this.rdbtn_All.TabIndex = 56;
            this.rdbtn_All.TabStop = true;
            this.rdbtn_All.Text = "Show All";
            this.rdbtn_All.UseVisualStyleBackColor = true;
            this.rdbtn_All.CheckedChanged += new System.EventHandler(this.rdbtn_All_CheckedChanged);
            // 
            // rdbtn_paid
            // 
            this.rdbtn_paid.AutoSize = true;
            this.rdbtn_paid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_paid.ForeColor = System.Drawing.Color.Black;
            this.rdbtn_paid.Location = new System.Drawing.Point(97, 46);
            this.rdbtn_paid.Name = "rdbtn_paid";
            this.rdbtn_paid.Size = new System.Drawing.Size(59, 24);
            this.rdbtn_paid.TabIndex = 57;
            this.rdbtn_paid.TabStop = true;
            this.rdbtn_paid.Text = "Paid";
            this.rdbtn_paid.UseVisualStyleBackColor = true;
            this.rdbtn_paid.CheckedChanged += new System.EventHandler(this.rdbtn_paid_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbtn_All);
            this.panel2.Controls.Add(this.rdbtn_unpaid);
            this.panel2.Controls.Add(this.rdbtn_paid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(490, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 99);
            this.panel2.TabIndex = 58;
            // 
            // ucManageArrearAndDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabState);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucManageArrearAndDiscounts";
            this.Size = new System.Drawing.Size(754, 688);
            this.panelToolBox.ResumeLayout(false);
            this.tabState.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudFees)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private MetroFramework.Controls.MetroTabControl tabState;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbChallanNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridView dgvStudFees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbtn_All;
        private System.Windows.Forms.RadioButton rdbtn_unpaid;
        private System.Windows.Forms.RadioButton rdbtn_paid;
    }
}
