using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class DomainBAL
    {
        public Guid Organization_id { get; set; }
        public Guid User_id { get; set; }
        public Guid Parent_id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Short_Name { get; set; }
        public DateTime Regestration_Date { get; set; }
        public DateTime Expiry_Date { get; set; }
        public DateTime Update_Date { get; set; }
        public string Regestrar_Name { get; set; }
        public string Tech_Persoan_Name { get; set; }
        public string Regestration_Email { get; set; }
        public string Name_Server1 { get; set; }
        public string Name_Server2 { get; set; }
        public string Name_Server3 { get; set; }
        public string Name_Server4 { get; set; }
        public string Name_Server5 { get; set; }
        public DateTime Timestamp { get; set; }
        public string Add_by { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
    }
}
