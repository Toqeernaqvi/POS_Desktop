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
    class AccountDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public  Guid Add(AccountBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Accounts_Insert";
                cmd.Parameters.Clear();
                obj.Account_id = Guid.NewGuid();
                cmd.Parameters.Add("@Account_id", SqlDbType.UniqueIdentifier).Value = obj.Account_id;
                cmd.Parameters.Add("@T", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;
                cmd.Parameters.Add("@D", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@tm", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@st", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }

            return obj.Account_id;
            //
        }
        public void Update(AccountBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Accounts_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@T", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;
                cmd.Parameters.Add("@D", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@tm", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@st", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.Flag;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Account_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }//update end

        public DataTable LoadDomainTypeAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SelectAll_DomainTypes";
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
        public DataTable LoadExpertiesTypeAll(AssignExpertiesBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AssignExperties_LoadAll ";
                cmd.Parameters.AddWithValue("@id", obj.UserId);
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
                cmd.CommandText = "sp_Accounts_SelectAll";
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



        public void Delete(AccountBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.CommandText = "sp_Accounts_Delete_by_Id";
                cmd.Parameters.AddWithValue("@id", obj.Account_id);
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
