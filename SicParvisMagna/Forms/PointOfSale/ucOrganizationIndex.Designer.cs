namespace SicParvisMagna.Forms.PointOfSale
{
	partial class ucOrganizationIndex
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrganizationIndex));
			this.btnOrganization = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnBranch = new Bunifu.Framework.UI.BunifuThinButton2();
			this.SuspendLayout();
			// 
			// btnOrganization
			// 
			this.btnOrganization.ActiveBorderThickness = 1;
			this.btnOrganization.ActiveCornerRadius = 20;
			this.btnOrganization.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnOrganization.ActiveForecolor = System.Drawing.Color.White;
			this.btnOrganization.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnOrganization.BackColor = System.Drawing.SystemColors.Control;
			this.btnOrganization.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrganization.BackgroundImage")));
			this.btnOrganization.ButtonText = "Manage Organizations";
			this.btnOrganization.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnOrganization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.btnOrganization.IdleBorderThickness = 1;
			this.btnOrganization.IdleCornerRadius = 20;
			this.btnOrganization.IdleFillColor = System.Drawing.Color.White;
			this.btnOrganization.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnOrganization.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.btnOrganization.Location = new System.Drawing.Point(4, 5);
			this.btnOrganization.Margin = new System.Windows.Forms.Padding(5);
			this.btnOrganization.Name = "btnOrganization";
			this.btnOrganization.Size = new System.Drawing.Size(440, 79);
			this.btnOrganization.TabIndex = 3;
			this.btnOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnOrganization.Click += new System.EventHandler(this.btnOrganization_Click);
			// 
			// btnBranch
			// 
			this.btnBranch.ActiveBorderThickness = 1;
			this.btnBranch.ActiveCornerRadius = 20;
			this.btnBranch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnBranch.ActiveForecolor = System.Drawing.Color.White;
			this.btnBranch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnBranch.BackColor = System.Drawing.SystemColors.Control;
			this.btnBranch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBranch.BackgroundImage")));
			this.btnBranch.ButtonText = "Manage Branch";
			this.btnBranch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.btnBranch.IdleBorderThickness = 1;
			this.btnBranch.IdleCornerRadius = 20;
			this.btnBranch.IdleFillColor = System.Drawing.Color.White;
			this.btnBranch.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
			this.btnBranch.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.btnBranch.Location = new System.Drawing.Point(454, 5);
			this.btnBranch.Margin = new System.Windows.Forms.Padding(5);
			this.btnBranch.Name = "btnBranch";
			this.btnBranch.Size = new System.Drawing.Size(440, 79);
			this.btnBranch.TabIndex = 4;
			this.btnBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
			// 
			// ucOrganizationIndex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnOrganization);
			this.Controls.Add(this.btnBranch);
			this.Name = "ucOrganizationIndex";
			this.Size = new System.Drawing.Size(903, 798);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuThinButton2 btnOrganization;
		private Bunifu.Framework.UI.BunifuThinButton2 btnBranch;
	}
}
