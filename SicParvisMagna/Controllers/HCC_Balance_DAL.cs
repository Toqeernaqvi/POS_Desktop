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
//using MySql.Data.MySqlClient;

namespace SicParvisMagna.Controllers
{
    class HCC_Balance_DAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
    //    private MySqlConnection mycon = new MYSQLCon().getCon();
      //  private MySqlCommand mycmd = new MySqlCommand();
        public void CloseMonth(HCC_Balance_BAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[HCC_Balance_ClosingMonth]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.date;

                cmd.ExecuteNonQuery();
                con.Close();


            }

  //          catch (MySqlException e)
    //        {
      //          MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Add(HCC_Balance_BAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[HCC_Balance_Insert]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@amount", SqlDbType.Float).Value = obj.amount;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = obj.type;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.date;
                cmd.Parameters.Add("@add_date", SqlDbType.DateTime).Value = obj.add_date;

                cmd.ExecuteNonQuery();
                con.Close();


            }

       //     catch (MySqlException e)
       //     {
       //         MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //     }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                cmd.CommandText = "[HCC_Balance_LoadAll]";
                cmd.Parameters.Clear();
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
        public DataTable LoadbyID(AreaBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AreaLoadbyID";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.City_id;
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
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@area_id", obj.Area_id);
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
