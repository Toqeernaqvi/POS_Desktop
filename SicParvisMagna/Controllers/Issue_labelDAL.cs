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
    class Issue_labelDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();



        public void Add(Issue_labelsBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertData_Issu_labels";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@iss_id", SqlDbType.UniqueIdentifier).Value = obj.Issue_id;
                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj.label_id;

                cmd.Parameters.Add("@addby", SqlDbType.VarChar).Value = obj.addby;
                cmd.Parameters.Add("@stat", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.flag;
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
        public DataTable LoadIss_labels_byIssueid(Issue_labelsBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadByIssueID_Iss_labels";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Issue_id;//gloabal
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

        public void DeleteByIssue(Issue_labelsBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DELETE_Iss_labels_by_issue";
                cmd.Parameters.Add("@Issue_id", SqlDbType.UniqueIdentifier).Value = obj.Issue_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        public void Delete(Issue_labelsBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DELETE_Iss_labels";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Id;
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

