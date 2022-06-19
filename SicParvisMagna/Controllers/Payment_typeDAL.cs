using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicCRUD.Models;
using SicParvisMagna.Models;
using SicParvisMagna.Library;

namespace SicParvisMagna.Controllers
{
	class Payment_typeDAL
	{
		//Connection
		private SqlConnection con = new SQLCon().getCon();
		private SqlCommand cmd = new SqlCommand();

		public DataTable LoadAll()
		{
			try
			{
				SqlDataAdapter da = new SqlDataAdapter();
				DataTable dt = new DataTable();

				con.Open();
				cmd.Connection = con;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Payment_type_LoadAll";
				cmd.ExecuteNonQuery();//execute
				con.Close();
				da.SelectCommand = cmd;// dataadapter
				da.Fill(dt);
				return dt;
			}
			catch (SqlException e)
			{
				MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return null;
		}
	}
}
