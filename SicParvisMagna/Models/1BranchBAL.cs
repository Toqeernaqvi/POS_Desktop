using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class _1BranchBAL
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string status { get; set; }
        public Guid inst_id { get; set; }

        public Guid branch_id { get; set; }
        public string name { get; set; }
        public string shortname { get; set; }
        public string code { get; set; }
        public string desc { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string STRN { get; set; }
        public string NTN { get; set; }

     //   public bool Local { get; set; }
       // public bool Web { get; set; }
        public string Add_by { get; set; }
        public DateTime Add_Date { get; set; }
        public string Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }
    }
}
