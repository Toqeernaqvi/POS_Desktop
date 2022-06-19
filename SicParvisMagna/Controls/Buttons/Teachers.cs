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
    public partial class Teachers : UserControl
    {
        bool LinkExpanded = false;
        public Teachers()
        {
            InitializeComponent();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 215;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 43;
                LinkExpanded = false;
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            FormMain.loadTeachersform();
        }
    }
}
