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
    class AreaDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        public void Add(AreaBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AreaInsert";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.Shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.Country_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.City_id;

                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.State_id;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(AreaBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AreaUpdate";
                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.Area_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.Shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.Country_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.City_id;
                 cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.State_id;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadByCity(AreaBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AreaLoadbyID";
                cmd.Parameters.AddWithValue("@city_id", obj.City_id);
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
        public void Delete(AreaBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AreaDelete";
                cmd.Parameters.Add("@Area_id", SqlDbType.UniqueIdentifier).Value = obj.Area_id;
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
