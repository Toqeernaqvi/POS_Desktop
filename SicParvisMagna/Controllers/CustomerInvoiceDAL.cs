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
    class CustomerInvoiceDAL
    {

        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public Guid Add(CustomerInvoiceBAL obj)
        {
            Guid CusIvID = Guid.Empty;
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerInvoice_Insert";

                cmd.Parameters.Add("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;

                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = obj.Price;
                cmd.Parameters.Add("@qty", SqlDbType.VarChar).Value = obj.Qty;


                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@tms", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;

                CusIvID = (Guid)cmd.ExecuteScalar();
                con.Close();
                return CusIvID;

            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return CusIvID;
        }
        public void Update(CustomerInvoiceBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerInvoice_Update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.CusIvID;
                cmd.Parameters.Add("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;

                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = obj.Price;
                cmd.Parameters.Add("@qty", SqlDbType.VarChar).Value = obj.Qty;


                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@tms", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;


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
                cmd.CommandText = "sp_CustomerInvoice_SelectAll";
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
        public DataTable LoadByCountry(CustomerInvoiceBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerInvoice_LoadByProduct";
                cmd.Parameters.AddWithValue("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
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
        public void Delete(CustomerInvoiceBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerInvoice_Delete_by_id";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.CusIvID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
