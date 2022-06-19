using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class VariantBAL
    {
        public Guid  Variant_Id { get; set; }
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
