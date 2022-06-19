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
    class VariantsDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(VariantBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Variants_Insert";
               
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

        public void Update(VariantBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Variants_Update";
                 cmd.Parameters.Add("@Variant_id", SqlDbType.UniqueIdentifier).Value = obj.Variant_Id;

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

        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Variants_LoadAll";
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
        //Load Product Variants by Product Variant Table
        public DataTable LoadVariants_byProductVarinnts(Guid id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "loadVariants_byProductVariant_id";
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
        public void Delete(VariantBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Variants_Delete";
                cmd.Parameters.Add("@variant_id", SqlDbType.UniqueIdentifier).Value = obj.Variant_Id;
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
 