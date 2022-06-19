namespace SicParvisMagna.Forms.Hospital.Patient
{
    partial class ucPatientIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPatientIndex));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_patient = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_patient_prescription = new Bunifu.Framework.UI.BunifuThinButton2();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.Controls.Add(this.btn_patient);
            this.flowLayoutPanel1.Controls.Add(this.btn_patient_prescription);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(705, 688);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_patient
            // 
            this.btn_patient.ActiveBorderThickness = 1;
            this.btn_patient.ActiveCornerRadius = 20;
            this.btn_patient.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btn_patient.ActiveForecolor = System.Drawing.Color.White;
            this.btn_patient.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btn_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_patient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_patient.BackgroundImage")));
            this.btn_patient.ButtonText = "Manage Patients";
            this.btn_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_patient.IdleBorderThickness = 1;
            this.btn_patient.IdleCornerRadius = 20;
            this.btn_patient.IdleFillColor = System.Drawing.Color.White;
            this.btn_patient.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btn_patient.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_patient.Location = new System.Drawing.Point(4, 4);
            this.btn_patient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(330, 64);
            this.btn_patient.TabIndex = 1;
            this.btn_patient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // btn_patient_prescription
            // 
            this.btn_patient_prescription.ActiveBorderThickness = 1;
            this.btn_patient_prescription.ActiveCornerRadius = 20;
            this.btn_patient_prescription.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btn_patient_prescription.ActiveForecolor = System.Drawing.Color.White;
            this.btn_patient_prescription.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btn_patient_prescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_patient_prescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_patient_prescription.BackgroundImage")));
            this.btn_patient_prescription.ButtonText = "Patient Prescriptions";
            this.btn_patient_prescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_patient_prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_patient_prescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_patient_prescription.IdleBorderThickness = 1;
            this.btn_patient_prescription.IdleCornerRadius = 20;
            this.btn_patient_prescription.IdleFillColor = System.Drawing.Color.White;
            this.btn_patient_prescription.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.btn_patient_prescription.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_patient_prescription.Location = new System.Drawing.Point(342, 4);
            this.btn_patient_prescription.Margin = new System.Windows.Forms.Padding(4);
            this.btn_patient_prescription.Name = "btn_patient_prescription";
            this.btn_patient_prescription.Size = new System.Drawing.Size(330, 64);
            this.btn_patient_prescription.TabIndex = 2;
            this.btn_patient_prescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_patient_prescription.Click += new System.EventHandler(this.btn_patient_prescription_Click);
            // 
            // ucPatientIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ucPatientIndex";
            this.Size = new System.Drawing.Size(705, 688);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_patient;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_patient_prescription;
    }
}
