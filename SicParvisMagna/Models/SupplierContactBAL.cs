using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class SupplierContactBAL
    {
        public Guid ContID { get; set; }
        public Guid User_id { get; set; }
        public string Number { get; set; }
        public string Descrip { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
    }
}
