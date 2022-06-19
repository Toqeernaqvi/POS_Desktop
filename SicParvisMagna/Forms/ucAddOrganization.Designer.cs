namespace SicParvisMagna.Forms
{
    partial class ucAddOrganization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddOrganization));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabCountry = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnRemovePic = new System.Windows.Forms.Button();
            this.OrgPicbox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblErrorOrganizationTitle = new System.Windows.Forms.Label();
            this.txtOrganizationTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridOrganization = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            this.tabCountry.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrgPicbox)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrganization)).BeginInit();
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
            this.panelToolBox.TabIndex = 18;
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
            this.tabCountry.Size = new System.Drawing.Size(754, 589);
            this.tabCountry.TabIndex = 19;
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
            this.metroTabPage1.Size = new System.Drawing.Size(746, 547);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Organizations";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 547);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 142);
            this.panel1.TabIndex = 40;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnAddPic);
            this.metroPanel1.Controls.Add(this.btnRemovePic);
            this.metroPanel1.Controls.Add(this.OrgPicbox);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(268, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(280, 142);
            this.metroPanel1.TabIndex = 245;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.Location = new System.Drawing.Point(8, 33);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(95, 50);
            this.btnAddPic.TabIndex = 243;
            this.btnAddPic.Text = "Add Pic";
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddExperincePic_Click);
            // 
            // btnRemovePic
            // 
            this.btnRemovePic.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePic.Location = new System.Drawing.Point(8, 89);
            this.btnRemovePic.Name = "btnRemovePic";
            this.btnRemovePic.Size = new System.Drawing.Size(95, 50);
            this.btnRemovePic.TabIndex = 244;
            this.btnRemovePic.Text = "Remove Pic";
            this.btnRemovePic.UseVisualStyleBackColor = false;
            // 
            // OrgPicbox
            // 
            this.OrgPicbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OrgPicbox.Image = ((System.Drawing.Image)(resources.GetObject("OrgPicbox.Image")));
            this.OrgPicbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("OrgPicbox.InitialImage")));
            this.OrgPicbox.Location = new System.Drawing.Point(109, 0);
            this.OrgPicbox.Name = "OrgPicbox";
            this.OrgPicbox.Size = new System.Drawing.Size(171, 142);
            this.OrgPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrgPicbox.TabIndex = 241;
            this.OrgPicbox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 30);
            this.label2.TabIndex = 242;
            this.label2.Text = "Add Organization Logo ";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 10);
            this.panel4.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblErrorOrganizationTitle);
            this.panel7.Controls.Add(this.txtOrganizationTitle);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 167);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 46);
            this.panel7.TabIndex = 39;
            // 
            // lblErrorOrganizationTitle
            // 
            this.lblErrorOrganizationTitle.AutoSize = true;
            this.lblErrorOrganizationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.lblErrorOrganizationTitle.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorOrganizationTitle.Location = new System.Drawing.Point(348, 7);
            this.lblErrorOrganizationTitle.Name = "lblErrorOrganizationTitle";
            this.lblErrorOrganizationTitle.Size = new System.Drawing.Size(11, 13);
            this.lblErrorOrganizationTitle.TabIndex = 229;
            this.lblErrorOrganizationTitle.Text = "*";
            // 
            // txtOrganizationTitle
            // 
            this.txtOrganizationTitle.Location = new System.Drawing.Point(133, 25);
            this.txtOrganizationTitle.Name = "txtOrganizationTitle";
            this.txtOrganizationTitle.Size = new System.Drawing.Size(217, 20);
            this.txtOrganizationTitle.TabIndex = 228;
            this.txtOrganizationTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrganizationTitle_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 227;
            this.label1.Text = "Organization Title";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 10);
            this.panel2.TabIndex = 41;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 140);
            this.panel3.TabIndex = 42;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(122, 15);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(217, 108);
            this.txtDescription.TabIndex = 225;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 224;
            this.label3.Text = "Description";
            // 
            // gridOrganization
            // 
            this.gridOrganization.AllowUserToAddRows = false;
            this.gridOrganization.AllowUserToDeleteRows = false;
            this.gridOrganization.AllowUserToResizeColumns = false;
            this.gridOrganization.AllowUserToResizeRows = false;
            this.gridOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrganization.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridOrganization.Location = new System.Drawing.Point(0, 540);
            this.gridOrganization.Name = "gridOrganization";
            this.gridOrganization.Size = new System.Drawing.Size(754, 148);
            this.gridOrganization.TabIndex = 40;
            this.gridOrganization.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrganization_CellClick);
            // 
            // ucAddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridOrganization);
            this.Controls.Add(this.tabCountry);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucAddOrganization";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucAddOrganization_Load);
            this.panelToolBox.ResumeLayout(false);
            this.tabCountry.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrgPicbox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrganization)).EndInit();
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView gridOrganization;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox OrgPicbox;
        private System.Windows.Forms.Button btnRemovePic;
        private System.Windows.Forms.Button btnAddPic;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblErrorOrganizationTitle;
        private System.Windows.Forms.TextBox txtOrganizationTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
    }
}
