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
    class EmployeeCompanyIndoDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        public void Add(EmployeeCompanyInfoBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_CompanyInfoInsert";
                cmd.Parameters.Add("@jobstatus_id", SqlDbType.UniqueIdentifier).Value = obj.jobstatus_id;
                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;
                cmd.Parameters.Add("@salary", SqlDbType.VarChar).Value = obj.salary;
                cmd.Parameters.Add("@designation", SqlDbType.VarChar).Value = obj.designation;
                cmd.Parameters.Add("@scale", SqlDbType.VarChar).Value = obj.scale;
                cmd.Parameters.Add("@date_of_join", SqlDbType.Date).Value = obj.date_of_join;
                cmd.Parameters.Add("@leavedate", SqlDbType.Date).Value = obj.leavedate;
              


                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update( EmployeeCompanyInfoBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Employee_CompanyInfoUpdate";
                cmd.Parameters.Add("@jobstatus_id", SqlDbType.UniqueIdentifier).Value = obj.jobstatus_id;
                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;
                cmd.Parameters.Add("@salary", SqlDbType.VarChar).Value = obj.salary;
                cmd.Parameters.Add("@designation", SqlDbType.VarChar).Value = obj.designation;
                cmd.Parameters.Add("@scale", SqlDbType.VarChar).Value = obj.scale;
                cmd.Parameters.Add("@date_of_join", SqlDbType.Date).Value = obj.date_of_join;
                cmd.Parameters.Add("@leavedate", SqlDbType.Date).Value = obj.leavedate;

 

                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadAll(EmployeeCompanyInfoBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_CompanyInfoLoadbyID";
                cmd.Parameters.AddWithValue("@employee_id", obj.employee_id);
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

        public DataTable LoadJobStatus()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_JobStatus";
            
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
        public void Delete( EmployeeCompanyInfoBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_CompanyInfoDelete";
                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //
        public Guid getid()
        {
            try
            {
                Guid employee_id =  Guid.Empty;
                SqlDataReader dr;
                int rowcount = 0;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoGetid";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rowcount++;
                    employee_id = (Guid)dr["ID"];
                }




                dr.Close();
                con.Close();

                return employee_id;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return  Guid.Empty;
        }

    }
}
