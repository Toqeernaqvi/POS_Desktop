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
    class lab_invoiceincomeDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon(); private SqlCommand cmd = new SqlCommand();

        public void Add(lab_invoiceincomeBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_invoice_income_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@discount", SqlDbType.Int).Value = obj.discount;
                cmd.Parameters.Add("@discountAmt", SqlDbType.Int).Value = obj.discountAmt;
                cmd.Parameters.Add("@welfarediscount", SqlDbType.Int).Value = obj.welfarediscount;
                cmd.Parameters.Add("@nettotal", SqlDbType.Int).Value = obj.nettotal;
                cmd.Parameters.Add("@netAmount", SqlDbType.Int).Value = obj.netAmount;
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

        public void Update(lab_invoiceincomeBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_invoice_income_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_invoice_income_id", SqlDbType.UniqueIdentifier).Value = obj.lab_invoice_income_id;
                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@discount", SqlDbType.Int).Value = obj.discount;
                cmd.Parameters.Add("@discountAmt", SqlDbType.Int).Value = obj.discountAmt;
                cmd.Parameters.Add("@netAmount", SqlDbType.Int).Value = obj.netAmount;
                cmd.Parameters.Add("@welfarediscount", SqlDbType.Int).Value = obj.welfarediscount;
                cmd.Parameters.Add("@nettotal", SqlDbType.Int).Value = obj.nettotal;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
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

        public List<lab_invoiceincomeBAL> LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<lab_invoiceincomeBAL> listt = new List<lab_invoiceincomeBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_invoice_income_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_invoice_income_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lab_invoiceincomeBAL obj1 = new lab_invoiceincomeBAL();
                        float x = 0; obj1.lab_invoice_income_id = Guid.Parse(dr["lab_invoice_income_id"].ToString());
                        obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.description = dr["description"].ToString();
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        obj1.discount = Convert.ToInt32(dr["discount"].ToString());
                        obj1.welfarediscount = Convert.ToInt32(dr["welfarediscount"].ToString());
                        obj1.nettotal = Convert.ToInt32(dr["nettotal"].ToString());
                        obj1.discountAmt = Convert.ToInt32(dr["discountAmt"].ToString());
                        obj1.netAmount = Convert.ToInt32(dr["netAmount"].ToString());
                        obj1.status = (bool)dr["status"];
                        obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
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

        public List<lab_invoiceincomeBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<lab_invoiceincomeBAL> listt = new List<lab_invoiceincomeBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_invoice_income_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lab_invoiceincomeBAL obj1 = new lab_invoiceincomeBAL();
                        float x = 0; obj1.lab_invoice_income_id = Guid.Parse(dr["lab_invoice_income_id"].ToString());
                        obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.description = dr["description"].ToString();
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        obj1.discount = Convert.ToInt32(dr["discount"].ToString());
                        obj1.welfarediscount = Convert.ToInt32(dr["welfarediscount"].ToString());
                        obj1.nettotal = Convert.ToInt32(dr["nettotal"].ToString());
                        obj1.discountAmt = Convert.ToInt32(dr["discountAmt"].ToString());
                        obj1.netAmount = Convert.ToInt32(dr["netAmount"].ToString());
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

        public List<lab_invoiceincomeBAL> Search(lab_invoiceincomeBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<lab_invoiceincomeBAL> listt = new List<lab_invoiceincomeBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_invoice_income_Search";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@lab_invoice_income_id", SqlDbType.UniqueIdentifier).Value = obj.lab_invoice_income_id;
                cmd.Parameters.Add("@lab_test_id", SqlDbType.UniqueIdentifier).Value = obj.lab_test_id;
                cmd.Parameters.Add("@patient_id", SqlDbType.UniqueIdentifier).Value = obj.patient_id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = obj.price;
                cmd.Parameters.Add("@discount", SqlDbType.Int).Value = obj.discount;
                cmd.Parameters.Add("@discountAmt", SqlDbType.Int).Value = obj.discountAmt;
                cmd.Parameters.Add("@welfarediscount", SqlDbType.Int).Value = obj.welfarediscount;
                cmd.Parameters.Add("@nettotal", SqlDbType.Int).Value = obj.nettotal;
                cmd.Parameters.Add("@netAmount", SqlDbType.Int).Value = obj.netAmount;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lab_invoiceincomeBAL obj1 = new lab_invoiceincomeBAL();
                        obj1.lab_invoice_income_id = Guid.Parse(dr["lab_invoice_income_id"].ToString());
                        obj1.lab_test_id = Guid.Parse(dr["lab_test_id"].ToString());
                        obj1.patient_id = Guid.Parse(dr["patient_id"].ToString());
                        obj1.description = dr["description"].ToString();
                        obj1.price = Convert.ToInt32(dr["price"].ToString());
                        obj1.welfarediscount = Convert.ToInt32(dr["welfarediscount"].ToString());
                        obj1.nettotal = Convert.ToInt32(dr["nettotal"].ToString());
                        obj1.discount = Convert.ToInt32(dr["discount"].ToString());
                        obj1.discountAmt = Convert.ToInt32(dr["discountAmt"].ToString());
                        obj1.netAmount = Convert.ToInt32(dr["netAmount"].ToString());
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

        public void Delete(lab_invoiceincomeBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_invoice_income_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_invoice_income_id", SqlDbType.UniqueIdentifier).Value = obj.lab_invoice_income_id;
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
