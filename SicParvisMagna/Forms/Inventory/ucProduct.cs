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

namespace SicParvisMagna.Forms
{
    public partial class ucProduct : UserControl
    {
      //  private System.Windows.Forms.Panel container;
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        private Guid CatID = Guid.Empty;
        //Error
        //private Guid UserID = Program.UserID;
        //To remove more error including userid
        //it will change later
        private Guid UserID = Guid.Empty;
        private Guid ProID = Guid.Empty;

        public ucProduct()
        {
            InitializeComponent();
        }
        private void clearMultiCategory()
        {
            btnSave.Text = "Save";
            txt_Title.Text = "";  //txt_Name.Clear();
            txt_Parentid.Text = "";
            txt_Code.Text = "";
            txt_Descrip.Text = "";
            lblErrorTitle.Text = "";
            lblErrorParentID.Text = "";
            lblError_Code.Text = "";

            CatID = Guid.Empty;
        }
        private void loadProductMultiCategory()
        {
            ProductMultiCategoryDAL objDAL = new ProductMultiCategoryDAL();
            gridCategory.DataSource = objDAL.LoadAll();
            gridCategory.Columns["Timestamp"].Visible = false;
            gridCategory.Columns["AddBy"].Visible = false;
            gridCategory.Columns["Status"].Visible = false;
            gridCategory.Columns["Flag"].Visible = false;
            gridCategory.Columns["EditBy"].Visible = false;
            gridCategory.Columns["EditDate"].Visible = false;
        }
        private void deleteMultiCategory()
        {
            if (CatID != null)
            {
                ProductMultiCategoryBAL objBAL = new ProductMultiCategoryBAL();
                ProductMultiCategoryDAL objDAL = new ProductMultiCategoryDAL();
                objBAL.CatID = CatID;
                objDAL.Delete(objBAL);
                clearMultiCategory();
                loadProductMultiCategory();
            }
            else
            {
                MessageBox.Show("No Category selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchMultiCategory()
        {
            if (CatID != null)
            {
                MessageBox.Show("Please unselect/clear Category before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM ProductMultiCategory ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txt_Title.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE Title like '%" + txt_Title.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (CatID != null)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE CatID  = " + CatID;
                        whereAdded = true;
                    }
                   // else
                     //   query += "   CatID = " + CatID;
                }

                if (!string.IsNullOrEmpty(txt_Parentid.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE ParentID like '%" + txt_Parentid.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txt_Code.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE Code like '%" + txt_Code.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
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
        private bool FormValidation()
        {
            bool validated = true;


            //For  title
            if (string.IsNullOrEmpty(txt_Title.Text))
            {
                lblErrorTitle.Text += "  Title  is required!";
                validated = false;
            }
            else
            {
                lblErrorTitle.Text = "";
            }

            if (!Validation.isAlpha(txt_Title.Text, 8))
            {
                if (string.IsNullOrEmpty(txt_Title.Text))
                    lblErrorTitle.Text += "\n";
                lblErrorTitle.Text += "Title Should be in  Alphabets and  MAximum Length 8 chracters!";
                validated = false;
            }
            else
            {
                lblErrorTitle.Text = "";
            }

            //For code
            if (string.IsNullOrEmpty(txt_Code.Text))
            {
                lblError_Code.Text += "  Codee  is required!";
                validated = false;
            }
            else
            {
                lblError_Code.Text = "";
            }

            if (!Validation.isAlphaNumeric(txt_Code.Text))
            {
                if (string.IsNullOrEmpty(txt_Code.Text))
                    lblError_Code.Text += "\n";
                lblError_Code.Text += "Code Should be in Correct!";
                validated = false;
            }
            else
            {
                lblError_Code.Text = "";
            }
            //For parentid
            if (string.IsNullOrEmpty(txt_Parentid.Text))
            {
                lblErrorParentID.Text += "  ParentID is required!";
                validated = false;
            }
            else
            {
                lblErrorParentID.Text = "";
            }

            if (!Validation.isNumber(txt_Parentid.Text))
            {
                if (string.IsNullOrEmpty(txt_Parentid.Text))
                    lblErrorParentID.Text += "\n";
                lblErrorParentID.Text += "ParentID Should be in Correct!";
                validated = false;
            }
            else
            {
                lblErrorParentID.Text = "";
            }
            //====================================================

            return validated;
        }
        private void saveMultiCategory()
        {
            if (FormValidation())
            {
                ProductMultiCategoryBAL objBAL = new ProductMultiCategoryBAL();
                objBAL.Title = txt_Title.Text;
                objBAL.ParentID = txt_Parentid.Text;
                objBAL.Code = txt_Code.Text;
                objBAL.Descrip = txt_Descrip.Text;


                ProductMultiCategoryDAL objDAL = new ProductMultiCategoryDAL();

                if (CatID != null)
                {
                    objBAL.CatID = CatID;
                    objBAL.EditBy = "Admin";
                    objBAL.EditDate = DateTime.Now;
                    objBAL.Status = "Active";
                    objBAL.Flag = 1;
                    objDAL.Update(objBAL);

                }
                else
                {
                    objBAL.AddBy = "Admin";
                    objBAL.Timestamp = DateTime.Now;
                    objBAL.Status = "Active";
                    objBAL.Flag = 1;
                    objDAL.Add(objBAL);
                }
                clearMultiCategory();
                loadProductMultiCategory();

            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mtcProduct.SelectedTab == mtcProduct.TabPages["Product"])
            {
                saveProduct();
            }

            if (mtcProduct.SelectedTab == mtcProduct.TabPages["ProductMultiCategory"])
            {
                saveMultiCategory();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (mtcProduct.SelectedTab == mtcProduct.TabPages["Product"])
            {
                clearProduct();
            }

            if (mtcProduct.SelectedTab == mtcProduct.TabPages["ProductMultiCategory"])
            {
                clearMultiCategory();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mtcProduct.SelectedTab == mtcProduct.TabPages["Product"])
            {
                deleteProduct();
            }

            if (mtcProduct.SelectedTab == mtcProduct.TabPages["ProductMultiCategory"])
            {
                deleteMultiCategory();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mtcProduct.SelectedTab == mtcProduct.TabPages["Product"])
            {
                searchProduct();
            }

            if (mtcProduct.SelectedTab == mtcProduct.TabPages["ProductMultiCategory"])
            {
                searchMultiCategory();
            }
        }

        private void gridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                CatID = Guid.Parse(gridCategory.Rows[rowindex].Cells["CatID"].Value.ToString());
                txt_Title.Text = gridCategory.Rows[rowindex].Cells["Title"].Value.ToString();
                txt_Parentid.Text = gridCategory.Rows[rowindex].Cells["ParentID"].Value.ToString();
                txt_Code.Text = gridCategory.Rows[rowindex].Cells["Code"].Value.ToString();
                txt_Descrip.Text = gridCategory.Rows[rowindex].Cells["Descrip"].Value.ToString();

                btnSave.Text = "Update";
            }
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            loadProductMultiCategory();
            clearMultiCategory();
            loadProducts();
            clearProduct();
            // loadCbxSupplier();
            loadgridCategories();
        }

        public void loadgridCategories()
        {
            //   dgvSearch.Rows.Clear();
            ProductMultiCategoryDAL objd = new ProductMultiCategoryDAL();
            gridCategories.DataSource = objd.LoadAll();
            //DataTable dt = objd.LoadAll();

            //foreach (DataColumn dc in dt.Columns)
            //{
            //    gridCategories.Columns.Add(dc.ColumnName, dc.ColumnName);
            //}
            //foreach (DataRow dr in dt.Rows)
            //{
            //    gridCategories.Rows.Add(dr.ItemArray);
            //}

        }

        private void clearProduct()
        {
            btnSave.Text = "Save";
            txtProduct.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            //  txt_Tax.Text = "";
            //  txt_Gst.Text = "";
            txtCompany.Text = "";
            chkBx_Instock.Checked = false;
            txtSize.Text = "";
            txtStuff.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtWidth.Text = "";
            
            // cbx_Supplier.SelectedIndex = -1;
            txtOpen.Text = "";
            txtQtyInEach.Text = "";
            txtCode.Text = "";
            txtFormulaName.Text = "";
            txtShtName.Text = "";

            UserID = Guid.Empty;

            lblErrorProduct.Text = "";
            lblErrorShortName.Text = "";
            lblErrorCode.Text = "";
            lblErrorFormulaName.Text = "";
            lblErrorPrice.Text = "";
            lblErrorQuantity.Text = "";
            lblErrorProduct.Text = "";
            lblErrorProduct.Text = "";
            lblErrorProduct.Text = "";

        }
        private void loadProducts()
        {
            ProductDAL objDAL = new ProductDAL();
            gridProduct.DataSource = objDAL.LoadAll();
            gridProduct.Columns["Timestamp"].Visible = false;
            gridProduct.Columns["AddBy"].Visible = false;
            gridProduct.Columns["Status"].Visible = false;
            gridProduct.Columns["Flag"].Visible = false;
            gridProduct.Columns["EditBy"].Visible = false;
            gridProduct.Columns["EditDate"].Visible = false;
        }
        private void deleteProduct()
        {
            if (ProID != null)
            {
                ProductBAL objBAL = new ProductBAL();
                ProductDAL objDAL = new ProductDAL();
                //objBAL.ProID = ProID;
                objDAL.Delete(objBAL);
                clearProduct();
                loadProducts();
            }
            else
            {
                MessageBox.Show("SQLError", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveProduct()
        {
            //if (ValidateForm())
            //{
            //    ProductBAL objBAL = new ProductBAL();
            //    objBAL.ProName = txtProduct.Text;
            //    objBAL.Quantity = txtQty.Text;
            //    objBAL.Price = txtPrice.Text;
            //    //    objBAL.Tax = txt_Tax.Text ;
            //    //    objBAL.GST = txt_Gst.Text ;
            //    objBAL.CompanyName = txtCompany.Text;
            //    objBAL.InStock = chkBx_Instock.Checked;
            //    objBAL.Size = txtSize.Text;
            //    objBAL.Stuff = txtStuff.Text;
            //    objBAL.Height = txtHeight.Text;
            //    objBAL.Weight = txtWeight.Text;
            //    objBAL.Width = txtWidth.Text;
            //    objBAL.QtyInEach = txtQtyInEach.Text;
            //    objBAL.Opened = txtOpen.Text;
            //    objBAL.FormulaName = txtFormulaName.Text;
            //    objBAL.Code = txtCode.Text;
            //    objBAL.ShortName = txtShtName.Text;

            //    objBAL.UserID = UserID;




            //    ProductDAL objDAL = new ProductDAL();

            //    if (ProID != null)
            //    {
            //        objBAL.ProID = ProID;
            //        objBAL.EditBy = "Admin";
            //        objBAL.EditDate = DateTime.Now;
            //        objBAL.Status = "active";
            //        objBAL.Flag = 1;
            //        objDAL.Update(objBAL);

            //    }
            //    else
            //    {
            //        objBAL.Addby = "Admin";
            //        objBAL.Timestamp = DateTime.Now;
            //        objBAL.Status = "active";
            //        objBAL.Flag = 1;
            //        ProID = objDAL.Add(objBAL);
            //    }
            //    ProductCategoryBAL objBalPC = new ProductCategoryBAL();
            //    ProductCategoryDAL objDalPC = new ProductCategoryDAL();
            //    objBalPC.ProID = ProID;
            //    objDalPC.Delete(objBalPC);
            //    for (int x = 0; x < gridCategories.Rows.Count; x++)
            //    {
            //        if (Convert.ToBoolean(gridCategories.Rows[x].Cells["GridClm_CheckBox_Select"].Value) == true)
            //        {
            //            // Create BAL / DAL -- populate and save to table

            //            ProductCategoryBAL objBalPC2 = new ProductCategoryBAL();
            //            objBalPC2.ProID = ProID;
            //            //   objBalPC2.PerAdd = Convert.ToBoolean(gridCategories.Rows[x].Cells["PerAdd"].Value

            //            //Error
            //            //objBalPC2.CatID = Guid.Parse(gridCategories.Rows[x].Cells["CatID"].Value);
            //            objBalPC2.Addby = "Admin";
            //            objBalPC2.Timestamp = DateTime.Now;
            //            objBalPC2.Status = "active";
            //            objBalPC2.Flag = 1;
            //            objDalPC.Add(objBalPC2);

            //        }
            //    }

            //    clearProduct();
            //    loadProducts();

            //}
        }
        private void searchProduct()
        {
            if (ProID != null)
            {
                MessageBox.Show("Please unselect/clear Product before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM ProductMultiCategory ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtProduct.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE ProName like '%" + txtProduct.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (ProID != null)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE ProID  = " + ProID;
                        whereAdded = true;
                    }
                    //else
                      //  query += "   ProID = " + ProID;
                }

                if (!string.IsNullOrEmpty(txtShtName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE ShortName like '%" + txtShtName.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtCode.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE Code like '%" + txtCode.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtFormulaName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE FormulaName like '%" + txtFormulaName.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
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
        private bool ValidateForm()
        {
            bool validated = true;

            if (string.IsNullOrEmpty(txtProduct.Text))
            {
                lblErrorProduct.Text += "  Product  is required!";
                validated = false;
            }
            else
            {
                lblErrorProduct.Text = "";
            }
            if (!Validation.isAlpha(txtProduct.Text, 25))
            {
                if (string.IsNullOrEmpty(txtProduct.Text))
                    lblErrorProduct.Text += "\n";
                lblErrorProduct.Text += "Product Should be in  Alphabets and  MAximum Length 5 chracters!";
                validated = false;
            }
            else
            {
                lblErrorProduct.Text = "";
            }
            //Sht name
            if (string.IsNullOrEmpty(txtShtName.Text))
            {
                lblErrorShortName.Text += "  ShortName  is required!";
                validated = false;
            }
            else
            {
                lblErrorShortName.Text = "";
            }
            if (!Validation.isAlpha(txtShtName.Text, 5))
            {
                if (string.IsNullOrEmpty(txtShtName.Text))
                    lblErrorShortName.Text += "\n";
                lblErrorShortName.Text += "Short name Should be in  Alphabets and  MAximum Length 5 chracters!";
                validated = false;
            }
            else
            {
                lblErrorShortName.Text = "";
            }

            //For code
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                lblErrorCode.Text += "  Code  is required!";
                validated = false;
            }
            else
            {
                lblErrorCode.Text = "";
            }

            if (!Validation.isAlphaNumeric(txtCode.Text))
            {
                if (string.IsNullOrEmpty(txtCode.Text))
                    lblErrorCode.Text += "\n";
                lblErrorCode.Text += "Code Should be in Correct!";
                validated = false;
            }
            else
            {
                lblErrorCode.Text = "";
            }
            //For FormulaName
            if (string.IsNullOrEmpty(txtFormulaName.Text))
            {
                lblErrorFormulaName.Text += "  Formula is required!";
                validated = false;
            }
            else
            {
                lblErrorFormulaName.Text = "";
            }

            if (!Validation.isAlphaNumeric(txtFormulaName.Text))
            {
                if (string.IsNullOrEmpty(txtFormulaName.Text))
                    lblErrorFormulaName.Text += "\n";
                lblErrorFormulaName.Text += "Formula Should be in Correct!";
                validated = false;
            }
            else
            {
                lblErrorFormulaName.Text = "";
            }
            //Price
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                lblErrorPrice.Text += "  Price  is required!";
                validated = false;
            }
            else
            {
                lblErrorPrice.Text = "";
            }
            if (!Validation.isNumber(txtPrice.Text))
            {
                if (string.IsNullOrEmpty(txtPrice.Text))
                    lblErrorPrice.Text += "\n";
                lblErrorPrice.Text += "Price Should be in  Number!";
                validated = false;
            }
            else
            {
                lblErrorPrice.Text = "";
            }
            //Quantity
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                lblErrorQuantity.Text += "  Quantity  is required!";
                validated = false;
            }
            else
            {
                lblErrorQuantity.Text = "";
            }
            if (!Validation.isNumber(txtQty.Text))
            {
                if (string.IsNullOrEmpty(txtQty.Text))
                    lblErrorQuantity.Text += "\n";
                lblErrorQuantity.Text += "Quantity Should be in  Number!";
                validated = false;
            }
            else
            {
                lblErrorQuantity.Text = "";
            }

            //For Qty in each
            if (string.IsNullOrEmpty(txtQtyInEach.Text))
            {
                lblErrorQtyInEach.Text += "  Quantity is required!";
                validated = false;
            }
            else
            {
                lblErrorQtyInEach.Text = "";
            }

            if (!Validation.isNumber(txtQtyInEach.Text))
            {
                if (string.IsNullOrEmpty(txtQtyInEach.Text))
                    lblErrorQtyInEach.Text += "\n";
                lblErrorQtyInEach.Text += "Quantity Should be in Correct!";
                validated = false;
            }
            else
            {
                lblErrorQtyInEach.Text = "";
            }
            //For Open
            if (string.IsNullOrEmpty(txtOpen.Text))
            {
                lblErrorOpened.Text += "  Opened quantity is required!";
                validated = false;
            }
            else
            {
                lblErrorOpened.Text = "";
            }

            if (!Validation.isNumber(txtOpen.Text))
            {
                if (string.IsNullOrEmpty(txtOpen.Text))
                    lblErrorOpened.Text += "\n";
                lblErrorOpened.Text += "Opened quantity Should be in Correct!";
                validated = false;
            }
            else
            {
                lblErrorOpened.Text = "";
            }
            //Company
            if (string.IsNullOrEmpty(txtCompany.Text))
            {
                lblErrorCompany.Text += "  Company  is required!";
                validated = false;
            }
            else
            {
                lblErrorCompany.Text = "";
            }
            if (!Validation.isAlpha(txtCompany.Text, 25))
            {
                if (string.IsNullOrEmpty(txtCompany.Text))
                    lblErrorCompany.Text += "\n";
                lblErrorCompany.Text += "Company name Should be in  Alphabets and  MAximum Length 25 chracters!";
                validated = false;
            }
            else
            {
                lblErrorCompany.Text = "";
            }
            return validated;
        }

        private void gridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                ProID = Guid.Parse(gridProduct.Rows[rowindex].Cells["ProID"].Value.ToString());
                txtProduct.Text = gridProduct.Rows[rowindex].Cells["ProName"].Value.ToString();
                txtQty.Text = gridProduct.Rows[rowindex].Cells["Quantity"].Value.ToString();
                txtPrice.Text = gridProduct.Rows[rowindex].Cells["Price"].Value.ToString();
                //  txt_Tax.Text = gridCountries.Rows[rowindex].Cells["Tax"].Value.ToString();
                // txt_Gst.Text = gridCountries.Rows[rowindex].Cells["GST"].Value.ToString();
                txtCompany.Text = gridProduct.Rows[rowindex].Cells["CompanyName"].Value.ToString();
                chkBx_Instock.Checked = Convert.ToBoolean(gridProduct.Rows[rowindex].Cells["InStock"].Value);
                txtSize.Text = gridProduct.Rows[rowindex].Cells["Size"].Value.ToString();
                txtStuff.Text = gridProduct.Rows[rowindex].Cells["Stuff"].Value.ToString();
                txtHeight.Text = gridProduct.Rows[rowindex].Cells["Height"].Value.ToString();
                txtWeight.Text = gridProduct.Rows[rowindex].Cells["Weight"].Value.ToString();
                txtWidth.Text = gridProduct.Rows[rowindex].Cells["Width"].Value.ToString();
                txtQtyInEach.Text = gridProduct.Rows[rowindex].Cells["QtyInEach"].Value.ToString();
                txtOpen.Text = gridProduct.Rows[rowindex].Cells["Opened"].Value.ToString();
                txtFormulaName.Text = gridProduct.Rows[rowindex].Cells["FormulaName"].Value.ToString();
                txtCode.Text = gridProduct.Rows[rowindex].Cells["Code"].Value.ToString();
                txtShtName.Text = gridProduct.Rows[rowindex].Cells["ShortName"].Value.ToString();

                UserID = Guid.Parse(gridProduct.Rows[rowindex].Cells["UserID"].Value.ToString());
                //cbx_Supplier.SelectedValue = UserID;


                btnSave.Text = "Update";
                ProductCategoryBAL objBalPC3 = new ProductCategoryBAL();
                ProductCategoryDAL objDalPC = new ProductCategoryDAL();
                objBalPC3.ProID = ProID;
                objDalPC.Delete(objBalPC3);
                for (int x = 0; x < gridCategories.Rows.Count; x++)
                {
                    // Create BAL / DAL -- populate and save to table

                    ProductCategoryBAL objBalPCLoad = new ProductCategoryBAL();
                    objBalPCLoad.ProID = ProID;
                    //error
                    //objBalPCLoad.CatID = Guid.ToInt32(gridCategories.Rows[x].Cells["CatID"].Value);
                    DataTable dt = objDalPC.LoadByProductNCategory(objBalPCLoad);
                    if (dt.Rows.Count > 0)
                        gridCategories.Rows[x].Cells["GridClm_CheckBox_Select"].Value = true;
                    else
                        gridCategories.Rows[x].Cells["GridClm_CheckBox_Select"].Value = false;

                }

            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FormMain.loadBackForm();
            // container.Controls.Clear();
        //  ucInventory form = new ucInventory();
           // form.Dock = DockStyle.Fill;
           // container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }
    }
}











