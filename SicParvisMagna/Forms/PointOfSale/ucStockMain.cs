using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SicParvisMagna.Library;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class ucStockMain : UserControl
    {
        int TotalrowIndex = 0;
        List<Guid> removed_product_id = new List<Guid>();
        Product_CategoryBAL Product_Category_OBJ = new Product_CategoryBAL();
        Product_CategoryDAL Product_CategoryDAL_db = new Product_CategoryDAL();
        ProductBAL Product_obj = new ProductBAL();
        ProductDAL Product_db = new ProductDAL();
        DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btn_delrow = new DataGridViewButtonColumn();
        ValidationRegex objvr = new ValidationRegex();
        private Guid ProductId = Guid.Empty;
        private Guid ProductCategoryId = Guid.Empty;
        private FormMain formMain;
        private System.Timers.Timer timer;
        public ucStockMain()
        {
            InitializeComponent();
            Load_Grid(Guid.Empty,"");
            Initialize();
            // this.formMain = formMain;
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }
        public ucStockMain(Guid invoice_id)
        {
            ProductId = invoice_id;
            InitializeComponent();

             FillProductCat_value();
            FillProducts_in_grid();
        }

        
 
        public void Initialize()
        {

            loadCbxCategories();
           // Load_Grid();
        }
        public void loadCbxCategories()
        {
            ProductCategoryDAL objDal = new ProductCategoryDAL();
            DataTable dt = objDal.LoadAll();
            cbxCategory.DataSource = dt;
            cbxCategory.DisplayMember = "name";
            cbxCategory.ValueMember = "id";
            cbxCategory.SelectedIndex = -1;
           // cbxCategory.AutoCompleteCustomSource = objDal.LoadAll();

        }
        public void FillProductCat_value()
        {
            //txt_CategoryName.Text = Product_CategoryDAL_db.LoadAll().Where(m => m.Product_Category_id == id).FirstOrDefault().name;
        }
        public void FillProducts_in_grid()
        {

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
        public void Load_Grid(Guid CatId, string title)
        {
            StockDAL objDal = new StockDAL();
            DataTable dt = new DataTable();
            //   gridProducts.DataSource = 
            if (CatId != Guid.Empty || !string.IsNullOrEmpty(title))
            {
                 dt = Search();
                if (dt.Rows.Count == 0)
                {
                    //timer = new System.Timers.Timer(1000); //adjust time based on time required to enter the last 3 chars 
                    //timer.Enabled = true;
                    //lblMsg.Text = "Stock doesn't Exist for " + cbxCategory.Text;
                   // MessageBox.Show("Stock doesn't Exist for " + cbxCategory.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                     
                      // throw new System.ApplicationException("Stock doesn't Exist for Selected item");
                     

                   
            }
            else
                dt = objDal.LoadStock();

            if (dt == null)
            {

                return;

            }
            //if (dt.Rows.Count <= 0)
            //    return;

            gridStock.Columns.Clear();
            gridStock.Rows.Clear();
            gridStock.DataSource = null;
            foreach (DataColumn dc in dt.Columns)
            {
                gridStock.Columns.Add(dc.ColumnName, dc.ColumnName);
            }
            foreach (DataRow dr in dt.Rows)
            {
                gridStock.Rows.Add(dr.ItemArray);
            }


            

            gridStock.Columns.Add(btn_delrow);                                        //6
            btn_delrow.HeaderText = "Edit";
            btn_delrow.Text = "✎";
            btn_delrow.Name = "btn_editrow";
            btn_delrow.UseColumnTextForButtonValue = true;
            gridStock.Columns["btn_editrow"].Width = 50;

          gridStock.Columns["Product_id"].Visible = false;
          gridStock.Columns["Product_Category_id"].Visible = false;

 
        }
         private void ClearAll()
        {
            ProductCategoryId = Guid.Empty;
            ProductId = Guid.Empty;
            txtName.Text = "";
            cbxCategory.SelectedIndex = -1;
            

        }
        private DataTable Search()
        {
             ProductDAL objDal = new ProductDAL();
             StringBuilder query = new StringBuilder(200);

             query.Append(@"
                               Select distinct (Product.name) as Items,   
            --Purchase_Order.Order_no,
 dbo.getTotalStockQuantity(Stock.Product_id, '+', GETDATE())
 --date where condition

-
 dbo.getTotalStockQuantity(Stock.Product_id, '-', GETDATE())
 --date where condition

    as Quantity,
 Stock.Product_Category_id ,Stock.Product_id

from Stock
inner join Product on Product.Pro_id = stock.Product_id
--left join Purchase_order on  Purchase_order.id = Stock.POS_id
group by product.name,stock.Product_Category_id,stock.Product_id,Product.Pro_id,stock.Quantity
                                                              ");
            if (ProductCategoryId != Guid.Empty)
            {
                query.Append(" Having [Stock].Product_Category_id = '" + ProductCategoryId.ToString() + "'");
            }

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                if (ProductCategoryId == Guid.Empty)
                    query.Append(" Having [Product].name LIKE '%" + txtName.Text + "%'");
                else
                    query.Append(" AND [Product].name LIKE '%" + txtName.Text + "%'");
            }
            return objDal.sqlQuery(query.ToString());

            StockDAL obj = new StockDAL();
            DataTable dt = new DataTable();
            dt = obj.LoadStockDataByID(ProductId);
            return dt;
        
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
            if (e.ColumnIndex == gridStock.Columns["btn_editrow"].Index)
            {
                Guid Product_id = Guid.Empty;
                    Guid.TryParse(gridStock.Rows[e.RowIndex].Cells["Product_id"].Value.ToString(), out Product_id);
                POSMain.loadStock(Product_id, "");
               // addRow();
            }
             
        }

        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }
        

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
            Load_Grid(Guid.Empty,"");
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            POSMain.loadStock(Guid.Empty,"");

             
        }

        private void gridProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //Guid product_id = Guid.Parse(gridStock.Rows[e.RowIndex].Cells["id"].Value.ToString());
            //POSMain.loadProduct(product_id, "");
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
               
            Load_Grid(ProductCategoryId,txtName.Text);
        }

        private void cbxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cbxCategory.SelectedValue.ToString(), out ProductCategoryId);
            Guid.TryParse(cbxCategory.SelectedValue.ToString(), out ProductId);

            Load_Grid(ProductCategoryId, txtName.Text);
        }

        private void txtName_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {

            Load_Grid(ProductCategoryId, txtName.Text);
        }
    }
}
