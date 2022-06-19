using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class BarcodeGenerateBAL
    {
        public Guid id { get; set; }
        public Guid Cat_id { get; set; }
        public Guid Pro_id { get; set; }
        public Guid user_id { get; set; }
        public  Double Quantity { get; set; }
        public Double Price { get; set; }
        public string Unit { get; set; }
        public String Order_No{ get; set; }
        public Double UPC_Barcode{ get; set; }
        public string Description { get; set; }
        public int Flag { get; set; }
        public DateTime AddDate { get; set; }


    }
}
