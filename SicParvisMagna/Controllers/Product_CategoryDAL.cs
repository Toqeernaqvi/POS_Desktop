
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
    class Product_CategoryDAL
    {
        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(Product_CategoryBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Category_Insert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@parent_id", SqlDbType.UniqueIdentifier).Value = obj.Parent_id;

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(Product_CategoryBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Category_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@parent_id", SqlDbType.UniqueIdentifier).Value = obj.Parent_id;

                cmd.Parameters.Add("@Product_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Category_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Product_Category_id", SqlDbType.UniqueIdentifier).Value = obj;
                cmd.ExecuteNonQuery();//execute
                con.Close();
                da.SelectCommand = cmd;// dataadapter
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
                //Local
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();


                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Category_LOADALL";
                cmd.Parameters.Clear();

                cmd.ExecuteNonQuery();//execute
                con.Close();
                da.SelectCommand = cmd;// dataadapter
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        //for  SubCategory
        public DataTable ProductCategory_LoadAll_byParent(Product_CategoryBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = " ProductCategory_LoadAll_byParent";
                cmd.Parameters.AddWithValue("@id", obj.Parent_id);
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

        public DataTable LoadCategoryWithParent()
        {
            DataRow workRow;
            DataTable dt1 = new DataTable();
            try
            {
                //Local
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();


                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadCategoryWithParent";
                cmd.Parameters.Clear();

                cmd.ExecuteNonQuery();//execute
                con.Close();
                da.SelectCommand = cmd;// dataadapter
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<Product_CategoryBAL> Search(string str)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<Product_CategoryBAL> listt = new List<Product_CategoryBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Category_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Product_Category_id", SqlDbType.UniqueIdentifier).Value = str;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = str;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = str;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = str;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Product_CategoryBAL obj1 = new Product_CategoryBAL();
                        float x = 0; obj1.Product_Category_id = Guid.Parse(dr["Product_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.AddDate = Convert.ToDateTime(dr["AddDate"].ToString());
                        obj1.Addby = dr["Addby"].ToString();
                        obj1.EditDate = Convert.ToDateTime(dr["EditDate"].ToString());
                        obj1.Editby = dr["Editby"].ToString();
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

        public void Delete(Product_CategoryBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Category_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Product_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_id;
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
