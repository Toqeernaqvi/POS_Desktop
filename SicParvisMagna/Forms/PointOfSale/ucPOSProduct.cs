using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SicParvisMagna.Library;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;

namespace SicParvisMagna.Forms.PointOfSale
{
	public partial class ucPOSProduct : UserControl
	{
		private SqlConnection con = new SQLCon().getCon();
		private SqlCommand cmd = new SqlCommand();
		private Guid Product_Category_id = Guid.Empty;
		private Guid Pro_id = Guid.Empty;

		public ucPOSProduct()
		{
			InitializeComponent();
		}
		private bool FormValidation()
		{
			bool validated = true;


			//For CityName
			if (string.IsNullOrEmpty(txt_Name.Text))
			{
				lblError_Name.Text += "  Name required!";
				validated = false;
			}
			else
			{
				lblError_Name.Text = "";
			}

			if (!Validation.isAlpha(txt_Name.Text, 20))
			{
				if (string.IsNullOrEmpty(txt_Name.Text))
					lblError_Name.Text += "\n";
				lblError_Name.Text += "Name Should be in  Alphabets and  MAximum Length 20 chracters!";
				validated = false;
			}
			else
			{
				lblError_Name.Text = "";
			}
			//For Code
			if (string.IsNullOrEmpty(txt_code.Text))
			{
				lblError_Code.Text += "  Name required!";
				validated = false;
			}
			else
			{
				lblError_Code.Text = "";
			}

			if (!Validation.isNumber(txt_code.Text))
			{
				if (string.IsNullOrEmpty(txt_code.Text))
					lblError_Code.Text += "\n";
				lblError_Code.Text += "Code must be integer!";
				validated = false;
			}
			else
			{
				lblError_Code.Text = "";
			}
			//====================================================

			return validated;
		}

		//Clear
		private void clearAll()
		{

			btnSave.Text = "Save";
			txt_Name.Text = "";
			txt_shortName.Text = "";
			txt_code.Text = "";
			txt_Description.Text = "";
			lblError_Name.Text = "";
			lblError_Code.Text = "";
			lblError_Category.Text = "";
			lblError_Rs.Text = "";
			lblError_unit.Text = "";
			// cbx_Country.SelectedIndex = -1;
			//CountryID = Guid.Empty;
			// StateID = Guid.Empty;
		}
		//Load Countries into ComboBox
		private void loadCategories()
		{
            Product_CategoryDAL objDAL = new Product_CategoryDAL();
            cbx_Category.DataSource = objDAL.LoadAll();
            cbx_Category.ValueMember = "id";
            cbx_Category.DisplayMember = "name";
            cbx_Category.SelectedIndex = -1;
        }
        //Load States
        private void loadProduct()//Function
		{
			ProductDAL objDAL = new ProductDAL();
			ProductBAL obj = new ProductBAL();
			obj.Product_Category_id = Guid.Parse((cbx_Category.SelectedValue.ToString()));

            //   obj.Country_id = Convert.ToInt32(cbx_Country.SelectedValue);
            gridProduct.DataSource = objDAL.LoadProdcutby_Category(obj.Product_Category_id);
		}


		//Validation
		private bool ValidateForm()
		{
			if (string.IsNullOrEmpty(txt_Name.Text))
			{
				lblError_Name.Text = "* Required";
				return false;
			}
			else
				lblError_Name.Text = "";

			if (!(cbx_Category.SelectedIndex >= 0))
			{
				lblError_Category.Text = "* Required";
				return false;
			}
			else
				lblError_Category.Text = "";

			return true;
		}		 
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (FormValidation())
			{
				ProductBAL objBAL = new ProductBAL();
				objBAL.name = txt_Name.Text;
				objBAL.shortname = txt_shortName.Text;
				objBAL.code = txt_code.Text;
				objBAL.description = txt_Description.Text;
				objBAL.Product_Category_id = Product_Category_id;
                objBAL.rs = float.Parse(txt_rs.Text);
                objBAL.rm = float.Parse(txt_Rm.Text);
                objBAL.qie = float.Parse(txt_qtyineach.Text);
                objBAL.InStock = true;
                objBAL.opn = float.Parse(txt_open.Text);
                objBAL.company_name = txt_CompName.Text;
				objBAL.formula_name = txt_ForName.Text;
				objBAL.unit = txt_unit.Text;

				ProductDAL objDAL = new ProductDAL();

				if (Pro_id!= Guid.Empty)
				{
					objBAL.Pro_id = Pro_id;
				//	objBAL.Editby = "Admin";
					objBAL.EditDate = DateTime.Now;
					objDAL.Update(objBAL);

				}
				else
				{
					//objBAL.Addby = "Admin";
					objBAL.AddDate = DateTime.Now;
					objBAL.Flag = 1;
					//objBAL.status = 1;
					objDAL.Add(objBAL);
				}


                //For Pricing Table
                PricingBAL objb = new PricingBAL();
                PricingDAL obj = new PricingDAL();

                objb.ProID = Pro_id;
                objb.CatID = Guid.Parse(cbx_Category.SelectedValue.ToString());
                objb.price = float.Parse(txt_rs.Text);
                objb.Date = DateTime.Now;
                objb.status = null;
                objb.Purchase_order_id = Guid.Empty;
                objb.AddBy = "Admin";
                objb.AddDate = DateTime.Now;

                if (Pro_id == Guid.Empty)
                {
                    obj.Add(objb);
                }
                else
                {

                    objb.status = null;
                    obj.Add(objb);

                }

                //clearAll();
                loadProduct();


			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			clearAll();
			loadCategories();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (Pro_id != null)

			{
				ProductBAL objBAL = new ProductBAL();
				ProductDAL objDAL = new ProductDAL();
				objBAL.Pro_id = Pro_id;
				objDAL.Delete(objBAL);
				clearAll();
				
			}
			else
			{
				MessageBox.Show("No Product selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void gridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;

			if (rowindex >= 0)
			{
				Pro_id = Guid.Parse(gridProduct.Rows[rowindex].Cells["Pro_id"].Value.ToString());
				//   int.TryParse(gridCountries.Rows[rowindex].Cells["state_id"].Value.ToString(), out StateID);
				txt_Name.Text = gridProduct.Rows[rowindex].Cells["name"].Value.ToString();
				txt_shortName.Text = gridProduct.Rows[rowindex].Cells["shortname"].Value.ToString();
				txt_code.Text = gridProduct.Rows[rowindex].Cells["code"].Value.ToString();
				txt_Description.Text = gridProduct.Rows[rowindex].Cells["description"].Value.ToString();
				txt_rs.Text = gridProduct.Rows[rowindex].Cells["rs"].Value.ToString();
				txt_unit.Text = gridProduct.Rows[rowindex].Cells["unit"].Value.ToString();
				txt_CompName.Text = gridProduct.Rows[rowindex].Cells["company_name"].Value.ToString();
				txt_ForName.Text = gridProduct.Rows[rowindex].Cells["formula_name"].Value.ToString();
				txt_qtyineach.Text = gridProduct.Rows[rowindex].Cells["quantityineach"].Value.ToString();
				txt_Rm.Text = gridProduct.Rows[rowindex].Cells["rm"].Value.ToString();
				txt_open.Text = gridProduct.Rows[rowindex].Cells["opened"].Value.ToString();//Instock rehta hai;
				Product_Category_id = Guid.Parse(gridProduct.Rows[rowindex].Cells["Product_Category_id"].Value.ToString());
				//  int.TryParse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
				cbx_Category.SelectedValue = Product_Category_id;
				btnSave.LabelText = "Update";
			}
		}

		private void ucPOSProduct_Load(object sender, EventArgs e)
		{
			clearAll();
			loadCategories();
		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		private void cbx_Category_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Product_Category_id = Guid.Parse(cbx_Category.SelectedValue.ToString());
			//int.TryParse(cbx_Country.SelectedValue.ToString(), out CountryID);
			loadProduct();
		}
	}
}
