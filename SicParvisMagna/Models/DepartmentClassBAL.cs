using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class DepartmentClassBAL
    {
        public Guid id { get; set; }
        public Guid Organzation_id { get; set; }
        public Guid Branch_id { get; set; }
        public Guid dept_id { get; set; }
        public Guid class_id { get; set; }
        public bool Local { get; set; }
        public bool Web { get; set; }
        public string Add_by { get; set; }
        public DateTime Add_Date { get; set; }
        public string Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }
    }
}
