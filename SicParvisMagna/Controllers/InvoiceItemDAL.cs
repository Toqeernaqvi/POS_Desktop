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
    class InvoiceItemDAL
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public Guid Add(InvoiceItemBAL obj)
        {
            Guid InVoiceItemID = Guid.Empty;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InvoiceItem_Insert";
                cmd.Parameters.Add("@entryno", SqlDbType.VarChar).Value = obj.EntryNo;
                cmd.Parameters.Add("@cusno", SqlDbType.VarChar).Value = obj.CustomerNo;
                cmd.Parameters.Add("@invoiceid", SqlDbType.UniqueIdentifier).Value = obj.InvoiceID;
                cmd.Parameters.Add("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
                cmd.Parameters.Add("@qty", SqlDbType.VarChar).Value = obj.Qty;
                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = obj.Price;
                cmd.Parameters.Add("@VETax", SqlDbType.VarChar).Value = obj.ValueExclusiveTax;
                cmd.Parameters.Add("@RSTax", SqlDbType.VarChar).Value = obj.RatesOfSalesTax;
                cmd.Parameters.Add("@STPay", SqlDbType.VarChar).Value = obj.SalesTaxPayable;
                cmd.Parameters.Add("@VITax", SqlDbType.VarChar).Value = obj.ValueIncludingTax;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@remain", SqlDbType.VarChar).Value = obj.Remaining;

                InVoiceItemID = (Guid)cmd.ExecuteScalar();
                con.Close();
                return InVoiceItemID;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            return InVoiceItemID;

            //
        }
        public void Update(InvoiceItemBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InvoiceItem_Update";
                cmd.Parameters.Add("@entryno", SqlDbType.VarChar).Value = obj.EntryNo;
                cmd.Parameters.Add("@cusno", SqlDbType.VarChar).Value = obj.CustomerNo;
                cmd.Parameters.Add("@invoiceid", SqlDbType.UniqueIdentifier).Value = obj.InvoiceID;
                cmd.Parameters.Add("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
                cmd.Parameters.Add("@qty", SqlDbType.VarChar).Value = obj.Qty;
                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = obj.Price;
                cmd.Parameters.Add("@VETax", SqlDbType.VarChar).Value = obj.ValueExclusiveTax;
                cmd.Parameters.Add("@RSTax", SqlDbType.VarChar).Value = obj.RatesOfSalesTax;
                cmd.Parameters.Add("@STPay", SqlDbType.VarChar).Value = obj.SalesTaxPayable;
                cmd.Parameters.Add("@VITax", SqlDbType.VarChar).Value = obj.ValueIncludingTax;
                cmd.Parameters.Add("@stats", SqlDbType.VarChar).Value = obj.Status;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;
                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.EditBy;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.EditDate;
                cmd.Parameters.Add("@remain", SqlDbType.VarChar).Value = obj.Remaining;

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.InVoiceItemID;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }//update end
        public DataTable LoadAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InvoiceItem_SelectAll";
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
        public void Delete(InvoiceItemBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InvoiceItem_Delete_by_Id";
                cmd.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = obj.InVoiceItemID;
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
