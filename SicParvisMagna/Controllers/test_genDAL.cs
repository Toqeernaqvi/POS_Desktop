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
    class test_genDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(test_genBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_gen_insert";
                cmd.Parameters.Add("@test_cat_id", SqlDbType.UniqueIdentifier).Value = obj.test_cat_id;
                cmd.Parameters.Add("@test_title", SqlDbType.VarChar).Value = obj.test_title;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.test_desc;
           //     cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@orgid", SqlDbType.UniqueIdentifier).Value = obj.OrgID;

                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
         
                cmd.Parameters.Add("@Add_by", SqlDbType.UniqueIdentifier).Value = obj.Add_by;
                cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;
                cmd.Parameters.Add("@dued", SqlDbType.DateTime).Value = obj.Due_Date;
                cmd.Parameters.Add("@s_d", SqlDbType.DateTime).Value = obj.Start_time;
                cmd.Parameters.Add("@e_d", SqlDbType.DateTime).Value = obj.End_time;
                cmd.Parameters.Add("@r_d", SqlDbType.DateTime).Value = obj.Relaxation_time;



                cmd.ExecuteNonQuery();
                con.Close();


            }

           
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(test_genBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_gen_update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@test_cat_id", SqlDbType.UniqueIdentifier).Value = obj.test_cat_id;
                cmd.Parameters.Add("@test_title", SqlDbType.VarChar).Value = obj.test_title;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.test_desc;
             //   cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;
                cmd.Parameters.Add("@orgid", SqlDbType.UniqueIdentifier).Value = obj.OrgID;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
               
                cmd.Parameters.Add("@Edit_By", SqlDbType.UniqueIdentifier).Value = obj.Edit_By;
                cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_Date;
                cmd.Parameters.Add("@dued", SqlDbType.DateTime).Value = obj.Due_Date;
                cmd.Parameters.Add("@s_d", SqlDbType.DateTime).Value = obj.Start_time;
                cmd.Parameters.Add("@e_d", SqlDbType.DateTime).Value = obj.End_time;
                cmd.Parameters.Add("@r_d", SqlDbType.DateTime).Value = obj.Relaxation_time;
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
                cmd.CommandText = "test_gen_getAll";
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



        public DataTable LoadbyTestCAT(test_genBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_gen_byTESTCAT";

                cmd.Parameters.Add("@test_cat_id", SqlDbType.UniqueIdentifier).Value = obj.test_cat_id;
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



        public void Delete(test_genBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_gen_delete";
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
