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
    class UserExperienceDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        //
        public void Add(UserExperienceBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserExperience_insert";
                cmd.Parameters.Add("@uid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = obj.Image;
                cmd.Parameters.Add("@jobTitle", SqlDbType.VarChar).Value = obj.Job_title;
                cmd.Parameters.Add("@Cmpn", SqlDbType.VarChar).Value = obj.Company_name;
                cmd.Parameters.Add("@Sdt", SqlDbType.Date).Value = obj.Start_date;
                cmd.Parameters.Add("@Edt", SqlDbType.Date).Value = obj.End_date;
                cmd.Parameters.Add("@Sdes", SqlDbType.VarChar).Value = obj.Start_designation;
                cmd.Parameters.Add("@Edes", SqlDbType.VarChar).Value = obj.End_designation;
                cmd.Parameters.Add("@resign", SqlDbType.VarChar).Value = obj.Resign;
                cmd.Parameters.Add("@Tmstmp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@Addby", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            //

        }//Add end
        public void Update(UserExperienceBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserExperience_Update";
                cmd.Parameters.Add("@uid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = obj.Image;
                cmd.Parameters.Add("@jobTitle", SqlDbType.VarChar).Value = obj.Job_title;
                cmd.Parameters.Add("@Cmpn", SqlDbType.VarChar).Value = obj.Company_name;
                cmd.Parameters.Add("@Sdt", SqlDbType.Date).Value = obj.Start_date;
                cmd.Parameters.Add("@Edt", SqlDbType.Date).Value = obj.End_date;
                cmd.Parameters.Add("@Sdes", SqlDbType.VarChar).Value = obj.Start_designation;
                cmd.Parameters.Add("@Edes", SqlDbType.VarChar).Value = obj.End_designation;
                cmd.Parameters.Add("@resign", SqlDbType.VarChar).Value = obj.Resign;
                cmd.Parameters.Add("@Tmstmp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@Addby", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.Flag;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Experience_id;
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
                cmd.CommandText = "sp_UserExperience_SelectAll";
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public DataTable LoadByID(UserExperienceBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserExperience_SelectAll_Getby_id";
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
        ///
        public void Delete(UserExperienceBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UserExperience_Delete_by_id";
                cmd.Parameters.AddWithValue("@id", obj.Experience_id);
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
