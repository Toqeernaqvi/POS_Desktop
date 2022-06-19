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
    class CityDAL
    {

        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
        // private MySqlConnection mycon = new MYSQLCon().getCon();
        //private MySqlCommand mycmd = new MySqlCommand();

        public void Add(CityBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "City_Add";
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@Shortname", SqlDbType.VarChar).Value = obj.Shortname;
                cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@Country_id", SqlDbType.UniqueIdentifier).Value = obj.Country_id;
                cmd.Parameters.Add("@Add_By", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.State_id;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(CityBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "City_Update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@Shortname", SqlDbType.VarChar).Value = obj.Shortname;
                cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@Country_id", SqlDbType.UniqueIdentifier).Value = obj.Country_id;
                cmd.Parameters.Add("@Edit_By", SqlDbType.VarChar).Value = obj.Edit_By;
                cmd.Parameters.Add("@Edit_Date", SqlDbType.DateTime).Value = obj.Edit_Date;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.State_id;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadByState(CityBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "City_LoadBy_State";
                cmd.Parameters.AddWithValue("@id", obj.State_id);
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
        public void Delete(CityBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "City_Delete";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
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
