using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms
{
    public partial class ucEmployeeAttendence : UserControl
    {
        private Guid Employee_ID = Guid.Empty;
        DataTable employData;
        string Date;
        string time;
        private const int PROBABILITY_ONE = 0x7fffffff;
        public ucEmployeeAttendence()
        {
            InitializeComponent();
            
            radDateTimePicker2.Value = DateTime.Now;
     


        }
     
        int count = 0;
        EmployAttendanceDAL objDal;//anceDAL();

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucEmployeeAttendence_Load(object sender, EventArgs e)
        {
            if (chkSystemDate.Checked == false)
            {
                pnlDate.Visible = true;
            }
            if (chkSystemTime.Checked == false)
            {
                pnlTime.Visible = true;
            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string datetime = "";
            try
            {
                Employee_ID = Guid.Empty;
                EmployAttendanceDAL objDal = new EmployAttendanceDAL();
                EmployeePersonalInfoDAL empDal = new EmployeePersonalInfoDAL();
                EmployeePersonalInfoBAL empBal = new EmployeePersonalInfoBAL();
                empBal.registration = textBox1.Text;

                DataTable dt1 = empDal.LoadByRegistration(empBal);
                Employee_ID = Guid.Parse(dt1.Rows[0]["employee_id"].ToString());
                employData = objDal.LoadEmployData(Employee_ID);


                EmployeAttendenceBAL objBal = new EmployeAttendenceBAL();
                objDal = new EmployAttendanceDAL();
                objBal.employid = Employee_ID;

       
                //for Date
                if (chkSystemDate.Checked == true)
                {
                    Date = DateTime.Now.ToString("M/d/yyyy");
                }
                else if(chkSystemDate.Checked == false)
                {
                    Date = radDateTimePicker2.Value.ToString("MM/dd/yyyy");
                }
                //for Time
                if (chkSystemTime.Checked == true)
                {
                    time = DateTime.Now.ToShortTimeString();
                }
                else if(chkSystemTime.Checked ==false)
                {
                    time = Convert.ToDateTime(radTimePicker1.Value).ToString("hh:mm:ss");
                }
                datetime = Date + " " + time;
                DateTime Current = Convert.ToDateTime(datetime);

                objBal.date = Current;

                if (rdbtn_TimeIn.Checked)
                    objBal.type = "Time-In";
                else if (rdbtn_TimeOut.Checked)
                    objBal.type = "Time-Out";
                else if (rdbtn_Overtime.Checked)
                    objBal.type = "Overtime";
                else if (rdbtn_TempIn.Checked)
                    objBal.type = "Temp-In";
                else if (rdbtn_TempOut.Checked)
                    objBal.type = "Temp-Out";
                else if (rdbtn_HalfLeave.Checked)
                    objBal.type = "Half-Leave";
                objBal.status = "Present";
                objDal.TimeIn(objBal);


                SendMessage(Action.UpdateEmployInfo, "");
            }
            catch (Exception ex)
            {
                // Send error message, then close form
                SendMessage(Action.SendMessage, "Error:  " + ex.Message + ex.Source + " " + ex.HelpLink + " " + datetime);
                SendMessage(Action.SetError, "");

            }
        }
        #region SendMessage
        private enum Action
        {
            SendBitmap,
            SendMessage,
            UpdateEmployInfo,
            SetError
        }
        private delegate void SendMessageCallback(Action action, object payload);
        private void SendMessage(Action action, object payload)
        {
            try
            {

                switch (action)
                {
                    case Action.SendMessage:
                        MessageBox.Show((string)payload);
                        break;
                    case Action.SendBitmap:
                        //    pbFingerprint.Image = (Bitmap)payload;
                        //    pbFingerprint.Refresh();
                        break;
                    case Action.UpdateEmployInfo:
                        lblError.Visible = false;
                        lblName.Text = employData.Rows[0]["Name"].ToString();
                        lblFather.Text = employData.Rows[0]["LastName"].ToString();
                        lblClass.Text = employData.Rows[0]["Designation"].ToString();
                        if (rdbtn_TimeIn.Checked)
                            lblTimeType.Text = "Time In:";
                        else
                            lblTimeType.Text = "Time Out:";
                        lblTimeIn.Text = DateTime.Now.TimeOfDay.ToString();

                        break;
                    case Action.SetError:
                        lblError.Visible = true;
                        lblName.Text = "";
                        lblFather.Text = "";
                        lblClass.Text = "";
                        lblTimeIn.Text = "";
                        break;
                }

            }
            catch (Exception)
            {
            }
        }
        #endregion
        private void radDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkSystemDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSystemDate.Checked == true)
            {

                radDateTimePicker2.Visible = false;
            }
            else
                radDateTimePicker2.Visible = true;

        }

        private void chkSystemTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSystemTime.Checked == true)
            {
                radTimePicker1.Visible = false;
            }
            else
                radTimePicker1.Visible = true;
        }
    }
}
