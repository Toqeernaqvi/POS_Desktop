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
    public partial class btnSales : UserControl
    {
     
      
        public btnSales()
        {
            InitializeComponent();
        }
        bool LinkExpanded = false;
        private void btnAttendence_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height =200;
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
            POSMain.loadSaleOrder();
        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {
            POSMain.loadReturnSaleOrder();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            POSMain.loadSaleScreen();
        }
    }
}
