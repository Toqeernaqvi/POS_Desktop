using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class labBAL
    {
        public Guid lab_id { get; set; }
        public string name { get; set; }
        public string shortname { get; set; }
        public string code { get; set; }
        public string desctiption { get; set; }
        public string type { get; set; }
        public string National_Tax_Number { get; set; }
        public string Goods_And_Services_Tax { get; set; }
        public string Guarranty { get; set; }
        public string Standard_Report_Number { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string Bank_account_number { get; set; }
        public string International_Account_Number { get; set; }
        public bool status { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
