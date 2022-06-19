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
    class CredentialDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public void Add(CredentialBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Credential_Table_Insert";
                cmd.Parameters.Add("@User_id", SqlDbType.UniqueIdentifier).Value =obj.User_id;
                cmd.Parameters.Add("@Organization_Id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@Domain_id", SqlDbType.VarChar).Value = obj.Domain_id;
                cmd.Parameters.Add("@primary_email", SqlDbType.VarChar).Value = obj.primary_email;
                cmd.Parameters.Add("@Recovery_Email", SqlDbType.VarChar).Value = obj.Recovery_Email;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = obj.Password;
                cmd.Parameters.Add("@Timestamp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@Flag", SqlDbType.TinyInt).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            }
        }

        public void Update(CredentialBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Credential_Update";
                cmd.Parameters.Add("@User_id", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@Organization_Id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@Domain_id", SqlDbType.VarChar).Value = obj.Domain_id;
                cmd.Parameters.Add("@primary_email", SqlDbType.VarChar).Value = obj.primary_email;
                cmd.Parameters.Add("@Recovery_Email", SqlDbType.VarChar).Value = obj.Recovery_Email;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = obj.Password;
                cmd.Parameters.Add("@Timestamp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@Flag", SqlDbType.TinyInt).Value = obj.Flag;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }//update end
        public DataTable LoadAll(CredentialBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Credential_Table_SelectAll";
                cmd.Parameters.AddWithValue("@id", obj.Organization_id);
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

        public void Delete(CredentialBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Credential_Table_Delete_by_Id";//by id
                cmd.Parameters.AddWithValue("@id", obj.id);
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
