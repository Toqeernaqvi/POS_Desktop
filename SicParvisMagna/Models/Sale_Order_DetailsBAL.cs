using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Sale_Order_DetailsBAL
    {
  
            public Guid id { get; set; }
            public Guid Sale_order_id { get; set; }
        public Guid Stockid { get; set; }
        public string Barcode { get; set; }
        public Guid product_id { get; set; }
            public Guid product_category_id { get; set; }
            public Double quantity { get; set; }
             public Double sale_amount { get; set; }
            public Double discount_amount { get; set; }
            public int discount_percentage { get; set; }
            public DateTime date { get; set; }
            public string status { get; set; }
            public Guid add_by { get; set; }
            public DateTime add_date { get; set; }
            public Guid edit_by { get; set; }
            public DateTime edit_date { get; set; }
            public Boolean flag { get; set; }
            public Guid tax_id { get; set; }
            public Double tax_amount { get; set; }
        public Guid Product_Variant_id { get; set; }

        public string quantityType { get; set; }

    }

}
 