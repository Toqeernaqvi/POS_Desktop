using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class ProductMultiCategoryBAL
    {
        public Guid CatID { get; set; }
        public string Title { get; set; }
        public string ParentID { get; set; }
        public string Code { get; set; }
        public string Descrip { get; set; }
        public DateTime Timestamp { get; set; }
        public string AddBy { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
    }
}
