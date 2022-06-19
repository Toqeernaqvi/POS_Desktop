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
    class patient_Next_of_kinDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(patient_Next_of_kinBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_Next_of_kin_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@relation_to_patient", SqlDbType.VarChar).Value = obj.relation_to_patient;
                cmd.Parameters.Add("@phone_no", SqlDbType.VarChar).Value = obj.phone_no;
                cmd.Parameters.Add("@first_address", SqlDbType.VarChar).Value = obj.first_address;
                cmd.Parameters.Add("@second_address", SqlDbType.VarChar).Value = obj.second_address;
                cmd.Parameters.Add("@country_id", SqlDbType.Int).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.Int).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.Int).Value = obj.city_id;
                cmd.Parameters.Add("@area_id", SqlDbType.Int).Value = obj.area_id;
                cmd.Parameters.Add("@zipcode", SqlDbType.VarChar).Value = obj.zipcode;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                
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

        public void Update(patient_Next_of_kinBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_Next_of_kin_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_Next_of_kin_id", SqlDbType.UniqueIdentifier).Value = obj.patient_Next_of_kin_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@relation_to_patient", SqlDbType.VarChar).Value = obj.relation_to_patient;
                cmd.Parameters.Add("@phone_no", SqlDbType.VarChar).Value = obj.phone_no;
                cmd.Parameters.Add("@first_address", SqlDbType.VarChar).Value = obj.first_address;
                cmd.Parameters.Add("@second_address", SqlDbType.VarChar).Value = obj.second_address;
                cmd.Parameters.Add("@country_id", SqlDbType.Int).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.Int).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.Int).Value = obj.city_id;
                cmd.Parameters.Add("@area_id", SqlDbType.Int).Value = obj.area_id;
                cmd.Parameters.Add("@zipcode", SqlDbType.VarChar).Value = obj.zipcode;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public List<patient_Next_of_kinBAL> LoadbyId(patient_Next_of_kinBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_Next_of_kinBAL> listt = new List<patient_Next_of_kinBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_Next_of_kin_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_Next_of_kin_id", SqlDbType.UniqueIdentifier).Value = obj.patient_Next_of_kin_id;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_Next_of_kinBAL obj1 = new patient_Next_of_kinBAL();
                        float x = 0; obj1.patient_Next_of_kin_id = Guid.Parse(dr["patient_Next_of_kin_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.relation_to_patient = dr["relation_to_patient"].ToString();
                        obj1.phone_no = dr["phone_no"].ToString();
                        obj1.first_address = dr["first_address"].ToString();
                        obj1.second_address = dr["second_address"].ToString();
                        obj1.country_id = Guid.Parse(dr["country_id"].ToString());
                        obj1.state_id = Guid.Parse(dr["state_id"].ToString());
                        obj1.city_id = Guid.Parse(dr["city_id"].ToString());
                        obj1.area_id = Guid.Parse(dr["area_id"].ToString());
                        obj1.zipcode = dr["zipcode"].ToString();
                        obj1.AddDate = Convert.ToDateTime(dr["AddDate"].ToString());
                        obj1.Addby = dr["Addby"].ToString();
                        obj1.EditDate = Convert.ToDateTime(dr["EditDate"].ToString());
                        obj1.Editby = dr["Editby"].ToString();
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

        public List<patient_Next_of_kinBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_Next_of_kinBAL> listt = new List<patient_Next_of_kinBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_Next_of_kin_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_Next_of_kinBAL obj1 = new patient_Next_of_kinBAL();
                        obj1.patient_Next_of_kin_id = Guid.Parse(dr["patient_Next_of_kin_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.relation_to_patient = dr["relation_to_patient"].ToString();
                        obj1.phone_no = dr["phone_no"].ToString();
                        obj1.first_address = dr["first_address"].ToString();
                        obj1.second_address = dr["second_address"].ToString();
                        obj1.country_id = Guid.Parse(dr["country_id"].ToString());
                        obj1.state_id = Guid.Parse(dr["state_id"].ToString());
                        obj1.city_id = Guid.Parse(dr["city_id"].ToString());
                        obj1.area_id = Guid.Parse(dr["area_id"].ToString());
                        obj1.zipcode = dr["zipcode"].ToString();
                        obj1.AddDate = Convert.ToDateTime(dr["AddDate"].ToString());
                        obj1.Addby = dr["Addby"].ToString();
                        obj1.EditDate = Convert.ToDateTime(dr["EditDate"].ToString());
                        obj1.Editby = dr["Editby"].ToString();
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

        public List<patient_Next_of_kinBAL> Search(patient_Next_of_kinBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_Next_of_kinBAL> listt = new List<patient_Next_of_kinBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_Next_of_kin_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_Next_of_kin_id", SqlDbType.UniqueIdentifier).Value = obj.patient_Next_of_kin_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@relation_to_patient", SqlDbType.VarChar).Value = obj.relation_to_patient;
                cmd.Parameters.Add("@phone_no", SqlDbType.VarChar).Value = obj.phone_no;
                cmd.Parameters.Add("@first_address", SqlDbType.VarChar).Value = obj.first_address;
                cmd.Parameters.Add("@second_address", SqlDbType.VarChar).Value = obj.second_address;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.area_id;
                cmd.Parameters.Add("@zipcode", SqlDbType.VarChar).Value = obj.zipcode;
                cmd.Parameters.Add("@AddDate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@Addby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@EditDate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@Editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_Next_of_kinBAL obj1 = new patient_Next_of_kinBAL();
                        float x = 0; obj1.patient_Next_of_kin_id = Guid.Parse(dr["patient_Next_of_kin_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.relation_to_patient = dr["relation_to_patient"].ToString();
                        obj1.phone_no = dr["phone_no"].ToString();
                        obj1.first_address = dr["first_address"].ToString();
                        obj1.second_address = dr["second_address"].ToString();
                        obj1.country_id = Guid.Parse(dr["country_id"].ToString());
                        obj1.state_id = Guid.Parse(dr["state_id"].ToString());
                        obj1.city_id = Guid.Parse(dr["city_id"].ToString());
                        obj1.area_id = Guid.Parse(dr["area_id"].ToString());
                        obj1.zipcode = dr["zipcode"].ToString();
                        obj1.AddDate = Convert.ToDateTime(dr["AddDate"].ToString());
                        obj1.Addby = dr["Addby"].ToString();
                        obj1.EditDate = Convert.ToDateTime(dr["EditDate"].ToString());
                        obj1.Editby = dr["Editby"].ToString();
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

        public void Delete(patient_Next_of_kinBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_Next_of_kin_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_Next_of_kin_id", SqlDbType.UniqueIdentifier).Value = obj.patient_Next_of_kin_id;
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
