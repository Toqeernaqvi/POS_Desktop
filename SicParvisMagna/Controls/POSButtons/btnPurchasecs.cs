using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Controls.POSButtons
{
    public partial class btnPurchasecs : UserControl
    {
     
        bool LinkExpanded = false;
        public btnPurchasecs()
        {
            InitializeComponent();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 100;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 47;
                LinkExpanded = false;
            }
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            POSMain.loadPurchaseOrder();
        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {
            POSMain.loadReturnOrder();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            POSMain.loadPartyForm();
        }
    }
}
