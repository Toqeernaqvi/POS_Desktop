using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class CustomerBAL
    {
        public Guid User_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string User_name { get; set; }
        public string Father_name { get; set; }
        public string Cnic { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string contact { get; set; }
        public string Phone { get; set; }
        public Guid country_id { get; set; }
        public Guid state_id { get; set; }
        public Guid city_id { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Account_type { get; set; }
        public DateTime Timestamp { get; set; }
        public string Add_by { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
        public int FirstTimeLogin { get; set; }
        public string oldPassword { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
    }
}
