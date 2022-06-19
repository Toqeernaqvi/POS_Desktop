using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Controls.Buttons
{
    public partial class Inventory : UserControl
    {
        bool LinkExpanded = false;
        public Inventory()
        {
            InitializeComponent();
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            FormMain.loadBackForm();
            if (LinkExpanded == false)
            {
                this.Height = 368;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 45;
                LinkExpanded = false;
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormMain.loadSupplierForm();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FormMain.loadInvoiceForm();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FormMain.loadProductForm();
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            FormMain.loadPromotionForm();
        }

        

        private void btnCusIV_Click(object sender, EventArgs e)
        {
            FormMain.loadCustomerInvoiceForm();
        }
    }
}
