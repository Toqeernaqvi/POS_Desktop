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
    class _1BranchDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
        // private MySqlConnection mycon = new MYSQLCon().getCon();
        //private MySqlCommand mycmd = new MySqlCommand();

        public void Add(_1BranchBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "branch_Insert";
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = obj.Username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@inst_id", SqlDbType.UniqueIdentifier).Value = obj.inst_id;
              //  cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
               // cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;


                cmd.ExecuteNonQuery();
                con.Close();


            }

          
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(_1BranchBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "branch_Update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = obj.Username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@inst_id", SqlDbType.UniqueIdentifier).Value = obj.inst_id;
               // cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                //cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Edit_By", SqlDbType.VarChar).Value = obj.Edit_By;
                cmd.Parameters.Add("@EditDate", SqlDbType.DateTime).Value = obj.Edit_Date;


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
        public List<_1BranchBAL> LoadbyId(_1BranchBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<_1BranchBAL> listt = new List<_1BranchBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Branch_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@branch_id", SqlDbType.UniqueIdentifier).Value = obj.branch_id;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        _1BranchBAL obj1 = new _1BranchBAL();
                        float x = 0; obj1.branch_id = Guid.Empty;
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.desc = dr["desc"].ToString();
                        obj1.phone = dr["phone"].ToString();
                        obj1.email = dr["email"].ToString();
                        obj1.address = dr["address"].ToString();
                        obj1.STRN = dr["STRN"].ToString();
                        obj1.NTN = dr["NTN"].ToString();
                        obj1.inst_id = Guid.Empty;
                        listt.Add(obj1);
                    }
                }
                dr.Close();
                con.Close();
               // return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<_1BranchBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<_1BranchBAL> listt = new List<_1BranchBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Branch_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        _1BranchBAL obj1 = new _1BranchBAL();
                        //  float x = 0;
                        obj1.branch_id = Guid.Empty;
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.desc = dr["desc"].ToString();
                        obj1.phone = dr["phone"].ToString();
                        obj1.email = dr["email"].ToString();
                        obj1.address = dr["address"].ToString();
                        obj1.STRN = dr["STRN"].ToString();
                        obj1.NTN = dr["NTN"].ToString();
                        obj1.inst_id = Guid.Empty;
                        listt.Add(obj1);
                    }
                }
                dr.Close();
                con.Close();
                return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable LoadAll_DT()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Branch_LOADALL";
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
        public DataTable Search(_1BranchBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "branch_search";
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = obj.Username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@Edit_By", SqlDbType.VarChar).Value = obj.Edit_By;
                cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
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
        public void Delete(_1BranchBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "branch_Delete";
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
                cmd.CommandText = "Branch_getIDbytitle";
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
    }
}


    


