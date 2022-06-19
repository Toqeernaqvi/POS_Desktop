using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
    class InvoiceBAL
    {
        public Guid InvoiceID { get; set; }
        public string InvoiceNo { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public string Descrip { get; set; }
        public string SerialNo { get; set; }
        public string DesignatedCost { get; set; }
        public string PurchaseOrderNo { get; set; }
        public Guid User_id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public int Flag { get; set; }
        public string EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Guid TaxID { get; set; }
    }
}
