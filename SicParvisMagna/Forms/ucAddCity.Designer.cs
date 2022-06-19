namespace SicParvisMagna.Forms
{
    partial class ucAddCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddCity));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabState = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Country = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.state = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_State = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblError_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_shortName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.gridCity = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.tabState.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnDelete);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 19;
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
            // tabState
            // 
            this.tabState.Controls.Add(this.metroTabPage1);
            this.tabState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabState.Location = new System.Drawing.Point(0, 99);
            this.tabState.Name = "tabState";
            this.tabState.SelectedIndex = 0;
            this.tabState.Size = new System.Drawing.Size(754, 359);
            this.tabState.TabIndex = 20;
            this.tabState.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabState.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 317);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "City";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 317);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_Country);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 46);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(348, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 36;
            // 
            // cbx_Country
            // 
            this.cbx_Country.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbx_Country.FormattingEnabled = true;
            this.cbx_Country.Location = new System.Drawing.Point(81, 16);
            this.cbx_Country.Name = "cbx_Country";
            this.cbx_Country.Size = new System.Drawing.Size(249, 27);
            this.cbx_Country.TabIndex = 35;
            this.cbx_Country.SelectionChangeCommitted += new System.EventHandler(this.cbx_Country_SelectionChangeCommitted);
            this.cbx_Country.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Country_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.state);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cbx_State);
            this.panel4.Location = new System.Drawing.Point(3, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 46);
            this.panel4.TabIndex = 36;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.state.Location = new System.Drawing.Point(16, 13);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(39, 17);
            this.state.TabIndex = 40;
            this.state.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(348, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 39;
            // 
            // cbx_State
            // 
            this.cbx_State.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbx_State.FormattingEnabled = true;
            this.cbx_State.Location = new System.Drawing.Point(81, 10);
            this.cbx_State.Name = "cbx_State";
            this.cbx_State.Size = new System.Drawing.Size(249, 27);
            this.cbx_State.TabIndex = 38;
            this.cbx_State.SelectionChangeCommitted += new System.EventHandler(this.cbx_State_SelectionChangeCommitted);
            this.cbx_State.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_State_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblErrorName);
            this.panel2.Controls.Add(this.lblError_Name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 46);
            this.panel2.TabIndex = 41;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.lblErrorName.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorName.Location = new System.Drawing.Point(329, 0);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(11, 13);
            this.lblErrorName.TabIndex = 228;
            this.lblErrorName.Text = "*";
            // 
            // lblError_Name
            // 
            this.lblError_Name.AutoSize = true;
            this.lblError_Name.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblError_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lblError_Name.Location = new System.Drawing.Point(336, 7);
            this.lblError_Name.Name = "lblError_Name";
            this.lblError_Name.Size = new System.Drawing.Size(0, 19);
            this.lblError_Name.TabIndex = 227;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 226;
            this.label3.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(81, 10);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(249, 27);
            this.txt_Name.TabIndex = 225;
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(348, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_shortName);
            this.panel3.Location = new System.Drawing.Point(3, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 46);
            this.panel3.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Shortname";
            // 
            // txt_shortName
            // 
            this.txt_shortName.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_shortName.Location = new System.Drawing.Point(81, 11);
            this.txt_shortName.MaxLength = 20;
            this.txt_shortName.Name = "txt_shortName";
            this.txt_shortName.Size = new System.Drawing.Size(249, 27);
            this.txt_shortName.TabIndex = 28;
            this.txt_shortName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_shortName_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txt_Code);
            this.panel5.Location = new System.Drawing.Point(3, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 46);
            this.panel5.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(21, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 30;
            this.label6.Tag = "Code";
            this.label6.Text = "Code";
            // 
            // txt_Code
            // 
            this.txt_Code.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Code.Location = new System.Drawing.Point(81, 16);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(249, 27);
            this.txt_Code.TabIndex = 29;
            this.txt_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Code_KeyDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txt_Description);
            this.panel6.Location = new System.Drawing.Point(3, 263);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 124);
            this.panel6.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 31;
            this.label8.Tag = "Code";
            this.label8.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Description.Location = new System.Drawing.Point(87, 7);
            this.txt_Description.MaxLength = 250;
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(249, 98);
            this.txt_Description.TabIndex = 30;
            // 
            // gridCity
            // 
            this.gridCity.AllowUserToAddRows = false;
            this.gridCity.AllowUserToDeleteRows = false;
            this.gridCity.AllowUserToResizeColumns = false;
            this.gridCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCity.Location = new System.Drawing.Point(0, 458);
            this.gridCity.Name = "gridCity";
            this.gridCity.Size = new System.Drawing.Size(754, 230);
            this.gridCity.TabIndex = 45;
            this.gridCity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCountries_CellClick);
            // 
            // ucAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabState);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.gridCity);
            this.Name = "ucAddCity";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucAddCity_Load);
            this.panelToolBox.ResumeLayout(false);
            this.tabState.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCity)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Country;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_State;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblError_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_shortName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.DataGridView gridCity;
    }
}
