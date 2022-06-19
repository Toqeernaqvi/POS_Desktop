using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class PatientBAL
    {
        public Guid patient_id { get; set; }
        public string patient_name { get; set; }
        public string patient_gender { get; set; }
        public DateTime patient_DateofBirth { get; set; }
        public string patient_CNIC { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public bool status { get; set; }
        public int Flag { get; set; }
    }
}
