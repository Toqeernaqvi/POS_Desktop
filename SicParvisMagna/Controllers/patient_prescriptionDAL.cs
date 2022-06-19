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
    class patient_prescriptionDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(patient_prescriptionBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_Insert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;

                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@assigned_Date", SqlDbType.DateTime).Value = obj.assigned_Date;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = obj.type;
                cmd.Parameters.Add("@total_cost", SqlDbType.Int).Value = obj.total_cost;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(patient_prescriptionBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = obj.type;
                cmd.Parameters.Add("@assigned_Date", SqlDbType.DateTime).Value = obj.assigned_Date;
                cmd.Parameters.Add("@total_cost", SqlDbType.Int).Value = obj.total_cost;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public List<patient_prescriptionBAL> LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_prescriptionBAL> listt = new List<patient_prescriptionBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_prescriptionBAL obj1 = new patient_prescriptionBAL();
                        
                        float x = 0; obj1.patient_prescription_id = Guid.Parse(dr["patient_prescription_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.assigned_Date = Convert.ToDateTime(dr["assigned_Date"].ToString());
                        obj1.total_cost = Convert.ToInt32(dr["total_cost"].ToString());
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

        public List<patient_prescriptionBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader reader;
                //   List<patient_prescriptionBAL> listt = new List<patient_prescriptionBAL>();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_LOADALL";
                cmd.Parameters.Clear();
                //   SqlDataAdapter sa = new SqlDataAdapter();
                //   DataTable dt = new DataTable();
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                //     id = row.Field<string>("id"),
                //   name = row.Field<string>("name")\

                var listt = reader.Cast<IDataRecord>()
                 .Select(dr => new patient_prescriptionBAL
                 {
                     
                     
                     patient_prescription_id = dr.GetGuid(0),
                     patient_id = dr.GetGuid(1),
                     assigned_Date = dr.GetDateTime(2),
                     total_cost = dr.GetInt32(3),
                     status = dr.GetBoolean(4),
                     type = dr.GetString(5)

                 })
                 .ToList();
                //List<patient_prescriptionBAL> listt = dt.AsEnumerable().Select(row =>
                //new patient_prescriptionBAL
                //{
                //    patient_prescription_id = Convert.ToInt32(row.Field<int>("patient_prescription_id").ToString()),
                //    patient_id = Convert.ToInt32(row.Field<int>("patient_id").ToString()),
                //    assigned_Date = Convert.ToDateTime(row.Field<DateTime>("assigned_Date").ToString()),
                //    total_cost = Convert.ToInt32(row.Field<int>("total_cost").ToString()),
                //    status = Convert.ToBoolean(row.Field<bool>("status").ToString())
                //}).ToList();


                //dr = cmd.ExecuteReader();
                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        patient_prescriptionBAL obj1 = new patient_prescriptionBAL();
                //        float x = 0; obj1.patient_prescription_id = Convert.ToInt32(dr["patient_prescription_id"].ToString());
                //        obj1.patient_id = Convert.ToInt32(dr["patient_id"].ToString());
                //        obj1.assigned_Date = Convert.ToDateTime(dr["assigned_Date"].ToString());
                //        obj1.total_cost = Convert.ToInt32(dr["total_cost"].ToString());
                //        obj1.status = (bool)dr["status"];
                //        listt.Add(obj1);
                //    }
                //}
                //dr.Close();
                con.Close();
                return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<patient_prescriptionBAL> Search(patient_prescriptionBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_prescriptionBAL> listt = new List<patient_prescriptionBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@assigned_Date", SqlDbType.DateTime).Value = obj.assigned_Date;
                cmd.Parameters.Add("@total_cost", SqlDbType.Int).Value = obj.total_cost;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_prescriptionBAL obj1 = new patient_prescriptionBAL();
                        obj1.patient_prescription_id = Guid.Parse(dr["patient_prescription_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.assigned_Date = Convert.ToDateTime(dr["assigned_Date"].ToString());
                        obj1.total_cost = Convert.ToInt32(dr["total_cost"].ToString());
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

        public void Delete(Guid obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj;
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
