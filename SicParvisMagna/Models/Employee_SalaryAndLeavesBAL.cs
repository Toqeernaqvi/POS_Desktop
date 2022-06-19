using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Employee_SalaryAndLeavesBAL
    {
        public Guid ESL_id { get; set; }
        public Guid employee_id { get; set; }
        public int totalSalary { get; set; }
        public int NoOfLeaveAllowed { get; set; }
        public int RemainingLeaves { get; set; }
        public int NoOfMedicalLeaveAllowed { get; set; }
        public int RemainingMedicalLeaves { get; set; }
        public int LeaveIncrement { get; set; }
        public int RemainingMonths { get; set; }
        public bool status { get; set; }
    }
}
