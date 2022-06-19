using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class StateBAL
    {
        public Guid  id { get; set; }
        public Guid  state_id { get; set; }
        public Guid Country_id { get; set; }
        public string Name { get; set; }
        public string Shortname { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Add_by { get; set; }
        public DateTime Add_Date { get; set; }
        public string Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }
    }
}
