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
    public partial class btnCategory : UserControl
    {
     
        bool LinkExpanded = false;
        public btnCategory()
        {
            InitializeComponent();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {

            POSMain.loadSubCategory();
        }

        
    }
}
