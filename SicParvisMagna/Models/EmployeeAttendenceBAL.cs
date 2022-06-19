using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class EmployeeAttendenceBAL
    {
        public Guid Attendence_id { get; set; }
        public Guid Employee_id { get; set; }
        public DateTime time_in { get; set; }
        public DateTime time_out { get; set; }
        public DateTime short_leave { get; set; }
        public DateTime grace_time { get; set; }
        public DateTime absent_after { get; set; }
        public DateTime break_start { get; set; }
        public DateTime break_end { get; set; }
         public string Addby { get; set; }
        public string Editby { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime EditDate { get; set; }

    }
}
