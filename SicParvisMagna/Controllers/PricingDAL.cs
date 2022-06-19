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
    class PricingDAL
    {


        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public void Add(PricingBAL obj)
        {
             
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Pricing_Insert";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
                cmd.Parameters.Add("@catid", SqlDbType.UniqueIdentifier).Value = obj.CatID;
                cmd.Parameters.Add("@Purchase_order_id", SqlDbType.UniqueIdentifier).Value = obj.Purchase_order_id;
                   
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;
                  cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;
 
                cmd.Parameters.Add("@adby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@addate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void UpdateRemaining(PricingBAL obj)
        {
          
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Pricing_UpdateRemaining";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Pricing_id", SqlDbType.UniqueIdentifier).Value = obj.Pricing_id;
             //   cmd.Parameters.Add("@remaining", SqlDbType.Float).Value = obj.remaining;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(PricingBAL obj)
        {
          //  obj.status = true;
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Pricing_Update";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Pricing_id;
                cmd.Parameters.Add("@proid", SqlDbType.UniqueIdentifier).Value = obj.ProID;
                cmd.Parameters.Add("@catid", SqlDbType.UniqueIdentifier).Value = obj.CatID;
                cmd.Parameters.Add("@Purchase_order_id", SqlDbType.UniqueIdentifier).Value = obj.Purchase_order_id;

                cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;

                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void UpdatePrice(PricingBAL obj)
        {
            //  obj.status = true;
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Pricing_Update_just_Price";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.Pricing_id;
                
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;
                 cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = obj.status;

                cmd.Parameters.Add("@editby", SqlDbType.VarChar).Value = obj.AddBy;
                cmd.Parameters.Add("@editdate", SqlDbType.DateTime).Value = obj.AddDate;
                cmd.Parameters.Add("@flg", SqlDbType.Int).Value = obj.Flag;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public List<PricingBAL> Pricing_GetRemainingMedsList(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Pricing_GetRemainingMeds";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                List<PricingBAL> list = new List<PricingBAL>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //PricingBAL obj1 = new PricingBAL();
                        //float x = 0; obj1.Pricing_id = Guid.Parse(dr["Pricing_id"].ToString());
                        //obj1.item_id = Guid.Parse(dr["item_id"].ToString());
                        //try
                        //{ obj1.InvoiceID = Guid.Parse(dr["invoice_id"].ToString()); }
                        //catch
                        //{ obj1.InvoiceID = Guid.Empty; }
                        //obj1.item_type = dr["item_type"].ToString();
                        //float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        //float.TryParse(dr["qty"].ToString(), out x); obj1.qty = x;
                        //float.TryParse(dr["total"].ToString(), out x); obj1.total = x;
                        //obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
                        //obj1.status = (bool)dr["status"];
                        //obj1.remaining = (float)Convert.ToDouble(dr["remaining"].ToString());
                        //list.Add(obj1);

                    }
                }
                dr.Close();
                con.Close();

                return list;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public PricingBAL Pricing_GetRemainingMeds(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Pricing_GetRemainingMeds";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@medicine_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();

                PricingBAL obj1 = new PricingBAL();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //float x = 0; obj1.Pricing_id = Guid.Parse(dr["Pricing_id"].ToString());
                        //obj1.item_id = Guid.Parse(dr["item_id"].ToString());
                        //try
                        //{ obj1.InvoiceID = Guid.Parse(dr["invoice_id"].ToString()); }
                        //catch
                        //{ obj1.InvoiceID = Guid.Empty; }
                        //obj1.item_type = dr["item_type"].ToString();
                        //float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        //float.TryParse(dr["qty"].ToString(), out x); obj1.qty = x;
                        //float.TryParse(dr["total"].ToString(), out x); obj1.total = x;
                        //obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
                        //obj1.status = (bool)dr["status"];
                        //obj1.remaining = (float)Convert.ToDouble(dr["remaining"].ToString());


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


        public PricingBAL LoadbyId(Guid obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Pricing_LOADByID";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Pricing_id", SqlDbType.UniqueIdentifier).Value = obj;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //PricingBAL obj1 = new PricingBAL();
                        //float x = 0; obj1.Pricing_id = Guid.Parse(dr["Pricing_id"].ToString());
                        //obj1.item_id = Guid.Parse(dr["item_id"].ToString());
                        //try
                        //{
                        //    obj1.InvoiceID = Guid.Parse(dr["invoice_id"].ToString());
                        //}
                        //catch
                        //{ obj1.InvoiceID = Guid.Empty; }
                        //obj1.item_type = dr["item_type"].ToString();
                        //float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        //float.TryParse(dr["qty"].ToString(), out x); obj1.qty = x;
                        //float.TryParse(dr["total"].ToString(), out x); obj1.total = x;
                        //obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
                        //obj1.status = (bool)dr["status"];

                        //return obj1;
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

        public List<PricingBAL> LoadAll()
        {
            try
            {
                //Local

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                List<PricingBAL> listt = new List<PricingBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Pricing_LOADALL";
                cmd.Parameters.Clear();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);
            //    List<PricingBAL> listt = dt.AsEnumerable().Select(row =>
          //     new PricingBAL
          //     {
          //.        Pricing_id = row["Pricing_id"].Equals(DBNull.Value) ? Guid.Empty : Guid.Parse(row["Pricing_id"].ToString()),
          //         InvoiceID = row["invoice_id"].Equals(DBNull.Value) ? Guid.Empty : Guid.Parse(row["invoice_id"].ToString()),
          //         remaining = row["remaining"].Equals(DBNull.Value) ? 0 : Convert.ToSingle(row["remaining"]),
          //         item_id = row["item_id"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(row["item_id"]),
          //         item_type = row.Field<string>("item_type"),
          //         price = Convert.ToSingle(row["price"]),//row.Field<float>("price")
          //         qty = Convert.ToSingle(row["qty"]),//row.Field<float>("qty"),
          //         total = Convert.ToSingle(row["total"]),//row.Field<float>("total"),
          //         Date = row.Field<DateTime>("Date"),
          //         status = row.Field<bool>("status")
          //     }).ToList();


                //       listt.OrderByDescending(m => m.Date).Where(m => m.status).ToList();
                //if (listt.Count > 1)
                //{
                //    for (int i = 1; i < listt.Count; i++)
                //    {
                //        listt[i].status = false;
                //        Update(listt[i]);
                //    }
                //}
                return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<PricingBAL> Search(PricingBAL obj)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<PricingBAL> listt = new List<PricingBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Pricing_Search";
                cmd.Parameters.Clear();

                //cmd.Parameters.Add("@Pricing_id", SqlDbType.UniqueIdentifier).Value = obj.Pricing_id;
                //cmd.Parameters.Add("@item_id", SqlDbType.UniqueIdentifier).Value = obj.item_id;
                //cmd.Parameters.Add("@item_type", SqlDbType.VarChar).Value = obj.item_type;
                //cmd.Parameters.Add("@price", SqlDbType.Float).Value = obj.price;
                //cmd.Parameters.Add("@qty", SqlDbType.Float).Value = obj.qty;
                //cmd.Parameters.Add("@total", SqlDbType.Float).Value = obj.total;
                //cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
                //cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //PricingBAL obj1 = new PricingBAL();
                        //float x = 0; obj1.Pricing_id = Guid.Parse(dr["Pricing_id"].ToString());
                        //obj1.item_id = Guid.Parse(dr["item_id"].ToString());
                        //obj1.item_type = dr["item_type"].ToString();
                        //try
                        //{
                        //    obj1.InvoiceID = Guid.Parse(dr["invoice_id"].ToString());
                        //}
                        //catch
                        //{ obj1.InvoiceID = Guid.Empty; }
                        //float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        //float.TryParse(dr["qty"].ToString(), out x); obj1.qty = x;
                        //float.TryParse(dr["total"].ToString(), out x); obj1.total = x;
                        //obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
                        //obj1.status = (bool)dr["status"];
                        //listt.Add(obj1);
                    }
                }
                dr.Close();
                con.Close();
               // listt.OrderByDescending(m => m.Date).Where(m => m.status).ToList();
                if (listt.Count > 1)
                {
                    for (int i = 1; i < listt.Count; i++)
                    {
                 //       listt[i].status = false;
                        Update(listt[i]);
                    }
                }
                return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<PricingBAL> LoadAll_SQLQuery(string query)
        {
            try
            {
                //Local

                SqlDataReader dr;
                List<PricingBAL> listt = new List<PricingBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "query";


                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //PricingBAL obj1 = new PricingBAL();
                        //float x = 0; obj1.Pricing_id = Guid.Parse(dr["Pricing_id"].ToString());
                        //obj1.item_id = Guid.Parse(dr["item_id"].ToString());
                        //try
                        //{
                        //    obj1.InvoiceID = Guid.Parse(dr["invoice_id"].ToString());
                        //}
                        //catch
                        //{ obj1.InvoiceID = Guid.Empty; }
                        //obj1.item_type = dr["item_type"].ToString();
                        //float.TryParse(dr["price"].ToString(), out x); obj1.price = x;
                        //float.TryParse(dr["qty"].ToString(), out x); obj1.qty = x;
                        //float.TryParse(dr["total"].ToString(), out x); obj1.total = x;
                        //obj1.Date = Convert.ToDateTime(dr["Date"].ToString());
                        //obj1.status = (bool)dr["status"];
                        //listt.Add(obj1);
                    }
                }
                dr.Close();
                con.Close();
           ///     listt.OrderByDescending(m => m.Date).Where(m => m.status).ToList();
                if (listt.Count > 1)
                {
                    for (int i = 1; i < listt.Count; i++)
                    {
              //          listt[i].status = false;
                        Update(listt[i]);
                    }
                }
                return listt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public void Delete(Guid InvoiceId)
        {
            try
            {
                //Local
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Pricing_DeleteByInvoice";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@invoice_id", SqlDbType.UniqueIdentifier).Value = InvoiceId;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void Delete(PricingBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Pricing_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@Pricing_id", SqlDbType.UniqueIdentifier).Value = obj.Pricing_id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void DeleteProduct(PricingBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Pricing_Delete";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@ProID", SqlDbType.UniqueIdentifier).Value = obj.ProID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //
        public DataTable FindPrice_Pricing(Guid ProID, Guid CatID)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.CommandText = "Find_Price_Pricing";
                cmd.Parameters.Add("@ProID", SqlDbType.UniqueIdentifier).Value = ProID;
                cmd.Parameters.Add("@CatID", SqlDbType.UniqueIdentifier).Value = CatID;

                cmd.ExecuteScalar();
                con.Close();
                sa.SelectCommand = cmd;
                sa.Fill(dt);

                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        //

        public DataTable FindPrice_Product(Guid ProID )
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.CommandText = "FindPrice_by_Product";
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = ProID;
 
                cmd.ExecuteScalar();
                con.Close();
                sa.SelectCommand = cmd;
                sa.Fill(dt);

                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public  DataTable FindPrice_ProductId(Guid ProID)
        {
            try
            {
                //Local
                SqlDataAdapter sa = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.CommandText = "FindPriceByProductID";
                cmd.Parameters.Add("@Pro_id", SqlDbType.UniqueIdentifier).Value = ProID;

                cmd.ExecuteScalar();
                con.Close();
                sa.SelectCommand = cmd;
                sa.Fill(dt);

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
