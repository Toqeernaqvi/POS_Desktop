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
    class patient_prescription_LabTestDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon(); private SqlCommand cmd = new SqlCommand();

        public void Add(patient_prescription_LabTestBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_LabTest_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;
                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@welfar_discount", SqlDbType.Int).Value = obj.welfare_discount;
                cmd.Parameters.Add("@total_price", SqlDbType.Int).Value = obj.total_price;
                cmd.Parameters.Add("@discount", SqlDbType.Int).Value = obj.discount;
                cmd.Parameters.Add("@net_total", SqlDbType.Int).Value = obj.net_price;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@Addby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@AddDate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(patient_prescription_LabTestBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_LabTest_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_LabTest_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_LabTest_id;
                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;
                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@welfar_discount", SqlDbType.Int).Value = obj.welfare_discount;
                cmd.Parameters.Add("@total_price", SqlDbType.Int).Value = obj.total_price;
                cmd.Parameters.Add("@discount", SqlDbType.Int).Value = obj.discount;
                cmd.Parameters.Add("@net_total", SqlDbType.Int).Value = obj.net_price;
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

        public List<patient_prescription_LabTestBAL> LoadbyId(patient_prescription_LabTestBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_prescription_LabTestBAL> listt = new List<patient_prescription_LabTestBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_LabTest_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_LabTest_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_LabTest_id;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_prescription_LabTestBAL obj1 = new patient_prescription_LabTestBAL();
                        obj1.patient_prescription_LabTest_id = Guid.Parse(dr["patient_prescription_LabTest_id"].ToString());
                        obj1.patient_prescription_id = Guid.Parse(dr["patient_prescription_id"].ToString());
                        obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        obj1.discount = Convert.ToInt32(dr["discount"].ToString());
                        try { obj1.welfare_discount = Convert.ToInt32(dr["welfare_discount"].ToString()); }
                        catch { obj1.welfare_discount = 0; }

                        try
                        {
                            obj1.net_price = Convert.ToInt32(dr["net_total"].ToString());
                        }
                        catch { obj1.net_price = 0; }
                        obj1.total_price = Convert.ToInt32(dr["total_price"].ToString());
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

        public List<patient_prescription_LabTestBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_prescription_LabTestBAL> listt = new List<patient_prescription_LabTestBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_LabTest_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_prescription_LabTestBAL obj1 = new patient_prescription_LabTestBAL();
                        float x = 0; obj1.patient_prescription_LabTest_id = Guid.Parse(dr["patient_prescription_LabTest_id"].ToString());
                        obj1.patient_prescription_id = Guid.Parse(dr["patient_prescription_id"].ToString());
                        obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        try { obj1.welfare_discount = Convert.ToInt32(dr["welfare_discount"].ToString()); }
                        catch { obj1.welfare_discount = 0; }

                        try
                        {
                            obj1.net_price = Convert.ToInt32(dr["net_total"].ToString());
                        }
                        catch { obj1.net_price = 0; }
                        obj1.discount = Convert.ToInt32(dr["discount"].ToString());
                        obj1.total_price = Convert.ToInt32(dr["total_price"].ToString());
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

        public List<patient_prescription_LabTestBAL> Search(patient_prescription_LabTestBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_prescription_LabTestBAL> listt = new List<patient_prescription_LabTestBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_LabTest_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_LabTest_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_LabTest_id;
                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;
                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@discount", SqlDbType.Int).Value = obj.discount;
                cmd.Parameters.Add("@total_price", SqlDbType.Int).Value = obj.total_price;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_prescription_LabTestBAL obj1 = new patient_prescription_LabTestBAL();
                        float x = 0; obj1.patient_prescription_LabTest_id = Guid.Parse(dr["patient_prescription_LabTest_id"].ToString());
                        obj1.patient_prescription_id = Guid.Parse(dr["patient_prescription_id"].ToString());
                        obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        try { obj1.welfare_discount = Convert.ToInt32(dr["welfare_discount"].ToString()); }
                        catch { obj1.welfare_discount = 0; }

                        try
                        {
                            obj1.net_price = Convert.ToInt32(dr["net_total"].ToString());
                        }
                        catch { obj1.net_price = 0; }
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        obj1.discount = Convert.ToInt32(dr["discount"].ToString());
                        obj1.total_price = Convert.ToInt32(dr["total_price"].ToString());
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
                cmd.CommandText = "patient_prescription_LabTest_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_LabTest_id", SqlDbType.UniqueIdentifier).Value = obj;
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
    