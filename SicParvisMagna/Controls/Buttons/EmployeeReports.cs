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
    public partial class EmployeeReports : UserControl
    {
        bool LinkExpanded = false;
        public EmployeeReports()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormMain.loadEmployeeReports();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 143;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 47;
                LinkExpanded = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormMain.ManageReports();
        }
    }
}
