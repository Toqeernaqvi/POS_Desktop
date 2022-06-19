namespace SicParvisMagna.Reports.PointOfSaleReports
{
    partial class FormInvoiceReport
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
            this.btnLoadReport = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.Location = new System.Drawing.Point(315, 249);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(96, 42);
            this.btnLoadReport.TabIndex = 39;
            this.btnLoadReport.Text = "Load Report";
            this.btnLoadReport.UseSelectable = true;
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(86, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Select  Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sale Invoice Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(86, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Invoice No.";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(186, 105);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(189, 20);
            this.txtInvoiceNo.TabIndex = 41;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(190, 147);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 29);
            this.dtpDate.TabIndex = 42;
            // 
            // FormInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 330);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoadReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInvoiceReport";
            this.Text = "FormInvoiceReport";
            this.Load += new System.EventHandler(this.FormInvoiceReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLoadReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private MetroFramework.Controls.MetroDateTime dtpDate;
    }
}