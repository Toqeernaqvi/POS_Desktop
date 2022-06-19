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
    public class ClassDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
        // private MySqlConnection mycon = new MYSQLCon().getCon();
        //private MySqlCommand mycmd = new MySqlCommand();

        public void Add(ClassBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "classes_Insert";

                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@urdu_title", SqlDbType.VarChar).Value = obj.urdu_title;
                cmd.Parameters.Add("@fee", SqlDbType.VarChar).Value = obj.fee;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@organizationid", SqlDbType.UniqueIdentifier).Value = obj.organizationid;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@class_level", SqlDbType.VarChar).Value = obj.class_level;
                cmd.Parameters.Add("@addby", SqlDbType.UniqueIdentifier).Value = obj.Add_by;
                cmd.Parameters.Add("@tmp", SqlDbType.DateTime).Value = obj.timestamp;


                cmd.ExecuteNonQuery();
                con.Close();


            }

            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        public void Update(ClassBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "classes_Update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@urdu_title", SqlDbType.VarChar).Value = obj.urdu_title;
                cmd.Parameters.Add("@fee", SqlDbType.VarChar).Value = obj.fee;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@organizationid", SqlDbType.UniqueIdentifier).Value = obj.organizationid;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@class_level", SqlDbType.VarChar).Value = obj.class_level;
                cmd.Parameters.Add("@editby", SqlDbType.UniqueIdentifier).Value = obj.Edit_by;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.Edit_date;


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

            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                cmd.CommandText = "classesGetAll";
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

        public DataTable Search(ClassBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "classes_Search";
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@urdu_title", SqlDbType.VarChar).Value = obj.urdu_title;
                cmd.Parameters.Add("@fee", SqlDbType.VarChar).Value = obj.fee;

                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
              
                cmd.Parameters.Add("@addby", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@tmp", SqlDbType.DateTime).Value = obj.timestamp;
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
        public DataTable Loadbyinstid(ClassBAL obj)
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
        public void Delete(ClassBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "classes_Delete";
                cmd.Parameters.AddWithValue("@id", obj.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public int GetId_byTITLE(string title)
        {
            try
            {
                SqlDataReader dr;
                int count = 0, id = 0;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "classes_getIDbytitle";
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        count++;
                        if (count == 1)
                        {
                            id = (int)dr["id"];
                        }

                    }
                }

                dr.Close();
                con.Close();

                return id;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return 0;
        }
        public ClassBAL LoadbyClassID(Guid id)
        {
            //string rt = "";
            ClassBAL classes = new ClassBAL();
            try
            {
                SqlDataReader dr;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Distinct * From classes where id=" + id + ";";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        classes.class_level = dr["class_level"].ToString();
                        classes.title = dr["title"].ToString();

                    }
                }

                dr.Close();
                con.Close();

                return classes;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        ////////////
        ///
        public DataTable LoadByDepartment(Guid DepartmentId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "classes_Get_By_Department";
                cmd.Parameters.Add("@department_id", SqlDbType.UniqueIdentifier).Value = DepartmentId;
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



    }

}

