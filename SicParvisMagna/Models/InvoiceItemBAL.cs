using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class InvoiceItemBAL
    {
        public Guid InVoiceItemID { get; set; }
        public string EntryNo { get; set; }
        public string CustomerNo { get; set; }
        public Guid InvoiceID { get; set; }
        public Guid ProID { get; set; }
        public string Qty { get; set; }
        public string Price { get; set; }
        public string ValueExclusiveTax { get; set; }
        public string RatesOfSalesTax { get; set; }
        public string SalesTaxPayable { get; set; }
        public string ValueIncludingTax { get; set; }
        public string Status { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public string Remaining { get; set; }
    }
}
