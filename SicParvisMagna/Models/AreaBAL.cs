using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class AreaBAL
    {
        public Guid City_id { get; set; }
        public Guid Country_id { get; set; }
        public Guid State_id { get; set; }
        public Guid Area_id { get; set; }
        public string Name { get; set; }
        public string Shortname { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Add_by { get; set; }
         public string Edit_By { get; set; }
     }
}
