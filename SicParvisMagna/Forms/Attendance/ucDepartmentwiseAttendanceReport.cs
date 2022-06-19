using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms.Attendance
{
    public partial class ucDepartmentwiseAttendanceReport : UserControl
    {
        private Guid ClassID = Guid.Empty;
         private  int count = 0;
        private int status = 0;
        private Guid SectionID = Guid.Empty;
        private Guid testCATid = Guid.Empty;
        private Guid testGENid = Guid.Empty;
        private bool h_s = false;
        private Guid teacherId = Guid.Empty;
        private Guid SessionID = Guid.Empty;
        public ucDepartmentwiseAttendanceReport()
        {
            InitializeComponent();
        }

        private void btn_LoadREcords_Click(object sender, EventArgs e)
        {
            
            {
                if (rptDailyReport.Checked)
                {
                    FormReport Form = new FormReport("Daily Attendance Report", "DailyDepartmentAttendance", dtp_Date.Value,dtp_Date.Value);
                    Form.Show();
                }
                else if(rptMonthlyReport.Checked)
                {
                    FormReport Form = new FormReport("Monthly Attendance Report", "MonthlyDepartmentAttendance", dtp_Date.Value, dtp_Date.Value);
                    Form.Show();
                }
            }
        }
    }
}
