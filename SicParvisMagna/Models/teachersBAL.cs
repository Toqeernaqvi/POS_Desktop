using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class teachersBAL
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string fathername { get; set; }
        public string mobile { get; set; }
        public int status { get; set; }
        public Guid branchid { get; set; }
        public Guid userid { get; set; }
        public string adress { get; set; }
        public string cnic { get; set; }
        public Guid classid { get; set; }
        public Guid subjectid { get; set; }
        public Guid sectionid { get; set; }

        public Guid OrganizationId { get; set; }
        public DateTime d_b { get; set; }
        public string img { get; set; }
        public bool Local { get; set; }
        public bool Web { get; set; }

        public string Add_by { get; set; }
        public DateTime Add_Date { get; set; }
        public string Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }

        public string gender { get; set; }

    }
}
