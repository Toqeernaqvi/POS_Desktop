using BasicCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SicParvisMagna.Models;
using SicParvisMagna.Library;

namespace SicParvisMagna.Controllers
{
    class LabelDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(LabelBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertdataLabel_tab";
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@color_c", SqlDbType.VarChar).Value = obj.color_code;
                cmd.Parameters.Add("@add_by", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@stat", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.flag;
                cmd.Parameters.Add("@timestamp", SqlDbType.DateTime).Value = obj.timestampp;
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void Update(LabelBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdatedataLabel_tab";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.label_id;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@color_c", SqlDbType.VarChar).Value = obj.color_code;
                cmd.Parameters.Add("@addby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@stat", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@flg", SqlDbType.TinyInt).Value = obj.flag;
                cmd.Parameters.Add("@tmp", SqlDbType.DateTime).Value = obj.timestampp;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public DataTable LoadAllIssue_labels()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadAllBylabelid_Iss_labels";
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

        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetAllbyLabel_tab";
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


        public DataTable LoadAllIssuelabels()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LOADBYLabelid_Iss_labels";
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


        public void Delete(LabelBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeletedataLabel_tab";
                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj.label_id;
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

