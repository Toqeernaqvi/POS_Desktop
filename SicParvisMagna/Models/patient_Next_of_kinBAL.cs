using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class patient_Next_of_kinBAL
    {
        public Guid patient_Next_of_kin_id { get; set; }
        public Guid patient_id { get; set; }
        public string name { get; set; }
        public string relation_to_patient { get; set; }
        public string phone_no { get; set; }
        public string first_address { get; set; }
        public string second_address { get; set; }
        public Guid country_id { get; set; }
        public Guid state_id { get; set; }
        public Guid city_id { get; set; }
        public Guid area_id { get; set; }
        public string zipcode { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public bool status { get; set; }
        public int Flag { get; set; }
    }
}
