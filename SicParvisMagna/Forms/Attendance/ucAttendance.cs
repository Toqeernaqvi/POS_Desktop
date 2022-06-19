using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCRUD.Controllers;

namespace SicParvisMagna.Forms
{
    public partial class ucAttendance : UserControl
    {
        public string pgURL;
        public bool PerView;
        bool LinkExpanded = false;
        private FormMain formMain;
        public ucAttendance(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;

        }

        private void btnManageManualAttendence_Click(object sender, EventArgs e)
        {
            formMain.loadManageManualAttendence();

        }

        private void ucAttendance_Load(object sender, EventArgs e)
        {

        }

        private void btnClasswiseMonthlyAttendance_Click(object sender, EventArgs e)
        {
            formMain.loadClasswiseMonthlyAttendanceReport();
        }

        private void btnStudentwiseMonthlyAttendance_Click(object sender, EventArgs e)
        {
            formMain.loadStudentwiseMonthlyAttendanceReport();
        }

        private void btnDepartmentwiseAttendanceReport_Click(object sender, EventArgs e)
        {
            formMain.loadDepartmentwiseAttendanceReport();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            formMain.loadMultipleAttendance();
        }
    }
}
