using SicParvisMagna.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms
{
    public partial class ucInventory : UserControl
    {
        //private System.Windows.Forms.Panel container;

        public ucInventory()
        {
            InitializeComponent();
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            FormMain.loadSupplierForm();
            //  container.Controls.Clear();
            //  ucAddSupplier form = new ucAddSupplier();
            //form.Dock = DockStyle.Fill;
            // form.Show();
            //container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            FormMain.loadInvoiceForm();
            // container.Controls.Clear();
           // ucInvoice form = new ucInvoice();
            //form.Dock = DockStyle.Fill;
            //form.Show();
            //container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            FormMain.loadProductForm();
            //container.Controls.Clear();
         //   ucProduct form = new ucProduct();
           // form.Dock = DockStyle.Fill;
            //form.Show();
            //container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }

        private void btn_Promotion_Click(object sender, EventArgs e)
        {
            FormMain.loadPromotionForm();
            //container.Controls.Clear();
            //ucAddPromotion form = new ucAddPromotion();
            //form.Dock = DockStyle.Fill;
            //form.Show();
            //container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }

         

        private void btn_CusIV_Click(object sender, EventArgs e)
        {
           // FormMain.loadCustomerInvoiceForm();
            //container.Controls.Clear();
          //  ucCustomerInvoice form = new ucCustomerInvoice();
            //form.Dock = DockStyle.Fill;
            //form.Show();
            //container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }
    }
}
