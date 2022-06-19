using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class ProductVariantDetailsBAL
    {
        public Guid Product_Variant_Detail_id { get; set; }

        public Guid Product_Variant_Id { get; set; }
        public Guid variant_Id { get; set; }
        public Guid variant_Type_Id { get; set; }

        public string Quantity { get; set; }

        public string Title { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public int Flag { get; set; }

    }
}
