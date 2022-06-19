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
    class BarcodeGenerateDAL
    {
        ///Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public void Add(BarcodeGenerateBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Insert_BarcodeGenerate";
                cmd.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = obj.user_id;
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = obj.Pro_id;
                cmd.Parameters.Add("@Cat_id", SqlDbType.UniqueIdentifier).Value = obj.Cat_id;
                cmd.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = obj.Quantity;
                cmd.Parameters.Add("@Unit", SqlDbType.VarChar).Value = obj.Unit;
                cmd.Parameters.Add("@Order_No", SqlDbType.VarChar).Value = obj.Order_No;
                cmd.Parameters.Add("@AddDate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@flag", SqlDbType.Bit).Value = obj.Flag;
                cmd.Parameters.Add("@Price", SqlDbType.Int).Value = obj.Price;


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
                cmd.CommandText = "LoadAll_BarcodeGenerate";
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
        public DataTable FindProductByBarcodeGenerate(BarcodeGenerateBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_FindProduct_BarcodeGenerate";
                cmd.Parameters.AddWithValue("@Barocde", obj.UPC_Barcode);
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable LoadByOrderNo(BarcodeGenerateBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadByOrder_BarcodeGenerate";
                cmd.Parameters.AddWithValue("@Order_no", obj.Order_No);
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
