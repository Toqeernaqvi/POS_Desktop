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
    class InvoiceDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public Guid Add(InvoiceBAL obj)
        {
            Guid InvoiceID = Guid.Empty;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Invoice_Insert";
                cmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar).Value = obj.InvoiceNo;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;

                cmd.Parameters.Add("@shtname", SqlDbType.VarChar).Value = obj.ShortName;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@decrip", SqlDbType.VarChar).Value = obj.Descrip;
                cmd.Parameters.Add("@serialno", SqlDbType.VarChar).Value = obj.SerialNo;
                cmd.Parameters.Add("@desigcost", SqlDbType.VarChar).Value = obj.DesignatedCost;
                cmd.Parameters.Add("@purchorder", SqlDbType.DateTime).Value = obj.PurchaseOrderNo;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@fromdate", SqlDbType.Date).Value = obj.FromDate;
                cmd.Parameters.Add("@todate", SqlDbType.Date).Value = obj.ToDate;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.Date;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@taxid", SqlDbType.UniqueIdentifier).Value = obj.TaxID;

                InvoiceID = (Guid)cmd.ExecuteScalar();
                con.Close();
                return InvoiceID;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            return InvoiceID;

        }
        public void Update(InvoiceBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Invoice_Update";
                cmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar).Value = obj.InvoiceNo;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                cmd.Parameters.Add("@shtname", SqlDbType.VarChar).Value = obj.ShortName;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.Code;
                cmd.Parameters.Add("@decrip", SqlDbType.VarChar).Value = obj.Descrip;
                cmd.Parameters.Add("@serialno", SqlDbType.VarChar).Value = obj.SerialNo;
                cmd.Parameters.Add("@desigcost", SqlDbType.VarChar).Value = obj.DesignatedCost;
                cmd.Parameters.Add("@purchorder", SqlDbType.DateTime).Value = obj.PurchaseOrderNo;
                cmd.Parameters.Add("@userid", SqlDbType.UniqueIdentifier).Value = obj.User_id;
                cmd.Parameters.Add("@fromdate", SqlDbType.Date).Value = obj.FromDate;
                cmd.Parameters.Add("@todate", SqlDbType.Date).Value = obj.ToDate;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = obj.Date;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@taxid", SqlDbType.UniqueIdentifier).Value = obj.TaxID;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.InvoiceID;


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
                cmd.CommandText = "sp_Invoice_SelectAll";
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
        public void Delete(InvoiceBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Invoice_Delete_by_Id";
                cmd.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = obj.InvoiceID;
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
