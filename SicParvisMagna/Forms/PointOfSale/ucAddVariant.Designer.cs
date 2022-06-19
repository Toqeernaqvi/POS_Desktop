namespace SicParvisMagna.Forms.PointOfSale
{
    partial class ucAddVariant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddVariant));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddVariantType = new System.Windows.Forms.Button();
            this.gridVariants = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelToolBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVariants)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.bunifuCustomLabel9);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnDelete);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(743, 105);
            this.panelToolBox.TabIndex = 26;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(577, 0);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(161, 25);
            this.bunifuCustomLabel9.TabIndex = 31;
            this.bunifuCustomLabel9.Text = "Manage Variants";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePosition = 16;
            this.btnSave.ImageZoom = 73;
            this.btnSave.LabelPosition = 32;
            this.btnSave.LabelText = "Save";
            this.btnSave.Location = new System.Drawing.Point(7, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 99);
            this.btnSave.TabIndex = 27;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImagePosition = 16;
            this.btnClear.ImageZoom = 73;
            this.btnClear.LabelPosition = 32;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(73, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 99);
            this.btnClear.TabIndex = 28;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePosition = 16;
            this.btnDelete.ImageZoom = 73;
            this.btnDelete.LabelPosition = 32;
            this.btnDelete.LabelText = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(139, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 99);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddVariantType);
            this.panel1.Controls.Add(this.gridVariants);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 476);
            this.panel1.TabIndex = 27;
            // 
            // btnAddVariantType
            // 
            this.btnAddVariantType.Location = new System.Drawing.Point(610, 3);
            this.btnAddVariantType.Name = "btnAddVariantType";
            this.btnAddVariantType.Size = new System.Drawing.Size(133, 23);
            this.btnAddVariantType.TabIndex = 54;
            this.btnAddVariantType.Text = "Add Variant Type";
            this.btnAddVariantType.UseVisualStyleBackColor = true;
            this.btnAddVariantType.Click += new System.EventHandler(this.btnAddVariantType_Click);
            // 
            // gridVariants
            // 
            this.gridVariants.AllowUserToAddRows = false;
            this.gridVariants.AllowUserToDeleteRows = false;
            this.gridVariants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVariants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridVariants.Location = new System.Drawing.Point(0, 243);
            this.gridVariants.Name = "gridVariants";
            this.gridVariants.Size = new System.Drawing.Size(743, 233);
            this.gridVariants.TabIndex = 53;
            this.gridVariants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVariants_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblErrorTitle);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 36);
            this.panel2.TabIndex = 51;
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorTitle.Location = new System.Drawing.Point(335, 10);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(13, 16);
            this.lblErrorTitle.TabIndex = 1;
            this.lblErrorTitle.Text = "*";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTitle.Location = new System.Drawing.Point(121, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(209, 25);
            this.txtTitle.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(70, 8);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(33, 17);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Title";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtShortName);
            this.panel7.Controls.Add(this.bunifuCustomLabel1);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(2, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 36);
            this.panel7.TabIndex = 50;
            // 
            // txtShortName
            // 
            this.txtShortName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtShortName.Location = new System.Drawing.Point(121, 5);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(209, 25);
            this.txtShortName.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(28, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(75, 17);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Shortname";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtDescription);
            this.panel8.Controls.Add(this.bunifuCustomLabel5);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(3, 87);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(548, 78);
            this.panel8.TabIndex = 52;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(120, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(216, 54);
            this.txtDescription.TabIndex = 0;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(23, 5);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(76, 17);
            this.bunifuCustomLabel5.TabIndex = 1;
            this.bunifuCustomLabel5.Text = "Description";
            // 
            // ucAddVariant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucAddVariant";
            this.Size = new System.Drawing.Size(743, 581);
            this.Load += new System.EventHandler(this.ucAddVariant_Load);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVariants)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        public Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        public Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridVariants;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtShortName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Button btnAddVariantType;
    }
}
