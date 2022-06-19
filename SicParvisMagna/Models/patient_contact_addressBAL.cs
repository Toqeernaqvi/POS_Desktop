using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class patient_contact_addressBAL
    {
        public Guid patient_contact_address_id { get; set; }
        public Guid patient_id { get; set; }
        public string email { get; set; }
        public string home_phone { get; set; }
        public string personal_phone { get; set; }
        public string office_phone { get; set; }
        public string first_address { get; set; }
        public string second_address { get; set; }
        public Guid country_id { get; set; }
        public Guid state_id { get; set; }
        public Guid city_id { get; set; }
        public Guid area_id { get; set; }
        public int zipcode { get; set; }
        public string Addby { get; set; }
        public DateTime AddDate { get; set; }
        public string Editby { get; set; }
        public string EditDate { get; set; }
        public bool status { get; set; }
        public int Flag { get; set; }
    }
}
