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
	public partial class ucLocationIndex : UserControl
	{
		public ucLocationIndex()
		{
			InitializeComponent();
		}

		private void btnCountry_Click(object sender, EventArgs e)
		{
			POSMain.loadCountryForm();
		}

		private void btnState_Click(object sender, EventArgs e)
		{
			POSMain.loadStateForm();
		}

		private void btnCity_Click(object sender, EventArgs e)
		{
			POSMain.loadCityForm();
		}

		private void btnArea_Click(object sender, EventArgs e)
		{
			POSMain.loadAreaForm();
		}

        private void ucLocationIndex_Load(object sender, EventArgs e)
        {

        }
    }
}
