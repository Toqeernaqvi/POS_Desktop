using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class smsBAL
    {
        public int id { get; set; }
        public int JobId { get; set; }
        public string message { get; set; }
        public string number { get; set; }
        public string sms_status { get; set; }
        public string error_message { get; set; }
        public DateTime add_date { get; set; }
        public DateTime import_date { get; set; }
        public DateTime export_date { get; set; }
        public DateTime send_date { get; set; }
        public string sms_timespan { get; set; }
        public string sms_type { get; set; }
        public int retryCount { get; set; }
        public bool status { get; set; }
    }
}
