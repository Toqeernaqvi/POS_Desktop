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
    class DepartmentClassDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
      

        public void Add(DepartmentClassBAL obj)
        {
            try
            {
                //Local
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DepartmentClassesInsert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organzation_id;
                cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
                cmd.Parameters.Add("@dept_id", SqlDbType.UniqueIdentifier).Value = obj.dept_id;
                cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.class_id;
                cmd.Parameters.Add("@local", SqlDbType.Bit).Value = obj.Local;
                cmd.Parameters.Add("@web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@add_by", SqlDbType.VarChar).Value = obj.Add_by;
                cmd.Parameters.Add("@add_date", SqlDbType.DateTime).Value = obj.Add_Date;
                cmd.ExecuteNonQuery();
                con.Close();


            }

            
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(DepartmentClassBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DepartmentClassesUpdate";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organzation_id;
                cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
                cmd.Parameters.Add("@dept_id", SqlDbType.UniqueIdentifier).Value = obj.dept_id;
                cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.class_id;
                cmd.Parameters.Add("@local", SqlDbType.Bit).Value = obj.Local;
                cmd.Parameters.Add("@web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Edit_by", SqlDbType.VarChar).Value = obj.Edit_By;
                cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_Date;

                cmd.ExecuteNonQuery();
                con.Close();
            }
             
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable LoadAssignedDepartments()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DepartmentClassesLoadALLAssignedDepartments]";
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
        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DepartmentClassesLoadALL";
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
        public DataTable LoadbyID(DepartmentClassBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DepartmentClassesLoadbyID";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
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
        public void Delete(DepartmentClassBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DepartmentClassesDelete";
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
    }
}
