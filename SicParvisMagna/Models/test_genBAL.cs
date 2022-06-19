using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class test_genBAL
    {
        public Guid id { get; set; }
        public Guid test_cat_id { get; set; }
        public string test_title { get; set; }
        public string test_desc { get; set; }
        public DateTime date { get; set; }
        public Guid userid { get; set; }
        public Guid branchid { get; set; }

        public Guid OrgID { get; set; }

        public string status { get; set; }
      

        public Guid Add_by { get; set; }
        public DateTime Add_Date { get; set; }
        public Guid Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }

        public DateTime Due_Date { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
        public DateTime Relaxation_time  { get; set; } 
    



    }
}
