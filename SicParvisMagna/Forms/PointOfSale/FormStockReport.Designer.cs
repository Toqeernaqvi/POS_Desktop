namespace SicParvisMagna.Forms.PointOfSale
{
    partial class FormStockReport
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.rdMonth = new System.Windows.Forms.RadioButton();
            this.rdDay = new System.Windows.Forms.RadioButton();
            this.dtp_Month = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 31);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(146, 30);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Stock Reports";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(125, 233);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(132, 38);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rdMonth
            // 
            this.rdMonth.AutoSize = true;
            this.rdMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMonth.Location = new System.Drawing.Point(40, 158);
            this.rdMonth.Name = "rdMonth";
            this.rdMonth.Size = new System.Drawing.Size(139, 25);
            this.rdMonth.TabIndex = 9;
            this.rdMonth.TabStop = true;
            this.rdMonth.Text = "Load By Month";
            this.rdMonth.UseVisualStyleBackColor = true;
            // 
            // rdDay
            // 
            this.rdDay.AutoSize = true;
            this.rdDay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDay.Location = new System.Drawing.Point(41, 191);
            this.rdDay.Name = "rdDay";
            this.rdDay.Size = new System.Drawing.Size(117, 25);
            this.rdDay.TabIndex = 10;
            this.rdDay.TabStop = true;
            this.rdDay.Text = "Load By Day";
            this.rdDay.UseVisualStyleBackColor = true;
            // 
            // dtp_Month
            // 
            this.dtp_Month.Location = new System.Drawing.Point(41, 96);
            this.dtp_Month.Name = "dtp_Month";
            this.dtp_Month.Size = new System.Drawing.Size(264, 20);
            this.dtp_Month.TabIndex = 11;
            // 
            // FormStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 315);
            this.Controls.Add(this.dtp_Month);
            this.Controls.Add(this.rdDay);
            this.Controls.Add(this.rdMonth);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "FormStockReport";
            this.Text = "FormStockReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RadioButton rdMonth;
        private System.Windows.Forms.RadioButton rdDay;
        private System.Windows.Forms.DateTimePicker dtp_Month;
    }
}