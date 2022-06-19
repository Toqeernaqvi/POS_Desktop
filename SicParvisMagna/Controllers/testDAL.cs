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
    class testDAL
    {

        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon(); private SqlCommand cmd = new SqlCommand();

        public void Add(testBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(testBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj.test_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public List<testBAL> LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<testBAL> listt = new List<testBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        testBAL obj1 = new testBAL();
                        float x = 0; obj1.test_id = Guid.Parse(dr["test_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.status = (bool)dr["status"];
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

        public List<testBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<testBAL> listt = new List<testBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        testBAL obj1 = new testBAL();
                        float x = 0; obj1.test_id = Guid.Parse(dr["test_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.status = (bool)dr["status"];
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

        public List<testBAL> Search(testBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<testBAL> listt = new List<testBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj.test_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        testBAL obj1 = new testBAL();
                        float x = 0; obj1.test_id = Guid.Parse(dr["test_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.status = (bool)dr["status"];
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

        public void Delete(testBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "test_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj.test_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
