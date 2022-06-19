using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class EmployeeCompanyInfoBAL
    {
        public Guid employeeCompany_id { get; set; }
        public Guid jobstatus_id { get; set; }
        public Guid employee_id { get; set; }
        public string salary { get; set; }
        public string designation { get; set; }
        public string scale { get; set; }
        public DateTime date_of_join { get; set; }
        public  DateTime leavedate{ get; set; }
    }
}
