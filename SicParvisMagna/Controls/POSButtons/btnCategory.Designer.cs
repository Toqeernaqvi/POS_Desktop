namespace SicParvisMagna.Controls.POSButtons
{
    partial class btnCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnCategory));
            this.btnAttendence = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnAttendence
            // 
            this.btnAttendence.Active = false;
            this.btnAttendence.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnAttendence.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnAttendence.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttendence.BorderRadius = 0;
            this.btnAttendence.ButtonText = "Categories";
            this.btnAttendence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendence.DisabledColor = System.Drawing.Color.Gray;
            this.btnAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendence.ForeColor = System.Drawing.Color.Transparent;
            this.btnAttendence.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAttendence.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAttendence.Iconimage")));
            this.btnAttendence.Iconimage_right = null;
            this.btnAttendence.Iconimage_right_Selected = null;
            this.btnAttendence.Iconimage_Selected = null;
            this.btnAttendence.IconMarginLeft = 0;
            this.btnAttendence.IconMarginRight = 0;
            this.btnAttendence.IconRightVisible = false;
            this.btnAttendence.IconRightZoom = 0D;
            this.btnAttendence.IconVisible = true;
            this.btnAttendence.IconZoom = 70D;
            this.btnAttendence.IsTab = true;
            this.btnAttendence.Location = new System.Drawing.Point(4, 4);
            this.btnAttendence.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAttendence.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnAttendence.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAttendence.selected = false;
            this.btnAttendence.Size = new System.Drawing.Size(271, 50);
            this.btnAttendence.TabIndex = 5;
            this.btnAttendence.Text = "Categories";
            this.btnAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttendence.Textcolor = System.Drawing.Color.Transparent;
            this.btnAttendence.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            // 
            // btnCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.btnAttendence);
            this.Name = "btnCategory";
            this.Size = new System.Drawing.Size(268, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAttendence;
    }
}
