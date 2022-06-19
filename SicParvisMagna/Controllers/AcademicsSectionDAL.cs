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
    public class AcademicsSectionDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(AcademicsSectionBAL obj)
        {
            try
            {

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sections_insert";

                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@UT", SqlDbType.VarChar).Value = obj.urdu_title;
                cmd.Parameters.Add("@class", SqlDbType.UniqueIdentifier).Value = obj.classid;
                cmd.Parameters.Add("@branch", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@org", SqlDbType.UniqueIdentifier).Value = obj.OrgId;
                cmd.Parameters.Add("@stat", SqlDbType.TinyInt).Value = obj.status;
                cmd.Parameters.Add("@Add_by", SqlDbType.UniqueIdentifier).Value = obj.Add_by;
                cmd.Parameters.Add("@Add_date", SqlDbType.DateTime).Value = obj.Add_date;


                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(AcademicsSectionBAL obj)
        {
            try
            {


                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sections_update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;

                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = obj.title;
                cmd.Parameters.Add("@UT", SqlDbType.VarChar).Value = obj.urdu_title;
                cmd.Parameters.Add("@class", SqlDbType.UniqueIdentifier).Value = obj.classid;
                cmd.Parameters.Add("@branch", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@org", SqlDbType.UniqueIdentifier).Value = obj.OrgId;
                cmd.Parameters.Add("@stat", SqlDbType.TinyInt).Value = obj.status;
                cmd.Parameters.Add("@Edit_by", SqlDbType.UniqueIdentifier).Value = obj.Edit_by;
                cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_date;


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
                cmd.CommandText = "sections_GetAll";
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

        //public DataTable LoadBranch(OrganizationBAL obj)
        //{
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter();
        //        DataTable dt = new DataTable();

        //        con.Open();
        //        cmd.Connection = con;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "sp_OrganizationBranch_LoadAll";
        //        cmd.Parameters.AddWithValue("@id", obj.Parent_id);
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        da.SelectCommand = cmd;
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    return null;
        //}

        public DataTable LoadByBranch(AcademicsSectionBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "section_GetbyBranch";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
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


        public DataTable LoadByClass(AcademicsSectionBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "section_LoadbyClass";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.classid;
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
        public void Delete(AcademicsSectionBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "section_Delete";
                cmd.Parameters.AddWithValue("@id", obj.id);
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


