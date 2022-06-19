using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class EmployeAttendenceBAL
    {
        public Guid employid { get; set; }
        public Guid id { get; set; }
        public string studentname { get; set; }
        public DateTime timein { get; set; }
        public string type { get; set; }
        public Guid attendance { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
        public bool Local { get; set; }
        public bool Web { get; set; }

        public string serializedFmd { get; set; }
        public DateTime Add_Date { get; set; }
        public string Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }
    }
}
