using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Controls
{
    public partial class ucAdvanceSearch : UserControl
    {
        public ucAdvanceSearch()
        {
            InitializeComponent();
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
        private void LoadSGridBrand(string value)
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

        private void cmbSCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid id;
            Guid.TryParse(cmbSCategory.SelectedValue.ToString(), out id);
            LoadSProducts(id);
        }

        private void btnCmbCategory_Click(object sender, EventArgs e)
        {
            cmbSCategory.SelectedIndex = -1;
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
            if (cmbSCategory.SelectedIndex < 0)
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

        private void txtSBarcode_TextChanged(object sender, EventArgs e)
        {

            //DataTable dt = new DataTable();
            //DataTable dt1 = new DataTable();
            //int barcode = 0;
            //BarcodeBAL obj = new BarcodeBAL();
            //BarcodeDAL objDal = new BarcodeDAL();
            //BarcodeGenerateBAL objBAL = new BarcodeGenerateBAL();
            //BarcodeGenerateDAL objGDAL = new BarcodeGenerateDAL();
            //obj.ActualCode = txtSBarcode.Text;
            //int.TryParse(txtSBarcode.Text, out barcode);
            //objBAL.UPC_Barcode = barcode;
            //dt = objDal.FindProductByBarcode(obj);
            //dt1 = objGDAL.FindProductByBarcodeGenerate(objBAL);

            //try
            //{
            //    if (dt.Rows.Count > 0)
            //    {
            //        for (int x = 0; x < gridSearchResult.Rows.Count; x++)
            //        {

            //            Product_CategoryDAL objDAL = new Product_CategoryDAL();
            //             cmbSCategory.DataSource = objDAL.LoadAll();
            //            cmbSCategory.DisplayMember = "name";
            //            cmbSCategory.ValueMember = "id";
            //            var v = gridSearchResult.Rows[x].Cells["cmb_ProductCategory"].Value;
            //            if (gridSearchResult.Rows[x].Cells["cmb_ProductCategory"].Value == null)
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

        private void cmbSBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value;
            value = cmbSBrand.SelectedValue.ToString();
            LoadSGridBrand(value);
        }

        private void btnCmbBrand_Click(object sender, EventArgs e)
        {
            cmbSBrand.SelectedIndex = -1;

        }

        private void txtSfourmula_TextChanged(object sender, EventArgs e)
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
    }
}
