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
    class labDAL
    {

        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(labBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = obj.type;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@desctiption", SqlDbType.VarChar).Value = obj.desctiption;
                cmd.Parameters.Add("@National_Tax_Number", SqlDbType.VarChar).Value = obj.National_Tax_Number;
                cmd.Parameters.Add("@Goods_And_Services_Tax", SqlDbType.VarChar).Value = obj.Goods_And_Services_Tax;
                cmd.Parameters.Add("@Guarranty", SqlDbType.VarChar).Value = obj.Guarranty;
                cmd.Parameters.Add("@Standard_Report_Number", SqlDbType.VarChar).Value = obj.Standard_Report_Number;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = obj.phone;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@Bank_account_number", SqlDbType.VarChar).Value = obj.Bank_account_number;
                cmd.Parameters.Add("@International_Account_Number", SqlDbType.VarChar).Value = obj.International_Account_Number;
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

        public void Update(labBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj.lab_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = obj.type;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@desctiption", SqlDbType.VarChar).Value = obj.desctiption;
                cmd.Parameters.Add("@National_Tax_Number", SqlDbType.VarChar).Value = obj.National_Tax_Number;
                cmd.Parameters.Add("@Goods_And_Services_Tax", SqlDbType.VarChar).Value = obj.Goods_And_Services_Tax;
                cmd.Parameters.Add("@Guarranty", SqlDbType.VarChar).Value = obj.Guarranty;
                cmd.Parameters.Add("@Standard_Report_Number", SqlDbType.VarChar).Value = obj.Standard_Report_Number;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = obj.phone;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj.address;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                cmd.Parameters.Add("@Bank_account_number", SqlDbType.VarChar).Value = obj.Bank_account_number;
                cmd.Parameters.Add("@International_Account_Number", SqlDbType.VarChar).Value = obj.International_Account_Number;
                
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

        public List<labBAL> LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<labBAL> listt = new List<labBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        labBAL obj1 = new labBAL();
                        obj1.lab_id = Guid.Parse(dr["lab_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.desctiption = dr["desctiption"].ToString();
                        obj1.National_Tax_Number = dr["National_Tax_Number"].ToString();
                        obj1.Goods_And_Services_Tax = dr["Goods_And_Services_Tax"].ToString();
                        obj1.Guarranty = dr["Guarranty"].ToString();
                        obj1.Standard_Report_Number = dr["Standard_Report_Number"].ToString();
                        obj1.phone = dr["phone"].ToString();
                        obj1.type = dr["type"].ToString();
                        obj1.address = dr["address"].ToString();
                        obj1.email = dr["email"].ToString();
                        obj1.Bank_account_number = dr["Bank_account_number"].ToString();
                        obj1.International_Account_Number = dr["International_Account_Number"].ToString();
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

        public List<labBAL> LoadAll()
        {
            try
            {
                //Local
                con.Close();
                SqlDataReader dr;
                List<labBAL> listt = new List<labBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        labBAL obj1 = new labBAL();
                        float x = 0; obj1.lab_id = Guid.Parse(dr["lab_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.desctiption = dr["desctiption"].ToString();
                        obj1.National_Tax_Number = dr["National_Tax_Number"].ToString();
                        obj1.type = dr["type"].ToString();
                        obj1.Goods_And_Services_Tax = dr["Goods_And_Services_Tax"].ToString();
                        obj1.Guarranty = dr["Guarranty"].ToString();
                        obj1.Standard_Report_Number = dr["Standard_Report_Number"].ToString();
                        obj1.phone = dr["phone"].ToString();
                        obj1.address = dr["address"].ToString();
                        obj1.email = dr["email"].ToString();
                        obj1.Bank_account_number = dr["Bank_account_number"].ToString();
                        obj1.International_Account_Number = dr["International_Account_Number"].ToString();
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

        public List<labBAL> Search(string obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<labBAL> listt = new List<labBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@desctiption", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@National_Tax_Number", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@Goods_And_Services_Tax", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@Guarranty", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@Standard_Report_Number", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@Bank_account_number", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@International_Account_Number", SqlDbType.VarChar).Value = obj;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        labBAL obj1 = new labBAL();
                        float x = 0; obj1.lab_id = Guid.Parse(dr["lab_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.desctiption = dr["desctiption"].ToString();
                        obj1.National_Tax_Number = dr["National_Tax_Number"].ToString();
                        obj1.Goods_And_Services_Tax = dr["Goods_And_Services_Tax"].ToString();
                        obj1.Guarranty = dr["Guarranty"].ToString();
                        obj1.Standard_Report_Number = dr["Standard_Report_Number"].ToString();
                        obj1.phone = dr["phone"].ToString();
                        obj1.type = dr["type"].ToString();
                        obj1.address = dr["address"].ToString();
                        obj1.email = dr["email"].ToString();
                        obj1.Bank_account_number = dr["Bank_account_number"].ToString();
                        obj1.International_Account_Number = dr["International_Account_Number"].ToString();
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

        public void Delete(labBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lab_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@lab_id", SqlDbType.UniqueIdentifier).Value = obj.lab_id;
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
