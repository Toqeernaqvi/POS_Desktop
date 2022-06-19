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
    class teachersDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
        // private MySqlConnection mycon = new MYSQLCon().getCon();
        //private MySqlCommand mycmd = new MySqlCommand();
        public void Add(teachersBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "teachers_insert";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@fathername", SqlDbType.VarChar).Value = obj.fathername;
                cmd.Parameters.Add("@mobile", SqlDbType.VarChar).Value = obj.mobile;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@orgid", SqlDbType.UniqueIdentifier).Value = obj.OrganizationId;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;
                cmd.Parameters.Add("@adress", SqlDbType.VarChar).Value = obj.adress;
                cmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = obj.cnic;
                //cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.classid;
                //cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = obj.subjectid;
                //cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = obj.sectionid;
                cmd.Parameters.Add("@d_b", SqlDbType.DateTime).Value = obj.d_b;
                cmd.Parameters.Add("@img", SqlDbType.VarChar).Value = obj.img;

                cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;
                cmd.Parameters.Add("@gend", SqlDbType.VarChar).Value = obj.gender;



                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(teachersBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "teachers_update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@fathername", SqlDbType.VarChar).Value = obj.fathername;
                cmd.Parameters.Add("@mobile", SqlDbType.VarChar).Value = obj.mobile;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@orgid", SqlDbType.UniqueIdentifier).Value = obj.OrganizationId;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;
                cmd.Parameters.Add("@adress", SqlDbType.VarChar).Value = obj.adress;
                cmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = obj.cnic;
                //cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.classid;
                //cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = obj.subjectid;
                //cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = obj.sectionid;
                cmd.Parameters.Add("@d_b", SqlDbType.DateTime).Value = obj.d_b;
                cmd.Parameters.Add("@img", SqlDbType.VarChar).Value = obj.img;


                cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Edit_By", SqlDbType.VarChar).Value = obj.Edit_By;
                cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_Date;
                cmd.Parameters.Add("@gend", SqlDbType.VarChar).Value = obj.gender;
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


        public DataTable LoadAllNameAndIds()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "teachers_LoadName";
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
                cmd.CommandText = "teachers_getAll";
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

        public void Delete(teachersBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "teachers_delete";
                cmd.Parameters.AddWithValue("@id", obj.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public int GetId_byname(string teach)
        {
            try
            {
                SqlDataReader dr;
                int count = 0, id = 0;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "teachers_getIDbyName";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = teach;
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


        public DataTable LoadByBranch(teachersBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "teachers_getbybranch";
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
