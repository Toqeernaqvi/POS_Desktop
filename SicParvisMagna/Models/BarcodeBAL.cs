using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class BarcodeBAL
    {
        public Guid id { get; set; }
        public Guid product_id { get; set; }
        public Guid ProductCategory_id { get; set; }
        public string ActualCode { get; set; }
        public string BarcodeType { get; set; }
        public string code { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
        public Guid AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public Guid EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public int Flag { get; set; }
    }
}
