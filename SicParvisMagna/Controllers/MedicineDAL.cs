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
    class MedicineDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(MedicineBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Insert";

                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Medicine_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Medicine_Category_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@company_name", SqlDbType.VarChar).Value = obj.company_name;
                cmd.Parameters.Add("@formula_name", SqlDbType.VarChar).Value = obj.formula_name;
                cmd.Parameters.Add("@rs", SqlDbType.Float).Value = obj.rs;
                cmd.Parameters.Add("@rm", SqlDbType.Float).Value = obj.rm;
                cmd.Parameters.Add("@qie", SqlDbType.Float).Value = obj.qie;
                cmd.Parameters.Add("@opn", SqlDbType.Float).Value = obj.opn;
                cmd.Parameters.Add("@InStock", SqlDbType.Bit).Value = obj.InStock;
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

        public void Update(MedicineBAL obj)
        {
            try
            {
                //Local
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Medicine_id", SqlDbType.UniqueIdentifier).Value = obj.Medicine_id;
                cmd.Parameters.Add("@Medicine_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Medicine_Category_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@company_name", SqlDbType.VarChar).Value = obj.company_name;
                cmd.Parameters.Add("@formula_name", SqlDbType.VarChar).Value = obj.formula_name;
                cmd.Parameters.Add("@rs", SqlDbType.Float).Value = obj.rs;
                cmd.Parameters.Add("@rm", SqlDbType.Float).Value = obj.rm;
                cmd.Parameters.Add("@qie", SqlDbType.Float).Value = obj.qie;
                cmd.Parameters.Add("@opn", SqlDbType.Float).Value = obj.opn;
                cmd.Parameters.Add("@InStock", SqlDbType.Bit).Value = obj.InStock;
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

        public MedicineBAL LoadbyId(Guid obj)
        {
            try
            {
                //Local
                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_LOADByID";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Medicine_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MedicineBAL obj1 = new MedicineBAL();
                        obj1.Medicine_id = Guid.Parse(dr["Medicine_id"].ToString());
                        obj1.Medicine_Category_id = Guid.Parse(dr["Medicine_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.company_name = dr["company_name"].ToString();
                        obj1.formula_name = dr["formula_name"].ToString();
                        obj1.rs = Convert.ToDouble(dr["rs"].ToString());
                        obj1.rm = Convert.ToDouble(dr["rm"].ToString());
                        obj1.qie = Convert.ToDouble(dr["quantityineach"].ToString());
                        obj1.opn = Convert.ToDouble(dr["opened"].ToString());

                        obj1.InStock = (bool)dr["InStock"];
                        obj1.status = (bool)dr["status"];

                        return obj1;
                    }
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }


        public MedicineBAL LoadCurrentInfoById(Guid id, DateTime date)
        {
            try
            {
                //Local
                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MedicineGetInfoById";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MedicineBAL obj1 = new MedicineBAL();
                        obj1.Medicine_id = Guid.Parse(dr["Medicine_id"].ToString());
                        obj1.Medicine_Category_id = Guid.Parse(dr["Medicine_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.company_name = dr["company_name"].ToString();
                        obj1.formula_name = dr["formula_name"].ToString();
                        obj1.rs = Convert.ToDouble(dr["rs"].ToString());
                        obj1.rm = Convert.ToDouble(dr["rm"].ToString());
                        obj1.qie = Convert.ToDouble(dr["quantityineach"].ToString());
                        obj1.opn = Convert.ToDouble(dr["opened"].ToString());

                        obj1.InStock = (bool)dr["InStock"];
                        obj1.status = (bool)dr["status"];

                        return obj1;
                    }
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }


        public List<MedicineBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<MedicineBAL> listt = new List<MedicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MedicineBAL obj1 = new MedicineBAL();
                        float x = 0;
                        obj1.Medicine_id = Guid.Parse(dr["Medicine_id"].ToString());
                        obj1.Medicine_Category_id = Guid.Parse(dr["Medicine_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.company_name = dr["company_name"].ToString();
                        obj1.formula_name = dr["formula_name"].ToString();
                        obj1.rs = Convert.ToDouble(dr["rs"].ToString());
                        obj1.rm = Convert.ToDouble(dr["rm"].ToString());
                        obj1.opn = Convert.ToDouble(dr["opened"].ToString());
                        obj1.qie = Convert.ToDouble(dr["quantityineach"].ToString());
                        try
                        { obj1.InStock = Convert.ToBoolean(dr["InStock"].ToString()); }
                        catch
                        { obj1.InStock = false; }
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

        public List<MedicineBAL> Search(MedicineBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<MedicineBAL> listt = new List<MedicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Search";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Medicine_id", SqlDbType.UniqueIdentifier).Value = obj.Medicine_id;
                cmd.Parameters.Add("@Medicine_Category_id", SqlDbType.UniqueIdentifier).Value = obj.Medicine_Category_id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.name;
                cmd.Parameters.Add("@shortname", SqlDbType.VarChar).Value = obj.shortname;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = obj.description;
                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = obj.code;
                cmd.Parameters.Add("@company_name", SqlDbType.VarChar).Value = obj.company_name;
                cmd.Parameters.Add("@formula_name", SqlDbType.VarChar).Value = obj.formula_name;
                cmd.Parameters.Add("@rs", SqlDbType.Float).Value = obj.rs;
                cmd.Parameters.Add("@rm", SqlDbType.Float).Value = obj.rm;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MedicineBAL obj1 = new MedicineBAL();
                        obj1.Medicine_id = Guid.Parse(dr["Medicine_id"].ToString());
                        obj1.Medicine_Category_id = Guid.Parse(dr["Medicine_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.company_name = dr["company_name"].ToString();
                        obj1.formula_name = dr["formula_name"].ToString();
                        obj1.rs = Convert.ToDouble(dr["rs"].ToString());
                        obj1.rm = Convert.ToDouble(dr["rm"].ToString());
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

        public DataTable getRemainingMedicineForReduction(Guid MedicineId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[Medicine_GetRemainingForReduction]";
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = MedicineId;
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public List<MedicineBAL> LoadAll_SQLQuery(string query)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<MedicineBAL> listt = new List<MedicineBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "query";


                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MedicineBAL obj1 = new MedicineBAL();
                        float x = 0; obj1.Medicine_id = Guid.Parse(dr["Medicine_id"].ToString());
                        obj1.Medicine_Category_id = Guid.Parse(dr["Medicine_Category_id"].ToString());
                        obj1.name = dr["name"].ToString();
                        obj1.shortname = dr["shortname"].ToString();
                        obj1.description = dr["description"].ToString();
                        obj1.code = dr["code"].ToString();
                        obj1.company_name = dr["company_name"].ToString();
                        obj1.formula_name = dr["formula_name"].ToString();
                        obj1.rs = Convert.ToDouble(dr["rs"].ToString());
                        obj1.rm = Convert.ToDouble(dr["rm"].ToString());
                        try
                        { obj1.InStock = Convert.ToBoolean(dr["InStock"].ToString()); }
                        catch
                        { obj1.InStock = false; }
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

        public void Delete(MedicineBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Medicine_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Medicine_id", SqlDbType.UniqueIdentifier).Value = obj.Medicine_id;
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
