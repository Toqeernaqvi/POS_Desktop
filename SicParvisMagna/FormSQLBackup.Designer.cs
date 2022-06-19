namespace SicParvisMagna
{
    partial class FormSQLBackup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSQLBackup));
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radProgressBar = new Telerik.WinControls.UI.RadProgressBar();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelTop;
            this.bunifuDragControl.Vertical = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Silver;
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
            this.panelTop.Size = new System.Drawing.Size(459, 50);
            this.panelTop.TabIndex = 14;
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblMainHeader.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.lblMainHeader.Location = new System.Drawing.Point(12, 9);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(218, 22);
            this.lblMainHeader.TabIndex = 4;
            this.lblMainHeader.Text = "SQL Database Backup";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.radProgressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 30);
            this.panel1.TabIndex = 15;
            // 
            // radProgressBar
            // 
            this.radProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radProgressBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProgressBar.Location = new System.Drawing.Point(0, 0);
            this.radProgressBar.Name = "radProgressBar";
            // 
            // 
            // 
            this.radProgressBar.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 130, 24);
            this.radProgressBar.Size = new System.Drawing.Size(459, 30);
            this.radProgressBar.TabIndex = 0;
            this.radProgressBar.Text = "-";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.MinimumSize = new System.Drawing.Size(790, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(790, 450);
            this.panelLeft.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormSQLBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Name = "FormSQLBackup";
            this.Text = "FormSQLBackup";
            this.Load += new System.EventHandler(this.FormSQLBackup_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelTop;
        private System.Windows.Forms.Label lblMainHeader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar;
        private System.Windows.Forms.Panel panelLeft;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}