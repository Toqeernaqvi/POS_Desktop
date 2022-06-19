using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class FeeGenerateBAL
    {
        public Guid  fee_challan_id { get; set; }
        public Guid Organization_id { get; set; }
        public Guid Branch_id { get; set; }
        public Guid Department_id { get; set; }
        public Guid class_id { get; set; }
        public Guid section_id { get; set; }
        public DateTime fee_month { get; set; }
        public DateTime fee_year { get; set; }
        public string challan_number { get; set; }
        public DateTime challan_given_date { get; set; }
        public DateTime challan_due_date { get; set; }
        public DateTime challan_produced_datetime { get; set; }
        public string RecieptNumber { get; set; }
        public Guid Session_id { get; set; }
        public Guid session_id { get; set; }

        public Guid student_challan_id { get; set; }
        public Guid head_id { get; set; }
        public int discount_Amount { get; set; }
        public int discount_Percentage { get; set; }

        public Guid student_challan_detail_id { get; set; }
        public Guid student_id { get; set; }
        public DateTime deposited_date { get; set; }
        public int deposited_amount { get; set; }
        public int arrear { get; set; }
        public int class_fee { get; set; }
           public int previous_arrear { get; set; }
     }
}

