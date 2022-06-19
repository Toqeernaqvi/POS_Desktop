namespace SicParvisMagna.Setting_Forms
{
    partial class ucBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBackup));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabState = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBackup = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPathDatabase = new System.Windows.Forms.TextBox();
            this.btnRestore = new MetroFramework.Controls.MetroButton();
            this.btnBrowseDatabase = new MetroFramework.Controls.MetroButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabState.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.label2);
            this.panelToolBox.Controls.Add(this.label1);
            this.panelToolBox.Controls.Add(this.pictureBox2);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 99);
            this.panelToolBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Take Database Backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Here";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(337, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabState
            // 
            this.tabState.Controls.Add(this.metroTabPage1);
            this.tabState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabState.Location = new System.Drawing.Point(0, 99);
            this.tabState.Name = "tabState";
            this.tabState.SelectedIndex = 0;
            this.tabState.Size = new System.Drawing.Size(754, 589);
            this.tabState.TabIndex = 23;
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
            this.metroTabPage1.Size = new System.Drawing.Size(746, 547);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Backup";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 547);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPath);
            this.panel6.Controls.Add(this.btnBackup);
            this.panel6.Controls.Add(this.btnBrowse);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 121);
            this.panel6.TabIndex = 44;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(177, 19);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(246, 39);
            this.txtPath.TabIndex = 6;
            // 
            // btnBackup
            // 
            this.btnBackup.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBackup.Location = new System.Drawing.Point(429, 80);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(92, 39);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBackup.UseSelectable = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBrowse.Location = new System.Drawing.Point(429, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 39);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 10);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPathDatabase);
            this.panel2.Controls.Add(this.btnRestore);
            this.panel2.Controls.Add(this.btnBrowseDatabase);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(3, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 183);
            this.panel2.TabIndex = 46;
            // 
            // txtPathDatabase
            // 
            this.txtPathDatabase.Location = new System.Drawing.Point(177, 71);
            this.txtPathDatabase.Multiline = true;
            this.txtPathDatabase.Name = "txtPathDatabase";
            this.txtPathDatabase.Size = new System.Drawing.Size(246, 39);
            this.txtPathDatabase.TabIndex = 6;
            // 
            // btnRestore
            // 
            this.btnRestore.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRestore.Location = new System.Drawing.Point(429, 132);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(92, 39);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRestore.UseSelectable = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseDatabase
            // 
            this.btnBrowseDatabase.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBrowseDatabase.Location = new System.Drawing.Point(429, 71);
            this.btnBrowseDatabase.Name = "btnBrowseDatabase";
            this.btnBrowseDatabase.Size = new System.Drawing.Size(92, 39);
            this.btnBrowseDatabase.TabIndex = 5;
            this.btnBrowseDatabase.Text = "Browse";
            this.btnBrowseDatabase.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBrowseDatabase.UseSelectable = true;
            this.btnBrowseDatabase.Click += new System.EventHandler(this.btnBrowseDatabase_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Restore Database";
            // 
            // ucBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabState);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucBackup";
            this.Size = new System.Drawing.Size(754, 688);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabState.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private MetroFramework.Controls.MetroTabControl tabState;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPath;
        private MetroFramework.Controls.MetroButton btnBackup;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPathDatabase;
        private MetroFramework.Controls.MetroButton btnRestore;
        private MetroFramework.Controls.MetroButton btnBrowseDatabase;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
