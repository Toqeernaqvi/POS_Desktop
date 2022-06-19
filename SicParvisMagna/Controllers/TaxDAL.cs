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
    class TaxDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public Guid Add(TaxBAL obj)
        {
            Guid TaxID = Guid.Empty;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Tax_Insert";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@decrip", SqlDbType.VarChar).Value = obj.Descrip;
                cmd.Parameters.Add("@shtname", SqlDbType.VarChar).Value = obj.ShortName;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@taxper", SqlDbType.VarChar).Value = obj.TaxPercen;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@tms", SqlDbType.DateTime).Value = obj.TimeStamp;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;

                TaxID = (Guid)cmd.ExecuteScalar();
                con.Close();
                return TaxID;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            return TaxID;

        }
        public void Update(TaxBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Tax_Update";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@decrip", SqlDbType.VarChar).Value = obj.Descrip;
                cmd.Parameters.Add("@shtname", SqlDbType.VarChar).Value = obj.ShortName;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@taxper", SqlDbType.VarChar).Value = obj.TaxPercen;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.EditBy;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.TaxID;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
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
                cmd.CommandText = "sp_Tax_SelectAll";
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

        public DataTable LoadByID(Guid id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.CommandText = "sp_Tax_SelectById";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = id;
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
        public void Delete(TaxBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Tax_Delete_by_Id";
                cmd.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = obj.TaxID;
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
