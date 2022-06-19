using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class ReportBAL
    {
        public Guid id { get; set; }
        public string ReportName { get; set; }
        public string HeaderTitle { get; set; }
        public string HeaderText { get; set; }
        public string HeaderPicturePath { get; set; }
        public DateTime date { get; set; }
    }
}
