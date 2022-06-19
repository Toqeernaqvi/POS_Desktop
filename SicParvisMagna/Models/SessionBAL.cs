using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class SessionBAL
    {
        public Guid id { get; set; }
        public string Session_Name { get; set; }
        public string UrduName { get; set; }
      

        public Guid OrgId { get; set; }

        public Guid BranchId { get; set; }

        public Guid ClassId { get; set; }

        public Guid Add_by { get; set; }

        public Guid Edit_by { get; set; }

        public DateTime Add_date { get; set; }

        public DateTime Edit_date { get; set; }
        public int status { get; set; }

       




    }
}
