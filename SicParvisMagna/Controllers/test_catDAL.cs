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
    class test_catDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        public void Add(test_catBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_cat_insert";
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;

                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@orgid", SqlDbType.UniqueIdentifier).Value = obj.OrgID;

                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;
                //cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                //cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Add_by", SqlDbType.UniqueIdentifier).Value = obj.Add_by;
                cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;




                cmd.ExecuteNonQuery();
                con.Close();


            }

         
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(test_catBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_cat_update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@orgid", SqlDbType.UniqueIdentifier).Value = obj.OrgID;

                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;
                //cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                //cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Edit_By", SqlDbType.UniqueIdentifier).Value = obj.Edit_By;
                cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_Date;
                cmd.ExecuteNonQuery();
                con.Close();



                //Web

                //MySqlDataAdapter da = new MySqlDataAdapter();
                //mycon.Open();
                //mycmd.Connection = mycon;
                //mycmd.CommandText = "UPDATE TBMD_City SET City.Web = False WHERE City.id = " + obj.City_id;
                //mycmd.ExecuteNonQuery();
                //mycmd.Dispose();
                //mycon.Close();
            }

            
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
                cmd.CommandText = "test_cat_getAll";
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

        public DataTable Loadbybranch(test_catBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.CommandText = "test_cat_loadbybranch";
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

        public void Delete(test_catBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_cat_delete";
                cmd.Parameters.AddWithValue("@id", obj.id);
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
