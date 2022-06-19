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
    class UserEducationDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public void Add(UserEducationBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserEducation_Insert";
                cmd.Parameters.Add("@uid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = obj.Image;
                cmd.Parameters.Add("@board", SqlDbType.VarChar).Value = obj.Board;
                cmd.Parameters.Add("@Subject", SqlDbType.VarChar).Value = obj.Specilization;
                cmd.Parameters.Add("@obt", SqlDbType.VarChar).Value = obj.OBT_CGPA;
                cmd.Parameters.Add("@Total", SqlDbType.VarChar).Value = obj.Totalmarks_Cgpa;
                cmd.Parameters.Add("@percentage", SqlDbType.VarChar).Value = obj.Percentage;
                cmd.Parameters.Add("@Tmstmp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@addby", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flag", SqlDbType.VarChar).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }

        }//Add end

        public void Update(UserEducationBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserEducation_Update";
                cmd.Parameters.Add("@uid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = obj.Image;
                cmd.Parameters.Add("@board", SqlDbType.VarChar).Value = obj.Board;
                cmd.Parameters.Add("@deg", SqlDbType.VarChar).Value = obj.Specilization;
                cmd.Parameters.Add("@obt", SqlDbType.VarChar).Value = obj.OBT_CGPA;
                cmd.Parameters.Add("@Total", SqlDbType.VarChar).Value = obj.Totalmarks_Cgpa;
                cmd.Parameters.Add("@percentage", SqlDbType.VarChar).Value = obj.Percentage;
                cmd.Parameters.Add("@Tmstmp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@addby", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flag", SqlDbType.VarChar).Value = obj.Flag;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Education_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }//update end


        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserEducation_SelectAll";
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

        //////////////
        /////for branch
        public DataTable LoadByID(UserEducationBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserEducation_Getby_id";
                cmd.Parameters.AddWithValue("@id", obj.User_id);
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
        ///
        public void Delete(UserEducationBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserEducation_Delete_by_id";
                cmd.Parameters.AddWithValue("@id", obj.Education_id);
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
