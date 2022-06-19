using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Reports.UserControls
{
    public partial class reportMonthlyAttendencePercentage : UserControl
    {
        public reportMonthlyAttendencePercentage()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("EmployeeMonthlyAttendencePercentage", "EmployeeMonthlyAttendencePercentage", dtpDate.Value);
            f.Show();
        }
    }
}
