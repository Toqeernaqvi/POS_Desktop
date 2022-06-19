using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class UserEducationBAL
    {
        public Guid  Education_id { get; set; }
        public Guid User_id { get; set; }
        public string Board { get; set; }
        public byte[] Image { get; set; }
        public string Specilization { get; set; }
        public string OBT_CGPA { get; set; }
        public string Totalmarks_Cgpa { get; set; }
        public string Percentage { get; set; }
        public DateTime Timestamp { get; set; }
        public string Add_by { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
    }
}
