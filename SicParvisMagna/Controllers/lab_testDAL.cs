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
    class lab_testDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(lab_testBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_test_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj.lab_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj.test_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(lab_testBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_test_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj.lab_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj.test_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;
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

        public List<lab_testBAL> LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<lab_testBAL> listt = new List<lab_testBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_test_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lab_testBAL obj1 = new lab_testBAL();
                        float x = 0; obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        obj1.lab_id = Guid.Parse(dr["lab_id"].ToString());
                        obj1.test_id = Guid.Parse(dr["test_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
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

        public List<lab_testBAL> LoadAll()
        {
            try
            {
                //Local
                con.Close();
                SqlDataReader dr;
                List<lab_testBAL> listt = new List<lab_testBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_test_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lab_testBAL obj1 = new lab_testBAL();
                        obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        obj1.lab_id = Guid.Parse(dr["lab_id"].ToString());
                        obj1.test_id = Guid.Parse(dr["test_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
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

        public List<lab_testBAL> Search(lab_testBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<lab_testBAL> listt = new List<lab_testBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_test_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj.lab_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj.test_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lab_testBAL obj1 = new lab_testBAL();
                        float x = 0; obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        obj1.lab_id = Guid.Parse(dr["lab_id"].ToString());
                        obj1.test_id = Guid.Parse(dr["test_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
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

        public void Delete(lab_testBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_test_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable findLabTestPrice(Guid lab_id, Guid test_id)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "findLabTestPrice";
                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = lab_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = test_id;

                cmd.ExecuteScalar();
                con.Close();
                sa.SelectCommand = cmd;
                sa.Fill(dt);

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
