using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class ucHospitalReports : UserControl
    {
        public ucHospitalReports()
        {
            InitializeComponent();
        }

        private void btnStockReports_Click(object sender, EventArgs e)
        {
            FormStockReport f = new FormStockReport();
            f.Show();
        }

        private void btnDailyPrescription_Click(object sender, EventArgs e)
        {
            FormPrescriptionReport f = new FormPrescriptionReport();
            f.Show();
        }
    }
}
