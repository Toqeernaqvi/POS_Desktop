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
    class Result_DAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
        // private MySqlConnection mycon = new MYSQLCon().getCon();
        //private MySqlCommand mycmd = new MySqlCommand();

        public void Add(Result_BAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "result_insert";
                cmd.Parameters.Add("@teachername", SqlDbType.VarChar).Value = obj.teachername;
                cmd.Parameters.Add("@totalmarks", SqlDbType.Int).Value = obj.TotalMarks;
                cmd.Parameters.Add("@obtainedmarks", SqlDbType.Real).Value = obj.ObtainedMarks;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.Date;
                cmd.Parameters.Add("@studentid", SqlDbType.UniqueIdentifier).Value = obj.studentid;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = obj.sectionid;
                cmd.Parameters.Add("@Session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
                cmd.Parameters.Add("@remarks", SqlDbType.VarChar).Value = obj.Remarks;
                cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = obj.SubjectId;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@Orgid", SqlDbType.UniqueIdentifier).Value = obj.OrganizationId;
                cmd.Parameters.Add("@teacher_id", SqlDbType.UniqueIdentifier).Value = obj.teacherid;
                cmd.Parameters.Add("@t_cat_id", SqlDbType.UniqueIdentifier).Value = obj.test_cat_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj.test_id;
                cmd.Parameters.Add("@std_tst", SqlDbType.VarChar).Value = obj.std_tst;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = obj.status;

                cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Add_by", SqlDbType.UniqueIdentifier).Value = obj.Add_by;
                cmd.Parameters.Add("@Add_Date", SqlDbType.DateTime).Value = obj.Add_Date;
                cmd.Parameters.Add("@PM", SqlDbType.Int).Value = obj.passing_marks;





                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        public void Update(Result_BAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "result_update";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@teachername", SqlDbType.VarChar).Value = obj.teachername;
                cmd.Parameters.Add("@totalmarks", SqlDbType.Int).Value = obj.TotalMarks;
                cmd.Parameters.Add("@obtainedmarks", SqlDbType.Real).Value = obj.ObtainedMarks;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.Date;
                cmd.Parameters.Add("@studentid", SqlDbType.UniqueIdentifier).Value = obj.studentid;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = obj.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = obj.sectionid;
                cmd.Parameters.Add("@Session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
                cmd.Parameters.Add("@remarks", SqlDbType.VarChar).Value = obj.Remarks;
                cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = obj.SubjectId;
                cmd.Parameters.Add("@branchid", SqlDbType.UniqueIdentifier).Value = obj.branchid;
                cmd.Parameters.Add("@Orgid", SqlDbType.UniqueIdentifier).Value = obj.OrganizationId;
                cmd.Parameters.Add("@teacher_id", SqlDbType.UniqueIdentifier).Value = obj.teacherid;
                cmd.Parameters.Add("@t_cat_id", SqlDbType.UniqueIdentifier).Value = obj.test_cat_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = obj.test_id;
                cmd.Parameters.Add("@std_tst", SqlDbType.VarChar).Value = obj.std_tst;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.userid;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = obj.status;

                cmd.Parameters.Add("@Local", SqlDbType.Bit).Value = obj.Local;
                cmd.Parameters.Add("@Web", SqlDbType.Bit).Value = obj.Web;
                cmd.Parameters.Add("@Edit_By", SqlDbType.UniqueIdentifier).Value = obj.Edit_By;
                cmd.Parameters.Add("@Edit_date", SqlDbType.DateTime).Value = obj.Edit_Date;
                cmd.Parameters.Add("@PM", SqlDbType.Int).Value = obj.passing_marks;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        public DataTable LoadbyClassSectionSubjectSession(Result_BAL objBal)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Result_Getby_ClassSectionSubjectSession";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = objBal.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = objBal.sectionid;
                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = objBal.Session_id;
                cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = objBal.SubjectId;

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


        public DataTable LoadbyC_S(Result_BAL objBal)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Result_Getby_ClassAndSection";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = objBal.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = objBal.sectionid;
                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = objBal.Session_id;

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

        public DataTable LoadbyC_S1(Result_BAL objBal)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Result_Getby_ClassAndSection1";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = objBal.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = objBal.sectionid;
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

        public DataTable LoadbyClassSectionSessionTest(Result_BAL objBal)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Result_Getby_ClassSectionSession";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = objBal.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = objBal.sectionid;
                cmd.Parameters.Add("@t_cat_id", SqlDbType.UniqueIdentifier).Value = objBal.test_cat_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = objBal.test_id;
                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = objBal.Session_id;
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



        public DataTable LoadbyClassSectionSubjectSessionTest(Result_BAL objBal)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Result_Getby_ClassAndSection_tt";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = objBal.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = objBal.sectionid;
                cmd.Parameters.Add("@t_cat_id", SqlDbType.UniqueIdentifier).Value = objBal.test_cat_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = objBal.test_id;
                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = objBal.Session_id;
                cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = objBal.SubjectId;
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


        public DataTable LoadbyClassSectionSubjectSessionTestt(Result_BAL objBal)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Result_Getby_ClassAndSection_tt";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = objBal.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = objBal.sectionid;
                cmd.Parameters.Add("@t_cat_id", SqlDbType.UniqueIdentifier).Value = objBal.test_cat_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = objBal.test_id;
                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = objBal.Session_id;
                cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = objBal.SubjectId;
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


        public DataTable LoadbyC_S_tt(Result_BAL objBal)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Result_Getby_ClassAndSection_tt";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = objBal.classid;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = objBal.sectionid;
                cmd.Parameters.Add("@t_cat_id", SqlDbType.UniqueIdentifier).Value = objBal.test_cat_id;
                cmd.Parameters.Add("@test_id", SqlDbType.UniqueIdentifier).Value = objBal.test_id;
                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = objBal.Session_id;
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

        public void updateStudentStatusByTest(Guid studentId, Guid testId, Guid sessionId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "[result_updateStudentStatusInTest]";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@studentid", SqlDbType.UniqueIdentifier).Value = studentId;
                cmd.Parameters.Add("@testid", SqlDbType.UniqueIdentifier).Value = testId;
                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = sessionId;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
            }
        }

        public DataTable getExistingTest(Guid session, Guid cls, Guid sct, Guid test_cat_id, Guid test_gen_id)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Result_Getby_ClassSectionSessionAndTest";

                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = session;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = cls;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = sct;
                cmd.Parameters.Add("@testcatid", SqlDbType.UniqueIdentifier).Value = test_cat_id;
                cmd.Parameters.Add("@testgenid", SqlDbType.UniqueIdentifier).Value = test_gen_id;
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

        public DataTable getExistingTest(Guid session, Guid cls, Guid sct, Guid subject, Guid test_cat_id, Guid test_gen_id)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Result_Getby_ClassSectionSessionSubjectAndTest";

                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = session;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = cls;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = sct;
                cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = subject;
                cmd.Parameters.Add("@testcatid", SqlDbType.UniqueIdentifier).Value = test_cat_id;
                cmd.Parameters.Add("@testgenid", SqlDbType.UniqueIdentifier).Value = test_gen_id;
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


        public DataTable getExistingTest(Guid session, Guid cls, Guid sct, Guid subject)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Result_Getby_ClassSectionSessionAndSubject";

                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = session;
                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = cls;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = sct;
                cmd.Parameters.Add("@subjectid", SqlDbType.UniqueIdentifier).Value = subject;

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

        public DataTable getExistingTest(Guid session, Guid cls, Guid sct)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Result_Getby_ClassSectionSessionOnly";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = cls;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = sct;
                cmd.Parameters.Add("@sessionid", SqlDbType.UniqueIdentifier).Value = session;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);



                con.Close();
                return dt;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }


        public bool checkExistingTest(Guid cls, Guid sct, Guid tcat, Guid tgen)
        {
            try
            {
                SqlDataReader dr;
                int count = 0;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Result_Getby_ClassAndSection2";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = cls;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = sct;

                cmd.Parameters.Add("@test_cat", SqlDbType.UniqueIdentifier).Value = tcat;
                cmd.Parameters.Add("@test_gen", SqlDbType.UniqueIdentifier).Value = tgen;

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        count++;
                    }
                }

                dr.Close();
                con.Close();

                return count < 1;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }


        public Result_BAL gethidevalues(Guid cls, Guid sct, Guid test_cat, Guid test_gen)
        {
            try
            {
                SqlDataReader dr;
                int count = 0;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Result_getHiddenValue";

                cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value = cls;
                cmd.Parameters.Add("@sectionid", SqlDbType.UniqueIdentifier).Value = sct;
                cmd.Parameters.Add("@test_cat", SqlDbType.UniqueIdentifier).Value = test_cat;
                cmd.Parameters.Add("@test_gen", SqlDbType.UniqueIdentifier).Value = test_gen;
                // cmd.Parameters.Add("@teachId", SqlDbType.UniqueIdentifier).Value = teachid;
                Result_BAL obj = new Result_BAL();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        count++;
                        if (count == 1)
                        {
                            obj.SubjectId = Guid.Empty;
                            obj.test_cat_id = Guid.Empty;
                            obj.test_id = Guid.Empty;
                            obj.teacherid = Guid.Empty;
                            obj.status = (int)dr["status"];
                            obj.userid = Guid.Empty;
                            obj.TotalMarks = (int)dr["totalmarks"];
                        }
                    }
                }

                dr.Close();
                con.Close();

                return obj;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }


        public void Delete(Result_BAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "result_delete";
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
