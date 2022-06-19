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
    class ProductVariantDetailDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(ProductVariantDetailsBAL obj)
        {
            try
            {
                //Local
                if (con.State == ConnectionState.Closed)
                    cmd.Parameters.Clear();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Details_Insert";
                cmd.Parameters.Add("@Product_Variant_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_Id;
                cmd.Parameters.Add("@Variant_id", SqlDbType.UniqueIdentifier).Value = obj.variant_Id;
                cmd.Parameters.Add("@Variant_Type_Id", SqlDbType.UniqueIdentifier).Value = obj.variant_Type_Id;
                cmd.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = obj.Quantity;

                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@ShortName", SqlDbType.VarChar).Value = obj.ShortName;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@AddBy", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@AddDate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@Flag", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(ProductVariantDetailsBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Details_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Product_Variant_Detail_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_Detail_id;
                cmd.Parameters.Add("@Product_Variant_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_Id;
                cmd.Parameters.Add("@Variant_id", SqlDbType.UniqueIdentifier).Value = obj.variant_Id;
                cmd.Parameters.Add("@Variant_Type_Id", SqlDbType.UniqueIdentifier).Value = obj.variant_Type_Id;
                cmd.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = obj.Quantity;

                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@ShortName", SqlDbType.VarChar).Value = obj.ShortName;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = obj.Description;
                cmd.Parameters.Add("@EditBy", SqlDbType.VarChar).Value = obj.EditBy;
                cmd.Parameters.Add("@EditDate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@Flag", SqlDbType.Int).Value = obj.Flag;

                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Load Product Variant Details by ProductVariantId
        public DataTable LoadProductVariantDetail_ByProductVariantId(Guid Product_Variant_id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Details_byProductVariant";
                cmd.Parameters.Add("@Product_Variant_id", SqlDbType.UniqueIdentifier).Value = Product_Variant_id;

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

        public DataTable LoadproductVariants_LoadByProductVariantId(Guid id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ProductVariantsDetails_LoadByProductVariantId";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;

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
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Details_LoadAll";
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


        //Load ProductVariantsDetails Table on Product_Variant_id
        public DataTable productVariantsDetails_LoadByProductVariantId(Guid id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "product_variants_load_by_product_variant_id";
                cmd.Parameters.Add("@Product_Variant_id", SqlDbType.UniqueIdentifier).Value = id;

                cmd.ExecuteNonQuery();//executea
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

        public void Delete(ProductVariantDetailsBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Details_Delete";
                cmd.Parameters.Add("@Product_Variant_Detail_Id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_Detail_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void DeleteByProductVariantId(Guid id)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Details_Delete_by_Product_Variant_id";
                cmd.Parameters.Add("@Product_Variant_Id", SqlDbType.UniqueIdentifier).Value = id;
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

