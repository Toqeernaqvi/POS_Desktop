using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class BarcodeTypeBAL
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public string Description { get; set; }

        public Guid AddBy { get; set; }

        public string AddDate { get; set; }
        public  Guid EditBy { get; set; }
        public string EditDate { get; set; }

        public string Status { get; set; }
        public int flag { get; set; }
    }
}
