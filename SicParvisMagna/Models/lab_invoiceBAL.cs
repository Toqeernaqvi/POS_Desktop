using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class lab_invoiceBAL
    {
        public Guid lab_invoice_id { get; set; }
        public Guid lab_test_id { get; set; }
        public Guid patient_id { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int discount { get; set; }
        public int discountAmt { get; set; }
        public int netAmount { get; set; }
        public bool status { get; set; }
        public DateTime Date { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
