namespace SicParvisMagna.Forms
{
    partial class ucAddCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddCountry));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabCountry = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblError_Name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_shortName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.gridCountries = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.tabCountry.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).BeginInit();
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
            this.panelToolBox.TabIndex = 17;
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
            // tabCountry
            // 
            this.tabCountry.Controls.Add(this.metroTabPage1);
            this.tabCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCountry.Location = new System.Drawing.Point(0, 99);
            this.tabCountry.Name = "tabCountry";
            this.tabCountry.SelectedIndex = 0;
            this.tabCountry.Size = new System.Drawing.Size(754, 383);
            this.tabCountry.TabIndex = 18;
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
            this.metroTabPage1.Size = new System.Drawing.Size(746, 341);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Countries";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 341);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblErrorName);
            this.panel4.Controls.Add(this.lblError_Name);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_Name);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 46);
            this.panel4.TabIndex = 36;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.lblErrorName.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorName.Location = new System.Drawing.Point(339, 0);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(11, 13);
            this.lblErrorName.TabIndex = 239;
            this.lblErrorName.Text = "*";
            // 
            // lblError_Name
            // 
            this.lblError_Name.AutoSize = true;
            this.lblError_Name.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblError_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lblError_Name.Location = new System.Drawing.Point(337, 26);
            this.lblError_Name.Name = "lblError_Name";
            this.lblError_Name.Size = new System.Drawing.Size(0, 19);
            this.lblError_Name.TabIndex = 238;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(31, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 237;
            this.label4.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(88, 15);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(249, 27);
            this.txt_Name.TabIndex = 236;
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txt_shortName);
            this.panel5.Location = new System.Drawing.Point(3, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 52);
            this.panel5.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Shortname";
            // 
            // txt_shortName
            // 
            this.txt_shortName.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_shortName.Location = new System.Drawing.Point(87, 14);
            this.txt_shortName.MaxLength = 20;
            this.txt_shortName.Name = "txt_shortName";
            this.txt_shortName.Size = new System.Drawing.Size(249, 27);
            this.txt_shortName.TabIndex = 28;
            this.txt_shortName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_shortName_KeyDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblErrorCode);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txt_Code);
            this.panel6.Location = new System.Drawing.Point(3, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 52);
            this.panel6.TabIndex = 38;
            // 
            // lblErrorCode
            // 
            this.lblErrorCode.AutoSize = true;
            this.lblErrorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.lblErrorCode.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorCode.Location = new System.Drawing.Point(343, 0);
            this.lblErrorCode.Name = "lblErrorCode";
            this.lblErrorCode.Size = new System.Drawing.Size(11, 13);
            this.lblErrorCode.TabIndex = 239;
            this.lblErrorCode.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(39, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 238;
            this.label6.Tag = "Code";
            this.label6.Text = "Code";
            // 
            // txt_Code
            // 
            this.txt_Code.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Code.Location = new System.Drawing.Point(88, 20);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(249, 27);
            this.txt_Code.TabIndex = 237;
            this.txt_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Code_KeyDown);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.txt_Description);
            this.panel7.Location = new System.Drawing.Point(3, 171);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 168);
            this.panel7.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(2, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 31;
            this.label7.Tag = "Code";
            this.label7.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Description.Location = new System.Drawing.Point(88, 9);
            this.txt_Description.MaxLength = 250;
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(249, 147);
            this.txt_Description.TabIndex = 30;
            // 
            // gridCountries
            // 
            this.gridCountries.AllowUserToAddRows = false;
            this.gridCountries.AllowUserToDeleteRows = false;
            this.gridCountries.AllowUserToResizeColumns = false;
            this.gridCountries.AllowUserToResizeRows = false;
            this.gridCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCountries.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCountries.Location = new System.Drawing.Point(0, 482);
            this.gridCountries.Name = "gridCountries";
            this.gridCountries.Size = new System.Drawing.Size(754, 176);
            this.gridCountries.TabIndex = 40;
            this.gridCountries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCountries_CellClick);
            // 
            // ucAddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCountry);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.gridCountries);
            this.Name = "ucAddCountry";
            this.Size = new System.Drawing.Size(754, 658);
            this.Load += new System.EventHandler(this.ucAddCountry_Load);
            this.panelToolBox.ResumeLayout(false);
            this.tabCountry.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private MetroFramework.Controls.MetroTabControl tabCountry;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblError_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_shortName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblErrorCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.DataGridView gridCountries;
    }
}
