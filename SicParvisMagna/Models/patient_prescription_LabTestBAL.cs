using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class patient_prescription_LabTestBAL
    {
        public Guid patient_prescription_LabTest_id { get; set; }
        public Guid patient_prescription_id { get; set; }
        public Guid lab_test_id { get; set; }
        public int price { get; set; }
        public int discount { get; set; }
        public int welfare_discount { get; set; }
        public int total_price { get; set; }
        public int net_price { get; set; }
        public bool status { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
