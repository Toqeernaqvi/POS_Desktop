using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class patient_prescription_medicineBAL
    {
        public Guid patient_prescription_medicine_id { get; set; }
        public Guid patient_prescription_id { get; set; }
        public Guid medicine_id { get; set; }
        public double price { get; set; }
        public double quantity { get; set; }
        public double total_price { get; set; }
        public bool status { get; set; }
        public Guid pricing_id { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
