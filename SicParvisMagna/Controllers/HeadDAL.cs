using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicCRUD.Models;
using SicParvisMagna.Models;
using SicParvisMagna.Library;

namespace SicParvisMagna.Controllers
{
    class HeadDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public DataTable getHeads()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeads";
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getHeads_SuperAdmin()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHead_SuperAdmin";
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getHeads_BranchAdmin(Guid Org_id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHead_BranchAdmin";
            cmd.Parameters.Add("@Org_id", SqlDbType.UniqueIdentifier).Value = Org_id;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getHeads_Operator(Guid Branch_id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHead_Operator";
            cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = Branch_id;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getHeadsFee()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeadsFee";
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
         }
 
      
        public DataTable getHeadsFee(Guid classid, string type)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeadsFeeClassType";
            cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = classid;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getHeadsFee(Guid deptid, Guid classid, string type)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeadsFeeDeptType";
            cmd.Parameters.Add("@dept_id", SqlDbType.UniqueIdentifier).Value = deptid;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getHeadsFee(Guid classid)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeadsFeeClass";
            cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = classid;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getHeadsFeeDept(Guid deptid)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeadsFeeDept";
            cmd.Parameters.Add("@dept_id", SqlDbType.UniqueIdentifier).Value = deptid;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getHeadsFee(string type)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getAllHeadsFeeType";
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void InsertHead(HeadBAL obj)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertHead";
            cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
            cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
            cmd.Parameters.Add("@Department_id", SqlDbType.UniqueIdentifier).Value = obj.Department_id;
            cmd.Parameters.Add("@Class_id", SqlDbType.UniqueIdentifier).Value = obj.Class_id;
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
            cmd.Parameters.Add("@short_name", SqlDbType.VarChar).Value = obj.ShortName;
            cmd.Parameters.Add("@amount", SqlDbType.VarChar).Value = obj.Ammount;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.Description;
            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value =  "Active";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateHead(HeadBAL obj)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateHead";
            cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
            cmd.Parameters.Add("@Organization_id", SqlDbType.UniqueIdentifier).Value = obj.Organization_id;
            cmd.Parameters.Add("@Branch_id", SqlDbType.UniqueIdentifier).Value = obj.Branch_id;
            cmd.Parameters.Add("@Department_id", SqlDbType.UniqueIdentifier).Value = obj.Department_id;
            cmd.Parameters.Add("@Class_id", SqlDbType.UniqueIdentifier).Value = obj.Class_id;
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = obj.Type;
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
            cmd.Parameters.Add("@short_name", SqlDbType.VarChar).Value = obj.ShortName;
            cmd.Parameters.Add("@amount", SqlDbType.VarChar).Value = obj.Ammount;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.Description;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SuspendHead(HeadBAL obj)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteHead";
            cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
