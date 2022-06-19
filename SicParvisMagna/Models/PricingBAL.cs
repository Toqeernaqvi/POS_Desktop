using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class PricingBAL
    {
        public Guid Pricing_id { get; set; }
        public Guid Purchase_order_id { get; set; }

        public Guid ProID { get; set; }
        public Guid CatID { get; set; }
                
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
       
        public Guid item_id { get; set; }
        public string item_type { get; set; }
        public float price { get; set; }
        public int opened { get; set; }
        public float qty { get; set; }
        public Nullable<Guid> InvoiceID { get; set; }
        public float remaining { get; set; }
        public float total { get; set; }
        public DateTime Date { get; set; }
        public string  status { get; set; }
    }
}
