using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class FormPrescriptionReport : Form
    {
        public FormPrescriptionReport()
        {
            InitializeComponent();
            dtp_Month.Value = DateTime.Now;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
             FormReport rptview = new FormReport("Report Viewer - Daily Prescription List" + dtp_Month.Value.ToString("dd-MM-yyyy"), "DailyPrescriptionList", dtp_Month.Value, dtp_Month.Value);
            rptview.Show();
        }
    }
}
