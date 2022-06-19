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
    class SessionDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
      

        public void Add(SessionBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sessions_Insert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Session_Name;
                cmd.Parameters.Add("@urduname", SqlDbType.VarChar).Value = obj.UrduName;
                cmd.Parameters.Add("@orgid", SqlDbType.UniqueIdentifier).Value = obj.OrgId;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.BranchId;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.ClassId;
                cmd.Parameters.Add("@addby", SqlDbType.UniqueIdentifier).Value = obj.Add_by;
                cmd.Parameters.Add("@add_date", SqlDbType.DateTime).Value = obj.Add_date;

                cmd.Parameters.Add("@stat", SqlDbType.TinyInt).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();


            }

          
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(SessionBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sessions_Update";
                cmd.Parameters.Clear();
               
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Session_Name;
                cmd.Parameters.Add("@urduname", SqlDbType.VarChar).Value = obj.UrduName;
                cmd.Parameters.Add("@orgid", SqlDbType.UniqueIdentifier).Value = obj.OrgId;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.BranchId;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.ClassId;
                cmd.Parameters.Add("@editby", SqlDbType.UniqueIdentifier).Value = obj.Edit_by;
                cmd.Parameters.Add("@edit_date", SqlDbType.DateTime).Value = obj.Edit_date;

                cmd.Parameters.Add("@stat", SqlDbType.TinyInt).Value = obj.status;

                cmd.ExecuteNonQuery();
                con.Close();


            }

          
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }







        public DataTable LoadByBranch(SessionBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "session_GetbyBranch";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.BranchId;
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
                cmd.CommandText = "Sessions_LoadAll";
                cmd.Parameters.Clear();
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


        public void Delete(SessionBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sessions_Delete";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", obj.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable searchStudentsByClassSection(StudentBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sessions_getStudentsForPromotion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Sessions_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
                cmd.Parameters.AddWithValue("@Class_id", SqlDbType.UniqueIdentifier).Value = obj.classid;
                cmd.Parameters.AddWithValue("@Section_id", SqlDbType.UniqueIdentifier).Value = obj.section;
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
        public void PromoteStudent(StudentBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[Sessions_setStudentPromotion]";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Sessions_id", obj.Session_id);
                cmd.Parameters.AddWithValue("@Class_id", obj.classid);
                cmd.Parameters.AddWithValue("@Section_id", obj.section);
                cmd.Parameters.AddWithValue("@Registration", obj.registration);
                cmd.Parameters.AddWithValue("@Student_id", obj.id);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        public void StudentLOG (Promote_stuBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[Insert_promote_stud]";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@stu_id", obj.stu_id);
                cmd.Parameters.AddWithValue("@prev_sess", obj.prev_session);
                cmd.Parameters.AddWithValue("@prev_class", obj.prev_class);
                cmd.Parameters.AddWithValue("@prev_sect", obj.prev_section);
                cmd.Parameters.AddWithValue("@next_sess", obj.next_session);
                cmd.Parameters.AddWithValue("@next_class", obj.next_class);
                cmd.Parameters.AddWithValue("@next_sect", obj.next_section);
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
