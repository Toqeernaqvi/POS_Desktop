using SicParvisMagna.Library;
using SicParvisMagna.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SicParvisMagna.Controllers
{
    class Sale_OrderDAL
    {
        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(SaleOrderBAL obj)
        {
            Guid id = Guid.NewGuid();

            try
            {
                //obj.id = Guid.NewGuid();
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sale_Order_Insert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@Customer_id", SqlDbType.UniqueIdentifier).Value = obj.Customer_id;
               cmd.Parameters.Add("@organization_id", SqlDbType.UniqueIdentifier).Value = obj.organization_id;
                cmd.Parameters.Add("@branch_id", SqlDbType.UniqueIdentifier).Value = obj.branch_id;
                 cmd.Parameters.Add("@t_am", SqlDbType.Float).Value = obj.total_amount;
                cmd.Parameters.Add("@s_t_am", SqlDbType.Float).Value = obj.sub_total_amount;
                cmd.Parameters.Add("@dis_am", SqlDbType.Float).Value = obj.discount_amount;
                cmd.Parameters.Add("@dis_per", SqlDbType.Int).Value = obj.discount_percentage;
                cmd.Parameters.Add("@paid_am", SqlDbType.Float).Value = obj.paid_amount;
                cmd.Parameters.Add("@rem", SqlDbType.Float).Value = obj.remaining_amount;
                cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = obj.remarks;
                cmd.Parameters.Add("@payment", SqlDbType.VarChar).Value = obj.payment_type;
                cmd.Parameters.Add("@invoice", SqlDbType.VarChar).Value = obj.Invoice_no;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
                cmd.Parameters.Add("@tax_id", SqlDbType.UniqueIdentifier).Value = obj.tax_id;
                cmd.Parameters.Add("@tax_am", SqlDbType.Float).Value = obj.tax_amount;
                cmd.Parameters.Add("@orderno", SqlDbType.VarChar).Value = obj.Order_no;
                cmd.Parameters.Add("@cashierDiscount", SqlDbType.Float).Value = obj.cashierDiscount;
                cmd.Parameters.Add("@nonvendor_am", SqlDbType.Float).Value = obj.non_vendor_cost_amount;
                cmd.Parameters.Add("@nonvendor_per", SqlDbType.Int).Value = obj.non_vendor_cost_percentage;
                cmd.Parameters.Add("@changeReturned", SqlDbType.Float).Value = obj.changeReturned;

                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.add_date;
                cmd.Parameters.Add("@adby", SqlDbType.UniqueIdentifier).Value = obj.add_by;
                cmd.Parameters.Add("@flag", SqlDbType.Bit).Value = obj.flag;




                cmd.ExecuteNonQuery();
                con.Close();
                //return obj.id;
            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //return Guid.Empty;
        }

        public void Update(SaleOrderBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sale_Order_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@organization_id", SqlDbType.UniqueIdentifier).Value = obj.organization_id;
                cmd.Parameters.Add("@branch_id", SqlDbType.UniqueIdentifier).Value = obj.branch_id;
                cmd.Parameters.Add("@customer_id", SqlDbType.UniqueIdentifier).Value = obj.Customer_id;
                cmd.Parameters.Add("@t_am", SqlDbType.Float).Value = obj.total_amount;
                cmd.Parameters.Add("@s_t_am", SqlDbType.Float).Value = obj.sub_total_amount;
                cmd.Parameters.Add("@dis_am", SqlDbType.Float).Value = obj.discount_amount;
                cmd.Parameters.Add("@dis_per", SqlDbType.Int).Value = obj.discount_percentage;
                cmd.Parameters.Add("@paid_am", SqlDbType.Float).Value = obj.paid_amount;
                cmd.Parameters.Add("@rem", SqlDbType.Float).Value = obj.remaining_amount;
                cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = obj.remarks;
                cmd.Parameters.Add("@payment", SqlDbType.VarChar).Value = obj.payment_type;
                cmd.Parameters.Add("@invoice", SqlDbType.VarChar).Value = obj.Invoice_no;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
                cmd.Parameters.Add("@tax_id", SqlDbType.UniqueIdentifier).Value = obj.tax_id;
                cmd.Parameters.Add("@tax_am", SqlDbType.Float).Value = obj.tax_amount;
                cmd.Parameters.Add("@orderno", SqlDbType.VarChar).Value = obj.Order_no;
                cmd.Parameters.Add("@cashierDiscount", SqlDbType.Float).Value = obj.cashierDiscount;
                cmd.Parameters.Add("@nonvendor_am", SqlDbType.Float).Value = obj.non_vendor_cost_amount;
                cmd.Parameters.Add("@nonvendor_per", SqlDbType.Int).Value = obj.non_vendor_cost_percentage;
                cmd.Parameters.Add("@changeReturned", SqlDbType.Float).Value = obj.changeReturned;

                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@editby", SqlDbType.UniqueIdentifier).Value = obj.edit_by;
                cmd.Parameters.Add("@flag", SqlDbType.Bit).Value = obj.flag;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sales_Order_LOADALL";
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable LoadAllById(Guid id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SaleOrder_LoadById";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public void FilterByDate(SaleOrderBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sale_Order_FilterByDate";//by date
                cmd.Parameters.AddWithValue("@date1", obj.date);
                cmd.Parameters.AddWithValue("@date2", obj.date);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void Delete(SaleOrderBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sale_Order_Delete";//by id
                cmd.Parameters.AddWithValue("@id", obj.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //for branch    `
        public DataTable LoadBranch(SaleOrderBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sale_Order_LoadByBranch";
                cmd.Parameters.AddWithValue("@branch_id", obj.branch_id);
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable LoadByStatus(string status)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SelectSaleOrder_by_Status";
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable LoadSaleOrder()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SelectSaleOrder";
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public string Tax(Guid tax_id)
        {
            string Tax = "";
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sp_Tax_SelectById]";
                cmd.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = tax_id;

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Tax = (read["TaxPercen"].ToString());

                    }
                }
            }
            finally
            {
                con.Close();
            }
            return Tax;
        }
    }
}
