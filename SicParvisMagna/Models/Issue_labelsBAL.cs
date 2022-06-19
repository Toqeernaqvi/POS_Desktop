using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Issue_labelsBAL
    {


        public Guid Id { get; set; }
        public Guid Issue_id { get; set; }
        public Guid label_id { get; set; }

        public string addby { get; set; }
        public int flag { get; set; }
        public string status { get; set; }

        public DateTime timestampp { get; set; }
    }
}
