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
    class SectionDAL
    {
       ///Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public void Add(SectionBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SectionEMPInsert";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortName;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.desc;
                cmd.Parameters.Add("@time_in", SqlDbType.DateTime).Value = obj.time_in;
                cmd.Parameters.Add("@time_out", SqlDbType.DateTime).Value = obj.time_out;
                cmd.Parameters.Add("@short_leave", SqlDbType.DateTime).Value = obj.short_leave;
                cmd.Parameters.Add("@grace_time", SqlDbType.DateTime).Value = obj.grace_time;
                cmd.Parameters.Add("@absent_after", SqlDbType.DateTime).Value = obj.absent_after;
                cmd.Parameters.Add("@break_start", SqlDbType.DateTime).Value = obj.break_start;
                cmd.Parameters.Add("@break_end", SqlDbType.DateTime).Value = obj.break_end;
                cmd.Parameters.Add("@local", SqlDbType.Bit).Value = obj.local;
                cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.web;
                cmd.Parameters.Add("@add_by", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@add_date", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@office_id", SqlDbType.UniqueIdentifier).Value = obj.Office_id;
 

                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(SectionBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "SectionEMPUpdate";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortName;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = obj.desc;
                cmd.Parameters.Add("@office_id", SqlDbType.UniqueIdentifier).Value = obj.Office_id;
                cmd.Parameters.Add("@time_in", SqlDbType.DateTime).Value = obj.time_in;
                cmd.Parameters.Add("@time_out", SqlDbType.DateTime).Value = obj.time_out;
                cmd.Parameters.Add("@short_leave", SqlDbType.DateTime).Value = obj.short_leave;
                cmd.Parameters.Add("@grace_time", SqlDbType.DateTime).Value = obj.grace_time;
                cmd.Parameters.Add("@absent_after", SqlDbType.DateTime).Value = obj.absent_after;
                cmd.Parameters.Add("@break_start", SqlDbType.DateTime).Value = obj.break_start;
                cmd.Parameters.Add("@break_end", SqlDbType.DateTime).Value = obj.break_end;
                cmd.Parameters.Add("@local", SqlDbType.Bit).Value = obj.local;
                cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.web;
                cmd.Parameters.Add("@edit_by", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@edit_date", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.section_id;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadAll(SectionBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SectionEMPLoadALL";
                cmd.Parameters.AddWithValue("@id", obj.Office_id);
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
        public void Delete(SectionBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Section_Delete";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.section_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable loadbyclass(SectionBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SectionGetByClass";
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.Classid;
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
