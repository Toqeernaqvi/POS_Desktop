using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Employee_Salary_RecordBAL
    {
        public Guid esr_id { get; set; }
        public Guid dep_id { get; set; }
        public Guid emp_id { get; set; }
        public string Employee_Name { get; set; }
        public DateTime Date_of_Join { get; set; }
        public string Designation { get; set; }
        public float Basic_Salary { get; set; }
        public int Total_Days { get; set; }
        public float Attendance_Days { get; set; }
        public float Attendance_Hours { get; set; }
        public float Per_Day_Salary { get; set; }
        public float Per_Hour_Salary { get; set; }
        public float Total_Days_Amount { get; set; }
        public float Total_Hours_Amount { get; set; }
        public float Total_Days_Hours_Amount { get; set; }
        public float Extra_Duty_Days { get; set; }
        public float Extra_Duty_Hours { get; set; }
        public float Extra_Duty_Minutes { get; set; }
        public float Extra_Duty_Amount { get; set; }
        public float Payable_Amount { get; set; }
        public float Leave_Salary { get; set; }
        public float Other_Expences { get; set; }
        public float Salary_Deduction { get; set; }
        public float Advance_Salary { get; set; }
        public float Net_Payable_Amount { get; set; }
        public DateTime SalaryDate { get; set; }
        public float RegularityDays { get; set; }
        public float RegularityAmount { get; set; }
        public bool status { get; set; }
    }
}
