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
    class patient_prescription_medicineDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(patient_prescription_medicineBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_mdeicine_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj.medicine_id;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = obj.quantity;
                cmd.Parameters.Add("@total_price", SqlDbType.Int).Value = obj.total_price;
                cmd.Parameters.Add("@pricing_id", SqlDbType.UniqueIdentifier).Value = obj.pricing_id;
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

        public void Update(patient_prescription_medicineBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_mdeicine_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_medicine_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_medicine_id;
                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj.medicine_id;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = obj.quantity;
                cmd.Parameters.Add("@total_price", SqlDbType.Int).Value = obj.total_price;
                cmd.Parameters.Add("@pricing_id", SqlDbType.UniqueIdentifier).Value = obj.pricing_id;
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


        public PricingBAL Medicine_GetRemainingMeds(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_GetRemainingMeds";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PricingBAL obj1 = new PricingBAL();

                        try
                        {
                            obj1.remaining = (float)Convert.ToDouble(dr["remaining"].ToString());
                            obj1.opened = (int)Convert.ToDouble(dr["Opn"].ToString());
                        }
                        catch
                        {
                            obj1.remaining = 0;
                            obj1.opened = 0;
                        }


                        return obj1;
                    }
                }
                dr.Close();
                con.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public patient_prescription_medicineBAL LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                // List<patient_prescription_mdeicineBAL> listt = new List<patient_prescription_mdeicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_mdeicine_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_mdeicine_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                patient_prescription_medicineBAL obj1 = new patient_prescription_medicineBAL();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        obj1.patient_prescription_medicine_id = Guid.Parse(dr["patient_prescription_mdeicine_id"].ToString());
                        obj1.patient_prescription_id = Guid.Parse(dr["patient_prescription_id"].ToString());
                        obj1.medicine_id = Guid.Parse(dr["medicine_id"].ToString());
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        obj1.quantity = Convert.ToInt32(dr["quantity"].ToString());
                        obj1.total_price = Convert.ToInt32(dr["total_price"].ToString());
                        obj1.status = (bool)dr["status"];

                    }
                }
                dr.Close();
                con.Close();
                return obj1;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }


        public List<patient_prescription_medicineBAL> LoadByPrescription(Guid id)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_prescription_medicineBAL> listt = new List<patient_prescription_medicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.CommandText = "patient_prescription_mdeicine_LOADALL";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;


                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_prescription_medicineBAL obj1 = new patient_prescription_medicineBAL();
                        float x = 0; obj1.patient_prescription_medicine_id = Guid.Parse(dr["patient_prescription_medicine_id"].ToString());
                        obj1.patient_prescription_id = Guid.Parse(dr["patient_prescription_id"].ToString());
                        obj1.medicine_id = Guid.Parse(dr["medicine_id"].ToString());
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        obj1.quantity = Convert.ToInt32(dr["quantity"].ToString());
                        obj1.total_price = Convert.ToInt32(dr["total_price"].ToString());
                        obj1.pricing_id = Guid.Parse(dr["pricing_id"].ToString());
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

        public List<patient_prescription_medicineBAL> Search(patient_prescription_medicineBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_prescription_medicineBAL> listt = new List<patient_prescription_medicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_prescription_mdeicine_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_mdeicine_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_medicine_id;
                cmd.Parameters.Add("@patient_prescription_id", SqlDbType.UniqueIdentifier).Value = obj.patient_prescription_id;
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj.medicine_id;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = obj.quantity;
                cmd.Parameters.Add("@total_price", SqlDbType.Int).Value = obj.total_price;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_prescription_medicineBAL obj1 = new patient_prescription_medicineBAL();
                        float x = 0; obj1.patient_prescription_medicine_id = Guid.Parse(dr["patient_prescription_mdeicine_id"].ToString());
                        obj1.patient_prescription_id = Guid.Parse(dr["patient_prescription_id"].ToString());
                        obj1.medicine_id = Guid.Parse(dr["medicine_id"].ToString());
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        obj1.quantity = Convert.ToInt32(dr["quantity"].ToString());
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
                cmd.CommandText = "patient_prescription_mdeicine_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_prescription_mdeicine_id", SqlDbType.UniqueIdentifier).Value = obj;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void DeleteStockPrescriptionMedicine(Guid obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteStockPrescriptionMedicine";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void DeletePrescriptionMedicine(Guid obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeletePrescriptionMedicine";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj;
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
