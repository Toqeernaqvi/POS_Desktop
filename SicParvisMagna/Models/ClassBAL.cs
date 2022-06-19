using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
      public class ClassBAL
      {
        public Guid id { get; set; }
        public string title { get; set; }
        public string fee { get; set; }
        public Guid branchid { get; set; }
        public Guid organizationid { get; set; }
        public Guid userid { get; set; }
        public string status { get; set; }
        public string urdu_title { get; set; }
        public string class_level { get; set; }
        //  public bool Local { get; set; }
        // public bool Web { get; set; }
        public Guid Add_by { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime Edit_date { get; set; }
        public Guid Edit_by { get; set; }
    }
}
