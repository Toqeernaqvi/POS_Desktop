using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Reports.PointOfSaleReports;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class ucReport1 : UserControl
    {
        public ucReport1()
        {
            InitializeComponent();
        }

        private void btnSaleInvoice_Click(object sender, EventArgs e)
        {
            FormInvoiceReport f = new FormInvoiceReport();
            f.Show();
        }
    }
}
