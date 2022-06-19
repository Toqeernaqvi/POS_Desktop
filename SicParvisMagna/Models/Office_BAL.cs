using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Office_BAL
    {
        public Guid Office_id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string desc { get; set; }
        public string code { get; set; }
        public Guid dept_id { get; set; }
         public DateTime time_in { get; set; }
        public DateTime time_out { get; set; }
        public DateTime short_leave { get; set; }
        public DateTime grace_time { get; set; }
        public DateTime absent_after { get; set; }
        public DateTime break_start { get; set; }
        public DateTime break_end { get; set; }
        public Boolean local { get; set; }
        public Boolean web { get; set; }
        public string Addby { get; set; }
        public string Editby { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime EditDate { get; set; }

    }
}
