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
    class Employee_Salary_RecordDAL
    {
        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon(); private SqlCommand cmd = new SqlCommand();

        public void Add(Employee_Salary_RecordBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_Salary_Record_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@dep_id", SqlDbType.UniqueIdentifier).Value = obj.dep_id;
                cmd.Parameters.Add("@emp_id", SqlDbType.UniqueIdentifier).Value = obj.emp_id;
                cmd.Parameters.Add("@Employee_Name", SqlDbType.VarChar).Value = obj.Employee_Name;
                cmd.Parameters.Add("@Date_of_Join", SqlDbType.DateTime).Value = obj.Date_of_Join;
                cmd.Parameters.Add("@Designation", SqlDbType.VarChar).Value = obj.Designation;
                cmd.Parameters.Add("@Basic_Salary", SqlDbType.Float).Value = obj.Basic_Salary;
                cmd.Parameters.Add("@Total_Days", SqlDbType.Int).Value = obj.Total_Days;
                cmd.Parameters.Add("@Attendance_Days", SqlDbType.Float).Value = obj.Attendance_Days;
                cmd.Parameters.Add("@Per_Day_Salary", SqlDbType.Float).Value = obj.Per_Day_Salary;
                cmd.Parameters.Add("@Per_Hour_Salary", SqlDbType.Float).Value = obj.Per_Hour_Salary;
                cmd.Parameters.Add("@Total_Days_Amount", SqlDbType.Float).Value = obj.Total_Days_Amount;
                cmd.Parameters.Add("@Extra_Duty_Days", SqlDbType.Float).Value = obj.Extra_Duty_Days;
                cmd.Parameters.Add("@Extra_Duty_Hours", SqlDbType.Float).Value = obj.Extra_Duty_Hours;
                cmd.Parameters.Add("@Extra_Duty_Minutes", SqlDbType.Float).Value = obj.Extra_Duty_Minutes;
                cmd.Parameters.Add("@Extra_Duty_Amount", SqlDbType.Float).Value = obj.Extra_Duty_Amount;
                cmd.Parameters.Add("@Payable_Amount", SqlDbType.Float).Value = obj.Payable_Amount;
                cmd.Parameters.Add("@Leave_Salary", SqlDbType.Float).Value = obj.Leave_Salary;
                cmd.Parameters.Add("@Other_Expences", SqlDbType.Float).Value = obj.Other_Expences;
                cmd.Parameters.Add("@Salary_Deduction", SqlDbType.Float).Value = obj.Salary_Deduction;
                cmd.Parameters.Add("@Advance_Salary", SqlDbType.Float).Value = obj.Advance_Salary;
                cmd.Parameters.Add("@Net_Payable_Amount", SqlDbType.Float).Value = obj.Net_Payable_Amount;
                cmd.Parameters.Add("@RegularityAmount", SqlDbType.Float).Value = obj.RegularityAmount;
                cmd.Parameters.Add("@RegularityDays", SqlDbType.Float).Value = obj.RegularityDays;
                cmd.Parameters.Add("@SalaryDate", SqlDbType.DateTime).Value = obj.SalaryDate;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(Employee_Salary_RecordBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_Salary_Record_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@esr_id", SqlDbType.UniqueIdentifier).Value = obj.esr_id;
                cmd.Parameters.Add("@dep_id", SqlDbType.UniqueIdentifier).Value = obj.dep_id;
                cmd.Parameters.Add("@Employee_Name", SqlDbType.VarChar).Value = obj.Employee_Name;
                cmd.Parameters.Add("@Date_of_Join", SqlDbType.DateTime).Value = obj.Date_of_Join;
                cmd.Parameters.Add("@Designation", SqlDbType.VarChar).Value = obj.Designation;
                cmd.Parameters.Add("@Basic_Salary", SqlDbType.Float).Value = obj.Basic_Salary;
                cmd.Parameters.Add("@Total_Days", SqlDbType.Int).Value = obj.Total_Days;
                cmd.Parameters.Add("@Attendance_Days", SqlDbType.Int).Value = obj.Attendance_Days;
                cmd.Parameters.Add("@Attendance_Hours", SqlDbType.Float).Value = obj.Attendance_Hours;
                cmd.Parameters.Add("@Per_Day_Salary", SqlDbType.Float).Value = obj.Per_Day_Salary;
                cmd.Parameters.Add("@Per_Hour_Salary", SqlDbType.Float).Value = obj.Per_Hour_Salary;
                cmd.Parameters.Add("@Total_Days_Amount", SqlDbType.Float).Value = obj.Total_Days_Amount;
                cmd.Parameters.Add("@Total_Hours_Amount", SqlDbType.Float).Value = obj.Total_Hours_Amount;
                cmd.Parameters.Add("@Total_Days_Hours_Amount", SqlDbType.Float).Value = obj.Total_Days_Hours_Amount;
                cmd.Parameters.Add("@Extra_Duty_Days", SqlDbType.Float).Value = obj.Extra_Duty_Days;
                cmd.Parameters.Add("@Extra_Duty_Amount", SqlDbType.Float).Value = obj.Extra_Duty_Amount;
                cmd.Parameters.Add("@Payable_Amount", SqlDbType.Float).Value = obj.Payable_Amount;
                cmd.Parameters.Add("@Loan", SqlDbType.Float).Value = obj.Leave_Salary;
                cmd.Parameters.Add("@Payed_Loan", SqlDbType.Float).Value = obj.Other_Expences;
                cmd.Parameters.Add("@Loan_Balance", SqlDbType.Float).Value = obj.Salary_Deduction;
                cmd.Parameters.Add("@Advance_Salary", SqlDbType.Float).Value = obj.Advance_Salary;
                cmd.Parameters.Add("@Net_Payable_Amount", SqlDbType.Float).Value = obj.Net_Payable_Amount;
                cmd.Parameters.Add("@SalaryDate", SqlDbType.DateTime).Value = obj.SalaryDate;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public List<Employee_Salary_RecordBAL> LoadbyId(Employee_Salary_RecordBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<Employee_Salary_RecordBAL> listt = new List<Employee_Salary_RecordBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_Salary_Record_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@esr_id", SqlDbType.UniqueIdentifier).Value = obj.esr_id;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Employee_Salary_RecordBAL obj1 = new Employee_Salary_RecordBAL();
                        obj1.dep_id  = Guid.Parse(dr["dep_id"].ToString());
                        obj1.Employee_Name = dr["Employee_Name"].ToString();
                        obj1.Date_of_Join = Convert.ToDateTime(dr["Date_of_Join"].ToString());
                        obj1.Designation = dr["Designation"].ToString();
                        obj1.Basic_Salary = (float)dr["Basic_Salary"];
                        obj1.Total_Days = Convert.ToInt32(dr["Total_Days"].ToString());
                        obj1.Attendance_Days = Convert.ToInt32(dr["Attendance_Days"].ToString());
                        obj1.Attendance_Hours = (float)dr["Attendance_Hours"];
                        obj1.Per_Day_Salary = (float)dr["Per_Day_Salary"];
                        obj1.Per_Hour_Salary = (float)dr["Per_Hour_Salary"];
                        obj1.Total_Days_Amount = (float)dr["Total_Days_Amount"];
                        obj1.Total_Hours_Amount = (float)dr["Total_Hours_Amount"];
                        obj1.Total_Days_Hours_Amount = (float)dr["Total_Days_Hours_Amount"];
                        obj1.Extra_Duty_Days = (float)dr["Extra_Duty_Hours"];
                        obj1.Extra_Duty_Amount = (float)dr["Extra_Duty_Amount"];
                        obj1.Payable_Amount = (float)dr["Payable_Amount"];
                        obj1.Leave_Salary = (float)dr["Loan"];
                        obj1.Other_Expences = (float)dr["Payed_Loan"];
                        obj1.Salary_Deduction = (float)dr["Loan_Balance"];
                        obj1.Advance_Salary = (float)dr["Advance_Salary"];
                        obj1.Net_Payable_Amount = (float)dr["Net_Payable_Amount"];
                        obj1.SalaryDate = Convert.ToDateTime(dr["SalaryDate"].ToString());
                        listt.Add(obj1);
                    }
                }
                dr.Close();
                con.Close();
                return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }



        public DataTable FindByDepartment(Employee_Salary_RecordBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[Employee_SalaryAndLeaves_FindExisting]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@dep_id", SqlDbType.UniqueIdentifier).Value = obj.dep_id;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.SalaryDate;
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


        public void DeleteByDepartment(Employee_Salary_RecordBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                // DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[Employee_SalaryAndLeaves_DeleteExisting]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@dep_id", SqlDbType.UniqueIdentifier).Value = obj.dep_id;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.SalaryDate;
                cmd.ExecuteNonQuery();
                con.Close();
                // da.SelectCommand = cmd;
                // da.Fill(dt);
                // return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // return null;
        }



        public List<Employee_Salary_RecordBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<Employee_Salary_RecordBAL> listt = new List<Employee_Salary_RecordBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_Salary_Record_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Employee_Salary_RecordBAL obj1 = new Employee_Salary_RecordBAL();
                        obj1.dep_id = Guid.Parse(dr["dep_id"].ToString());
                        obj1.Employee_Name = dr["Employee_Name"].ToString();
                        obj1.Date_of_Join = Convert.ToDateTime(dr["Date_of_Join"].ToString());
                        obj1.Designation = dr["Designation"].ToString();
                        obj1.Basic_Salary = (float)dr["Basic_Salary"];
                        obj1.Total_Days = Convert.ToInt32(dr["Total_Days"].ToString());
                        obj1.Attendance_Days = Convert.ToInt32(dr["Attendance_Days"].ToString());
                        obj1.Attendance_Hours = (float)dr["Attendance_Hours"];
                        obj1.Per_Day_Salary = (float)dr["Per_Day_Salary"];
                        obj1.Per_Hour_Salary = (float)dr["Per_Hour_Salary"];
                        obj1.Total_Days_Amount = (float)dr["Total_Days_Amount"];
                        obj1.Total_Hours_Amount = (float)dr["Total_Hours_Amount"];
                        obj1.Total_Days_Hours_Amount = (float)dr["Total_Days_Hours_Amount"];
                        obj1.Extra_Duty_Days = (float)dr["Extra_Duty_Hours"];
                        obj1.Extra_Duty_Amount = (float)dr["Extra_Duty_Amount"];
                        obj1.Payable_Amount = (float)dr["Payable_Amount"];
                        obj1.Leave_Salary = (float)dr["Loan"];
                        obj1.Other_Expences = (float)dr["Payed_Loan"];
                        obj1.Salary_Deduction = (float)dr["Loan_Balance"];
                        obj1.Advance_Salary = (float)dr["Advance_Salary"];
                        obj1.Net_Payable_Amount = (float)dr["Net_Payable_Amount"];
                        obj1.SalaryDate = Convert.ToDateTime(dr["SalaryDate"].ToString());
                        listt.Add(obj1);
                    }
                }
                dr.Close();
                con.Close();
                return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public void Delete(Employee_Salary_RecordBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_Salary_Record_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@esr_id", SqlDbType.UniqueIdentifier).Value = obj.esr_id;
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
