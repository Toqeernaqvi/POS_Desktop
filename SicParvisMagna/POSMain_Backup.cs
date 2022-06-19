using EMS_VS15U2.Reports;
using SicParvisMagna.Forms;
using SicParvisMagna.Reports.UserControls;
using SicParvisMagna.Forms.Hospital;
using SicParvisMagna.Forms.Hospital.Lab;
using SicParvisMagna.Forms.Hospital.Medicine;
using SicParvisMagna.Forms.Hospital.Parties;
using SicParvisMagna.Forms.Hospital.Parties.Party_invoice;
using SicParvisMagna.Forms.Hospital.Patient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using BasicCRUD.Models;
using BasicCRUD.Controllers;
using SicParvisMagna.Library;
using SicParvisMagna.Forms.Inventory;
using SicParvisMagna.Forms.ChartOfAccounts;
using SicParvisMagna.Forms.PointOfSale;
using SicParvisMagna.Reports;
using SicParvisMagna.Reports_Form;
 
namespace SicParvisMagna
{
    public partial class POSMain : Form
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

		public POSMain(String username, Guid userid)
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
		public static void loadCityForm()
		{
			formContainer.Controls.Clear();
			ucAddCity form = new ucAddCity();

			formHeading.Text = "Manage Cities";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}
		public static void loadPurchaseAdvancedForm()
		{
			//formContainer.Controls.Clear();
			//ucPurchaseAdvanced form = new ucPurchaseAdvanced();

			//formHeading.Text = "Manage Purchases";
			//form.Dock = DockStyle.Fill;

			//formContainer.Controls.Add(form);
		}
		public static void loadPurchaseIndex()
		{
			formContainer.Controls.Clear();
			ucPurchaseIndex form = new ucPurchaseIndex();

			formHeading.Text = "Purchases";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}
		public static void loadPurchasing()
		{
			formContainer.Controls.Clear();
			//ucPurchasing form = new ucPurchasing();
          ucPurchase form = new ucPurchase();
			formHeading.Text = "Manage Purchase";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}
        public static void loadPurchasingbyID(Guid id)
        {
            formContainer.Controls.Clear();

            //ucPurchasing form = new ucPurchasing();
            ucPurchase form = new ucPurchase(id);
            formHeading.Text = " Manage Purchases";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadReturningbyID(Guid id)
        {
            formContainer.Controls.Clear();
            ucReturn form = new ucReturn(id);

            formHeading.Text = "Manage Purchase Returns";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadSalesbyID(Guid id)
        {
            formContainer.Controls.Clear();
            ucSales form = new ucSales(id);

            formHeading.Text = "Manage Sales";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        public static void loadReturning()
		{
			formContainer.Controls.Clear();
			ucReturn form = new ucReturn();

			formHeading.Text = "Manage Purchase Returns";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}

        public static void loadSaleReturningbyID(Guid id)
        {
            formContainer.Controls.Clear();
            ucReturnSale form = new ucReturnSale(id);

            formHeading.Text = "Manage Sale Returns";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadReturningSale()
        {
            formContainer.Controls.Clear();
            ucReturnSale form = new ucReturnSale();


            formHeading.Text = "Manage Sale Returns";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadPurchaseForm()
		{
			//formContainer.Controls.Clear();
			//ucPurchasing form = new ucPurchasing();

			//formHeading.Text = "Manage Purchase";
			//form.Dock = DockStyle.Fill;

			//formContainer.Controls.Add(form);
			//formContainer.Controls.Clear();
			//ucPurchase form = new ucPurchase();

			//formHeading.Text = "Manage Purchases";
			//form.Dock = DockStyle.Fill;

			//formContainer.Controls.Add(form);
		}
		//public static void loadPurchasing()
		//{
		//	//formContainer.Controls.Clear();
		//	//ucPurchasing form = new ucPurchasing();

		//	//formHeading.Text = "Manage Purchase";
		//	//form.Dock = DockStyle.Fill;

		//	//formContainer.Controls.Add(form);
		//}
		public static void loadOrganizationIndex()
		{
			formContainer.Controls.Clear();
			ucOrganizationIndex form = new ucOrganizationIndex();
			form.Dock = DockStyle.Fill;
			formHeading.Text = "Organization";
			formContainer.Controls.Add(form);
		}
		public static void loadOrganization()
		{
			formContainer.Controls.Clear();
			ucAddOrganization form = new ucAddOrganization();
			form.Dock = DockStyle.Fill;
			formHeading.Text = "Manage Organization";
			formContainer.Controls.Add(form);
		}
        public static void loadPurchaseOrder()
        {
            formContainer.Controls.Clear();
            ucPurchaseOrder form = new ucPurchaseOrder();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Purchase Orders";
            formContainer.Controls.Add(form);
        }

        public static void loadSales()
        {
            formContainer.Controls.Clear();
            ucSales form = new ucSales();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Sales";
            formContainer.Controls.Add(form);
        }
        public static void loadStockMain()
        {
            formContainer.Controls.Clear();
            ucStockMain form = new ucStockMain();
            formHeading.Text = "Manage Stocks";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        //
       
        public static void loadReturnOrder()
        {
            formContainer.Controls.Clear();
            ucReturnOrder form = new ucReturnOrder();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Return Orders";
            formContainer.Controls.Add(form);
        }
        public static void loadReturnSaleOrder()
        {
            formContainer.Controls.Clear();
            ucReturnOrderSale form = new ucReturnOrderSale();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Sales Return Orders";
            formContainer.Controls.Add(form);
        }

        public static void loadSaleOrder()
        {
            formContainer.Controls.Clear();
            ucSaleOrder form = new ucSaleOrder();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Sales Orders";
            formContainer.Controls.Add(form);
        }
        public static void loadBranch()
		{
			formContainer.Controls.Clear();
			ucAddBranch form = new ucAddBranch();
			form.Dock = DockStyle.Fill;
			formHeading.Text = "Manage Branch";
			formContainer.Controls.Add(form);
		}
		public static void loadCountryForm()
		{
			formContainer.Controls.Clear();
			ucAddCountry form = new ucAddCountry();
			form.Dock = DockStyle.Fill;
			formHeading.Text = "Manage Country";
			formContainer.Controls.Add(form);
		}
		public static void loadStateForm()
		{
			formContainer.Controls.Clear();
			ucAddState form = new ucAddState();
			formHeading.Text = "Manage States";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}
		public static void loadAreaForm()
		{
			formContainer.Controls.Clear();
			ucAddArea form = new ucAddArea();
			formHeading.Text = "Manage Areas";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}

		private void btn_User_Click(object sender, EventArgs e)
		{
			formContainer.Controls.Clear();
			ucAddUsers form = new ucAddUsers();
			form.Dock = DockStyle.Fill;
			formContainer.Controls.Add(form);
			lblFormHeading.Text = "Users";
		}

		private void btnHeaderLogout_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormLogin frm = new FormLogin();
			frm.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
			Environment.Exit(0);
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
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

		private void btn_Home_Click(object sender, EventArgs e)
		{

		}
		public static void loadlocation()
		{
			formContainer.Controls.Clear();
			//ucLocation form = new ucLocation();
			//formHeading.Text = "Manage Location";
			//form.Dock = DockStyle.Fill;

			//formContainer.Controls.Add(form);
		}
		private void btn_Location_Click(object sender, EventArgs e)
		{
			//loadlocation();
			loadLocationIndex();
		}
		public static void loadProduct(Guid id,string status)
		{
            formContainer.Controls.Clear();
            ucProduct form;
            if (id == Guid.Empty)
                form = new ucProduct();
            else
                form = new ucProduct(id, status);

            formHeading.Text = "Manage Products & Stock";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadStock(Guid id, string status)
        {
            formContainer.Controls.Clear();
            ucStock form;
            if (id == Guid.Empty)
                form = new ucStock();
            else
                form = new ucStock(id, status);

            formHeading.Text = "Manage Stock";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }


        public static void loadProductForm( )
        {
            formContainer.Controls.Clear();
            // ucPOSProduct form = new ucPOSProduct();
            ucProduct form = new ucProduct();

            formHeading.Text = "Manage Products";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadCategory()
        {
            formContainer.Controls.Clear();
            ucProductCategory form = new ucProductCategory();
           
            formHeading.Text = "Manage Categories";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadProductMain()
        {
            formContainer.Controls.Clear();
            ucProductMain form = new ucProductMain();
            formHeading.Text = "Products List";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        private void btn_Product_Click(object sender, EventArgs e)
		{
			loadProductMain();
		}

		private void Btn_PartyInvoice_Click(object sender, EventArgs e)
		{

			formContainer.Controls.Clear();
			ucInvoice form = new ucInvoice();
			formHeading.Text = "Manage Party Invoice";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}

       public  static  void loadPartyForm()
        {

            formContainer.Controls.Clear();
            ucProductParty form = new ucProductParty();
            formHeading.Text = "Manage Party ";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
		 
		public static void loadreport()
		{
			formContainer.Controls.Clear();
			ucReports form = new ucReports();
			formHeading.Text = "Manage Reports";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}

		private void btnReports_Click(object sender, EventArgs e)
		{
			loadreport();
		}
		public static void loadBarcode()
		{
			formContainer.Controls.Clear();
			BarcodeForm form = new BarcodeForm();
            form.TopLevel = false;
			formHeading.Text = "Barcode";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}
        public static void BarcodeGenerate()
        {
            formContainer.Controls.Clear();
            BarcodeGenerate form = new BarcodeGenerate();
           
            formHeading.Text = "Barcode";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadGenerateBarcode()
		{
			formContainer.Controls.Clear();
			ucGenerateBarcode form = new ucGenerateBarcode();

			formHeading.Text = "Generate Barcode";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}

        public static void loadAccessDenied()
        {
            formContainer.Controls.Clear();
            ucAccessDenied form = new ucAccessDenied();

            formHeading.Text = "Access Denied";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadLocationIndex()
		{
			formContainer.Controls.Clear();
			ucLocationIndex form = new ucLocationIndex();

			formHeading.Text = "Location";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}
		public static void loadFormBarcode()
		{
			formContainer.Controls.Clear();
			ucBarcode form = new ucBarcode();

			formHeading.Text = "Manage Barcode";
			form.Dock = DockStyle.Fill;

			formContainer.Controls.Add(form);
		}
		private void btn_Barcode_Click(object sender, EventArgs e)
		{
			loadFormBarcode();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void btn_Product_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHeaderProfile_Click(object sender, EventArgs e)
        {

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void btnLoadCategories_Click(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void btn_Purchase_Click(object sender, EventArgs e)
		{
			loadPurchaseIndex();
		}

		private void btnStock_Click(object sender, EventArgs e)
		{

		}

		private void btnSales_Click(object sender, EventArgs e)
		{
            //this.Hide();
            //CashMain frm = new CashMain(username, userid);
            //frm.Show();
            loadSales();
		}

		private void btnOrganization_Click(object sender, EventArgs e)
		{
			loadOrganizationIndex();
		}

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            loadPurchaseOrder();
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            loadStockMain();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSetting f = new FormSetting();
            f.Show();
        }

        
    }
}
