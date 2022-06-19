using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class ProductBAL
    {
        public Guid Pro_id { get; set; }
        public Guid Product_Category_id { get; set; }
        public Guid Organization_id { get; set; }
        public Guid Branch_id { get; set; }
        public string name { get; set; }
        public string shortname { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public string company_name { get; set; }
        public string formula_name { get; set; }
        public double rs { get; set; }
        public double rm { get; set; }
        public double opn { get; set; }
        public double qie { get; set; }
        public bool hasVariants { get; set; }
        public bool hasExpiry { get; set; }
        public string status { get; set; }
        public string reorder_quantity { get; set; }
        public string reorder_point { get; set; }

        public bool InStock { get; set; }
        public DateTime AddDate { get; set; }
        public Guid Addby { get; set; }
        public DateTime EditDate { get; set; }
        public Guid Editby { get; set; }
        public int Flag { get; set; }
		public string unit { get; set; }
    }
}
