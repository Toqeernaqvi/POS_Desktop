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
    public partial class ucReturn : UserControl
    {
        bool validated = true;
        int x = 0;//f=for product Frid
        List<comboboxListItem> fullList;

        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        bool debug = false;
        Guid return_order_id = Guid.Empty;
        public static bool PerAdd;
        public static bool PerDel;
        public static string pgURL;
        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;
        private string AccountType = null;
        private Guid Stock_id = Guid.Empty;
        private Guid return_order_detail_id = Guid.Empty;
        private Guid organization_id = Guid.Empty;
        private Guid branch_id = Guid.Empty;
        private Guid party_id = Guid.Empty;
        private Guid tax_id = Guid.Empty;
        private Guid Product_Category_id = Guid.Empty;
        private Guid Pro_id = Guid.Empty;
        private string payment_type = "";
        GridViewComboBoxColumn cmb_ProductCategory = new GridViewComboBoxColumn();
        GridViewComboBoxColumn cmb_Product = new GridViewComboBoxColumn();
        GridViewComboBoxColumn cmb_Tax = new GridViewComboBoxColumn();
       // GridViewComboBoxColumn Quantity = new GridViewComboBoxColumn();
        GridViewTextBoxColumn Quantity = new GridViewTextBoxColumn();
        GridViewComboBoxColumn cmbQuantityType = new GridViewComboBoxColumn();

        GridViewTextBoxColumn UnitPrice = new GridViewTextBoxColumn();
        GridViewTextBoxColumn DiscountPercentage = new GridViewTextBoxColumn();
        GridViewTextBoxColumn DiscountAmount = new GridViewTextBoxColumn();

        GridViewTextBoxColumn SubTotal = new GridViewTextBoxColumn();
        GridViewTextBoxColumn SaleAmount = new GridViewTextBoxColumn();

        GridViewTextBoxColumn PriceWithoutDiscount = new GridViewTextBoxColumn();
        GridViewTextBoxColumn PriceWithDiscount = new GridViewTextBoxColumn();
        GridViewTextBoxColumn PriceWithTax = new GridViewTextBoxColumn();
        double sub_total;
        double Stotal;
        double tempp = 0;
        Double temp = 0;
        string Tax;
        Guid value = Guid.Empty;
        //
        bool testStock = true;

        string QuantityType = null;
        Double TotalQuantity = 0;


        //

        public void Load_Grid_Columns()
        {
            gridPurchases.Columns.Clear();

            GridViewCommandColumn btn_newrow = new GridViewCommandColumn();
            GridViewCommandColumn btn_delrow = new GridViewCommandColumn();

 
           

            ProductCategoryDAL objDAL = new ProductCategoryDAL();

            cmb_ProductCategory.HeaderText = "Product Category";
            cmb_ProductCategory.Name = "cmb_ProductCategory";

            this.gridPurchases.Columns.Add(cmb_ProductCategory);
            cmb_ProductCategory.DataSource = objDAL.LoadAll();
            cmb_ProductCategory.DisplayMember = "name";
            cmb_ProductCategory.ValueMember = "id";

            gridPurchases.Columns[0].Width = 200;

            //Product Coloumn
            ProductDAL objPDAL = new ProductDAL();

            cmb_Product.HeaderText = "Products";
            cmb_Product.Name = "cmb_Product";
           cmb_Product.DataSource = objPDAL.LoadAll();
           cmb_Product.DisplayMember = "Title";
           cmb_Product.ValueMember = "id";
            gridPurchases.Columns.Add(cmb_Product);

            gridPurchases.Columns["cmb_Product"].Width = 100;

            //


            // Quantity Type Coloumn

            cmbQuantityType.HeaderText = "Quantity Type";
            cmbQuantityType.Name = "cmbQuantityType";
            cmbQuantityType.DataSource = new String[] { "Packs", "Units" };
            cmbQuantityType.NullValue = "Packs";
            cmbQuantityType.FieldName = "Packs";
            //cmbQuantityType.DisplayMember = "Packs";
            //  cmbQuantityType.ValueMember =  "{acks" ;
            gridPurchases.Columns.Add(cmbQuantityType);

            gridPurchases.Columns["cmbQuantityType"].Width = 100;



            //Quantity Colunm
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
             
            gridPurchases.Columns.Add(Quantity);
            gridPurchases.Columns["Quantity"].Width = 100;
           // Quantity.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;
           


            //Unit Price Colunm
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.Name = "UnitPrice";
            gridPurchases.Columns.Add(UnitPrice);
            gridPurchases.Columns["UnitPrice"].Width = 100;

            //price w/o disc
            PriceWithoutDiscount.HeaderText = "Price Without Discount";
            PriceWithoutDiscount.Name = "PriceWithoutDiscount";
            gridPurchases.Columns.Add(PriceWithoutDiscount);
            gridPurchases.Columns["PriceWithoutDiscount"].Width = 100;


            //Discount Percentage
            DiscountPercentage.HeaderText = "Discount Percnetage";
            DiscountPercentage.Name = "DiscountPercentage";
            gridPurchases.Columns.Add(DiscountPercentage);
            gridPurchases.Columns["DiscountPercentage"].Width = 100;


            //Discount Amount
            DiscountAmount.HeaderText = "Discount Amount";
            DiscountAmount.Name = "DiscountAmount";
            gridPurchases.Columns.Add(DiscountAmount);
            gridPurchases.Columns["DiscountAmount"].Width = 100;


            //price w/d
            PriceWithDiscount.HeaderText = "Price With Discount";
            PriceWithDiscount.Name = "PriceWithDiscount";
            gridPurchases.Columns.Add(PriceWithDiscount);
            gridPurchases.Columns["PriceWithDiscount"].Width = 100;

            //Tax Coloumn
            TaxDAL objTDAL = new TaxDAL();
            cmb_Tax.HeaderText = "Tax";
            cmb_Tax.Name = "cmb_Tax";
            gridPurchases.Columns.Add(cmb_Tax);
            cmb_Tax.DataSource = objTDAL.LoadAll();
            cmb_Tax.DisplayMember = "Tax";
            cmb_Tax.ValueMember = "TaxID";
           // cmb_Tax.Index = sksk;
           // cmb_Tax.Index = -1;//Guid.Empty;
             gridPurchases.Columns["cmb_Tax"].Width = 100;

            //price w t
            PriceWithTax.HeaderText = "Price With Tax";
            PriceWithTax.Name = "PriceWithTax";
            gridPurchases.Columns.Add(PriceWithTax);
            gridPurchases.Columns["PriceWithTax"].Width = 100;

            //Sub Total Colunm
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            gridPurchases.Columns.Add(SubTotal);
            gridPurchases.Columns["SubTotal"].Width = 80;


            //Sale Amount
            SaleAmount.HeaderText = "Sale Amount";
            SaleAmount.Name = "SaleAmount";
            gridPurchases.Columns.Add(SaleAmount);
            gridPurchases.Columns["SaleAmount"].Width = 80;

            //
            gridPurchases.Columns.Add(btn_newrow);
            btn_newrow.HeaderText = "Add";
            btn_newrow.UseDefaultText = true;
            btn_newrow.DefaultText = "   +  ";
            btn_newrow.Name = "btn_newrow";
            gridPurchases.Columns["btn_newrow"].Width = 50;
            gridPurchases.Columns.Add(btn_delrow);              //5
            btn_delrow.HeaderText = "Delete";
            btn_delrow.UseDefaultText = true;
            btn_delrow.DefaultText = "  -  "; ;
            btn_delrow.Name = "btn_delrow";
            gridPurchases.Columns["btn_delrow"].Width = 50;

            if (debug == true)
            {

                gridPurchases.Columns["PriceWithDiscount"].IsVisible = false;
                gridPurchases.Columns["PriceWithOutDiscount"].IsVisible = false;
                gridPurchases.Columns["PriceWithTax"].IsVisible = false;
            }
        }
        public void addRow_PurchasesGrid()
        {
            GridViewRowInfo row = gridPurchases.Rows.AddNew();
            int i = row.Index;
            sub_total = 0;
            gridPurchases.Rows[i].Cells["SaleAmount"].Value = 0;
            gridPurchases.Rows[i].Cells["cmb_Tax"].Value = Guid.Parse("1E015D8C-0ECD-4DAA-83DB-0C258669C1BD");

            gridPurchases.Rows[i].Cells["DiscountPercentage"].Value = 0;
            gridPurchases.Rows[i].Cells["DiscountAmount"].Value = 0;

            gridPurchases.Rows[i].Cells["SubTotal"].Value = 0;

            gridPurchases.Rows[i].Cells["Quantity"].Value = 0;
            gridPurchases.Rows[i].Cells["UnitPrice"].Value = 0;


        }

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
                gridPurchases.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;
                //



                cmb_Product.DataSource = obj.LoadAll();
                cmb_Product.DisplayMember = "Title";
                cmb_Product.ValueMember = "id";

                var ProductID = dt.Rows[0]["pro_id"];
                gridPurchases.Rows[x].Cells["cmb_Product"].Value = ProductID;

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

                    gridPurchases.Columns["PriceWithDiscount"].IsVisible = false;
                    gridPurchases.Columns["PriceWithOutDiscount"].IsVisible = false;
                    gridPurchases.Columns["PriceWithTax"].IsVisible = false;
                }

                addRow_PurchasesGrid();
                x = gridPurchases.RowCount;
                x--;
            }
            catch { }
        }


        public ucReturn()
        {
            InitializeComponent();
            LoadCmbOrg();
            LoadCbxPayment();
            LoadCmbTax();
            LoadCmbProduct();
            LoadCbxProductCategory();
            loadParty();
            Load_Grid_Columns();
            addRow_PurchasesGrid();
            LoadCmbProducGrid();
            clearAll();            cbx_Status.Enabled = false;
            
        }
        private void LoadCmbProducGrid()
        {
            ProductDAL objDAL = new ProductDAL();
            cmbProductGrid.DataSource = objDAL.LoadProductNameWithCategory();
            cmbProductGrid.ValueMember = "id";
            cmbProductGrid.DisplayMember = "Title";
            cmbProductGrid.SelectedIndex = -1;
        }

        public ucReturn(Guid id)
        {
            InitializeComponent(); // This initializes front end components, should be first.

            LoadCmbOrg();
            LoadCbxPayment();
            LoadCmbTax();
            LoadCmbProduct();
            LoadCbxProductCategory();
            loadParty();
            Load_Grid_Columns();
            LoadCmbProducGrid();
            //  addRow_PurchasesGrid();
            loadForm_byID(id);
            loadGrid_byID(id);
            return_order_id = id;


        }

        private void loadGrid_byID(Guid id)

        {
            //Assign Values

            debug = true;
            Purchase_Order_Return_DetailDAL obj = new Purchase_Order_Return_DetailDAL();

            ProductDAL objPDAL = new ProductDAL();

            DataTable dt = obj.LoadAllById(id);
            for (int x = 0; x < dt.Rows.Count; x++)
            {
            
                Guid.TryParse(dt.Rows[x]["id"].ToString(), out return_order_detail_id);
                
                addRow_PurchasesGrid();
                //
                ProductCategoryDAL objDAL = new ProductCategoryDAL();
                cmb_ProductCategory.DataSource = objDAL.LoadAll();
                cmb_ProductCategory.DisplayMember = "name";
                cmb_ProductCategory.ValueMember = "id";

                var ProductCategory = dt.Rows[x]["product_category_id"];
                gridPurchases.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;
                //



                cmb_Product.DataSource = objPDAL.LoadAll();
                cmb_Product.DisplayMember = "Title";
                cmb_Product.ValueMember = "id";

                var ProductID = dt.Rows[x]["product_id"];
                gridPurchases.Rows[x].Cells["cmb_Product"].Value = ProductID;

                //
                var unitprice = dt.Rows[x]["purchase_amount"];
                gridPurchases.Rows[x].Cells["unitprice"].Value = unitprice;

                var quantity = dt.Rows[x]["quantity"];
                gridPurchases.Rows[x].Cells["quantity"].Value = quantity;

                var discountAmount = dt.Rows[x]["discount_amount"];
                gridPurchases.Rows[x].Cells["DiscountAmount"].Value = discountAmount;

                var discountPercentage = dt.Rows[x]["discount_percentage"];
                gridPurchases.Rows[x].Cells["DiscountPercentage"].Value = discountPercentage;

                var saleAmount = dt.Rows[x]["sale_amount"];
                gridPurchases.Rows[x].Cells["SaleAmount"].Value = saleAmount;
                //

                TaxDAL objTDAL = new TaxDAL();

                cmb_Tax.DataSource = objTDAL.LoadAll();
                cmb_Tax.DisplayMember = "Tax";
                cmb_Tax.ValueMember = "TaxID";


                var tax_id = dt.Rows[x]["tax_id"];
                gridPurchases.Rows[x].Cells["cmb_Tax"].Value = tax_id;
                //
                var tax_amount = dt.Rows[x]["tax_amount"];
                gridPurchases.Rows[x].Cells["PriceWithTax"].Value = tax_amount;

                Calculate_Discount();
                Calculate_Discount_Amount();
                Calculate_Tax();

                Sub_Total();
                if (debug == true)
                {

                    gridPurchases.Columns["PriceWithDiscount"].IsVisible = false;
                    gridPurchases.Columns["PriceWithOutDiscount"].IsVisible = false;
                    gridPurchases.Columns["PriceWithTax"].IsVisible = false;
                }
            }
        }
        //For Form Fields 
        public void loadForm_byID(Guid id)
        {
            btnSave.LabelText = "Update";
            Purchase_Order_ReturnDAL obj = new Purchase_Order_ReturnDAL();

            DataTable dt = obj.LoadAllById(id);
      
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                var ID = dt.Rows[x]["id"];
           Guid.TryParse(ID.ToString(), out return_order_id);

                var OrgID = dt.Rows[x]["organization_id"];
               Guid.TryParse(OrgID.ToString(), out organization_id);

                cbx_Organization.SelectedValue = organization_id;
                LoadCmbOrgBranch();
                var BranchID = dt.Rows[x]["branch_id"];
                 Guid.TryParse(BranchID.ToString(),out branch_id);
                cbx_branch.SelectedValue = branch_id;


                var partyID = dt.Rows[x]["party_id"];
               Guid.TryParse(partyID.ToString(), out party_id);
                cbx_Party.SelectedValue = party_id;


                var TotalAmount = dt.Rows[x]["total_amount"];
                lblTotal.Text = TotalAmount.ToString();

                var subTotalAmount = dt.Rows[x]["sub_total_amount"];
                lblSubTotal.Text = subTotalAmount.ToString();

                var discount_amount = dt.Rows[x]["discount_amount"];
                txtDiscountAmount.Text = discount_amount.ToString();

                var discount_Percentage = dt.Rows[x]["discount_percentage"];
                txt_Discount.Text = discount_Percentage.ToString();
                txt_Order.Text = discount_Percentage.ToString();

                var Paid_amount = dt.Rows[x]["paid_amount"];
                txt_PaidAmount.Text = Paid_amount.ToString();

                var remaining_amount = dt.Rows[x]["remaning_amount"];
                lblRemaining.Text = remaining_amount.ToString();

                var remarks = dt.Rows[x]["remarks"];
                txt_Remarks.Text = remarks.ToString();

                var payment_Type = dt.Rows[x]["payment_type"];
                cbx_Payment.Text = payment_Type.ToString();
               
                

                var invoiceNo = dt.Rows[x]["Invoice_no"];
                txt_Invoice.Text = invoiceNo.ToString();

                var orderNo = dt.Rows[x]["Order_no"];
                txt_Order.Text = orderNo.ToString();

                var status = dt.Rows[x]["status"];
                cbx_Status.Text = status.ToString();
                if (cbx_Status.Text == "Paid but items not returned")
                {
                    cbx_Status.Items.Clear();
                    cbx_Status.Items.Add("Paid and returned");

                }
                else if (cbx_Status.Text == "Items returned but not paid")
                {
                    testStock = false;
                    cbx_Status.Items.Clear();
                    cbx_Status.Items.Add("Paid and returned");

                }
                else if (cbx_Status.Text == "Paid and returned")
                {
                    cbx_Status.Items.Clear();

                    cbx_Status.Items.Add("Paid and returned");
                    btnSave.Hide();

                }
                else if (cbx_Status.Text == "Pending")
                {
                    cbx_Status.Items.Clear();
                    cbx_Status.Items.Add("Paid but items not returned");
                    cbx_Status.Items.Add("Items returned but not paid");
                    cbx_Status.Items.Add("Paid and returned");


                }
                var TaxID = dt.Rows[x]["tax_id"];
                cbx_Tax.SelectedValue = TaxID;
                Guid.TryParse(TaxID.ToString(),out tax_id);

                var TaxAmount = dt.Rows[x]["tax_amount"];
                lbl_TaxAmount.Text = TaxAmount.ToString();

                var vendor = dt.Rows[x]["non_vendor_cost_amount"];
                txt_VendorCost.Text = vendor.ToString();


                var ReturnDate = dt.Rows[x]["return_date"];
                dtpReturnDate.Value = DateTime.Parse(ReturnDate.ToString());


                var ReturnFee = dt.Rows[x]["return_fee"];
                txtReturnFee.Text = ReturnFee.ToString();


                var Refund = dt.Rows[x]["refund"];
                txtRefund.Text = ReturnFee.ToString();



                var Credit = dt.Rows[x]["credit"];
                lblCredit.Text = Credit.ToString();

                var date = dt.Rows[x]["date"];
                mdtPurchase.Value = DateTime.Parse(date.ToString());

            }
        }
        private void loadParty()
        {
            PurchasePartyDAL objDAL = new PurchasePartyDAL();
            cbx_Party.DataSource = objDAL.LoadAll();
            cbx_Party.ValueMember = "party_id";
            cbx_Party.DisplayMember = "name";
            cbx_Party.SelectedIndex = -1;

        }


        private void LoadCmbTax()
        {
            TaxDAL objDAL = new TaxDAL();
            cbx_Tax.DataSource = objDAL.LoadAll();
            cbx_Tax.ValueMember = "TaxID";
            cbx_Tax.DisplayMember = "Tax";
            cbx_Tax.SelectedValue = Guid.Parse("1E015D8C-0ECD-4DAA-83DB-0C258669C1BD");
           // cbx_Tax.SelectedIndex = -1;
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
            //Product_CategoryDAL objDAL = new Product_CategoryDAL();
            ////cbx_Category.DataSource = objDAL.LoadAll();
            ////cbx_Category.ValueMember = "id";
            ////cbx_Category.DisplayMember = "name";
            ////cbx_Category.SelectedIndex = -1;
            //cmb_ProductCategory.HeaderText = "Product Category";
            //cmb_ProductCategory.Name = "cmb_ProductCatego";
            //gridPurchases.Columns.Clear();
            //this.gridPurchases.Columns.Add(cmb_ProductCategory);
            //cmb_ProductCategory.DataSource = objDAL.LoadAll();
            //cmb_ProductCategory.DisplayMember = "name";
            //cmb_ProductCategory.ValueMember = "id";
            //gridPurchases.Columns[0].Width = 255;
        }
        private void LoadCmbProduct()
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
            cbx_Payment.SelectedIndex = -1;
        }

        private void ucPurchase1_Load(object sender, EventArgs e)
        {
            pgURL = "Manage Return Orders";  
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

                cbx_Organization.Visible = false;
                lblError_Organization.Visible = false;
                lblOrganization.Visible = false;


            }

            else if (AccountType == "Accountant")
            {
                //for  Branch Admin
 
                try {
                    organization_id = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString());
                    branch_id = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Branch_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                cbx_Organization.Visible = false;
                lblError_Organization.Visible = false;
                lblOrganization.Visible = false;
                cbx_branch.Visible = false;
                lblError_Branch.Visible = false;
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

            cbx_Organization.SelectedValue = organization_id;
            LoadCmbOrgBranch();
            cbx_branch.SelectedValue = branch_id;


            Purchase_OrderDAL orderDAL = new Purchase_OrderDAL();
            orderDAL.LoadAll();

             Purchase_Order_DetailDAL detailDAL = new Purchase_Order_DetailDAL();
            detailDAL.LoadAll();
            GenerateID_Invoice();
            GenerateID_Order();

            
            txt_Discount.Text = "0";
            txtDiscountAmount.Text = "0";
            txt_VendorCost.Text = "0";

        }
        private void clearAll()
        {
            lblError_Organization.Text = "!";
            lblError_Branch.Text = "!";
            lblError_Party.Text = "!";
            // lblError_ProductCategory.Text = "!";
            //lblError_Product.Text = "!";
            lblError_Payment.Text = "!";
            cbx_branch.SelectedValue = -1;
            cbx_Organization.SelectedValue = -1;
            cbx_Party.SelectedValue = -1;
            cbx_Payment.SelectedIndex = 0;
            cbx_Tax.SelectedIndex = 1;
            txtDiscountAmount.Text = "0";
            //  cbx_Status.SelectedIndex = 1;

            txt_Invoice.Text = "";
            txt_Order.Text = "";
            txt_PaidAmount.Text = "0";
            txt_Remarks.Text = "";
            txt_VendorCost.Text = "0";
            txt_Discount.Text = "0";

            lblSubTotal.Text = "0.00";
            lblCredit.Text = "0.00";
            lblTotal.Text = "0.00";
            lbl_TaxAmount.Text = "0.00";

            gridPurchases.Rows.Clear();
            lblPaidAmount.Text = "";
            addRow_PurchasesGrid();
            lblDiscount.Text = "0.00";
            lblRemaining.Text = "0.00";
            lblSubTotal.Text = "0.00";

            txtRefund.Text = "0";
            txtReturnFee.Text = "0";
            txt_PaidAmount.Text = "0";
            txtRefund.Text = "0";
            txtReturnFee.Text = "0";
            cbx_Payment.SelectedIndex = 0;

        }
        private bool ValidateForm()
        {
            float paidAmount = 0;
                float.TryParse(txt_PaidAmount.Text, out paidAmount);
            float total = 0;
                float.TryParse(lblTotal.Text, out total);
            if (paidAmount > total)
            {
                lblPaidAmount.Text = "Amount Should be less \nthan or Equal Total Amount";
            }

            //Order No.
            if (string.IsNullOrEmpty(txt_Order.Text))
            {
                lblErrorOrder.Text += "!";
                validated = false;
            }
            else
            {
                lblErrorOrder.Text = "";
            }


            //Invoic No.
            if (string.IsNullOrEmpty(txt_Invoice.Text))
            {
                lblErrorInvoice.Text += " !";
                validated = false;
            }
            else
            {
                lblErrorInvoice.Text = "";
            }

            // bool validated = true;

            // if (cbx_Organization.SelectedIndex < 0)
            // {
            //     lblError_Organization.Text += "Required!";
            //     validated = false;
            // }
            // else
            // {
            //     lblError_Organization.Text = "!";
            // }


            // if (cbx_branch.SelectedIndex < 0)
            // {
            //     lblError_Branch.Text += "Required!";
            //     validated = false;
            // }
            // else
            // {
            //     lblError_Branch.Text = "!";
            // }

            // if (cbx_Party.SelectedIndex < 0)
            // {
            //     lblError_Party.Text += "Required!";
            //     validated = false;
            // }
            // else
            // {
            //     lblError_Party.Text = "!";
            // }

            //if (cbx_Category.SelectedIndex < 0)
            ////// {
            ////     lblError_ProductCategory.Text += "Required!";
            ////     validated = false;
            //// }
            // else
            // {
            //     lblError_ProductCategory.Text = "!";
            // }

            // if (cbx_Product.SelectedIndex < 0)
            // {
            //     lblError_Product.Text += "Required!";
            //     validated = false;
            // }
            // else
            // {
            //     lblError_Product.Text = "!";
            // }

            // if (cbx_Payment.SelectedIndex < 0)
            // {
            //     lblError_Payment.Text += "Required!";
            //     validated = false;
            // }
            // else
            // {
            //     lblError_Payment.Text = "!";
            // }


            return  validated;

        }

        private void cbx_Organization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cbx_Organization.SelectedValue.ToString(),out organization_id);
            LoadCmbOrgBranch();
            txt_Invoice.Clear();
            txt_Order.Clear();

        }

        private void cbx_branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
             Guid.TryParse(cbx_branch.SelectedValue.ToString(), out branch_id);
            loadParty();
            GenerateID_Invoice();
            GenerateID_Order();

        }

        private void cbx_Party_SelectionChangeCommitted(object sender, EventArgs e)
        {
             Guid.TryParse(cbx_Party.SelectedValue.ToString(), out party_id);

        }

        private void cbx_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //  Product_Category_id = Guid.Parse(cbx_Category.SelectedValue.ToString());

        }

        private void cbx_Product_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Pro_id = Guid.Parse(cbx_Product.SelectedValue.ToString());

        }

        private void cbx_Payment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            payment_type = cbx_Payment.SelectedValue.ToString();

        }

        private void cbx_Tax_SelectionChangeCommitted(object sender, EventArgs e)
        {
             
         
                Calculate_SubTotal();

            tax_id = Guid.Parse(cbx_Tax.SelectedValue.ToString());

            Purchase_Order_ReturnDAL obj = new Purchase_Order_ReturnDAL();

            Tax = obj.Tax(tax_id);
            double t = 0;
                double.TryParse(Tax,out t);
           Double.TryParse(lblSubTotal.Text,out temp);
            double ans = temp * (t / 100);
            lbl_TaxAmount.Text = ans.ToString();

            DiscountCalculate();
           
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = new Guid();
                if (btnSave.LabelText == "Save")
                {
                    id = Guid.NewGuid();
                    return_order_id = id;
                }
                if (ValidateForm())
                {
                    Purchase_Order_ReturnBAL objBAL = new Purchase_Order_ReturnBAL();
                    GenerateID_Invoice();
                    GenerateID_Order();


                    objBAL.id = return_order_id;
                    objBAL.organization_id = organization_id;
                    objBAL.branch_id = branch_id;
                    objBAL.party_id = party_id;
                    objBAL.Order_no = txt_Order.Text;
                    objBAL.status = cbx_Status.Text;
                    objBAL.Invoice_no = txt_Invoice.Text;
                    objBAL.tax_id = tax_id;
                    objBAL.tax_amount = Convert.ToInt32(Tax);
                    objBAL.non_vendor_cost_amount = Convert.ToInt32(txt_VendorCost.Text);
                    objBAL.non_vendor_cost_percentage = Convert.ToInt32(txt_VendorCost.Text);
                    objBAL.remarks = txt_Remarks.Text;
                    float t1 = 0;
                    float.TryParse(txtDiscountAmount.Text, out t1);
                    objBAL.discount_amount = t1;

                    int t2 = 0;
                    int.TryParse(txt_Discount.Text, out t2);
                    objBAL.discount_percentage = t2;
                    objBAL.payment_type = cbx_Payment.Text;

                    float t3 = 0, t4 = 0, t5 = 0, t6 = 0, t7 = 0;
                    float.TryParse(lblSubTotal.Text, out t3);
                    objBAL.sub_total_amount = t3;
                    float.TryParse(lblTotal.Text, out t4);
                    objBAL.total_amount = t4;
                    float.TryParse(txt_PaidAmount.Text, out t5);
                    objBAL.paid_amount = t5;
                    float.TryParse(lblRemaining.Text, out t6);
                    objBAL.remaining_amount = t6;
                    objBAL.date = mdtPurchase.Value;


                    objBAL.return_date = DateTime.Parse(dtpReturnDate.Value.ToString());
                    objBAL.return_fee = float.Parse(txtReturnFee.Text);
                    objBAL.refund = float.Parse(txtRefund.Text);
                    objBAL.credit = float.Parse(lblCredit.Text);


                    Purchase_Order_ReturnDAL objDAL = new Purchase_Order_ReturnDAL();

                    if (return_order_id != id)
                    {

                        objBAL.id = return_order_id;
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
                    Purchase_Order_Return_DetailDAL objt = new Purchase_Order_Return_DetailDAL();

                    DataTable dt = objt.LoadAllById(return_order_id);
                    for (int x = 0; x < gridPurchases.RowCount; x++)
                    {

                        try
                        {
                            return_order_detail_id = Guid.Parse(dt.Rows[x]["id"].ToString());

                        }
                        catch
                        {
                            return_order_detail_id = Guid.Empty;
                        }
                        Purchase_Order_Return_DetailsBAL objDetailBAL = new Purchase_Order_Return_DetailsBAL();
                        objDetailBAL.puchase_order_Return_id = return_order_id;
                        Guid.TryParse(gridPurchases.Rows[x].Cells["cmb_ProductCategory"].Value.ToString(), out Product_Category_id);
                        objDetailBAL.product_category_id = Product_Category_id;
                        Guid Pro_id = Guid.Empty;
                        Guid.TryParse(gridPurchases.Rows[x].Cells["cmb_Product"].Value.ToString(), out Pro_id);
                        objDetailBAL.product_id = Pro_id;
                        objDetailBAL.status = cbx_Status.Text;

                        objDetailBAL.quantity = Convert.ToDouble(gridPurchases.Rows[x].Cells["Quantity"].Value.ToString());
                        objDetailBAL.purchase_amount = Convert.ToDouble(gridPurchases.Rows[x].Cells["UnitPrice"].Value.ToString());
                        objDetailBAL.sale_amount = Convert.ToDouble(gridPurchases.Rows[x].Cells["saleAmount"].Value.ToString());
                        Guid.TryParse(gridPurchases.Rows[x].Cells["cmb_Tax"].Value.ToString(), out tax_id);
                        objDetailBAL.tax_id = tax_id;
                        objDetailBAL.tax_amount = Convert.ToDouble(gridPurchases.Rows[x].Cells["PriceWithTax"].Value.ToString());
                        objDetailBAL.discount_amount = Convert.ToDouble(gridPurchases.Rows[x].Cells["DiscountPercentage"].Value.ToString());
                        objDetailBAL.discount_percentage = Convert.ToInt32(gridPurchases.Rows[x].Cells["DiscountAmount"].Value.ToString());
                        objDetailBAL.date = mdtPurchase.Value;
                        objDetailBAL.return_date = dtpReturnDate.Value;
                       try
                        {
                            string quantityType = Convert.ToString(gridPurchases.Rows[x].Cells["quantityType"].Value.ToString());
                            if (quantityType == null)
                            {
                                objDetailBAL.quantityType = "Packs";
                            }
                            else
                                objDetailBAL.quantityType = Convert.ToString(gridPurchases.Rows[x].Cells["quantityType"].Value.ToString());
                        }
                        catch {
                            objDetailBAL.quantityType = "Packs";
                            QuantityType = objDetailBAL.quantityType;


                        }

                        Purchase_Order_Return_DetailDAL objDetailDAL = new Purchase_Order_Return_DetailDAL();

                        if (return_order_detail_id != Guid.Empty)
                        {
                            objDetailBAL.id = return_order_detail_id;
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
                        if (testStock == true)
                        {
                            if (QuantityType == "Packs")
                            {
                                ProductDAL obj = new ProductDAL();
                                DataTable dtt = new DataTable();
                                dtt = obj.getQuantityInEachFromProduct(Pro_id);
                                var qie = dtt.Rows[0]["quantityineach"];
                                double q = Convert.ToDouble(gridPurchases.Rows[x].Cells["Quantity"].Value.ToString());
                                TotalQuantity = Convert.ToDouble(qie) * q;
                            }
                            else if (QuantityType == "Units")
                            {
                                TotalQuantity = Convert.ToDouble(gridPurchases.Rows[x].Cells["Quantity"].Value.ToString());

                            }
                            if (cbx_Status.Text == "Paid and returned" | cbx_Status.Text == "Items returned but not paid")
                            {

                                //
                                StockBAL obj = new StockBAL();
                                obj.Organization_id = organization_id;
                                Guid.TryParse(gridPurchases.Rows[x].Cells["cmb_ProductCategory"].Value.ToString(), out Product_Category_id);
                                obj.Product_Category_id = Product_Category_id;
                                Guid.TryParse(gridPurchases.Rows[x].Cells["cmb_Product"].Value.ToString(), out Pro_id);
                                obj.Product_id = Pro_id;
                                obj.Branch_id = branch_id;
                                obj.POS_id = return_order_id;
                                obj.Order_no = txt_Order.Text;
                                obj.quantity = TotalQuantity;
                                obj.purchaseprice = Convert.ToDouble(gridPurchases.Rows[x].Cells["UnitPrice"].Value.ToString());
                                obj.saleprice = Convert.ToDouble(gridPurchases.Rows[x].Cells["saleAmount"].Value.ToString());
                                obj.barcode = "123X";
                                obj.expiryDate = Convert.ToDateTime("02-02-2022");
                                obj.Addby = Program.User_id;
                                obj.AddDate = DateTime.Now;
                                obj.status = "Return Stock";
                                obj.SOS_id = Guid.Empty;
                                obj.SOR_id = Guid.Empty;
                                obj.POR_id = Guid.Empty;
                                obj.Prescription_Medicine_id = Guid.Empty;

                                obj.Source = Sources.PurchaseOrderDetail.ToString();
                                obj.Type = "-";
                                obj.Flag = 1;
                                if (cbx_Status.Text == "Paid and returned")
                                {
                                    StockDAL objD = new StockDAL();
                                    objD.Add(obj);
                                }
                                else if (cbx_Status.Text == "Items returned but not paid")
                                {
                                    StockDAL objD = new StockDAL();
                                    objD.Add(obj);
                                }
                                //
                                //For Manage Stock
                                //StockDAL objStock = new StockDAL();
                                //DataTable dtStock = new DataTable();
                                //int stockQuantity = 0;
                                //int gridQuantity = 0;
                                //int tempQuantity = 0;
                                //Int32.TryParse(objDetailBAL.quantity.ToString(), out gridQuantity);
                                //if (gridQuantity > 0)
                                //{
                                //    dtStock = objStock.GetStockOnProductId(Pro_id);
                                //    for (int y = 0; y < dtStock.Rows.Count; y++)
                                //    {
                                //        Guid.TryParse(dtStock.Rows[y]["id"].ToString(), out Stock_id);
                                //        Guid.TryParse(dtStock.Rows[y]["Product_id"].ToString(), out Pro_id);
                                //        Int32.TryParse(dtStock.Rows[y]["Quantity"].ToString(), out stockQuantity);
                                //        try
                                //        {
                                //            do
                                //            {
                                //                if (gridQuantity < stockQuantity)
                                //                {
                                //                    tempQuantity = gridQuantity;
                                //                    objStock.MinusQuantityInStock(Stock_id, Pro_id, tempQuantity);
                                //                }
                                //                else if (stockQuantity < gridQuantity)
                                //                {
                                //                    tempQuantity = gridQuantity - stockQuantity;
                                //                    objStock.MinusQuantityInStock(Stock_id, Pro_id, tempQuantity);

                                //                }
                                //                else if (stockQuantity == gridQuantity)
                                //                {
                                //                    tempQuantity = stockQuantity;
                                //                    objStock.MinusQuantityInStock(Stock_id, Pro_id, tempQuantity);

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

            clearAll();
        }

        private void gridPurchases_CellClick(object sender, GridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 12)
            {
                addRow_PurchasesGrid();
            }
            if (e.ColumnIndex == 13)
            {
                if(gridPurchases.Rows.Count>1)
                this.gridPurchases.Rows.RemoveAt(e.RowIndex);
              
            }
           
        }

        public void Sub_Total()
        {
            // if (gridPurchases.Rows.Count > 0)

            double quantity = 0, unit_price = 0, discount = 0;
            for (int i = 0; i < gridPurchases.Rows.Count; i++)
            {
                try
                {
                    quantity = Convert.ToDouble(gridPurchases.Rows[i].Cells["Quantity"].Value.ToString());
                    unit_price = Convert.ToDouble(gridPurchases.Rows[i].Cells["UnitPrice"].Value.ToString());
                    //  discount = Convert.ToDouble(gridPurchases.Rows[i].Cells["Discount"].Value.ToString());


                    gridPurchases.Rows[i].Cells["PriceWithoutDiscount"].Value = quantity * unit_price;
                    gridPurchases.Rows[i].Cells["SubTotal"].Value = gridPurchases.Rows[i].Cells["PriceWithoutDiscount"].Value;




                }
                catch (Exception)
                {
                    gridPurchases.Rows[i].Cells["SubTotal"].Value = 0;

                }
            }


        }
        public void Calculate_Tax()
        {
            Double atax = 0,Tax= 0 ;
            TaxDAL objTDAL = new TaxDAL();
    

            for (int i = 0; i < gridPurchases.Rows.Count; i++)

            {
                Guid TaxID  ;


                try
                {
                    atax = Convert.ToDouble(gridPurchases.Rows[i].Cells["PriceWithDiscount"].Value.ToString());
                  

                          Guid.TryParse(gridPurchases.Rows[i].Cells["cmb_Tax"].Value.ToString(),out TaxID);
                
                    try
                    {
                       // gridPurchases.Rows[i].Cells["cmb_Tax"].Value = TaxID;

                        DataTable dt = objTDAL.LoadByID(TaxID);

                         Double.TryParse(dt.Rows[0]["TaxPercen"].ToString(), out Tax);
                       // Tax = Double.Parse(value.ToString());

                    }

                    catch { }
                  
            
                    atax += atax * (Tax / 100);
                    Math.Round(atax);
                    gridPurchases.Rows[i].Cells["PriceWithTax"].Value = atax;
                    gridPurchases.Rows[i].Cells["SubTotal"].Value = gridPurchases.Rows[i].Cells["PriceWithTax"].Value;
                   
                    sub_total = Convert.ToDouble(gridPurchases.Rows[i].Cells["SubTotal"].Value.ToString());

                }
                catch (Exception)
                {
                    gridPurchases.Rows[i].Cells["SubTotal"].Value = 0;

                }
            }
        }
        private void gridPurchases_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
           


            try
            {
               
                Guid.TryParse(e.Row.Cells["cmb_Tax"].Value.ToString(), out tax_id);
            }
            catch { }

            //if (e.Column.Name == "cmb_ProductCategory")
            //{
            //    try
            //    {
            //        ProductDAL obj = new ProductDAL();
            //        cmb_Product.DataSource = obj.LoadProdcutbyCategory(value);
            //        cmb_Product.ValueMember = "Pro_id";
            //        cmb_Product.DisplayMember = "Name";

            //        gridPurchases.CurrentColumn = cmb_Product;
            //        Pro_id = Guid.Parse(e.Row.Cells["cmb_Product"].Value.ToString());
            //    }

            //    catch { }
            //}
            // colBox.DataSource = obj.LoadbyId(value);
            // colBox.ValueMember = "Pro_id";
            // colBox.DisplayMember = "name";
            //     e.Row.Cells["cmb_Product"].Value = colBox.ToString();

            //   RadMessageBox.Show(value.ToString());
            Sub_Total();
            Calculate_Discount();
            Calculate_Discount_Amount();
            Calculate_Tax();
            Calculate_SubTotal();

            VendorText();
            PaidAmount();

        }
        public void Calculate_SubTotal()
        {
            try
            {
                Stotal = 0;
                for (int i = 0; i < gridPurchases.Rows.Count; i++)
                {

                    Stotal += Convert.ToDouble(gridPurchases.Rows[i].Cells["SubTotal"].Value.ToString());
                    Math.Abs(Stotal);
                }
                lblSubTotal.Text = Stotal.ToString();
            }
            catch { }
        }
        public void Calculate_Discount()
        {
            // if (gridPurchases.Rows.Count > 0)

            double temp = 0, unit_price = 0, discount = 0;
            for (int i = 0; i < gridPurchases.Rows.Count; i++)
            {
                try
                {
                    temp = Convert.ToDouble(gridPurchases.Rows[i].Cells["PriceWithoutDiscount"].Value.ToString());
                    discount = Convert.ToDouble(gridPurchases.Rows[i].Cells["DiscountPercentage"].Value.ToString());
                    double Stotal = temp - (temp * discount / 100);
                    Math.Round(Stotal);
                    gridPurchases.Rows[i].Cells["PriceWithDiscount"].Value = Stotal;
                    gridPurchases.Rows[i].Cells["SubTotal"].Value = gridPurchases.Rows[i].Cells["PriceWithDiscount"].Value;



                }
                catch (Exception)
                {
                    gridPurchases.Rows[i].Cells["SubTotal"].Value = 0;

                }
            }


        }


        private void Calculate_Discount_Amount()
        {
            // if (gridPurchases.Rows.Count > 0)

            double temp = 0, unit_price = 0, discount = 0;
            for (int i = 0; i < gridPurchases.Rows.Count; i++)
            {
                try
                {
                    temp = Convert.ToDouble(gridPurchases.Rows[i].Cells["PriceWithoutDiscount"].Value.ToString());

                    discount = Convert.ToDouble(gridPurchases.Rows[i].Cells["DiscountAmount"].Value.ToString());
                    if (discount != 0)
                    {
                        double Stotal = temp - discount;
                        Math.Round(Stotal);
                        gridPurchases.Rows[i].Cells["PriceWithDiscount"].Value = Stotal;
                        gridPurchases.Rows[i].Cells["SubTotal"].Value = gridPurchases.Rows[i].Cells["PriceWithDiscount"].Value;

                    }

                }
                catch (Exception)
                {
                    gridPurchases.Rows[i].Cells["SubTotal"].Value = 0;

                }
            }
        }
        private void GenerateID_Invoice()
        {
            if (txt_Invoice.Text.Length==0)
            {
                SqlDataReader dr;
                con.Open();
                cmd = new SqlCommand("Select Max(Invoice_no) from Purchase_Order_Return  Where  Organization_id = '" + cbx_Organization.SelectedValue+"'" +
                    "  and branch_id  = '"+cbx_branch.SelectedValue+"'", con);
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
                cmd = new SqlCommand("Select Max(Order_no) from Purchase_Order_Return Where  Organization_id = '" + cbx_Organization.SelectedValue + "'" +
                    "  and branch_id  = '" + cbx_branch.SelectedValue + "'", con);
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
                Double.TryParse(lblTotal.Text,out temp);




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
   

        private void  DiscountAmountCalculate()
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
                lblRemaining.Text = Stotal.ToString();

                temp = tempp;
            }
            catch { }


        }

         
        private void PaidAmount()
        {
            try
            {
                Double Paid = 0, total = 0;
                 Double.TryParse(txt_PaidAmount.Text,out Paid);
                total =  Double.Parse(lblTotal.Text) - Paid;
                
                double ans = Math.Truncate(total);
                 lblRemaining.Text = ans.ToString();
                if (total > 0)
                {
                    lblRemaining.Text = "0";
                }
                else
                {
                    ans = Math.Truncate(total);
                    lblRemaining.Text = ans.ToString();
                }
             }
            catch { }
        }
        private void txt_PaidAmount_TextChanged(object sender, EventArgs e)
        {

            PaidAmount();
        }
        private void VendorText()
        {
            try
            {
              
                DiscountCalculate();
                DiscountAmountCalculate();

                double temp = 0;  Double.TryParse(lblSubTotal.Text, out temp);
                double venderCost = 0; Double.TryParse(txt_VendorCost.Text, out venderCost);
                temp +=Math.Truncate( venderCost);
                lblTotal.Text = temp.ToString();
                tempp = temp;
            }
            catch { }
        }
        private void txt_VendorCost_TextChanged(object sender, EventArgs e)
        {


            VendorText();
        }

      

        private void gridPurchases_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {

            //fullList = new BindingList<ForBinding>();
            DataTable dt = new DataTable();
            object ob = new object();

            PricingDAL objd = new PricingDAL();
            ProductDAL obj = new ProductDAL();

            try
            {
                  Guid.TryParse(e.Row.Cells["cmb_ProductCategory"].Value.ToString(),out value);

                Product_Category_id = value;
            }
            catch { }
            int i = 0;
             i = Convert.ToInt32(e.RowIndex);

            if (e.Column.HeaderText == "Products")
                {
                    if (this.gridPurchases.CurrentRow.Cells["cmb_ProductCategory"].Value != DBNull.Value
                        && this.gridPurchases.CurrentRow.Cells["cmb_ProductCategory"].Value != null)
                    {
                        RadDropDownListEditor editor = (RadDropDownListEditor)this.gridPurchases.ActiveEditor;
                        RadDropDownListEditorElement editorElement = (RadDropDownListEditorElement)editor.EditorElement;
                        dt = obj.LoadProdcutbyCategory(value);
                        //fullList = Utility.GetListByDataTable(dt);
                        editorElement.DataSource = Utility.GetListByDataTable(dt);

                           // editorElement.SelectedValue = null;
                        editorElement.SelectedValue = this.gridPurchases.CurrentCell.Value;
                    }
                }

            if (e.Column.HeaderText == "Quantity" || e.Column.HeaderText == "Discount Percnetage")
            {

                DataTable dtt = new DataTable();
                DataTable dt2 = new DataTable();
                PricingBAL objb = new PricingBAL();
                PricingDAL objdd = new PricingDAL();
                dtt.Clear();
                try
                {
                    StockDAL objj = new StockDAL();
                Guid.TryParse(gridPurchases.Rows[i].Cells["cmb_Product"].Value.ToString(),out Pro_id);
                    Guid Cat_id = Guid.Empty;
                   Guid.TryParse(gridPurchases.Rows[i].Cells["cmb_ProductCategory"].Value.ToString(),out Cat_id);

                    dtt = objj.FindQuantity(Pro_id, Cat_id);
                    dt2 = objd.FindPrice_Pricing(Pro_id, Cat_id);

                    //pricing
                    Guid PriceID = Guid.Empty;Guid RID = Guid.Empty;
                    Guid.TryParse(dt2.Rows[0]["PriceID"].ToString(), out PriceID);
                    objb.Pricing_id = PriceID;
                    objb.ProID = Pro_id;
                    objb.CatID = Cat_id;
                    Guid.TryParse(dt2.Rows[0]["Purchase_Order_id"].ToString(), out RID);
                    objb.Purchase_order_id= RID;
                    objb.Date = DateTime.Now;
                    objb.AddBy = dt2.Rows[0]["AddBy"].ToString();
                    DateTime d; DateTime.TryParse(dt2.Rows[0]["AddDate"].ToString(), out d);
                    objb.AddDate = d;

                    //
 
 

                    if (dtt.Rows.Count != 0)
                    {//fetch quantity ffrom stock
                        var quantity = dtt.Rows[0]["Quantity"];
                      //  gridPurchases.Rows[i].Cells["Quantity"].Value = quantity.ToString();
                       // MessageBox.Show("Total Quantity in Stock : " + quantity);
                        //stock fetch values
                    }
              
                    if (dt2.Rows.Count != 0)
                    {
                        float priceD = 0;
                       
                            var price = dt2.Rows[0]["Price"];
                        if(e.Column.HeaderText == "Quantity")
                            gridPurchases.Rows[i].Cells["UnitPrice"].Value = price;

                            //price from grid
                            priceD = float.Parse(gridPurchases.Rows[i].Cells["UnitPrice"].Value.ToString());
                            objb.price = float.Parse(dt2.Rows[0]["Price"].ToString());
                        //compare grid price and datatable price
                        if (objb.price != priceD)
                        {
                            Guid.TryParse(dt2.Rows[0]["PriceID"].ToString(), out PriceID);
                            objb.Pricing_id = PriceID;
                            objb.status = "deactive";

                            objb.Flag = 0;
                            objb.EditBy = "Admin";
                            objb.EditDate = DateTime.Now;

                            objdd.Update(objb);

                            //Add new price

                            objb.price = priceD;
                            objb.Purchase_order_id =  RID;

                            objb.status = "Active";
                                objb.Flag = 1;
                                objdd.Add(objb);
                               
                            }
                        }
                }
                catch { }
               
            }
            Sub_Total();
            Calculate_Discount();
            Calculate_Discount_Amount();
            Calculate_Tax();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            POSMain.loadReturnOrder();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Calculate_SubTotal();
            VendorText();
            PaidAmount();
        }

        private void gridPurchases_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            Calculate_SubTotal();

            VendorText();
            PaidAmount();
        }

        private void cbx_Tax_Click(object sender, EventArgs e)
        {

            VendorText();
        }

        private void cbx_Organization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbx_branch.Focus();
            }
        }

        private void cbx_branch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbx_Party.Focus();
            }
        }

        private void cbx_Party_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Order.Focus();
            }
        }

        private void txt_Order_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mdtPurchase.Focus();
            }
        }

        private void mdtPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Invoice.Focus();
            }
        }

        private void cbx_Tax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_VendorCost.Focus();
            }
        }

        private void txt_VendorCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txt_Remarks.Focus();
            }
        }

        private void txt_Remarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbx_Payment.Focus();
            }
        }

        private void cbx_Payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Discount.Focus();
            }
        }

        private void txt_Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiscountAmount.Focus();
            }
        }

  

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Guid id;
                Guid.TryParse(cmbProduct.SelectedValue.ToString(), out id);
                loadGrid_by_ProductID(id);
            }
            catch { }

        }

        private void txt_Discount_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Discount.Text))
            {
                txt_Discount.Text = "0";
                lblDiscountPercentage.Text = "*";
            }

            try
            {
                float p = 0;
                float.TryParse(txt_Discount.Text, out p);
                if (p >= 0 && p <= 100)
                    DiscountCalculate();
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

        private void cmbProductGrid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Guid id;
                Guid.TryParse(cmbProductGrid.SelectedValue.ToString(), out id);
                loadGrid_by_ProductID(id);
            }
            catch { }
        }

        private void txtDiscountAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PaidAmount.Focus();
            }
        }

        private void txt_PaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpReturnDate.Focus();
            }
        }

        private void dtpReturnDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReturnFee.Focus();
            }
        }

        private void txtReturnFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRefund.Focus();
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        { 
                if (txtBarcode.TextLength > 3)
                {
                    DataTable dt = new DataTable();
                    BarcodeBAL obj = new BarcodeBAL();
                    BarcodeDAL objDal = new BarcodeDAL();
                    obj.ActualCode = txtBarcode.Text;
                    dt = objDal.FindProductByBarcode(obj);
                    try
                    {
                        if (dt.Rows.Count > 0)
                        {
                            for (int x = 0; x < gridPurchases.Rows.Count; x++)
                            {

                                Product_CategoryDAL objDAL = new Product_CategoryDAL();
                                cmb_ProductCategory.DataSource = objDAL.LoadAll();
                                cmb_ProductCategory.DisplayMember = "name";
                                cmb_ProductCategory.ValueMember = "id";
                                var v = gridPurchases.Rows[x].Cells["cmb_ProductCategory"].Value;
                                if (gridPurchases.Rows[x].Cells["cmb_ProductCategory"].Value == null)
                                {
                                    var ProductCategory = dt.Rows[0]["Product_Category_Id"];
                                    gridPurchases.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;


                                    var Product = dt.Rows[0]["Product_Id"];
                                    gridPurchases.Rows[x].Cells["cmb_Product"].Value = Product;
                                    txtBarcode.Clear();
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
        }
}
 

