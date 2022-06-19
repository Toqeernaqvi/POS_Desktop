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
    class SupplierDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public Guid Add(SupplierBAL obj)
        {
            Guid User_id = Guid.Empty;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Supplier_Insert";
                cmd.Parameters.Add("@First_name", SqlDbType.VarChar).Value = obj.First_name;
                cmd.Parameters.Add("@Last_name", SqlDbType.VarChar).Value = obj.Last_name;
                cmd.Parameters.Add("@User_name", SqlDbType.VarChar).Value = obj.User_name;
                cmd.Parameters.Add("@Father_name", SqlDbType.VarChar).Value = obj.First_name;
                cmd.Parameters.Add("@Cnic", SqlDbType.VarChar).Value = obj.Cnic;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = obj.contact;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = obj.Phone;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@Adress", SqlDbType.VarChar).Value = obj.Adress;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = obj.Gender;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = obj.DOB;
                cmd.Parameters.Add("@Account_type", SqlDbType.VarChar).Value = obj.Account_type;
                cmd.Parameters.Add("@Timestamp", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@Flag", SqlDbType.VarChar).Value = obj.Flag;

                User_id = (Guid)cmd.ExecuteScalar();
                con.Close();
                return User_id;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            return User_id;

        }
        public void Update(SupplierBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Supplier_Update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@First_name", SqlDbType.VarChar).Value = obj.First_name;
                cmd.Parameters.Add("@Last_name", SqlDbType.VarChar).Value = obj.Last_name;
                cmd.Parameters.Add("@User_name", SqlDbType.VarChar).Value = obj.User_name;
                cmd.Parameters.Add("@Father_name", SqlDbType.VarChar).Value = obj.First_name;
                cmd.Parameters.Add("@Cnic", SqlDbType.VarChar).Value = obj.Cnic;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = obj.contact;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = obj.Phone;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@Adress", SqlDbType.VarChar).Value = obj.Adress;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = obj.Gender;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = obj.DOB;
                cmd.Parameters.Add("@Account_type", SqlDbType.VarChar).Value = obj.Account_type;
                cmd.Parameters.Add("@Timestamp", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.EditBy;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@Flag", SqlDbType.VarChar).Value = obj.Flag;
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
                cmd.CommandText = "sp_Supplier_SelectAll";
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

        public void Delete(SupplierBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Supplier_Delete_by_id";
                cmd.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = obj.User_id;
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
