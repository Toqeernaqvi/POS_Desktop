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
    class ProductCategoryDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public Guid Add(ProductCategoryBAL obj)
        {
            Guid ProCatID = Guid.Empty;
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ProductCategory_Insert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@catid", SqlDbType.UniqueIdentifier).Value = obj.CatID;
                cmd.Parameters.Add("@tms", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                ProCatID = (Guid)cmd.ExecuteScalar();
                con.Close();
                return ProCatID;


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return ProCatID;
        }

        public void Update(ProductCategoryBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ProductCategory_Update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.ProCatID;
                cmd.Parameters.Add("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@catid", SqlDbType.UniqueIdentifier).Value = obj.CatID;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.EditBy;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable LoadAll()
        {
            Guid ProductCategoryId = Guid.Empty;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ProductCategory_SelectAll";
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);


 
                string name = null;
                string name2 = null;
                DataTable dt1 = new DataTable();

                 //
                for (int x = 0; x < dt.Rows.Count; x++)
                {

                    Guid.TryParse(dt.Rows[x]["id"].ToString(), out ProductCategoryId);
                    name = dt.Rows[x]["name"].ToString();
                    try
                    {
                        dt1 =  GetCategoryHerarichy(ProductCategoryId);
                        name2 = dt1.Rows[0]["name"].ToString();
                        if (name != name2)
                        {
                            dt.Rows[x]["name"] = name2;
                            //    dt.Rows[x].Cells["cmb_ProductCategory"].Value = ProductCategory;

                        }
                    }
                    catch (Exception e) { e.Message.ToString(); }

                }
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable LoadByProduct(ProductCategoryBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ProductCategory_LoadByProduct";
                cmd.Parameters.AddWithValue("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
               // cmd.CommandText = "sp_ProductCategory_LoadByProduct";
                cmd.Parameters.AddWithValue("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
               // cmd.CommandText = "sp_ProductCategory_LoadByProduct";
                cmd.Parameters.AddWithValue("@catid", SqlDbType.UniqueIdentifier).Value = obj.CatID;
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
        public DataTable LoadByProductNCategory(ProductCategoryBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sp_ProductCategory_LoadByProNCat]";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
                cmd.Parameters.AddWithValue("@catid", SqlDbType.UniqueIdentifier).Value = obj.CatID;
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

        public DataTable  GetCategoryHerarichy(Guid id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getCatagoryHierarchy";
                cmd.Parameters.Clear();
               
                cmd.Parameters.AddWithValue("@catid", SqlDbType.Char).Value = id;
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
        public void Delete(ProductCategoryBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ProductCategory_Delete";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.ProCatID;
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
