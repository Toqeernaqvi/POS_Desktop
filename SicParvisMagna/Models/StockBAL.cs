using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class StockBAL
    {
        public Guid id { get; set; }
        public Guid Product_Category_id { get; set; }
        public Guid Product_id { get; set; }
        public Guid Branch_id { get; set; }
        public Guid Organization_id { get; set; }
        public Guid POS_id { get; set; }
        public double quantity { get; set; }
        public double purchaseprice { get; set; }
        public double saleprice { get; set; }
        public string barcode { get; set; }
        public DateTime expiryDate { get; set; }
        public double qie { get; set; }
      //  public bool status { get; set; }
        public bool InStock { get; set; }
        public DateTime AddDate { get; set; }
        public Guid Addby { get; set; }
        public DateTime EditDate { get; set; }
        public Guid Editby { get; set; }
        public int Flag { get; set; }
        public string Order_no { get; set; }
        public string status { get; set; }

        public Guid SOS_id { get; set; }
        public Guid POR_id { get; set; }
        public Guid SOR_id { get; set; }
        public Guid Prescription_Medicine_id { get; set; }
         public string Type { get; set; }
        public string Source { get; set; }

        public Guid Product_Variant_id { get; set; }

    }
}
