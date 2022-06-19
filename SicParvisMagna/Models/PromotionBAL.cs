using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class PromotionBAL
    {
        public Guid PromID { get; set; }
        public Guid ProID { get; set; }
        public string Descrip { get; set; }
        public DateTime Timestamp { get; set; }
        public string AddBy { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
    }
}
