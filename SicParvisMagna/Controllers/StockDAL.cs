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
    class StockDAL
    {
        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(StockBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Stock_Insert";

                cmd.Parameters.Clear();

                cmd.Parameters.Add("@organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@branch_id", SqlDbType.UniqueIdentifier).Value       = obj.Branch_id;
                cmd.Parameters.Add("@pos_id", SqlDbType.UniqueIdentifier).Value          = obj.POS_id;
                cmd.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value      = obj.Product_id;
                cmd.Parameters.Add("@product_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_id;
                cmd.Parameters.Add("@Order_No", SqlDbType.VarChar).Value = obj.Order_no;

                cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = obj.barcode;
                cmd.Parameters.Add("@quantity", SqlDbType.Float).Value = obj.quantity;
                cmd.Parameters.Add("@quantityineach", SqlDbType.Float).Value = obj.qie;
                cmd.Parameters.Add("@purchaseprice", SqlDbType.Float).Value = obj.purchaseprice;
                cmd.Parameters.Add("@sellprice", SqlDbType.Float).Value = obj.saleprice;
                cmd.Parameters.Add("@addby", SqlDbType.UniqueIdentifier).Value = obj.Addby;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@SOS_id", SqlDbType.UniqueIdentifier).Value = obj.SOS_id;
                cmd.Parameters.Add("@POR_id", SqlDbType.UniqueIdentifier).Value = obj.POR_id;
                cmd.Parameters.Add("@SOR_id", SqlDbType.UniqueIdentifier).Value = obj.SOR_id;
                cmd.Parameters.Add("@Prescription_Medicine_id", SqlDbType.UniqueIdentifier).Value = obj.Prescription_Medicine_id;
                 cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;
                cmd.Parameters.Add("@Source", SqlDbType.VarChar).Value = obj.Source;
                cmd.Parameters.Add("@Product_Variant_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(StockBAL obj)
        {
            try
            {
                //Local
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Stock_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
                cmd.Parameters.Add("@pos_id", SqlDbType.UniqueIdentifier).Value = obj.POS_id;
                cmd.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = obj.Product_id;
                cmd.Parameters.Add("@product_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_id;
                cmd.Parameters.Add("@Order_No", SqlDbType.VarChar).Value = obj.Order_no;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
               
                cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = obj.barcode;
                cmd.Parameters.Add("@quantity", SqlDbType.Float).Value = obj.quantity;
                cmd.Parameters.Add("@quantityineach", SqlDbType.Float).Value = obj.qie;
                cmd.Parameters.Add("@purchaseprice", SqlDbType.Float).Value = obj.purchaseprice;
                cmd.Parameters.Add("@sellprice", SqlDbType.Float).Value = obj.saleprice;
                cmd.Parameters.Add("@editby", SqlDbType.UniqueIdentifier).Value = obj.Editby;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;

                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@SOS_id", SqlDbType.UniqueIdentifier).Value = obj.SOS_id;
                cmd.Parameters.Add("@POR_id", SqlDbType.UniqueIdentifier).Value = obj.POR_id;
                cmd.Parameters.Add("@SOR_id", SqlDbType.UniqueIdentifier).Value = obj.SOR_id;
                cmd.Parameters.Add("@Prescription_Medicine_id", SqlDbType.UniqueIdentifier).Value = obj.Prescription_Medicine_id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;
                cmd.Parameters.Add("@Source", SqlDbType.VarChar).Value = obj.Source;
                cmd.Parameters.Add("@Product_Variant_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadbyProductId(Guid obj)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Stock_LOADByProductID";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = obj;
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

        public DataTable FindQuantity(Guid Pro_id , Guid Cat_id)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_FindQunatity_INStock";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = Pro_id;
                cmd.Parameters.Add("@Cat_id", SqlDbType.UniqueIdentifier).Value = Cat_id;

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
                        obj1.status =  dr["status"].ToString();

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


        public DataTable LoadAll(Guid id)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.CommandText = "Stock_LOADALL";
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

        public DataTable LoadAllByID(Guid id)
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
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.CommandText = "sp_StockLoadByID";
              
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

        public DataTable LoadStockGrid(Guid id)
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
                cmd.Parameters.Add("@pro_id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.CommandText = "sp_LoadSrockGrid";
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
        public DataTable LoadStock( )
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_LoadStock";
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

        public DataTable LoadStockDataByID(Guid Pro_id)
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
                cmd.CommandText = "LoadStockDataByID";
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = Pro_id;

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

        public List<ProductBAL> Search(ProductBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<ProductBAL> listt = new List<ProductBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Product_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = obj.Pro_id;
                cmd.Parameters.Add("@Product_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@company_name", SqlDbType.VarChar).Value = obj.company_name;
                cmd.Parameters.Add("@formula_name", SqlDbType.VarChar).Value = obj.formula_name;
                cmd.Parameters.Add("@rs", SqlDbType.Float).Value = obj.rs;
                cmd.Parameters.Add("@rm", SqlDbType.Float).Value = obj.rm;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
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
                        obj1.status = dr["status"].ToString();
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


        public List<ProductBAL> LoadAll_SQLQuery(string query)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<ProductBAL> listt = new List<ProductBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "query";


                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProductBAL obj1 = new ProductBAL();
                        float x = 0; obj1.Pro_id = Guid.Parse(dr["Pro_id"].ToString());
                        obj1.Product_Category_id = Guid.Parse(dr["Product_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.company_name = dr["company_name"].ToString();
                        obj1.formula_name = dr["formula_name"].ToString();
                        obj1.rs = Convert.ToDouble(dr["rs"].ToString());
                        obj1.rm = Convert.ToDouble(dr["rm"].ToString());
                        try
                        { obj1.InStock = Convert.ToBoolean(dr["InStock"].ToString()); }
                        catch
                        { obj1.InStock = false; }
                        obj1.status = dr["status"].ToString();
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

        public void DeleteStock(Guid id)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Delete_Stock";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        ///Check Qunatity in Stock
        public DataTable CheckQuantityInStock(Guid ProId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CheckQuantityInStock";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Product_id", SqlDbType.UniqueIdentifier).Value = ProId;
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

        ///Check Qunatity in Stock
        public DataTable MinusQuantityInStock(Guid stockId ,Guid ProId, int Quantity)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MinusQuantityFromStock";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@stockId", SqlDbType.UniqueIdentifier).Value = stockId;
                 cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = ProId;
                cmd.Parameters.Add("@Quantity", SqlDbType.Float).Value = Quantity;

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

        /////Get Stock on Product Id
        ///
        public DataTable  GetStockOnProductId(Guid ProId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetStockOnProductId";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Product_id", SqlDbType.UniqueIdentifier).Value = ProId;
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

    }
}
