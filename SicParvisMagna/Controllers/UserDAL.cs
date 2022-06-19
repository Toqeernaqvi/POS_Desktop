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
    class UserDAL
    {


        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public Guid Add(UserBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Users_Insert";
                
                cmd.Parameters.Add("@First_name", SqlDbType.VarChar).Value = obj.First_name;
                cmd.Parameters.Add("@Last_name", SqlDbType.VarChar).Value = obj.Last_name;
                cmd.Parameters.Add("@User_name", SqlDbType.VarChar).Value = obj.User_name;
                cmd.Parameters.Add("@Father_name", SqlDbType.VarChar).Value = obj.Father_name;
                cmd.Parameters.Add("@Cnic", SqlDbType.VarChar).Value = obj.Cnic;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = obj.contact;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = obj.Phone;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@Area_id", SqlDbType.UniqueIdentifier).Value = obj.Area_id;
                  cmd.Parameters.Add("@Adress", SqlDbType.VarChar).Value = obj.Adress;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = obj.Gender;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = obj.DOB;
                cmd.Parameters.Add("@Account_type", SqlDbType.VarChar).Value = obj.Account_type;
                cmd.Parameters.Add("@Timestamp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@Flag", SqlDbType.VarChar).Value = obj.Flag;
                cmd.Parameters.Add("@FirstTimeLogin", SqlDbType.VarChar).Value = obj.FirstTimeLogin;
                cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
                cmd.Parameters.Add("@Employee_id", SqlDbType.UniqueIdentifier).Value = obj.Employee_id;
                obj.User_id = Guid.NewGuid();
                cmd.Parameters.Add("@userId", SqlDbType.UniqueIdentifier).Value = obj.User_id;

                cmd.ExecuteNonQuery();
                 
                // cmd.ExecuteNonQuery();
                //  var command = con.CreateCommand();
                //  command.CommandText = "Select "
                
                con.Close();
                return obj.User_id;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                return Guid.Empty;
            }

        }
        public void Update(UserBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Users_Update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@First_name", SqlDbType.VarChar).Value = obj.First_name;
                cmd.Parameters.Add("@Last_name", SqlDbType.VarChar).Value = obj.Last_name;
                cmd.Parameters.Add("@User_name", SqlDbType.VarChar).Value = obj.User_name;
                cmd.Parameters.Add("@Father_name", SqlDbType.VarChar).Value = obj.Father_name;
                cmd.Parameters.Add("@Cnic", SqlDbType.VarChar).Value = obj.Cnic;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = obj.contact;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = obj.Phone;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@Area_id", SqlDbType.UniqueIdentifier).Value = obj.Area_id;

                cmd.Parameters.Add("@Adress", SqlDbType.VarChar).Value = obj.Adress;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = obj.Gender;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = obj.DOB;
                cmd.Parameters.Add("@Account_type", SqlDbType.VarChar).Value = obj.Account_type;
                cmd.Parameters.Add("@Timestamp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@Flag", SqlDbType.VarChar).Value = obj.Flag;
                cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
                cmd.Parameters.Add("@Employee_id", SqlDbType.UniqueIdentifier).Value = obj.Employee_id;




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
                cmd.CommandText = "sp_Users_SelectAll";
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
        //--------------------------================------------------------------------
        public DataTable LoadByUser(UserBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.CommandText = "SelectByUserId";
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

        public void Delete(UserBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Users_Delete_by_id";
                cmd.Parameters.AddWithValue("@id", obj.User_id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        //Login 
        //public void Login(UserBAL obj)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    SqlDataReader dr;
        //    try
        //    {
        //        con.Open();
        //        cmd.Connection = con;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "MatchLogin";
        //        cmd.Parameters.Add("@Em", SqlDbType.VarChar).Value = obj.User_name;
        //        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
        //        dr = cmd.ExecuteReader();
        //        if (dr.HasRows)
        //        {//dt.Rows.Count > 0
        //            dr.Read(); // read first row 
        //            Int32 userId = dr.GetInt32(0); // dt.Rows[0]["UserId"]
        //            MessageBox.Show("User login Successfully   " + userId);
        //            Program.UserId = userId;
        //            FormMain frm = new FormMain("Administrator", 1);
        //            frm.Show();
                  
        //            //this.Hide();

        //        }
           public DataTable Login(UserBAL obj)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlDataReader dr;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MatchLogin";
                cmd.Parameters.Add("@Em", SqlDbType.VarChar).Value = obj.User_name;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
          
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
                //if (dr.HasRows)
                //{//dt.Rows.Count > 0
                //    dr.Read(); // read first row 
                //    Int32 userId = dr.GetInt32(0); // dt.Rows[0]["UserId"]
                //    MessageBox.Show("User login Successfully   " + userId);
                //    Program.UserId = userId;
                //    FormMain frm = new FormMain("Administrator", 1);
                //    frm.Show();
                  
                //    //this.Hide();

             

         
          

        }
        //Reset Password
        public void resetPassword(UserBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "resetPassword";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.User_id;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("PAssword Updated Successfully");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }

        }

        //update old password

        public void updateOldPassword(UserBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateWithOldPassword";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.User_id;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                cmd.Parameters.Add("@oldPassword", SqlDbType.VarChar).Value = obj.oldPassword;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("PAssword Updated Successfully");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }

        }
    }
}
