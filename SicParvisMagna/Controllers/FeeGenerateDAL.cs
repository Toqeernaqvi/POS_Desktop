using SicParvisMagna.Library;
using SicParvisMagna.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Controllers
{
    class FeeGenerateDAL
    {

       //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();



        public DataTable getHeads()
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeads";
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getHeadsFee()
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeadsFee";
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getStudentsbyFeeChallan(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getStudentsbyFeeChallan";
            cmd.Parameters.Add("@student_challan_id ", SqlDbType.UniqueIdentifier).Value = obj.fee_challan_id;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getHeadsbyStudentChallanDetails(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getHeadsbyStudentChallanDetails";
            cmd.Parameters.Add("@fee_challan_detail_id", SqlDbType.UniqueIdentifier).Value = obj.student_challan_detail_id;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }



        public DataTable saveStudentFee(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[saveStudentFee]";
            cmd.Parameters.Add("@student_challan_id", SqlDbType.UniqueIdentifier).Value = obj.student_challan_id;
            cmd.Parameters.Add("@student_id", SqlDbType.UniqueIdentifier).Value = obj.student_id;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = obj.deposited_amount;
            cmd.Parameters.Add("@RecieptNumber", SqlDbType.VarChar).Value = obj.RecieptNumber;
            cmd.Parameters.Add("@arrear", SqlDbType.Int).Value = obj.arrear;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable saveStudentArrear(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[saveStudentArrear]";
            cmd.Parameters.Add("@student_challan_id", SqlDbType.UniqueIdentifier).Value = obj.student_challan_id;
            cmd.Parameters.Add("@arrear", SqlDbType.Int).Value = obj.arrear;
            cmd.Parameters.Add("@discountAmount", SqlDbType.Int).Value = obj.discount_Amount;
            cmd.Parameters.Add("@discountPercentage", SqlDbType.Int).Value = obj.discount_Percentage;

            cmd.Parameters.Add("@student_id", SqlDbType.UniqueIdentifier).Value = obj.student_id;

            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getStudentChallanForFeeSubmittion(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetStudentChallanForFeeSubmittion";
            cmd.Parameters.Add("@student_challan_id", SqlDbType.UniqueIdentifier).Value = obj.student_challan_id;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public DataTable getStudentsForFeeSubmittionByChallan(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[getStudentsbyFeeChallan]";
            cmd.Parameters.Add("@student_challan_id", SqlDbType.Int).Value = obj.student_challan_id;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getStudentsForFeeSubmittionPaid(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[GetStudentsForFeeSubmittionPaid]";
            cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.class_id;
            cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.section_id;
            cmd.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.fee_month;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getStudentsForFeeSubmittionUnpaid(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[GetStudentsForFeeSubmittionUnpaid]";
            cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.class_id;
            cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.section_id;
            cmd.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.fee_month;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getStudentsForFeeSubmittionAll(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[GetStudentsForFeeSubmittion]";
            cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.class_id;
            cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.section_id;
            cmd.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.fee_month;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void deleteFeeChallanDetail(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();


            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteHeadsbyStudentChallanDetails";
            cmd.Parameters.Add("@student_challan_id", SqlDbType.UniqueIdentifier).Value = obj.student_challan_id;
            cmd.ExecuteNonQuery();

            con.Close();

        }
        public void suspendFeeChallan(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();


            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SuspendFeeChallan";
            cmd.Parameters.Add("@fee_challan_id", SqlDbType.Int).Value = obj.fee_challan_id;
            cmd.ExecuteNonQuery();

            con.Close();

        }

        public DataTable getAllHeadsFee_ExcludeIDs(string ids)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeadsFee_ExcludeIDs";
            cmd.Parameters.Add("@str", SqlDbType.VarChar).Value = ids.Substring(0, ids.Length - 1);
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable SelectQuery(string query)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void Query(string query)
        {
            SqlCommand cmd = new SqlCommand();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable getClassBySssionId(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetClassBySessionId";
            cmd.Parameters.Add("@class_id", SqlDbType.Int).Value = obj.class_id;
            cmd.Parameters.Add("@session_id", SqlDbType.Int).Value = obj.Session_id;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getClassById(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetClassById";
            cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.class_id;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getStudentsbySession(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getStudentsByClassSectionSession";
            cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.class_id;
            cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.section_id;
            cmd.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getStudents(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getStudentsByClassSection";
            cmd.Parameters.Add("@class_id", SqlDbType.Int).Value = obj.class_id;
            cmd.Parameters.Add("@section_id", SqlDbType.Int).Value = obj.section_id;
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getFeeGenerated()
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getFeeGenerated";
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public Guid  InsertFeeGenerate(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_FeeGenerate";
            cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
            cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
            cmd.Parameters.Add("@Department_id", SqlDbType.UniqueIdentifier).Value = obj.Department_id;
            cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = obj.class_id;
            cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = obj.section_id;
            //   cmd.Parameters.Add("@challan_number"  , SqlDbType.Int).Value               = obj.challan_number;
            cmd.Parameters.Add("@fee_month", SqlDbType.Date).Value = obj.fee_month;
            cmd.Parameters.Add("@fee_year", SqlDbType.Date).Value = obj.fee_year;
            cmd.Parameters.Add("@challan_given_date", SqlDbType.DateTime).Value = obj.challan_given_date;
            cmd.Parameters.Add("@challan_due_date", SqlDbType.DateTime).Value = obj.challan_due_date;
            //       cmd.Parameters.Add("@challan_produced_datetime", SqlDbType.DateTime).Value = obj.challan_produced_datetime;

            Guid newID = Guid.Empty;
            // if (!(cmd.ExecuteScalar() == null))
            newID = (Guid)cmd.ExecuteScalar();

            con.Close();
            return newID;
        }

        public Guid InsertStudentChallan(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_StudentChallan";
            cmd.Parameters.Add("@student_id", SqlDbType.UniqueIdentifier).Value = obj.student_id;
            cmd.Parameters.Add("@fee_challan_id", SqlDbType.UniqueIdentifier).Value = obj.fee_challan_id;
            cmd.Parameters.Add("@class_fee", SqlDbType.Int).Value = obj.class_fee;
            cmd.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = obj.Session_id;

            //        cmd.Parameters.Add("@deposited_date"        , SqlDbType.Date).Value              = obj.deposited_date;
            //       cmd.Parameters.Add("@deposited_amount"      , SqlDbType.Int).Value               = obj.deposited_amount;
            //      cmd.Parameters.Add("@arrear"                , SqlDbType.Int).Value               = obj.arrear;

            Guid newID = Guid.Empty;
            //   if (!(cmd.ExecuteScalar() == null))
            newID = (Guid)cmd.ExecuteScalar();

            con.Close();
            return newID;
        }

        public Guid InsertStudentChallanDetail(FeeGenerateBAL obj)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_StudentChallanDetail";
            cmd.Parameters.Add("@student_challan_id", SqlDbType.UniqueIdentifier).Value = obj.student_challan_id;
            cmd.Parameters.Add("@head_id", SqlDbType.UniqueIdentifier).Value = obj.head_id;

            Guid newID = Guid.Empty;
            //if (!(cmd.ExecuteScalar() == null))
            newID = (Guid)cmd.ExecuteScalar();

            con.Close();
            return newID;
        }

        public DataTable CheckMonthFeeGeneration(Guid classid, int month)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "check_Month_FeeGeneration";
            cmd.Parameters.Add("@classid", SqlDbType.UniqueIdentifier).Value =  classid;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value =  month;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
