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
    public partial class UserExpandable : UserControl
    {
        bool LinkExpanded = false;
        public UserExpandable()
        {
            InitializeComponent();
        }

        private void btnOpenHome_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 122;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 47;
                LinkExpanded = false;
            }
        }

        private void HomeExpandable_Load(object sender, EventArgs e)
        {

        }
    }
}
