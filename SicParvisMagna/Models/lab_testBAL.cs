using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class lab_testBAL
    {
        public Guid lab_test_id { get; set; }
        public Guid lab_id { get; set; }
        public Guid test_id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public bool status { get; set; }
        public DateTime AddDate { get; set; }
        public string Addby { get; set; }
        public DateTime EditDate { get; set; }
        public string Editby { get; set; }
        public int Flag { get; set; }
    }
}
