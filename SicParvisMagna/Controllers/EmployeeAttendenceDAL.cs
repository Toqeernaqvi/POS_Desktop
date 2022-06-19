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
    class EmployeeAttendenceDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(EmployeeAttendenceBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_EmployeeCustomAttendence_Insert";

                cmd.Parameters.Add("@Employee_id", SqlDbType.UniqueIdentifier).Value = obj.Employee_id;
                cmd.Parameters.Add("@time_in", SqlDbType.DateTime).Value = obj.time_in;
         
                cmd.Parameters.Add("@time_out", SqlDbType.DateTime).Value = obj.time_out;
                cmd.Parameters.Add("@short_leave", SqlDbType.DateTime).Value = obj.short_leave;
                cmd.Parameters.Add("@grace_time", SqlDbType.DateTime).Value = obj.grace_time;
                cmd.Parameters.Add("@absent_after", SqlDbType.DateTime).Value = obj.absent_after;
                cmd.Parameters.Add("@break_start", SqlDbType.DateTime).Value = obj.break_start;
                cmd.Parameters.Add("@break_end", SqlDbType.DateTime).Value = obj.break_end;
        
                cmd.Parameters.Add("@add_by", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@add_date", SqlDbType.DateTime).Value = obj.AddDate;


                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(EmployeeAttendenceBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "sp_EmployeeCustomAttendence_Update";
                cmd.Parameters.Add("@Employee_id", SqlDbType.UniqueIdentifier).Value = obj.Employee_id;
                cmd.Parameters.Add("@time_in", SqlDbType.DateTime).Value = obj.time_in;

                cmd.Parameters.Add("@time_out", SqlDbType.DateTime).Value = obj.time_out;
                cmd.Parameters.Add("@short_leave", SqlDbType.DateTime).Value = obj.short_leave;
                cmd.Parameters.Add("@grace_time", SqlDbType.DateTime).Value = obj.grace_time;
                cmd.Parameters.Add("@absent_after", SqlDbType.DateTime).Value = obj.absent_after;
                cmd.Parameters.Add("@break_start", SqlDbType.DateTime).Value = obj.break_start;
                cmd.Parameters.Add("@break_end", SqlDbType.DateTime).Value = obj.break_end;
                cmd.Parameters.Add("@edit_by", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@edit_date", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Attendence_id;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadAll(EmployeeAttendenceBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_EmployeeCustomAttendence_SelectById";
                cmd.Parameters.AddWithValue("@id", obj.Employee_id);
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
        public void Delete(EmployeeAttendenceBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Employee_Attendance_Delete";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Employee_id;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.AddDate;

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
