namespace SicParvisMagna.Forms.PointOfSale
{
	partial class ucGenerateBarcode
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
			this.GenerateBtn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// GenerateBtn
			// 
			this.GenerateBtn.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GenerateBtn.Location = new System.Drawing.Point(497, 120);
			this.GenerateBtn.Name = "GenerateBtn";
			this.GenerateBtn.Size = new System.Drawing.Size(170, 34);
			this.GenerateBtn.TabIndex = 0;
			this.GenerateBtn.Text = "Generate";
			this.GenerateBtn.UseVisualStyleBackColor = true;
			this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(45, 186);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(622, 327);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(45, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(421, 34);
			this.textBox1.TabIndex = 2;
			// 
			// ucGenerateBarcode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.GenerateBtn);
			this.Name = "ucGenerateBarcode";
			this.Size = new System.Drawing.Size(737, 583);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GenerateBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
