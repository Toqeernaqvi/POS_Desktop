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
    class Medicine_CategoryDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(Medicine_CategoryBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Category_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
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

        public void Update(Medicine_CategoryBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Category_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Medicine_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Medicine_Category_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
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

        public List<Medicine_CategoryBAL> LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<Medicine_CategoryBAL> listt = new List<Medicine_CategoryBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Category_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Medicine_Category_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Medicine_CategoryBAL obj1 = new Medicine_CategoryBAL();
                        float x = 0; obj1.Medicine_Category_id = Guid.Parse(dr["Medicine_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.description = dr["description"].ToString();
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

        public List<Medicine_CategoryBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<Medicine_CategoryBAL> listt = new List<Medicine_CategoryBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Category_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Medicine_CategoryBAL obj1 = new Medicine_CategoryBAL();
                        obj1.Medicine_Category_id = Guid.Parse(dr["Medicine_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.AddDate = Convert.ToDateTime(dr["AddDate"].ToString());
                        obj1.Addby = dr["Addby"].ToString();
                        //obj1.EditDate = Convert.ToDateTime(dr["EditDate"].ToString());
                        //obj1.Editby = dr["Editby"].ToString();
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

        public List<Medicine_CategoryBAL> Search(string str)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<Medicine_CategoryBAL> listt = new List<Medicine_CategoryBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Category_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Medicine_Category_id", SqlDbType.UniqueIdentifier).Value = str;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = str;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = str;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = str;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = str;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Medicine_CategoryBAL obj1 = new Medicine_CategoryBAL();
                        float x = 0; obj1.Medicine_Category_id = Guid.Parse(dr["Medicine_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.description = dr["description"].ToString();
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

        public void Delete(Medicine_CategoryBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Category_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Medicine_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Medicine_Category_id;
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
