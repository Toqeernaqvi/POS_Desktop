using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Reports.PointOfSaleReports
{
    public partial class FormInvoiceReport : Form
    {
        public FormInvoiceReport()
        {
            InitializeComponent();
        }

        private void FormInvoiceReport_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text.Length>=5)
            {
                FormReport f = new FormReport("SaleInvoice_By InvoiceNo", "SaleInvoice_By InvoiceNo",  txtInvoiceNo.Text);
                f.Show();
            }
       
            FormReport f1 = new FormReport("SaleInvoice_ByDate", "SaleInvoice_ByDate",  dtpDate.Value);
            f1.Show();
        }
    }
}
