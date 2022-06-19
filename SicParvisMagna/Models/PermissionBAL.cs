using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCRUD.Models
{
    public class PermissionBAL
    {
        public Guid PerID { get; set; }
        public Guid RoleID { get; set; }
        public string PerUID { get; set; }
        public Guid PgID { get; set; }
        public Guid User_id { get; set; }
        public Boolean PerAdd { get; set; }
        public Boolean PerEdit { get; set; }
        public Boolean PerView { get; set; }
        public Boolean PerDel { get; set; }
        public DateTime Timestamp { get; set; }
        public string AddBy { get; set; }
        public string Status { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
    }
}
