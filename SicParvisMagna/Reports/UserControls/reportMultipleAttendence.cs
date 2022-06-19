using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SicParvisMagna.Forms
{
    public partial class reportMultipleAttendence : UserControl
    {
        public reportMultipleAttendence()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {


            //DateTime dt = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, 1);
            //int offset = ((int)dt.DayOfWeek - (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek + 6) % 7 + 1;
            //DateTime firstDate = dt.AddDays(-offset);
            //DateTime lastDate = firstDate.AddDays(41);

            DateTime last_Date = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, 1).AddMonths(1).AddDays(-1);
            FormReport f = new FormReport("EmployeeAttendence", "EmployeeAttendence", last_Date);
            f.Show();
        }

        private void reportMultipleAttendence_Load(object sender, EventArgs e)
        {
            // dtpDate.Value.AddDays(dtpDate);


            dtpDate.Format = DateTimePickerFormat.Custom;
            //

           dtpDate.CustomFormat = "MM-yyyy";
            //dtpDate.MaxDate.AddDays(dtpDate.Value);
                
        }
    }
}
