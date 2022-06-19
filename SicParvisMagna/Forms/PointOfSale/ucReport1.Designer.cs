namespace SicParvisMagna.Forms.PointOfSale
{
    partial class ucReport1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReport1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaleInvoice = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lblSubHeading);
            this.panel2.Location = new System.Drawing.Point(17, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 48);
            this.panel2.TabIndex = 41;
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSubHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.Black;
            this.lblSubHeading.Location = new System.Drawing.Point(287, 7);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(88, 30);
            this.lblSubHeading.TabIndex = 0;
            this.lblSubHeading.Text = "Reports";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Sale Invoice";
            // 
            // btnSaleInvoice
            // 
            this.btnSaleInvoice.ActiveBorderThickness = 1;
            this.btnSaleInvoice.ActiveCornerRadius = 20;
            this.btnSaleInvoice.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btnSaleInvoice.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaleInvoice.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btnSaleInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaleInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaleInvoice.BackgroundImage")));
            this.btnSaleInvoice.ButtonText = "Sale Invoice";
            this.btnSaleInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaleInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSaleInvoice.IdleBorderThickness = 1;
            this.btnSaleInvoice.IdleCornerRadius = 20;
            this.btnSaleInvoice.IdleFillColor = System.Drawing.Color.White;
            this.btnSaleInvoice.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btnSaleInvoice.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSaleInvoice.Location = new System.Drawing.Point(17, 121);
            this.btnSaleInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaleInvoice.Name = "btnSaleInvoice";
            this.btnSaleInvoice.Size = new System.Drawing.Size(207, 39);
            this.btnSaleInvoice.TabIndex = 57;
            this.btnSaleInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaleInvoice.Click += new System.EventHandler(this.btnSaleInvoice_Click);
            // 
            // ucReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSaleInvoice);
            this.Controls.Add(this.panel2);
            this.Name = "ucReport1";
            this.Size = new System.Drawing.Size(708, 786);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaleInvoice;
    }
}
