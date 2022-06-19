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
    class DomainDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public void Add(DomainBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Domain_Insert";
                cmd.Parameters.Add("@User_id", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@Parent_id", SqlDbType.UniqueIdentifier).Value = obj.Parent_id;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;
                cmd.Parameters.Add("@Short_Name", SqlDbType.VarChar).Value = obj.Short_Name;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@Regestration_Date", SqlDbType.Date).Value = obj.Regestration_Date;
                cmd.Parameters.Add("@Expiry_Date", SqlDbType.Date).Value = obj.Expiry_Date;
                cmd.Parameters.Add("@Update_Date", SqlDbType.Date).Value = obj.Update_Date;
                cmd.Parameters.Add("@Regestrar_Name", SqlDbType.VarChar).Value = obj.Regestrar_Name;
                cmd.Parameters.Add("@Tech_Persoan_Name", SqlDbType.VarChar).Value = obj.Tech_Persoan_Name;
                cmd.Parameters.Add("@Regestration_Email", SqlDbType.VarChar).Value = obj.Regestration_Email;
                cmd.Parameters.Add("@Name_Server1", SqlDbType.VarChar).Value = obj.Name_Server1;
                cmd.Parameters.Add("@Name_Server2", SqlDbType.VarChar).Value = obj.Name_Server2;
                cmd.Parameters.Add("@Name_Server3", SqlDbType.VarChar).Value = obj.Name_Server3;
                cmd.Parameters.Add("@Name_Server4", SqlDbType.VarChar).Value = obj.Name_Server4;
                cmd.Parameters.Add("@Name_Server5", SqlDbType.VarChar).Value = obj.Name_Server5;
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
        public void Update(DomainBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Domain_Update";
                cmd.Parameters.Add("@User_id", SqlDbType.UniqueIdentifier).Value = Program.User_id;
                cmd.Parameters.Add("@Parent_id", SqlDbType.UniqueIdentifier).Value = obj.Parent_id;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@Short_Name", SqlDbType.VarChar).Value = obj.Short_Name;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@Regestration_Date", SqlDbType.Date).Value = obj.Regestration_Date;
                cmd.Parameters.Add("@Expiry_Date", SqlDbType.Date).Value = obj.Expiry_Date;
                cmd.Parameters.Add("@Update_Date", SqlDbType.Date).Value = obj.Update_Date;
                cmd.Parameters.Add("@Regestrar_Name", SqlDbType.VarChar).Value = obj.Regestrar_Name;
                cmd.Parameters.Add("@Regestrar_Name", SqlDbType.VarChar).Value = obj.Regestrar_Name;
                cmd.Parameters.Add("@Tech_Persoan_Name", SqlDbType.VarChar).Value = obj.Tech_Persoan_Name;
                cmd.Parameters.Add("@Regestration_Email", SqlDbType.VarChar).Value = obj.Regestration_Email;
                cmd.Parameters.Add("@Name_Server1", SqlDbType.VarChar).Value = obj.Name_Server1;
                cmd.Parameters.Add("@Name_Server2", SqlDbType.VarChar).Value = obj.Name_Server2;
                cmd.Parameters.Add("@Name_Server3", SqlDbType.VarChar).Value = obj.Name_Server3;
                cmd.Parameters.Add("@Name_Server4", SqlDbType.VarChar).Value = obj.Name_Server4;
                cmd.Parameters.Add("@Name_Server5", SqlDbType.VarChar).Value = obj.Name_Server5;
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
        public DataTable LoadAll(DomainBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Domain_SelectAll";
                cmd.Parameters.AddWithValue("@id", obj.Parent_id);
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

        public void Delete(OrganizationBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Organization_Delete";//by id
                cmd.Parameters.AddWithValue("@id", obj.Organization_id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //for branch
        public DataTable LoadBranch(OrganizationBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_OrganizationBranch_LoadAll ";
                cmd.Parameters.AddWithValue("@id", obj.Parent_id);
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
