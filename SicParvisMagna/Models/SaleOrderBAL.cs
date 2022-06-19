using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class SaleOrderBAL
    {

        public Guid id { get; set; }
        public Guid Customer_id { get; set; }
        public Guid organization_id { get; set; }
        public Guid branch_id { get; set; }
        public float total_amount { get; set; }
        public float sub_total_amount { get; set; }
        public float discount_amount { get; set; }
        public int discount_percentage { get; set; }
        public float paid_amount { get; set; }
        public float remaining_amount { get; set; }
        public string remarks { get; set; }
        public string payment_type { get; set; }
        public string Invoice_no { get; set; }
        public string status { get; set; }
        public Guid add_by { get; set; }
        public DateTime add_date { get; set; }
        public Guid edit_by { get; set; }
        public DateTime edit_date { get; set; }
        public Boolean flag { get; set; }
        public Guid tax_id { get; set; }
        public Double tax_amount { get; set; }
        public string Order_no { get; set; }
        public int non_vendor_cost_amount { get; set; }
        public int non_vendor_cost_percentage { get; set; }
        public DateTime date { get; set; }
        public float cashierDiscount { get; set; }
        public float changeReturned { get; set; }
    }
}
