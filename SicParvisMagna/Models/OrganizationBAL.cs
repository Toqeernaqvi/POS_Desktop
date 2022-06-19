using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class OrganizationBAL
    {
         public Guid Organization_id { get; set; }
        public Guid User_id { get; set; }
        public Guid Parent_id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string HeaderPicturePath { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public string Add_by { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
    }
}
