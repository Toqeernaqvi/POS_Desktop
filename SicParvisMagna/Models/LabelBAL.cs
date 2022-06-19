using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class LabelBAL
    {

        public Guid label_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string color_code { get; set; }
        public string Addby { get; set; }
        public string status { get; set; }
        public string flag { get; set; }
        public DateTime timestampp { get; set; }

    }
}
