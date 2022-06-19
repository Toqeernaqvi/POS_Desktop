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
    class StudentDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        public void Add(StudentBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "student_Insert";
               

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@fathername", SqlDbType.VarChar).Value = obj.fathername;
             
                cmd.Parameters.Add("@mob", SqlDbType.VarChar).Value = obj.mobile;
             //   cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = obj.tel;
                cmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = obj.cnic;
                cmd.Parameters.Add("@session", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
               // cmd.Parameters.Add("@parenttype", SqlDbType.VarChar).Value = obj.ParentType;
                // cmd.Parameters.Add("@Session_id", SqlDbType.Int).Value       = obj.Session_id;
                cmd.Parameters.Add("@reg_id", SqlDbType.VarChar).Value = obj.registration;
                cmd.Parameters.Add("@rollno", SqlDbType.VarChar).Value = obj.rollno;

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.classid;
                cmd.Parameters.Add("@section", SqlDbType.UniqueIdentifier).Value = obj.section;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = obj.d_b;

                cmd.Parameters.Add("@DOA", SqlDbType.DateTime).Value = obj.d_a;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@img", SqlDbType.NVarChar).Value = obj.img;
               // cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;

                cmd.Parameters.Add("@stat", SqlDbType.TinyInt).Value = obj.status;
                cmd.Parameters.Add("@Add_date", SqlDbType.DateTime).Value = obj.Add_Date;
                cmd.Parameters.Add("@Add_by", SqlDbType.UniqueIdentifier).Value = obj.Add_by;
                cmd.Parameters.Add("@urdu_name", SqlDbType.VarChar).Value = obj.urdu_name;
               cmd.Parameters.Add("@gend", SqlDbType.VarChar).Value = obj.gender;
                cmd.Parameters.Add("@urduFname", SqlDbType.VarChar).Value = obj.urdu_fname;
                cmd.Parameters.Add("@urdu_add", SqlDbType.VarChar).Value = obj.addresurdu;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;

                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.area_id;

                cmd.Parameters.Add("@subj", SqlDbType.UniqueIdentifier).Value = obj.subjects;
                cmd.Parameters.Add("@orgID", SqlDbType.UniqueIdentifier).Value = obj.Organization;

                //cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                //cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
           
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void Update(StudentBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "student_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@fathername", SqlDbType.VarChar).Value = obj.fathername;

                cmd.Parameters.Add("@mob", SqlDbType.VarChar).Value = obj.mobile;
                //   cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = obj.tel;
                cmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = obj.cnic;
                cmd.Parameters.Add("@session", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
                // cmd.Parameters.Add("@parenttype", SqlDbType.VarChar).Value = obj.ParentType;
                // cmd.Parameters.Add("@Session_id", SqlDbType.Int).Value       = obj.Session_id;
                cmd.Parameters.Add("@reg_id", SqlDbType.VarChar).Value = obj.registration;
                cmd.Parameters.Add("@rollno", SqlDbType.VarChar).Value = obj.rollno;

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.classid;
                cmd.Parameters.Add("@section", SqlDbType.UniqueIdentifier).Value = obj.section;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = obj.d_b;

                cmd.Parameters.Add("@DOA", SqlDbType.DateTime).Value = obj.d_a;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@img", SqlDbType.NVarChar).Value = obj.img;
                // cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;

                cmd.Parameters.Add("@stat", SqlDbType.TinyInt).Value = obj.status;
                cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_Date;
                cmd.Parameters.Add("@Edit_by", SqlDbType.UniqueIdentifier).Value = obj.Edit_By;
                cmd.Parameters.Add("@urdu_name", SqlDbType.VarChar).Value = obj.urdu_name;
                cmd.Parameters.Add("@gend", SqlDbType.VarChar).Value = obj.gender;
                cmd.Parameters.Add("@urduFname", SqlDbType.VarChar).Value = obj.urdu_fname;
                cmd.Parameters.Add("@urdu_add", SqlDbType.VarChar).Value = obj.addresurdu;
                cmd.Parameters.Add("@country_id", SqlDbType.UniqueIdentifier).Value = obj.country_id;

                cmd.Parameters.Add("@state_id", SqlDbType.UniqueIdentifier).Value = obj.state_id;
                cmd.Parameters.Add("@city_id", SqlDbType.UniqueIdentifier).Value = obj.city_id;
                cmd.Parameters.Add("@area_id", SqlDbType.UniqueIdentifier).Value = obj.area_id;

                cmd.Parameters.Add("@subj", SqlDbType.UniqueIdentifier).Value = obj.subjects;
                cmd.Parameters.Add("@orgID", SqlDbType.UniqueIdentifier).Value = obj.Organization;

                cmd.ExecuteNonQuery();
                con.Close();



            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        public DataTable LoadByBranch(StudentBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "student_GetbyBranch";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
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
        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "student_geAll";
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

      

        public DataTable LoadAllas()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "student_GetallAs";
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


       

        public void Delete(StudentBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "student_Delete";
                cmd.Parameters.AddWithValue("@id", obj.id);
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