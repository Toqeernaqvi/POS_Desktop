using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class HCC_Balance_BAL
    {
        public Guid id { get; set; }

        public double amount { get; set; }

        public string type { get; set; }

        public DateTime date { get; set; }

        public DateTime add_date { get; set; }

        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
