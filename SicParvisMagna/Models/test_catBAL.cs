using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class test_catBAL
    {

        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Guid branchid { get; set; }
        public Guid OrgID { get; set; }
        public string status { get; set; }
        public Guid userid { get; set; }

        //public bool Local { get; set; }
        //public bool Web { get; set; }

        public Guid Add_by { get; set; }
        public DateTime Add_Date { get; set; }
        public Guid Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }





    }
}
