using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class StudentBAL
    {
        public Guid id { get; set; }
        public Guid Session_id { get; set; }//1
        public DateTime? d_b { get; set; }
        public DateTime? d_a { get; set; }
        public string name { get; set; }
        public string fathername { get; set; }

        public string mobile { get; set; }

        public string cnic { get; set; }
  
        public string registration { get; set; }
        public string rollno { get; set; }
        public Guid classid { get; set; }
        public Guid section { get; set; }
        public string address { get; set; }
        public Guid branchid { get; set; }
        public string img { get; set; }
     
        public int status { get; set; }
   
        public string urdu_name { get; set; }
        public string urdu_fname { get; set; }
        public string addresurdu { get; set; }
        public Guid country_id { get; set; }
        public Guid state_id { get; set; }
        public Guid city_id { get; set; }
        public Guid area_id { get; set; }
        //public bool Local { get; set; }
        //public bool Web { get; set; }

        public Guid Add_by { get; set; }
        public DateTime Add_Date { get; set; }
        public Guid Edit_By { get; set; }
        public DateTime Edit_Date { get; set; }

        public string ParentType { get; set; }

        public Guid subjects { get; set; }

        public string gender { get; set; }
        public Guid Organization { get; set; }

    }
}
