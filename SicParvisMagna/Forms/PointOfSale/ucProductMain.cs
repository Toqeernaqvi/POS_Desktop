using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Library;
using System.Data.SqlClient;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class ucProductMain : UserControl
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
        public ucProductMain()
        {
            InitializeComponent();
            Load_Grid(Guid.Empty,"");
            Initialize();
            inti();
           // this.formMain = formMain;
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }
        public ucProductMain(Guid invoice_id)
        {
            ProductId = invoice_id;
            InitializeComponent();

            inti();
            FillProductCat_value();
         }

        //Validation Methodvar


        //KeyUP
        private void txt_Name_KeyUp(object sender, KeyEventArgs e)
        {
        }

        //ON Leave
        private void txt_Name_Leave(object sender, EventArgs e)
        {
        }
        public void inti()
        {


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
         
        public void Load_Grid(Guid CatId, string title)
        {
            ProductDAL objDal = new ProductDAL();
            DataTable dt = new DataTable();
            //   gridProducts.DataSource = 
            if (CatId != Guid.Empty || !string.IsNullOrEmpty(title))
                dt = Search();
            else
                dt = objDal.LoadAll();

            if (dt == null)
                return;
            //if (dt.Rows.Count <= 0)
            //    return;

            gridProducts.Columns.Clear();
            gridProducts.Rows.Clear();
            gridProducts.DataSource = null;
            foreach (DataColumn dc in dt.Columns)
            {
                gridProducts.Columns.Add(dc.ColumnName, dc.ColumnName);
            }
            foreach (DataRow dr in dt.Rows)
            {
                gridProducts.Rows.Add(dr.ItemArray);
            }


            

            gridProducts.Columns.Add(btn_delrow);                                        //6
            btn_delrow.HeaderText = "Edit";
            btn_delrow.Text = "✎";
            btn_delrow.Name = "btn_editrow";
            btn_delrow.UseColumnTextForButtonValue = true;
            gridProducts.Columns["btn_editrow"].Width = 50;

            gridProducts.Columns["id"].Visible = false;
            gridProducts.Columns["Product_Category_id"].Visible = false;


            if (ProductId == Guid.Empty)
                addRow();
        }
        public void ValidateRS_RM()
        {
            for (int i = 0; i < gridProducts.RowCount; i++)
            {
                try
                {
                    double RS = Convert.ToDouble(gridProducts.Rows[i].Cells[1].Value.ToString());
                }
                catch (Exception)
                {
                    gridProducts.Rows[i].Cells[1].Value = 0;
                }

                try
                {
                    double qie = Convert.ToDouble(gridProducts.Rows[i].Cells["QIE"].Value.ToString());
                }
                catch (Exception)
                {
                    gridProducts.Rows[i].Cells["QIE"].Value = 0;
                }

                try
                {
                    double opn = Convert.ToDouble(gridProducts.Rows[i].Cells["OPN"].Value.ToString());
                }
                catch (Exception)
                {
                    gridProducts.Rows[i].Cells["OPN"].Value = 0;
                }

                try
                {
                    double RS = Convert.ToDouble(gridProducts.Rows[i].Cells[2].Value.ToString());
                }
                catch (Exception)
                {
                    gridProducts.Rows[i].Cells[2].Value = 0;
                }
            }
        }
        public void addRow()
        {
            //string[] row = null;
            //if (ProductId != Guid.Empty)
            //{
            //    row = new string[] { "", "0", "0", "", "", null, null, "0" };
            //}
            //else
            //{
            //    row = new string[] { "", "0", "0", "", "", null, null, "0" };
            //}
            //if (row != null)
            //    gridProducts.Rows.Add(row);
        }
        public void CalculateTotal()
        {
            for (int i = 0; i < gridProducts.RowCount; i++)
            {
                double price = 0, quantity = 0;
                try
                {
                    price = Convert.ToDouble(gridProducts.Rows[i].Cells[3].Value.ToString());
                }
                catch (Exception)
                {
                    gridProducts.Rows[i].Cells[3].Value = 0;
                }
                try
                {
                    quantity += Convert.ToDouble(gridProducts.Rows[i].Cells[4].Value.ToString());
                }
                catch (Exception)
                {
                    gridProducts.Rows[i].Cells[4].Value = 0;
                }
                gridProducts.Rows[i].Cells[5].Value = price * quantity;
            }
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
                                SELECT [Product].Pro_id AS 'id',
                                       [Product].Product_Category_id,
                                       [Product].name AS 'Title',
                                       [Product].shortname,
                                       [Product].description,
                                       [Product].company_name AS 'Brand',
                                        [Product].formula_name  As 'Formula',
                                       Product_Category.name AS 'Category'
	                                    FROM [Product] 
                                INNER JOIN dbo.Product_Category ON Product.Product_Category_id = dbo.Product_Category.id
                                WHERE 
                                [Product].Flag = 1
                             ");
            if (ProductCategoryId != Guid.Empty)
            {
                query.Append(" AND [Product].Product_Category_id = '" + ProductCategoryId.ToString() + "'");
            }

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                query.Append(" AND [Product].name LIKE '%" + txtName.Text + "%'");
            }
          return  objDal.sqlQuery(query.ToString());
        
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
            try
            {
                if (e.ColumnIndex == gridProducts.Columns["btn_editrow"].Index)
                {
                    Guid product_id = Guid.Parse(gridProducts.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    POSMain.loadProduct(product_id, "");
                    // addRow();
                }
            }
            catch(Exception e2)
            {
              MessageBox.Show(e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            //POSMain.loadProduct(Guid.Empty,"");

            POSMain.loadProductForm();
        }

        private void gridProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Guid product_id = Guid.Parse(gridProducts.Rows[e.RowIndex].Cells["id"].Value.ToString());
            POSMain.loadProduct(product_id, "");
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
               
            Load_Grid(ProductCategoryId,txtName.Text);
        }

        private void cbxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cbxCategory.SelectedValue.ToString(), out ProductCategoryId);

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
