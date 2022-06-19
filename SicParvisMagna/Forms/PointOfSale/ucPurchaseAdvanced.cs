using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SicParvisMagna.Library;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;
using System.Data.SqlClient;
using System.IO;

namespace SicParvisMagna.Forms.PointOfSale
{
	public partial class ucPurchaseAdvanced : UserControl
	{
		private Guid id = Guid.Empty;
		private Guid organization_id = Guid.Empty;
		private Guid branch_id = Guid.Empty;
		private Guid party_id = Guid.Empty;
		private Guid tax_id = Guid.Empty;
		private Guid Product_Category_id = Guid.Empty;
		private Guid Pro_id = Guid.Empty;
		DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();
		DataGridViewButtonColumn btn_delrow = new DataGridViewButtonColumn();
		ValidationRegex objvr = new ValidationRegex();

		Purchase_OrderDAL objDAL = new Purchase_OrderDAL();
		Purchase_Order_DetailDAL objPurchaseDAL = new Purchase_Order_DetailDAL();

		public ucPurchaseAdvanced()
		{
			InitializeComponent();
			LoadCmbOrg();

		}

		private void tabControlPurchase_Click(object sender, EventArgs e)
		{

		}

		private void tabControlPurchaseAdvanced_Click(object sender, EventArgs e)
		{
			
		}

		private void ucPurchaseAdvanced_Load(object sender, EventArgs e)
		{

		}
		private void loadParty()
		{
			PurchasePartyDAL objDAL = new PurchasePartyDAL();
			cbx_Party.DataSource = objDAL.LoadAll();
			cbx_Party.ValueMember = "party_id";
			cbx_Party.DisplayMember = "Title";
			cbx_Party.SelectedIndex = -1;

		}
		private void LoadCmbTax()
		{
			TaxDAL objDAL = new TaxDAL();
			cbx_Tax.DataSource = objDAL.LoadAll();
			cbx_Tax.ValueMember = "tax_id";
			cbx_Tax.DisplayMember = "TaxPercen";
			cbx_Tax.SelectedIndex = -1;
		}
		private void LoadCmbOrg()
		{
			OrganizationDAL objDAL = new OrganizationDAL();
			cbx_Organization.DataSource = objDAL.LoadAll();
			cbx_Organization.ValueMember = "organization_id";
			cbx_Organization.DisplayMember = "Title";
			cbx_Organization.SelectedIndex = -1;
		}

		// 2;// BranchID;

		private void LoadCmbOrgBranch()
		{
			OrganizationDAL objDAL = new OrganizationDAL();
			OrganizationBAL obj = new OrganizationBAL();
			obj.Parent_id = organization_id;
			cbx_branch.DataSource = objDAL.LoadBranch(obj);
			cbx_branch.ValueMember = "Organization_id";
			cbx_branch.DisplayMember = "Title";
			cbx_branch.SelectedIndex = -1;
		}
		private void LoadCbxProductCategory()
		{
			Product_CategoryDAL objDAL = new Product_CategoryDAL();
			cbx_Party.DataSource = objDAL.LoadAll();
			cbx_Party.ValueMember = "Product_Category_id";
			cbx_Party.DisplayMember = "name";
			cbx_Party.SelectedIndex = -1;
		}
		private void LoadCbxProduct()
		{
			ProductDAL objDAL = new ProductDAL();
			cbx_Party.DataSource = objDAL.LoadAll();
			cbx_Party.ValueMember = "Pro_id";
			cbx_Party.DisplayMember = "name";
			cbx_Party.SelectedIndex = -1;
		}
		public void Load_Grid()
		{
			gridMedicine.Columns.Add("quantity", "Quantity");        //0
			
			gridMedicine.Columns.Add("purchase_amount", "Purachse Amount");                   //1  
			gridMedicine.Columns.Add("sale_amount", "Sale Amoount");                   //2          
																	//gridMedicine.Columns.Add("price", "Price");             //
																	//gridMedicine.Columns.Add("quantity", "quantity");          //
																	//gridMedicine.Columns.Add("total_price", "Total Price");          // 
			gridMedicine.Columns.Add("company_name", "Company Name");         //3   
			gridMedicine.Columns["company_name"].Width = 250;
			gridMedicine.Columns.Add("formula_name", "Formula Name");          //4
			gridMedicine.Columns["formula_name"].Width = 250;

			gridMedicine.Columns.Add(btn_newrow);
			btn_newrow.HeaderText = "Add";                                              //5
			btn_newrow.Text = "Add Medicine";
			btn_newrow.Name = "btn_newrow";
			btn_newrow.UseColumnTextForButtonValue = true;

			gridMedicine.Columns.Add(btn_delrow);                                        //6
			btn_delrow.HeaderText = "Delete";
			btn_delrow.Text = "Delete Medicine";
			btn_delrow.Name = "btn_delrow";
			btn_delrow.UseColumnTextForButtonValue = true;

			


			DataGridViewCheckBoxColumn cbc = new DataGridViewCheckBoxColumn();
			cbc.HeaderText = "InStock";
			cbc.Name = "InStock";


			gridMedicine.Columns.Add(cbc);  //8
			gridMedicine.Columns["InStock"].DisplayIndex = 4;


			gridMedicine.Columns["RM"].HeaderText = "Packed";

			gridMedicine.Columns[7].Visible = false;

			if (id == Guid.Empty)
				addRow();
		}
		public void addRow()
		{
			string[] row = null;
			if (id != Guid.Empty)
			{
				row = new string[] { "", "0", "0", "", "", null, null, "0" };
			}
			else
			{
				row = new string[] { "", "0", "0", "", "", null, null, "0" };
			}
			if (row != null)
				gridMedicine.Rows.Add(row);
		}
	}
}
