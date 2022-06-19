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
    class AssignExpertiesDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public void Add(AssignExpertiesBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AssignExperties_Insert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ExpertiesId", SqlDbType.UniqueIdentifier).Value = obj.ExpertiesId;
                cmd.Parameters.Add("@UserId", SqlDbType.UniqueIdentifier).Value = obj.UserId;
                cmd.Parameters.Add("@Timestamp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@Addby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@Flag", SqlDbType.VarChar).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }

        }//Add end

        public DataTable LoadByUserID(AssignExpertiesBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AssignExperties_LoadByUserID";
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
        //
        public DataTable LoadByUser(AssignExpertiesBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AssignExperties_LoadAll";
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

        //Delete 
        public void Delete(AssignExpertiesBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AssignExperties_delete ";
                cmd.Parameters.AddWithValue("@id", obj.AssignId);
                cmd.Parameters.AddWithValue("@uid", obj.ExpertiesId);
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
