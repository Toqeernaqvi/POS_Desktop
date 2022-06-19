using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Promote_stuBAL
    {
        public Guid id { get; set; }
        public  Guid stu_id { get; set; }
        public Guid prev_session { get; set; }
        public Guid prev_class { get; set; }
        public Guid prev_section { get; set; }
        public Guid next_session { get; set; }
        public Guid next_class { get; set; }
        public Guid next_section { get; set; }
        public DateTime time { get; set; }
        public Guid addby { get; set; }
        public Guid editby { get; set; }

        public int flag { get; set; }

    }
}
