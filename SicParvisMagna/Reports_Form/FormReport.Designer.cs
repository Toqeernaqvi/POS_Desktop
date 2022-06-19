namespace SicParvisMagna
{
    partial class FormReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormHeading = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHeaderProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHeaderLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFormHeading);
            this.panel1.Controls.Add(this.panelControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 43);
            this.panel1.TabIndex = 8;
            // 
            // lblFormHeading
            // 
            this.lblFormHeading.AutoSize = true;
            this.lblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblFormHeading.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFormHeading.Location = new System.Drawing.Point(12, 12);
            this.lblFormHeading.Name = "lblFormHeading";
            this.lblFormHeading.Size = new System.Drawing.Size(79, 22);
            this.lblFormHeading.TabIndex = 7;
            this.lblFormHeading.Text = "Reports";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.panelControl.Controls.Add(this.panel2);
            this.panelControl.Controls.Add(this.bunifuImageButton1);
            this.panelControl.Controls.Add(this.panel3);
            this.panelControl.Controls.Add(this.btnExit);
            this.panelControl.Controls.Add(this.btnMinimize);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(207, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(599, 43);
            this.panelControl.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnHeaderProfile);
            this.panel2.Controls.Add(this.lblMainHeader);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(104, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 40);
            this.panel2.TabIndex = 6;
            // 
            // btnHeaderProfile
            // 
            this.btnHeaderProfile.Active = false;
            this.btnHeaderProfile.Activecolor = System.Drawing.Color.Transparent;
            this.btnHeaderProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderProfile.BorderRadius = 0;
            this.btnHeaderProfile.ButtonText = "";
            this.btnHeaderProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeaderProfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnHeaderProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHeaderProfile.Iconimage = global::SicParvisMagna.Properties.Resources.icons8_user_24;
            this.btnHeaderProfile.Iconimage_right = null;
            this.btnHeaderProfile.Iconimage_right_Selected = null;
            this.btnHeaderProfile.Iconimage_Selected = null;
            this.btnHeaderProfile.IconMarginLeft = 0;
            this.btnHeaderProfile.IconMarginRight = 0;
            this.btnHeaderProfile.IconRightVisible = true;
            this.btnHeaderProfile.IconRightZoom = 0D;
            this.btnHeaderProfile.IconVisible = true;
            this.btnHeaderProfile.IconZoom = 50D;
            this.btnHeaderProfile.IsTab = false;
            this.btnHeaderProfile.Location = new System.Drawing.Point(4, 4);
            this.btnHeaderProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeaderProfile.Name = "btnHeaderProfile";
            this.btnHeaderProfile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderProfile.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderProfile.selected = false;
            this.btnHeaderProfile.Size = new System.Drawing.Size(33, 34);
            this.btnHeaderProfile.TabIndex = 4;
            this.btnHeaderProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHeaderProfile.Textcolor = System.Drawing.Color.White;
            this.btnHeaderProfile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblMainHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMainHeader.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMainHeader.Location = new System.Drawing.Point(40, 9);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(113, 22);
            this.lblMainHeader.TabIndex = 4;
            this.lblMainHeader.Text = "Dashboard";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::SicParvisMagna.Properties.Resources.round_maximize_white_18dp;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(514, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnHeaderLogout);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(354, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 40);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "LogOut";
            // 
            // btnHeaderLogout
            // 
            this.btnHeaderLogout.Active = false;
            this.btnHeaderLogout.Activecolor = System.Drawing.Color.Transparent;
            this.btnHeaderLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderLogout.BorderRadius = 0;
            this.btnHeaderLogout.ButtonText = "";
            this.btnHeaderLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeaderLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnHeaderLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHeaderLogout.Iconimage = global::SicParvisMagna.Properties.Resources.icons8_exit_24;
            this.btnHeaderLogout.Iconimage_right = null;
            this.btnHeaderLogout.Iconimage_right_Selected = null;
            this.btnHeaderLogout.Iconimage_Selected = null;
            this.btnHeaderLogout.IconMarginLeft = 0;
            this.btnHeaderLogout.IconMarginRight = 0;
            this.btnHeaderLogout.IconRightVisible = true;
            this.btnHeaderLogout.IconRightZoom = 0D;
            this.btnHeaderLogout.IconVisible = true;
            this.btnHeaderLogout.IconZoom = 50D;
            this.btnHeaderLogout.IsTab = false;
            this.btnHeaderLogout.Location = new System.Drawing.Point(0, 4);
            this.btnHeaderLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeaderLogout.Name = "btnHeaderLogout";
            this.btnHeaderLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderLogout.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderLogout.selected = false;
            this.btnHeaderLogout.Size = new System.Drawing.Size(33, 34);
            this.btnHeaderLogout.TabIndex = 5;
            this.btnHeaderLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHeaderLogout.Textcolor = System.Drawing.Color.White;
            this.btnHeaderLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::SicParvisMagna.Properties.Resources.icons8_multiply_24;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(561, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::SicParvisMagna.Properties.Resources.round_minimize_white_18dp;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(469, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.crViewer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(806, 560);
            this.panel4.TabIndex = 9;
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewer.Location = new System.Drawing.Point(0, 0);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(806, 560);
            this.crViewer.TabIndex = 8;
            this.crViewer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.crViewer_KeyDown);
            this.crViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crViewer_MouseDown);
            this.crViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.crViewer_MouseMove);
            this.crViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crViewer_MouseUp);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(806, 603);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormReport_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormHeading;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnHeaderProfile;
        private System.Windows.Forms.Label lblMainHeader;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHeaderLogout;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel panel4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}