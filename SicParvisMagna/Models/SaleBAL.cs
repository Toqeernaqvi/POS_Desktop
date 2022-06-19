using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Models
{
	class SaleBAL
	{
		public Guid ProSales_id { get; set; }
		public Guid Pro_id { get; set; }
		public float unitprice { get; set; }
		public float qtysold { get; set; }
		public float total { get; set; }
		public DateTime date { get; set; }
		public string transaction_no { get; set; }
		public Guid add_by { get; set; }
		public DateTime add_date { get; set; }
		public Guid edit_by { get; set; }
		public DateTime edit_date { get; set; }
		public Boolean flag { get; set; }
	}
}
