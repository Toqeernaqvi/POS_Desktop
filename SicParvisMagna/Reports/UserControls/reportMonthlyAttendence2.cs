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
    public partial class reportMonthlyAttendence2 : UserControl
    {
        public reportMonthlyAttendence2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            FormReport f = new FormReport("ReportEmployeeMonthlyAttendencePercentage", "ReportEmployeeMonthlyAttendencePercentage", dtpDate.Value);
            f.Show();
        }
    }
}
