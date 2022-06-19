namespace SicParvisMagna.Forms.ChartOfAccounts
{
    partial class FormFeeSubmitSecondry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFeeSubmitSecondry));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPendingFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReciept = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArrear = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblChallan = new System.Windows.Forms.Label();
            this.panelToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.btnClear);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(800, 99);
            this.panelToolBox.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImagePosition = 17;
            this.btnClear.ImageZoom = 73;
            this.btnClear.LabelPosition = 34;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(77, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 99);
            this.btnClear.TabIndex = 6;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePosition = 17;
            this.btnSave.ImageZoom = 73;
            this.btnSave.LabelPosition = 34;
            this.btnSave.LabelText = "Save";
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 99);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotal.Location = new System.Drawing.Point(198, 260);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(0, 21);
            this.lblGrandTotal.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 63;
            this.label5.Text = "Grand Total: ";
            // 
            // lblPendingFee
            // 
            this.lblPendingFee.AutoSize = true;
            this.lblPendingFee.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingFee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingFee.ForeColor = System.Drawing.Color.Black;
            this.lblPendingFee.Location = new System.Drawing.Point(198, 182);
            this.lblPendingFee.Name = "lblPendingFee";
            this.lblPendingFee.Size = new System.Drawing.Size(0, 21);
            this.lblPendingFee.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Pending Fee: ";
            // 
            // txtReciept
            // 
            this.txtReciept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReciept.Location = new System.Drawing.Point(198, 374);
            this.txtReciept.Name = "txtReciept";
            this.txtReciept.Size = new System.Drawing.Size(152, 27);
            this.txtReciept.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Reciept Number: ";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(198, 221);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 21);
            this.lblTotalAmount.TabIndex = 58;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(198, 297);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(152, 27);
            this.numericUpDown1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Deposited Amount: ";
            // 
            // lblArrear
            // 
            this.lblArrear.AutoSize = true;
            this.lblArrear.BackColor = System.Drawing.Color.Transparent;
            this.lblArrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrear.ForeColor = System.Drawing.Color.Black;
            this.lblArrear.Location = new System.Drawing.Point(119, 338);
            this.lblArrear.Name = "lblArrear";
            this.lblArrear.Size = new System.Drawing.Size(71, 21);
            this.lblArrear.TabIndex = 54;
            this.lblArrear.Text = "Arrear:  ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(64, 221);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(126, 21);
            this.lblAmount.TabIndex = 55;
            this.lblAmount.Text = "Total Amount: ";
            // 
            // lblChallan
            // 
            this.lblChallan.AutoSize = true;
            this.lblChallan.BackColor = System.Drawing.Color.Transparent;
            this.lblChallan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallan.ForeColor = System.Drawing.Color.Black;
            this.lblChallan.Location = new System.Drawing.Point(73, 143);
            this.lblChallan.Name = "lblChallan";
            this.lblChallan.Size = new System.Drawing.Size(117, 21);
            this.lblChallan.TabIndex = 53;
            this.lblChallan.Text = "Challan No#: ";
            // 
            // FormFeeSubmitSecondry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPendingFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReciept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArrear);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblChallan);
            this.Controls.Add(this.panelToolBox);
            this.Name = "FormFeeSubmitSecondry";
            this.Text = "FormFeeSubmitSecondry";
            this.panelToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPendingFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReciept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArrear;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblChallan;
    }
}