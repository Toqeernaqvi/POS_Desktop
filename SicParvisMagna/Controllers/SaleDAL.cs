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
	class SaleDAL
	{
		//SQL Objects
		//Connection
		private SqlConnection con = new SQLCon().getCon();
		private SqlCommand cmd = new SqlCommand();

		public void Add(SaleBAL obj)
		{
			try
			{
				
				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "ProSales_Insert";
				cmd.Parameters.Clear();

				cmd.Parameters.Add("@pro_id", SqlDbType.UniqueIdentifier).Value = obj.Pro_id;
				
				cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.unitprice;
				cmd.Parameters.Add("@qty", SqlDbType.Float).Value = obj.qtysold;
				cmd.Parameters.Add("@total", SqlDbType.Float).Value = obj.total;
				cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
				cmd.Parameters.Add("@transaction", SqlDbType.Float).Value = obj.transaction_no;
				
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
		public void GetTransaction()
		{

		}

		public void Update(SaleBAL obj)
		{
			try
			{
				//Local

				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "ProSales_Update";
				cmd.Parameters.Clear();

				cmd.Parameters.Add("@prosale_id", SqlDbType.UniqueIdentifier).Value = obj.ProSales_id;
				cmd.Parameters.Add("@pro_id", SqlDbType.UniqueIdentifier).Value = obj.Pro_id;

				cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.unitprice;
				cmd.Parameters.Add("@qty", SqlDbType.Float).Value = obj.qtysold;
				cmd.Parameters.Add("@total", SqlDbType.Float).Value = obj.total;
				//cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = obj.date;
				cmd.Parameters.Add("@transaction", SqlDbType.Float).Value = obj.transaction_no;

				cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.edit_date;
				cmd.Parameters.Add("@editby", SqlDbType.UniqueIdentifier).Value = obj.edit_by;



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
				cmd.CommandText = "ProSales_LOADALL";
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
		

		public void Delete(SaleBAL obj)
		{
			try
			{
				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "ProSales_Delete";//by id
				cmd.Parameters.AddWithValue("@id", obj.ProSales_id);
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
