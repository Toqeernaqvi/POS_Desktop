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
    class ProductMultiCategoryDAL
    {
        //sql connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public Guid Add(ProductMultiCategoryBAL obj)
        {
            Guid CatID = Guid.Empty;
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ProductMultiCategory_Add";
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@parid", SqlDbType.VarChar).Value = obj.ParentID;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@descrip", SqlDbType.VarChar).Value = obj.Descrip;
                cmd.Parameters.Add("@tms", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@stats", SqlDbType.NVarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;

                CatID = (Guid)cmd.ExecuteScalar();
                con.Close();
                return CatID;


            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return CatID;
        }

        public void Update(ProductMultiCategoryBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ProductMultiCategory_Update";
                cmd.Parameters.Add("@catid", SqlDbType.UniqueIdentifier).Value = obj.CatID;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@parid", SqlDbType.VarChar).Value = obj.ParentID;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@descrip", SqlDbType.VarChar).Value = obj.Descrip;
                cmd.Parameters.Add("@tms", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.EditBy;
                cmd.Parameters.Add("@stats", SqlDbType.NVarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;


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
                cmd.CommandText = "ProductMultiCategory_LoadAll";
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

        public void Delete(ProductMultiCategoryBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ProductMultiCategory_Delete";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.CatID;
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
