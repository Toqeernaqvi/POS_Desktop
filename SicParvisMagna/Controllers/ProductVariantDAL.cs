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
    class ProductVariantDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(ProductVariantBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Insert";
                cmd.Parameters.Add("@Product_Id", SqlDbType.UniqueIdentifier).Value = obj.Product_Id;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@ShortName", SqlDbType.VarChar).Value = obj.ShortName;
                cmd.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = obj.Barcode;
                cmd.Parameters.Add("@AddBy", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@AddDate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@Flag", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@Product_Category_Id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_Id;
                cmd.Parameters.Add("@Barcode_Type_Id", SqlDbType.UniqueIdentifier).Value = obj.Barcode_Type_Id;

                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update( ProductVariantBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Update";
                cmd.Parameters.Add("@Product_Variant_Id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_Id;
                cmd.Parameters.Add("@Product_Id", SqlDbType.UniqueIdentifier).Value = obj.Product_Id;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@ShortName", SqlDbType.VarChar).Value = obj.ShortName;
                cmd.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = obj.Barcode;
                cmd.Parameters.Add("@EditBy", SqlDbType.VarChar).Value = obj.EditBy;
                cmd.Parameters.Add("@EditDate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@Flag", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@Product_Category_Id", SqlDbType.UniqueIdentifier).Value = obj.Product_Category_Id;
                cmd.Parameters.Add("@Barcode_Type_Id", SqlDbType.UniqueIdentifier).Value = obj.Barcode_Type_Id;

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
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_LoadAll";
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

        public DataTable LoadAllVariants()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_LoadAll_Variants";
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


        public DataTable LoadAllByProductVariant_id(Guid ProductVariantId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadAllByProductVariant_Id";
                cmd.Parameters.Add("@product_variant_id", SqlDbType.UniqueIdentifier).Value =  ProductVariantId;

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



        public DataTable LoadProductVariants_By_Product_Id(Guid Product_id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadAll_ProductVariants";
                cmd.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = Product_id;

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

        public DataTable GetProductVariantId_byProductId(Guid Product_id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getProductVariantId_byProductId";
                cmd.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = Product_id;

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

        public void Delete( ProductVariantBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Product_Variant_Delete";
                cmd.Parameters.Add("@Product_Variant_Id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_Id;
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
