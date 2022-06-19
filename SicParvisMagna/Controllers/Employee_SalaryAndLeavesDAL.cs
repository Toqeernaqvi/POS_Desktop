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
    class Employee_SalaryAndLeavesDAL
    {

        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon(); private SqlCommand cmd = new SqlCommand();

        public void Add(Employee_SalaryAndLeavesBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_SalaryAndLeaves_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;
                cmd.Parameters.Add("@totalSalary", SqlDbType.Int).Value = obj.totalSalary;
                cmd.Parameters.Add("@NoOfLeaveAllowed", SqlDbType.Int).Value = obj.NoOfLeaveAllowed;
                cmd.Parameters.Add("@RemainingLeaves", SqlDbType.Int).Value = obj.RemainingLeaves;
                cmd.Parameters.Add("@NoOfMedicalLeaveAllowed", SqlDbType.Int).Value = obj.NoOfMedicalLeaveAllowed;
                cmd.Parameters.Add("@RemainingMedicalLeaves", SqlDbType.Int).Value = obj.RemainingMedicalLeaves;
                cmd.Parameters.Add("@LeaveIncrement", SqlDbType.Int).Value = obj.LeaveIncrement;
                cmd.Parameters.Add("@RemainingMonths", SqlDbType.Int).Value = obj.RemainingMonths;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(Employee_SalaryAndLeavesBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_SalaryAndLeaves_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;
                cmd.Parameters.Add("@totalSalary", SqlDbType.Int).Value = obj.totalSalary;
                cmd.Parameters.Add("@NoOfLeaveAllowed", SqlDbType.Int).Value = obj.NoOfLeaveAllowed;
                cmd.Parameters.Add("@RemainingLeaves", SqlDbType.Int).Value = obj.RemainingLeaves;
                cmd.Parameters.Add("@NoOfMedicalLeaveAllowed", SqlDbType.Int).Value = obj.NoOfMedicalLeaveAllowed;
                cmd.Parameters.Add("@RemainingMedicalLeaves", SqlDbType.Int).Value = obj.RemainingMedicalLeaves;
                cmd.Parameters.Add("@LeaveIncrement", SqlDbType.Int).Value = obj.LeaveIncrement;
                cmd.Parameters.Add("@RemainingMonths", SqlDbType.Int).Value = obj.RemainingMonths;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadbyId(Employee_SalaryAndLeavesBAL obj)
        {
            try
            {
                //Local

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_SalaryAndLeaves_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;
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

        public DataTable LoadAll(Employee_SalaryAndLeavesBAL obj)
        {
            try
            {
                //Local

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_SalaryAndLeaves_LOADALL";
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

        public void Delete(Employee_SalaryAndLeavesBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_SalaryAndLeaves_Delete";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
