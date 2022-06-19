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
    class EmployeePersonalInfoDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

    

        public void Add(EmployeePersonalInfoBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoInsert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = obj.firstname;

                cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = obj.lastname;
                cmd.Parameters.Add("@registration", SqlDbType.VarChar).Value = obj.registration;

                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = obj.dob;

                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = obj.phone;

                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;


                //     cmd.Parameters.Add("@Martial_status", SqlDbType.VarChar).Value = obj.Martial_status;

                //     cmd.Parameters.Add("@Refrence", SqlDbType.VarChar).Value = obj.Refrence;

                //     cmd.Parameters.Add("@Parent_CNIC", SqlDbType.VarChar).Value = obj.Parent_CNIC;

                //      cmd.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = obj.CNIC;


                cmd.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = obj.CNIC;

                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;

                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;

                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;

                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.area_id;

                cmd.Parameters.Add("@address_type", SqlDbType.VarChar).Value = obj.address_type;

                cmd.Parameters.Add("@address1", SqlDbType.VarChar).Value = obj.address1;

                cmd.Parameters.Add("@address2", SqlDbType.VarChar).Value = obj.address2;
                cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;

                cmd.Parameters.Add("@dept_id", SqlDbType.UniqueIdentifier).Value = obj.dept_id;

                cmd.Parameters.Add("@office_id", SqlDbType.UniqueIdentifier).Value = obj.office_id;

                cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.section_id;

 
                cmd.Parameters.Add("@attendance_type", SqlDbType.VarChar).Value = obj.attendance_type;
                cmd.Parameters.Add("@ntn_Number", SqlDbType.VarChar).Value = obj.ntn_Number;
                cmd.Parameters.Add("@profile_PicPath", SqlDbType.NVarChar).Value = obj.profile_PicPath;

                //cmd.Parameters.Add("@img", SqlDbType.VarChar).Value = obj.img;

                cmd.ExecuteNonQuery();
                con.Close();
                //employee_id int Unchecked
                //firstname varchar(50) Unchecked
                //lastname    varchar(50) Unchecked
                //dob date    Unchecked
                //phone   varchar(50) Unchecked
                //email   varchar(50) Unchecked
                //country_id  int Unchecked
                //state_id    int Unchecked
                //city_id int Unchecked
                //area_id int Unchecked
                //address_type    varchar(50) Unchecked
                //address1    varchar(50) Unchecked
                //address2    varchar(50) Unchecked
                //skill   varchar(50) Unchecked
                //dept_id int Unchecked
                //office_id   int Unchecked
                //section_id  int Unchecked
                //date_of_join    date    Unchecked


            }

           
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(EmployeePersonalInfoBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoUpdate";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = obj.firstname;

                cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = obj.lastname;
                cmd.Parameters.Add("@registration", SqlDbType.VarChar).Value = obj.registration;

                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = obj.dob;

                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = obj.phone;

                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;


                //     cmd.Parameters.Add("@Martial_status", SqlDbType.VarChar).Value = obj.Martial_status;

                //     cmd.Parameters.Add("@Refrence", SqlDbType.VarChar).Value = obj.Refrence;

                //     cmd.Parameters.Add("@Parent_CNIC", SqlDbType.VarChar).Value = obj.Parent_CNIC;

                //      cmd.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = obj.CNIC;


                cmd.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = obj.CNIC;

                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;

                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;

                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;

                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.area_id;

                cmd.Parameters.Add("@address_type", SqlDbType.VarChar).Value = obj.address_type;

                cmd.Parameters.Add("@address1", SqlDbType.VarChar).Value = obj.address1;

                cmd.Parameters.Add("@address2", SqlDbType.VarChar).Value = obj.address2;
                cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
                cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;

                cmd.Parameters.Add("@dept_id", SqlDbType.UniqueIdentifier).Value = obj.dept_id;

                cmd.Parameters.Add("@office_id", SqlDbType.UniqueIdentifier).Value = obj.office_id;

                cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.section_id;


                cmd.Parameters.Add("@attendance_type", SqlDbType.VarChar).Value = obj.attendance_type;
                cmd.Parameters.Add("@ntn_Number", SqlDbType.VarChar).Value = obj.ntn_Number;
                cmd.Parameters.Add("@profile_PicPath", SqlDbType.NVarChar).Value = obj.profile_PicPath;


                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;


                //cmd.Parameters.Add("@img", SqlDbType.VarChar).Value = obj.img;
                cmd.ExecuteNonQuery();
                con.Close();



                //Web

                //MySqlDataAdapter da = new MySqlDataAdapter();
                //mycon.Open();
                //mycmd.Connection = mycon;
                //mycmd.CommandText = "UPDATE TBMD_Country SET Country.Web = False WHERE Country.id = " + obj.employee_id;
                //mycmd.ExecuteNonQuery();
                //mycmd.Dispose();
                //mycon.Close();
            }

          
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
                cmd.CommandText = "Employee_PersonalInfoLoadALL";
                cmd.Parameters.Clear();

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
        public DataTable Search(EmployeePersonalInfoBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_Search";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = obj.firstname;
                cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = obj.lastname;
                cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = obj.dob;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = obj.phone;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                // cmd.Parameters.Add("@Martial_status", SqlDbType.VarChar).Value = obj.Martial_status;
                // cmd.Parameters.Add("@Refrence", SqlDbType.VarChar).Value = obj.Refrence;
                // cmd.Parameters.Add("@Parent_CNIC", SqlDbType.VarChar).Value = obj.Parent_CNIC;
                cmd.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = obj.CNIC;
                cmd.Parameters.Add("@address_type", SqlDbType.VarChar).Value = obj.address_type;
                cmd.Parameters.Add("@address1", SqlDbType.VarChar).Value = obj.address1;
                cmd.Parameters.Add("@address2", SqlDbType.VarChar).Value = obj.address2;
                 cmd.Parameters.Add("@attendance_type", SqlDbType.VarChar).Value = obj.attendance_type;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public int getid()
        {
            try
            {
                int employee_id = 0;
                SqlDataReader dr;
                int count = 0, rowcount = 0;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoGetid";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rowcount++;
                    employee_id = (int)dr["ID"];
                }




                dr.Close();
                con.Close();

                return employee_id;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return 0;
        }

        public int getidbyname(string firstname)
        {
            try
            {
                int employee_id = 0;
                SqlDataReader dr;
                int count = 0, rowcount = 0;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoGetidbyName";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = firstname;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    employee_id = (int)dr["ID"];
                }

                dr.Close();
                con.Close();

                return employee_id;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return 0;
        }
        public DataTable LoadByRegistration(EmployeePersonalInfoBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[Employee_PersonalInfoLoadByRegistration]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@registration", SqlDbType.VarChar).Value = obj.registration;
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
        public DataTable LoadbyID(EmployeePersonalInfoBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoLoadbyID";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@employee_id", SqlDbType.UniqueIdentifier).Value = obj.employee_id;
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
        public DataTable LoadbyDept(EmployeePersonalInfoBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoLoadbyDept";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@dept_id", SqlDbType.UniqueIdentifier).Value = obj.dept_id;
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
        public DataTable LoadbyOffice(EmployeePersonalInfoBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoLoadbyOffice";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@office_id", SqlDbType.UniqueIdentifier).Value = obj.office_id;
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
        public void Delete(EmployeePersonalInfoBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Employee_PersonalInfoDelete";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@employee_id", obj.employee_id);
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
