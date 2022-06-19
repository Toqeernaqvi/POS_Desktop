namespace SicParvisMagna.Reports.PointOfSaleReports
{
    partial class ReportPurchaseOrderDMY
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Purchase Order Report";
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtpDate.Location = new System.Drawing.Point(136, 129);
            this.dtpDate.Name = "dtpDate";
            // 
            // 
            // 
            this.dtpDate.RootElement.ControlBounds = new System.Drawing.Rectangle(59, 121, 164, 20);
            this.dtpDate.RootElement.StretchVertically = true;
            this.dtpDate.Size = new System.Drawing.Size(185, 25);
            this.dtpDate.TabIndex = 33;
            this.dtpDate.TabStop = false;
            this.dtpDate.Text = "Tuesday, May 14, 2019";
            this.dtpDate.Value = new System.DateTime(2019, 5, 14, 4, 0, 55, 636);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(120, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Select  Date";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(298, 160);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 42);
            this.metroButton1.TabIndex = 35;
            this.metroButton1.Text = "Load Report";
            this.metroButton1.UseSelectable = true;
            // 
            // ReportPurchaseOrderDMY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 256);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportPurchaseOrderDMY";
            this.Text = "ReportPurchaseOrderDMY";
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}