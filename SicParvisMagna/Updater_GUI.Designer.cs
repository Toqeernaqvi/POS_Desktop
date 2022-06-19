namespace SicParvisMagna
{
    partial class Updater_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater_GUI));
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new Telerik.WinControls.UI.RadLabel();
            this.lblDownloadSpeed = new Telerik.WinControls.UI.RadLabel();
            this.lblTimeLeft = new Telerik.WinControls.UI.RadLabel();
            this.lblTimeRemaining = new Telerik.WinControls.UI.RadLabel();
            this.lblFrom = new Telerik.WinControls.UI.RadLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btnShowMore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblFileSize = new Telerik.WinControls.UI.RadLabel();
            this.lblDownloadingSpeed = new Telerik.WinControls.UI.RadLabel();
            this.lblUrl = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDownloadSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTimeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTimeRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFrom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFileSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDownloadingSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(250, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "GLOBAL TEKSOFT";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(12, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 25);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "FileSize : ";
            // 
            // lblDownloadSpeed
            // 
            this.lblDownloadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblDownloadSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDownloadSpeed.Location = new System.Drawing.Point(12, 179);
            this.lblDownloadSpeed.Name = "lblDownloadSpeed";
            this.lblDownloadSpeed.Size = new System.Drawing.Size(172, 25);
            this.lblDownloadSpeed.TabIndex = 4;
            this.lblDownloadSpeed.Text = "Downloading Speed : ";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeLeft.Location = new System.Drawing.Point(505, 215);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(86, 25);
            this.lblTimeLeft.TabIndex = 8;
            this.lblTimeLeft.Text = "Time Left :";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeRemaining.Location = new System.Drawing.Point(505, 179);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(142, 25);
            this.lblTimeRemaining.TabIndex = 7;
            this.lblTimeRemaining.Text = "Time Remaining : ";
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrom.Location = new System.Drawing.Point(505, 143);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(60, 25);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 12;
            // 
            // progressBar
            // 
            this.progressBar.animated = false;
            this.progressBar.animationIterval = 5;
            this.progressBar.animationSpeed = 300;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar.BackgroundImage")));
            this.progressBar.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.LabelVisible = true;
            this.progressBar.LineProgressThickness = 8;
            this.progressBar.LineThickness = 5;
            this.progressBar.Location = new System.Drawing.Point(286, 100);
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.progressBar.MaxValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.progressBar.Size = new System.Drawing.Size(184, 184);
            this.progressBar.TabIndex = 13;
            this.progressBar.Value = 0;
            // 
            // btnShowMore
            // 
            this.btnShowMore.Active = false;
            this.btnShowMore.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnShowMore.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowMore.BorderRadius = 0;
            this.btnShowMore.ButtonText = "Show More";
            this.btnShowMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMore.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowMore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowMore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowMore.Iconimage")));
            this.btnShowMore.Iconimage_right = null;
            this.btnShowMore.Iconimage_right_Selected = null;
            this.btnShowMore.Iconimage_Selected = null;
            this.btnShowMore.IconMarginLeft = 0;
            this.btnShowMore.IconMarginRight = 0;
            this.btnShowMore.IconRightVisible = true;
            this.btnShowMore.IconRightZoom = 0D;
            this.btnShowMore.IconVisible = true;
            this.btnShowMore.IconZoom = 90D;
            this.btnShowMore.IsTab = false;
            this.btnShowMore.Location = new System.Drawing.Point(0, 4);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnShowMore.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnShowMore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowMore.selected = false;
            this.btnShowMore.Size = new System.Drawing.Size(153, 48);
            this.btnShowMore.TabIndex = 17;
            this.btnShowMore.Text = "Show More";
            this.btnShowMore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowMore.Textcolor = System.Drawing.Color.White;
            this.btnShowMore.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMore.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // btnReload
            // 
            this.btnReload.Active = false;
            this.btnReload.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnReload.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 0;
            this.btnReload.ButtonText = "Reload";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReload.Iconimage")));
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 0;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = true;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 90D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(165, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnReload.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(153, 48);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Active = false;
            this.btnQuit.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnQuit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.BorderRadius = 0;
            this.btnQuit.ButtonText = "Quit";
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuit.Iconimage")));
            this.btnQuit.Iconimage_right = null;
            this.btnQuit.Iconimage_right_Selected = null;
            this.btnQuit.Iconimage_Selected = null;
            this.btnQuit.IconMarginLeft = 0;
            this.btnQuit.IconMarginRight = 0;
            this.btnQuit.IconRightVisible = true;
            this.btnQuit.IconRightZoom = 0D;
            this.btnQuit.IconVisible = true;
            this.btnQuit.IconZoom = 90D;
            this.btnQuit.IsTab = false;
            this.btnQuit.Location = new System.Drawing.Point(332, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnQuit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnQuit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuit.selected = false;
            this.btnQuit.Size = new System.Drawing.Size(153, 48);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Textcolor = System.Drawing.Color.White;
            this.btnQuit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnShowMore);
            this.panel2.Controls.Add(this.btnQuit);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Location = new System.Drawing.Point(300, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 54);
            this.panel2.TabIndex = 20;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(0, 390);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(788, 194);
            this.bunifuMaterialTextbox1.TabIndex = 21;
            this.bunifuMaterialTextbox1.Text = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblFileSize
            // 
            this.lblFileSize.BackColor = System.Drawing.Color.Transparent;
            this.lblFileSize.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFileSize.Location = new System.Drawing.Point(103, 145);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(12, 25);
            this.lblFileSize.TabIndex = 22;
            this.lblFileSize.Text = " ";
            // 
            // lblDownloadingSpeed
            // 
            this.lblDownloadingSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblDownloadingSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadingSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDownloadingSpeed.Location = new System.Drawing.Point(199, 176);
            this.lblDownloadingSpeed.Name = "lblDownloadingSpeed";
            this.lblDownloadingSpeed.Size = new System.Drawing.Size(12, 25);
            this.lblDownloadingSpeed.TabIndex = 23;
            this.lblDownloadingSpeed.Text = " ";
            // 
            // lblUrl
            // 
            this.lblUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUrl.Location = new System.Drawing.Point(578, 145);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(12, 25);
            this.lblUrl.TabIndex = 24;
            this.lblUrl.Text = " ";
            // 
            // Updater_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblDownloadingSpeed);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblDownloadSpeed);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updater_GUI";
            this.Text = "Updater_GUI";
            this.Load += new System.EventHandler(this.Updater_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDownloadSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTimeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTimeRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFrom)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblFileSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDownloadingSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadLabel lblStatus;
        private Telerik.WinControls.UI.RadLabel lblDownloadSpeed;
        private Telerik.WinControls.UI.RadLabel lblTimeLeft;
        private Telerik.WinControls.UI.RadLabel lblTimeRemaining;
        private Telerik.WinControls.UI.RadLabel lblFrom;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowMore;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuit;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Telerik.WinControls.UI.RadLabel lblFileSize;
        private Telerik.WinControls.UI.RadLabel lblDownloadingSpeed;
        private Telerik.WinControls.UI.RadLabel lblUrl;
    }
}