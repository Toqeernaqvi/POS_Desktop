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
    class PartyDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(PartyBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Party_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = obj.add;
                cmd.Parameters.Add("@National_Tax_Number", SqlDbType.VarChar).Value = obj.National_Tax_Number;
                cmd.Parameters.Add("@Goods_And_Services_Tax", SqlDbType.VarChar).Value = obj.Goods_And_Services_Tax;
                cmd.Parameters.Add("@Guarranty", SqlDbType.VarChar).Value = obj.Guarranty;
                cmd.Parameters.Add("@Standard_Report_Number", SqlDbType.VarChar).Value = obj.Standard_Report_Number;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = obj.phone;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@Bank_account_number", SqlDbType.VarChar).Value = obj.Bank_account_number;
                cmd.Parameters.Add("@International_Account_Number", SqlDbType.VarChar).Value = obj.Internation_Account_Number;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.Addby;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = obj.Flag;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(PartyBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Party_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@p_id", SqlDbType.UniqueIdentifier).Value = obj.p_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = obj.add;
                cmd.Parameters.Add("@National_Tax_Number", SqlDbType.VarChar).Value = obj.National_Tax_Number;
                cmd.Parameters.Add("@Goods_And_Services_Tax", SqlDbType.VarChar).Value = obj.Goods_And_Services_Tax;
                cmd.Parameters.Add("@Guarranty", SqlDbType.VarChar).Value = obj.Guarranty;
                cmd.Parameters.Add("@Standard_Report_Number", SqlDbType.VarChar).Value = obj.Standard_Report_Number;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = obj.phone;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@Bank_account_number", SqlDbType.VarChar).Value = obj.Bank_account_number;
                cmd.Parameters.Add("@International_Account_Number", SqlDbType.VarChar).Value = obj.Internation_Account_Number;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.Editby;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable LoadbyId(Guid id)
        {
            try
            {
                //Local

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Party_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@p_id", SqlDbType.UniqueIdentifier).Value = id;
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
                //Local

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Party_LOADALL";
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


        public void Delete(PartyBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Party_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@p_id", SqlDbType.UniqueIdentifier).Value = obj.p_id;
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
