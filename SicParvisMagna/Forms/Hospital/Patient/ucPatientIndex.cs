using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms.Hospital.Patient
{
    public partial class ucPatientIndex : UserControl
    {
        public ucPatientIndex( )
        {
            InitializeComponent();
         }

        private POSMain formMain;
        public ucPatientIndex(POSMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            formMain.loadPatient();

        }

        private void btn_patient_prescription_Click(object sender, EventArgs e)
        {
            formMain.loadPatientPrescription();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            formMain.loadPatientPrescription();
            //FormMain.loadIndexBackForm();
        }
    }
}
