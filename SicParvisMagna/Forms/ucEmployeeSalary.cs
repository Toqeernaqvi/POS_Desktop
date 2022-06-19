using SicParvisMagna.Controllers;
using SicParvisMagna.Library;
using SicParvisMagna.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SicParvisMagna.Forms
{
    public partial class ucEmployeeSalary : UserControl
    {
        string frm = "";
        bool visibility, admin;
        string username = "";
        DataGridViewButtonColumn btn_NewAdvance = new DataGridViewButtonColumn();
        bool loaddet = false;
        Validations v = new Validations();
        int days;
        int employee_id;
        private Guid salaryID = Guid.Empty;
        List<Tuple<int, int>> ListFullatend = new List<Tuple<int, int>>();

        List<Tuple<Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32>> ListSalary_and_Leave = new List<Tuple<Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32>>();

        private void loadCmbDepartment()
        {
            Department_DAL objDAL = new Department_DAL();
            Department_BAL obj = new Department_BAL();

 
          cmbx_Dept.DataSource = objDAL.Load();
            cmbx_Dept.ValueMember = "dept_id";
            cmbx_Dept.DisplayMember = "name";
            cmbx_Dept.SelectedIndex = -1;
        }
        public ucEmployeeSalary()
        {
            InitializeComponent();
            loadCmbDepartment();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            //Check Existing Salary 
            Employee_Salary_RecordBAL obj = new Employee_Salary_RecordBAL();
            Employee_Salary_RecordDAL objD = new Employee_Salary_RecordDAL();
            obj.dep_id = Guid.Parse(cmbx_Dept.SelectedValue.ToString());
            obj.SalaryDate = dtp_SalaryMonth.Value;

            dtt = objD.FindByDepartment(obj);
            if (dtt.Rows.Count > 0)
            {
                DialogResult resultt = MessageBox.Show("Record is Already Availbale. Are you sure to want to Modify this Record ", "Record ", MessageBoxButtons.YesNo);
                if(resultt == DialogResult.Yes)
                {
                    for (int x = 0; x < dtt.Rows.Count; x++)
                    {
                        salaryID = Guid.Parse(dtt.Rows[x]["esr_id"].ToString());
                        obj.esr_id = salaryID;
                        objD.Delete(obj);
                    }

                }
            }
              
                EmployeePersonalInfoDAL emp_db = new EmployeePersonalInfoDAL();
            if (cmbx_Dept.SelectedIndex > -1)
            {
                if (gridEmployee.Rows.Count >= 1)
                {
                    Employee_Salary_RecordDAL salary_db = new Employee_Salary_RecordDAL();
                    Employee_Salary_RecordBAL objBal = new Employee_Salary_RecordBAL();
                    objBal.dep_id = Guid.Parse(cmbx_Dept.SelectedValue.ToString());
                    objBal.SalaryDate = dtp_SalaryMonth.Value;
                    DataTable dt = salary_db.FindByDepartment(objBal);
                    if (dt.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Salary for Department already exists in selected Date \n Do you wish to override?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return;
                        else if (result == DialogResult.Yes)
                        {
                            salary_db.DeleteByDepartment(objBal);
                        }
                        else
                            return;
                    }



                    for (int i = 0; i < gridEmployee.RowCount; i++)
                    {







                        Employee_Salary_RecordBAL salary = new Employee_Salary_RecordBAL();
                        salary.dep_id = Guid.Parse(cmbx_Dept.SelectedValue.ToString());
                        salary.emp_id = Guid.Parse(gridEmployee.Rows[i].Cells["emp_id"].Value.ToString());
                        salary.Employee_Name = gridEmployee.Rows[i].Cells["Employee Name"].Value.ToString();
                        salary.Date_of_Join = Convert.ToDateTime(gridEmployee.Rows[i].Cells["Date of join"].Value.ToString());
                        salary.Designation = gridEmployee.Rows[i].Cells["Designation"].Value.ToString();
                        salary.Basic_Salary = Convert.ToInt32(gridEmployee.Rows[i].Cells["Basic Salary"].Value.ToString());
                        salary.Total_Days = Convert.ToInt32(gridEmployee.Rows[i].Cells["Total Days"].Value.ToString());
                        salary.Attendance_Days = (float)Convert.ToDouble(gridEmployee.Rows[i].Cells["Attendance Days"].Value.ToString());
                        salary.Per_Day_Salary = (float)Convert.ToDouble(gridEmployee.Rows[i].Cells["Per Day Salary"].Value.ToString());
                        try
                        {
                            salary.Per_Hour_Salary = Convert.ToInt32(gridEmployee.Rows[i].Cells["Per Hour Salary"].Value.ToString());
                        }
                        catch
                        {
                            salary.Per_Hour_Salary = 0;

                        }

                        salary.Total_Days_Amount = Convert.ToInt32(gridEmployee.Rows[i].Cells["Total Days Amount"].Value.ToString());
                        salary.Extra_Duty_Days = (float)Convert.ToDouble(gridEmployee.Rows[i].Cells["Extra Duty Days"].Value.ToString());
                        salary.Extra_Duty_Hours = (float)Convert.ToDouble(gridEmployee.Rows[i].Cells["Extra Duty Hours"].Value.ToString());
                        salary.Extra_Duty_Minutes = (float)Convert.ToDouble(gridEmployee.Rows[i].Cells["Extra Duty Minutes"].Value.ToString());
                        salary.Extra_Duty_Amount = Convert.ToInt32(gridEmployee.Rows[i].Cells["Extra Duty Amount"].Value.ToString());
                        salary.Payable_Amount = Convert.ToInt32(gridEmployee.Rows[i].Cells["Payable Amount"].Value.ToString());


                        if (gridEmployee.Rows[i].Cells["Include Leave Salary"].Value.ToString() == "True")
                            salary.Leave_Salary = Convert.ToInt32(gridEmployee.Rows[i].Cells["Leave Salary"].Value.ToString());
                        else
                            salary.Leave_Salary = 0;

                        salary.Other_Expences = Convert.ToInt32(gridEmployee.Rows[i].Cells["Other Expences"].Value.ToString());
                        salary.Salary_Deduction = Convert.ToInt32(gridEmployee.Rows[i].Cells["Salary Deduction"].Value.ToString());
                        salary.Advance_Salary = Convert.ToInt32(gridEmployee.Rows[i].Cells["Advance Salary"].Value.ToString());
                        salary.Net_Payable_Amount = (int)Convert.ToDouble(gridEmployee.Rows[i].Cells["Net Payable Amount"].Value.ToString());
                        salary.SalaryDate = dtp_SalaryMonth.Value;



                        if (gridEmployee.Rows[i].Cells["Regular Allowance 3 Days"].Value.ToString() == "True")
                        {
                            double regularAllowance3 = salary.Per_Day_Salary * 3;
                            salary.RegularityAmount = (float)regularAllowance3;
                            salary.RegularityDays = 3;
                        }
                        else if (gridEmployee.Rows[i].Cells["Regular Allowance 2 Days"].Value.ToString() == "True")
                        {
                            double regularAllowance2 = salary.Per_Day_Salary * 2;
                            salary.RegularityAmount = (float)regularAllowance2;
                            salary.RegularityDays = 2;
                        }
                        else if (gridEmployee.Rows[i].Cells["Regular Allowance 2 and Half"].Value.ToString() == "True")
                        {

                            double regularAllowance25 = salary.Per_Day_Salary * 2.5;
                            salary.RegularityAmount = (float)regularAllowance25;
                            salary.RegularityDays = (float)2.5;
                        }



                        salary_db.Add(salary);

                    }
                }
            }

            gridEmployee.Columns.Clear();
            cmbx_Dept.SelectedIndex = -1;
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            dtp_SalaryMonth.Format = DateTimePickerFormat.Custom;
            dtp_SalaryMonth.CustomFormat = "MM / yyyy";
        }
        public void PutZero()
        {
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {
                gridEmployee.Rows[i].Cells["Extra Duty Days"].Value = 0;
                gridEmployee.Rows[i].Cells["Extra Duty Hours"].Value = 0;
                gridEmployee.Rows[i].Cells["Extra Duty Minutes"].Value = 0;
                gridEmployee.Rows[i].Cells["Other Expences"].Value = 0;
                gridEmployee.Rows[i].Cells["Advance Salary"].Value = 0;
                gridEmployee.Rows[i].Cells["Salary Deduction"].Value = 0;
                gridEmployee.Rows[i].Cells["Leave Salary"].Value = 0;
                //    gridEmployee.Rows[i].Cells["Regularity Allowance"].Value   = 0;
                gridEmployee.Rows[i].Cells["Include Leave Salary"].Value = "False";
                gridEmployee.Rows[i].Cells["Regular Allowance 2 Days"].Value = "False";

                gridEmployee.Rows[i].Cells["Regular Allowance 2 and Half"].Value = "False";
                gridEmployee.Rows[i].Cells["Regular Allowance 3 Days"].Value = "False";

                gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = 0;
                gridEmployee.Rows[i].Cells["Basic Salary"].Value = 0;
                gridEmployee.Rows[i].Cells["Attendance Hours"].Value = 0;
            }
        }
        public void AttendanceDays()
        {
            double TotalAttendance = 0, totaldays = 0;
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {
                try
                {
                    totaldays = Convert.ToDouble(gridEmployee.Rows[i].Cells["Total Days"].Value.ToString());
                    TotalAttendance = Convert.ToDouble(gridEmployee.Rows[i].Cells["Attendance Days"].Value.ToString());
                    if (totaldays < TotalAttendance)
                    {
                        gridEmployee.Rows[i].Cells["Attendance Days"].Value = totaldays;
                    }


                }
                catch (Exception)
                {
                     
                        gridEmployee.Rows[i].Cells["Attendance Days"].Value = 0;
                  
                }
            }
        }
        public void PerDaySalary()
        {
            double reservedsalary, totaldays;
            for (int i = 0; i < gridEmployee.Rows.Count; i++)
            {
                try
                {
                    reservedsalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Basic Salary"].Value.ToString());
                    totaldays = Convert.ToDouble(gridEmployee.Rows[i].Cells["Total Days"].Value.ToString());
                   double  total = reservedsalary / totaldays;
                    gridEmployee.Rows[i].Cells["Per Day Salary"].Value = Math.Round(total, 2);
                    if (gridEmployee.Rows[i].Cells["Per Day Salary"].Value.ToString() == "Infinity" || gridEmployee.Rows[i].Cells["Per Day Salary"].Value.ToString() == "NaN")
                    {
                        gridEmployee.Rows[i].Cells["Per Day Salary"].Value = 0;
                    }

                }
                catch (Exception)
                {
                    gridEmployee.Rows[i].Cells["Per Day Salary"].Value = 0;
                }
            }

        }
        public void PerHourSalary()
        {
            double perdaySalary;
            for (int i = 0; i < gridEmployee.Rows.Count; i++)
            {
                try
                {
                    perdaySalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Per Day Salary"].Value.ToString());
                    if (cmbx_Dept.Text.Trim() == "Security Staff" || cmbx_Dept.Text.Trim() == "Administration")
                        gridEmployee.Rows[i].Cells["Per Hour Salary"].Value = Math.Round( perdaySalary / 9,2);
                    else if (cmbx_Dept.Text.Trim() == "Dars e Nizami")
                        gridEmployee.Rows[i].Cells["Per Hour Salary"].Value = Math.Round( perdaySalary / 5,2);
                    else if (cmbx_Dept.Text.Trim() == "Health Care Center")
                        gridEmployee.Rows[i].Cells["Per Hour Salary"].Value = Math.Round(perdaySalary / 3,2);
                    else
                        gridEmployee.Rows[i].Cells["Per Hour Salary"].Value = Math.Round(perdaySalary / 6,2);

                    if (gridEmployee.Rows[i].Cells["Per Hour Salary"].Value.ToString() == "Infinity" || gridEmployee.Rows[i].Cells["Per Hour Salary"].Value.ToString() == "NaN")
                    {
                        gridEmployee.Rows[i].Cells["Per Hour Salary"].Value = 0;
                    }
                }
                catch (Exception)
                {
                    gridEmployee.Rows[i].Cells["Per Hour Salary"].Value = 0;
                }
            }

        }
        public void TotalDaysAmount()
        {
            double perdaySalary, TotalAttendance;
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {
                try
                {

                    perdaySalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Per Day Salary"].Value.ToString());
                    TotalAttendance = Convert.ToDouble(gridEmployee.Rows[i].Cells["Attendance Days"].Value.ToString());
                    gridEmployee.Rows[i].Cells["Total Days Amount"].Value = Math.Round(perdaySalary * TotalAttendance);
                    if (gridEmployee.Rows[i].Cells["Total Days Amount"].Value.ToString() == "Infinity" || gridEmployee.Rows[i].Cells["Total Days Amount"].Value.ToString() == "NaN")
                    {
                        gridEmployee.Rows[i].Cells["Total Days Amount"].Value = 0;
                    }


                }
                catch (Exception)
                {
                    gridEmployee.Rows[i].Cells["Total Days Amount"].Value = 0;

                }
            }

        }
        public void TotalHoursAmount()
        {
            double perhourSalary, perdaySalary, TotalAttendance;
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {
                try
                {

                    TotalAttendance = Convert.ToDouble(gridEmployee.Rows[i].Cells["Attendance Hours"].Value.ToString());

                    perdaySalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Per Day Salary"].Value.ToString());
                    perhourSalary = Math.Round(perdaySalary / 11);


                    gridEmployee.Rows[i].Cells["Total Hours Amount"].Value = Math.Round(perhourSalary * TotalAttendance);
                    if (gridEmployee.Rows[i].Cells["Total Hours Amount"].Value.ToString() == "Infinity" || gridEmployee.Rows[i].Cells["Total Days Amount"].Value.ToString() == "NaN")
                    {
                        gridEmployee.Rows[i].Cells["Total Hours Amount"].Value = 0;
                    }

                }
                catch (Exception ex)
                {
                    gridEmployee.Rows[i].Cells["Total Hours Amount"].Value = 0;
                }
            }

        }
        ////public void TotalDays_HoursAmount()
        ////{
        ////    double TotalDaysAmount, TotalHoursAmount;
        ////    for (int i = 0; i < gridEmployee.RowCount; i++)
        ////    {
        ////        try
        ////        {

        ////            TotalDaysAmount = Convert.ToInt32(gridEmployee.Rows[i].Cells["Total Days Amount"].Value.ToString());
        ////            TotalHoursAmount = Convert.ToInt32(gridEmployee.Rows[i].Cells["Total Hours Amount"].Value.ToString());
        ////            gridEmployee.Rows[i].Cells["Total Days Hours Amount"].Value = Math.Round(TotalDaysAmount + TotalHoursAmount);

        ////            if (gridEmployee.Rows[i].Cells["Total Days Hours Amount"].Value.ToString() == "Infinity" || gridEmployee.Rows[i].Cells["Total Days Hours Amount"].Value.ToString() == "NaN")
        ////            {
        ////                gridEmployee.Rows[i].Cells["Total Days Hours Amount"].Value = 0;
        ////            }
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            gridEmployee.Rows[i].Cells["Total Days Hours Amount"].Value = 0;
        ////        }
        ////    }

        ////}
        public void PayableAmount()
        {
            double TotalDays_HoursAmount, ExtraDutyAmount;
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {
                try
                {

                    TotalDays_HoursAmount = Convert.ToDouble(gridEmployee.Rows[i].Cells["Total Days Amount"].Value.ToString());
                    ExtraDutyAmount = Convert.ToDouble(gridEmployee.Rows[i].Cells["Extra Duty Amount"].Value.ToString());
                    gridEmployee.Rows[i].Cells["Payable Amount"].Value = Math.Round(TotalDays_HoursAmount + ExtraDutyAmount);


                }
                catch (Exception ex)
                {
                    gridEmployee.Rows[i].Cells["Payable Amount"].Value = 0;
                }
            }
        }
        public void Payed_Loan()
        {
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {
                try
                {



                    //double payedAmount = Convert.ToDouble(gridEmployee.Rows[i].Cells["Other Expences"].Value.ToString());
                    //double Loan = Convert.ToDouble(gridEmployee.Rows[i].Cells["Leave Salary"].Value.ToString());
                    //double Basic_Salary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Basic Salary"].Value.ToString());
                    //if (payedAmount > Loan)
                    //{
                    //    gridEmployee.Rows[i].Cells["Other Expences"].Value = Loan;
                    //    if (payedAmount > Basic_Salary)
                    //    {
                    //        gridEmployee.Rows[i].Cells["Other Expences"].Value = Basic_Salary;
                    //    }
                    //}
                }
                catch (Exception)
                {
                    gridEmployee.Rows[i].Cells["Other Expences"].Value = 0;
                }
            }
        }
        public void Loan_Balance()
        {
            //for (int i = 0; i < gridEmployee.RowCount; i++)
            //{
            //    //try
            //    //{

            //    //    double Loan = Convert.ToDouble(gridEmployee.Rows[i].Cells["Loan"].Value.ToString());
            //    //    double payedAmount = Convert.ToDouble(gridEmployee.Rows[i].Cells["Leave Salary"].Value.ToString());
            //    //    gridEmployee.Rows[i].Cells["Loan Balance"].Value = Loan - payedAmount;

            //    //}
            //    //catch (Exception)
            //    //{
            //    //    gridEmployee.Rows[i].Cells["Loan Balance"].Value = 0;
            //    //}
            //}

        }
        public void ExtraHourAmount()
        {
            double ExtraDutyDays, ExtraDutyHours, ExtraDutyMinutes, PerHourSalary, PerDaySalary;
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {
                try
                {

                    ExtraDutyDays = Convert.ToDouble(gridEmployee.Rows[i].Cells["Extra Duty Days"].Value.ToString());
                    ExtraDutyHours = Convert.ToDouble(gridEmployee.Rows[i].Cells["Extra Duty Hours"].Value.ToString());
                    ExtraDutyMinutes = Convert.ToDouble(gridEmployee.Rows[i].Cells["Extra Duty Minutes"].Value.ToString());
                    PerDaySalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Per Day Salary"].Value.ToString());
                    PerHourSalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Per Hour Salary"].Value.ToString());
                    gridEmployee.Rows[i].Cells["Extra Duty Amount"].Value = Math.Round((ExtraDutyDays * PerDaySalary) + (ExtraDutyHours * PerHourSalary) + (ExtraDutyMinutes * (PerHourSalary / 60)));


                }
                catch (Exception ex)
                {
                    gridEmployee.Rows[i].Cells["Extra Duty Amount"].Value = 0;
                }
            }
        }
        public void NetPayableAmount()
        {
            double Advance_Received, PayableAmount;
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {
                try
                {

                    PayableAmount = Convert.ToDouble(gridEmployee.Rows[i].Cells["Payable Amount"].Value.ToString());
                    double otherExpences = Convert.ToDouble(gridEmployee.Rows[i].Cells["Other Expences"].Value.ToString());
                    double AdvanceSalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Advance Salary"].Value.ToString());
                    double TotalHourlySalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Total Hours Amount"].Value.ToString());
                    double SalaryDeduction = Convert.ToDouble(gridEmployee.Rows[i].Cells["Salary Deduction"].Value.ToString());
                    double leaveSalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Leave Salary"].Value.ToString());
                    //   double regularAllowance  = Convert.ToDouble(gridEmployee.Rows[i].Cells["Regularity Allowance"].Value.ToString());
                    double salary = (double)gridEmployee.Rows[i].Cells["Per Day Salary"].Value;
                    //                    finalAllowance = salary * 3;
                    //                    gridEmployee.Rows[i].Cells["Regularity Allowance"].Value = salary * 3;

                    double regularAllowance2 = salary * 2;
                    double regularAllowance25 = salary * 2.5;
                    double regularAllowance3 = salary * 3;

                    if (gridEmployee.Rows[i].Cells["Regular Allowance 3 Days"].Value.ToString() == "True" && gridEmployee.Rows[i].Cells["Include Leave Salary"].Value.ToString() != "True")
                        gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = (PayableAmount + otherExpences + regularAllowance3 + TotalHourlySalary) - AdvanceSalary - SalaryDeduction;
                    else if (gridEmployee.Rows[i].Cells["Regular Allowance 3 Days"].Value.ToString() == "True" && gridEmployee.Rows[i].Cells["Include Leave Salary"].Value.ToString() == "True")
                        gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = (PayableAmount + otherExpences + leaveSalary + regularAllowance3 + TotalHourlySalary) - AdvanceSalary - SalaryDeduction;


                    else if (gridEmployee.Rows[i].Cells["Regular Allowance 2 Days"].Value.ToString() == "True" && gridEmployee.Rows[i].Cells["Include Leave Salary"].Value.ToString() != "True")
                        gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = (PayableAmount + otherExpences + regularAllowance2 + TotalHourlySalary) - AdvanceSalary - SalaryDeduction;
                    else if (gridEmployee.Rows[i].Cells["Regular Allowance 2 Days"].Value.ToString() == "True" && gridEmployee.Rows[i].Cells["Include Leave Salary"].Value.ToString() == "True")
                        gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = (PayableAmount + otherExpences + leaveSalary + regularAllowance2 + TotalHourlySalary) - AdvanceSalary - SalaryDeduction;


                    else if (gridEmployee.Rows[i].Cells["Regular Allowance 2 and Half"].Value.ToString() == "True" && gridEmployee.Rows[i].Cells["Include Leave Salary"].Value.ToString() != "True")
                        gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = (PayableAmount + otherExpences + regularAllowance25 + TotalHourlySalary) - AdvanceSalary - SalaryDeduction;
                    else if (gridEmployee.Rows[i].Cells["Regular Allowance 2 and Half"].Value.ToString() == "True" && gridEmployee.Rows[i].Cells["Include Leave Salary"].Value.ToString() == "True")
                        gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = (PayableAmount + otherExpences + leaveSalary + regularAllowance25 + TotalHourlySalary) - AdvanceSalary - SalaryDeduction;


                    else if (gridEmployee.Rows[i].Cells["Include Leave Salary"].Value.ToString() == "True")
                        gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = (PayableAmount + otherExpences + leaveSalary + TotalHourlySalary) - AdvanceSalary - SalaryDeduction;
                    else
                        gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = (PayableAmount + otherExpences + TotalHourlySalary) - AdvanceSalary - SalaryDeduction;
                }
                catch (Exception ex)
                {
                    gridEmployee.Rows[i].Cells["Net Payable Amount"].Value = 0;
                }
            }
        }
        public void Total()
        {
            //            //gridEmployee.Columns.Add("Extra Duty Amount", "Extra Duty Amount");
            //            //gridEmployee.Columns.Add("Payable Amount", "Payable Amount");
            //            //gridEmployee.Columns.Add("Advance Received", "Advance Received");
            //            //gridEmployee.Columns.Add("Net Payable Amount", "Net Payable Amount");
            //            double ExtraDutyAmount = 0, PayableAmount = 0, NetPayableAmount = 0,
            //                salary = 0, leaveSalary = 0, payedamount=0, loanbalance=0, advanceSalary = 0;
            //            for (int i = 0; i < gridEmployee.RowCount; i++)
            //            {
            //                try
            //                {
            //                    salary+= Convert.ToDouble(gridEmployee.Rows[i].Cells["Basic Salary"].Value.ToString());
            //                    ExtraDutyAmount += Convert.ToDouble(gridEmployee.Rows[i].Cells["Extra Duty Amount"].Value.ToString());
            //                    PayableAmount += Convert.ToDouble(gridEmployee.Rows[i].Cells["Payable Amount"].Value.ToString());
            //                    leaveSalary += Convert.ToDouble(gridEmployee.Rows[i].Cells["Leave Salary"].Value.ToString());
            //                    payedamount += Convert.ToDouble(gridEmployee.Rows[i].Cells["Other Expences"].Value.ToString());
            ////loanbalance+=Convert.ToDouble(gridEmployee.Rows[i].Cells["Loan Balance"].Value.ToString());
            //                    advanceSalary += Convert.ToDouble(gridEmployee.Rows[i].Cells["Advance Salary"].Value.ToString());
            //                    NetPayableAmount += Convert.ToDouble(gridEmployee.Rows[i].Cells["Net Payable Amount"].Value.ToString());

            //                }rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr
            //                catch (Exception)
            //                {

            //                }
            //            }
            //            txt_Salary.Text = Math.Round(salary).ToString();
            //            txt_ExtraDutyAmount.Text = Math.Round(ExtraDutyAmount).ToString();
            //            txt_PayableAmount.Text = Math.Round(PayableAmount).ToString();
            //            txt_Loan.Text = Math.Round(leaveSalary).ToString();
            //            txt_PayedAmount.Text = Math.Round(payedamount).ToString();
            //            txt_LoanBalance.Text = Math.Round(loanbalance).ToString();
            //            txt_AdvanceSalary.Text = Math.Round(advanceSalary).ToString();
            //            txt_NetPayable_Amount.Text = Math.Round(NetPayableAmount).ToString();
        }

        public void LeaveSalary()
        {
            Employee_SalaryAndLeavesBAL salary = new Employee_SalaryAndLeavesBAL();
            Employee_SalaryAndLeavesDAL salaryDb = new Employee_SalaryAndLeavesDAL();
            double Dailysalary, totalSalary, NoOfDays, Multiply = 0, NoOfLeaveAllowed = 0, AttendanceDays = 0;
            DateTime joinDate;
            for (int i = 0; i < gridEmployee.Rows.Count; i++)
            {

                NoOfLeaveAllowed = 0;
                joinDate = Convert.ToDateTime(gridEmployee.Rows[i].Cells["Date of join"].Value.ToString());

                int YearsJoined = Years(joinDate, dtp_SalaryMonth.Value.Date);

                if (YearsJoined < 0)
                {
                    Multiply = 0;

                }
                if (YearsJoined == 0)
                {
                    NoOfLeaveAllowed = 5;
                    Multiply = 0.416;
                }
                else if (YearsJoined == 1)
                {
                    NoOfLeaveAllowed = 10;
                    Multiply = 0.833;
                }
                else if (YearsJoined == 2 || YearsJoined == 3)
                {
                    NoOfLeaveAllowed = 15;
                    Multiply = 1.25;
                }
                else if (YearsJoined >= 4)
                {
                    NoOfLeaveAllowed = 20;
                    Multiply = 1.66;
                }




                Dailysalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Per Day Salary"].Value.ToString());
                salary.employee_id = Guid.Parse(gridEmployee.Rows[i].Cells["emp_id"].Value.ToString());
                totalSalary = Convert.ToDouble(gridEmployee.Rows[i].Cells["Basic Salary"].Value.ToString());
                NoOfDays = Convert.ToDouble(gridEmployee.Rows[i].Cells["Total Days"].Value.ToString());
                AttendanceDays = Convert.ToDouble(gridEmployee.Rows[i].Cells["Attendance Days"].Value.ToString());

                try
                {
                    if (dtp_SalaryMonth.Value.Month == joinDate.Month && dtp_SalaryMonth.Value.Year == joinDate.Year)
                    {
                        gridEmployee.Rows[i].Cells["Leave Salary"].Value = Convert.ToInt32((((totalSalary / NoOfDays) * 0.416) / NoOfDays) * AttendanceDays);
                    }
                    else
                        gridEmployee.Rows[i].Cells["Leave Salary"].Value = Convert.ToInt32((totalSalary / NoOfDays) * Multiply);
                }
                catch (Exception)
                {
                    gridEmployee.Rows[i].Cells["Leave Salary"].Value = 0;
                }
                // gridEmployee.Rows[i].Cells["Leave Salary"].Value = Convert.ToInt32((Dailysalary * NoOfLeaveAllowed) / 12);
            }

        }
        private int Years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }


        public void EmployeeSalary_Leave()
        {
            try
            {
                EmployeePersonalInfoDAL empl_DB = new EmployeePersonalInfoDAL();
                Employee_SalaryAndLeavesBAL salary = new Employee_SalaryAndLeavesBAL();
                Employee_SalaryAndLeavesDAL salaryDb = new Employee_SalaryAndLeavesDAL();
                for (int i = 0; i < gridEmployee.Rows.Count; i++)
                {
                    Guid employee_id = Guid.Parse(gridEmployee.Rows[i].Cells["emp_id"].Value.ToString());
                    salary.employee_id = employee_id;
                    var sl = salaryDb.LoadbyId(salary);
                    for (int j = 0; j < sl.Rows.Count; j++)
                    {
                        int totalsalary = Convert.ToInt32(sl.Rows[j]["totalSalary"].ToString());

                        Int32 NoOfLeaveAllowed = Convert.ToInt32(sl.Rows[j]["NoOfLeaveAllowed"].ToString());

                        Int32 RemainingLeaves = Convert.ToInt32(sl.Rows[j]["RemainingLeaves"].ToString());

                        Int32 NoOfMedicalLeaveAllowed = Convert.ToInt32(sl.Rows[j]["NoOfMedicalLeaveAllowed"].ToString());

                        Int32 RemainingMedicalLeaves = Convert.ToInt32(sl.Rows[j]["RemainingMedicalLeaves"].ToString());

                        Int32 LeaveIncrement = Convert.ToInt32(sl.Rows[j]["LeaveIncrement"].ToString());

                        Int32 RemainingMonths = Convert.ToInt32(sl.Rows[j]["RemainingMonths"].ToString());


                        // ListSalary_and_Leave.Add(
                        //     new Tuple<Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32>
                        //   (employee_id, totalsalary, NoOfLeaveAllowed, RemainingLeaves, NoOfMedicalLeaveAllowed, RemainingMedicalLeaves, LeaveIncrement, RemainingMonths)


                        //    );
                        gridEmployee.Rows[i].Cells["Basic Salary"].Value = totalsalary.ToString();

                        gridEmployee.Rows[i].Cells["Employee Id"].Value = salary.employee_id;
                    }

                }

            }
            catch (Exception ex)
            {

            }
        }
        //private void RegularityAllowance()
        //{
        //    double salary;
        //    int finalAllowance;
        //    for (int i = 0; i < gridEmployee.Rows.Count; i++)
        //    {
        //        try
        //        {
        //            string total = gridEmployee.Rows[i].Cells["Total Days"].Value.ToString();
        //            string attended = gridEmployee.Rows[i].Cells["Attendance Days"].Value.ToString();

        //            if (total == attended)
        //            {
        //                if (gridEmployee.Rows[i].Cells["Regular on Time"].Value.ToString() == "True")
        //                {
        //                    salary = (double)gridEmployee.Rows[i].Cells["Per Day Salary"].Value;
        //                    finalAllowance = salary * 3;
        //                    gridEmployee.Rows[i].Cells["Regularity Allowance"].Value = salary * 3;
        //                }
        //                else
        //                {
        //                    gridEmployee.Rows[i].Cells["Regularity Allowance"].Value = 0;
        //                }
        //            }
        //            else
        //            {
        //                gridEmployee.Rows[i].Cells["Regularity Allowance"].Value = 0;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            gridEmployee.Rows[i].Cells["Regularity Allowance"].Value = 0;
        //        }
        //    }
        //}

        private void EmployeeAttendance()
        {
            try
            {
                EmployeePersonalInfoDAL empl_DB = new EmployeePersonalInfoDAL();
                EmployAttendanceDAL attend_db = new EmployAttendanceDAL();
                for (int i = 0; i < gridEmployee.Rows.Count; i++)
                {
                    //int employee_id = Convert.ToInt32(gridEmployee.Rows[i].Cells["emp_id"].Value.ToString());

                    //int fullattendance = attend_db.GetRowCountforType(DateTime.Now, DateTime.Now, employee_id, 0);
                    //int HalfDay = attend_db.GetRowCountforType(DateTime.Now, DateTime.Now, employee_id, 1);
                    //int absent = attend_db.GetRowCountforType(DateTime.Now, DateTime.Now, employee_id, 2);
                    //if (absent == 0)
                    //{
                    //    gridEmployee.Rows[i].Cells["Attendance Days"].Value = days;
                    //}
                    //else
                    //{
                    //    // gridEmployee.Rows[i].Cells["Attendance Days"].Value = fullattendance.ToString();
                    //    gridEmployee.Rows[i].Cells["Attendance Days"].Value = fullattendance;
                    //}
                    //ListFullatend.Add(new Tuple<int, int>(employee_id, fullattendance));
                    gridEmployee.Rows[i].Cells["Attendance Days"].Value = 0;
                }
            }
            catch (Exception e)
            {

            }



        }
        private void FindDaysinMonth()
        {
            days = DateTime.DaysInMonth(dtp_SalaryMonth.Value.Year, dtp_SalaryMonth.Value.Month);
            for (int i = 0; i < gridEmployee.Rows.Count; i++)
            {
                gridEmployee.Rows[i].Cells["Total Days"].Value = days.ToString();
            }
        }

        private void gridEmployee_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            AttendanceDays();
            PerDaySalary();
            PerHourSalary();
            TotalDaysAmount();
            TotalHoursAmount();
            //TotalDays_HoursAmount();
            ExtraHourAmount();
            PayableAmount();
            Payed_Loan();
            SalaryDeduction();
            Loan_Balance();
            //    RegularityAllowance();
            NetPayableAmount();
            Total();
            ValidateGrid();
        }

        private void gridEmployee_CellClick(object snder, DataGridViewCellEventArgs e)
        {
            
                
                    AttendanceDays();
                    PerDaySalary();
                    PerHourSalary();
                    TotalDaysAmount();
                    //TotalHoursAmount();
                    //TotalDays_HoursAmount();
                    ExtraHourAmount();
                    PayableAmount();
                    Payed_Loan();
                    Loan_Balance();
                    //    RegularityAllowance();
                    NetPayableAmount();
                    SalaryDeduction();
                    Total();
                    LeaveSalary();
                    ValidateGrid();
                 
        }

        private void SalaryDeduction()
        {
            for (int i = 0; i < gridEmployee.RowCount; i++)
            {

                try
                {





                    //DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                    //ch1 = (DataGridViewCheckBoxCell)gridEmployee.Rows[e.RowIndex].Cells[16];

                    //if (ch1.Value == null)
                    //    ch1.Value = false;
                    //switch (ch1.Value.ToString())
                    //{
                    //    case "True":
                    //        ch1.Value = false;
                    //        break;
                    //    case "False":
                    //        ch1.Value = true;
                    //        break;


                    //}




                    if (gridEmployee.Rows[i].Cells["5 % Salary Deduction"].Value.ToString() == "True")
                    //if (ch1.Value.ToString() == "True")
                    {
                        int Salary = Convert.ToInt32(gridEmployee.Rows[i].Cells["Basic Salary"].Value.ToString());
                        gridEmployee.Rows[i].Cells["Salary Deduction"].Value = (Salary / 100) * 5;
                    }
                    else
                    {
                        gridEmployee.Rows[i].Cells["Salary Deduction"].Value = 0;
                    }

                }
                catch (Exception ex)
                {

                    gridEmployee.Rows[i].Cells["Salary Deduction"].Value = 0;
                }
            }
            
        }

        public void ValidateGrid()
        {
            ////int x, y, z;
            ////for (int i = 0; i < gridEmployee.RowCount; i++)
            ////{
            ////    try
            ////    {
            ////        x = Convert.ToInt32(gridEmployee.Rows[i].Cells["Extra Duty Days"].Value);
            ////    }
            ////    catch (Exception)
            ////    {
            ////        gridEmployee.Rows[i].Cells["Extra Duty Days"].Value = 0;
            ////    }
            ////    try
            ////    {

            ////    //    y = Convert.ToInt32(gridEmployee.Rows[i].Cells["Attendance Hours"].Value);
            ////    }
            ////    catch (Exception)
            ////    {
            ////        //gridEmployee.Rows[i].Cells["Attendance Hours"].Value = 0;
            ////    }
            ////    try
            ////    {
            ////        z = Convert.ToInt32(gridEmployee.Rows[i].Cells["Advance Received"].Value);

            ////    }
            ////    catch (Exception)
            ////    {

            ////    }

            ////}
        }

        private bool SearchValidated()
        {
            if (string.IsNullOrEmpty(dtp_SalaryMonth.Value.ToString()))
            {
                lblError_Month.Text = "* Required";
                return false;
            }
            else
                lblError_Month.Text = "";

            if (cmbx_Dept.SelectedValue != null && string.IsNullOrEmpty(cmbx_Dept.SelectedValue.ToString()))
            {
                lblError_Department.Text = "* Required";
                return false;
            }
            else
                lblError_Department.Text = "";


            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (SearchValidated())
            {
                gridEmployee.Columns.Clear();
                try
                {
                    DataTable dt = new DataTable();

                    //Check Existing Salary 
                    Employee_Salary_RecordBAL obj = new Employee_Salary_RecordBAL();
                    Employee_Salary_RecordDAL objD = new Employee_Salary_RecordDAL();
                    obj.dep_id = Guid.Parse(cmbx_Dept.SelectedValue.ToString());
                    obj.SalaryDate = dtp_SalaryMonth.Value;

                    dt = objD.FindByDepartment(obj);
                    if (dt.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Record is Already Availbale. Are you sure to want to Modify this Record ", "Record ", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            EmployeePersonalInfoBAL employee = new EmployeePersonalInfoBAL();
                            EmployeePersonalInfoDAL db = new EmployeePersonalInfoDAL();
                            employee.dept_id = Guid.Parse(cmbx_Dept.SelectedValue.ToString());

                            gridEmployee.DataSource = db.LoadbyDept(employee);
                            gridEmployee.Columns.Add("Basic Salary", "Basic Salary");       //3
                            gridEmployee.Columns["Basic Salary"].ReadOnly = true;

                            gridEmployee.Columns.Add("Total Days", "Total Days");           //4
                            gridEmployee.Columns["Total Days"].ReadOnly = true;

                            gridEmployee.Columns.Add("Attendance Days", "Attendance Days");     //5
                            gridEmployee.Columns["Attendance Days"].ReadOnly = false;

                            //gridEmployee.Columns.Add("Attendance Hours", "Attendance Hours");       //6
                            //gridEmployee.Columns["Attendance Hours"].ReadOnly = false;


                            gridEmployee.Columns.Add("Attendance Hours", "Attendance Hours");       //6
                            gridEmployee.Columns["Attendance Hours"].ReadOnly = false;

                            gridEmployee.Columns.Add("Per Day Salary", "Per Day Salary");           //7
                            gridEmployee.Columns["Per Day Salary"].ReadOnly = true;

                            gridEmployee.Columns.Add("Per Hour Salary", "Per Hour Salary");             //8
                            gridEmployee.Columns["Per Hour Salary"].ReadOnly = true;

                            gridEmployee.Columns.Add("Total Days Amount", "Total Days Amount");         //9
                            gridEmployee.Columns["Total Days Amount"].ReadOnly = true;

                            gridEmployee.Columns.Add("Total Hours Amount", "Total Hours Amount");           //10
                            gridEmployee.Columns["Total Hours Amount"].ReadOnly = true;

                            //gridEmployee.Columns.Add("Total Days Hours Amount", "Total Days Hours Amount");           //11
                            //gridEmployee.Columns["Total Days Hours Amount"].ReadOnly = true;

                            gridEmployee.Columns.Add("Extra Duty Days", "Extra Duty Days");               //12
                            gridEmployee.Columns["Extra Duty Days"].ReadOnly = false;

                            gridEmployee.Columns.Add("Extra Duty Hours", "Extra Duty Hours");               //12
                            gridEmployee.Columns["Extra Duty Hours"].ReadOnly = false;

                            gridEmployee.Columns.Add("Extra Duty Minutes", "Extra Duty Minutes");               //12
                            gridEmployee.Columns["Extra Duty Minutes"].ReadOnly = false;

                            gridEmployee.Columns.Add("Extra Duty Amount", "Extra Duty Amount");                 //13
                            gridEmployee.Columns["Extra Duty Amount"].ReadOnly = true;

                            gridEmployee.Columns.Add("Payable Amount", "Payable Amount");                       //14
                            gridEmployee.Columns["Payable Amount"].ReadOnly = true;


                            gridEmployee.Columns.Add("Other Expences", "Other Expences");                         //15
                            gridEmployee.Columns["Other Expences"].ReadOnly = false;

                            gridEmployee.Columns.Add("Advance Salary", "Advance Salary");                    //16
                            gridEmployee.Columns["Advance Salary"].ReadOnly = false;


                            DataGridViewCheckBoxColumn gdvcbc = new DataGridViewCheckBoxColumn();
                            gdvcbc.Name = "5 % Salary Deduction";
                            gdvcbc.HeaderText = "5 % Salary Deduction";
                            gridEmployee.Columns.Add(gdvcbc);
                            gridEmployee.Columns["5 % Salary Deduction"].ReadOnly = false;



                            gridEmployee.Columns.Add("Salary Deduction", "Salary Deduction");           //18
                            gridEmployee.Columns["Salary Deduction"].ReadOnly = true;



                            DataGridViewCheckBoxColumn gdvcbc2 = new DataGridViewCheckBoxColumn();
                            gdvcbc2.Name = "Regular Allowance 2 Days";
                            gdvcbc2.HeaderText = "Regular Allowance 2 Days";
                            gridEmployee.Columns.Add(gdvcbc2);
                            gridEmployee.Columns["Regular Allowance 2 Days"].ReadOnly = false;


                            DataGridViewCheckBoxColumn gdvcbc25 = new DataGridViewCheckBoxColumn();
                            gdvcbc25.Name = "Regular Allowance 2 and Half";
                            gdvcbc25.HeaderText = "Regular Allowance 2 and Half";
                            gridEmployee.Columns.Add(gdvcbc25);
                            gridEmployee.Columns["Regular Allowance 2 and Half"].ReadOnly = false;


                            DataGridViewCheckBoxColumn gdvcbc3 = new DataGridViewCheckBoxColumn();
                            gdvcbc3.Name = "Regular Allowance 3 Days";
                            gdvcbc3.HeaderText = "Regular Allowance 3 Days";
                            gridEmployee.Columns.Add(gdvcbc3);
                            gridEmployee.Columns["Regular Allowance 3 Days"].ReadOnly = false;

                            gridEmployee.Columns.Add("Leave Salary", "Leave Salary");                         //15
                            gridEmployee.Columns["Leave Salary"].ReadOnly = true;

                            DataGridViewCheckBoxColumn gdvcbc4 = new DataGridViewCheckBoxColumn();
                            gdvcbc4.Name = "Include Leave Salary";
                            gdvcbc4.HeaderText = "Include Leave Salary";
                            gridEmployee.Columns.Add(gdvcbc4);
                            gridEmployee.Columns["Include Leave Salary"].ReadOnly = false;

                            gridEmployee.Columns.Add("Net Payable Amount", "Net Payable Amount");           //18
                            gridEmployee.Columns["Net Payable Amount"].ReadOnly = true;
                            gridEmployee.Columns["emp_id"].Visible = false;


                            gridEmployee.Columns.Add("Employee Id", "Employee Id");                       //14
                            gridEmployee.Columns["Employee Id"].Visible = false;
                            gridEmployee.Columns["Employee Id"].ReadOnly = false;
                            //gridEmployee.Columns.Add("Regular (Days)", "Regular (Days)");
                            //gridEmployee.Columns.Add("Regular Allownce", "Regular Allownce");
                            //gridEmployee.Columns.Add("Leave Salary", "Leave Salary");
                            //gridEmployee.Columns.Add("Other Liabilities", "Other Liabilities");
                            //gridEmployee.Columns.Add("Total Salary", "Total Salary");
                            //gridEmployee.Columns.Add("Leave Without Pay", "Leave Without Pay");
                            //gridEmployee.Columns.Add("Leave Without Pay Cut", "Leave Without Pay Cut");
                            //gridEmployee.Columns.Add("Salary 5%", "Salary 5%");
                            //gridEmployee.Columns.Add("Total Payment", "Total Payment");
                            PutZero();
                            FindDaysinMonth();
                            EmployeeAttendance();
                            PerDaySalary();
                            PerHourSalary();
                            TotalDaysAmount();
                            EmployeeSalary_Leave();
                            //    TotalHoursAmount();
                            //   TotalDays_HoursAmount();
                            ExtraHourAmount();
                            PayableAmount();
                            Payed_Loan();
                            Loan_Balance();
                            NetPayableAmount();
                            Total();
                            LeaveSalary();
                            loaddet = true;
                        }
                        else
                        {
                            // Do something  
                        }
                   
                    }
                     

                } 
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}
