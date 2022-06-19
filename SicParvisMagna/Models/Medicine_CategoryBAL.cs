using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Medicine_CategoryBAL
    {
        public Guid Medicine_Category_id { get; set; }
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
    }
}
