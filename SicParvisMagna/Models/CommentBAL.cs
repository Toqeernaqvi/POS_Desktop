using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class CommentBAL
    {
        public Guid Comm_id { get; set; }
        public Guid Issue_id { get; set; }
        public string title { get; set; }

        public string descript { get; set; }
        public string attachments { get; set; }
        public DateTime date { get; set; }
        public int flag { get; set; }
        public string status { get; set; }
        public string edit_by { get; set; }
    }
}
