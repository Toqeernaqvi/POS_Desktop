namespace SicParvisMagna.Forms
{
    partial class ucAccessDenied
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
            this.AccessLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccessLbl
            // 
            this.AccessLbl.AutoSize = true;
            this.AccessLbl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessLbl.ForeColor = System.Drawing.Color.Red;
            this.AccessLbl.Location = new System.Drawing.Point(31, 28);
            this.AccessLbl.Name = "AccessLbl";
            this.AccessLbl.Size = new System.Drawing.Size(404, 23);
            this.AccessLbl.TabIndex = 0;
            this.AccessLbl.Text = "Sorry, You don\'t have rights to access this page";
            // 
            // ucAccessDenied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AccessLbl);
            this.Name = "ucAccessDenied";
            this.Size = new System.Drawing.Size(616, 572);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccessLbl;
    }
}
