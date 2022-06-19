using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class IssueBAL
    {

        public Guid Issue_id { get; set; }
        public string Title { get; set; }
        public string descript { get; set; }

        public string Addby { get; set; }
        public DateTime due_date { get; set; }
        public string status { get; set; }
        public int flag { get; set; }
        public DateTime timestampp { get; set; }
        public Guid label_id { get; set; }
        public Guid dept_id { get; set; }
    }
}
