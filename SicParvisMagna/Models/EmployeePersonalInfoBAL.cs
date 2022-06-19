using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class EmployeePersonalInfoBAL
    {
        public Guid employee_id { get; set; }
        public string registration { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime dob { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
  
        public string CNIC { get; set; }
        public string address_type { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public Guid country_id { get; set; }
        public Guid state_id { get; set; }
        public Guid city_id { get; set; }
        public Guid area_id { get; set; }
        public Guid Organization_id { get; set; }
        public Guid Branch_id { get; set; }
        public Guid dept_id { get; set; }
        public Guid office_id { get; set; }
        public Guid section_id { get; set; }
         public string attendance_type { get; set; }
        public string ntn_Number { get; set; }
        public string profile_PicPath { get; set; }
     }
}
