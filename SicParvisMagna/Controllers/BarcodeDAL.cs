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
    class BarcodeDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        public void Add(BarcodeBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Barocde_Insert";
                cmd.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = obj.product_id;
                cmd.Parameters.Add("@ProductCategory_id", SqlDbType.UniqueIdentifier).Value = obj.ProductCategory_id;
                cmd.Parameters.Add("@ActualCode", SqlDbType.VarChar).Value = obj.ActualCode;
                cmd.Parameters.Add("@BarcodeType", SqlDbType.VarChar).Value = obj.BarcodeType;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@Addby", SqlDbType.UniqueIdentifier).Value = obj.AddBy;
                cmd.Parameters.Add("@AddDate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@Flag", SqlDbType.Bit).Value = obj.Flag;

                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(BarcodeBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Barcode_Update";
                cmd.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = obj.product_id;
                cmd.Parameters.Add("@ProductCategory_id", SqlDbType.UniqueIdentifier).Value = obj.ProductCategory_id;
                cmd.Parameters.Add("@ActualCode", SqlDbType.VarChar).Value = obj.ActualCode;
                cmd.Parameters.Add("@BarcodeType", SqlDbType.VarChar).Value = obj.BarcodeType;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@Editby", SqlDbType.UniqueIdentifier).Value = obj.EditBy;
                cmd.Parameters.Add("@EditDate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@Flag", SqlDbType.Bit).Value = obj.Flag;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadByProduct(BarcodeBAL  obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Barcode_LoadByProduct";
                cmd.Parameters.AddWithValue("@product_id", obj.product_id);
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

        public DataTable FindProductByBarcode(BarcodeBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_FindProduct_Barcode";
                cmd.Parameters.AddWithValue("@Barocde", obj.ActualCode);
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


        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Barcode_LoadAll";
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
    }
}
