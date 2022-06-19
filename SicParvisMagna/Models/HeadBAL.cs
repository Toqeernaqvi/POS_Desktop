using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class HeadBAL
    {
        public Guid id { get; set; }
        public Guid Organization_id { get; set; }
        public Guid Branch_id { get; set; }
        public Guid Department_id{ get; set; }
        public Guid Class_id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Ammount { get; set; }
        public string Frequency { get; set; }
        public string  status  { get; set; }
    }
}
