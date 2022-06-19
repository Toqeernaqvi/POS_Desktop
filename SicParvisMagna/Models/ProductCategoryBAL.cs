using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class ProductCategoryBAL
    {
        public Guid ProCatID { get; set; }
        public Guid ProID { get; set; }
        public Guid User_id { get; set; }
        public Guid CatID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Addby { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
    }
}
