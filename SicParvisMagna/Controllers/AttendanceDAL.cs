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
    class AttendanceDAL
    {

        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
        // private MySqlConnection mycon = new MYSQLCon().getCon();
        //private MySqlCommand mycmd = new MySqlCommand();

        public void Add(AttendanceBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_InsertStudThumbScan]";
                cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = obj.studentid;
                cmd.Parameters.Add("@ts", SqlDbType.NVarChar).Value = obj.serializedFmd;
                cmd.ExecuteNonQuery();
                con.Close();


            }

            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public DataTable SearchExistingAttendance(AttendanceBAL obj)
        {
            try
            {
                //Local
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_searchExistingAttendance]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ClassId", SqlDbType.UniqueIdentifier).Value = obj.Class_id;
                cmd.Parameters.Add("@SectionId", SqlDbType.UniqueIdentifier).Value = obj.Section_id;
                cmd.Parameters.Add("@SessionId", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.date;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;

            }

            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable SearchAttendanceNoAttendance(AttendanceBAL obj)
        {
            try
            {
                //Local
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ts_searchAttendanceNoAttendance";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ClassId", SqlDbType.Int).Value = obj.Class_id;
                cmd.Parameters.Add("@SectionId", SqlDbType.Int).Value = obj.Section_id;
                cmd.Parameters.Add("@SessionId", SqlDbType.Int).Value = obj.Session_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.date;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;

            }

            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable SearchAttendanceNoStatusStudents(AttendanceBAL obj)
        {
            try
            {
                //Local
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_searchAttendanceNoStatusStudents]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ClassId", SqlDbType.UniqueIdentifier).Value = obj.Class_id;
                cmd.Parameters.Add("@SectionId", SqlDbType.UniqueIdentifier).Value = obj.Section_id;
                cmd.Parameters.Add("@SessionId", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;

            }

            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable SearchAttendance(AttendanceBAL obj)
        {
            try
            {
                //Local
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_searchAttendance]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ClassId", SqlDbType.Int).Value = obj.Class_id;
                cmd.Parameters.Add("@SectionId", SqlDbType.Int).Value = obj.Section_id;
                cmd.Parameters.Add("@SessionId", SqlDbType.Int).Value = obj.Session_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.date;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;

            }

            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public void TimeIn(AttendanceBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_insertAttendance]";
                cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = obj.studentid;
                cmd.Parameters.Add("@Session_id", SqlDbType.Int).Value = obj.Session_id;
                //           cmd.Parameters.Add("@studentname", SqlDbType.VarChar).Value = obj.studentname;
                //  cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = obj.type;
                // cmd.Parameters.Add("@Attendance", SqlDbType.VarChar).Value = obj.attendance;
                // cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;

                cmd.ExecuteNonQuery();
                con.Close();


            }

            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void TimeIn_Update(AttendanceBAL obj)
        {
            try
            {
                //Local
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_updateAttendance]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@studentAttendanceId", SqlDbType.Int).Value = obj.id;
                cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = obj.studentid;
                cmd.Parameters.Add("@Session_id", SqlDbType.Int).Value = obj.Session_id;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@class_id", SqlDbType.Int).Value = obj.Class_id;
                cmd.Parameters.Add("@section_id", SqlDbType.Int).Value = obj.Section_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.date;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void TimeIn_ManualUpdate(AttendanceBAL obj)
        {
            try
            {
                //Local
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_updateManualAttendance]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@studentAttendanceId", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@studentid", SqlDbType.UniqueIdentifier).Value = obj.studentid;
                cmd.Parameters.Add("@Session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.Class_id;
                cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.Section_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.date;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void TimeIn_Manual(AttendanceBAL obj)
        {
            try
            {
                //Local
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_insertAttendance]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@studentid", SqlDbType.UniqueIdentifier).Value = obj.studentid;
                cmd.Parameters.Add("@Session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.Class_id;
                cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.Section_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.date;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //public void Update(SmsBAL obj)
        //{
        //    try
        //    {

        //        //Local

        //        con.Open();
        //        cmd.Connection = con;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "sms_Update";
        //        cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.id;
        //        cmd.Parameters.Add("@sms_message", SqlDbType.VarChar).Value = obj.message;
        //        cmd.Parameters.Add("@sms_number", SqlDbType.Int).Value = obj.number;
        //        cmd.Parameters.Add("@sms_status", SqlDbType.VarChar).Value = obj.status;
        //        //cmd.Parameters.Add("@sms_imported", SqlDbType.Binary).Value = obj.imported;
        //        cmd.Parameters.Add("@sms_add_date", SqlDbType.DateTime2).Value = obj.add_date;
        //        cmd.Parameters.Add("@sms_send_date", SqlDbType.DateTime2).Value = obj.send_date;
        //        // cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
        //        // cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
        //        //  cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
        //        // cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;
        //        // cmd.Parameters.Add("@Edit_By", SqlDbType.DateTime).Value = obj.Edit_By;
        //        //  cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_Date;


        //        cmd.ExecuteNonQuery();
        //        con.Close();



        //        //Web

        //        //MySqlDataAdapter da = new MySqlDataAdapter();
        //        //mycon.Open();
        //        //mycmd.Connection = mycon;
        //        //mycmd.CommandText = "UPDATE TBMD_City SET City.Web = False WHERE City.id = " + obj.City_id;
        //        //mycmd.ExecuteNonQuery();
        //        //mycmd.Dispose();
        //        //mycon.Close();
        //    }

        //    catch (MySqlException e)
        //    {
        //        MessageBox.Show(e.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    catch (SqlException e1)
        //    {
        //        MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}
        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_getStudThumbScan]";
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

        public DataTable LoadStudentData(int StudentID)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ts_getStudDataByThumbScan";
                cmd.Parameters.AddWithValue("@studentid", StudentID);
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
        //public void Delete(SmsBAL obj)
        //{
        //    try
        //    {
        //        con.Open();
        //        cmd.Connection = con;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "sms_Delete";
        //        cmd.Parameters.AddWithValue("@id", obj.id);
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

    }
}
