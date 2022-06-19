using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class FormPrice : Form
    {
        private Guid ProductId = Guid.Empty;
        private Guid ProductCategoryId = Guid.Empty;
        private Guid Pricing_id = Guid.Empty;
        private bool condition = true;

        public FormPrice()
        {
            InitializeComponent();
        }
        public FormPrice(Guid Cat_id , Guid Pro_id)
        {
            InitializeComponent();
            loadCmbCategories();
            loadCmbProduct();
            ProductCategoryId = Cat_id;
            ProductId = Pro_id;
           
        }
        public void loadCmbCategories()
        {
            Product_CategoryDAL objDal = new Product_CategoryDAL();
            DataTable dt = objDal.LoadAll();
            cmbCategory.DataSource = objDal.LoadAll();
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
            cmbCategory.SelectedIndex = -1;
            // cmbCategory.AutoCompleteCustomSource = objDal.LoadAll();

        }
        public void loadCmbProduct()
        {
            ProductDAL objDal = new ProductDAL();
            DataTable dt = objDal.LoadAll();
            cmbProduct.DataSource = objDal.LoadAll();
            cmbProduct.DisplayMember = "name";
            cmbProduct.ValueMember = "id";
            cmbProduct.SelectedIndex = -1;
            // cmbCategory.AutoCompleteCustomSource = objDal.LoadAll();

        }
        public void clearAll()
        {
            cmbCategory.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
            txtPrice.Text = "";
             btnSave.LabelText = "Save";
        }
        public void loadCmbProducts(Guid id)
        {
            ProductDAL objDAL = new ProductDAL();
            cmbProduct.DataSource = objDAL.LoadProdcutbyCategory(id);
            cmbProduct.ValueMember = "Pro_id";
            cmbProduct.DisplayMember = "name";
            cmbProduct.SelectedIndex = -1;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
             PricingBAL objb = new PricingBAL();
            PricingDAL obj = new PricingDAL();
            //For Pricing Table
            float tempPrice = 0;
            DataTable dt = new DataTable();
            objb.ProID = ProductId;
            objb.CatID = ProductCategoryId;
            float.TryParse(txtPrice.Text, out tempPrice);

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
                    objb.price = float.Parse(txtPrice.Text.ToString());

                    objb.Pricing_id = Pricing_id;
                    objb.status = "Inactive";
                    objb.Flag = 0;
                    obj.Update(objb);

                    //Add new price

                    if (condition == true)
                    {
                        objb.Pricing_id = Guid.Empty;
                        objb.price = float.Parse(txtPrice.Text.ToString());
                        objb.status = "Active";
                        objb.Flag = 1;
                        obj.Add(objb);
                        condition = false;

                    }
           
                    clearAll();
                }
            }




        }

        private void FormPrice_Load(object sender, EventArgs e)
        {
             LoadGrid();
            loadCmbCategories();
            loadCmbProducts(ProductCategoryId);
            cmbCategory.SelectedValue = ProductCategoryId;
            cmbProduct.SelectedValue = ProductId;
        }

        private void cmbProduct_SelectionChangeCommitted(object sender, EventArgs e)

        {

            Guid.TryParse(cmbProduct.SelectedValue.ToString(), out ProductId);

            PricingDAL obj = new PricingDAL();
            DataTable dt = new DataTable();

            dt = obj.FindPrice_Pricing(ProductId, ProductCategoryId);
            if (dt.Rows.Count != 0)
            {
                var priceD = dt.Rows[0]["Price"];
                txtPrice.Text = priceD.ToString();
                btnSave.LabelText = "Update";

            }


        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Guid.TryParse(cmbCategory.SelectedValue.ToString(), out ProductCategoryId);
                loadCmbProducts(ProductCategoryId);
            }
            catch { }
        }
        private void LoadGrid()
        {
            PricingDAL obj = new PricingDAL();
           DataTable dt = obj.FindPrice_ProductId(ProductId);
            gridPrice.DataSource = dt;
            

        }
    }
}