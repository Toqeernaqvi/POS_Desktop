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
    public partial class btnManageVariants : UserControl
    {
        bool LinkExpanded = false;
        public btnManageVariants()
        {
            InitializeComponent();
        }

        private void btnVariants_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 160;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 47;
                LinkExpanded = false;
            }
        }

        private void btVariantType_Click(object sender, EventArgs e)
        {
            POSMain.loadVariantTypes();
        }

        private void btnMVariants_Click(object sender, EventArgs e)
        {
            POSMain.loadVariants();

        }

        private void btnMAnageVariant_Click(object sender, EventArgs e)
        {
            POSMain.loadManageVariants();
        }
    }
}
