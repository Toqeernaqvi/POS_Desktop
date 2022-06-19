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
    class patient_contact_addressDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(patient_contact_addressBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_contact_address_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@home_phone", SqlDbType.VarChar).Value = obj.home_phone;
                cmd.Parameters.Add("@personal_phone", SqlDbType.VarChar).Value = obj.personal_phone;
                cmd.Parameters.Add("@office_phone", SqlDbType.VarChar).Value = obj.office_phone;
                cmd.Parameters.Add("@first_address", SqlDbType.VarChar).Value = obj.first_address;
                cmd.Parameters.Add("@second_address", SqlDbType.VarChar).Value = obj.second_address;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.area_id;
                cmd.Parameters.Add("@zipcode", SqlDbType.Int).Value = obj.zipcode;
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

        public void Update(patient_contact_addressBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_contact_address_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_contact_address_id", SqlDbType.UniqueIdentifier).Value = obj.patient_contact_address_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@home_phone", SqlDbType.VarChar).Value = obj.home_phone;
                cmd.Parameters.Add("@personal_phone", SqlDbType.VarChar).Value = obj.personal_phone;
                cmd.Parameters.Add("@office_phone", SqlDbType.VarChar).Value = obj.office_phone;
                cmd.Parameters.Add("@first_address", SqlDbType.VarChar).Value = obj.first_address;
                cmd.Parameters.Add("@second_address", SqlDbType.VarChar).Value = obj.second_address;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.area_id;
                cmd.Parameters.Add("@zipcode", SqlDbType.Int).Value = obj.zipcode;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@editdate", SqlDbType.VarChar).Value = obj.EditDate;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public List<patient_contact_addressBAL> LoadbyId(patient_contact_addressBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_contact_addressBAL> listt = new List<patient_contact_addressBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_contact_address_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_contact_address_id", SqlDbType.UniqueIdentifier).Value = obj.patient_contact_address_id;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_contact_addressBAL obj1 = new patient_contact_addressBAL();
                        obj1.patient_contact_address_id = Guid.Parse(dr["patient_contact_address_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.email = dr["email"].ToString();
                        obj1.home_phone = dr["home_phone"].ToString();
                        obj1.personal_phone = dr["personal_phone"].ToString();
                        obj1.office_phone = dr["office_phone"].ToString();
                        obj1.first_address = dr["first_address"].ToString();
                        obj1.second_address = dr["second_address"].ToString();
                        obj1.country_id = Guid.Parse(dr["country_id"].ToString());
                        obj1.state_id = Guid.Parse(dr["state_id"].ToString());
                        obj1.city_id = Guid.Parse(dr["city_id"].ToString());
                        obj1.area_id = Guid.Parse(dr["area_id"].ToString());
                        obj1.zipcode = Convert.ToInt32(dr["zipcode"].ToString());
                        obj1.Addby = dr["add_by"].ToString();
                        obj1.AddDate = Convert.ToDateTime(dr["add_date"].ToString());
                        obj1.Editby = dr["edit_by"].ToString();
                        obj1.EditDate = dr["edit_date"].ToString();
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

        public List<patient_contact_addressBAL> LoadAll()
        {
            try
            {
                //Local

                //   SqlDataReader dr;
                //           List<patient_contact_addressBAL> listt = new List<patient_contact_addressBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_contact_address_LOADALL";
                cmd.Parameters.Clear();
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd.ExecuteNonQuery();
                con.Close();
                sa.SelectCommand = cmd;
                sa.Fill(dt);

                //     id = row.Field<string>("id"),
                //   name = row.Field<string>("name")
                List<patient_contact_addressBAL> listt = dt.AsEnumerable().Select(row =>
                new patient_contact_addressBAL
                {
                    patient_id = Guid.Parse(row.Field<int>("patient_id").ToString()),
                    email = row.Field<string>("email").ToString(),
                    home_phone = row.Field<string>("home_phone").ToString(),
                    personal_phone = row.Field<string>("personal_phone").ToString(),
                    office_phone = row.Field<string>("office_phone").ToString(),
                    first_address = row.Field<string>("first_address").ToString(),
                    second_address = row.Field<string>("second_address").ToString(),
                    country_id = Guid.Parse(row.Field<int>("country_id").ToString()),
                    state_id = Guid.Parse(row.Field<int>("state_id").ToString()),
                    city_id = Guid.Parse(row.Field<int>("city_id").ToString()),
                    area_id = Guid.Parse(row.Field<int>("area_id").ToString()),
                    zipcode = Convert.ToInt32(row.Field<int>("zipcode").ToString()),
                    AddDate = Convert.ToDateTime(row.Field<DateTime>("AddDate").ToString()).Date,
                    Addby = row.Field<string>("Addby").ToString(),
                    Editby = row.Field<string>("Editby").ToString(),
                    EditDate = row.Field<string>("EditDate").ToString(),
                    status = Convert.ToBoolean(row.Field<bool>("status").ToString())
                }).ToList();



                //dr = cmd.ExecuteReader();
                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        patient_contact_addressBAL obj1 = new patient_contact_addressBAL();
                //float x=0;                obj1.patient_contact_address_id = Convert.ToInt32(dr["patient_contact_address_id"].ToString());
                //obj1.patient_id = Convert.ToInt32(dr["patient_id"].ToString());
                //obj1.email = dr["email"].ToString();
                //obj1.home_phone = dr["home_phone"].ToString();
                //obj1.personal_phone = dr["personal_phone"].ToString();
                //obj1.office_phone = dr["office_phone"].ToString();
                //obj1.first_address = dr["first_address"].ToString();
                //obj1.second_address = dr["second_address"].ToString();
                //obj1.country_id = Convert.ToInt32(dr["country_id"].ToString());
                //obj1.state_id = Convert.ToInt32(dr["state_id"].ToString());
                //obj1.city_id = Convert.ToInt32(dr["city_id"].ToString());
                //obj1.area_id = Convert.ToInt32(dr["area_id"].ToString());
                //obj1.zipcode = Convert.ToInt32(dr["zipcode"].ToString());
                //obj1.add_by = dr["add_by"].ToString();
                //obj1.add_date =Convert.ToDateTime( dr["add_date"].ToString());
                //obj1.edit_by = dr["edit_by"].ToString();
                //obj1.edit_date = dr["edit_date"].ToString();
                //obj1.status =(bool) dr["status"];
                //listt.Add(obj1);
                //}
                //  }
                //  dr.Close();
                return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<patient_contact_addressBAL> Search(patient_contact_addressBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<patient_contact_addressBAL> listt = new List<patient_contact_addressBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_contact_address_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_contact_address_id", SqlDbType.UniqueIdentifier).Value = obj.patient_contact_address_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@home_phone", SqlDbType.VarChar).Value = obj.home_phone;
                cmd.Parameters.Add("@personal_phone", SqlDbType.VarChar).Value = obj.personal_phone;
                cmd.Parameters.Add("@office_phone", SqlDbType.VarChar).Value = obj.office_phone;
                cmd.Parameters.Add("@first_address", SqlDbType.VarChar).Value = obj.first_address;
                cmd.Parameters.Add("@second_address", SqlDbType.VarChar).Value = obj.second_address;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;
                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.area_id;
                cmd.Parameters.Add("@zipcode", SqlDbType.Int).Value = obj.zipcode;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@adddate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@editdate", SqlDbType.VarChar).Value = obj.EditDate;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        patient_contact_addressBAL obj1 = new patient_contact_addressBAL();
                        float x = 0; obj1.patient_contact_address_id = Guid.Parse(dr["patient_contact_address_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.email = dr["email"].ToString();
                        obj1.home_phone = dr["home_phone"].ToString();
                        obj1.personal_phone = dr["personal_phone"].ToString();
                        obj1.office_phone = dr["office_phone"].ToString();
                        obj1.first_address = dr["first_address"].ToString();
                        obj1.second_address = dr["second_address"].ToString();
                        obj1.country_id = Guid.Parse(dr["country_id"].ToString());
                        obj1.state_id = Guid.Parse(dr["state_id"].ToString());
                        obj1.city_id = Guid.Parse(dr["city_id"].ToString());
                        obj1.area_id = Guid.Parse(dr["area_id"].ToString());
                        obj1.zipcode = Convert.ToInt32(dr["zipcode"].ToString());
                        obj1.Addby = dr["Addby"].ToString();
                        obj1.AddDate = Convert.ToDateTime(dr["AddDate"].ToString());
                        obj1.Editby = dr["Editby"].ToString();
                        obj1.EditDate = dr["EditDate"].ToString();
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

        public void Delete(patient_contact_addressBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "patient_contact_address_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@patient_contact_address_id", SqlDbType.UniqueIdentifier).Value = obj.patient_contact_address_id;
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
