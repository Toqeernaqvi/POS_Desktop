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
    class party_invoice_medicineDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(party_invoice_medicineBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_medicine_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj.medicine_id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;
                cmd.Parameters.Add("@packprice", SqlDbType.Float).Value = obj.packprice;
                cmd.Parameters.Add("@quantity", SqlDbType.Float).Value = obj.quantity;
                cmd.Parameters.Add("@discount_percentage", SqlDbType.Float).Value = obj.discount_percentage;
                cmd.Parameters.Add("@discount_amount", SqlDbType.Float).Value = obj.discount_amount;
                cmd.Parameters.Add("@tax_percentage", SqlDbType.Int).Value = obj.tax_percentage;
                cmd.Parameters.Add("@tax_amount", SqlDbType.Float).Value = obj.tax_amount;
                cmd.Parameters.Add("@net_amount", SqlDbType.Float).Value = obj.net_amount;
                cmd.Parameters.Add("@party_invoice_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
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

        public void Update(party_invoice_medicineBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_medicine_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@party_invoice_medicine_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_medicine_id;
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj.medicine_id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;
                cmd.Parameters.Add("@packprice", SqlDbType.Float).Value = obj.packprice;
                cmd.Parameters.Add("@quantity", SqlDbType.Float).Value = obj.quantity;
                cmd.Parameters.Add("@discount_percentage", SqlDbType.Float).Value = obj.discount_percentage;
                cmd.Parameters.Add("@discount_amount", SqlDbType.Float).Value = obj.discount_amount;
                cmd.Parameters.Add("@tax_percentage", SqlDbType.Int).Value = obj.tax_percentage;
                cmd.Parameters.Add("@tax_amount", SqlDbType.Float).Value = obj.tax_amount;
                cmd.Parameters.Add("@net_amount", SqlDbType.Float).Value = obj.net_amount;
                cmd.Parameters.Add("@party_invoice_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
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

        public party_invoice_medicineBAL LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_medicine_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@party_invoice_medicine_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                party_invoice_medicineBAL obj1 = new party_invoice_medicineBAL(); if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        float x = 0; obj1.party_invoice_medicine_id = Guid.Parse(dr["party_invoice_medicine_id"].ToString());
                        obj1.medicine_id = Guid.Parse(dr["medicine_id"].ToString());
                        obj1.description = dr["description"].ToString();
                        float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        try { float.TryParse(dr["packprice"].ToString(), out x); obj1.packprice = x; }
                        catch { obj1.packprice = 0; }
                        float.TryParse(dr["quantity"].ToString(), out x); obj1.quantity = x;
                        float.TryParse(dr["discount_percentage"].ToString(), out x); obj1.discount_percentage = x;
                        float.TryParse(dr["discount_amount"].ToString(), out x); obj1.discount_amount = x;
                        obj1.tax_percentage = Convert.ToInt32(dr["tax_percentage"].ToString());
                        float.TryParse(dr["tax_amount"].ToString(), out x); obj1.tax_amount = x;
                        float.TryParse(dr["net_amount"].ToString(), out x); obj1.net_amount = x;
                        obj1.party_invoice_id = Guid.Parse(dr["party_invoice_id"].ToString());
                        obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
                        obj1.status = (bool)dr["status"];

                    }
                }
                dr.Close();
                con.Close();
                return obj1;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<party_invoice_medicineBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<party_invoice_medicineBAL> listt = new List<party_invoice_medicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_medicine_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        party_invoice_medicineBAL obj1 = new party_invoice_medicineBAL();
                        float x = 0; obj1.party_invoice_medicine_id = Guid.Parse(dr["party_invoice_medicine_id"].ToString());
                        obj1.medicine_id = Guid.Parse(dr["medicine_id"].ToString());
                        obj1.description = dr["description"].ToString();
                        float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        try { float.TryParse(dr["packprice"].ToString(), out x); obj1.packprice = x; }
                        catch { obj1.packprice = 0; }
                        float.TryParse(dr["quantity"].ToString(), out x); obj1.quantity = x;
                        float.TryParse(dr["discount_percentage"].ToString(), out x); obj1.discount_percentage = x;
                        float.TryParse(dr["discount_amount"].ToString(), out x); obj1.discount_amount = x;
                        obj1.tax_percentage = Convert.ToInt32(dr["tax_percentage"].ToString());
                        float.TryParse(dr["tax_amount"].ToString(), out x); obj1.tax_amount = x;
                        float.TryParse(dr["net_amount"].ToString(), out x); obj1.net_amount = x;
                        obj1.party_invoice_id = Guid.Parse(dr["party_invoice_id"].ToString());
                        obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
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

        public List<party_invoice_medicineBAL> Search(party_invoice_medicineBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<party_invoice_medicineBAL> listt = new List<party_invoice_medicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_medicine_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@party_invoice_medicine_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_medicine_id;
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj.medicine_id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;

                cmd.Parameters.Add("@packprice", SqlDbType.Float).Value = obj.packprice;
                cmd.Parameters.Add("@quantity", SqlDbType.Float).Value = obj.quantity;
                cmd.Parameters.Add("@discount_percentage", SqlDbType.Float).Value = obj.discount_percentage;
                cmd.Parameters.Add("@discount_amount", SqlDbType.Float).Value = obj.discount_amount;
                cmd.Parameters.Add("@tax_percentage", SqlDbType.Int).Value = obj.tax_percentage;
                cmd.Parameters.Add("@tax_amount", SqlDbType.Float).Value = obj.tax_amount;
                cmd.Parameters.Add("@net_amount", SqlDbType.Float).Value = obj.net_amount;
                cmd.Parameters.Add("@party_invoice_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        party_invoice_medicineBAL obj1 = new party_invoice_medicineBAL();
                        float x = 0; obj1.party_invoice_medicine_id = Guid.Parse(dr["party_invoice_medicine_id"].ToString());
                        obj1.medicine_id = Guid.Parse(dr["medicine_id"].ToString());
                        obj1.description = dr["description"].ToString();
                        float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        try { float.TryParse(dr["packprice"].ToString(), out x); obj1.packprice = x; }
                        catch { obj1.packprice = 0; }
                        float.TryParse(dr["quantity"].ToString(), out x); obj1.quantity = x;
                        float.TryParse(dr["discount_percentage"].ToString(), out x); obj1.discount_percentage = x;
                        float.TryParse(dr["discount_amount"].ToString(), out x); obj1.discount_amount = x;
                        obj1.tax_percentage = Convert.ToInt32(dr["tax_percentage"].ToString());
                        float.TryParse(dr["tax_amount"].ToString(), out x); obj1.tax_amount = x;
                        float.TryParse(dr["net_amount"].ToString(), out x); obj1.net_amount = x;
                        obj1.party_invoice_id = Guid.Parse(dr["party_invoice_id"].ToString());
                        obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
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

        public List<party_invoice_medicineBAL> LoadAll_SQLQuery(string query)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<party_invoice_medicineBAL> listt = new List<party_invoice_medicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "query";


                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        party_invoice_medicineBAL obj1 = new party_invoice_medicineBAL();
                        float x = 0; obj1.party_invoice_medicine_id = Guid.Parse(dr["party_invoice_medicine_id"].ToString());
                        obj1.medicine_id = Guid.Parse(dr["medicine_id"].ToString());
                        obj1.description = dr["description"].ToString();
                        float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        try { float.TryParse(dr["packprice"].ToString(), out x); obj1.packprice = x; }
                        catch { obj1.packprice = 0; }
                        float.TryParse(dr["quantity"].ToString(), out x); obj1.quantity = x;
                        float.TryParse(dr["discount_percentage"].ToString(), out x); obj1.discount_percentage = x;
                        float.TryParse(dr["discount_amount"].ToString(), out x); obj1.discount_amount = x;
                        obj1.tax_percentage = Convert.ToInt32(dr["tax_percentage"].ToString());
                        float.TryParse(dr["tax_amount"].ToString(), out x); obj1.tax_amount = x;
                        float.TryParse(dr["net_amount"].ToString(), out x); obj1.net_amount = x;
                        obj1.party_invoice_id = Guid.Parse(dr["party_invoice_id"].ToString());
                        obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
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

        public void Delete(party_invoice_medicineBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "party_invoice_medicine_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@party_invoice_medicine_id", SqlDbType.UniqueIdentifier).Value = obj.party_invoice_medicine_id;
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
