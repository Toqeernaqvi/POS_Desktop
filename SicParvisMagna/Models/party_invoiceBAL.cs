using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class party_invoiceBAL
    {
        public Guid party_invoice_id { get; set; }
        public string entry_no { get; set; }
        public int customer_no { get; set; }
        public Guid p_id { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
