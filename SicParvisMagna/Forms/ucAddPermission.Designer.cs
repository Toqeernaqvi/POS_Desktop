namespace SicParvisMagna.Forms
{
    partial class ucAddPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddPermission));
            this.cbx_User = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridPermission = new System.Windows.Forms.DataGridView();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.chkBx_Edit = new System.Windows.Forms.CheckBox();
            this.chkBx_View = new System.Windows.Forms.CheckBox();
            this.chkBx_Del = new System.Windows.Forms.CheckBox();
            this.chkBx_Add = new System.Windows.Forms.CheckBox();
            this.chkBx_SelectAll = new System.Windows.Forms.CheckBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPermission)).BeginInit();
            this.panelToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_User
            // 
            this.cbx_User.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbx_User.FormattingEnabled = true;
            this.cbx_User.Location = new System.Drawing.Point(112, 37);
            this.cbx_User.Name = "cbx_User";
            this.cbx_User.Size = new System.Drawing.Size(217, 25);
            this.cbx_User.TabIndex = 248;
            this.cbx_User.SelectionChangeCommitted += new System.EventHandler(this.cbx_User_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 247;
            this.label2.Text = "Select User";
            // 
            // gridPermission
            // 
            this.gridPermission.AllowUserToAddRows = false;
            this.gridPermission.AllowUserToDeleteRows = false;
            this.gridPermission.AllowUserToResizeColumns = false;
            this.gridPermission.AllowUserToResizeRows = false;
            this.gridPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPermission.Location = new System.Drawing.Point(0, 206);
            this.gridPermission.Name = "gridPermission";
            this.gridPermission.Size = new System.Drawing.Size(754, 482);
            this.gridPermission.TabIndex = 257;
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.chkBx_Edit);
            this.panelToolBox.Controls.Add(this.chkBx_View);
            this.panelToolBox.Controls.Add(this.chkBx_Del);
            this.panelToolBox.Controls.Add(this.chkBx_Add);
            this.panelToolBox.Controls.Add(this.chkBx_SelectAll);
            this.panelToolBox.Controls.Add(this.btnSave);
            this.panelToolBox.Controls.Add(this.label2);
            this.panelToolBox.Controls.Add(this.cbx_User);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(754, 206);
            this.panelToolBox.TabIndex = 258;
            // 
            // chkBx_Edit
            // 
            this.chkBx_Edit.AutoSize = true;
            this.chkBx_Edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_Edit.Location = new System.Drawing.Point(148, 155);
            this.chkBx_Edit.Name = "chkBx_Edit";
            this.chkBx_Edit.Size = new System.Drawing.Size(105, 23);
            this.chkBx_Edit.TabIndex = 261;
            this.chkBx_Edit.Text = "Select Edit";
            this.chkBx_Edit.UseVisualStyleBackColor = true;
            this.chkBx_Edit.CheckedChanged += new System.EventHandler(this.chkBx_Edit_CheckedChanged_1);
            // 
            // chkBx_View
            // 
            this.chkBx_View.AutoSize = true;
            this.chkBx_View.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_View.Location = new System.Drawing.Point(276, 155);
            this.chkBx_View.Name = "chkBx_View";
            this.chkBx_View.Size = new System.Drawing.Size(116, 23);
            this.chkBx_View.TabIndex = 260;
            this.chkBx_View.Text = "Select View";
            this.chkBx_View.UseVisualStyleBackColor = true;
            this.chkBx_View.CheckedChanged += new System.EventHandler(this.chkBx_View_CheckedChanged_1);
            // 
            // chkBx_Del
            // 
            this.chkBx_Del.AutoSize = true;
            this.chkBx_Del.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_Del.Location = new System.Drawing.Point(411, 155);
            this.chkBx_Del.Name = "chkBx_Del";
            this.chkBx_Del.Size = new System.Drawing.Size(103, 23);
            this.chkBx_Del.TabIndex = 259;
            this.chkBx_Del.Text = "Select Del";
            this.chkBx_Del.UseVisualStyleBackColor = true;
            this.chkBx_Del.CheckedChanged += new System.EventHandler(this.chkBx_Del_CheckedChanged_1);
            // 
            // chkBx_Add
            // 
            this.chkBx_Add.AutoSize = true;
            this.chkBx_Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_Add.Location = new System.Drawing.Point(19, 155);
            this.chkBx_Add.Name = "chkBx_Add";
            this.chkBx_Add.Size = new System.Drawing.Size(112, 23);
            this.chkBx_Add.TabIndex = 258;
            this.chkBx_Add.Text = "Select Add";
            this.chkBx_Add.UseVisualStyleBackColor = true;
            this.chkBx_Add.CheckedChanged += new System.EventHandler(this.chkBx_Add_CheckedChanged_1);
            // 
            // chkBx_SelectAll
            // 
            this.chkBx_SelectAll.AutoSize = true;
            this.chkBx_SelectAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_SelectAll.Location = new System.Drawing.Point(636, 118);
            this.chkBx_SelectAll.Name = "chkBx_SelectAll";
            this.chkBx_SelectAll.Size = new System.Drawing.Size(98, 23);
            this.chkBx_SelectAll.TabIndex = 257;
            this.chkBx_SelectAll.Text = "Select All";
            this.chkBx_SelectAll.UseVisualStyleBackColor = true;
            this.chkBx_SelectAll.CheckedChanged += new System.EventHandler(this.chkBx_SelectAll_CheckedChanged_1);
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
            this.btnSave.Location = new System.Drawing.Point(666, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 99);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucAddPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.gridPermission);
            this.Name = "ucAddPermission";
            this.Size = new System.Drawing.Size(754, 688);
            this.Load += new System.EventHandler(this.ucAddPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPermission)).EndInit();
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridPermission;
        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuTileButton btnSave;
        private System.Windows.Forms.CheckBox chkBx_Edit;
        private System.Windows.Forms.CheckBox chkBx_View;
        private System.Windows.Forms.CheckBox chkBx_Del;
        private System.Windows.Forms.CheckBox chkBx_Add;
        private System.Windows.Forms.CheckBox chkBx_SelectAll;
    }
}
