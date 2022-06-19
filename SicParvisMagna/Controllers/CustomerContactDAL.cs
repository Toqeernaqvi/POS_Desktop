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
    class CustomerContactDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public Guid Add(CustomerContactBAL obj)
        {
            Guid ContID = Guid.Empty;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerContact_Insert";

                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = obj.Number;
                cmd.Parameters.Add("@descrip", SqlDbType.VarChar).Value = obj.Descrip;

                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;

                ContID = (Guid)cmd.ExecuteScalar();
                con.Close();
                return ContID;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            return ContID;

        }
        public void Update(CustomerContactBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerContact_Update";
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = obj.Number;
                cmd.Parameters.Add("@descrip", SqlDbType.VarChar).Value = obj.Descrip;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.EditBy;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.ContID;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
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
                cmd.CommandText = "sp_CustomerContact_SelectAll";
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
        public void Delete(CustomerContactBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerContact_Delete_by_id";
                cmd.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = obj.ContID;
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
