using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    public class AcademicsSectionBAL
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public Guid classid { get; set; }
        public Guid branchid { get; set; }

        public Guid OrgId { get; set; }
        public int status { get; set; }
        public string urdu_title { get; set; }
        // public bool Local { get; set; }
        //public bool Web { get; set; }
        public Guid Add_by { get; set; }
        public Guid Edit_by { get; set; }

        public DateTime Add_date { get; set; }
        public DateTime Edit_date { get; set; }


    }
}
