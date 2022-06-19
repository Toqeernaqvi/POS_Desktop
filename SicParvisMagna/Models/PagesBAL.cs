using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCRUD.Models
{
    class PagesBAL
    {
        public Guid PgID { get; set; }
        public string PgURL { get; set; }
        public DateTime Timestamp { get; set; }
        public string AddBy { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
    }
}
