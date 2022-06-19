using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class TaxBAL
    {
        public Guid TaxID { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public string TaxPercen { get; set; }
        public string Status { get; set; }
        public DateTime TimeStamp { get; set; }
        public string AddBy { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public int Flag { get; set; }
    }
}
