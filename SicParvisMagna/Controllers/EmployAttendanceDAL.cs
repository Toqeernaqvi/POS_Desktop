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
    class EmployAttendanceDAL
    {
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
        // private MySqlConnection mycon = new MYSQLCon().getCon();
        //private MySqlCommand mycmd = new MySqlCommand();

        public void Add(EmployeAttendenceBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tes_InsertEmpThumbScan]";
                cmd.Parameters.Add("@employid", SqlDbType.Int).Value = obj.employid;
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
        public void TimeIn(EmployeAttendenceBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_insertAttendanceEmp]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@employ_id", SqlDbType.UniqueIdentifier).Value = obj.employid;
                //           cmd.Parameters.Add("@studentname", SqlDbType.VarChar).Value = obj.studentname;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = obj.type;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
                 cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;

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
        public void Update(smsBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sms_Update";
                cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.id;
                cmd.Parameters.Add("@sms_message", SqlDbType.VarChar).Value = obj.message;
                cmd.Parameters.Add("@sms_number", SqlDbType.Int).Value = obj.number;
                cmd.Parameters.Add("@sms_status", SqlDbType.VarChar).Value = obj.status;
                // cmd.Parameters.Add("@sms_imported", SqlDbType.Binary).Value = obj.imported;
                cmd.Parameters.Add("@sms_add_date", SqlDbType.DateTime2).Value = obj.add_date;
                cmd.Parameters.Add("@sms_send_date", SqlDbType.DateTime2).Value = obj.send_date;
                //     cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                //    cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                //     cmd.Parameters.Add("@Add_by", SqlDbType.VarChar).Value = obj.Add_by;
                //    cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;
                //   cmd.Parameters.Add("@Edit_By", SqlDbType.DateTime).Value = obj.Edit_By;
                //    cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_Date;


                cmd.ExecuteNonQuery();
                con.Close();



                //Web

                //MySqlDataAdapter da = new MySqlDataAdapter();
                //mycon.Open();
                //mycmd.Connection = mycon;
                //mycmd.CommandText = "UPDATE TBMD_City SET City.Web = False WHERE City.id = " + obj.City_id;
                //mycmd.ExecuteNonQuery();
                //mycmd.Dispose();
                //mycon.Close();
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
        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ts_getEmpThumbScan]";
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

        public DataTable LoadEmployData(Guid EmployID)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ts_getEmpDataByThumbScan";
                cmd.Parameters.AddWithValue("@employ_id", EmployID);
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


        public DataTable LoadEmployData_ByID(Guid EmployID,DateTime date)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_EmployeeAttendence_id";
                cmd.Parameters.AddWithValue("@id", EmployID);
                cmd.Parameters.AddWithValue("@date", date);
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
        public void Delete(smsBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sms_Delete";
                cmd.Parameters.AddWithValue("@id", obj.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public int GetRowCountforType(DateTime IntialDate, DateTime EndDate, int emoloyee_id, int type)
        {
            int count = 0;
            try
            {
                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEmolyeeAttendancetypeCount";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@IntialDate", SqlDbType.Date).Value = IntialDate;
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = EndDate;
                cmd.Parameters.Add("@employee_id", SqlDbType.Int).Value = emoloyee_id;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        count = (int)dr["Type Count"];

                    }
                }
                dr.Close();
                con.Close();
                return count;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return 0;
        }


    }
}
