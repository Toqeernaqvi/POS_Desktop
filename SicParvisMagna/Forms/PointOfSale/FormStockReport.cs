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
    public partial class FormStockReport : Form
    {
        public FormStockReport()
        {
            InitializeComponent();
            dtp_Month.Value = DateTime.Now;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            if (rdMonth.Checked)
            {
                FormReport rptview = new FormReport("Report Viewer - Medicine In-Stock Monthy" + dtp_Month.Value.ToString("dd-MM-yyyy"), "MedicineInStockMonthWise", dtp_Month.Value, dtp_Month.Value);
                rptview.Show();
            }
            else if (rdDay.Checked)
            {
                FormReport rptview = new FormReport("Report Viewer - Medicine In-Stock Daily" + dtp_Month.Value.ToString("dd-MM-yyyy"), "MedicineInStockDaily", dtp_Month.Value, dtp_Month.Value);
                rptview.Show();
            }
            else
            {
                //FormReport rptview = new FormReport("Report Viewer - Medicine In-Stock", "MedicineInStock");
                //rptview.Show();
            }
        }
    }
}
