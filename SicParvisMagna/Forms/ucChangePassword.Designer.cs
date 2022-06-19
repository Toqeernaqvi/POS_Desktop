namespace SicParvisMagna.Forms
{
    partial class ucChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChangePassword));
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErrorRetypePassword = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Old  Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(368, 377);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(194, 20);
            this.txtOldPassword.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Please Change new  password to finish signing in.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "New Password";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Location = new System.Drawing.Point(368, 463);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(194, 20);
            this.txtRetypePassword.TabIndex = 43;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(432, 512);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(130, 31);
            this.btnChangePassword.TabIndex = 42;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(128, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(495, 32);
            this.label5.TabIndex = 41;
            this.label5.Text = "Welcome in Donation Managment System";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(368, 417);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 20);
            this.txtPassword.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Retype Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // lblErrorRetypePassword
            // 
            this.lblErrorRetypePassword.AutoSize = true;
            this.lblErrorRetypePassword.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblErrorRetypePassword.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorRetypePassword.Location = new System.Drawing.Point(568, 454);
            this.lblErrorRetypePassword.Name = "lblErrorRetypePassword";
            this.lblErrorRetypePassword.Size = new System.Drawing.Size(11, 15);
            this.lblErrorRetypePassword.TabIndex = 241;
            this.lblErrorRetypePassword.Text = "*";
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Roboto Condensed", 7.75F);
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorPassword.Location = new System.Drawing.Point(568, 417);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(11, 15);
            this.lblErrorPassword.TabIndex = 242;
            this.lblErrorPassword.Text = "*";
            // 
            // ucChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorRetypePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRetypePassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Name = "ucChangePassword";
            this.Size = new System.Drawing.Size(754, 688);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorRetypePassword;
        private System.Windows.Forms.Label lblErrorPassword;
    }
}
