namespace SicParvisMagna.Forms
{
    partial class FormUpdater
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
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnBrowseRF = new System.Windows.Forms.Button();
            this.btnBrowseOF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReplaceFilePath = new System.Windows.Forms.TextBox();
            this.txtOrignalFilePath = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtExtractPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtDownload = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSQLScript = new System.Windows.Forms.Button();
            this.txtSQLScript = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtUpdateLog = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDownloadingSpeed = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(445, 321);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(152, 33);
            this.btnReplace.TabIndex = 25;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBrowseRF
            // 
            this.btnBrowseRF.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseRF.Location = new System.Drawing.Point(551, 286);
            this.btnBrowseRF.Name = "btnBrowseRF";
            this.btnBrowseRF.Size = new System.Drawing.Size(110, 29);
            this.btnBrowseRF.TabIndex = 24;
            this.btnBrowseRF.Text = "Browse";
            this.btnBrowseRF.UseVisualStyleBackColor = true;
            this.btnBrowseRF.Click += new System.EventHandler(this.btnBrowseRF_Click);
            // 
            // btnBrowseOF
            // 
            this.btnBrowseOF.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOF.Location = new System.Drawing.Point(551, 245);
            this.btnBrowseOF.Name = "btnBrowseOF";
            this.btnBrowseOF.Size = new System.Drawing.Size(110, 29);
            this.btnBrowseOF.TabIndex = 23;
            this.btnBrowseOF.Text = "Browse";
            this.btnBrowseOF.UseVisualStyleBackColor = true;
            this.btnBrowseOF.Click += new System.EventHandler(this.btnBrowseOF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Replace File Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Orignal File Path";
            // 
            // txtReplaceFilePath
            // 
            this.txtReplaceFilePath.Location = new System.Drawing.Point(309, 292);
            this.txtReplaceFilePath.Name = "txtReplaceFilePath";
            this.txtReplaceFilePath.Size = new System.Drawing.Size(236, 20);
            this.txtReplaceFilePath.TabIndex = 20;
            // 
            // txtOrignalFilePath
            // 
            this.txtOrignalFilePath.Location = new System.Drawing.Point(309, 245);
            this.txtOrignalFilePath.Name = "txtOrignalFilePath";
            this.txtOrignalFilePath.Size = new System.Drawing.Size(236, 20);
            this.txtOrignalFilePath.TabIndex = 19;
            // 
            // btnExtract
            // 
            this.btnExtract.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Location = new System.Drawing.Point(427, 146);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(152, 33);
            this.btnExtract.TabIndex = 18;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtExtractPath
            // 
            this.txtExtractPath.Location = new System.Drawing.Point(300, 120);
            this.txtExtractPath.Name = "txtExtractPath";
            this.txtExtractPath.Size = new System.Drawing.Size(279, 20);
            this.txtExtractPath.TabIndex = 17;
            this.txtExtractPath.Text = "F:\\uPDATER aPPLICATION\\Updater Application WinForms\\Updater Application WinForms\\" +
    "bin\\Debug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Path for Extract File";
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(427, 59);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(152, 33);
            this.btnDownload.TabIndex = 15;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtDownload
            // 
            this.txtDownload.Location = new System.Drawing.Point(300, 33);
            this.txtDownload.Name = "txtDownload";
            this.txtDownload.Size = new System.Drawing.Size(279, 20);
            this.txtDownload.TabIndex = 14;
            this.txtDownload.Text = "http://globalteksoft.com/uploads/logo.zip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Paste Download Link";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Select SQL Script File ";
            // 
            // btnSQLScript
            // 
            this.btnSQLScript.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQLScript.Location = new System.Drawing.Point(551, 395);
            this.btnSQLScript.Name = "btnSQLScript";
            this.btnSQLScript.Size = new System.Drawing.Size(110, 29);
            this.btnSQLScript.TabIndex = 28;
            this.btnSQLScript.Text = "Browse";
            this.btnSQLScript.UseVisualStyleBackColor = true;
            this.btnSQLScript.Click += new System.EventHandler(this.btnSQLScript_Click);
            // 
            // txtSQLScript
            // 
            this.txtSQLScript.Location = new System.Drawing.Point(309, 395);
            this.txtSQLScript.Name = "txtSQLScript";
            this.txtSQLScript.Size = new System.Drawing.Size(236, 20);
            this.txtSQLScript.TabIndex = 27;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(445, 439);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(152, 33);
            this.btnExecute.TabIndex = 29;
            this.btnExecute.Text = "Replace";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtUpdateLog
            // 
            this.txtUpdateLog.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateLog.Location = new System.Drawing.Point(107, 547);
            this.txtUpdateLog.Multiline = true;
            this.txtUpdateLog.Name = "txtUpdateLog";
            this.txtUpdateLog.Size = new System.Drawing.Size(608, 157);
            this.txtUpdateLog.TabIndex = 31;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(585, 33);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 23);
            this.progressBar.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(847, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Downloaded 0%";
            // 
            // lblDownloadingSpeed
            // 
            this.lblDownloadingSpeed.AutoSize = true;
            this.lblDownloadingSpeed.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadingSpeed.Location = new System.Drawing.Point(787, 133);
            this.lblDownloadingSpeed.Name = "lblDownloadingSpeed";
            this.lblDownloadingSpeed.Size = new System.Drawing.Size(15, 15);
            this.lblDownloadingSpeed.TabIndex = 34;
            this.lblDownloadingSpeed.Text = " ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(787, 97);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(15, 15);
            this.lblTime.TabIndex = 35;
            this.lblTime.Text = " ";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.Location = new System.Drawing.Point(787, 66);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(15, 15);
            this.lblFileSize.TabIndex = 36;
            this.lblFileSize.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(582, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "File Size : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(582, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Estimated Time : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(582, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 18);
            this.label10.TabIndex = 37;
            this.label10.Text = "Downloading Speed : ";
            // 
            // FormUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 770);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDownloadingSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtUpdateLog);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnSQLScript);
            this.Controls.Add(this.txtSQLScript);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnBrowseRF);
            this.Controls.Add(this.btnBrowseOF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReplaceFilePath);
            this.Controls.Add(this.txtOrignalFilePath);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.txtExtractPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtDownload);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdater";
            this.Text = "FormUpdater";
            this.Load += new System.EventHandler(this.FormUpdater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnBrowseRF;
        private System.Windows.Forms.Button btnBrowseOF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReplaceFilePath;
        private System.Windows.Forms.TextBox txtOrignalFilePath;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtExtractPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSQLScript;
        private System.Windows.Forms.TextBox txtSQLScript;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtUpdateLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDownloadingSpeed;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}