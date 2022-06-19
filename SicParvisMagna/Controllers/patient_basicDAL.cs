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
    class patient_basicDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon(); private SqlCommand cmd = new SqlCommand();

        public void Add(patient_basicBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_basic_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_name", SqlDbType.VarChar).Value = obj.patient_name;
                cmd.Parameters.Add("@patient_gender", SqlDbType.VarChar).Value = obj.patient_gender;
                cmd.Parameters.Add("@patient_Age", SqlDbType.Int).Value = obj.patient_Age;
                cmd.Parameters.Add("@patient_Age_month", SqlDbType.Int).Value = obj.patient_Age_month;
                cmd.Parameters.Add("@patient_Date_of_Birth", SqlDbType.DateTime).Value = obj.patient_Date_of_Birth;
                cmd.Parameters.Add("@patient_record_no", SqlDbType.VarChar).Value = obj.patient_record_no;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;

                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(patient_basicBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_basic_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@patient_name", SqlDbType.VarChar).Value = obj.patient_name;
                cmd.Parameters.Add("@patient_gender", SqlDbType.VarChar).Value = obj.patient_gender;
                cmd.Parameters.Add("@patient_Age", SqlDbType.Int).Value = obj.patient_Age;
                cmd.Parameters.Add("@patient_Age_month", SqlDbType.Int).Value = obj.patient_Age_month;
                cmd.Parameters.Add("@patient_Date_of_Birth", SqlDbType.DateTime).Value = obj.patient_Date_of_Birth;
                cmd.Parameters.Add("@patient_record_no", SqlDbType.VarChar).Value = obj.patient_record_no;

                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public List<patient_basicBAL> LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_basicBAL> listt = new List<patient_basicBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_basic_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_basicBAL obj1 = new patient_basicBAL();
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.patient_name = dr["patient_name"].ToString();
                        obj1.patient_gender = dr["patient_gender"].ToString();
                        obj1.patient_Age = Convert.ToInt32(dr["patient_Age"].ToString());
                        try { obj1.patient_Age_month = Convert.ToInt32(dr["patient_Age_month"].ToString()); } catch { obj1.patient_Age_month = 0; }
                        obj1.patient_Date_of_Birth = Convert.ToDateTime(dr["patient_Date_of_Birth"].ToString());
                        obj1.patient_record_no = dr["patient_record_no"].ToString();
                       // obj1.AddDate = Convert.ToDateTime(dr["AddDate"].ToString()).Date;
                        //obj1.Addby = dr["Addby"].ToString();
                      //  obj1.EditDate = Convert.ToDateTime(dr["EditDate"].ToString()).Date;
                       // obj1.Editby = dr["Editby"].ToString();
                        obj1.status = (bool)dr["status"];
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

        public List<patient_basicBAL> LoadAll()
        {
            try
            {
                //Local
                //List<patient_basicBAL> listt = new List<patient_basicBAL>();
                SqlDataReader reader;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_basic_LOADALL";
                cmd.Parameters.Clear();
                //    SqlDataAdapter sa = new SqlDataAdapter();
                //    DataTable dt = new DataTable();

                reader = cmd.ExecuteReader();
                //  sa.SelectCommand = cmd;
                //  sa.Fill(dt);

                //     id = row.Field<string>("id"),
                //   name = row.Field<string>("name")

                var listt = reader.Cast<IDataRecord>()
                 .Select(dr => new patient_basicBAL
                 {
                     patient_id = dr.GetGuid(0),
                     patient_name = dr.GetString(1),
                     patient_gender = dr.GetString(2),
                     patient_Age = dr.GetInt32(3),
                     patient_Age_month = dr.GetInt32(11),
                     patient_Date_of_Birth = dr.GetDateTime(4),
                     patient_record_no = dr.GetString(5),
                     Addby = dr.GetString(6),
                     AddDate = dr.GetDateTime(7),
                    // Editby = dr.GetString(8),
                     //EditDate = dr.GetDateTime(9),
                     status = dr.GetBoolean(10)



                 }).ToList();
                   



                    //List<patient_basicBAL> listt = dt.AsEnumerable().Select(row =>
                    //new patient_basicBAL
                    //{
                    //        patient_id            = Convert.ToInt32(row.Field<int>("patient_id").ToString()),
                    //        patient_name          = row.Field<string>("patient_name").ToString(),
                    //        patient_gender        = row.Field<string>("patient_gender").ToString(),
                    //        patient_Age           = Convert.ToInt32(row.Field<int>("patient_Age").ToString()),
                    //        patient_Age_month     = Convert.ToInt32(row.Field<DateTime>("patient_Age_month").ToString()),
                    //        patient_Date_of_Birth = Convert.ToDateTime(row.Field<Nullable<DateTime>>("patient_Date_of_Birth").ToString()),
                    //        patient_record_no     = Convert.ToInt32(row.Field<int>("patient_record_no").ToString()),
                    //        add_Date              = Convert.ToDateTime(row.Field<Nullable<DateTime>>("add_Date").ToString()).Date,
                    //        add_By                = row.Field<string>("add_By").ToString(),
                    //        edit_date             = Convert.ToDateTime(row.Field<Nullable<DateTime>>("edit_Date").ToString()).Date,
                    //        edit_By               = row.Field<string>("edit_By").ToString(),
                    //        status                = Convert.ToBoolean(row.Field<bool>("status").ToString())
                    //}).ToList();

                    //if (dr.HasRows)
                    //{
                    //    while (dr.Read())
                    //    {
                    //        patient_basicBAL obj1 = new patient_basicBAL();
                    //        float x = 0;
                    //        obj1.patient_id = Convert.ToInt32(dr["patient_id"].ToString());
                    //        obj1.patient_name = dr["patient_name"].ToString();
                    //        obj1.patient_gender = dr["patient_gender"].ToString();
                    //        obj1.patient_Age = Convert.ToInt32(dr["patient_Age"].ToString());
                    //        try { obj1.patient_Age_month = Convert.ToInt32(dr["patient_Age_month"].ToString()); } catch { obj1.patient_Age_month = 0; }
                    //        obj1.patient_Date_of_Birth = Convert.ToDateTime(dr["patient_Date_of_Birth"].ToString());
                    //        obj1.patient_record_no = Convert.ToInt32(dr["patient_record_no"].ToString());
                    //        obj1.add_Date = Convert.ToDateTime(dr["add_Date"].ToString()).Date;
                    //        obj1.add_By = dr["add_By"].ToString();
                    //        obj1.edit_date = Convert.ToDateTime(dr["edit_Date"].ToString()).Date;
                    //        obj1.edit_By = dr["edit_By"].ToString();
                    //        obj1.status = (bool)dr["status"];
                    //        listt.Add(obj1);
                    //    }
                    //}
                    con.Close();
                    return listt;
                
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable Search(patient_basicBAL obj)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                List<patient_basicBAL> listt = new List<patient_basicBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_basic_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_name", SqlDbType.VarChar).Value = obj.patient_name;
                cmd.Parameters.Add("@patient_record_no", SqlDbType.VarChar).Value = obj.patient_record_no;
                con.Close();
                sa.SelectCommand = cmd;
                sa.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable FindRecordNo( )
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                List<patient_basicBAL> listt = new List<patient_basicBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patientRecordNo";
 
                
                con.Close();
                sa.SelectCommand = cmd;
                sa.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public void Delete(patient_basicBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_basic_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
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
