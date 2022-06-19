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
    public partial class ucStock : UserControl
    {
        Guid organization_id = Guid.Empty;
        Guid Branch_id = Guid.Empty;
        public static bool PerAdd;
        public static bool PerEdit;

        public static bool PerDel;
        public static string pgURL;
        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;
        private string AccountType = null;
        Guid Cat_id = Guid.Empty;
        Guid StockID = Guid.Empty;
        Guid ProductID = Guid.Empty;
        Guid Purchase_Order_id = Guid.Empty;

        public ucStock()
        {
            InitializeComponent();
            this.gridStock.EnableAlternatingRowColor = true;
            ((GridTableElement)this.gridStock.TableElement).AlternatingRowColor = Color.Red;

            //this.GridUser.RowsDefaultCellStyle.BackColor = Color.LightGray;
            //this.GridUser.AlternatingRowsDefaultCellStyle.BackColor =
            //    Color.White;
            LoadCmbOrg();
            LoadCmbOrgBranch();

            LoadCbxProductCategory();
            gridStock.Visible = false;
            panel18.Visible = false;
            panel14.Visible = false;
            panel19.Visible = false;
            panel5.Visible = false;
            try
            {
                cmbOrganization.SelectedIndex = 3;
                Guid.TryParse(cmbOrganization.SelectedValue.ToString(), out organization_id);
                LoadCmbOrgBranch();


                cmbBranch.SelectedIndex = 0;
                Guid.TryParse(cmbBranch.SelectedValue.ToString(), out Branch_id);
            }
            catch { }
        }

        private void loadStock(Guid id)
        {

            StockDAL obj = new StockDAL();
            gridStock.DataSource = obj.LoadStockGrid(id);
            gridStock.Columns["ID"].IsVisible = false;
            gridStock.Columns["Cat_id"].IsVisible = false;
            gridStock.Columns["POS"].IsVisible = false;
            gridStock.Columns["Source"].IsVisible = false;

            gridStock.Columns["Item"].Width = 250;
            gridStock.Columns["Quantity"].Width = 150;
          //  gridStock.Columns["Source"].Width = 150;
            gridStock.Columns["Date"].Width = 150;
            gridStock.Columns["Status"].Width = 150;


        }
        public ucStock(Guid product_id, string status)
        {

            //    ProductId = product_id;
            InitializeComponent();
            loadStock(product_id);

            //Initialize();
            //FillProductDetails();
            //Load_Grid();
            //cbxCategory.Focus();
            //lblStatus.Text = status;
            panel18.Visible = false;
            panel5.Visible = false;
            panel14.Visible = false;
            panel19.Visible = false;
            cmbOrganization.Enabled = false;
            cmbBranch.Enabled = false;
            cmbProduct.Enabled = false;
            cmbCategory.Enabled = false;

            try
            {
                cmbOrganization.SelectedIndex = 3;
                Guid.TryParse(cmbOrganization.SelectedValue.ToString(), out organization_id);
                LoadCmbOrgBranch();


                cmbBranch.SelectedIndex = 0;
                Guid.TryParse(cmbBranch.SelectedValue.ToString(), out Branch_id);
            }
            catch { }
                


            btnSave.LabelText = "Update";
        }

        private void LoadCmbOrg()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;
        }

        // 2;// BranchID;

        private void LoadCmbOrgBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();
            obj.Parent_id = organization_id;
            cmbBranch.DataSource = objDAL.LoadBranch(obj);
            cmbBranch.ValueMember = "Organization_id";
            cmbBranch.DisplayMember = "Title";
            cmbBranch.SelectedIndex = -1;
        }
        private void LoadCbxProductCategory()
        {
            ProductCategoryDAL objDAL = new ProductCategoryDAL();
            ////cbx_Category.DataSource = objDAL.LoadAll();
            ////cbx_Category.ValueMember = "id";
            ////cbx_Category.DisplayMember = "name";
            ////cbx_Category.SelectedIndex = -1;
            //cmb_ProductCategory.HeaderText = "Product Category";
            //cmb_ProductCategory.Name = "cmb_ProductCatego";
            //gridPurchases.Columns.Clear();
            // this.gridPurchases.Columns.Add(cmb_ProductCategory);
            cmbCategory.DataSource = objDAL.LoadAll();
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
            cmbCategory.SelectedIndex = -1;
        }
        private void LoadCmbProduct(Guid id)
        {
            ProductDAL objDAL = new ProductDAL();
            cmbProduct.DataSource = objDAL.LoadProdcutbyCategory(id);
            cmbProduct.ValueMember = "Pro_id";
            cmbProduct.DisplayMember = "name";
            cmbProduct.SelectedIndex = -1;
        }

        private void clearAll()
        {
            txtBarcode.Clear();
            txtPurchasePrice.Clear();
            txtQunatity.Clear();
            txtRemainingQuantity.Clear();
            txtSellPrice.Clear();
            cmbOrganization.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;

        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cmbOrganization.SelectedValue.ToString(), out organization_id);
            LoadCmbOrgBranch();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cmbCategory.SelectedValue.ToString(), out Cat_id);
            LoadCmbProduct(Cat_id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StockBAL obj = new StockBAL();
                StockDAL objDal = new StockDAL();
                Guid.TryParse(cmbOrganization.SelectedValue.ToString(), out organization_id);
                obj.Organization_id = organization_id;
                Guid.TryParse(cmbBranch.SelectedValue.ToString(), out Branch_id);
                obj.Branch_id = Branch_id;
                obj.POS_id = Purchase_Order_id;
                Guid.TryParse(cmbProduct.SelectedValue.ToString(), out ProductID);
                obj.Product_id = ProductID;
                Guid.TryParse(cmbCategory.SelectedValue.ToString(), out Cat_id);
                obj.Product_Category_id = Cat_id;
                obj.quantity = float.Parse(txtQunatity.Text);
                obj.saleprice = 0;// float.Parse(txtSellPrice.Text);
                obj.purchaseprice = 0;// float.Parse(txtPurchasePrice.Text);
                obj.barcode = "0";// txtBarcode.Text;
                obj.qie = 0;// float.Parse(txtQunatity.Text);
                obj.expiryDate = dtpExpiryDate.Value;
                obj.status = "Add Stock";
                obj.Order_no = "Manual";
               
                obj.SOS_id = Guid.Empty;
                obj.SOR_id = Guid.Empty;
                obj.POR_id = Guid.Empty;
                obj.Prescription_Medicine_id = Guid.Empty;
                obj.Product_Variant_id = Guid.Empty;
                obj.Source = Sources.PurchaseOrderDetail.ToString();
                obj.Type = "+";
                if (StockID != Guid.Empty)
                {
                    obj.id = StockID;
                    obj.Editby = Program.User_id;
                    obj.EditDate = DateTime.Now;
                    objDal.Update(obj);
                }
                else
                {
                    obj.Flag = 1;
                    obj.Addby = Program.User_id;
                    obj.AddDate = DateTime.Now;
                    objDal.Add(obj);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            loadStock(StockID);
            clearAll();
     

        }

        private void gridStock_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                Guid.TryParse(gridStock.Rows[rowindex].Cells["id"].Value.ToString(), out StockID);
                Guid.TryParse(gridStock.Rows[rowindex].Cells["POS"].Value.ToString(), out Purchase_Order_id);

                LoadForm(StockID);
            }

        }

        private void LoadForm(Guid id)
        {


            StockDAL obj = new StockDAL();
            DataTable dt = new DataTable();
            dt = obj.LoadAllByID(StockID);

            LoadCmbOrg();
            Guid.TryParse(dt.Rows[0]["Organization_id"].ToString(), out organization_id);
            cmbOrganization.SelectedValue = organization_id;
            LoadCmbOrgBranch();

            Guid.TryParse(dt.Rows[0]["Branch_id"].ToString(), out Branch_id);
            cmbBranch.SelectedValue = Branch_id;
            LoadCbxProductCategory();
            Guid.TryParse(dt.Rows[0]["Product_Category_id"].ToString(), out Cat_id);
            cmbCategory.SelectedValue = Cat_id;
            LoadCmbProduct(Cat_id);
            Guid.TryParse(dt.Rows[0]["Product_id"].ToString(), out ProductID);
            cmbProduct.SelectedValue = ProductID;
            txtQunatity.Text = dt.Rows[0]["Quantity"].ToString();
            txtRemainingQuantity.Text = dt.Rows[0]["RemainingQuantity"].ToString();
            txtSellPrice.Text = dt.Rows[0]["SellPrice"].ToString();
            txtPurchasePrice.Text = dt.Rows[0]["PurchasePrice"].ToString();
            txtBarcode.Text = dt.Rows[0]["Barcode"].ToString();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            POSMain.loadStockMain();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (StockID != Guid.Empty)
                {
                    StockDAL obj = new StockDAL();
                    DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        //Do something
                        obj.DeleteStock(StockID);
                    }
                    else if (result.Equals(DialogResult.Cancel))
                    {
                        clearAll();
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            loadStock(StockID);
            clearAll();
         

        }

        private void cmbOrganization_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cmbBranch.Focus();
            }
        }

        private void cmbBranch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cmbCategory.Focus();
            }
        }

        private void cmbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbProduct.Focus();
            }

        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                txtQunatity.Focus();
            }
        }

        private void txtQunatity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpExpiryDate.Focus();
            }
        }

        private void dtpExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPurchasePrice.Focus();
            }
        }

        private void txtPurchasePrice_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtSellPrice.Focus();
            }

        }

        private void txtSellPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBarcode.Focus();
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRemainingQuantity.Focus();
            }
        }

        private void cmbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid ProID = Guid.Empty;
            Guid.TryParse(cmbProduct.SelectedValue.ToString(), out ProID);
            loadStock(ProID);
            gridStock.Visible = true;
        }

        private void ucStock_Load(object sender, EventArgs e)
        {
            pgURL = "Manage Stocks";
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
                try { organization_id = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                LoadCmbOrgBranch();

                cmbOrganization.Visible = false;
                lblErrorOrganization.Visible = false;
                lblOrganization.Visible = false;


            }

            else if (AccountType == "Inventory Manager")
            {
                //for  Branch Admin

                try
                {
                    organization_id = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString());
                    Branch_id = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Branch_id"].ToString());
                }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                cmbOrganization.Visible = false;
                lblErrorOrganization.Visible = false;
                lblOrganization.Visible = false;
                cmbBranch.Visible = false;
                lblErrorBranch.Visible = false;
                lblBranch.Visible = false;

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
            cmbOrganization.SelectedValue = organization_id;
            LoadCmbOrgBranch();
            cmbBranch.SelectedValue = Branch_id;


        }
      

    }
}