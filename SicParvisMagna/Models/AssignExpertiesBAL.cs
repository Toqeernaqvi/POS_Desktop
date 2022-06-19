using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class AssignExpertiesBAL
    {
        public Guid AssignId { get; set; }
        public Guid ExpertiesId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Addby { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
    }
}
