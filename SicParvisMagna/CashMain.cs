using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 
using SicParvisMagna.Forms;
using SicParvisMagna.Reports.UserControls;

 
using System.Data.SqlClient;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using BasicCRUD.Models;
using BasicCRUD.Controllers;
using SicParvisMagna.Library;

using SicParvisMagna.Forms.PointOfSale;
using SicParvisMagna.Reports;
using SicParvisMagna.Reports_Form;
using SicParvisMagna.Forms.Cashier_Module;

namespace SicParvisMagna
{
	public partial class CashMain : Form
	{
		//public static string username ;
		private SqlConnection con = new SQLCon().getCon();
		private static SqlConnection staticcon;
		private SqlCommand cmd = new SqlCommand();
		private static SqlCommand staticcmd;

		private Guid userid;
		private string username;
		public static Panel formContainer;
		public Label formHeadingNonStatic;
		public static Label formHeading;
		public static bool PerView;
		public static string pgURL;

		public CashMain(String username, Guid userid)
		{
			InitializeComponent();
			this.username = username;
			this.userid = userid;
			lblMainHeader.Text = username;
			formContainer = this.container;
			staticcon = new SQLCon().getCon();
			staticcmd = new SqlCommand();
			formHeading = lblFormHeading;

			formHeadingNonStatic = lblFormHeading;

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Hide();
			POSMain frm = new POSMain(username,userid);
			frm.Show();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			//1024, 768
			if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
				Size = new Size(1024, 728);
			}

			else
			{
				System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
				this.MaximizedBounds = Screen.GetWorkingArea(this);
				this.WindowState = FormWindowState.Maximized;
				//WindowState = FormWindowState.Maximized;
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}

		private void btnDiscount_Click(object sender, EventArgs e)
		{

		}

		private void btnDailySales_Click(object sender, EventArgs e)
		{

		}

		private void CashMain_Load(object sender, EventArgs e)
		{
			//ucCart form = new ucCart();
			//formContainer.Controls.Add(form);
		}

		private void btnTransaction_Click(object sender, EventArgs e)
		{

		}
	}
}
