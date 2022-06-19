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
    public partial class ucEmployeeReports : UserControl
    {
        public ucEmployeeReports()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("Employeelist","Employeelist");
            f.Show();
            
        }

        private void btnEmployeeAttendence_Click(object sender, EventArgs e)
        {
            FormMain.loadReportAttendence();
             
        }

        private void btnEmployeeMonthlyAttendence_Click(object sender, EventArgs e)
        {
            FormMain.loadReportMonthlyAttendence();
        }

        private void btnMonthlyAttendencePercentage_Click(object sender, EventArgs e)
        {
            FormMain.loadReportMonthlyAttendencePercentage();
        }

        private void btnEmployeeMonthlyAttendence2_Click(object sender, EventArgs e)
        {
            FormMain.loadReportMonthlyAttendence2();
        }

        private void btnEmployeeSalary_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport("SalaryByDepartment", "SalaryByDepartment");
            f.Show();
        }

        private void ucEmployeeReports_Load(object sender, EventArgs e)
        {
            btnEmployeeAttendence.Enabled = false;
            btnEmployeeMonthlyAttendence.Enabled = false;
            btnEmployeeMonthlyAttendence2.Enabled = false;
            btnEmployeeReports.Enabled = false;
            
            btnMonthlyAttendencePercentage.Enabled = false;
            
        }
    }
}
