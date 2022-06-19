using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicCRUD.Models;
using SicParvisMagna.Models;
using SicParvisMagna.Library;


namespace SicParvisMagna.Controllers
{
    class IssueDAL
    {

        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        public Guid Add(IssueBAL obj)
        {
            Guid IssueID = Guid.Empty;
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sp_InsertdataInIssue_Tab]";

                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.descript;
                cmd.Parameters.Add("@addby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@due_dat", SqlDbType.DateTime).Value = obj.due_date;
                cmd.Parameters.Add("@stat", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.flag;
                cmd.Parameters.Add("@timestamp", SqlDbType.DateTime).Value = obj.timestampp;
                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj.label_id;
                cmd.Parameters.Add("@dept_id", SqlDbType.UniqueIdentifier).Value = obj.dept_id;


                IssueID = (Guid)cmd.ExecuteScalar();
                con.Close();
                return IssueID;

            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return IssueID;
        }

        public void Update(IssueBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateIssueTab";
                cmd.Parameters.Add("@issue_id", SqlDbType.UniqueIdentifier).Value = obj.Issue_id;
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.Title;
                cmd.Parameters.Add("@descrp", SqlDbType.VarChar).Value = obj.descript;
                //    cmd.Parameters.Add("@addby", SqlDbType.VarChar).Value = obj.Addby;
                //  cmd.Parameters.Add("@duedate", SqlDbType.DateTime).Value = obj.due_date;
                // cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                // cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.flag;

                // cmd.Parameters.Add("@lab_id", SqlDbType.Int).Value = obj.label_id;
                //cmd.Parameters.Add("@dpt_id", SqlDbType.Int).Value = obj.dept_id;

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
                cmd.CommandText = "LoadALL_Issues";
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




        public DataTable LoadByID(Guid ID)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Issue_LoadByID"; //Issue_Load

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = ID;
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





        public DataTable LoadOpen()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IssueOpen";

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

        public DataTable LoadClose()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IssueClose";
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


        public void Delete(IssueBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeletefromIssueTab";
                cmd.Parameters.Add("@iss_id", SqlDbType.UniqueIdentifier).Value = obj.Issue_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void buttonClose_Issue(IssueBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Button_closeIssue"; //Issue_Load

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Issue_id;
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
