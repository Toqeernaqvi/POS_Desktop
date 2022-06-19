namespace SicParvisMagna.Forms
{
    partial class ucAddPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddPromotion));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btn_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.mtcPromotion = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.panel34 = new System.Windows.Forms.Panel();
            this.lblErrorDescrip = new System.Windows.Forms.Label();
            this.bunifuCustomLabel32 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Descrip = new System.Windows.Forms.TextBox();
            this.gridPromotion = new System.Windows.Forms.DataGridView();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.mtcPromotion.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromotion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.btn_Back);
            this.panelToolBox.Controls.Add(this.btnSearch);
            this.panelToolBox.Controls.Add(this.btnDelete);
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(748, 115);
            this.panelToolBox.TabIndex = 18;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Image = global::SicParvisMagna.Properties.Resources.Back_Arrow_48px;
            this.btn_Back.ImageActive = null;
            this.btn_Back.Location = new System.Drawing.Point(643, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(77, 48);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Back.TabIndex = 27;
            this.btn_Back.TabStop = false;
            this.btn_Back.Zoom = 10;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            // mtcPromotion
            // 
            this.mtcPromotion.Controls.Add(this.metroTabPage1);
            this.mtcPromotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcPromotion.Location = new System.Drawing.Point(0, 115);
            this.mtcPromotion.Name = "mtcPromotion";
            this.mtcPromotion.SelectedIndex = 0;
            this.mtcPromotion.Size = new System.Drawing.Size(748, 588);
            this.mtcPromotion.TabIndex = 19;
            this.mtcPromotion.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(740, 546);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Promotion";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel29);
            this.flowLayoutPanel1.Controls.Add(this.panel34);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 546);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.bunifuCustomLabel22);
            this.panel29.Controls.Add(this.cbxProduct);
            this.panel29.Location = new System.Drawing.Point(3, 3);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(548, 36);
            this.panel29.TabIndex = 198;
            // 
            // bunifuCustomLabel22
            // 
            this.bunifuCustomLabel22.AutoSize = true;
            this.bunifuCustomLabel22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel22.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel22.Location = new System.Drawing.Point(9, 10);
            this.bunifuCustomLabel22.Name = "bunifuCustomLabel22";
            this.bunifuCustomLabel22.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel22.TabIndex = 213;
            this.bunifuCustomLabel22.Text = "Product";
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(82, 10);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(184, 21);
            this.cbxProduct.TabIndex = 212;
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.lblErrorDescrip);
            this.panel34.Controls.Add(this.bunifuCustomLabel32);
            this.panel34.Controls.Add(this.txt_Descrip);
            this.panel34.Location = new System.Drawing.Point(3, 45);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(548, 136);
            this.panel34.TabIndex = 47;
            // 
            // lblErrorDescrip
            // 
            this.lblErrorDescrip.AutoSize = true;
            this.lblErrorDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescrip.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorDescrip.Location = new System.Drawing.Point(91, 10);
            this.lblErrorDescrip.Name = "lblErrorDescrip";
            this.lblErrorDescrip.Size = new System.Drawing.Size(13, 16);
            this.lblErrorDescrip.TabIndex = 217;
            this.lblErrorDescrip.Text = "*";
            // 
            // bunifuCustomLabel32
            // 
            this.bunifuCustomLabel32.AutoSize = true;
            this.bunifuCustomLabel32.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel32.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel32.Location = new System.Drawing.Point(9, 9);
            this.bunifuCustomLabel32.Name = "bunifuCustomLabel32";
            this.bunifuCustomLabel32.Size = new System.Drawing.Size(76, 17);
            this.bunifuCustomLabel32.TabIndex = 209;
            this.bunifuCustomLabel32.Text = "Description";
            // 
            // txt_Descrip
            // 
            this.txt_Descrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descrip.Location = new System.Drawing.Point(82, 38);
            this.txt_Descrip.Multiline = true;
            this.txt_Descrip.Name = "txt_Descrip";
            this.txt_Descrip.Size = new System.Drawing.Size(398, 75);
            this.txt_Descrip.TabIndex = 208;
            // 
            // gridPromotion
            // 
            this.gridPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPromotion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPromotion.Location = new System.Drawing.Point(0, 507);
            this.gridPromotion.Name = "gridPromotion";
            this.gridPromotion.Size = new System.Drawing.Size(748, 196);
            this.gridPromotion.TabIndex = 23;
            // 
            // ucAddPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPromotion);
            this.Controls.Add(this.mtcPromotion);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucAddPromotion";
            this.Size = new System.Drawing.Size(748, 703);
            this.Load += new System.EventHandler(this.ucAddPromotion_Load);
            this.panelToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.mtcPromotion.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel34.ResumeLayout(false);
            this.panel34.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromotion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private MetroFramework.Controls.MetroTabControl mtcPromotion;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel29;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Panel panel34;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel32;
        private System.Windows.Forms.TextBox txt_Descrip;
        private System.Windows.Forms.Label lblErrorDescrip;
        private System.Windows.Forms.DataGridView gridPromotion;
        private Bunifu.Framework.UI.BunifuImageButton btn_Back;
    }
}
