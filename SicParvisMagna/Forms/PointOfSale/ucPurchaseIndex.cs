using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms.PointOfSale
{
	public partial class ucPurchaseIndex : UserControl
	{
		public ucPurchaseIndex()
		{
			InitializeComponent();
		}

		private void btnPurchasing_Click(object sender, EventArgs e)
		{
			POSMain.loadPurchasing();
		}

		private void btnReturning_Click(object sender, EventArgs e)
		{
			POSMain.loadReturning();
		}
	}
}
