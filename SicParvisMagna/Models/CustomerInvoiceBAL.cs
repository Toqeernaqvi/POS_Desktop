using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class CustomerInvoiceBAL
    {
        public Guid CusIvID { get; set; }
        public Guid ProID { get; set; }

        public string Price { get; set; }
        public string Qty { get; set; }
        public string Status { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public int Flag { get; set; }
    }
}
