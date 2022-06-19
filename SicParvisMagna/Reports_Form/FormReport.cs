using CrystalDecisions.CrystalReports.Engine;
 
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using SicParvisMagna.Reports;
using SicParvisMagna.Reports.PointOfSaleReports;
using SicParvisMagna.Reports.PointOfSaleReports.import_reports;
using SicParvisMagna.Reports.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna
{
    public partial class FormReport : Form
    {
        Point mouseDownPoint = Point.Empty;

        private string report = "";
        private Guid testgenid, studentId, sectionId;

        private int HeadID;
        private string typeClass;
        private int teacherId, type, status;
        private DateTime d1, d2;
        private Guid SessionID, DepartmentID;
        private DataTable ReportDataSource;
        private DateTime FromDate, ToDate, Date;

        private DateTime date;
        private int year;
        private int month;
        private string Invoice_No;
        public FormReport()
        {
            InitializeComponent();
        }
        public FormReport(string title, string report, DateTime dt1, DateTime dt2)
        {
            InitializeComponent();
            this.Text = title;
            this.report = report;
            FromDate = dt1;
            ToDate = dt2;
        }
        public FormReport(string title, string report, string InvoiceNo)
        {
            InitializeComponent();
            this.Text = title;
            this.report = report;
            Invoice_No = InvoiceNo;
                }

        private void crViewer_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);

        }

        private void crViewer_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void crViewer_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        
    }

        private void crViewer_KeyDown(object sender, KeyEventArgs e)
        {
           //Write some code for print

        }

        private void FormReport_KeyDown(object sender, KeyEventArgs e)
        {
            // Code for print Sort K|ey
            if (e.KeyCode == Keys.Enter)
            {
                crViewer.PrintReport();
                this.Dispose();
            }
        }

        public FormReport(string reportTitle, string ReportName,DateTime Date)
        {
            InitializeComponent();
            this.Text = reportTitle;
            this.report = ReportName;
            this.date = Date;
        }
        public FormReport(string reportTitle, string ReportName, int year,int month)
        {
            InitializeComponent();
            this.Text = reportTitle;
            this.report = ReportName;
            this.year = year;
            this.month = month;
        }

        public FormReport(string title, string report, Guid classsid, Guid sectionid, Guid SessionID, DateTime date)
        {
            InitializeComponent();
            this.Text = title;
            this.report = report;
            this.testgenid = classsid;
            this.sectionId = sectionid;
            this.Date = date;
            this.SessionID = SessionID;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1024, 768);
            }

            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Minimized;
        }

        ////////////////////////////////////////////////
        ////////////////////////////////////////
        ///
        public FormReport(string reportTitle, string ReportName)
        {
            InitializeComponent();
             this.Text = reportTitle;
            this.report = ReportName;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            if (report == "Employeelist")
            {
                DataTable dt = new DataTable();
                Rpt_EmployeeInfo rpt = new Rpt_EmployeeInfo();
                reportsDAL rptDAL = new reportsDAL();

                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("Employeelist");
                txtReportHeaderDesc.Text = rptBAL.HeaderText;
                txtReportHeaderTitle.Text = rptBAL.HeaderTitle;
                //txtReportHeaderPic.

                dt = rptDAL.report_Employeelist();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "EmployeeAttendence")
            {
                DataTable dt = new DataTable();
                Rpt_EmployeeAttendence rpt = new Rpt_EmployeeAttendence();
                reportsDAL rptDAL = new reportsDAL();

                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("EmployeeAttendence");
                txtReportHeaderDesc.Text = rptBAL.HeaderText;
                txtReportHeaderTitle.Text = rptBAL.HeaderTitle;
                //txtReportHeaderPic.

                dt = rptDAL.report_EmployeeAttendence(date);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            //
            if (report == "EmployeeMonthlyAttendence")
            {
                DataTable dt = new DataTable();
                Rpt_EmployeeMonthlyAttendence rpt = new Rpt_EmployeeMonthlyAttendence();
                reportsDAL rptDAL = new reportsDAL();

                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("EmployeeMonthlyAttendence");
                txtReportHeaderDesc.Text = rptBAL.HeaderText;
                txtReportHeaderTitle.Text = rptBAL.HeaderTitle;
                //txtReportHeaderPic.

                dt = rptDAL.report_EmployeeMonthlyAttendence(year, month);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }//
            if (report == "EmployeeMonthlyAttendencePercentage")
            {
                DataTable dt = new DataTable();
                EmployeeMonthlyAttendencePercentage rpt = new EmployeeMonthlyAttendencePercentage();
                reportsDAL rptDAL = new reportsDAL();

                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("EmployeeMonthlyAttendencePercentage");
                txtReportHeaderDesc.Text = rptBAL.HeaderText;
                txtReportHeaderTitle.Text = rptBAL.HeaderTitle;
                //txtReportHeaderPic.

                dt = rptDAL.report_EmployeeMonthlyAttendencePercentage(date);
                    
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            //
            if (report == "ReportEmployeeMonthlyAttendencePercentage")
            {
                DataTable dt = new DataTable();
                Report_2_EmployeeMonthlyAttendance rpt = new Report_2_EmployeeMonthlyAttendance();
                reportsDAL rptDAL = new reportsDAL();

                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("ReportEmployeeMonthlyAttendencePercentage");
                txtReportHeaderDesc.Text = rptBAL.HeaderText;
                txtReportHeaderTitle.Text = rptBAL.HeaderTitle;
                //txtReportHeaderPic.

                dt = rptDAL.report_EmployeeMonthlyAttendencePercentage(date);

                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "SalaryByDepartment")
            {
                DataTable dt = new DataTable();
                rpt_SalaryByDept rpt = new rpt_SalaryByDept();

                reportsDAL rptDAL = new reportsDAL();

                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("SalaryByDepartment");
                //txtReportHeaderDesc.Text  = rptBAL.HeaderDesc;
               //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.SalaryByDepartment();
                rpt.SetDataSource(dt);

                crViewer.ReportSource = rpt;
            }
            if (report == "FeeGenerate")
            {
                DataTable dt = new DataTable();
                rpt_FeeChalan_true rpt = new rpt_FeeChalan_true();

                reportsDAL rptDAL = new reportsDAL();
                dt = rptDAL.LoadReportFeeChallan();
                rpt.SetDataSource(dt);

                crViewer.ReportSource = rpt;
            }
            if (report == "FeeGenerate2")
            {
                DataTable dt = new DataTable();
                rpt_FeeChalan rpt = new rpt_FeeChalan();

                reportsDAL rptDAL = new reportsDAL();
                dt = rptDAL.LoadReportFeeChallanByGroup();
                rpt.SetDataSource(dt);

                crViewer.ReportSource = rpt;
            }
            if (report == "DailyStudentAttendance")
            {
                DataTable dt = new DataTable();
                rptDailyAttendanceReport rpt = new rptDailyAttendanceReport();
                reportsDAL rptDAL = new reportsDAL();

                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderPic"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("DailyStudentAttendance");
               // txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
               // txtReportHeaderTitle.Text = rptBAL.HeaderTitle;

                dt = rptDAL.DailyStudentAttendance(testgenid, sectionId, SessionID, Date);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            if (report == "StudentsMonthlyAttendance")
            {
                DataTable dt = new DataTable();
                rptStudentwiseMonthlyAttendance rpt = new rptStudentwiseMonthlyAttendance();
                reportsDAL rptDAL = new reportsDAL();

                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("StudentsMonthlyAttendance");
                
                dt = rptDAL.StudentsMonthlyAttendance(testgenid, sectionId, SessionID, Date);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "MonthlyDepartmentAttendance")
            {
                DataTable dt = new DataTable();
                rptMonthlyAttendanceDepartmentwise rpt = new rptMonthlyAttendanceDepartmentwise();
                reportsDAL rptDAL = new reportsDAL();

                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("MonthlyDepartmentAttendance");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.DepartmentwiseMonthlyAttendance(FromDate);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }



            if (report == "DailyDepartmentAttendance")
            {
                DataTable dt = new DataTable();
                rptMonthlyAttendanceDepartmentwise rpt = new rptMonthlyAttendanceDepartmentwise();
                reportsDAL rptDAL = new reportsDAL();

               // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("DailyDepartmentAttendance");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.DepartmentwiseDailyAttendance(FromDate);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "StockList")
            {
                DataTable dt = new DataTable();
                RPTStockList rpt = new RPTStockList();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("StockList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.RPTStockList();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "ProductList")
            {
                DataTable dt = new DataTable();
                RPTProductList rpt = new RPTProductList();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("ProductList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.RPTProductList();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "PurchaseOrderList")
            {
                DataTable dt = new DataTable();
                RPTPurchaseOrder rpt = new RPTPurchaseOrder();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("PurchaseOrderList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.RPTPurchaseOrder();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            if (report == "Return_PurchaseOrderList")
            {
                DataTable dt = new DataTable();
                Reports.RPTPurchaseOrder_Return rpt = new Reports.RPTPurchaseOrder_Return();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("Return_PurchaseOrderList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_PurchaseOrder_Return();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            if (report == "SaleOrderList")
            {
                DataTable dt = new DataTable();
                RPTSaleOrder rpt = new RPTSaleOrder();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("SaleOrderList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_SaleOrder();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            if (report == "Return_SaleOrderList")
            {
                DataTable dt = new DataTable();
                RPTSaleOrder_Return rpt = new RPTSaleOrder_Return();
                 reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("Return_SaleOrderList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_SaleOrder_Return();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }


            if (report == "SaleInvoice")
            {
                DataTable dt = new DataTable();
                RPTSaleInvoice rpt = new RPTSaleInvoice();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("SaleInvoice");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_SaleInvoice();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            //print Sale Invoice by Invoice No.
            
            if (report == "SaleInvoice_By InvoiceNo")
                
            {
                DataTable dt = new DataTable();
                RPTSaleInvoice rpt = new RPTSaleInvoice();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("SaleInvoice_By InvoiceNo");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


         

               

                dt = rptDAL.Rpt_SaleInvoice_By_InvoiceNo(Invoice_No); 
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
                //PrintDialog printDialog = new PrintDialog();
                //    if (printDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                //        reportDocument.Load(Application.StartupPath + rpt);
                //        reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                //        reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                //    }
              

               // crViewer.ReportSource = rpt;

            }


            if (report == "SaleInvoice_ByDate")

            {
                DataTable dt = new DataTable();
                RPTSaleInvoice rpt = new RPTSaleInvoice();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("SaleInvoice_ByDate");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;






                dt = rptDAL.Rpt_SaleInvoice_By_Date(date);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
                //PrintDialog printDialog = new PrintDialog();
                //    if (printDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                //        reportDocument.Load(Application.StartupPath + rpt);
                //        reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                //        reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                //    }


                // crViewer.ReportSource = rpt;

            }

            if (report == "PurchaseOrderSummary")
            {
                DataTable dt = new DataTable();
                RPTPurchaseOrderSummary rpt = new RPTPurchaseOrderSummary();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("PurchaseOrderSummary");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_PurchaseOrderSummary();
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "PurchaseOrderDetails")
            {
                DataTable dt = new DataTable();
                RPTPurchaseOrderDetails rpt = new RPTPurchaseOrderDetails();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("PurchaseOrderDetails");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_PurchaseOrderDetails();
               
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "PurchasingTaxReport")
            {
                DataTable dt = new DataTable();
                RPTPurchasingTaxReport rpt = new RPTPurchasingTaxReport();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("PurchasingTaxReport");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_PurchasingTaxReport();
              
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "PurchaseOrderStatus")
            {
                DataTable dt = new DataTable();
                RptPurchaseOrderStatus rpt = new RptPurchaseOrderStatus();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("PurchaseOrderStatus");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_PurchaseOrderStatus();

                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "ProductCostReport")
            {
                DataTable dt = new DataTable();
                RPTProductCostReport rpt = new RPTProductCostReport();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("ProductCostReport");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_ProductCostReport();

                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "VendorProductList")
            {
                DataTable dt = new DataTable();
                RptVendorProductList rpt = new RptVendorProductList();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("VendorProductList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_VendorProductList();

                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "VendorList")
            {
                DataTable dt = new DataTable();
                RPTVendorList rpt = new RPTVendorList();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("VendorList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_VendorList();

                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }


            if (report == "SalesByProductSummary")
            {
                DataTable dt = new DataTable();
                RptSalesByProductSummary rpt = new RptSalesByProductSummary();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("SalesByProductSummary");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_SalesByProductSummary();

                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "SalesByProductDetails")
            {
                DataTable dt = new DataTable();
                RPTSalesByProductDetails rpt = new RPTSalesByProductDetails();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("SalesByProductDetails");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.Rpt_SalesByProductDetails();

                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            if (report == "HistoricalInventory")
            {
                DataTable dt = new DataTable();
                RPtHistoricalInventory rpt = new RPtHistoricalInventory();
                reportsDAL rptDAL = new reportsDAL();

                // CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("HistoricalInventory");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.RptHistoricalInventory();

                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            if (report == "MedicineInStockMonthWise")
            {
                DataTable dt = new DataTable();
                rptMedicineListMonthly rpt = new rptMedicineListMonthly();
                reportsDAL rptDAL = new reportsDAL();

                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("MedicineInStock");
              //  txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.MedicineInStockMonthWise(FromDate);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
            if (report == "MedicineInStockDaily")
            {
                DataTable dt = new DataTable();
                rptMedicineListDaily rpt = new rptMedicineListDaily();
                reportsDAL rptDAL = new reportsDAL();

                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("MedicineInStock");
             ////   txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
             //   txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


             dt = rptDAL.MedicineInStockDaily(FromDate);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }

            if (report == "DailyPrescriptionList")
            {
                DataTable dt = new DataTable();
                rptDailyPatientPrescriptionList rpt = new rptDailyPatientPrescriptionList();
                reportsDAL rptDAL = new reportsDAL();


                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderDesc = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeaderTitle = rpt.ReportDefinition.ReportObjects["HeaderTitle"] as TextObject;
                //CrystalDecisions.CrystalReports.Engine.PictureObject txtReportHeaderPic = rpt.ReportDefinition.ReportObjects["HeaderDesc"] as PictureObject;

                ReportBAL rptBAL = rptDAL.GetReportDetails("DailyPrescriptionList");
                //txtReportHeaderDesc.Text = rptBAL.HeaderDesc;
                //        txtReportHeaderTitle.Text = rptBAL.HeaderTitle;


                dt = rptDAL.DailyPrescriptionList(FromDate);
                rpt.SetDataSource(dt);
                crViewer.ReportSource = rpt;
            }
        }
         



}
}
