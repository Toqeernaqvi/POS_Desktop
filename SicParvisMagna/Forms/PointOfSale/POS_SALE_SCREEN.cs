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
using SicParvisMagna.Forms.PointOfSale;
using System.Collections;
using BasicCRUD.Controllers;
using System.Timers;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class POS_SALE_SCREEN : UserControl
    {
        bool validated = true;
        int x = 0;//f=for product Frid
                  //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        bool debug = false;
        bool testStock = true;

        private string AccountType = null;
        Guid Sale_order_id = Guid.Empty;

        private Guid Sale_order_detail_id = Guid.Empty;
        private Guid Customer_id = Guid.Empty;
        private Guid stock_id = Guid.Empty;
        private Guid Product_Variant_Id = Guid.Empty;
        private Guid organization_id = Guid.Empty;
        private Guid branch_id = Guid.Empty;
        private Guid tax_id = Guid.Empty;
        private Guid Product_Category_id = Guid.Empty;
        private Guid Pro_id = Guid.Empty;
        private Guid Variant_Type_Id = Guid.Empty;
        private Guid Product_Id = Guid.Empty;
        private string payment_type = "";
        GridViewComboBoxColumn cmb_ProductCategory = new GridViewComboBoxColumn();
        GridViewComboBoxColumn cmb_Product = new GridViewComboBoxColumn();
        GridViewComboBoxColumn cmb_Tax = new GridViewComboBoxColumn();
        // GridViewComboBoxColumn Quantity = new GridViewComboBoxColumn();
        GridViewTextBoxColumn Quantity = new GridViewTextBoxColumn();
        GridViewComboBoxColumn cmbQuantityType = new GridViewComboBoxColumn();
        GridViewComboBoxColumn cmbVariant = new GridViewComboBoxColumn();
        GridViewComboBoxColumn cmbVariantType = new GridViewComboBoxColumn();
        GridViewTextBoxColumn UnitPrice = new GridViewTextBoxColumn();
        GridViewTextBoxColumn DiscountPercentage = new GridViewTextBoxColumn();
        GridViewTextBoxColumn DiscountAmount = new GridViewTextBoxColumn();

        GridViewTextBoxColumn SubTotal = new GridViewTextBoxColumn();
        GridViewTextBoxColumn SaleAmount = new GridViewTextBoxColumn();

        GridViewTextBoxColumn PriceWithoutDiscount = new GridViewTextBoxColumn();
        GridViewTextBoxColumn PriceWithDiscount = new GridViewTextBoxColumn();
        GridViewTextBoxColumn PriceWithTax = new GridViewTextBoxColumn();
        private System.Timers.Timer timer;

        double sub_total;
        double Stotal;
        double tempp = 0;
        Double temp = 0;
        string Tax;
        string QuantityType = null;
        Double TotalQuantity = 0;

        Guid value = Guid.Empty;
        //





        //

        public void Load_Grid_Columns()
        {

            gridSales.Columns.Clear();

            GridViewCommandColumn btn_newrow = new GridViewCommandColumn();
            GridViewCommandColumn btn_delrow = new GridViewCommandColumn();

            ProductCategoryDAL objDAL = new ProductCategoryDAL();

            cmb_ProductCategory.HeaderText = "Category";
            cmb_ProductCategory.Name = "cmb_ProductCategory";

            this.gridSales.Columns.Add(cmb_ProductCategory);
            cmb_ProductCategory.DataSource = objDAL.LoadAll();
            cmb_ProductCategory.DisplayMember = "name";
            cmb_ProductCategory.ValueMember = "id";

            gridSales.Columns[0].Width = 80;


            //Product Coloumn
            ProductDAL objPDAL = new ProductDAL();

            cmb_Product.HeaderText = "Product";
            cmb_Product.Name = "cmb_Product";
            cmb_Product.DataSource = objPDAL.LoadAll();
            cmb_Product.DisplayMember = "Title";
            cmb_Product.ValueMember = "id";
            gridSales.Columns.Add(cmb_Product);

            gridSales.Columns["cmb_Product"].Width = 80;


            

            //Variant Coloum

            ProductVariantDAL objVDAL = new ProductVariantDAL();
            cmbVariant.HeaderText = "Variant";
            cmbVariant.Name = "cmbVariant";
            cmbVariant.DataSource = objVDAL.LoadAllVariants();
            cmbVariant.DisplayMember = "Variants";
            cmbVariant.ValueMember = "Product_Variant_Id";
            gridSales.Columns.Add(cmbVariant);
            gridSales.Columns["cmbVariant"].Width = 150;

            //Quantity Type

            cmbQuantityType.HeaderText = "Qty.Type";
            cmbQuantityType.Name = "cmbQuantityType";
            cmbQuantityType.DataSource = new String[] { "Packs", "Units" };
            cmbQuantityType.NullValue = "Packs";
            cmbQuantityType.FieldName = "Packs";
            //cmbQuantityType.DisplayMember = "Packs";
            //  cmbQuantityType.ValueMember =  "{acks" ;
            gridSales.Columns.Add(cmbQuantityType);

            gridSales.Columns["cmbQuantityType"].Width = 40;


            //Quantity Colunm
            Quantity.HeaderText = "Qty";
            Quantity.Name = "Quantity";

            gridSales.Columns.Add(Quantity);
            gridSales.Columns["Quantity"].Width = 40;
            // Quantity.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;



            //Unit Price Colunm
            UnitPrice.HeaderText = "Unit.Price";
            UnitPrice.Name = "UnitPrice";
            gridSales.Columns.Add(UnitPrice);
            gridSales.Columns["UnitPrice"].Width = 40;

          //  price w/ o disc
            PriceWithoutDiscount.HeaderText = "Price Without Discount";
            PriceWithoutDiscount.Name = "PriceWithoutDiscount";
            gridSales.Columns.Add(PriceWithoutDiscount);
            gridSales.Columns["PriceWithoutDiscount"].Width = 50;
            gridSales.Columns["PriceWithoutDiscount"].IsVisible = false;


            //Discount Percentage
            DiscountPercentage.HeaderText = "Disc_%";
            DiscountPercentage.Name = "DiscountPercentage";
            gridSales.Columns.Add(DiscountPercentage);
            gridSales.Columns["DiscountPercentage"].Width = 40;


            //Discount Amount
            DiscountAmount.HeaderText = "Disc_Amount";
            DiscountAmount.Name = "DiscountAmount";
            gridSales.Columns.Add(DiscountAmount);
            gridSales.Columns["DiscountAmount"].Width = 50;


            //price w/ d
            PriceWithDiscount.HeaderText = "Price With Discount";
            PriceWithDiscount.Name = "PriceWithDiscount";
            gridSales.Columns.Add(PriceWithDiscount);
            gridSales.Columns["PriceWithDiscount"].Width = 50;
            gridSales.Columns["PriceWithDiscount"].IsVisible = false;


            //Tax Coloumn
            TaxDAL objTDAL = new TaxDAL();
            cmb_Tax.HeaderText = "Tax";
            cmb_Tax.Name = "cmb_Tax";
            gridSales.Columns.Add(cmb_Tax);
            cmb_Tax.DataSource = objTDAL.LoadAll();
            cmb_Tax.DisplayMember = "Tax";
            cmb_Tax.ValueMember = "TaxID";
            // cmb_Tax.Index = sksk;
            // cmb_Tax.Index = -1;//Guid.Empty;
            gridSales.Columns["cmb_Tax"].Width = 50;

            ////price w t
            PriceWithTax.HeaderText = "Price With Tax";
            PriceWithTax.Name = "PriceWithTax";
            gridSales.Columns.Add(PriceWithTax);
            gridSales.Columns["PriceWithTax"].Width = 50;
            gridSales.Columns["PriceWithTax"].IsVisible = false;

            //Sub Total Colunm
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            gridSales.Columns.Add(SubTotal);
            gridSales.Columns["SubTotal"].Width = 50;


          

            //
            gridSales.Columns.Add(btn_newrow);
            btn_newrow.HeaderText = "Add";
            btn_newrow.UseDefaultText = true;
            btn_newrow.DefaultText = "   +  ";
            btn_newrow.Name = "btn_newrow";
            gridSales.Columns["btn_newrow"].Width = 30;
            gridSales.Columns.Add(btn_delrow);              //5
            btn_delrow.HeaderText = "Delete";
            btn_delrow.UseDefaultText = true;
            btn_delrow.DefaultText = "  -  "; ;
            btn_delrow.Name = "btn_delrow";
            gridSales.Columns["btn_delrow"].Width = 30;

            if (debug == true)
            {

                gridSales.Columns["PriceWithDiscount"].IsVisible = false;
                gridSales.Columns["PriceWithOutDiscount"].IsVisible = false;
                gridSales.Columns["PriceWithTax"].IsVisible = false;
            }
        }

        public void addRow_PurchasesGrid()
        {
            GridViewRowInfo row = gridSales.Rows.AddNew();
            int i = row.Index;
            sub_total = 0;
            //gridSales.Rows[i].Cells["SaleAmount"].Value = 0;
            gridSales.Rows[i].Cells["cmb_Tax"].Value = Guid.Parse("1E015D8C-0ECD-4DAA-83DB-0C258669C1BD");

            gridSales.Rows[i].Cells["DiscountPercentage"].Value = 0;
            gridSales.Rows[i].Cells["DiscountAmount"].Value = 0;

            gridSales.Rows[i].Cells["SubTotal"].Value = 0;

            gridSales.Rows[i].Cells["Quantity"].Value = 0;
            gridSales.Rows[i].Cells["UnitPrice"].Value = 0;


        }
      
        // load grid for advance Search

        private void loadGrid_by_ProductID(Guid id)

        {
            try
            {
                //Assign Values

                debug = true;




                ProductDAL obj = new ProductDAL();
                DataTable dt = obj.ProductLoadbyid(id);
                Product_CategoryDAL objDAL = new Product_CategoryDAL();
                cmb_ProductCategory.DataSource = objDAL.LoadAll();
                cmb_ProductCategory.DisplayMember = "name";
                cmb_ProductCategory.ValueMember = "id";

                var ProductCategory = dt.Rows[0]["id"];
                gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;
                //



                cmb_Product.DataSource = obj.LoadAll();
                cmb_Product.DisplayMember = "Title";
                cmb_Product.ValueMember = "id";

                var ProductID = dt.Rows[0]["pro_id"];
                gridSales.Rows[x].Cells["cmb_Product"].Value = ProductID;

                //

                TaxDAL objTDAL = new TaxDAL();

                cmb_Tax.DataSource = objTDAL.LoadAll();
                cmb_Tax.DisplayMember = "Tax";
                cmb_Tax.ValueMember = "TaxID";



                Calculate_Discount();
                Calculate_Discount_Amount();
                Calculate_Tax();

                Sub_Total();
                if (debug == true)
                {

                    gridSales.Columns["PriceWithDiscount"].IsVisible = false;
                    gridSales.Columns["PriceWithOutDiscount"].IsVisible = false;
                    gridSales.Columns["PriceWithTax"].IsVisible = false;
                }

                addRow_PurchasesGrid();
                x = gridSales.RowCount;
                x--;
            }
            catch { }
        }
        //Advance Search Work
        private void loadSCategory()
        {
            ProductCategoryDAL objDAL = new ProductCategoryDAL();
            DataTable dt = objDAL.LoadAll();

            cmbSCategory.DataSource = dt;
            cmbSCategory.ValueMember = "id";
            cmbSCategory.DisplayMember = "name";
            cmbSCategory.SelectedIndex = -1;
        }
        private void loadSBrand()
        {
            ProductDAL objDAL = new ProductDAL();
            DataTable dt = objDAL.BrandFromProduct();

            cmbSBrand.DataSource = dt;
           cmbSBrand.ValueMember = "company_name";
            cmbSBrand.DisplayMember = "company_name";
            cmbSBrand.SelectedIndex = -1;
        }
        // load search grid by brand 
        private void LoadSGridBrand(string value )
        {
            DataTable dt = new DataTable();

            ProductDAL objDAL = new ProductDAL();
            dt = objDAL.LoadProdcutbyBrand(value);
            gridSearchResult.DataSource = dt;
            //cmbProduct.ValueMember = "Pro_id";
            //cmbProduct.DisplayMember = "name";
            //cmbProduct.SelectedIndex = -1;

            gridSearchResult.Columns["Pro_id"].Visible = false;
            gridSearchResult.Columns["name"].Visible = false;
            gridSearchResult.Columns["id"].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
        }
        private void LoadSGridFourmula(string value)
        {
            DataTable dt = new DataTable();

            ProductDAL objDAL = new ProductDAL();
            dt = objDAL.LoadProdcutbyFourmula(value);
            gridSearchResult.DataSource = dt;
            //cmbProduct.ValueMember = "Pro_id";
            //cmbProduct.DisplayMember = "name";
            //cmbProduct.SelectedIndex = -1;

            gridSearchResult.Columns["Pro_id"].Visible = false;
            gridSearchResult.Columns["name"].Visible = false;
            gridSearchResult.Columns["id"].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
        }
        private void LoadSGridPrice(string value)
        {
            DataTable dt = new DataTable();

            ProductDAL objDAL = new ProductDAL();
            dt = objDAL.LoadProdcutbyPrice(value);
            gridSearchResult.DataSource = dt;
            //cmbProduct.ValueMember = "Pro_id";
            //cmbProduct.DisplayMember = "name";
            //cmbProduct.SelectedIndex = -1;

            gridSearchResult.Columns["Pro_id"].Visible = false;
            gridSearchResult.Columns["name"].Visible = false;
            gridSearchResult.Columns["id"].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
        }
        private void LoadSGridProduct_name_(string value)
        {
            DataTable dt = new DataTable();

            ProductDAL objDAL = new ProductDAL();
            dt = objDAL.LoadProdcutbyName_(value);
            gridSearchResult.DataSource = dt;
            //cmbProduct.ValueMember = "Pro_id";
            //cmbProduct.DisplayMember = "name";
            //cmbProduct.SelectedIndex = -1;

            gridSearchResult.Columns["Pro_id"].Visible = false;
            gridSearchResult.Columns["name"].Visible = false;
            gridSearchResult.Columns["id"].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
        }
        private void LoadSGridProduct_name_wildcard(string value)
        {
            DataTable dt = new DataTable();

            ProductDAL objDAL = new ProductDAL();
            dt = objDAL.LoadProdcutbyName_wildcard(value);
            gridSearchResult.DataSource = dt;
            //cmbProduct.ValueMember = "Pro_id";
            //cmbProduct.DisplayMember = "name";
            //cmbProduct.SelectedIndex = -1;

            gridSearchResult.Columns["Pro_id"].Visible = false;
            gridSearchResult.Columns["name"].Visible = false;
            gridSearchResult.Columns["id"].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
        }

        //load Products
        private void LoadSProducts(Guid id)
        {
            DataTable dt = new DataTable();
            
                ProductDAL objDAL = new ProductDAL();
              dt = objDAL.LoadProdcutbyCategory(id);
            gridSearchResult.DataSource = dt;
            txtcmbProduct.DataSource = dt;
            txtcmbProduct.ValueMember = "Pro_id";
            txtcmbProduct.DisplayMember = "name";
            txtcmbProduct.SelectedIndex = -1;
            //cmbProduct.ValueMember = "Pro_id";
            //cmbProduct.DisplayMember = "name";
            //cmbProduct.SelectedIndex = -1;

           gridSearchResult.Columns["Pro_id"].Visible = false;
            gridSearchResult.Columns["name"].Visible = false;
            gridSearchResult.Columns["id"].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;


          

        }
        private void LoadSProductsProId(Guid id)
        {
            DataTable dt = new DataTable();

            ProductDAL objDAL = new ProductDAL();
            dt = objDAL.LoadProdcutbyid(id);
            gridSearchResult.DataSource = dt;
            txtcmbProduct.DataSource = dt;
            txtcmbProduct.ValueMember = "Pro_id";
            txtcmbProduct.DisplayMember = "name";
            //cmbProduct.ValueMember = "Pro_id";
            //cmbProduct.DisplayMember = "name";
            //cmbProduct.SelectedIndex = -1;

            gridSearchResult.Columns["Pro_id"].Visible = false;
            gridSearchResult.Columns["name"].Visible = false;
            gridSearchResult.Columns["id"].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;
            //gridSearchResult.Columns[0].Visible = false;




        }


        //--------------------
        public POS_SALE_SCREEN()
        {
            InitializeComponent();
        
            LoadCbxPayment();
            LoadCmbProducts();
            LoadCmbTax();
            LoadCmbProduct();
             loadCustomer();
            Load_Grid_Columns();
            addRow_PurchasesGrid();
            GenerateID_Invoice();
            GenerateID_Order();
            clearAll();
            cbx_Status.Enabled = true;

            //Advance Search
            loadSCategory();
             
        }
        private void loadCustomer()
        {
            UserDAL objDAL = new UserDAL();
            cbx_Customer.DataSource = objDAL.LoadAll();
            cbx_Customer.ValueMember = "user_id";
            cbx_Customer.DisplayMember = "user_name";
            cbx_Customer.SelectedIndex = 2;

        }
        private void LoadCmbTax()
        {
            TaxDAL objDAL = new TaxDAL();
            cbx_Tax.DataSource = objDAL.LoadAll();
            cbx_Tax.ValueMember = "TaxID";
            cbx_Tax.DisplayMember = "Tax";
            cbx_Tax.SelectedValue = Guid.Parse("1E015D8C-0ECD-4DAA-83DB-0C258669C1BD");
            //   cbx_Tax.SelectedIndex = 1;
        }
        private void LoadCmbProduct()
        {
            ProductDAL objDAL = new ProductDAL();
        //    cmbProductGrid.DataSource = objDAL.LoadProductNameWithCategory();
        //    cmbProductGrid.ValueMember = "id";
        //    cmbProductGrid.DisplayMember = "Title";
        //    cmbProductGrid.SelectedIndex = -1;
        //
        }
        private void LoadCmbProducts()
        {
            ProductDAL objDAL = new ProductDAL();
            cmbProduct.DataSource = objDAL.LoadProductNameWithCategory();
            cmbProduct.ValueMember = "id";
            cmbProduct.DisplayMember = "Title";
            cmbProduct.SelectedIndex = -1;
        }
        private void LoadCbxPayment()
        {
            Payment_typeDAL objDAL = new Payment_typeDAL();
            cbx_Payment.DataSource = objDAL.LoadAll();
            cbx_Payment.ValueMember = "Payment_id";
            cbx_Payment.DisplayMember = "Payment_type";
            cbx_Payment.SelectedIndex = 0;
        }

        private void POS_SALE_SCREEN_Load(object sender, EventArgs e)
        {
            loadSBrand();
            cbx_Status.Items.Add("Paid and Sold");
            cbx_Status.SelectedIndex = 0;
            cbx_Customer.SelectedIndex = 0;
            cbx_Payment.SelectedIndex = 0;



            GenerateID_Invoice();
            GenerateID_Order();

            Purchase_OrderDAL orderDAL = new Purchase_OrderDAL();
            orderDAL.LoadAll();

            Purchase_Order_DetailDAL detailDAL = new Purchase_Order_DetailDAL();
            detailDAL.LoadAll();
            
        }
        private void clearAll()
        {
 
            // lblError_ProductCategory.Text = "!";
            //lblError_Product.Text = "!";
           
            cbx_Customer.SelectedValue = 2;
 
            //   cbx_Tax.SelectedValue = -1;
            cbx_Status.SelectedValue = 0;
            cbx_Payment.SelectedValue = 0;
            txt_Invoice.Text = "";
            txt_Order.Text = "";
       
            txt_VendorCost.Text = "0";
            txt_Discount.Text = "";
            lblDiscount.Text = "0.00";
            lblRemaining.Text = "0.00";
            lblSubTotal.Text = "0.00";

            lblTotal.Text = "0.00";
            lbl_TaxAmount.Text = "0.00";
            gridSales.Rows.Clear();
             
            addRow_PurchasesGrid();
            txtDiscountAmount.Text = "0";
            txtCashierDiscount.Text = "";
             cbx_Payment.SelectedIndex = 1;
            txtCashierDiscount.Text = "0";
          //  txt_PaidAmount.Text = "0";
            txtDiscountAmount.Text = "0";
            txt_Discount.Text = "0";
            //cbx_Status.SelectedIndex = 0;
            cbx_Customer.SelectedIndex = 0;
            cbx_Payment.SelectedIndex = 0;
            txtBarcode.Text = "";
            txtSBarcode.Text = "";
            txtSfourmula.Text = "";
            txtSprice.Text = "";
            txt_Discount.Text = "";
            cmbSBrand.SelectedIndex = -1;
            cmbSCategory.SelectedIndex = -1;
            gridSearchResult.DataSource = null;
            Sale_order_id = Guid.Empty;
            Sale_order_detail_id = Guid.Empty;



        }

        private void cbx_Customer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cbx_Customer.SelectedValue.ToString(), out Customer_id);

        }

        private void cbx_Payment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            payment_type = cbx_Payment.SelectedValue.ToString();

        }

        private void cbx_Tax_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Calculate_SubTotal();

            tax_id = Guid.Parse(cbx_Tax.SelectedValue.ToString());

            Purchase_OrderDAL obj = new Purchase_OrderDAL();
            Tax = obj.Tax(tax_id);
            double t = 0;
            double.TryParse(Tax, out t);
            Double.TryParse(lblSubTotal.Text, out temp);
            double ans = temp * (t / 100);
            lbl_TaxAmount.Text = ans.ToString();

            DiscountCalculate();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

     
       

        public void Sub_Total()
        {
            // if (gridSales.Rows.Count > 0)

            double quantity = 0, unit_price = 0, discount = 0;
            for (int i = 0; i < gridSales.Rows.Count; i++)
            {
                try
                {
                    quantity = Convert.ToDouble(gridSales.Rows[i].Cells["Quantity"].Value.ToString());
                    unit_price = Convert.ToDouble(gridSales.Rows[i].Cells["UnitPrice"].Value.ToString());
                    //  discount = Convert.ToDouble(gridSales.Rows[i].Cells["Discount"].Value.ToString());


                    gridSales.Rows[i].Cells["PriceWithoutDiscount"].Value = quantity * unit_price;
                    gridSales.Rows[i].Cells["SubTotal"].Value = gridSales.Rows[i].Cells["PriceWithoutDiscount"].Value;




                }
                catch (Exception)
                {
                    gridSales.Rows[i].Cells["SubTotal"].Value = 0;

                }
            }


        }
        public void Calculate_Tax()
        {
            Double atax = 0, Tax = 0;
            TaxDAL objTDAL = new TaxDAL();


            for (int i = 0; i < gridSales.Rows.Count; i++)

            {
                Guid TaxID;


                try
                {
                    atax = Convert.ToDouble(gridSales.Rows[i].Cells["PriceWithDiscount"].Value.ToString());


                    Guid.TryParse(gridSales.Rows[i].Cells["cmb_Tax"].Value.ToString(), out TaxID);

                    try
                    {
                        // gridSales.Rows[i].Cells["cmb_Tax"].Value = TaxID;

                        DataTable dt = objTDAL.LoadByID(TaxID);

                        Double.TryParse(dt.Rows[0]["TaxPercen"].ToString(), out Tax);
                        // Tax = Double.Parse(value.ToString());

                    }

                    catch { }


                    atax += atax * (Tax / 100);
                    Math.Round(atax);
                    gridSales.Rows[i].Cells["PriceWithTax"].Value = atax;
                    gridSales.Rows[i].Cells["SubTotal"].Value = gridSales.Rows[i].Cells["PriceWithTax"].Value;

                    sub_total = Convert.ToDouble(gridSales.Rows[i].Cells["SubTotal"].Value.ToString());

                }
                catch (Exception)
                {
                    gridSales.Rows[i].Cells["SubTotal"].Value = 0;

                }
            }
        }
 
        public void Calculate_SubTotal()
        {
            try
            {
                Stotal = 0;
                for (int i = 0; i < gridSales.Rows.Count; i++)
                {

                    Stotal += Convert.ToDouble(gridSales.Rows[i].Cells["SubTotal"].Value.ToString());
                    Math.Abs(Stotal);
                }
                lblSubTotal.Text = Stotal.ToString();
            }
            catch { }
        }
        public void Calculate_Discount()
        {
            // if (gridSales.Rows.Count > 0)

            double temp = 0, unit_price = 0, discount = 0;
            for (int i = 0; i < gridSales.Rows.Count; i++)
            {
                try
                {
                    temp = Convert.ToDouble(gridSales.Rows[i].Cells["PriceWithoutDiscount"].Value.ToString());
                    discount = Convert.ToDouble(gridSales.Rows[i].Cells["DiscountPercentage"].Value.ToString());
                    double Stotal = temp - (temp * discount / 100);
                    Math.Round(Stotal);
                    gridSales.Rows[i].Cells["DiscountAmount"].Value = (temp * discount / 100);

                    gridSales.Rows[i].Cells["PriceWithDiscount"].Value = Stotal;
                    gridSales.Rows[i].Cells["SubTotal"].Value = gridSales.Rows[i].Cells["PriceWithDiscount"].Value;



                }
                catch (Exception)
                {
                    gridSales.Rows[i].Cells["SubTotal"].Value = 0;

                }
            }


        }


        private void Calculate_Discount_Amount()
        {
            // if (gridSales.Rows.Count > 0)

            double temp = 0, unit_price = 0, discount = 0;
            for (int i = 0; i < gridSales.Rows.Count; i++)
            {
                try
                {
                    temp = Convert.ToDouble(gridSales.Rows[i].Cells["PriceWithoutDiscount"].Value.ToString());

                    discount = Convert.ToDouble(gridSales.Rows[i].Cells["DiscountAmount"].Value.ToString());
                    if (discount != 0)
                    {
                        double Stotal = temp - discount;
                        Math.Round(Stotal);
                        gridSales.Rows[i].Cells["PriceWithDiscount"].Value = Stotal;
                        gridSales.Rows[i].Cells["SubTotal"].Value = gridSales.Rows[i].Cells["PriceWithDiscount"].Value;

                    }

                }
                catch (Exception)
                {
                    gridSales.Rows[i].Cells["SubTotal"].Value = 0;

                }
            }
        }
        private void GenerateID_Invoice()
        {
            if (txt_Invoice.Text.Length == 0)
            {
                SqlDataReader dr;
                con.Open();
                cmd = new SqlCommand("Select Max(Invoice_no) from Sales_Order Where  Organization_id = '" +  organization_id + "'" +
                    "  and branch_id  = '" +  branch_id + "'", con);
                dr = cmd.ExecuteReader();
                string newId = "";
                if (dr.HasRows)
                {
                    try
                    {
                        while (dr.Read())
                        {
                            string id = "00000";
                            id = (dr[0]).ToString();

                            string[] multiArray = id.Split(new Char[] { 'I', 'O', '-' });
                            string Mid = null;
                            foreach (string mid in multiArray)
                            {
                                if (mid.Trim() != "")
                                {
                                    Mid = mid;
                                }
                            }

                            int sequenceNumber = int.Parse(Mid);

                            sequenceNumber++;
                            newId = string.Format("{0}", sequenceNumber.ToString().PadLeft(5, '0'));
                        }
                    }
                    catch { }
                }
                else
                {
                    txt_Invoice.Text = "IO-00001";
                }
                if (string.IsNullOrEmpty(txt_Invoice.Text))
                {
                    if (string.IsNullOrWhiteSpace(newId.ToString()))
                    {
                        txt_Invoice.Text = "IO-00001" + newId.ToString();
                    }
                    else
                        txt_Invoice.Text = "IO-" + newId.ToString();
                }
                con.Close();
            }
        }

        private void GenerateID_Order()
        {
            if (txt_Order.Text.Length == 0)
            {
                SqlDataReader dr;
                con.Open();
                cmd = new SqlCommand("Select Max(Order_no) from Sales_Order  Where  Organization_id = '" + organization_id + "'" +
                    "  and branch_id  = '" +  branch_id+ "'", con);
                dr = cmd.ExecuteReader();
                string newId = "";
                if (dr.HasRows)
                {
                    try
                    {

                        while (dr.Read())
                        {
                            string id = "00000";
                            id = (dr[0]).ToString();
                            string[] multiArray = id.Split(new Char[] { 'P', 'O', '-' });
                            string Mid = null;
                            foreach (string mid in multiArray)
                            {
                                if (mid.Trim() != "")
                                {
                                    Mid = mid;
                                }
                            }

                            int sequenceNumber = int.Parse(Mid);
                            sequenceNumber++;
                            newId = string.Format("{0}", sequenceNumber.ToString().PadLeft(5, '0'));
                        }
                    }
                    catch { }
                }
                else
                {
                    txt_Order.Text = "PO-00001";
                }
                if (string.IsNullOrEmpty(txt_Order.Text))
                {
                    if (string.IsNullOrWhiteSpace(newId.ToString()))
                    {
                        txt_Order.Text = "PO-00001" + newId.ToString();
                    }
                    else
                        txt_Order.Text = "PO-" + newId.ToString();

                }

                con.Close();
            }
        }

        private void DiscountCalculate()
        {
            try
            {
                lblTotal.Text = tempp.ToString();
                double disc = 0;
                Double.TryParse(txt_Discount.Text, out disc);
                double temp = 0;
                Double.TryParse(lblTotal.Text, out temp);




                lblDiscount.Text = txt_Discount.Text + " %";
                double percentage = temp * disc / 100;
                double Stotal = temp - (temp * disc / 100);
                txtDiscountAmount.Text = percentage.ToString();
                double tax = 0;
                Double.TryParse(lbl_TaxAmount.Text, out tax);

                Stotal += tax;
                Math.Abs(Stotal);

                lblTotal.Text = Stotal.ToString();
                lblRemaining.Text = Stotal.ToString();
                //tempp = temp;
            }
            catch { }

        }


        private void DiscountAmountCalculate()
        {
            try
            {
                //lblTotal.Text = tempp.ToString();
                double disc = 0;
                double percentage = 0;
                double.TryParse(txtDiscountAmount.Text, out disc);
                double temp = 0;
                Double.TryParse(lblTotal.Text, out temp);
                if (disc > 0)
                {
                    percentage = (disc / temp) * 100;
                    percentage = Math.Round(percentage);
                    txt_Discount.Text = percentage.ToString();
                    lblDiscount.Text = percentage.ToString();

                }
                double Stotal = temp - disc;



                Math.Abs(Stotal);

                lblTotal.Text = Stotal.ToString();
               // lblRemaining.Text = Stotal.ToString();

                temp = tempp;
            }
            catch { }


        }

        private void CashierDiscountAmountCalculate()
        {
            Calculate_SubTotal();

            VendorText();
            PaidAmount();
            VendorText();
            DiscountCalculate();
            DiscountAmountCalculate();

            try
            {
                //lblTotal.Text = tempp.ToString();
                double disc = 0;
                double percentage = 0;
                double.TryParse(txtCashierDiscount.Text, out disc);
                double temp = 0;
                Double.TryParse(lblTotal.Text, out temp);

                double Stotal = temp - disc;



                Math.Abs(Stotal);

                lblTotal.Text = Stotal.ToString();
              //  lblRemaining.Text = Stotal.ToString();

            }
            catch { }


        }
        private void PaidAmount()
        {
            try
            {
                Double Paid = 0, total = 0;
                Double.TryParse(txtCashierDiscount.Text, out Paid);
                if (Paid > 0)
                {
                    total = Double.Parse(lblTotal.Text) - Paid;

                    double ans = Math.Truncate(total);
                    lblRemaining.Text = ans.ToString();
                    lblChnageReturned.Text = Math.Abs(float.Parse(ans.ToString())).ToString();
                }
            }
            catch { }
        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Discount.Text))
            {
                txt_Discount.Text = "0";
                 
            }

            try
            {
                float p = float.Parse(txt_Discount.Text);
                if (p >= 0 && p <= 100)
                    DiscountCalculate();
                //else
                //    lblDiscountPercentage.Text = ("Percentage must betwen 0-100");
            }
            catch { }
        }
        private void VendorText()
        {
            try
            {

                DiscountCalculate();
                DiscountAmountCalculate();

                double temp = 0; Double.TryParse(lblSubTotal.Text, out temp);
                double venderCost = 0; Double.TryParse(txt_VendorCost.Text, out venderCost);
                temp += Math.Truncate(venderCost);
                lblTotal.Text = temp.ToString();
                tempp = temp;
            }
            catch { }
        }

        private void txt_VendorCost_TextChanged(object sender, EventArgs e)
        {
            VendorText();
        }

       
        

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Guid id;
                Guid.TryParse(cmbProduct.SelectedValue.ToString(), out id);
                loadGrid_by_ProductID(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCashierDiscount_TextChanged(object sender, EventArgs e)
        {
            PaidAmount();

        }

      
        private void cmbSCategory_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Guid id;
            Guid.TryParse(cmbSCategory.SelectedValue.ToString(), out id);
            LoadSProducts(id);
        }

        private void cmbSBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value;
            value  = cmbSBrand.SelectedValue.ToString();
            LoadSGridBrand(value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value;
            value = txtcmbProduct.Text;
            LoadSGridProduct_name_(value);
        }

        private void txtSfourmula_TabIndexChanged(object sender, EventArgs e)
        {
            string value;
            value = txtSfourmula.Text;
            LoadSGridFourmula(value);
        }

        private void txtSprice_TextChanged(object sender, EventArgs e)
        {
            string value;
            value = txtSprice.Text;
            LoadSGridPrice(value);
        }

        private void txtBarcode_TextChanged_1(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            int barcode = 0;
            BarcodeBAL obj = new BarcodeBAL();
            BarcodeDAL objDal = new BarcodeDAL();
            BarcodeGenerateBAL objBAL = new BarcodeGenerateBAL();
            BarcodeGenerateDAL objGDAL = new BarcodeGenerateDAL();
            obj.ActualCode = txtBarcode.Text;
            int.TryParse(txtBarcode.Text, out barcode);
            objBAL.UPC_Barcode = barcode;
            dt = objDal.FindProductByBarcode(obj);
            dt1 = objGDAL.FindProductByBarcodeGenerate(objBAL);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    for (int x = 0; x < gridSales.Rows.Count; x++)
                    {

                        Product_CategoryDAL objDAL = new Product_CategoryDAL();
                        cmb_ProductCategory.DataSource = objDAL.LoadAll();
                        cmb_ProductCategory.DisplayMember = "name";
                        cmb_ProductCategory.ValueMember = "id";
                        var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
                        if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
                        {
                            var ProductCategory = dt.Rows[0]["productCategory_id"];
                            gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


                            var Product = dt.Rows[0]["Product_id"];
                            gridSales.Rows[x].Cells["cmb_Product"].Value = Product;
                            txtBarcode.Clear();
                        }
                    }
                }
                else if (dt1.Rows.Count > 0)
                {
                    for (int x = 0; x < gridSales.Rows.Count; x++)
                    {

                        Product_CategoryDAL objDAL = new Product_CategoryDAL();
                        cmb_ProductCategory.DataSource = objDAL.LoadAll();
                        cmb_ProductCategory.DisplayMember = "name";
                        cmb_ProductCategory.ValueMember = "id";
                        var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
                        if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
                        {
                            var ProductCategory = dt1.Rows[0]["Cat_id"];
                            gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


                            var Product = dt1.Rows[0]["Pro_id"];
                            gridSales.Rows[x].Cells["cmb_Product"].Value = Product;

                            var Quantity = dt1.Rows[0]["Quantity"];
                            gridSales.Rows[x].Cells["Quantity"].Value = Quantity;

                            var Subtotal = dt1.Rows[0]["Price"];
                            gridSales.Rows[x].Cells["SubTotal"].Value = SubTotal;

                            txtBarcode.Clear();
                        }
                    }
                }
            }
            catch (Exception ee) { MessageBox.Show(e.ToString()); }
            // myList 
        }

        private void txtSBarcode_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            int barcode = 0;
            BarcodeBAL obj = new BarcodeBAL();
            BarcodeDAL objDal = new BarcodeDAL();
            BarcodeGenerateBAL objBAL = new BarcodeGenerateBAL();
            BarcodeGenerateDAL objGDAL = new BarcodeGenerateDAL();
            obj.ActualCode = txtSBarcode.Text;
            int.TryParse(txtBarcode.Text, out barcode);
            objBAL.UPC_Barcode = barcode;
            dt = objDal.FindProductByBarcode(obj);
           dt1 = objGDAL.FindProductByBarcodeGenerate(objBAL);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    for (int x = 0; x < gridSales.Rows.Count; x++)
                    {

                        Product_CategoryDAL objDAL = new Product_CategoryDAL();
                        cmb_ProductCategory.DataSource = objDAL.LoadAll();
                        cmb_ProductCategory.DisplayMember = "name";
                        cmb_ProductCategory.ValueMember = "id";
                        var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
                        if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
                        {
                            var ProductCategory = dt.Rows[0]["productCategory_id"];
                            gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


                            var Product = dt.Rows[0]["Product_id"];
                            gridSales.Rows[x].Cells["cmb_Product"].Value = Product;
                            txtBarcode.Clear();
                        }
                    }
                }
                else if (dt1.Rows.Count > 0)
                {
                    for (int x = 0; x < gridSales.Rows.Count; x++)
                    {

                        Product_CategoryDAL objDAL = new Product_CategoryDAL();
                        cmb_ProductCategory.DataSource = objDAL.LoadAll();
                        cmb_ProductCategory.DisplayMember = "name";
                        cmb_ProductCategory.ValueMember = "id";
                        var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
                        if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
                        {
                            var ProductCategory = dt1.Rows[0]["Cat_id"];
                            gridSearchResult.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


                            var Product = dt1.Rows[0]["Pro_id"];
                            gridSales.Rows[x].Cells["cmb_Product"].Value = Product;

                            var Quantity = dt1.Rows[0]["Quantity"];
                            gridSales.Rows[x].Cells["Quantity"].Value = Quantity;

                            var Subtotal = dt1.Rows[0]["Price"];
                            gridSales.Rows[x].Cells["SubTotal"].Value = SubTotal;

                            txtBarcode.Clear();
                        }
                    }
                }
            }
            catch (Exception ee) { MessageBox.Show(e.ToString()); }
            // myList 
        }

        private void gridSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            Guid Product_id;
            if (rowindex >= 0)
            {
                Product_id = Guid.Parse(gridSearchResult.Rows[rowindex].Cells["id"].Value.ToString());
                try
                {
                     
                    loadGrid_by_ProductID(Product_id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txt_Discount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Discount.Text))
            {
                txt_Discount.Text = "0";
                lblDiscountPercentage.Text = "*";
            }

            try
            {
                float p = 0;
                float.TryParse(txt_Discount.Text, out p);
                if (p >= 0 && p <= 100)
                {
                    DiscountCalculate();
                    lblDiscountPercentage.Text = "*";

                }
                else
                    lblDiscountPercentage.Text = ("Percentage must betwen 0-100");
            }
            catch { }
        }

        private void txtDiscountAmount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountAmount.Text))
            {
                txtDiscountAmount.Text = "0";
                lblDiscountAmount.Text = "*";

            }
            float temp = 0;
            float.TryParse(txtDiscountAmount.Text, out temp);
            try
            {
                float p = 0;
                float.TryParse(lblTotal.Text, out p);
                if (temp <= p)
                    DiscountAmountCalculate();

                else
                    lblDiscountAmount.Text = ("Amount Should be less than Total Amount");


            }
            catch { }
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            lblCash.Text = lblTotal.Text;
        }

        private void cmbSCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid id;
            Guid.TryParse(cmbSCategory.SelectedValue.ToString(), out id);
            LoadSProducts(id);
        }

  
        private void cmbSBrand_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            string value;
            value = cmbSBrand.SelectedValue.ToString();
            LoadSGridBrand(value);
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            string value;
            value = txtcmbProduct.Text;
            LoadSGridProduct_name_(value);
        }

        private void txtSBarcode_TextChanged_1(object sender, EventArgs e)
        {

            if (txtSBarcode.Text.Length == 5)
            {
                //wait for 10 chars and then set the timer
                timer = new System.Timers.Timer(2000); //adjust time based on time required to enter the last 3 chars 
                timer.Elapsed += OnTimedEvent;
                timer.Enabled = true;
            }

            //DataTable dt = new DataTable();
            //DataTable dt1 = new DataTable();
            //int barcode = 0;
            //BarcodeBAL obj = new BarcodeBAL();
            //BarcodeDAL objDal = new BarcodeDAL();
            //BarcodeGenerateBAL objBAL = new BarcodeGenerateBAL();
            //BarcodeGenerateDAL objGDAL = new BarcodeGenerateDAL();
            //obj.ActualCode = txtBarcode.Text;
            //int.TryParse(txtBarcode.Text, out barcode);
            //objBAL.UPC_Barcode = barcode;
            //dt = objDal.FindProductByBarcode(obj);
            //dt1 = objGDAL.FindProductByBarcodeGenerate(objBAL);

            //try
            //{
            //    if (dt.Rows.Count > 0)
            //    {
            //        for (int x = 0; x < gridSales.Rows.Count; x++)
            //        {

            //            Product_CategoryDAL objDAL = new Product_CategoryDAL();
            //            cmb_ProductCategory.DataSource = objDAL.LoadAll();
            //            cmb_ProductCategory.DisplayMember = "name";
            //            cmb_ProductCategory.ValueMember = "id";
            //            var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
            //            if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
            //            {
            //                var ProductCategory = dt.Rows[0]["productCategory_id"];
            //                gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


            //                var Product = dt.Rows[0]["Product_id"];
            //                gridSales.Rows[x].Cells["cmb_Product"].Value = Product;
            //                txtBarcode.Clear();
            //            }
            //        }
            //    }
            //    else if (dt1.Rows.Count > 0)
            //    {
            //        for (int x = 0; x < gridSales.Rows.Count; x++)
            //        {

            //            Product_CategoryDAL objDAL = new Product_CategoryDAL();
            //            cmb_ProductCategory.DataSource = objDAL.LoadAll();
            //            cmb_ProductCategory.DisplayMember = "name";
            //            cmb_ProductCategory.ValueMember = "id";
            //            var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
            //            if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
            //            {
            //                var ProductCategory = dt1.Rows[0]["Cat_id"];
            //                gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


            //                var Product = dt1.Rows[0]["Pro_id"];
            //                gridSales.Rows[x].Cells["cmb_Product"].Value = Product;

            //                var Quantity = dt1.Rows[0]["Quantity"];
            //                gridSales.Rows[x].Cells["Quantity"].Value = Quantity;

            //                var Subtotal = dt1.Rows[0]["Price"];
            //                gridSales.Rows[x].Cells["SubTotal"].Value = SubTotal;

            //                txtBarcode.Clear();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ee) { MessageBox.Show(e.ToString()); }
            // myList 
        }

        private void gridSearchResult_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            Guid Product_id;
            if (rowindex >= 0)
            {
                Product_id = Guid.Parse(gridSearchResult.Rows[rowindex].Cells["id"].Value.ToString());
                try
                {

                    loadGrid_by_ProductID(Product_id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtBarcode_TextChanged_2(object sender, EventArgs e)
        {
           

            if (txtBarcode.Text.Length >= 11)
            {
                //wait for 10 chars and then set the timer
                timer = new System.Timers.Timer(1000); //adjust time based on time required to enter the last 3 chars 
                timer.Elapsed += OnTimedEvent;
                timer.Enabled = true;
            
            }
       
            //DataTable dt = new DataTable();
            //DataTable dt1 = new DataTable();
            //int barcode = 0;
            //BarcodeBAL obj = new BarcodeBAL();
            //BarcodeDAL objDal = new BarcodeDAL();
            //BarcodeGenerateBAL objBAL = new BarcodeGenerateBAL();
            //BarcodeGenerateDAL objGDAL = new BarcodeGenerateDAL();
            //obj.ActualCode = txtBarcode.Text;
            //int.TryParse(txtBarcode.Text, out barcode);
            //objBAL.UPC_Barcode = barcode;
            // dt = objDal.FindProductByBarcode(obj);
            //dt1 = objGDAL.FindProductByBarcodeGenerate(objBAL);

            //try
            //{
            //    if (dt.Rows.Count > 0)
            //    {
            //        for (int x = 0; x < gridSales.Rows.Count; x++)
            //        {

            //            Product_CategoryDAL objDAL = new Product_CategoryDAL();
            //            cmb_ProductCategory.DataSource = objDAL.LoadAll();
            //            cmb_ProductCategory.DisplayMember = "name";
            //            cmb_ProductCategory.ValueMember = "id";
            //            var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
            //            if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
            //            {
            //                var ProductCategory = dt.Rows[0]["productCategory_id"];
            //                gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


            //                var Product = dt.Rows[0]["Product_id"];
            //                gridSales.Rows[x].Cells["cmb_Product"].Value = Product;
            //                txtBarcode.Clear();
            //            }
            //        }
            //    }
            //    else if (dt1.Rows.Count > 0)
            //    {
            //        for (int x = 0; x < gridSales.Rows.Count; x++)
            //        {

            //            Product_CategoryDAL objDAL = new Product_CategoryDAL();
            //            cmb_ProductCategory.DataSource = objDAL.LoadAll();
            //            cmb_ProductCategory.DisplayMember = "name";
            //            cmb_ProductCategory.ValueMember = "id";
            //            var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
            //            if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
            //            {
            //                var ProductCategory = dt1.Rows[0]["Cat_id"];
            //                gridSearchResult.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


            //                var Product = dt1.Rows[0]["Pro_id"];
            //                gridSales.Rows[x].Cells["cmb_Product"].Value = Product;

            //                var Quantity = dt1.Rows[0]["Quantity"];
            //                gridSales.Rows[x].Cells["Quantity"].Value = Quantity;

            //                var Subtotal = dt1.Rows[0]["Price"];
            //                gridSales.Rows[x].Cells["SubTotal"].Value = SubTotal;

            //                txtBarcode.Clear();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ee) { MessageBox.Show(e.ToString()); }
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            timer.Enabled = false;

            if (txtBarcode.Text.Length >=11 || txtSBarcode.Text.Length >= 11)
            {
                //FindBarcode_Own();
                FindBarcode();
           

            }
            //else if (txtBarcode.Text.Length == 12|| txtSBarcode.Text.Length == 12)
            //{
            //    FindBarcode();
            //    FindBarcode_Own();

            //}

        }


        private void txtSfourmula_TextChanged(object sender, EventArgs e)
        {
            string value;
            value = txtSfourmula.Text;
            LoadSGridFourmula(value);
        }

        private void txtSprice_TextChanged_1(object sender, EventArgs e)
        {
            string value;
            value = txtSprice.Text;
            LoadSGridPrice(value);
        }

        private void cmbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Guid id;
                Guid.TryParse(cmbProduct.SelectedValue.ToString(), out id);
                loadGrid_by_ProductID(id);
            }
            catch { }
        }

        private void gridSales_CellClick_1(object sender, GridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {
                addRow_PurchasesGrid();
            }
            if (e.ColumnIndex == 14)
            {
                if (gridSales.Rows.Count > 1)
                    this.gridSales.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void gridSales_CellEditorInitialized_1(object sender, GridViewCellEventArgs e)
        {
            Product_Variant_Id = Guid.Empty;
            //fullList = new BindingList<ForBinding>();
            DataTable dt = new DataTable();
            DataTable dttt = new DataTable();
            Guid ValueVariant = Guid.Empty;
            object ob = new object();

            PricingDAL objd = new PricingDAL();
            ProductDAL obj = new ProductDAL();
            VariantTypeDAL objVTD = new VariantTypeDAL();
            Product_Variant_Id = Guid.Empty;
            //fullList = new BindingList<ForBinding>();
         

            int i = 0;
            i = Convert.ToInt32(e.RowIndex);


            try
            {
                Guid.TryParse(e.Row.Cells["cmb_ProductCategory"].Value.ToString(), out value);

                Product_Category_id = value;
                Guid.TryParse(e.Row.Cells["cmb_Product"].Value.ToString(), out Product_Id);
                ProductVariantDAL objD = new ProductVariantDAL();
                DataTable dts = new DataTable();
                dts = objD.LoadProductVariants_By_Product_Id(Product_Id);
                var xL = dts.Rows[0]["Variants"].ToString();

                for (int x = 0; x < dts.Rows.Count; x++)
                {
                    Product_Variant_Id = Guid.Parse(dts.Rows[x]["Product_Variant_Id"].ToString());
                    if (e.Column.HeaderText == "Variant")
                    {
                        //   DataTable dts = new DataTable();


                        if (this.gridSales.CurrentRow.Cells["cmb_Product"].Value != DBNull.Value
                            && this.gridSales.CurrentRow.Cells["cmb_Product"].Value != null)
                        {
                            RadDropDownListEditor editor = (RadDropDownListEditor)this.gridSales.ActiveEditor;
                            RadDropDownListEditorElement editorElement = (RadDropDownListEditorElement)editor.EditorElement;

                            editorElement.DataSource = Utility.GetVariantByDataTable(dts);


                            editorElement.SelectedValue = this.gridSales.CurrentCell.Value;

                        }


                    }
                }

            }
            catch { }


            try
            {
                Guid.TryParse(e.Row.Cells["cmb_ProductCategory"].Value.ToString(), out value);

                Product_Category_id = value;
                Guid.TryParse(e.Row.Cells["cmb_Product"].Value.ToString(), out Product_Id);
                ProductVariantDAL objD = new ProductVariantDAL();
                DataTable dts = new DataTable();
                dts = objD.GetProductVariantId_byProductId(Product_Id);
                Product_Variant_Id = Guid.Parse(dts.Rows[0]["Product_Variant_Id"].ToString());
            }
            catch { }
          
            i = Convert.ToInt32(e.RowIndex);

            if (e.Column.HeaderText == "Product") 
            {
                if (this.gridSales.CurrentRow.Cells["cmb_ProductCategory"].Value != DBNull.Value
                    && this.gridSales.CurrentRow.Cells["cmb_ProductCategory"].Value != null)
                {
                    RadDropDownListEditor editor = (RadDropDownListEditor)this.gridSales.ActiveEditor;
                    RadDropDownListEditorElement editorElement = (RadDropDownListEditorElement)editor.EditorElement;
                    dt = obj.LoadProdcutbyCategory(value);
                    //fullList = Utility.GetListByDataTable(dt);
                    editorElement.DataSource = Utility.GetListByDataTable(dt);

                    // editorElement.SelectedValue = null;
                    editorElement.SelectedValue = this.gridSales.CurrentCell.Value;
                }
            }


             

            if (e.Column.HeaderText == "Qty" || e.Column.HeaderText == "Disc_%")
            {

                DataTable dtt = new DataTable();
                DataTable dt2 = new DataTable();
                PricingBAL objb = new PricingBAL();
                PricingDAL objdd = new PricingDAL();
                dtt.Clear();
                try
                {
                    StockDAL objj = new StockDAL();
                    Guid.TryParse(gridSales.Rows[i].Cells["cmb_Product"].Value.ToString(), out Pro_id);
                    Guid Cat_id = Guid.Empty;
                    Guid.TryParse(gridSales.Rows[i].Cells["cmb_ProductCategory"].Value.ToString(), out Cat_id);

                    dtt = objj.FindQuantity(Pro_id, Cat_id);
                    dt2 = objd.FindPrice_Pricing(Pro_id, Cat_id);




                    //      //pricing
                    //      objb.Pricing_id = Guid.Parse(dt2.Rows[0]["PriceID"].ToString());
                    //      objb.ProID = Pro_id;
                    //      objb.CatID = Cat_id;
                    ////      objb.Purchase_order_id = Guid.Parse(dt2.Rows[0]["Purchase_Order_id"].ToString());
                    //      objb.Date = DateTime.Now;
                    //      objb.AddBy = dt2.Rows[0]["AddBy"].ToString();
                    //      objb.AddDate = DateTime.Parse(dt2.Rows[0]["AddDate"].ToString());

                    //      //



                    if (dtt.Rows.Count != 0)
                    {//fetch quantity ffrom stock
                        var quantity = dtt.Rows[0]["Quantity"];
                        //  gridSales.Rows[i].Cells["Quantity"].Value = quantity.ToString();
                        // MessageBox.Show("Total Quantity in Stock : " + quantity);
                        //stock fetch values
                    }

                    if (dt2.Rows.Count != 0)
                    {
                        float priceD = 0;

                        var price = dt2.Rows[0]["Price"];
                        if (e.Column.HeaderText == "Qty")
                            gridSales.Rows[i].Cells["UnitPrice"].Value = price;

                        ////price from grid
                        //priceD = float.Parse(gridSales.Rows[i].Cells["UnitPrice"].Value.ToString());
                        //objb.price = float.Parse(dt2.Rows[0]["Price"].ToString());
                        ////compare grid price and datatable price
                        //if (objb.price != priceD)
                        //{

                        //    objb.Pricing_id = Guid.Parse(dt2.Rows[0]["PriceID"].ToString());
                        //    objb.status = "deactive";

                        //    objb.Flag = 0;
                        //    objb.EditBy = "Admin";
                        //    objb.EditDate = DateTime.Now;

                        //    objdd.Update(objb);

                        //    //Add new price

                        //    objb.price = priceD;
                        //    objb.Purchase_order_id = Sale_order_id;

                        //    objb.status = "Active";
                        //    objb.Flag = 1;
                        //    objdd.Add(objb);

                        //}
                    }

                }
                catch { }
            }

            Sub_Total();
            Calculate_Discount();
            Calculate_Discount_Amount();
            Calculate_Tax();

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            double res1 = Convert.ToDouble(lblTotal.Text.ToString());
            double res2 = Convert.ToDouble(txtCashierDiscount.Text.ToString());

            try
            {


                Guid id = new Guid();
                if (btnSave.LabelText == "Save")
                {
                    id = Guid.NewGuid();
                    Sale_order_id = id;
                }
                if (res2>=res1)
                {

                 
                        
                        SaleOrderBAL objBAL = new SaleOrderBAL();
                    GenerateID_Invoice();
                    GenerateID_Order();


                    objBAL.id = Sale_order_id;
                    objBAL.organization_id = organization_id;
                    objBAL.branch_id = branch_id;
                    objBAL.Customer_id = Customer_id;
                    objBAL.Order_no = txt_Order.Text;
                    objBAL.status = cbx_Status.Text;
                    objBAL.Invoice_no = txt_Invoice.Text;
                    objBAL.tax_id = tax_id;
                    objBAL.tax_amount = Convert.ToInt32(Tax);
                    objBAL.non_vendor_cost_amount = Convert.ToInt32(txt_VendorCost.Text);
                    objBAL.non_vendor_cost_percentage = Convert.ToInt32(txt_VendorCost.Text);
                    objBAL.remarks = "";

                    float t1 = 0;
                    float.TryParse(txtDiscountAmount.Text, out t1);
                    objBAL.discount_amount = t1;

                    int t2 = 0;
                    int.TryParse(txt_Discount.Text, out t2);
                    objBAL.discount_percentage = t2;
                    objBAL.payment_type = cbx_Payment.Text;

                    float t3 = 0, t4 = 0, t5 = 0, t6 = 0, t7 = 0, t8 = 0;
                    float.TryParse(lblSubTotal.Text, out t3);
                    objBAL.sub_total_amount = t3;
                    float.TryParse(lblTotal.Text, out t4);
                    objBAL.total_amount = t4;
                    float.TryParse(txtCashierDiscount.Text, out t5);
                    objBAL.paid_amount = t5;
                    float.TryParse(lblRemaining.Text, out t6);
                    objBAL.remaining_amount = t6;
                    objBAL.date = mdtPurchase.Value;
                    float.TryParse(txtCashierDiscount.Text, out t7);
                    objBAL.cashierDiscount = t7;
                    float.TryParse(lblChnageReturned.Text, out t8);
                    objBAL.changeReturned = t8;

                    Sale_OrderDAL objDAL = new Sale_OrderDAL();

                    if (Sale_order_id != id)
                    {

                        objBAL.id = Sale_order_id;
                        objBAL.edit_by = Program.User_id;
                        objBAL.edit_date = DateTime.Now;
                        objDAL.Update(objBAL);

                        btnSave.LabelText = "Save";

                        //


                    }
                    else
                    {
                        objBAL.status = "Pending";
                        objBAL.add_by = Program.User_id;
                        objBAL.add_date = DateTime.Now;
                        objBAL.flag = true;
                        objDAL.Add(objBAL);

                    }
                    //clearAll();
                    //    
                    Sale_Order_DetailDAL objt = new Sale_Order_DetailDAL();

                    DataTable dt = objt.LoadAllById(Sale_order_id);
                    for (int x = 0; x < gridSales.RowCount; x++)
                    {

                        try
                        {
                            Sale_order_detail_id = Guid.Parse(dt.Rows[x]["id"].ToString());

                        }
                        catch
                        {
                            Sale_order_detail_id = Guid.Empty;
                        }
                        Sale_Order_DetailsBAL objDetailBAL = new Sale_Order_DetailsBAL();
                        objDetailBAL.Sale_order_id = Sale_order_id;

                        Guid.TryParse(gridSales.Rows[x].Cells["cmb_ProductCategory"].Value.ToString(), out Product_Category_id);
                        objDetailBAL.product_category_id = Product_Category_id;
                        Guid Pro_id = Guid.Empty;
                        Guid.TryParse(gridSales.Rows[x].Cells["cmb_Product"].Value.ToString(), out Pro_id);
                        objDetailBAL.product_id = Pro_id;
                        objDetailBAL.status = cbx_Status.Text;
                        TotalQuantity = Convert.ToDouble(gridSales.Rows[x].Cells["Quantity"].Value.ToString());
                        objDetailBAL.quantity = TotalQuantity;
                        objDetailBAL.sale_amount = Convert.ToDouble(gridSales.Rows[x].Cells["UnitPrice"].Value.ToString());
                        // objDetailBAL.sale_amount = Convert.ToDouble(gridSales.Rows[x].Cells["saleAmount"].Value.ToString());
                        Guid.TryParse(gridSales.Rows[x].Cells["cmb_Tax"].Value.ToString(), out tax_id);
                        objDetailBAL.tax_id = tax_id;
                        objDetailBAL.tax_amount = 0;// Convert.ToDouble(gridSales.Rows[x].Cells["PriceWithTax"].Value.ToString());
                        objDetailBAL.discount_amount = Convert.ToDouble(gridSales.Rows[x].Cells["DiscountPercentage"].Value.ToString());
                        objDetailBAL.discount_percentage = Convert.ToInt32(gridSales.Rows[x].Cells["DiscountAmount"].Value.ToString());
                        objDetailBAL.date = mdtPurchase.Value;
                        objDetailBAL.Barcode = "123X";
                        objDetailBAL.Stockid = stock_id;
                        //  find Product variant id

                        try
                        {
                            ProductVariantDAL objD = new ProductVariantDAL();
                            DataTable dtsd = new DataTable();
                            dtsd = objD.GetProductVariantId_byProductId(Pro_id);
                            Product_Variant_Id = Guid.Parse(dtsd.Rows[0]["Product_Variant_Id"].ToString());
                        }
                        catch { }

                        objDetailBAL.Product_Variant_id = Product_Variant_Id;


                        try
                        {
                            string quantityType = Convert.ToString(gridSales.Rows[x].Cells["quantityType"].Value.ToString());
                            if (quantityType == null)
                            {
                                objDetailBAL.quantityType = "Packs";
                            }
                            else
                                objDetailBAL.quantityType = Convert.ToString(gridSales.Rows[x].Cells["quantityType"].Value.ToString());
                        }
                        catch
                        {
                            objDetailBAL.quantityType = "Packs";

                        }



                        Sale_Order_DetailDAL objDetailDAL = new Sale_Order_DetailDAL();

                        if (Sale_order_detail_id != Guid.Empty)
                        {
                            objDetailBAL.id = Sale_order_detail_id;
                            objDetailBAL.edit_by = Program.User_id;
                            objDetailBAL.edit_date = DateTime.Now;
                            objDetailDAL.Update(objDetailBAL);

                        }
                        else
                        {
                            objDetailBAL.add_by = Program.User_id;
                            objDetailBAL.add_date = DateTime.Now;
                            objDetailBAL.flag = true;
                            objDetailDAL.Add(objDetailBAL);


                        }
                        //if packs then convert into units
                        if (QuantityType == "Packs")
                        {
                            ProductDAL obj = new ProductDAL();
                            DataTable dtt = new DataTable();
                            dtt = obj.getQuantityInEachFromProduct(Pro_id);
                            var qie = dtt.Rows[0]["quantityineach"];
                            if (Convert.ToInt32(qie) > 0)
                            {
                                double q = Convert.ToDouble(gridSales.Rows[x].Cells["Quantity"].Value.ToString());
                                TotalQuantity = Convert.ToDouble(qie) * q;
                            }
                        }
                        else if (QuantityType == "Units")
                        {
                            TotalQuantity = Convert.ToDouble(gridSales.Rows[x].Cells["Quantity"].Value.ToString());

                        }
                        if (testStock == true)
                        {
                            if (cbx_Status.Text == "Paid and Sold" | cbx_Status.Text == "Sold but not Paid")
                            {
                                //For Manage Stock
                                StockDAL objStock = new StockDAL();
                                DataTable dtStock = new DataTable();
                                int stockQuantity = 0;
                                int gridQuantity = 0;
                                int tempQuantity = 0;
                                StockBAL obj = new StockBAL();
                                obj.Organization_id = organization_id;

                                Guid.TryParse(gridSales.Rows[x].Cells["cmb_ProductCategory"].Value.ToString(), out Product_Category_id);
                                obj.Product_Category_id = Product_Category_id;
                                Guid.TryParse(gridSales.Rows[x].Cells["cmb_Product"].Value.ToString(), out Pro_id);
                                Int32.TryParse(gridSales.Rows[x].Cells["Quantity"].Value.ToString(), out stockQuantity);

                                obj.Product_id = Pro_id;
                                obj.Branch_id = branch_id;
                                obj.POS_id = Sale_order_id;
                                obj.Order_no = txt_Order.Text;
                                obj.quantity = TotalQuantity;
                                obj.purchaseprice = Convert.ToDouble(gridSales.Rows[x].Cells["UnitPrice"].Value.ToString());
                                obj.saleprice = 0;// Convert.ToDouble(gridSales.Rows[x].Cells["saleAmount"].Value.ToString());
                                obj.barcode = stockQuantity.ToString();
                                obj.expiryDate = Convert.ToDateTime("02-02-2022");
                                obj.Addby = Program.User_id;
                                obj.AddDate = DateTime.Now;
                                obj.status = "Sales";
                                obj.SOS_id = Guid.Empty;
                                obj.SOR_id = Guid.Empty;
                                obj.POR_id = Guid.Empty;
                                obj.Prescription_Medicine_id = Guid.Empty;
                                obj.Product_Variant_id = Product_Variant_Id;

                                obj.Source = Sources.PurchaseOrderDetail.ToString();
                                obj.Type = "-";
                                obj.Flag = 1;
                                if (cbx_Status.Text == "Paid and Sold" | cbx_Status.Text == "Sold but not Paid")
                                {
                                    StockDAL objD = new StockDAL();
                                    objD.Add(obj);
                                }
                                //Int32.TryParse(objDetailBAL.quantity.ToString(), out gridQuantity);
                                //if (gridQuantity > 0)
                                //{
                                //    dtStock = objStock.GetStockOnProductId(Pro_id);
                                //    for (int y = 0; y < dtStock.Rows.Count; y++)
                                //    {
                                //        Guid.TryParse(dtStock.Rows[y]["id"].ToString(), out stock_id);
                                //        Guid.TryParse(dtStock.Rows[y]["Product_id"].ToString(), out Pro_id);
                                //        Int32.TryParse(dtStock.Rows[y]["Quantity"].ToString(), out stockQuantity);

                                //        try
                                //        {
                                //            do
                                //            {
                                //                if (gridQuantity < stockQuantity)
                                //                {
                                //                    tempQuantity = gridQuantity;
                                //                    objStock.MinusQuantityInStock(stock_id, Pro_id, tempQuantity);
                                //                }
                                //                else if (stockQuantity < gridQuantity)
                                //                {
                                //                    tempQuantity = gridQuantity - stockQuantity;
                                //                    objStock.MinusQuantityInStock(stock_id, Pro_id, tempQuantity);

                                //                }
                                //                else if (stockQuantity == gridQuantity)
                                //                {
                                //                    tempQuantity = stockQuantity;
                                //                    objStock.MinusQuantityInStock(stock_id, Pro_id, tempQuantity);

                                //                }
                                //                gridQuantity -= tempQuantity;
                                //            } while (gridQuantity != 0);

                                //        }
                                //        catch (Exception e1)
                                //        {
                                //            MessageBox.Show(e1.ToString());
                                //        }



                                //    }
                                // }

                            }
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            MessageBox.Show("Sale Order Saved Successfully");

            //  clearAll();


        }

      
        private void gridSales_CellEndEdit_1(object sender, GridViewCellEventArgs e)
        {

            try
            {

                Guid.TryParse(e.Row.Cells["cmb_Tax"].Value.ToString(), out tax_id);
            }
            catch { }



            DataTable dt3 = new DataTable();

            try
            {
                StockDAL obj = new StockDAL();
                Guid.TryParse(e.Row.Cells["cmb_Product"].Value.ToString(), out Pro_id);
                dt3 = obj.CheckQuantityInStock(Pro_id);

                if (e.Column.HeaderText == "Qty")
                {
                    //Check Quantity
                    int TempQuantity = Int32.Parse(dt3.Rows[0]["Quantity"].ToString());
                    if (Int32.Parse(e.Row.Cells["Quantity"].Value.ToString()) > TempQuantity)
                    {
                        MessageBox.Show("Item is not in Stock \n" +
                            "Total Quantity  is  : " + TempQuantity);
                        e.Row.Cells["Quantity"].Value = 0;

                    }

                }
            }

            catch { }

            try
            {

                tax_id = Guid.Parse(e.Row.Cells["cmb_Tax"].Value.ToString());
            }
            catch { }

            Sub_Total();
            Calculate_Discount();
            Calculate_Discount_Amount();
            Calculate_Tax();
            Calculate_SubTotal();

            VendorText();
            PaidAmount();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearAll();
            POSMain.loadSaleScreen();
        }

        private void btnCmbCategory_Click(object sender, EventArgs e)
        {
            cmbSCategory.SelectedIndex = -1;
        }

        private void btnCmbBrand_Click(object sender, EventArgs e)
        {
            cmbSBrand.SelectedIndex = -1;
        }

    

       

     
        private void txtcmbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                Guid id;
                var val = txtcmbProduct.SelectedText;
                Guid.TryParse(txtcmbProduct.SelectedValue.ToString(), out id);
                LoadSProductsProId(id);
            }
            catch (Exception ex)
            {

            }
        }

        private void txtcmbProduct_TextChanged(object sender, EventArgs e)
        {
            if (cmbSCategory.SelectedIndex <0)
            {
                if (chkWildCard.Checked == true)
                {
                    string values;
                    values = txtcmbProduct.Text;
                    LoadSGridProduct_name_wildcard(values);
                }
                else
                {
                    string value;
                    value = txtcmbProduct.Text;
                    LoadSGridProduct_name_(value);
                }
            }
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            txtcmbProduct.SelectedIndex = -1;
            try
            {
                Guid id;
                Guid.TryParse(cmbSCategory.SelectedValue.ToString(), out id);
                LoadSProducts(id);
            }
            catch { }
        }

      

        //New Flow Addition
        private void FindBarcode()
        {
            DataTable dt = new DataTable();
            BarcodeBAL obj = new BarcodeBAL();
            BarcodeDAL objDal = new BarcodeDAL();
           if( txtBarcode.Text.Length >0)
            obj.ActualCode = txtBarcode.Text;
            if (txtSBarcode.Text.Length > 0)
                obj.ActualCode = txtSBarcode.Text;
            dt = objDal.FindProductByBarcode(obj);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    int x = gridSales.CurrentRow.Index;
                    //for add row automatically after barcode
                    
                    // try
                    //{
                    //    if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
                    //    {
                    //        if(x!=0)
                    //        addRow_PurchasesGrid();
                    //        x = gridSales.CurrentRow.Index;
                    //    }
                    //}
                    //catch { }
                        
                        //for (int x = 0; x < gridPurchases.Rows.Count; x++)
                        //{
 
                    Product_CategoryDAL objDAL = new Product_CategoryDAL();
                    cmb_ProductCategory.DataSource = objDAL.LoadAll();
                    cmb_ProductCategory.DisplayMember = "name";
                    cmb_ProductCategory.ValueMember = "id";
                   var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
                    if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
                    {
                        var ProductCategory = dt.Rows[0]["Product_Category_Id"];
                        gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


                        var Product = dt.Rows[0]["Product_Id"];
                        gridSales.Rows[x].Cells["cmb_Product"].Value = Product;

                        var Product_Variant_Id = dt.Rows[0]["Product_Variant_Id"];
                        gridSales.Rows[x].Cells["cmbVariant"].Value = Product_Variant_Id;
                       

                        var Price = dt.Rows[0]["Price"];
                        gridSales.Rows[x].Cells["UnitPrice"].Value =  Price;

                        var Quantity = 1;
                        gridSales.Rows[x].Cells["Quantity"].Value = Quantity;

                        Sub_Total();
                        Calculate_Discount();
                        Calculate_Discount_Amount();
                        Calculate_Tax();
                        Calculate_SubTotal();

                        VendorText();
                        PaidAmount();
                        addRow_PurchasesGrid();
                        SetText("");
                    }
                    // }
                   
                }
            }
            catch { }

            
        }
      
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtBarcode.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtBarcode.Text = text;
            }
        }

        // Find Barcode Like sugar (those we generated our own barcodes)
        private void FindBarcode_Own()
        {
            DataTable dt = new DataTable();
            BarcodeGenerateBAL obj = new BarcodeGenerateBAL();
            BarcodeGenerateDAL objDal = new BarcodeGenerateDAL();
            if (txtBarcode.Text.Length > 0)
                obj.UPC_Barcode = Convert.ToDouble(txtBarcode.Text);
            if (txtSBarcode.Text.Length > 0)
                 obj.UPC_Barcode = Convert.ToDouble(txtSBarcode.Text);
            dt = objDal.FindProductByBarcodeGenerate(obj);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    //for (int x = 0; x < gridPurchases.Rows.Count; x++)
                    //{
                    int x = gridSales.CurrentRow.Index;

                    Product_CategoryDAL objDAL = new Product_CategoryDAL();
                    cmb_ProductCategory.DataSource = objDAL.LoadAll();
                    cmb_ProductCategory.DisplayMember = "name";
                    cmb_ProductCategory.ValueMember = "id";
                    var v = gridSales.Rows[x].Cells["cmb_ProductCategory"].Value;
                    if (gridSales.Rows[x].Cells["cmb_ProductCategory"].Value == null)
                    {
                        var ProductCategory = dt.Rows[0]["Cat_id"];
                        gridSales.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


                        var Product = dt.Rows[0]["Pro_id"];
                        gridSales.Rows[x].Cells["cmb_Product"].Value = Product;

                        var Quantity = dt.Rows[0]["Quantity"];
                        gridSales.Rows[x].Cells["Quantity"].Value = Quantity;
                        

                        var Price = dt.Rows[0]["Price"];
                        gridSales.Rows[x].Cells["UnitPrice"].Value =  Price;
                        txtBarcode.Clear();

                        
                    }
                    // }
                }
            }
            catch { }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //for print report
            FormReport f = new FormReport("SaleInvoice_By InvoiceNo", "SaleInvoice_By InvoiceNo", txt_Invoice.Text);
            f.Show();

            POSMain.loadSaleScreen();
        }

        private void gridSales_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.ShiftKey)
            {
               
                int count = gridSales.Rows.Count;
                if(count>1)
                this.gridSales.Rows.RemoveAt(count-1);

            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {

                int count = gridSales.Rows.Count;
                if (count > 1)
                    this.gridSales.Rows.RemoveAt(count - 1);

            }
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {

            POSMain.loadSaleScreen();
            //this.panel3.AutoSize = true;
            //this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            //this.panel3.Controls.Add(this.panel6);
            //this.panel3.Controls.Add(this.cmbProduct);
            //this.panel3.Controls.Add(this.bunifuCustomLabel20);
            //this.panel3.Controls.Add(this.flowLayoutPanel2);
            //this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            //this.panel3.Location = new System.Drawing.Point(0, 0);
            //this.panel3.Name = "panel3";
            //this.panel3.Size = new System.Drawing.Size(513, 113);
            //this.panel3.TabIndex = 98;
        }
    }
}
