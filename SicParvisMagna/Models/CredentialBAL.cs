using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class CredentialBAL
    {
        public Guid  id { get; set; }
        public Guid  User_id { get; set; }
        public Guid Organization_id { get; set; }
        public string Domain_id { get; set; }
        public string primary_email { get; set; }
        public string Recovery_Email { get; set; }
        public string Password { get; set; }
        public DateTime Timestamp { get; set; }
        public string Add_by { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }

    }
}
