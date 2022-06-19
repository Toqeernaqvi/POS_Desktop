using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class UserExperienceBAL
    {
        public Guid Experience_id { get; set; }
        public Guid User_id { get; set; }
        public byte[] Image { get; set; }
        public string Job_title { get; set; }
        public string Company_name { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Start_designation { get; set; }
        public string End_designation { get; set; }
        public string Resign { get; set; }
        public DateTime Timestamp { get; set; }
        public string Add_by { get; set; }
        public string status { get; set; }
        public int Flag { get; set; }
    }
}
