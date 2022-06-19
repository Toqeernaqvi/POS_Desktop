﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BasicCRUD.Controllers;
using SicParvisMagna.Controllers;
using SicParvisMagna.Library;
using Telerik.WinControls.UI;


namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class ucReturnOrder : UserControl
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
        public ucReturnOrder()
        {
            InitializeComponent();
            loadParty();
        }
        private void loadParty()
        {
            PurchasePartyDAL objDAL = new PurchasePartyDAL();
            cbx_Party.DataSource = objDAL.LoadAll();
            cbx_Party.ValueMember = "party_id";
            cbx_Party.DisplayMember = "name";
            cbx_Party.SelectedIndex = -1;

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
            gridPurchase.Columns[0].IsVisible = false;

            gridPurchase.Columns[1].Width = 100;
            gridPurchase.Columns[2].Width = 200;
            gridPurchase.Columns[3].Width = 250;
            gridPurchase.Columns[4].Width = 120;


            gridPurchase.Columns.Add(btn_delrow);                                        //6
            btn_delrow.HeaderText = "Edit";
            btn_delrow.UseDefaultText = true;
            btn_delrow.DefaultText = "✎";
            btn_delrow.Name = "btn_editrow";
            btn_delrow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridPurchase.Columns["btn_editrow"].Width = 50;
        }
        private void loadGrid()
        {
       

            Purchase_Order_ReturnDAL obj = new Purchase_Order_ReturnDAL();

            if (rdAll.Checked)
            {
                gridPurchase.Columns.Clear();
                gridPurchase.DataSource = obj.LoadAll();
                setGrid();

            }
            if (rdPaid.Checked)
            {
                gridPurchase.Columns.Clear();

                gridPurchase.DataSource = obj.LoadByStatus("Paid but items not returned");
                setGrid();
            }
            if (rdPaidAndReturned.Checked)
            {
                gridPurchase.Columns.Clear();

                gridPurchase.DataSource = obj.LoadByStatus("Paid and returned");
                setGrid();
            }
            if (rdPending.Checked)
            {
                gridPurchase.Columns.Clear();

                gridPurchase.DataSource = obj.LoadByStatus("Pending");
                setGrid();
            }
            if (rdReturned.Checked)
            {
                gridPurchase.Columns.Clear();

                gridPurchase.DataSource = obj.LoadByStatus("Items returned but not paid");
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

            if (gridPurchase.Rows.Count > 0)
                if (gridPurchase.CurrentCell.ColumnIndex == 5)
                {
                    Guid id = Guid.Empty;
                    id = Guid.Parse(gridPurchase.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    POSMain.loadReturningbyID(id);

                }
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            POSMain.loadReturning();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridPurchase.Columns.Clear();

            try
            {
                string query = @" 
                                SELECT Distinct (dbo.Purchase_Order_Return.id) ,dbo.Purchase_Order_Return.Order_no , convert(varchar, dbo.Purchase_Order_Return.date, 106) as Date	,dbo.Purchase_Order_Return.status,dbo.PurchaseParty.name
                                FROM dbo.Purchase_Order_Return INNER JOIN dbo.Purchase_Order_Return_Details
                                ON Purchase_Order_Return.id = dbo.Purchase_Order_Return_Details.Purchase_Order_Return_id
                                INNER JOIN dbo.PurchaseParty ON Purchase_Order_Return.party_id = dbo.PurchaseParty.party_id";
                                                bool whereAdded = false;

                if (!string.IsNullOrEmpty(cbx_Party.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   dbo.Purchase_Order_Return.party_id like '%" + cbx_Party.SelectedValue.ToString() + "%'";
                        whereAdded = true;
                    }

                }
                else
                    query += "Where dbo.Purchase_Order_Return.Date between '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "'And'" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "'";


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

                gridPurchase.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            setGrid();

        }

        private void ucReturnOrder_Load(object sender, EventArgs e)
        {
            pgURL = "Manage Purchase  Returns";
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


            }

           else if (AccountType == "Accountant")
            {
                //for  Branch Admin


            }
            else
            {

                POSMain.loadAccessDenied();
            }
        }
    }
}
