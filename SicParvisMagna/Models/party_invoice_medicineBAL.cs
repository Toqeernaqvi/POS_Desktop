using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    public class party_invoice_medicineBAL
    {
        public Guid party_invoice_medicine_id { get; set; }
        public Guid medicine_id { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public float packprice { get; set; }
        public float quantity { get; set; }
        public float discount_percentage { get; set; }
        public float discount_amount { get; set; }
        public int tax_percentage { get; set; }
        public float tax_amount { get; set; }
        public float net_amount { get; set; }
        public Guid party_invoice_id { get; set; }
        public DateTime Date { get; set; }
        public bool status { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
