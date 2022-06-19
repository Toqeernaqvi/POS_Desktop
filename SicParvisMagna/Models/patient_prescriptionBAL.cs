using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class patient_prescriptionBAL
    {
        public Guid patient_prescription_id { get; set; }
        public Guid patient_id { get; set; }
        public Guid medicine_id { get; set; }

        public DateTime assigned_Date { get; set; }
        public int total_cost { get; set; }
        public bool status { get; set; }
        public string type { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
