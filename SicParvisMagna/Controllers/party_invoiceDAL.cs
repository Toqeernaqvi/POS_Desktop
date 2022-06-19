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
    class party_invoiceDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon(); private SqlCommand cmd = new SqlCommand();

        public void Add(party_invoiceBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@entry_no", SqlDbType.VarChar).Value = obj.entry_no;
                cmd.Parameters.Add("@customer_no", SqlDbType.Int).Value = obj.customer_no;
                cmd.Parameters.Add("@p_id", SqlDbType.UniqueIdentifier).Value = obj.p_id;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
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

        public void Update(party_invoiceBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@party_invoice_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_id;
                cmd.Parameters.Add("@entry_no", SqlDbType.VarChar).Value = obj.entry_no;
                cmd.Parameters.Add("@customer_no", SqlDbType.Int).Value = obj.customer_no;
                cmd.Parameters.Add("@p_id", SqlDbType.UniqueIdentifier).Value = obj.p_id;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
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

        public List<party_invoiceBAL> LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<party_invoiceBAL> listt = new List<party_invoiceBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@party_invoice_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        party_invoiceBAL obj1 = new party_invoiceBAL();
                        obj1.party_invoice_id = Guid.Parse(dr["party_invoice_id"].ToString());
                        obj1.entry_no = dr["entry_no"].ToString();
                        obj1.customer_no = Convert.ToInt32(dr["customer_no"].ToString());
                        obj1.p_id = Guid.Parse(dr["p_id"].ToString());
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

        public List<party_invoiceBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<party_invoiceBAL> listt = new List<party_invoiceBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        party_invoiceBAL obj1 = new party_invoiceBAL();
                        float x = 0; obj1.party_invoice_id = Guid.Parse(dr["party_invoice_id"].ToString());
                        obj1.entry_no = dr["entry_no"].ToString();
                        obj1.customer_no = Convert.ToInt32(dr["customer_no"].ToString());
                        obj1.p_id = Guid.Parse(dr["p_id"].ToString());
                        try { obj1.date = Convert.ToDateTime(dr["date"].ToString()); }
                        catch { obj1.date = DateTime.Now; }
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

        public List<party_invoiceBAL> Search(party_invoiceBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<party_invoiceBAL> listt = new List<party_invoiceBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@party_invoice_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_id;
                cmd.Parameters.Add("@entry_no", SqlDbType.Int).Value = obj.entry_no;
                cmd.Parameters.Add("@customer_no", SqlDbType.Int).Value = obj.customer_no;
                cmd.Parameters.Add("@p_id", SqlDbType.UniqueIdentifier).Value = obj.p_id;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        party_invoiceBAL obj1 = new party_invoiceBAL();
                        float x = 0; obj1.party_invoice_id = Guid.Parse(dr["party_invoice_id"].ToString());
                        obj1.entry_no = dr["entry_no"].ToString();
                        obj1.customer_no = Convert.ToInt32(dr["customer_no"].ToString());
                        obj1.p_id = Guid.Parse(dr["p_id"].ToString());
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

        public void Delete(party_invoiceBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@party_invoice_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_id;
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
