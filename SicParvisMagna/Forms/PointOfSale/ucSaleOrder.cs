using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BasicCRUD.Controllers;
using SicParvisMagna.Controllers;
using SicParvisMagna.Library;
using Telerik.WinControls.UI;


namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class ucSaleOrder : UserControl
    {
     

        private POSMain formMain;

        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public static bool PerAdd;
        public static bool PerDel;
        public static string pgURL;
        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;
        private string AccountType = null;
        GridViewCommandColumn btn_newrow = new GridViewCommandColumn();
        GridViewCommandColumn btn_delrow = new GridViewCommandColumn();
        public ucSaleOrder()
        {
            InitializeComponent();
            loadCustomer();
        }
        private void loadCustomer()
        {
            UserDAL objDAL = new UserDAL();
            cbx_Customer.DataSource = objDAL.LoadAll();
            cbx_Customer.ValueMember = "user_id";
            cbx_Customer.DisplayMember = "user_name";
            cbx_Customer.SelectedIndex = -1;

        }
        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void rdPending_CheckedChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void rdPaid_CheckedChanged(object sender, EventArgs e)
        {
            loadGrid();
        }


        private void rdRecieved_CheckedChanged(object sender, EventArgs e)
        {
            loadGrid();

        }

        private void rdPaidAndRecieved_CheckedChanged(object sender, EventArgs e)
        {
            loadGrid();
        }
        private void setGrid()
        {
            gridSales.Columns[0].IsVisible = false;

            gridSales.Columns[1].Width = 100;
            gridSales.Columns[2].Width = 200;
            gridSales.Columns[3].Width = 250;
            gridSales.Columns[4].Width = 120;


            gridSales.Columns.Add(btn_delrow);                                        //6
            btn_delrow.HeaderText = "Edit";
            btn_delrow.UseDefaultText = true;
            btn_delrow.DefaultText = "✎";
            btn_delrow.Name = "btn_editrow";
            btn_delrow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridSales.Columns["btn_editrow"].Width = 50;
        }
        private void loadGrid()
        {


            Sale_OrderDAL obj = new Sale_OrderDAL();

            if (rdAll.Checked)
            {
                gridSales.Columns.Clear();
                gridSales.DataSource = obj.LoadAll();
                setGrid();

            }
            if (rdPaid.Checked)
            {
                gridSales.Columns.Clear();

                gridSales.DataSource = obj.LoadByStatus("Paid but not Sold");
                setGrid();
            }
            if (rdPaidAndSold.Checked)
            {
                gridSales.Columns.Clear();

                gridSales.DataSource = obj.LoadByStatus("Paid and sold");
                setGrid();
            }
            if (rdPending.Checked)
            {
                gridSales.Columns.Clear();

                gridSales.DataSource = obj.LoadByStatus("Pending");
                setGrid();
            }
            if (rdSold.Checked)
            {
                gridSales.Columns.Clear();

                gridSales.DataSource = obj.LoadByStatus("Sold but not Paid");
                setGrid();
            }

          //  gridPurchase col = gridPurchase.Columns.FindByUniqueNameSafe("ColumnName");
            //if (col != null)
            //{
           
            //}




        }

        private void gridPurchase_CellClick(object sender, GridViewCellEventArgs e)

        {

         //   for (int x = 0; x < gridPurchase.RowCount; x++)
          //  {


            //   }

            if (gridSales.Rows.Count > 0)
                if (gridSales.CurrentCell.ColumnIndex == 5)
                {
                    Guid id = Guid.Empty;
                    id = Guid.Parse(gridSales.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    POSMain.loadSalesbyID(id);

                }
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            POSMain.loadSales();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridSales.Columns.Clear();

            try
            {
                string query = @" 
                                SELECT Distinct (dbo.Sales_Order.id) ,dbo.Sales_Order.Order_no , convert(varchar, dbo.Sales_Order.date, 106) as Date	,dbo.Sales_Order.status,dbo.Users.User_name as 'Customer'
                                FROM dbo.Sales_Order INNER JOIN dbo.Sale_Order_Details
                                ON Sales_Order.id = dbo.Sale_Order_Details.Sale_Order_id
                                INNER JOIN dbo.Users ON  Users.User_id =  Sales_Order.Customer_id";
                                                bool whereAdded = false;

                if (!string.IsNullOrEmpty(cbx_Customer.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   Sales_Order.Customer_id like '%" + cbx_Customer.SelectedValue.ToString() + "%'";
                        whereAdded = true;
                    }

                }
                else
                    query += "Where dbo.Sales_Order.Date between '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "'And'" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "'";


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

                gridSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            setGrid();

        }

        private void ucReturnOrder_Load(object sender, EventArgs e)
        {
           // pgURL = "Manage  Sales";
           // //for Account Type
           // try { AccountType = (PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Account_type"].ToString()); }
           // catch (Exception r)
           // {
           //     MessageBox.Show("Error:" + r.Message);
           // }

           // if (AccountType == "Super Admin")
           // {


           // }

           //else if (AccountType == "Branch Admin")
           // {


           // }

           //else if (AccountType == "Accountant")
           // {
           //     //for  Branch Admin


           // }
           // else
           // {

                //POSMain.loadAccessDenied();
            //}
        }
    }
}
