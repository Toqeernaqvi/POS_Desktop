using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class patient_basicBAL
    {
        public Guid patient_id { get; set; }
        public string patient_name { get; set; }
        public string patient_gender { get; set; }
        public int patient_Age { get; set; }
        public int patient_Age_month { get; set; }
        public DateTime patient_Date_of_Birth { get; set; }
        public string patient_record_no { get; set; }
        public string Addby { get; set; }
        public DateTime AddDate { get; set; }
        public string Editby { get; set; }
        public DateTime EditDate { get; set; }
        public bool status { get; set; }
        public int Flag { get; set; }
    }
}
