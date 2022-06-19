using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class Result_BAL
    {
        public Guid id { get; set; }
        public string teachername { get; set; }
        public int TotalMarks { get; set; }
        public float ObtainedMarks { get; set; }
        public DateTime Date { get; set; }
        public Guid studentid { get; set; }
        public Guid Session_id { get; set; }
        public Guid classid { get; set; }
        public Guid sectionid { get; set; }
        public string Remarks { get; set; }
        public Guid SubjectId { get; set; }
        public Guid branchid { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid userid { get; set; }
        public int status { get; set; }
        public Guid teacherid { get; set; }
        public Guid test_cat_id { get; set; }
        public Guid test_id { get; set; }
        public string std_tst { get; set; }
        public bool Local { get; set; }
        public bool Web { get; set; }
        public Guid Add_by { get; set; }
        public DateTime Add_Date { get; set; }
        public Guid Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }

        public int passing_marks { get; set; }
    }
}
