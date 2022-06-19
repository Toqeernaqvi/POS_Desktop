namespace SicParvisMagna.Reports_Form
{
	partial class BarcodeForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(9, 72);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(990, 538);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ShowBtn
            // 
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.Location = new System.Drawing.Point(579, 23);
            this.ShowBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(114, 34);
            this.ShowBtn.TabIndex = 1;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // txtCopy
            // 
            this.txtCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopy.Location = new System.Drawing.Point(429, 24);
            this.txtCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(134, 28);
            this.txtCopy.TabIndex = 2;
            this.txtCopy.Text = "1";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(117, 24);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(134, 28);
            this.txtCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. of copy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Code";
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllBtn.Location = new System.Drawing.Point(698, 23);
            this.ShowAllBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(110, 34);
            this.ShowAllBtn.TabIndex = 7;
            this.ShowAllBtn.Text = "Show All";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 619);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.crystalReportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BarcodeForm";
            this.Text = "BarcodeForm";
            this.Load += new System.EventHandler(this.BarcodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private System.Windows.Forms.Button ShowBtn;
		private System.Windows.Forms.TextBox txtCopy;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ShowAllBtn;
	}
}