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
    class StateDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(StateBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "State_Add";
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@Shortname", SqlDbType.VarChar).Value = obj.Shortname;
                cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@Country_id", SqlDbType.UniqueIdentifier).Value = obj.Country_id;
                cmd.Parameters.Add("@Add_By", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void Update(StateBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "State_Update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
               
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@Shortname", SqlDbType.VarChar).Value = obj.Shortname;
                cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@Country_id", SqlDbType.UniqueIdentifier).Value = obj.Country_id;
                cmd.Parameters.Add("@Edit_By", SqlDbType.VarChar).Value = obj.Edit_By;
                cmd.Parameters.Add("@Edit_Date", SqlDbType.DateTime).Value = obj.Edit_Date;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable LoadAll(StateBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "State_LoadAll";
                cmd.Parameters.AddWithValue("@id", obj.Country_id);
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
        public DataTable LoadByCountry(StateBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "State_LoadByCountry";
                cmd.Parameters.AddWithValue("@Country_id", obj.Country_id);//combox 
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
        public void Delete(StateBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "State_Delete";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.id;
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
