using System;
using SicParvisMagna.Reports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using SicParvisMagna.Library;

namespace SicParvisMagna.Reports_Form
{
	public partial class BarcodeForm : Form
	{
		ReportDocument crystal = new ReportDocument();
		public BarcodeForm()
		{
			InitializeComponent();
		}
		
		private void BarcodeForm_Load(object sender, EventArgs e)
		{
			//			crystal.Load(@"E:\NCBAE&LCU WORKAREA\Project_Database\SicParvisWork\SICPARVISMAGNA WORK LAPTOP\SicParvisBackup\sicparvismagna\sicparvismagna\SicParvisMagna\Reports\Barcode.rpt");
			crystal.Load("E:\\NCBAE&LCU WORKAREA\\Project_Database\\SicParvisWork\\SICPARVISMAGNA WORK LAPTOP\\SicParvisBackup\\sicparvismagna\\sicparvismagna\\SicParvisMagna\\Reports\\Barcode.rpt");
		}

		private void ShowBtn_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SQLCon().getCon();

			string sql = "Select * From Product_Category where code = " + txtCode.Text + "'";
			for(int i = 1; i<= int.Parse(txtCopy.Text); i++)
			{
				sql = sql + "Select * From Product_Category where code = " + txtCode.Text + "'";
			}
					   

			SqlDataAdapter sa = new SqlDataAdapter("Select * From Product_Category where code = '" + txtCode.Text + "'", con);
			DataSet ds = new DataSet();
			sa.Fill(ds, "Product_Category");
			crystal.SetDataSource(ds);
			crystalReportViewer1.ReportSource = crystal;
		}

		private void ShowAllBtn_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SQLCon().getCon();
			SqlDataAdapter sa = new SqlDataAdapter("Select * From Product_Category ", con);
			DataSet ds = new DataSet();
			
			sa.Fill(ds, "Product_Category");
			crystal.SetDataSource(ds);
			crystalReportViewer1.ReportSource = crystal;
		}
	}
}
