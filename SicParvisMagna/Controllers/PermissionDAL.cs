using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicCRUD.Models;
using SicParvisMagna.Library;

namespace BasicCRUD.Controllers
{
    class PermissionDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;

        
        public void Add(PermissionBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Permission_Insert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@peruid", SqlDbType.VarChar).Value = obj.PerUID;
                cmd.Parameters.Add("@pgid", SqlDbType.UniqueIdentifier).Value = obj.PgID;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@peradd", SqlDbType.VarChar).Value = obj.PerAdd;
                cmd.Parameters.Add("@peredit", SqlDbType.VarChar).Value = obj.PerEdit;
                cmd.Parameters.Add("@perview", SqlDbType.VarChar).Value = obj.PerView;
                cmd.Parameters.Add("@perdel", SqlDbType.VarChar).Value = obj.PerDel;
                cmd.Parameters.Add("@tms", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Add_withRole(PermissionBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Permission_Insert_byRole";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@peruid", SqlDbType.VarChar).Value = obj.PerUID;
                cmd.Parameters.Add("@pgid", SqlDbType.UniqueIdentifier).Value = obj.PgID;
                cmd.Parameters.Add("@roleid", SqlDbType.UniqueIdentifier).Value = obj.RoleID;
                cmd.Parameters.Add("@peradd", SqlDbType.VarChar).Value = obj.PerAdd;
                cmd.Parameters.Add("@peredit", SqlDbType.VarChar).Value = obj.PerEdit;
                cmd.Parameters.Add("@perview", SqlDbType.VarChar).Value = obj.PerView;
                cmd.Parameters.Add("@perdel", SqlDbType.VarChar).Value = obj.PerDel;
                cmd.Parameters.Add("@tms", SqlDbType.DateTime).Value = obj.Timestamp;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void Update(PermissionBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Permission_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.PerID;
                // cmd.Parameters.Add("@peruid", SqlDbType.VarChar).Value = obj.PerUID;
                // cmd.Parameters.Add("@pgid", SqlDbType.Int).Value = obj.PgID;
                // cmd.Parameters.Add("@userid", SqlDbType.Int).Value = obj.User_id;
                cmd.Parameters.Add("@peradd", SqlDbType.VarChar).Value = obj.PerAdd;
                cmd.Parameters.Add("@peredit", SqlDbType.VarChar).Value = obj.PerEdit;
                cmd.Parameters.Add("@perview", SqlDbType.VarChar).Value = obj.PerView;
                cmd.Parameters.Add("@perdel", SqlDbType.VarChar).Value = obj.PerDel;
                //cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                //cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                //cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.EditBy;
                //cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void UpdateUserId_Roles(PermissionBAL obj)
        {
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Permission_UpdateUserId";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@roleid", SqlDbType.UniqueIdentifier).Value = obj.RoleID;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                


                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private static void initializeConnection()
        {
            staticcon = new SQLCon().getCon();
            staticcmd = new SqlCommand();
        }
        public static DataTable Permission(Guid userid, string pgURL, Boolean PerView)
        {
            try
            {
                initializeConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                staticcon.Open();
                staticcmd.Connection = staticcon;
                staticcmd.CommandType = CommandType.StoredProcedure;
                staticcmd.CommandText = "sp_Permission_LoadPagesPermission";
                
                //staticcmd.Parameters.Clear();
                staticcmd.Parameters.AddWithValue("@userid", userid);
                staticcmd.Parameters.AddWithValue("@pgURL", pgURL);
                staticcmd.Parameters.AddWithValue("@PerView", PerView);
                staticcmd.ExecuteNonQuery();
                staticcon.Close();
                da.SelectCommand = staticcmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public static DataTable Permission_Level(Guid userid, string pgURL, Boolean PerView)
        {
            try
            {
                initializeConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                staticcon.Open();
                staticcmd.Connection = staticcon;
                staticcmd.CommandType = CommandType.StoredProcedure;
                staticcmd.CommandText = "sp_Permission_LoadPagesPermission_by_Level";

                //staticcmd.Parameters.Clear();
                staticcmd.Parameters.AddWithValue("@userid", userid);
                staticcmd.Parameters.AddWithValue("@pgURL", pgURL);
                staticcmd.Parameters.AddWithValue("@PerView", PerView);
                staticcmd.ExecuteNonQuery();
                staticcon.Close();
                da.SelectCommand = staticcmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public static DataTable SaveButtonPermission(Guid userid, string pgURL, Boolean PerAdd)
        {
            try
            {

                initializeConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                staticcon.Open();
                staticcmd.Connection = staticcon;
                staticcmd.CommandType = CommandType.StoredProcedure;
                staticcmd.CommandText = "sp_Permission_SaveButtonPermission";
                staticcmd.Parameters.Clear();
                staticcmd.Parameters.AddWithValue("@Userid", userid);
                staticcmd.Parameters.AddWithValue("@pgURL", pgURL);
                staticcmd.Parameters.AddWithValue("@PerAdd", PerAdd);
                
                staticcmd.ExecuteNonQuery();
                staticcon.Close();
                da.SelectCommand = staticcmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public static DataTable EditButtonPermission(Guid userid, string pgURL, Boolean PerEdit)
        {
            try
            {

                initializeConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                staticcon.Open();
                staticcmd.Connection = staticcon;
                staticcmd.CommandType = CommandType.StoredProcedure;
                staticcmd.CommandText = "sp_Permission_SaveButtonPermission";
                staticcmd.Parameters.Clear();
                staticcmd.Parameters.AddWithValue("@Userid", userid);
                staticcmd.Parameters.AddWithValue("@pgURL", pgURL);
                staticcmd.Parameters.AddWithValue("@PerAdd", PerEdit);

                staticcmd.ExecuteNonQuery();
                staticcon.Close();
                da.SelectCommand = staticcmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public static DataTable DeleteButtonPermission(Guid userid, string pgURL, Boolean PerDel)
        {
            try
            {
                initializeConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                staticcon.Open();
                staticcmd.Connection = staticcon;
                staticcmd.CommandType = CommandType.StoredProcedure;
                staticcmd.CommandText = "sp_Permission_DeleteButtonPermission";
                staticcmd.Parameters.Clear();
                staticcmd.Parameters.AddWithValue("@Userid", userid);
                staticcmd.Parameters.AddWithValue("@pgURL", pgURL);
                staticcmd.Parameters.AddWithValue("@PerDel", PerDel);

                staticcmd.ExecuteNonQuery();
                staticcon.Close();
                da.SelectCommand = staticcmd;
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
                cmd.CommandText = "sp_Permission_LoadAll";
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
        public DataTable loadByUser(PermissionBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Permission_LoadByUser";
                cmd.Parameters.AddWithValue("@Userid", obj.User_id);
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

        public DataTable loadByRole(PermissionBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Permission_LoadByRole";
                cmd.Parameters.AddWithValue("@roleid", obj.RoleID);
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
        public DataTable loadPermission(PermissionBAL obj)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Permission_LoadByPermission";
                cmd.Parameters.AddWithValue("@id", obj.User_id);
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

        public void Delete(PermissionBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Permission_Delete";
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.PerID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //public static DataTable AssignPermissions(PermissionBAL objPerBal)
        //{
        //    try
        //    {
        //        initializeConnection();
        //        SqlDataAdapter da = new SqlDataAdapter();
        //        DataTable dt = new DataTable();
        //        staticcon.Open();
        //        staticcmd.Connection = staticcon;
        //        staticcmd.CommandType = CommandType.StoredProcedure;
        //        staticcmd.CommandText = "sp_Permission_DeleteButtonPermission";
        //        staticcmd.Parameters.Clear();

         
        //        staticcmd.ExecuteNonQuery();
        //        staticcon.Close();

        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }

        //}
    }
}
