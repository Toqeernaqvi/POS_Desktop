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
    class ProductDAL
    {
        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public Guid Add(ProductBAL obj)
        {
            try
            {
                //
                obj.Pro_id = Guid.NewGuid();
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Insert";

                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = obj.Pro_id;
                cmd.Parameters.Add("@Product_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_id;
                cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@company_name", SqlDbType.VarChar).Value = obj.company_name;
                cmd.Parameters.Add("@unit", SqlDbType.VarChar).Value = obj.unit;
                cmd.Parameters.Add("@reorder_point", SqlDbType.VarChar).Value = obj.reorder_point;
                cmd.Parameters.Add("@reorder_quantity", SqlDbType.VarChar).Value = obj.reorder_quantity;

                cmd.Parameters.Add("@formula_name", SqlDbType.VarChar).Value = obj.formula_name;
                cmd.Parameters.Add("@rs", SqlDbType.Float).Value = obj.rs;
                cmd.Parameters.Add("@rm", SqlDbType.Float).Value = obj.rm;
                cmd.Parameters.Add("@qie", SqlDbType.Float).Value = obj.qie;
                cmd.Parameters.Add("@opn", SqlDbType.Float).Value = obj.opn;
                cmd.Parameters.Add("@InStock", SqlDbType.Bit).Value = obj.InStock;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@adby", SqlDbType.UniqueIdentifier).Value = obj.Addby;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
                return obj.Pro_id;
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return Guid.Empty;
        }

        public void Update(ProductBAL obj)
        {
            try
            {
                //Local
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = obj.Pro_id;
                cmd.Parameters.Add("@Product_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_id;
                cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@company_name", SqlDbType.VarChar).Value = obj.company_name;
                cmd.Parameters.Add("@formula_name", SqlDbType.VarChar).Value = obj.formula_name;
                cmd.Parameters.Add("@reorder_point", SqlDbType.VarChar).Value = obj.reorder_point;
                cmd.Parameters.Add("@reorder_quantity", SqlDbType.VarChar).Value = obj.reorder_quantity;

                cmd.Parameters.Add("@rs", SqlDbType.Float).Value = obj.rs;
                cmd.Parameters.Add("@rm", SqlDbType.Float).Value = obj.rm;
                cmd.Parameters.Add("@qie", SqlDbType.Float).Value = obj.qie;
                cmd.Parameters.Add("@opn", SqlDbType.Float).Value = obj.opn;
                cmd.Parameters.Add("@InStock", SqlDbType.Bit).Value = obj.InStock;
                cmd.Parameters.Add("@unit", SqlDbType.VarChar).Value = obj.unit;

                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@editby", SqlDbType.UniqueIdentifier).Value = obj.Editby;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public ProductBAL LoadbyId(Guid obj)
        {
            try
            {
                //Local
                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_LOADByID";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        
                        ProductBAL obj1 = new ProductBAL();
                        obj1.Pro_id = Guid.Parse(dr["Pro_id"].ToString());
                        obj1.Product_Category_id = Guid.Parse(dr["Product_Category_id"].ToString());
                        obj1.Organization_id = Guid.Parse(dr["Organization_id"].ToString());
                        obj1.Branch_id = Guid.Parse(dr["Branch_id"].ToString());

                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.company_name = dr["company_name"].ToString();
                        obj1.formula_name = dr["formula_name"].ToString();
                        obj1.rs = Convert.ToDouble(dr["rs"].ToString());
                        obj1.rm = Convert.ToDouble(dr["rm"].ToString());
                        obj1.qie = Convert.ToDouble(dr["quantityineach"].ToString());
                        obj1.opn = Convert.ToDouble(dr["opened"].ToString());
                        obj1.unit = dr["unit"].ToString();
                        obj1.reorder_point = dr["reorder_point"].ToString();
                        obj1.reorder_quantity = dr["reorder_quantity"].ToString();


                        obj1.InStock = (bool)dr["InStock"];
                        obj1.status = dr["status"].ToString(); 

                        return obj1;
                    }
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }


        public ProductBAL LoadCurrentInfoById(Guid id, DateTime date)
        {
            try
            {
                //Local
                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ProductGetInfoById";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProductBAL obj1 = new ProductBAL();
                        obj1.Pro_id = Guid.Parse(dr["Pro_id"].ToString());
                        obj1.Product_Category_id = Guid.Parse(dr["Product_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.company_name = dr["company_name"].ToString();
                        obj1.formula_name = dr["formula_name"].ToString();
                        obj1.rs = Convert.ToDouble(dr["rs"].ToString());
                        obj1.rm = Convert.ToDouble(dr["rm"].ToString());
                        obj1.qie = Convert.ToDouble(dr["quantityineach"].ToString());
                        obj1.opn = Convert.ToDouble(dr["opened"].ToString());

                        obj1.InStock = (bool)dr["InStock"];
                        obj1.status = dr["status"].ToString(); 

                        return obj1;
                    }
                }
                dr.Close();
                con.Close();
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
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.CommandText = "Product_LOADALL";
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

        public DataTable LoadProductNameWithCategory()
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadProductNameWithCategory";
                cmd.Parameters.Clear();
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
        //
        public DataTable LoadProdcutbyCategory(Guid value)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_LOAD_CatID";
                cmd.Parameters.Add("@Cat_id", SqlDbType.UniqueIdentifier).Value = value;
                 
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

        //Search by brand
        public DataTable LoadProdcutbyBrand(string value)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_LOADBRAND";
                cmd.Parameters.Add("@brand", SqlDbType.VarChar).Value = value;

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

        //

        //Search by product
        public DataTable LoadProdcutbyName_(string name)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_LOADProductName_%";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

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

        public DataTable LoadProdcutbyName_wildcard(string name)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_LOADProductName_wildcard";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

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
        public DataTable LoadProdcutbyid(Guid id )
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Loadby_Pro_id";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;

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
        //

        //Search by Fourmula Name
        public DataTable LoadProdcutbyFourmula(string name)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_LOADFourmula";
                cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = name;

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

        //Search by Price
        public DataTable LoadProdcutbyPrice(string value)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_LOADPrice";
                cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = value;

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
        public DataTable LoadProdcutby_Category(Guid value)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_LOAD_ID";
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = value;

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
        //

        public DataTable Search(Guid catid,string title)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Search";
                cmd.Parameters.Clear();
                
                cmd.Parameters.Add("@Product_Category_id", SqlDbType.UniqueIdentifier).Value = catid;
                cmd.Parameters.Add("@text", SqlDbType.VarChar).Value = title;
                cmd.ExecuteNonQuery();
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

        public DataTable getRemainingProductForReduction(Guid ProId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[Product_GetRemainingForReduction]";
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = ProId;
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable sqlQuery(string query)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
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

        public void Delete(ProductBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = obj.Pro_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public DataTable ProductLoadbyid(Guid ProId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_LoadById";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = ProId;
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        //
        public DataTable BrandFromProduct()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ProductBrand";
                 da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }


        public DataTable getQuantityInEachFromProduct(Guid value)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getQuantityInEachFromProduct";
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = value;

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
