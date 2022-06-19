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
    class CommDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(CommentBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Comment_Add";
                cmd.Parameters.Add("@iss_id", SqlDbType.UniqueIdentifier).Value = obj.Issue_id;
                //cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.descript;
                cmd.Parameters.Add("@files", SqlDbType.VarChar).Value = obj.attachments;
                cmd.Parameters.Add("@tmp", SqlDbType.DateTime).Value = obj.date;
                cmd.Parameters.Add("@flg", SqlDbType.TinyInt).Value = obj.flag;
                cmd.Parameters.Add("@stat", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@edtby", SqlDbType.VarChar).Value = obj.edit_by;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(CommentBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Comment_Update";
                cmd.Parameters.Add("@com_id", SqlDbType.UniqueIdentifier).Value = obj.Comm_id;
                cmd.Parameters.Add("@iss_id", SqlDbType.UniqueIdentifier).Value = obj.Issue_id;
                // cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.descript;
                //cmd.Parameters.Add("@files", SqlDbType.VarChar).Value = obj.attachments;
                //cmd.Parameters.Add("@tmp", SqlDbType.DateTime).Value = obj.date;
                //cmd.Parameters.Add("@flg", SqlDbType.TinyInt).Value = obj.flag;
                //cmd.Parameters.Add("@stat", SqlDbType.VarChar).Value = obj.status;
                //cmd.Parameters.Add("@edtby", SqlDbType.VarChar).Value = obj.edit_by;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public DataTable LoadByIssue(Guid IssueID)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Comment_LoadByIssue";
                cmd.Parameters.Add("@issue_id", SqlDbType.UniqueIdentifier).Value = IssueID;

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
                cmd.CommandText = "Comment_LoadAll";
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

        public void Delete(CommentBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Comment_Delete";
                cmd.Parameters.Add("@com_id", SqlDbType.UniqueIdentifier).Value = obj.Comm_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //for comment
        public DataTable Loadcomment()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadComments";
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






    }

}

