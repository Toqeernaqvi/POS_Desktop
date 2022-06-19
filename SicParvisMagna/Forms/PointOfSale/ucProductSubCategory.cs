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
using Telerik.WinControls.UI;
using System.Web.UI.WebControls;
using Telerik.WinControls;
using System.Configuration;
using BasicCRUD.Controllers;


namespace SicParvisMagna.Forms.PointOfSale
{
	public partial class ucProductSubCategory : UserControl
	{
		private SqlConnection con = new SQLCon().getCon();
		private SqlCommand cmd = new SqlCommand();
        public static bool PerAdd;
        public static bool PerEdit;

        public static bool PerDel;
        public static string pgURL;

        private string AccountType = null;
        private Guid MainCategory = Guid.Empty;

        private Guid Product_Category_id = Guid.Empty;
		public ucProductSubCategory()
		{
			InitializeComponent();
            this.gridCategory.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridCategory.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
            Product_Category_id = Guid.Empty;
        }

        private void loadMainCategories()
        {
             ProductCategoryDAL objDAL = new  ProductCategoryDAL();

            string name = null;
            string name2 = null;
            DataTable dt1 = new DataTable();

            DataTable dt = objDAL.LoadAll();
            //
            for (int x = 0; x < dt.Rows.Count; x++)
            {

                Guid.TryParse(dt.Rows[x]["id"].ToString(), out  Product_Category_id);
                 name  = dt.Rows[x]["name"].ToString();
                try
                {
                    dt1 = objDAL.GetCategoryHerarichy(Product_Category_id);
                    name2 = dt1.Rows[0]["name"].ToString();
                    if (name != name2)
                    {
                        dt.Rows[x]["name"] = name2;
                    //    dt.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;

                    }
                }
                catch (Exception e){ e.Message.ToString(); }

            }

            // Loop on DT
            // For each id send call to procedure getCatagoryHierarchy
            // if checkon return value
            // cell 'name' ovvertide with the value returned by getCatagoryHierarchy



            //
            cmbMainCategory.DataSource = dt;
            cmbMainCategory.ValueMember = "id";
            cmbMainCategory.DisplayMember = "name";
            cmbMainCategory.SelectedIndex = -1;

            gridCategory.DataSource = dt;
            gridCategory.Columns["id"].Visible = false;
            gridCategory.Columns["parent_id"].Visible = false;
            gridCategory.Columns["Type"].Visible = false;

            gridCategory.Columns["AddDate"].Visible = false;
            gridCategory.Columns["AddBy"].Visible = false;
            gridCategory.Columns["EditBy"].Visible = false;
            gridCategory.Columns["Flag"].Visible = false;
            gridCategory.Columns["EditDate"].Visible = false;
            gridCategory.Columns["Status"].Visible = false;
            gridCategory.Columns["name"].Width = 100;
            gridCategory.Columns["Shortname"].Visible = false;
            gridCategory.Columns["code"].Visible = false;
            gridCategory.Columns["description"].Width = 300;
        }
        private bool FormValidation()
		{
			bool validated = true;


            // Category Name
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                lblError_name.Text += "Name is required!";
                validated = false;
            }
            else
            {
                lblError_name.Text = "";
            }

            if (!Validation.isAlpha(txt_Name.Text, 25))
            {
                if (string.IsNullOrEmpty(txt_Name.Text))
                    lblError_name.Text += "\n";
                lblError_name.Text += "Name Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblError_name.Text = "";
            }



            return validated;
		}
		private void clearAll()
		{
			btnSave.LabelText = "Save";
			txt_Name.Text = "";  //txt_Name.Clear();
			txt_shortName.Text = "";
			txt_Code.Text = "";
			txt_Description.Text = "";
			lblError_name.Text = "";
			lblErrorCode.Text = "";
			//lblErrorName.Text = "";
			Product_Category_id = Guid.Empty;
		}
		private bool ValidateForm()
		{
			if (string.IsNullOrEmpty(txt_Name.Text))
			{
				lblError_name.Text = "* Required";
				return false;
			}
			else
				lblError_name.Text = "";

			return true;
		}

		private void loadCategories()
		{
            try
            {
                Product_CategoryDAL objDAL = new Product_CategoryDAL();
                Product_CategoryBAL objBAL = new Product_CategoryBAL();
                objBAL.Parent_id = MainCategory;
                gridCategory.DataSource = objDAL.ProductCategory_LoadAll_byParent(objBAL);
                gridCategory.Columns["id"].Visible = false;
                gridCategory.Columns["parent_id"].Visible = false;
                gridCategory.Columns["Type"].Visible = false;

                gridCategory.Columns["AddDate"].Visible = false;
                gridCategory.Columns["AddBy"].Visible = false;
                gridCategory.Columns["EditBy"].Visible = false;
                gridCategory.Columns["Flag"].Visible = false;
                gridCategory.Columns["EditDate"].Visible = false;
                gridCategory.Columns["Status"].Visible = false;
                gridCategory.Columns["name"].Width = 100;
                gridCategory.Columns["Shortname"].Visible = false;
                gridCategory.Columns["code"].Visible = false;
                gridCategory.Columns["description"].Width = 300;
            }
            catch { }
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (FormValidation())
			{
				Product_CategoryBAL objBAL = new Product_CategoryBAL();
                objBAL.Parent_id = MainCategory;
				objBAL.name = txt_Name.Text;
				objBAL.shortname = txt_shortName.Text;
				objBAL.code = txt_Code.Text;
				objBAL.description = txt_Description.Text;
                objBAL.Type = "SubCategory";
                objBAL.Flag = 1;
				Product_CategoryDAL objDAL = new Product_CategoryDAL();

				if (MainCategory!= Guid.Empty)
				{
					objBAL.Product_Category_id = Product_Category_id;
					objBAL.Editby = "Admin";
					objBAL.EditDate = DateTime.Now;
					objDAL.Update(objBAL);

				}
				else
				{
					objBAL.Addby = "Admin";
					objBAL.AddDate = DateTime.Now;
                    objBAL.Flag = 1;
                    objBAL.status = true;
					objDAL.Add(objBAL);
				}
				clearAll();
                loadMainCategories();
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			clearAll();
            loadMainCategories();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (Product_Category_id != Guid.Empty)
			{
				MessageBox.Show("Please unselect/clear Category before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			try
			{
				string query = @" SELECT * FROM dbo.Product_Category ";
				bool whereAdded = false;

				if (!string.IsNullOrEmpty(txt_Name.Text))
				{
					if (!whereAdded) //whereAdded == false
					{
						query += "  WHERE   name like '%" + txt_Name.Text + "%'";
						whereAdded = true;
					}
					//else
					// query += "  AND name like '%" + txtFirstName.Text + "%'";
				}

				if (!string.IsNullOrEmpty(txt_shortName.Text))
				{
					if (!whereAdded) //whereAdded == false
					{
						query += "  WHERE   shortname like '%" + txt_shortName.Text + "%'";
						whereAdded = true;
					}
					else
						query += "  AND shortname like '%" + txt_shortName.Text + "%'";
				}
				if (!string.IsNullOrEmpty(txt_Description.Text))
				{
					if (!whereAdded) //whereAdded == false
					{
						query += "  WHERE description like '%" + txt_Description.Text + "%'";
						whereAdded = true;
					}
					else
						query += "  AND [desc] like '%" + txt_Description.Text + "%'";
				}
				if (!string.IsNullOrEmpty(txt_Code.Text))
				{
					if (!whereAdded) //whereAdded == false
					{
						query += "  WHERE  code like '%" + txt_Code.Text + "%'";
						whereAdded = true;
					}
					else
						query += "  AND code like '%" + txt_Code.Text + "%'";
				}
				if (Product_Category_id != Guid.Empty)
				{
					if (!whereAdded)
					{
						query += "  WHERE Product_Category_id  = " + Product_Category_id;
						whereAdded = true;
					}
					else
						query += "  Where  Product_Category_id = " + Product_Category_id;
				}

				SqlDataAdapter da = new SqlDataAdapter();
				DataTable dt = new DataTable();

				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = query;
				cmd.ExecuteNonQuery();
				con.Close();
				da.SelectCommand = cmd;
				da.Fill(dt);

				gridCategory.DataSource = dt;

           
            }
            catch (Exception e1)
			{
				MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (Product_Category_id != Guid.Empty)
			{
				Product_CategoryBAL objBAL = new Product_CategoryBAL();
				Product_CategoryDAL objDAL = new Product_CategoryDAL();
				objBAL.Product_Category_id = Product_Category_id;
				objDAL.Delete(objBAL);
				clearAll();
				loadCategories();
			}
			else
			{
				MessageBox.Show("No Category selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ucProductCategory_Load(object sender, EventArgs e)
		{

            pgURL = "Manage Products"; PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
            //for Account Type
            try { AccountType = (PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Account_type"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }

          if (AccountType == "Super Admin")
            {


            }

          else if (AccountType == "Branch Admin")
            {
                //for  Branch Admin
                

            }

            else if (AccountType == "Inventory Manager")
            { 
            }
            else
            {

                POSMain.loadAccessDenied();
            }
            try { PerAdd = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["PerAdd"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerAdd == true)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Hide();
            }
            try { PerEdit = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerEdit).Rows[0]["PerEdit"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerEdit == true)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Hide();
            }
            try { PerDel = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerDel).Rows[0]["PerDel"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerDel == true)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Hide();
            }

            clearAll();
           // loadCategories();
            loadMainCategories();
            cmbMainCategory.Focus();
		}

		private void GridUser_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;
            try
            {
                if (rowindex >= 0)
                {
                    btnSave.LabelText = "Update";
                    Product_Category_id = Guid.Parse(gridCategory.Rows[rowindex].Cells["id"].Value.ToString());
                    MainCategory = Guid.Parse(gridCategory.Rows[rowindex].Cells["parent_id"].Value.ToString());

                    //   int.TryParse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                    txt_Name.Text = gridCategory.Rows[rowindex].Cells["name"].Value.ToString();
                    txt_shortName.Text = gridCategory.Rows[rowindex].Cells["shortname"].Value.ToString();
                    txt_Code.Text = gridCategory.Rows[rowindex].Cells["code"].Value.ToString();
                    txt_Description.Text = gridCategory.Rows[rowindex].Cells["description"].Value.ToString();

                   
                }
            }
            catch { }
		}

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabUserPersonal_Click(object sender, EventArgs e)
        {

        }

        private void txt_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_shortName_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Description.Focus();
            }
        }

        private void cmbMainCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clearAll();
            Guid.TryParse(cmbMainCategory.SelectedValue.ToString(), out MainCategory);
            loadCategories();
        }

        private void txt_Name_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Description.Focus();
            }
        }

        private void cmbMainCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Name.Focus();
            }
        }
    }
}
