using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Product_CategoryBAL
    {
        public Guid Parent_id { get; set; }
        public Guid Product_Category_id { get; set; }
        public string name { get; set; }
        public string shortname { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public bool status { get; set; }
        public int Flag { get; set; }
        public string Type { get; set; }

    }
}
