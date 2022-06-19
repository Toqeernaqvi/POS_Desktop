using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms
{
    public partial class ucCustomerInvoice : UserControl
    {
        //private System.Windows.Forms.Panel container;
        public ucCustomerInvoice()
        {
            InitializeComponent();
        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FormMain.loadBackForm();
         //   container.Controls.Clear();
         //   ucInventory form = new ucInventory();
         //   form.Dock = DockStyle.Fill;
         //   container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }
    }
}
