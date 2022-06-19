namespace SicParvisMagna.Forms.PointOfSale
{
	partial class ucPurchaseIndex
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPurchaseIndex));
			this.btnPurchasing = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnReturning = new Bunifu.Framework.UI.BunifuThinButton2();
			this.SuspendLayout();
			// 
			// btnPurchasing
			// 
			this.btnPurchasing.ActiveBorderThickness = 1;
			this.btnPurchasing.ActiveCornerRadius = 20;
			this.btnPurchasing.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnPurchasing.ActiveForecolor = System.Drawing.Color.White;
			this.btnPurchasing.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnPurchasing.BackColor = System.Drawing.SystemColors.Control;
			this.btnPurchasing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPurchasing.BackgroundImage")));
			this.btnPurchasing.ButtonText = "Purchasing";
			this.btnPurchasing.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPurchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnPurchasing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.btnPurchasing.IdleBorderThickness = 1;
			this.btnPurchasing.IdleCornerRadius = 20;
			this.btnPurchasing.IdleFillColor = System.Drawing.Color.White;
			this.btnPurchasing.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnPurchasing.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.btnPurchasing.Location = new System.Drawing.Point(5, 5);
			this.btnPurchasing.Margin = new System.Windows.Forms.Padding(5);
			this.btnPurchasing.Name = "btnPurchasing";
			this.btnPurchasing.Size = new System.Drawing.Size(440, 79);
			this.btnPurchasing.TabIndex = 3;
			this.btnPurchasing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnPurchasing.Click += new System.EventHandler(this.btnPurchasing_Click);
			// 
			// btnReturning
			// 
			this.btnReturning.ActiveBorderThickness = 1;
			this.btnReturning.ActiveCornerRadius = 20;
			this.btnReturning.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnReturning.ActiveForecolor = System.Drawing.Color.White;
			this.btnReturning.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnReturning.BackColor = System.Drawing.SystemColors.Control;
			this.btnReturning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturning.BackgroundImage")));
			this.btnReturning.ButtonText = "Returning";
			this.btnReturning.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReturning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnReturning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.btnReturning.IdleBorderThickness = 1;
			this.btnReturning.IdleCornerRadius = 20;
			this.btnReturning.IdleFillColor = System.Drawing.Color.White;
			this.btnReturning.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnReturning.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.btnReturning.Location = new System.Drawing.Point(455, 5);
			this.btnReturning.Margin = new System.Windows.Forms.Padding(5);
			this.btnReturning.Name = "btnReturning";
			this.btnReturning.Size = new System.Drawing.Size(440, 79);
			this.btnReturning.TabIndex = 4;
			this.btnReturning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnReturning.Click += new System.EventHandler(this.btnReturning_Click);
			// 
			// ucPurchaseIndex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnPurchasing);
			this.Controls.Add(this.btnReturning);
			this.Name = "ucPurchaseIndex";
			this.Size = new System.Drawing.Size(908, 799);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuThinButton2 btnPurchasing;
		private Bunifu.Framework.UI.BunifuThinButton2 btnReturning;
	}
}
