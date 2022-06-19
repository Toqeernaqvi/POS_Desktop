using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicCRUD.Models;
using SicParvisMagna.Models;
using SicParvisMagna.Library;


namespace SicParvisMagna.Controllers
{
   
        class SubjectDAL
        {
            //Connection
            private SqlConnection con = new SQLCon().getCon();
            private SqlCommand cmd = new SqlCommand();

            //MySQL Objects
            //Connection
            // private MySqlConnection mycon = new MYSQLCon().getCon();
            //private MySqlCommand mycmd = new MySqlCommand();

            public void Add(SubjectBAL obj)
            {
                try
                {
                    //Local

                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "subjects_Insert";
                    cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@UT", SqlDbType.VarChar).Value = obj.urdu_title;
                cmd.Parameters.Add("@org", SqlDbType.UniqueIdentifier).Value = obj.orgID;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.classid;
                    cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                 
                    cmd.Parameters.Add("@stat", SqlDbType.TinyInt).Value = obj.status;
                
                //    cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                  //  cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                    cmd.Parameters.Add("@Add_by", SqlDbType.UniqueIdentifier).Value = obj.Add_by;
                    cmd.Parameters.Add("@Add_date", SqlDbType.DateTime).Value = obj.Add_date;





                    cmd.ExecuteNonQuery();
                    con.Close();


                }

               
                catch (SqlException e1)
                {
                    MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            public void Update(SubjectBAL obj)
            {
                try
                {

                    //Local

                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "subjects_Update";
                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@UT", SqlDbType.VarChar).Value = obj.urdu_title;
                cmd.Parameters.Add("@org", SqlDbType.UniqueIdentifier).Value = obj.orgID;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.classid;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;

                cmd.Parameters.Add("@stat", SqlDbType.TinyInt).Value = obj.status;
             
                //    cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                //  cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Edit_by", SqlDbType.UniqueIdentifier).Value = obj.Edit_by;
                cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_date;
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




        public DataTable LoadByBranch(SubjectBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "subject_GetbyBranch";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
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



        public DataTable LoadAll()
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "subjects_GetAll";
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

        public DataTable LoadByBranch(ClassBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "class_GetbyBranch";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
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





        public void Delete(SubjectBAL obj)
            {
                try
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "subjects_Delete";
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

