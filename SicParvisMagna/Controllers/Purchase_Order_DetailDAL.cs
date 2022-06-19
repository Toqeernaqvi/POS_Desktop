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
	class Purchase_Order_DetailDAL
	{
		//SQL Objects
		//Connection
		private SqlConnection con = new SQLCon().getCon();
		private SqlCommand cmd = new SqlCommand();

		public void Add(Purchase_Order_DetailsBAL obj)
		{
			try
			{
				

				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Purchase_Order_Detail_Insert";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("@purchase_order_id", SqlDbType.UniqueIdentifier).Value = obj.puchase_order_id;
				cmd.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = obj.product_id;
				cmd.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = obj.product_category_id;
 
                cmd.Parameters.Add("@qty", SqlDbType.Int).Value = obj.quantity;
				cmd.Parameters.Add("@pur_am", SqlDbType.Float).Value = obj.purchase_amount;
				cmd.Parameters.Add("@sale_am", SqlDbType.Float).Value = obj.sale_amount;
				cmd.Parameters.Add("@tax_id", SqlDbType.UniqueIdentifier).Value = obj.tax_id;
				cmd.Parameters.Add("@tax_am", SqlDbType.Float).Value = obj.tax_amount;
				cmd.Parameters.Add("@dis_am", SqlDbType.Float).Value = obj.discount_amount;
				cmd.Parameters.Add("@dis_per", SqlDbType.Int).Value = obj.discount_percentage;
				cmd.Parameters.Add("@Product_Variant_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_id;

				cmd.Parameters.Add("@quantityType", SqlDbType.VarChar).Value = obj.quantityType;

                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
				cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
								
				cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.add_date;
				cmd.Parameters.Add("@adby", SqlDbType.UniqueIdentifier).Value = obj.add_by;
				cmd.Parameters.Add("@flag", SqlDbType.Bit).Value = obj.flag;

				cmd.ExecuteNonQuery();
				con.Close();
				
			}

			catch (SqlException e1)
			{
				MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}

		public void Update(Purchase_Order_DetailsBAL obj)
		{
			try
			{
				//Local

				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Purchase_Order_Detail_Update";
				cmd.Parameters.Clear();

				cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.Parameters.Add("@purchase_order_id", SqlDbType.UniqueIdentifier).Value = obj.puchase_order_id;
                cmd.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = obj.product_id;
                cmd.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = obj.product_category_id;

                cmd.Parameters.Add("@qty", SqlDbType.Int).Value = obj.quantity;
                cmd.Parameters.Add("@pur_am", SqlDbType.Float).Value = obj.purchase_amount;
                cmd.Parameters.Add("@sale_am", SqlDbType.Float).Value = obj.sale_amount;
                cmd.Parameters.Add("@tax_id", SqlDbType.UniqueIdentifier).Value = obj.tax_id;
                cmd.Parameters.Add("@tax_am", SqlDbType.Float).Value = obj.tax_amount;
                cmd.Parameters.Add("@dis_am", SqlDbType.Float).Value = obj.discount_amount;
                cmd.Parameters.Add("@dis_per", SqlDbType.Int).Value = obj.discount_percentage;

                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
                cmd.Parameters.Add("@quantityType", SqlDbType.VarChar).Value = obj.quantityType;
				cmd.Parameters.Add("@Product_Variant_id", SqlDbType.UniqueIdentifier).Value = obj.Product_Variant_id;


				cmd.Parameters.Add("@edit_date", SqlDbType.DateTime).Value = obj.edit_date;
				cmd.Parameters.Add("@edit_by", SqlDbType.UniqueIdentifier).Value = obj.edit_by;
				//cmd.Parameters.Add("@flag", SqlDbType.Bit).Value = obj.flag;

				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (SqlException e1)
			{
				MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
				cmd.CommandText = "Purchase_Order_Detail_LOADALL";
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

        public DataTable LoadAllById(Guid id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PurchaseOrderDetail_LoadById";
                cmd.Parameters.AddWithValue("@id", id);
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


        public void FilterByDate(Purchase_Order_DetailsBAL obj)
		{
			try
			{
				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Purchase_Order_Detail_FilterByDate";//by date
				cmd.Parameters.AddWithValue("@date1", obj.date);
				cmd.Parameters.AddWithValue("@date2", obj.date);
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (SqlException e)
			{
				MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}

		public void Delete(Purchase_Order_DetailsBAL obj)
		{
			try
			{
				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Purchase_Order_Detail_Delete";//by id
				cmd.Parameters.AddWithValue("@id", obj.id);
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
