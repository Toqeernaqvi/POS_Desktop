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
	public partial class ucOrganizationIndex : UserControl
	{
		public ucOrganizationIndex()
		{
			InitializeComponent();
		}

		private void btnOrganization_Click(object sender, EventArgs e)
		{
			POSMain.loadOrganization();
		}

		private void btnBranch_Click(object sender, EventArgs e)
		{
			POSMain.loadBranch();
		}
	}
}
