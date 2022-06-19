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
    public partial class ucProduct : UserControl
    {
        bool validated = true;
        int TotalrowIndex = 0;
        List<Guid> removed_product_id = new List<Guid>();
        Product_CategoryBAL Product_Category_OBJ = new Product_CategoryBAL();
        Product_CategoryDAL Product_CategoryDAL_db = new Product_CategoryDAL();
        ProductBAL Product_obj = new ProductBAL();
        ProductDAL Product_db = new ProductDAL();
        DataGridViewButtonColumn editVariant = new DataGridViewButtonColumn();
        DataGridViewButtonColumn addVariant = new DataGridViewButtonColumn();
        ValidationRegex objvr = new ValidationRegex();
        private Guid ProductId = Guid.Empty;
        private Guid ProductCategoryId = Guid.Empty;
        private Guid Organization_id = Guid.Empty;
        private Guid Branch_id = Guid.Empty;
        private Guid Pricing_id = Guid.Empty;
        public static bool PerAdd;
        public static bool PerEdit;

        public static bool PerDel;
        public static string pgURL;
        private Guid Product_Variant_Id = Guid.Empty;
        private string AccountType = null;

        private Guid Branch = Guid.Empty;


        private FormMain formMain;
        public ucProduct()
        {
            InitializeComponent();
            ClearAll();
            Load_Grid(ProductId);
            Initialize();
            LoadCmbBrand();
            cbxCategory.Focus();
            LoadCmbOrg();
        }
        public ucProduct(Guid product_id, string status)
        {
            ProductId = product_id;
            InitializeComponent();
            Initialize();
            FillProductDetails();
            Load_Grid(product_id);

            cbxCategory.Focus();
            lblStatus.Text = status;
            btnSave.LabelText = "Update";

            if (gridProducts.Rows.Count == 0)
            {
                //Add Product Variant
                ProductVariantBAL objPVB = new ProductVariantBAL();
                ProductVariantDAL objPVD = new ProductVariantDAL();

                try
                {

                    ProductVariantDAL objD = new ProductVariantDAL();
                    DataTable dt = new DataTable();
                    dt = objD.GetProductVariantId_byProductId(ProductId);
                    Product_Variant_Id = Guid.Parse(dt.Rows[0]["Product_Variant_Id"].ToString());
                    if (Product_Variant_Id == Guid.Empty)
                    {
                        // For Add Default Variant of Product
                        objPVB.Product_Category_Id = ProductCategoryId;
                        objPVB.Product_Id = ProductId;
                        objPVB.Title = "Default Variant  " + txtName.Text;
                        objPVB.ShortName = "";
                        objPVB.Barcode = "";
                        objPVB.AddBy = "Admin";
                        objPVB.AddDate = DateTime.Now;
                        objPVB.Flag = 1;

                        objPVD.Add(objPVB);
                        dt = objD.GetProductVariantId_byProductId(ProductId);
                        Product_Variant_Id = Guid.Parse(dt.Rows[0]["Product_Variant_Id"].ToString());
                    }

                    LoadCmbOrg();
                    //	loadGrid_by_ProductVariantID(Product_Variant_Id);
                }
                catch
                {
                    DataTable dt = new DataTable();
                    ProductVariantDAL objD = new ProductVariantDAL();


                    if (Product_Variant_Id == Guid.Empty)
                    {
                        // For Add Default Variant of Product
                          objPVB.Product_Category_Id = ProductCategoryId;

                        objPVB.Flag = 1;
                        objPVB.Product_Id = ProductId;
                        objPVB.Title = "Default Variant  " + txtName.Text;
                        objPVB.ShortName = "";
                        objPVB.Barcode = "";
                        objPVB.AddBy = "Admin";
                        objPVB.AddDate = DateTime.Now;
                        objPVD.Add(objPVB);
                        dt = objD.GetProductVariantId_byProductId(ProductId);
                        Product_Variant_Id = Guid.Parse(dt.Rows[0]["Product_Variant_Id"].ToString());
                      

                    }
                }

                Load_Grid(product_id);

            }
        }

        //Validation Methodvar

        private void ucProduct_Load(object sender, EventArgs e)
        {
            gridProducts.Visible = true;
         //   ClearAll();
          //  gridProducts.Visible = false;
            panel6.Visible = false;
            panelExpiry.Visible = false;
            // panelA.Visible = false;
            panelB.Visible = false;
            panelC.Visible = false;
            panelD.Visible = false;


             LoadCmbOrg();
            LoadCmbOrgBranch();

            Guid.TryParse(cmbOrg.SelectedValue.ToString(), out Organization_id);
            LoadCmbOrgBranch();

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
                try {  Organization_id = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                LoadCmbOrgBranch();

                    cmbOrg.Visible = false;
                lblErrorOrganization.Visible = false;
                lblOrganization.Visible = false;


            }

           else if (AccountType == "Inventory Manager")
            {
                //for  Branch Admin

                try
                {
                    Organization_id = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString());
                    Branch_id = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Branch_id"].ToString());
                }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                cmbOrg.Visible = false;
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

            cmbOrg.SelectedValue = Organization_id;
            LoadCmbOrgBranch();
            cmbBranch.SelectedValue = Branch_id;
            LoadCmbOrg();
        }

        //KeyUP
        private void txt_Name_KeyUp(object sender, KeyEventArgs e)
        {
        }

        public void Initialize()
        {

            loadCbxCategories();
        }
        public void loadCbxCategories()
        {

            ProductCategoryDAL objDAL = new ProductCategoryDAL();

            string name = null;
            string name2 = null;
            DataTable dt1 = new DataTable();

            DataTable dt = objDAL.LoadAll();
            //
            for (int x = 0; x < dt.Rows.Count; x++)
            {

                Guid.TryParse(dt.Rows[x]["id"].ToString(), out  ProductCategoryId);
                name = dt.Rows[x]["name"].ToString();
                try
                {
                    dt1 = objDAL.GetCategoryHerarichy(ProductCategoryId);
                    name2 = dt1.Rows[0]["name"].ToString();
                    if (name != name2)
                    {
                        dt.Rows[x]["name"] = name2;
                        //    dt.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;

                    }
                }
                catch (Exception e) { e.Message.ToString(); }

            }

            // Loop on DT
            // For each id send call to procedure getCatagoryHierarchy
            // if checkon return value
            // cell 'name' ovvertide with the value returned by getCatagoryHierarchy



            //
            cbxCategory.DataSource = dt;
            cbxCategory.ValueMember = "id";
            cbxCategory.DisplayMember = "name";
            cbxCategory.SelectedIndex = -1;

        }
        public void FillProductDetails()
        {
            ProductDAL objDal = new ProductDAL();
            ProductBAL prod = objDal.LoadbyId(ProductId);
            PricingDAL obj = new PricingDAL();
            DataTable dt = new DataTable();

            dt = obj.FindPrice_Product(ProductId);


            try
            {

                cmbOrg.SelectedValue = prod.Organization_id;
                Organization_id = prod.Organization_id;
                
                cmbBranch.SelectedValue = prod.Branch_id;
                Branch_id = prod.Branch_id;
                cbxCategory.SelectedValue = prod.Product_Category_id;
                ProductCategoryId = prod.Product_Category_id;
                txtName.Text = prod.name;
                txtShortname.Text = prod.shortname;
                txtDescription.Text = prod.description;
                txtCode.Text = prod.code;
                chkInStock.Checked = prod.InStock;
                chkExpiry.Checked = prod.hasExpiry;
                chkHasVariants.Checked = prod.hasVariants;
                cmbBrand.Text = prod.company_name;
                txt_ForName.Text = prod.formula_name;
                txt_open.Text = prod.opn.ToString();
                txt_qtyineach.Text = prod.qie.ToString();
                txt_Rm.Text = prod.rm.ToString();
                txt_unit.Text = prod.unit;
                txtReorderPoint.Text = prod.reorder_point;
                txtReorderQuantity.Text = prod.reorder_quantity;
                txt_rs.Text = dt.Rows[0]["Price"].ToString();
                

            }
            catch (Exception e){
                MessageBox.Show(e.ToString());
                //Agr Pricing k Table mai Price  set nhi hoi means k abi shuru sy product add ki hai then yai code run hoga
                txt_rs.Text = prod.rs.ToString(); }

            //txt_CategoryName.Text = Product_CategoryDAL_db.LoadAll().Where(m => m.Product_Category_id == id).FirstOrDefault().name;
        }
        public void FillStockDetails()
        {

            StockDAL objDal = new StockDAL();
            DataTable dt = objDal.LoadAll(ProductId);



            //PricingDAL pricingDB = new PricingDAL();
            //Load_Grid();
            //int i = 0;
            //foreach (var item in Product_db.LoadAll().Where(m => m.Product_Category_id == id).ToList())
            //{
            //    addRow();
            //    gridProducts.Rows[i].Cells["name"].Value = item.name;
            //    gridProducts.Rows[i].Cells["rs"].Value = item.rs;
            //    gridProducts.Rows[i].Cells["rm"].Value = item.rm;
            //    gridProducts.Rows[i].Cells["OPN"].Value = item.opn;
            //    gridProducts.Rows[i].Cells["QIE"].Value = item.qie;
            //    gridProducts.Rows[i].Cells["company_name"].Value = item.company_name;
            //    gridProducts.Rows[i].Cells["formula_name"].Value = item.formula_name;
            //    gridProducts.Rows[i].Cells["ID"].Value = item.Pro_id;

            //    gridProducts.Rows[i].Cells["InStock"].Value = item.InStock;
            //    i++;
            //}
            ////  CalculateTotal();
        }
        public void Load_Grid(Guid Product_id)
        {
            ProductVariantDAL obj = new ProductVariantDAL();
            DataTable dt = new DataTable();
            dt = obj.LoadProductVariants_By_Product_Id(Product_id);
            gridProducts.DataSource = dt;
            gridProducts.Columns["Product_Variant_Id"].Visible = false;
              gridProducts.Columns["ShortName"].Visible =  false;
            gridProducts.Columns["Barcode"].Visible = false;
            gridProducts.Columns["product_Id"].Visible = false;
            gridProducts.Columns["Product_Category_Id"].Visible = false;
            gridProducts.Columns["Barcode_Type_Id"].Visible = false;

            gridProducts.Columns["AddBy"].Visible = false;
            gridProducts.Columns["AddDate"].Visible = false;
            gridProducts.Columns["EditBy"].Visible = false;
            gridProducts.Columns["EditDate"].Visible = false;
             gridProducts.Columns["Flag"].Visible = false;
            //if (ProductId == Guid.Empty)
            //{

            //    gridProducts.Columns.Add("Product Variant", "ProductVariant");        //0
            //    gridProducts.Columns["ActualCode"].Width = 125;
            //    gridProducts.Columns.Add("BarcodeType", "Barcode Type");                   //1  
            //    gridProducts.Columns.Add("Description", "Description");                   //2          
            //                                                                                      //gridProducts.Columns.Add("expiry", "Expiry");         //3   
            //                                                                                      //gridProducts.Columns["expiry"].Width = 250;

            //    gridProducts.Columns.Add("Id", "ID");   
            //    gridProducts.Columns["ID"].Visible = false;


            //}
            //else
            //{
            //    BarcodeBAL objBAL = new BarcodeBAL();

            //    BarcodeDAL objDal = new BarcodeDAL();

            //    objBAL.product_id = ProductId;
            //    DataTable dt = objDal.LoadByProduct(objBAL);

            //    gridProducts.Columns.Clear();
            //    gridProducts.Rows.Clear();
            //    gridProducts.DataSource = null;
            //    foreach (DataColumn dc in dt.Columns)
            //    {
            //        gridProducts.Columns.Add(dc.ColumnName, dc.ColumnName);
            //    }
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        gridProducts.Rows.Add(dr.ItemArray);
            //    }
            //    gridProducts.Columns["ActualCode"].Width = 125;
            //   gridProducts.Columns["ActualCode"].HeaderText = "Bar Code";
            //    gridProducts.Columns["BarcodeType"].HeaderText = "Barcode Type";
            //    gridProducts.Columns["Description"].HeaderText = "Description";
            //    gridProducts.Columns["id"].Visible = false;
            //    gridProducts.Columns["product_id"].Visible = false;
            //    gridProducts.Columns["ProductCategory_id"].Visible = false;

            //    gridProducts.Columns["code"].Visible = false;
            //    gridProducts.Columns["AddBy"].Visible = false;
            //    gridProducts.Columns["AddDate"].Visible = false;
            //    gridProducts.Columns["EditBy"].Visible = false;
            //    gridProducts.Columns["EditDate"].Visible = false;
            //    gridProducts.Columns["Status"].Visible = false;
            //    gridProducts.Columns["Flag"].Visible = false;

            //}
            try
            {

                gridProducts.Columns.Add(editVariant);                                        //6
                editVariant.HeaderText = "Edit";
                editVariant.Text = "!";
                editVariant.Name = "editVariant";
                editVariant.UseColumnTextForButtonValue = true;
                gridProducts.Columns["editVariant"].Width = 50;


                gridProducts.Columns.Add(addVariant);
                addVariant.HeaderText = "Manage Variants";                                              //5
                addVariant.Text = "Add Variant";
                addVariant.Name = "addVariant";
                addVariant.UseColumnTextForButtonValue = true;
                gridProducts.Columns["addVariant"].Width = 100;

            }
            catch(Exception e) { /*MessageBox.Show(e.ToString());*/ }


            if (ProductId == Guid.Empty)
                addRow();
        }
        public void ValidateGridValues()
        {
            //for (int i = 0; i < gridProducts.RowCount; i++)
            //{
            //    try
            //    {
            //        double RS = Convert.ToDouble(gridProducts.Rows[i].Cells[1].Value.ToString());
            //    }
            //    catch (Exception)
            //    {
            //        gridProducts.Rows[i].Cells[1].Value = 0;
            //    }

            //    try
            //    {
            //        double qie = Convert.ToDouble(gridProducts.Rows[i].Cells["QIE"].Value.ToString());
            //    }
            //    catch (Exception)
            //    {
            //        gridProducts.Rows[i].Cells["QIE"].Value = 0;
            //    }

            //    try
            //    {
            //        double opn = Convert.ToDouble(gridProducts.Rows[i].Cells["OPN"].Value.ToString());
            //    }
            //    catch (Exception)
            //    {
            //        gridProducts.Rows[i].Cells["OPN"].Value = 0;
            //    }

            //    try
            //    {
            //        double RS = Convert.ToDouble(gridProducts.Rows[i].Cells[2].Value.ToString());
            //    }
            //    catch (Exception)
            //    {
            //        gridProducts.Rows[i].Cells[2].Value = 0;
            //    }
            //}
        }
        public void addRow()
        {
            //string[] row = null;
            //if (ProductId != Guid.Empty)
            //{
            //    row = new string[] { "", "", " " };
            //}
            //else
            //{
            //    row = new string[] { "", "", " "  };
            //}
            //if (row != null)
              //  gridProducts.Rows.Add(row);
        }
        //public void CalculateTotal()
        //{
        //    for (int i = 0; i < gridProducts.RowCount; i++)
        //    {
        //        double price = 0, quantity = 0;
        //        try
        //        {
        //            price = Convert.ToDouble(gridProducts.Rows[i].Cells[3].Value.ToString());
        //        }
        //        catch (Exception)
        //        {
        //            gridProducts.Rows[i].Cells[3].Value = 0;
        //        }
        //        try
        //        {
        //            quantity += Convert.ToDouble(gridProducts.Rows[i].Cells[4].Value.ToString());
        //        }
        //        catch (Exception)
        //        {
        //            gridProducts.Rows[i].Cells[4].Value = 0;
        //        }
        //        gridProducts.Rows[i].Cells[5].Value = price * quantity;
        //    }
        //}
        public Guid Insert_Product_Category()
        {
            //Product_Category_OBJ = new Product_CategoryBAL();
            ////Product_Category_OBJ.name = txt_CategoryName.Text;
            ////Product_Category_OBJ.shortname = txt_CategoryName.Text;
            ////Product_Category_OBJ.description = txt_CategoryName.Text;
            ////Product_Category_OBJ.code = txt_CategoryName.Text;
            //Product_Category_OBJ.Addby = "admin";
            //Product_Category_OBJ.AddDate = DateTime.Now;
            //Product_Category_OBJ.Flag = 1;
            //Product_CategoryDAL_db.Add(Product_Category_OBJ);
            //return Product_CategoryDAL_db.LoadAll().Max(m => m.Product_Category_id);
            return Guid.Empty;
        }

        private void LoadCmbBrand()
        {
            ProductDAL objDAL = new ProductDAL();
            cmbBrand.DataSource = objDAL.BrandFromProduct();
            // comboBox1.ValueMember = "Pro_id";
            cmbBrand.DisplayMember = "company_name";
            cmbBrand.SelectedIndex = -1;
        }
        private void LoadCmbOrg()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrg.DataSource = objDAL.LoadAll();
            cmbOrg.ValueMember = "organization_id";
            cmbOrg.DisplayMember = "Title";
            cmbOrg.SelectedIndex = 3;
            Guid.TryParse(cmbOrg.SelectedValue.ToString(), out Organization_id);

            LoadCmbOrgBranch();
         }

        // 2;// BranchID;

        private void LoadCmbOrgBranch()
        {
           
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();
            obj.Parent_id = Guid.Parse(cmbOrg.SelectedValue.ToString());
            cmbBranch.DataSource = objDAL.LoadBranch(obj);
            cmbBranch.ValueMember = "Organization_id";
            cmbBranch.DisplayMember = "Title";
            try
            {
                cmbBranch.SelectedIndex = 0;
            }
            catch { }
        }
        public void Update_Product_Category()
        {

            //Product_Category_OBJ = Product_CategoryDAL_db.LoadbyId(id).FirstOrDefault();
            //if (Product_Category_OBJ != null)
            //{
            //    //Product_Category_OBJ.name = txt_CategoryName.Text;
            //    //Product_Category_OBJ.shortname = txt_CategoryName.Text;
            //    //Product_Category_OBJ.description = txt_CategoryName.Text;
            //    //Product_Category_OBJ.code = txt_CategoryName.Text;
            //    Product_Category_OBJ.Editby = "admin";
            //    Product_Category_OBJ.EditDate = DateTime.Now;
            //    Product_CategoryDAL_db.Update(Product_Category_OBJ);
            //}
        }
        private void labelMessage()
        {
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                lblConfirmationMsg.Hide();
                t.Stop();
            };
            t.Start();
        }

        private void AddProductVariant(Guid Product_Id)
        {
            //Add Product Variant
            ProductVariantBAL objPVB = new ProductVariantBAL();
            ProductVariantDAL objPVD = new ProductVariantDAL();
            // For Add Default Variant of Product
            objPVB.Product_Id =  Product_Id;
            int n = gridProducts.Rows.Count;
            if (n >= 0)
            {
                n++;
            }
            objPVB.Title = txtName.Text + "   "+n;
            objPVB.Product_Category_Id = ProductCategoryId;
            objPVB.Barcode_Type_Id = Guid.Empty;
            objPVB.ShortName = "";
            objPVB.Barcode = "";
            objPVB.AddBy = "Admin";
            objPVB.AddDate = DateTime.Now;
            objPVB.Flag = 1;
            objPVD.Add(objPVB);

            Load_Grid(Product_Id);
        }

        private void AddProductVariant()
        {
            //Add Product Variant
            ProductVariantBAL objPVB = new ProductVariantBAL();
            ProductVariantDAL objPVD = new ProductVariantDAL();
            // For Add Default Variant of Product
            objPVB.Product_Id = ProductId;
            int n = gridProducts.Rows.Count;
            if (n >= 0)
            {
                n++;
            }
            objPVB.Title = txtName.Text + "   " + n;
            objPVB.Product_Category_Id = ProductCategoryId;
            objPVB.Barcode_Type_Id = Guid.Empty;
            objPVB.ShortName = "";
            objPVB.Barcode = "";
            objPVB.AddBy = "Admin";
            objPVB.AddDate = DateTime.Now;
            objPVB.Flag = 1;
            objPVD.Add(objPVB);

            Load_Grid(ProductId);
        }

        public void SaveProduct(Guid ProductId)
        {
            try
            {
                PricingBAL objb = new PricingBAL();
                PricingDAL obj = new PricingDAL();
               

           
                bool condition = true;
                if (FormValid())
                {
                    Product_obj = new ProductBAL();
                    Product_obj.name = txtName.Text;
                    Product_obj.shortname = txtShortname.Text;
                    Product_obj.description = txtDescription.Text;
                    Product_obj.code = txtCode.Text;
                    Product_obj.hasVariants = chkHasVariants.Checked;
                    Product_obj.InStock = chkInStock.Checked;
                    Product_obj.hasExpiry = chkExpiry.Checked;
                    Product_obj.company_name = cmbBrand.Text;
                    Product_obj.opn = 0; //float.Parse(txt_open.Text);
                   // float temp = 0;
                  //float.TryParse(txt_qtyineach.Text,out temp);
                    Product_obj.qie = int.Parse(txt_qtyineach.Text);
                    Product_obj.rs = 0;
                    Product_obj.rm = 0;//float.Parse(txt_Rm.Text);
                    Product_obj.formula_name = txt_ForName.Text;
                    Product_obj.unit = (txt_unit.Text);
                    Product_obj.reorder_point = txtReorderPoint.Text;
                    Product_obj.reorder_quantity = txtReorderQuantity.Text;
                    Product_obj.Flag = 1;
                    Product_obj.status = "Active";
                    Product_obj.Product_Category_id = ProductCategoryId;
                    Guid.TryParse(cmbOrg.SelectedValue.ToString(), out Organization_id);
                    Product_obj.Organization_id = Organization_id;
                    Guid.TryParse(cmbBranch.SelectedValue.ToString(), out Branch_id);
                    Product_obj.Branch_id = Branch_id;
                    lblConfirmationMsg.Refresh();
                    if (ProductId == Guid.Empty)
                    {

                        Product_obj.Addby = Program.User_id;
                        Product_obj.AddDate = DateTime.Now;
                        ProductId = Product_db.Add(Product_obj);
                        // For Add Default Variant of Product
                        AddProductVariant(ProductId);
                        //Product_db.Add(Product_obj);
                        labelMessage();
                        lblConfirmationMsg.Text = "Record Saved Successfully";


                    }
                    else
                    {

                        Product_obj.Pro_id = ProductId;
                        Product_obj.Editby = Program.User_id;
                        Product_obj.EditDate = DateTime.Now;
                        Product_db.Update(Product_obj);
                        labelMessage();
                        lblConfirmationMsg.Text = "Record Updated Successfully";
                     
                        lblConfirmationMsg.Hide();

                    }
                    Load_Grid(ProductId);





                    //For Pricing Table
                    float tempPrice = 0;
                    DataTable dt = new DataTable();
                    objb.ProID = ProductId;
                    objb.CatID = ProductCategoryId;
                    float.TryParse(txt_rs.Text, out tempPrice);
                    objb.Date = DateTime.Now;

                    objb.Purchase_order_id = Guid.Empty;
                    objb.AddBy = "Admin";
                    objb.AddDate = DateTime.Now;

                    dt = obj.FindPrice_Pricing(ProductId, ProductCategoryId);
                    if (dt.Rows.Count != 0)
                    {
                        var priceD = dt.Rows[0]["Price"];


                        if (tempPrice != float.Parse(priceD.ToString()))
                        {
                            var priceID = dt.Rows[0]["PriceID"];
                            Guid.TryParse(priceID.ToString(), out Pricing_id);
                            objb.price = float.Parse(txt_rs.Text.ToString());

                            objb.Pricing_id = Pricing_id;
                            objb.status = "Inactive";
                            objb.Flag = 0;
                            obj.Update(objb);

                            //Add new price

                            if (condition == true)
                            {
                                objb.Pricing_id = Guid.Empty;
                                objb.price = float.Parse(txt_rs.Text.ToString());
                                objb.status = "Active";
                                objb.Flag = 1;
                                obj.Add(objb);
                                condition = false;
                            }
                        }

                    }


                    if (condition == true)
                    {
                        objb.Pricing_id = Guid.Empty;
                        objb.price = float.Parse(txt_rs.Text.ToString());
                        objb.status = "Active";
                        objb.Flag = 1;
                        obj.Add(objb);
                     }





                    //for (int i = 0; i < gridProducts.Rows.Count; i++)
                    //{
                    //    try
                    //    {
                    //        StockBAL objBal = new StockBAL();
                    //        Guid id;
                    //        try
                    //        {
                    //            id = Guid.Parse(gridProducts.Rows[i].Cells["ID"].Value.ToString());
                    //        }
                    //        catch
                    //        {
                    //            id = Guid.Empty;
                    //        }
                    //        objBal.barcode = txtCode.Text;
                    //        objBal.quantity = Convert.ToInt32(gridProducts.Rows[i].Cells["quantity"].Value.ToString());
                    //        objBal.qie = Convert.ToInt32(gridProducts.Rows[i].Cells["quantityineach"].Value.ToString());
                    //        objBal.purchaseprice = Convert.ToInt32(gridProducts.Rows[i].Cells["purchaseprice"].Value.ToString());
                    //        objBal.saleprice = Convert.ToInt32(gridProducts.Rows[i].Cells["sellingprice"].Value.ToString());
                    //        objBal.Product_id = ProductId;
                    //        objBal.Flag = 1;
                    //        StockDAL objDal = new StockDAL();
                    //        if (id == Guid.Empty)
                    //        {
                    //            objBal.Addby = Program.User_id;
                    //            objBal.AddDate = DateTime.Now;
                    //            objDal.Add(objBal);
                    //        }
                    //        else
                    //        {
                    //            objBal.id = id;
                    //            objBal.Editby = Program.User_id;
                    //            objBal.EditDate = DateTime.Now;
                    //            objBal.EditDate = DateTime.Now;
                    //            objDal.Update(objBal);
                    //        }
                    //    }
                    //    catch (Exception e4)
                    //    {
                    //        MessageBox.Show(e4.Message, "Error while saving records");
                    //    }
                    //}

                    // Add Data into Barcode_Table by this code.
                    //Now i update code ..barcode save in product Variant table
                    //Therefor i comment this code.

                    //for (int i = 0; i < gridProducts.Rows.Count; i++)
                    //{
                    //    try
                    //    {
                    //        BarcodeBAL objBal = new BarcodeBAL();
                    //        Guid id;
                    //        try
                    //        {
                    //          id = Guid.Parse(gridProducts.Rows[i].Cells["ID"].Value.ToString());
                    //        }
                    //        catch
                    //        {
                    //            id = Guid.Empty;
                    //        }
                    //        objBal.ActualCode = gridProducts.Rows[i].Cells["ActualCode"].Value.ToString();
                    //        objBal.BarcodeType =  gridProducts.Rows[i].Cells["BarcodeType"].Value.ToString();
                    //        objBal.Description = gridProducts.Rows[i].Cells["Description"].Value.ToString();
                    //        objBal.code = txtCode.Text;
                    //        objBal.status = "Active";
                    //        objBal.product_id = ProductId;
                    //        objBal.ProductCategory_id = ProductCategoryId;

                    //        objBal.Flag = 1;
                    //        BarcodeDAL objDal = new BarcodeDAL();
                    //        if (id == Guid.Empty)
                    //        {
                    //            objBal.AddBy = Program.User_id;
                    //            objBal.AddDate = DateTime.Now;
                    //            objDal.Add(objBal);
                    //        }
                    //        else
                    //        {
                    //            objBal.id = id;
                    //            objBal.EditBy = Program.User_id;
                    //            objBal.EditDate = DateTime.Now;
                    //             objDal.Update(objBal);
                    //        }
                    //    }
                    //    catch (Exception e4)
                    //    {
                    //        MessageBox.Show(e4.Message, "Error while saving Barcode ");
                    //    }
                    //}

                    //  POSMain.loadProduct(Guid.Empty, Product_obj.name + " Saved Successfully");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
        }

        private bool FormValid()
        {
            bool isValid = true;

            //Category
            if (ProductCategoryId == Guid.Empty || cbxCategory.SelectedIndex < 0)
            {
                lblErrorCategory.Text = "Required!";
                isValid = false;
            }
            else
                lblErrorCategory.Text = "";

            // Title
            //User Name
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorTitle.Text += "UserName is required!";
                validated = false;
            }
            else
            {
                lblErrorTitle.Text = "";
            }

            //if (!Validation.isAlpha(txtName.Text, 25))
            //{
            //    if (string.IsNullOrEmpty(txtName.Text))
            //        lblErrorTitle.Text += "\n";
            //    lblErrorTitle.Text += "Name Should be in  Alphabets ";
            //    validated = false;
            //}
            //else
            //{
            //    lblErrorTitle.Text = "";
            //}
            //===========
            

            return validated;
        }

            public void Update_Product()
        {
            //for (int i = 0; i < gridProducts.Rows.Count; i++)
            //{
            //    Product_obj = new ProductBAL();
            //    Product_obj.Pro_id = Guid.Parse(gridProducts.Rows[i].Cells["ID"].Value.ToString());
            //    Product_obj.name = gridProducts.Rows[i].Cells[0].Value.ToString();
            //    Product_obj.shortname = gridProducts.Rows[i].Cells[0].Value.ToString() + " | " ;
            //    Product_obj.description = gridProducts.Rows[i].Cells[0].Value.ToString();
            //    Product_obj.code = gridProducts.Rows[i].Cells[0].Value.ToString();
            //    try
            //    {
            //        Product_obj.InStock = Convert.ToBoolean(gridProducts.Rows[i].Cells["InStock"].Value.ToString());
            //    }
            //    catch
            //    {
            //        Product_obj.InStock = false;
            //    }
            //    try
            //    {
            //        Product_obj.rs = Convert.ToDouble(gridProducts.Rows[i].Cells[1].Value.ToString());

            //    }
            //    catch (Exception)
            //    {
            //        Product_obj.rs = 0;

            //    }
            //    try
            //    {
            //        Product_obj.opn = Convert.ToDouble(gridProducts.Rows[i].Cells["OPN"].Value.ToString());
            //    }
            //    catch (Exception)
            //    {
            //        Product_obj.opn = 0;
            //    }

            //    try
            //    {
            //        Product_obj.qie = Convert.ToDouble(gridProducts.Rows[i].Cells["QIE"].Value.ToString());
            //    }
            //    catch (Exception)
            //    {
            //        Product_obj.qie = 0;
            //    }
            //    try
            //    {
            //        Product_obj.rm = Convert.ToDouble(gridProducts.Rows[i].Cells[2].Value.ToString());

            //    }
            //    catch (Exception)
            //    {

            //        Product_obj.rm = 0;

            //    }
            //    Product_obj.company_name = gridProducts.Rows[i].Cells["company_name"].Value.ToString();
            //    Product_obj.formula_name = gridProducts.Rows[i].Cells["formula_name"].Value.ToString();
            //    Product_obj.Editby = "Admin";
            //    Product_obj.EditDate = DateTime.Now;
            //    Product_obj.Product_Category_id = id;
            //    if (Product_obj.Pro_id != null)
            //    {
            //        Product_db.Update(Product_obj);

            //    }
            //    else
            //    {
            //        Product_db.Add(Product_obj);

            //    }
            //}
            //foreach (var item in removed_product_id)
            //{
            //    Product_obj.Pro_id = item;
            //    Product_db.Delete(Product_obj);
            //}
        }


        private void ClearAll()
        {
            cmbOrg.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            cmbBranch.SelectedText = "";
            cbxCategory.SelectedIndex = -1;
            txtCode.Text = "N";
            txtDescription.Text = "N";
            txtName.Clear();
            txtReorderPoint.Text = "N";
            txtReorderQuantity.Text = "0";
            txtShortname.Clear();
            txt_ForName.Text = "N";
            txt_open.Text = "N";
            txt_qtyineach.Text ="0";
            txt_Rm.Text = "N";
            txt_rs.Text = "0";
            txt_unit.Text = "N";
            btnSave.LabelText = "Save";
            ProductId = Guid.Empty;
            cbxCategory.Focus();


            LoadCmbOrg();
            LoadCmbBrand();
            loadCbxCategories();
            LoadCmbOrgBranch();
            gridProducts.DataSource = null;

        }
        private void Search()
        {
            if (ProductId != Guid.Empty)
            {
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }
        private void Content(DataGridViewCellEventArgs e)
        {
         
                Product_Variant_Id =  Guid.Parse(gridProducts.Rows[e.RowIndex].Cells["Product_Variant_Id"].Value.ToString());

            

            if (e.ColumnIndex == gridProducts.Columns["editVariant"].Index)
            {
                POSMain.loadManageVariants(Product_Variant_Id);
            }
            if (e.ColumnIndex == gridProducts.Columns["addVariant"].Index && gridProducts.RowCount >=0)
            {
                AddProductVariant();
              
                //Guid remid;

                //try
                //{
                //    remid = Guid.Parse(gridProducts.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                //}
                //catch
                //{
                //    remid = Guid.Empty;
                //}
                //try
                //{
                //    if (ProductId != Guid.Empty)
                //    {
                //        removed_product_id.Add(ProductId);
                //    }

                //    gridProducts.Rows.RemoveAt(e.RowIndex);
                //}
                //catch (Exception e3)
                //{
                //    MessageBox.Show("Error: " + e3.Message, "Unable to delete row");
                //}

            }
        }

        private void gridMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void gridVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void gridVoucher_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            ValidateGridValues();
        }

        private void gridMedicine_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidateGridValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateGridValues();

            SaveProduct(ProductId);

            lblStatus.Text = "Product Saved Successfully";
             //ClearAll();
         }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId != Guid.Empty)
                {
                    ProductDAL obj = new ProductDAL();
                    ProductBAL ob = new ProductBAL();
                    PricingDAL objP = new PricingDAL();
                    PricingBAL oj = new PricingBAL();
                    DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        //Do something
                        ob.Pro_id = ProductId;
                        oj.ProID = ProductId;
                        obj.Delete(ob);
                        objP.DeleteProduct(oj);
                        ClearAll();
                    }
                    else if (result.Equals(DialogResult.Cancel))
                    {
                        ClearAll();
                    }

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            POSMain.loadProductMain();
        }

        private void cbxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cbxCategory.SelectedValue.ToString(), out ProductCategoryId);
        }

        private void radScrollablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void cbxInStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbOrg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cmbOrg.SelectedValue.ToString(), out Organization_id);
            LoadCmbOrgBranch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblConfirmationMsg.Visible = false;
            timer1.Stop();
        }

        private void cmbOrg_KeyDown(object sender, KeyEventArgs e)
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
                cbxCategory.Focus();
            }
        }

        private void cbxCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtShortname.Focus();
            }
        }

        private void txtShortname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCode.Focus();
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBrand.Focus();
            }
        }

        private void cmbBrand_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_rs.Focus();
            }
        }

        private void txt_rs_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_ForName.Focus();
            }
        }

        private void txt_unit_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_Rm.Focus();
            }
        }

        private void txt_ForName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtReorderQuantity.Focus();
            }
        }

        private void txt_qtyineach_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_unit.Focus();
            }
        }

        private void txtReorderQuantity_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtReorderPoint.Focus();
            }
        }

        private void txtReorderPoint_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_Rm.Focus();
            }
        }

        private void txt_Rm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_open.Focus();
            }
        }

        private void txt_rs_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            FormPrice f = new FormPrice(ProductCategoryId,ProductId);
            f.Show();
        }

        private void cmbOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Guid.TryParse(cmbOrg.SelectedValue.ToString(), out Organization_id);
                LoadCmbOrgBranch();
            }
            catch { }
        }

        private void btnPrice_Click_1(object sender, EventArgs e)
        {
            FormPrice f = new FormPrice(ProductCategoryId, ProductId);
            f.Show();
        }

     
    }
}