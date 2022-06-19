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
    class reportsDAL
    {
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
                cmd.CommandText = "sp_Reports_SelectAll";
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
        public void Add(ReportBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Reports_Insert";
                cmd.Parameters.Add("@ReportName", SqlDbType.NVarChar).Value = obj.ReportName;
                cmd.Parameters.Add("@HeaderTitle", SqlDbType.NVarChar).Value = obj.HeaderTitle;
                cmd.Parameters.Add("@HeaderText", SqlDbType.NVarChar).Value = obj.HeaderText;
            
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            //
        }
        public void Update(ReportBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Reports_Update";
                 cmd.Parameters.Add("@ReportName", SqlDbType.NVarChar).Value = obj.ReportName;
                cmd.Parameters.Add("@HeaderTitle", SqlDbType.NVarChar).Value = obj.HeaderTitle;
                cmd.Parameters.Add("@HeaderText", SqlDbType.NVarChar).Value = obj.HeaderText;
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = obj.id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Sql Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }//update end

        public void Delete(ReportBAL obj)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Reports_Delete";
                cmd.Parameters.AddWithValue("@id", obj.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public ReportBAL GetReportDetails(string ReportName)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[reportGetByName]";
                cmd.Parameters.Add("@reportName", SqlDbType.NVarChar).Value = ReportName;
                cmd.CommandTimeout = 9000;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                ReportBAL rptBal = new ReportBAL();
             //   rptBal.HeaderTitle = dt.Rows[0]["HeaderTitle"].ToString();
               // rptBal.HeaderText = dt.Rows[0]["HeaderText"].ToString();
              //  rptBal.HeaderPicturePath = dt.Rows[0]["HeaderPicturePath"].ToString();

                return rptBal;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
            ///////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            ///....Reports..................////////////////////////////////////////////////
            ///

            public DataTable report_Employeelist()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "report_Employeelist";
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

        //2nd Report
        public DataTable report_EmployeeAttendence(DateTime date)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "report_EmployeeAttendence";
                cmd.Parameters.AddWithValue("@date", date);
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
        //3rd Report
        public DataTable report_EmployeeMonthlyAttendence(int year,int month)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "reportMonthlyAttendence";
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@month", month);
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

        //4th Report
        //Employee Attendence Monthly Percentage
        public DataTable report_EmployeeMonthlyAttendencePercentage(DateTime date)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "reportMonthlyAttendencePercentage";
                cmd.Parameters.AddWithValue("@date", date);
                 
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
        public DataTable SalaryByDepartment()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "rpt_SalaryByDept";
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

        public DataTable LoadReportFeeChallan()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con; cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "rptFeeGenerate";
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable LoadReportFeeChallanByGroup()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con; cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "rptFeeGenerateByGroup";
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable DailyStudentAttendance(Guid ClassId, Guid SectionId, Guid SessionId, DateTime date)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "rpt_DailyStudentAttendance";
                cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = ClassId;
                cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = SectionId;
                cmd.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = SessionId;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
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
        public DataTable StudentsMonthlyAttendance(Guid ClassID, Guid SectionID, Guid SessionID, DateTime date)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "reportStudentsMonthlyAttendance";
                cmd.Parameters.Add("@class_id", SqlDbType.UniqueIdentifier).Value = ClassID;
                cmd.Parameters.Add("@section_id", SqlDbType.UniqueIdentifier).Value = SectionID;
                cmd.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = SessionID;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;
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
        public DataTable DepartmentwiseMonthlyAttendance(DateTime date)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[reportStudentsMonthlyAttendanceDepartment]";
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
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
        public DataTable DepartmentwiseDailyAttendance(DateTime date)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[reportStudentsDailyAttendanceDepartment]";
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
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

        public DataTable RPTStockList()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "rpt_StockList";
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

        public DataTable RPTProductList()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "rpt_ProductList";
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

        public DataTable RPTPurchaseOrder()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_PurchaseOrder";
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

        public DataTable Rpt_PurchaseOrder_Return()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_PurchaseOrder_Return";
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
        public DataTable Rpt_SaleOrder()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_SaleOrder";
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

        public DataTable Rpt_SaleOrder_Return()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_SaleOrder_Return";
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

        public DataTable Rpt_SaleInvoice()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_SaleInvoice";
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

        public DataTable Rpt_SaleInvoice_By_InvoiceNo(string Invoice_No)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_SaleInvoice_ByOrderNo";
                cmd.Parameters.Add("@Invoice_No", SqlDbType.VarChar).Value = Invoice_No;

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

        public DataTable Rpt_SaleInvoice_By_Date(DateTime Date)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_SaleInvoice_ByDate";
                cmd.Parameters.Add("@Date", SqlDbType.VarChar).Value = Date;

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


        public DataTable Rpt_PurchaseOrderSummary()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RPT_PurchaseOrderSummary";
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

        public DataTable Rpt_PurchaseOrderDetails()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RPT_PurchaseOrderDetails";
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

        public DataTable Rpt_PurchasingTaxReport()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RPT_PurchasingTaxReport";
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

        public DataTable Rpt_PurchaseOrderStatus()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_PurchaseOrderStatus";
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

        public DataTable Rpt_ProductCostReport()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Rpt_ProductCostReport";
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

        public DataTable Rpt_VendorProductList()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RptVendorProductList";
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

        public DataTable Rpt_VendorList()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RptVendorList";
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


        public DataTable Rpt_SalesByProductSummary()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "rptSalesbyProductSummary";
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

        public DataTable Rpt_SalesByProductDetails()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RptSalesByProductDetails";
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
        public DataTable RptHistoricalInventory()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con; cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RPTHistoricalInventory";
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
        //////Medicnes report
        ///
        public DataTable MedicineInStockMonthWise(DateTime month)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con; cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[reportMedicineListMonthy]";
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = month;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable MedicineInStockDaily(DateTime month)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con; cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[reportMedicineListDaily]";
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = month;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable DailyPrescriptionList(DateTime Date)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            cmd.Connection = con; cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "reportDailyPrescriptionList";
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Date;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }

}
