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
    public partial class reportMonthlyAttendence : UserControl
    {
        public reportMonthlyAttendence()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //DateTime last_Date = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, 1).AddMonths(1).AddDays(-1);

            int year = dtpDate.Value.Year;
            int month = dtpDate.Value.Month;
            FormReport f = new FormReport("EmployeeMonthlyAttendence", "EmployeeMonthlyAttendence",  year,month);
            f.Show();
        }

        private void reportMonthlyAttendence_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void reportMonthlyAttendence_Load(object sender, EventArgs e)
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            //

            dtpDate.CustomFormat = "MM-yyyy";
        }
    }
}
