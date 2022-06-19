using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SicParvisMagna.Library;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;
using System.Data.SqlClient;
using System.IO;
namespace SicParvisMagna.Forms
{

    public partial class ucAddEmployee : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        private Guid CountryID = Guid.Empty;
        private Guid stateID = Guid.Empty;
        private Guid CityID = Guid.Empty;
        private Guid AreaID = Guid.Empty;
        private Guid EmployeeID = Guid.Empty;
        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid DepartmentID = Guid.Empty;
        private Guid OfficeID = Guid.Empty;
        private Guid SectionID = Guid.Empty;
        private Guid JobStatusID = Guid.Empty;
        private Guid CompanyID = Guid.Empty;
        private Guid AttendenceID = Guid.Empty;
        private Guid AccountID = Guid.Empty;
        private Guid EducationID = Guid.Empty;
        private Guid ExperienceID = Guid.Empty;
        private Guid AssID = Guid.Empty;
        private Guid ExpID = Guid.Empty;
        DataTable dt_AllExperties;
        DataTable dt_selectedExperties;
        string imgLoc = "";
        byte[] img = null;
        string imgLocExperience = "";
        byte[] imgExperience = null;
        private string appPath;
        private string filepath;
        private string picname;

        public ucAddEmployee()
        {
            InitializeComponent();
        }
        /*
      * *************************************
      * **********************************
      ****VALIDATION*****************
      * *****************************
      ***********************************/
        //-->UserPersonal
        private bool FormValidation()
        {


            bool validated = true;
            //First Name
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                lblErrorFirstName.Text += "FirstName is required!";
                validated = false;
            }
            else
            {
                lblErrorFirstName.Text = "";
            }

            if (!Validation.isAlpha(txtFirstName.Text, 25))
            {
                if (string.IsNullOrEmpty(txtFirstName.Text))
                    lblErrorFirstName.Text += "\n";
                lblErrorFirstName.Text += "FirstName Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorFirstName.Text = "";
            }
            //====================================================

            //Last Name
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                lblErrorLastName.Text += "LastName is required!";
                validated = false;
            }
            else
            {
                lblErrorLastName.Text = "";
            }

            if (!Validation.isAlpha(txtLastName.Text, 25))
            {
                if (string.IsNullOrEmpty(txtLastName.Text))
                    lblErrorLastName.Text += "\n";
                lblErrorLastName.Text += "LastName Should be in  Alphabets";
                validated = false;
            }
            else
            {
                lblErrorLastName.Text = "";
            }
            //====================================================




            
            //for Cnic
            if (string.IsNullOrEmpty(txtCnic.Text))
            {
                lblErrorCnic.Text += "Cnic is required!";
                validated = false;
            }
            else
            {
                lblErrorCnic.Text = "";
            }

            if (!Validation.isCnic(txtCnic.Text))
            {
                if (string.IsNullOrEmpty(txtCnic.Text))
                    lblErrorCnic.Text += "\n";
                lblErrorCnic.Text += "Cnic  Should be numeric!";
                validated = false;
            }
            else
            {
                lblErrorCnic.Text = "";
            }
            //====================================================

            //for Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {

                lblErrorEmail.Text += "Email is required!";
                validated = false;
            }
            else
            {
                lblErrorEmail.Text = "";
            }

            if (!Validation.isEmail(txtEmail.Text))
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                    lblErrorEmail.Text += "\n";
                lblErrorEmail.Text += "abc@gmail.com ";
                validated = false;
            }
            else
            {
                lblErrorEmail.Text = "";
            }
            //====================================================
            
            //====================================================

            //for Phone Number
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                lblErrorPhone.Text += "Phone no. is required!";
                validated = false;
            }
            else
            {
                lblErrorPhone.Text = "";
            }

            if (!Validation.isPhoneNumber(txtPhone.Text))
            {
                if (string.IsNullOrEmpty(txtPhone.Text))
                    lblErrorPhone.Text += "\n";
                lblErrorPhone.Text += "03XXXXXXXXX ";
                validated = false;
            }
            else
            {
                lblErrorPhone.Text = "";
            }
            //====================================================

            //for Adress
            if (string.IsNullOrEmpty(txtAdress1.Text))
            {

                lblErrorAdress1.Text += "Adress is required!";
                validated = false;
            }
            else
            {
                lblErrorAdress1.Text = "";
            }

            if (!Validation.isAdress(txtAdress1.Text))
            {
                if (string.IsNullOrEmpty(txtAdress1.Text))
                    lblErrorAdress1.Text += "\n";
                lblErrorAdress1.Text += "Special Chracters are not Allowed";
                validated = false;
            }
            else
            {
                lblErrorAdress1.Text = "";
            }
            //
            if (string.IsNullOrEmpty(txtAdress2.Text))
            {

                lblErrorAdress1.Text += "Adress is required!";
                validated = false;
            }
            else
            {
                lblErrorAdress1.Text = "";
            }

            if (!Validation.isAdress(txtAdress2.Text))
            {
                if (string.IsNullOrEmpty(txtAdress2.Text))
                    lblErrorAdress1.Text += "\n";
                lblErrorAdress1.Text += "Special Chracters are not Allowed";
                validated = false;
            }
            else
            {
                lblErrorAdress1.Text = "";
            }
            //====================================================



            return validated;

        }
        /******************************************************************************8
         * *******************************************************************************
         * *******************************************************************************/
        // UserEducation
        private bool formUserEducationValidation()
        {
            bool validated = true;


            //For Degree
            if (string.IsNullOrEmpty(txtDegree.Text))
            {
                lblErrorDegree.Text += "Degree Title  is required!";
                validated = false;
            }
            else
            {
                lblErrorDegree.Text = "";
            }

            if (!Validation.isAlpha(txtDegree.Text, 10))
            {
                if (string.IsNullOrEmpty(txtDegree.Text))
                    lblErrorDegree.Text += "\n";
                lblErrorDegree.Text += "Degree Name Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorDegree.Text = "";
            }
            //====================================================

            //For Board
            if (string.IsNullOrEmpty(txtBoard.Text))
            {
                lblErrorBoard.Text += "Board name   is required!";
                validated = false;
            }
            else
            {
                lblErrorBoard.Text = "";
            }

            if (!Validation.isBoard(txtBoard.Text, 10))
            {
                if (string.IsNullOrEmpty(txtBoard.Text))
                    lblErrorBoard.Text += "\n";
                lblErrorBoard.Text += "Board Name Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorBoard.Text = "";
            }
            //====================================================

            //For Obtain Marks
            if (string.IsNullOrEmpty(txtOBT.Text))
            {
                lblErrorObtain.Text += "Obtain Marks Required   is required!";
                validated = false;
            }
            else
            {
                lblErrorObtain.Text = "";
            }

            if (!Validation.isNumber(txtOBT.Text))
            {
                if (string.IsNullOrEmpty(txtOBT.Text))
                    lblErrorObtain.Text += "\n";
                lblErrorObtain.Text += "Obtain Marks Should be Numeric";
                validated = false;
            }
            else
            {
                lblErrorObtain.Text = "";
            }
            //====================================================
            //For Total Marks
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                lblErrorTotal.Text += "Total  Marks Required   is required!";
                validated = false;
            }
            else
            {
                lblErrorTotal.Text = "";
            }

            if (!Validation.isNumber(txtOBT.Text))
            {
                if (string.IsNullOrEmpty(txtTotal.Text))
                    lblErrorTotal.Text += "\n";
                lblErrorTotal.Text += "total Marks Should be Numeric";
                validated = false;
            }
            else
            {
                lblErrorTotal.Text = "";
            }
            //===================================================

            return validated;
        }
        /*******************************************************************************
         * ******************************************************************************
         * **********************************************************/
        //User Experience
        private bool FormUserExperienceValidation()
        {
            bool validated = true;


            //For jobTitle
            if (string.IsNullOrEmpty(txtJobTitle.Text))
            {
                lblErrorJobTitle.Text += "Title is required!";
                validated = false;
            }
            else
            {
                lblErrorJobTitle.Text = "";
            }

            if (!Validation.isAlpha(txtJobTitle.Text, 20))
            {
                if (string.IsNullOrEmpty(txtJobTitle.Text))
                    lblErrorJobTitle.Text += "\n";
                lblErrorJobTitle.Text += "Divison Name Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorJobTitle.Text = "";
            }
            //====================================================
            //For Company Name
            if (string.IsNullOrEmpty(txtComapnyName.Text))
            {
                lblErrorCompanyName.Text += "Title is required!";
                validated = false;
            }
            else
            {
                lblErrorCompanyName.Text = "";
            }

            if (!Validation.isAlpha(txtComapnyName.Text, 15))
            {
                if (string.IsNullOrEmpty(txtComapnyName.Text))
                    lblErrorCompanyName.Text += "\n";
                lblErrorCompanyName.Text += "Special Chracters not allowed must Alphabets";
                validated = false;
            }
            else
            {
                lblErrorCompanyName.Text = "";
            }
            //====================================================
            //For Start Designation
            if (string.IsNullOrEmpty(txtStartDesignation.Text))
            {
                lblErrorStartDesignation.Text += "Start Designation is required!";
                validated = false;
            }
            else
            {
                lblErrorStartDesignation.Text = "";
            }

            if (!Validation.isAlpha(txtStartDesignation.Text, 10))
            {
                if (string.IsNullOrEmpty(txtStartDesignation.Text))
                    lblErrorStartDesignation.Text += "\n";
                lblErrorStartDesignation.Text += "Designation Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorStartDesignation.Text = "";
            }
            //=================================================
            //For End Designation
            if (string.IsNullOrEmpty(txtEndDesignation.Text))
            {
                lblErrorEndDesignation.Text += "End Designation is required!";
                validated = false;
            }
            else
            {
                lblErrorEndDesignation.Text = "";
            }

            if (!Validation.isAlpha(txtEndDesignation.Text, 10))
            {
                if (string.IsNullOrEmpty(txtEndDesignation.Text))
                    lblErrorEndDesignation.Text += "\n";
                lblErrorEndDesignation.Text += "Designation Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorEndDesignation.Text = "";
            }
            //=================================================
            return validated;
        }


        private void searchEmployeePersonal()
        {
            if (EmployeeID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM  Employee_PersonalInfo ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtFirstName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE firstname like '%" + txtFirstName.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtLastName.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE lastname like '%" + txtLastName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND lastname like '%" + txtLastName.Text + "%'";
                }

                 if (!string.IsNullOrEmpty(txtCnic.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Cnic like '%" + txtCnic.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Cnic like '%" + txtCnic.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Email like '%" + txtEmail.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Email like '%" + txtEmail.Text + "%'";
                }


                if (!string.IsNullOrEmpty(txtPhone.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Phone like '%" + txtPhone.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Phone  like '%" + txtPhone.Text + "%'";
                }
               
                if (!string.IsNullOrEmpty(cmbCountry.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE country_id like '%" + cmbCountry.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND country_id like '%" + cmbCountry.Text + "%'";
                }
                if (!string.IsNullOrEmpty(cmbState.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE state_id like '%" + cmbState.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND state_id like '%" + cmbState.Text + "%'";
                }
                if (!string.IsNullOrEmpty(cmbCity.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE city_id like '%" + cmbCity.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND city_id like '%" + cmbCity.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtAdress1.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Adress1 like '%" + txtAdress1.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Adress1  like '%" + txtAdress1.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtAdress2.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Adress2 like '%" + txtAdress1.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Adress2  like '%" + txtAdress1.Text + "%'";
                }

                if (EmployeeID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE employee_id  = " + EmployeeID;
                        whereAdded = true;
                    }
                    else
                        query += "   AND employee_id  = " + EmployeeID;
                }

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                GridEmployee.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //========================================
        //User Experience
        private bool CompanyInfoValidation()
        {
            bool validated = true;


            
            if (string.IsNullOrEmpty(txtDesignation.Text))
            {
                lblErrorDesignation.Text += " Designation Required...";
                validated = false;
            }
            else
            {
                lblErrorDesignation.Text = "";
            }

            if (!Validation.isAlpha(txtDesignation.Text, 15))
            {
                if (string.IsNullOrEmpty(txtComapnyName.Text))
                    lblErrorDesignation.Text += "\n";
                lblErrorDesignation.Text += "Special Chracters not allowed must Alphabets";
                validated = false;
            }
            else
            {
                lblErrorCompanyName.Text = "";
            }
            //====================================================
            //For Start Designation
            if (string.IsNullOrEmpty(txtSalary.Text))
            {
                lblErrorSalary.Text += " Salary Required!!";
                validated = false;
            }
            else
            {
                lblErrorSalary.Text = "";
            }

            if (!Validation.isNumber(txtSalary.Text))
            {
                if (string.IsNullOrEmpty(txtSalary.Text))
                    lblErrorSalary.Text += "\n";
                lblErrorSalary.Text += "Designation Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorStartDesignation.Text = "";
            }
            //=================================================
            //For End Designation
            if (string.IsNullOrEmpty(txtScale.Text))
            {
                lblErrorScale.Text += "Scale required!";
                validated = false;
            }
            else
            {
                lblErrorScale.Text = "";
            }

        
            //=================================================
            return validated;
        }

        //=========================================
        //User Education
        private void searchUserEducation()
        {
            if (EducationID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                string query = @"SELECT * FROM dbo.User_Education ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtDegree.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE Specilization LIKE '%" + txtDegree.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                //query = "SELECT * FROM dbo.User_Education ";
                if (!string.IsNullOrEmpty(txtBoard.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Board like '%" + txtBoard.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Board like '%" + txtBoard.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtOBT.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE OBT_CGPA like '%" + txtOBT.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND OBT_CGPA like '%" + txtOBT.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtTotal.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Totalmarks_Cgpa like '%" + txtTotal.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Totalmarks_Cgpa '%" + txtTotal.Text + "%'";
                }
                if (EducationID != null)
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Education_id = " + EducationID;
                        whereAdded = true;
                    }
                    else
                        query += "   AND Education_id  = " + EducationID;
                }

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                gridUserEducation.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Employee Attendence
        private void searchEmployeeAttendence()
        {
            if (AttendenceID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                string query = @" select  * from Employee_PersonalInfo";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtReg.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE  registration LIKE '%" + txtReg.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                //query = "SELECT * FROM dbo.User_Education ";
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE firstname like '%" + txtName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND firstname like '%" + txtName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(cmbOrg.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Organization_id  =   '" + cmbOrg.SelectedValue + "'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Organization_id  =  '" + cmbOrg.SelectedValue +  "'";
                }

                //
                if (!string.IsNullOrEmpty(cmbOrgBranch.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Branch_id like  = '" + cmbOrgBranch.SelectedValue + " '";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Branch_id  = ' " + cmbOrgBranch.SelectedValue + " '";
                }

                //
                if (!string.IsNullOrEmpty(cmbDept.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE dept_id  =  '" + cmbDept.SelectedValue + "'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND dept_id  = '" + cmbDept.SelectedValue + "'";
                }
                //
                if (!string.IsNullOrEmpty(cmbDeptOfficce.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE office_id  =  '" + cmbDeptOfficce.SelectedValue + "'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND office_id  = '" + cmbDeptOfficce.SelectedValue + "'";
                }
                //
                if (!string.IsNullOrEmpty(cmbOfficeSection.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE section_id  =  '" + cmbOfficeSection.SelectedValue + "'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND section_id   =  '" + cmbOfficeSection.SelectedValue + "'";
                }
                if (  EmployeeID!=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE  employee_id = '" + EmployeeID+"'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND employee_id   =  '" + EmployeeID+"'";
                }

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                cmbEmp.DataSource = dt;
                cmbEmp.DisplayMember = "firstname";
                cmbEmp.ValueMember = "Employee_id";
                cmbEmployee.DataSource = dt;
                cmbEmployee.DisplayMember = "firstname";
                cmbEmployee.ValueMember = "Employee_id";
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //User Experience
        private void searchUserExperience()
        {
            if (ExperienceID != null)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM User_Experience ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtJobTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE Job_title like '%" + txtJobTitle.Text + "%'";

                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtComapnyName.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Company_name like '%" + txtComapnyName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Company_name like '%" + txtComapnyName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtStartDesignation.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Start_designation like '%" + txtStartDesignation.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Start_designation like '%" + txtStartDesignation.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtEndDesignation.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE End_designation like '%" + txtEndDesignation.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND End_designation like '%" + txtEndDesignation.Text + "%'";
                }

                if (ExperienceID != null)
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Experience_id  = " + ExperienceID;
                        whereAdded = true;
                    }
                    else
                        query += "   AND Experience_id  = " + ExperienceID;
                }

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                gridUserExperience.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //User Education
        private void searchCompanyInfo()
        {
            if (EmployeeID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                string query = @"SELECT * FROM Employee_CompanyInfoUpdate ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtDesignation.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE designation LIKE '%" + txtDesignation.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                //query = "SELECT * FROM dbo.User_Education ";
                if (!string.IsNullOrEmpty(txtSalary.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE salary like '%" + txtSalary.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND salary like '%" + txtSalary.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtScale.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE scale like '%" + txtScale.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND scale like '%" + txtScale.Text + "%'";
                }
                
                if (EmployeeID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE  employee_id  = " + EmployeeID;
                        whereAdded = true;
                    }
                    else
                        query += "   AND employee_id  = " + EmployeeID;
                }

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                gridUserEducation.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void saveEmployeePersonal()
        {
            EmployeePersonalInfoBAL objBAL = new EmployeePersonalInfoBAL();

            if (FormValidation())
            {
                objBAL.firstname = txtFirstName.Text;
                objBAL.lastname = txtLastName.Text;
               objBAL.CNIC = txtCnic.Text;
                objBAL.email = txtEmail.Text;
                objBAL.registration = txtRegNo.Text;
                 objBAL.phone = txtPhone.Text;
                objBAL.dob = DateTime.Parse(dtpDOB.Text);
                 objBAL.country_id = CountryID;
                objBAL.city_id = CityID;
                objBAL.state_id = stateID;
                objBAL.area_id = AreaID;
                objBAL.Organization_id = OrganizationID;
                objBAL.Branch_id = BranchID;
                objBAL.dept_id = DepartmentID;
                objBAL.office_id = OfficeID;
                objBAL.section_id = SectionID;
                objBAL.attendance_type = cmbAttendence.Text;
                objBAL.address_type = cmbAdressType.Text;
                objBAL.address1 = txtAdress1.Text;
                objBAL.address2 = txtAdress2.Text;
                objBAL.ntn_Number = txtNTN.Text;
                //
                EmployeePersonalInfoDAL objDAL = new EmployeePersonalInfoDAL();


                if (EmployeeID != Guid.Empty)
                {
                    try
                    {
                        string newpic = (picname) + Guid.NewGuid() + (".jpg");
                        objBAL.profile_PicPath = newpic;
                        File.Copy(filepath, appPath + newpic);
                        File.Delete(appPath + (picname));

                        objBAL.employee_id = EmployeeID;
                         objDAL.Update(objBAL);

                    }
                    catch(Exception ee)
                    {
                        objBAL.employee_id = EmployeeID;


                        objDAL.Update(objBAL);
                    }

                }
                else
                {
                    try
                    {

                        objBAL.profile_PicPath = txtFirstName.Text + picname + (".jpg");
                        File.Copy(filepath, appPath + (picname) + (".jpg"));
                        objDAL.Add(objBAL);
                    }
                    catch
                    {
                        objDAL.Add(objBAL);
                    }
                }

                clearEmployeePersonal();
                loadEmployee();
            }
        }
        //User Education
        private void saveUserEducation()
        {
            //Code for image
            try
            {
                if (formUserEducationValidation())
                {
                    try
                    {
                        FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                    }
                    catch { }

                    UserEducationBAL obj = new UserEducationBAL();
                    if (img != null)
                        obj.Image = img;
                    else
                        obj.Image = img = new byte[20];
                    obj.User_id = EmployeeID;
                    obj.Board = txtBoard.Text;
                    obj.Specilization = txtDegree.Text;
                    obj.OBT_CGPA = txtOBT.Text;
                    obj.Totalmarks_Cgpa = txtTotal.Text;
                    float ans = (float.Parse(txtOBT.Text) / float.Parse(txtTotal.Text)) * 100;
                    obj.Percentage = ans.ToString() + "%";
                    UserEducationDAL objDAL = new UserEducationDAL();
                    if (EducationID != Guid.Empty)
                    {

                        obj.Education_id = EducationID;
                        obj.Timestamp = DateTime.Now;
                        obj.Add_by = "Admin";
                        obj.Status = "Active";
                        obj.Flag = 1;
                        objDAL.Update(obj);

                    }
                    else
                    {
                        obj.Timestamp = DateTime.Now;
                        obj.Add_by = "Admin";
                        obj.Status = "Active";
                        obj.Flag = 1;
                        objDAL.Add(obj);
                    }

                    clearAllEducation();
                    loadUserEducation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //

        //User Experience
        private void saveUserExperience()
        {
            //code for Image
            try
            {

                FileStream fs = new FileStream(imgLocExperience, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imgExperience = br.ReadBytes((int)fs.Length);



            }
            catch
            {

            }
            if (FormUserExperienceValidation())
            {
                //
                UserExperienceBAL obj = new UserExperienceBAL();
                obj.User_id = EmployeeID;
                if (imgExperience != null)
                    obj.Image = imgExperience;
                else
                    obj.Image = imgExperience = new byte[20];
                //
                obj.Job_title = txtJobTitle.Text;
                obj.Company_name = txtComapnyName.Text;
                obj.Start_designation = txtStartDesignation.Text;
                obj.End_designation = txtEndDesignation.Text;
                obj.Start_date = DateTime.Parse(dtpStartDate.Text);
                obj.End_date = DateTime.Parse(dtpEndDate.Text);
                obj.Resign = txtReason.Text;
                obj.Timestamp = DateTime.Now;
                obj.Add_by = "Admin";
                obj.status = "Active";
                obj.Flag = 1;
                UserExperienceDAL objDAL = new UserExperienceDAL();
                if (ExperienceID != Guid.Empty)
                {
                    objDAL.Update(obj);
                }
                else
                {
                    objDAL.Add(obj);
                }
                clearUserExperience();
                loadUserExperience();

            }
        }

        //User Experience
        private void saveCompanyInfo()
        {
            if (CompanyInfoValidation())
            {
                //
                EmployeeCompanyInfoBAL obj = new EmployeeCompanyInfoBAL();
                obj.employee_id = EmployeeID;

                obj.date_of_join = DateTime.Parse(dtpDateofJoin.Text);
                obj.designation = txtDesignation.Text;
                obj.jobstatus_id = JobStatusID;
                obj.leavedate = DateTime.Parse(dtpLeaveDate.Text);
                obj.salary = txtSalary.Text;
                obj.scale = txtScale.Text;

                EmployeeCompanyIndoDAL objDAL = new EmployeeCompanyIndoDAL();
                if (CompanyID != Guid.Empty)
                {
                    objDAL.Update(obj);
                    Salary(EmployeeID, "U");
                }
                else
                {
                    objDAL.Add(obj);
                    Salary(objDAL.getid(), "I");
                }


                clearCompanyInfo();
                loadCompanyInfo();
            }
        }

        //Employee Attendence//
        private void saveEmployeeAttendence() {
       
         
                EmployeeAttendenceBAL obj = new EmployeeAttendenceBAL();
            EmployeeID = Guid.Parse(cmbEmp.SelectedValue.ToString());
            obj.Employee_id = EmployeeID;
                obj.time_in = Convert.ToDateTime(dtpTimeIn.Text);
                obj.time_out = Convert.ToDateTime(dtpTimeOut.Text);
                obj.break_start = Convert.ToDateTime(dtpBreakStart.Text);
                obj.break_end = Convert.ToDateTime(dtpBreakEnd.Text);
                obj.grace_time = Convert.ToDateTime(dtpGraceTime.Text);
                obj.short_leave = Convert.ToDateTime(dtpShortLeave.Text);
                obj.absent_after = Convert.ToDateTime(dtpAbsentAfter.Text);
            EmployeeAttendenceDAL objDAL = new EmployeeAttendenceDAL();
            if (AttendenceID != Guid.Empty)
            {
                obj.Editby = "Toqeer";
                obj.EditDate = DateTime.Now;
                objDAL.Update(obj);
            }
            else
            {
                obj.Addby = "Admin";
                obj.AddDate = DateTime.Now;
                objDAL.Add(obj);
            }


            clearEmployeeAttendence();
            loadAttendence();

        }
         //==============
        //User Experties
        private void saveUserExperties()
        {
            AssignExpertiesBAL obj;
            AssignExpertiesDAL objDal = new AssignExpertiesDAL();
            for (int i = 0; i < gridSelected.Rows.Count; i++)
            {

                obj = new AssignExpertiesBAL();

                obj.ExpertiesId = Guid.Parse(gridSelected.Rows[i].Cells["Account_id"].Value.ToString());
                obj.UserId = EmployeeID;
                obj.Timestamp = DateTime.Now;
                obj.Addby = "Admin";
                obj.Status = "Active";
                obj.Flag = 1;


                objDal.Add(obj);
                loadExperties();
            }
        }

        //Clear Function----------------------------------------------------------------------->
        private void clearEmployeePersonal()
        {
            txtNTN.Text = "";
            ProfilePicBox.Image = null;
            EmployeeID = Guid.Empty;
            txtAdress1.Text = "";
            txtAdress2.Text = "";
            txtBoard.Text = "";
            txtCnic.Text = "";
            txtEmail.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtRegNo.Text = "";
            cmbAdressType.SelectedIndex = -1;
            cmbAttendence.SelectedIndex = -1;
            cmbAdressType.SelectedIndex = -1;
            cmbCountry.SelectedIndex = -1;
            cmbState.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            cmbArea.SelectedIndex = -1;
            cmbOrganization.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbOffice.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            cmbEmployee.SelectedIndex = -1;
            txtPhone.Clear();
            lblErrorCnic.Text = "";
            lblErrorEmail.Text = "";
            lblErrorFirstName.Text = "";
            lblErrorPhone.Text = "";
            lblErrorAdress1.Text = "";
            lblErrorLastName.Text = "";
            btnSave.LabelText = "Save";
            txtNTN.Text = "";
            ProfilePicBox.Image = null;
            
        }
        private void clearCompanyInfo()
        {
            txtDesignation.Clear();
            txtSalary.Clear();
            txtScale.Clear();
            cmbJobStatus.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            gridCompanyInfo.DataSource = null;
            btnSave.LabelText = "Save";
            gridCompanyInfo.Rows.Clear();
            lblErrorScale.Text = "";
            lblErrorSalary.Text = "";
            lblErrorDesignation.Text= "";

        }

        private void clearEmployeeAttendence()
        {
            txtReg.Clear();
            txtName.Clear();
            cmbOrg.SelectedIndex = -1;
            cmbOrgBranch.SelectedIndex = -1;
            cmbDept.SelectedIndex = -1;
            cmbDeptOfficce.SelectedIndex = -1;
            cmbOfficeSection.SelectedIndex = -1;

            cmbEmployee.SelectedIndex = -1;
            dtpAbsentAfter.Value = DateTime.Now;
            dtpBreakEnd.Value = DateTime.Now;
            dtpBreakStart.Value = DateTime.Now;
            dtpGraceTime.Value = DateTime.Now;
            dtpShortLeave.Value = DateTime.Now;
            dtpTimeIn.Value = DateTime.Now;
            dtpTimeOut.Value = DateTime.Now;
            gridAttendence.DataSource = null;
            gridAttendence.Rows.Clear();
            btnSave.LabelText = "Save";


        }
        public void clearAllEducation()
        {
            btnSave.LabelText = "Save";


            txtBoard.Clear();
            txtDegree.Clear();
            txtOBT.Clear();
            txtTotal.Clear();
            btnSave.Text = "Save";
            if (DegreePicBox.Image != null)
            {
                DegreePicBox.Image.Dispose();
                DegreePicBox.Image = null;
            }
            lblErrorBoard.Text = "";
            lblErrorDegree.Text = "";
            lblErrorObtain.Text = "";
            lblErrorTotal.Text = "";

            loadUserEducation();
            gridUserEducation.DataSource = null;
            gridUserEducation.Rows.Clear();
        }
        //
        public void clearUserExperience()
        {
            btnSave.LabelText = "Save";

            txtJobTitle.Clear();
            txtStartDesignation.Clear();
            txtEndDesignation.Clear();
            txtComapnyName.Clear();
            txtReason.Clear();
            dtpEndDate.Text = "";
            dtpStartDate.Text = "";
            btnSave.Text = "Save";
            if (experiencePicbox.Image != null)
            {
                experiencePicbox.Image.Dispose();
                experiencePicbox.Image = null;
            }

            lblErrorCompanyName.Text = "";
            lblErrorJobTitle.Text = "";
            lblErrorStartDesignation.Text = "";
            lblErrorEndDesignation.Text = "";

            loadUserExperience();
            
            gridUserExperience.DataSource = null;
        }
        /*  *#############################################################################
           * ################################################################################
           * ###############################DELETE FUNCTION##################################*/
        private void deleteEmployeePersonal()
        {

            if (EmployeeID != Guid.Empty)
            {
                EmployeePersonalInfoBAL objBAL = new EmployeePersonalInfoBAL();
                EmployeePersonalInfoDAL objDAL = new EmployeePersonalInfoDAL();
                //

                objBAL.employee_id = EmployeeID;


                objDAL.Delete(objBAL);
                clearEmployeePersonal();
                loadEmployee();
            }
            else
            {
                MessageBox.Show("No Employee selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteUserEducation()
        {
            if (EducationID != Guid.Empty)
            {
                UserEducationBAL objBAL = new UserEducationBAL();
                UserEducationDAL objDAL = new UserEducationDAL();
                objBAL.Education_id = EducationID;
                objDAL.Delete(objBAL);
                clearAllEducation();
                loadUserEducation();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteUserExperience()
        {
            if (ExperienceID != Guid.Empty)
            {
                UserExperienceBAL objBAL = new UserExperienceBAL();
                UserExperienceDAL objDAL = new UserExperienceDAL();
                objBAL.Experience_id = ExperienceID;
                objDAL.Delete(objBAL);
                clearUserExperience();
                loadUserExperience();
            }
            else
            {
                MessageBox.Show("No user selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //employee Attendence
        private void deleteEmployeeAttendence()
        {
            if (AttendenceID != Guid.Empty)
            {
                EmployeeAttendenceBAL objBAL = new EmployeeAttendenceBAL();
                EmployeeAttendenceDAL objDAL = new EmployeeAttendenceDAL();
                objBAL.Attendence_id = AttendenceID;
             
                objDAL.Delete(objBAL);
                clearEmployeeAttendence();
                loadAttendence();
              
            }
            else
            {
                MessageBox.Show("No Employee selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCompanuInfo()
        {
            if (EmployeeID != Guid.Empty)
            {
                EmployeeCompanyInfoBAL objBAL = new EmployeeCompanyInfoBAL();
                EmployeeCompanyIndoDAL objDAL = new EmployeeCompanyIndoDAL();
                objBAL.employee_id = EmployeeID;
                objDAL.Delete(objBAL);
                clearUserExperience();
                loadUserExperience();
            }
            else
            {
                MessageBox.Show("No user selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        ///$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        ///$$$$$$$$$$$$$$$  LOAD   FUNCTION$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        //Load functions
        private void loadEmployee()
        {
            EmployeePersonalInfoDAL objDAL = new EmployeePersonalInfoDAL();
            GridEmployee.DataSource = objDAL.LoadAll();
            //GridEmployee.Columns["User_id"].Visible = false;
            GridEmployee.Columns["country_id"].Visible = false;
            GridEmployee.Columns["state_id"].Visible = false;
            GridEmployee.Columns["city_id"].Visible = false;
            GridEmployee.Columns["Area_id"].Visible = false;
            GridEmployee.Columns["Organization_id"].Visible = false;
            GridEmployee.Columns["Branch_id"].Visible = false;
            GridEmployee.Columns["Employee_id"].Visible = false;
            GridEmployee.Columns["dept_id"].Visible = false;
            GridEmployee.Columns["section_id"].Visible = false;
            GridEmployee.Columns["office_id"].Visible = false;
            //GridEmployee.Columns["Flag"].Visible = false;
            //GridEmployee.Columns["Add_by"].Visible = false;
           //GridEmployee.Columns["TimeStamp"].Visible = false;
            //GridEmployee.Columns["Editby"].Visible = false;
            //GridEmployee.Columns["EditDate"].Visible = false;
            //GridEmployee.Columns["FirstTimeLogin"].Visible = false;
            //GridEmployee.Columns["Status"].Visible = false;
        }
        private void loadCompanyInfo()
        {
            EmployeeCompanyIndoDAL objDAL = new EmployeeCompanyIndoDAL();
            EmployeeCompanyInfoBAL obj = new EmployeeCompanyInfoBAL();
            obj.employee_id = EmployeeID;
            gridCompanyInfo.DataSource = objDAL.LoadAll(obj);
            gridCompanyInfo.Columns["employeeCompany_id"].Visible = false;
            gridCompanyInfo.Columns["jobstatus_id"].Visible = false;
            gridCompanyInfo.Columns["employee_id"].Visible = false;
     
        }
        private void loadAttendence()
        {
            EmployeeAttendenceBAL obj = new EmployeeAttendenceBAL();
            EmployeeAttendenceDAL objDAL = new EmployeeAttendenceDAL();
            obj.Employee_id = EmployeeID;
            gridAttendence.DataSource =  objDAL.LoadAll(obj);
            gridAttendence.Columns["attendence_id"].Visible = false;
            gridAttendence.Columns["Employee_id"].Visible = false;
            gridAttendence.Columns["add_by"].Visible = false;
            gridAttendence.Columns["add_date"].Visible = false;
            gridAttendence.Columns["edit_by"].Visible = false;
            gridAttendence.Columns["edit_date"].Visible = false;

        }
        private void loadUserId()
        {
            EmployeePersonalInfoDAL objDAL = new EmployeePersonalInfoDAL();

            cmbEmployee.DataSource = objDAL.LoadAll();
             cmbEmployee.ValueMember = "employee_id";
            cmbEmployee.DisplayMember = "firstname";
            cmbEmployee.SelectedIndex = -1;
            //===
            cmbEmp.DataSource = objDAL.LoadAll();
            cmbEmp.ValueMember = "employee_id";
            cmbEmp.DisplayMember = "firstname";
            cmbEmp.SelectedIndex = -1;
        }


        private void loadEmpoyeeByGrid()
        {
            EmployeePersonalInfoDAL objDAL = new EmployeePersonalInfoDAL();

            EmployeePersonalInfoBAL obj = new EmployeePersonalInfoBAL();

            obj.employee_id = EmployeeID;
            GridEmployee.DataSource = objDAL.LoadbyID(obj);
 
        }
        private void loadCbxCountries()
        {
            CountryDAL objDAL = new CountryDAL();
            cmbCountry.DataSource = objDAL.LoadAll();
            cmbCountry.ValueMember = "country_id";
            cmbCountry.DisplayMember = "name";
            cmbCountry.SelectedIndex = -1;
        }

        private void loadCbxStates()
        {
            StateDAL objDAL = new StateDAL();
            StateBAL obj = new StateBAL();
            obj.Country_id = CountryID;
            cmbState.DataSource = objDAL.LoadAll(obj);
            cmbState.ValueMember = "state_id";
            cmbState.DisplayMember = "name";
            cmbState.SelectedIndex = -1;
        }


        private void loadCbxCities()
        {

            CityDAL objDAL = new CityDAL();
            CityBAL obj = new CityBAL();
            obj.State_id = stateID;//       Guid.Parse(Convert.ToString(cmbState.SelectedValue));
            cmbCity.DataSource = objDAL.LoadByState(obj);
            cmbCity.ValueMember = "city_id";
            cmbCity.DisplayMember = "name";
            cmbCity.SelectedIndex = -1;
        }
        private void loadCbxArea()
        {

            AreaDAL objDAL = new AreaDAL();
            AreaBAL obj = new AreaBAL();
            obj.City_id = CityID;//       Guid.Parse(Convert.ToString(cmbState.SelectedValue));
            cmbArea.DataSource = objDAL.LoadByCity(obj);
            cmbArea.ValueMember = "area_id";
            cmbArea.DisplayMember = "name";
            cmbArea.SelectedIndex = -1;
        }
      
            private void loadCmbBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();

            obj.Parent_id = OrganizationID;//   Guid.Parse(cmbOrganization.SelectedValue.ToString());

            cmbBranch.DataSource = objDAL.LoadBranch(obj);
            cmbBranch.ValueMember = "Organization_id";
            cmbBranch.DisplayMember = "Title";
            cmbBranch.SelectedIndex = -1;

          
        }

      
            private void loadCbxOrganization()
        {
            OrganizationBAL objBAL = new OrganizationBAL();
            OrganizationDAL objDAL = new OrganizationDAL();

            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;

          
        }
        
        private void loadCbxDepartment()
        {
           Department_BAL objBAL = new Department_BAL();
            Department_DAL objDAL = new Department_DAL();
            objBAL.branch_id = BranchID;
            cmbDepartment.DataSource = objDAL.LoadAll(objBAL);
            cmbDepartment.ValueMember = "dept_id";
            cmbDepartment.DisplayMember = "name";
            cmbDepartment.SelectedIndex = -1;

       
        }
         

        private void loadCbxOffice()
        {
            Office_BAL objBAL = new Office_BAL();
            Office_DAL objDAL = new Office_DAL();
            objBAL.dept_id = DepartmentID;
            cmbOffice.DataSource = objDAL.LoadAll(objBAL);
            cmbOffice.ValueMember = "office_id";
            cmbOffice.DisplayMember = "name";
            cmbOffice.SelectedIndex = -1;
        }
        //===
        private void loadCbxOfficeSection()
        {
            SectionBAL objBAL = new SectionBAL();
            SectionDAL objDAL = new SectionDAL();
            objBAL.Office_id = OfficeID;
            cmbOfficeSection.DataSource = objDAL.LoadAll(objBAL);
            cmbOfficeSection.ValueMember = "section_id";
            cmbOfficeSection.DisplayMember = "name";
            cmbOfficeSection.SelectedIndex = -1;
        }
            private void loadCbxSection()
        {
            SectionBAL objBAL = new SectionBAL();
            SectionDAL objDAL = new SectionDAL();
            objBAL.Office_id = OfficeID;
          cmbSection.DataSource = objDAL.LoadAll(objBAL);
            cmbSection.ValueMember = "section_id";
            cmbSection.DisplayMember = "name";
            cmbSection.SelectedIndex = -1;
            
        }
        private void loadUserExperience()
        {
            UserExperienceDAL objDAL = new UserExperienceDAL();
            UserExperienceBAL obj = new UserExperienceBAL();
            obj.User_id = EmployeeID;//Convert.ToInt32(cmbUserExperience.SelectedValue);
            gridUserExperience.DataSource = objDAL.LoadByID(obj);
            gridUserExperience.Columns["Experience_id"].Visible = false;
            gridUserExperience.Columns["User_id"].Visible = false;
            gridUserExperience.Columns["TimeStamp"].Visible = false;
            gridUserExperience.Columns["Add_by"].Visible = false;
            gridUserExperience.Columns["Status"].Visible = false;
            gridUserExperience.Columns["Flag"].Visible = false;

        }

        private void loadJobStatus()
        {
            EmployeeCompanyInfoBAL obj = new EmployeeCompanyInfoBAL();
            EmployeeCompanyIndoDAL objDAL = new EmployeeCompanyIndoDAL();

            cmbJobStatus.DataSource = objDAL.LoadJobStatus();
            cmbJobStatus.ValueMember = "jobstatus_id";
            cmbJobStatus.DisplayMember = "name";
            cmbJobStatus.SelectedIndex = -1;
        }

        private void loadExperties()//Function
        {
            AssignExpertiesDAL objDAL = new AssignExpertiesDAL();
            AssignExpertiesBAL obj = new AssignExpertiesBAL();
            obj.UserId = EmployeeID;//Convert.ToInt32(cmbUserExperties.SelectedValue);
           
            gridUserExperties.DataSource = objDAL.LoadByUserID(obj);
        }
     
        private void loadUserEducation()
        {
            UserEducationDAL objDAL = new UserEducationDAL();
            UserEducationBAL obj = new UserEducationBAL();
            obj.User_id = EmployeeID;//Convert.ToInt32(cmb_User.SelectedValue);
            gridUserEducation.DataSource = objDAL.LoadByID(obj);
            gridUserEducation.Columns["Education_id"].Visible = false;
             gridUserEducation.Columns["User_id"].Visible = false;
            gridUserEducation.Columns["TimeStamp"].Visible = false;
           gridUserEducation.Columns["Add_by"].Visible = false;
            gridUserEducation.Columns["Status"].Visible = false;
            gridUserEducation.Columns["Flag"].Visible = false;

        }


        private void loadgridAllExperties()
        {
            AccountDAL objDAL = new AccountDAL();
            AssignExpertiesDAL obj = new AssignExpertiesDAL();
            AssignExpertiesBAL OBJ = new AssignExpertiesBAL();
           
            OBJ.UserId = EmployeeID;
            dt_AllExperties = obj.LoadByUser(OBJ);
            dt_selectedExperties = dt_AllExperties.Clone();
            foreach (DataColumn dc in dt_AllExperties.Columns)
            {
                gridAll.Columns.Add(dc.ColumnName, dc.ColumnName);
                gridSelected.Columns.Add(dc.ColumnName, dc.ColumnName);
            }
            foreach (DataRow dr in dt_AllExperties.Rows)
            {
                gridAll.Rows.Add(dr.ItemArray);
            }

            DataGridViewCheckBoxColumn dgc = new DataGridViewCheckBoxColumn();
            dgc.Name = "Select";
            dgc.HeaderText = "Select";

            DataGridViewCheckBoxColumn dgc2 = new DataGridViewCheckBoxColumn();
            dgc2.Name = "Select";
            dgc2.HeaderText = "Select";

            gridAll.Columns.Add(dgc);
            gridAll.Columns["Select"].DisplayIndex = 0;

            gridSelected.Columns.Add(dgc2);
            gridSelected.Columns["Select"].DisplayIndex = 0;
            //    gridSelected.Rows.Clear();

            gridAll.Columns["Account_id"].Visible = false;
            //gridAll.Columns["Type"].Visible = false;
            //gridAll.Columns["Description"].Visible = false;
            //gridAll.Columns["Timestamp"].Visible = false;
            //gridAll.Columns["Add_by"].Visible = false;
            //gridAll.Columns["Status"].Visible = false;
            //gridAll.Columns["Flag"].Visible = false;
            gridSelected.Columns["Account_id"].Visible = false;
            //gridSelected.Columns["Type"].Visible = false;
            //gridSelected.Columns["Description"].Visible = false;
            //gridSelected.Columns["Timestamp"].Visible = false;
            //gridSelected.Columns["Add_by"].Visible = false;
            //gridSelected.Columns["Status"].Visible = false;
            //gridSelected.Columns["Flag"].Visible = false;


        }
        private void cmbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete button
            //User Personal
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[0])
            {
                deleteEmployeePersonal();

            }
            //User Education
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[1])
            {
                deleteUserEducation();

            }

            //User Experience
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[2])
            {
                deleteUserExperience();

            }

            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[4])
            {
                deleteCompanuInfo();

            }
            //Employee Attendence
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[5])
            {
                deleteEmployeeAttendence();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Button
            //User Personal
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[0])
            {
                saveEmployeePersonal();
            }

            else if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[1])
            {
                saveUserEducation();
            }

            else if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[2])
            {
                saveUserExperience();
            }
            else if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[3])
            {
                saveUserExperties();
            }
            else if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[4])
            {
                saveCompanyInfo();
            }
            else if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[5])
            {
                saveEmployeeAttendence();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[0])
            {
                searchEmployeePersonal();
            }
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[1])
            {
                searchUserEducation();
            }
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[2])
            {
                searchUserExperience();
            }
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[4])
            {
                searchCompanyInfo();
            }
            if (tabControlEmployee.SelectedTab ==  tabAttendence)
            {
                searchEmployeeAttendence();
            }
        }

        private void GridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //  cmbCountry.SelectedValue = CountryID;
            CountryID = Guid.Parse(cmbCountry.SelectedValue.ToString());
            //   int.TryParse(cmbCountry.SelectedValue.ToString(), out CountryID);
            loadCbxStates();
        }

        private void cmbState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cmbState.SelectedValue = stateID;
            stateID = Guid.Parse(cmbState.SelectedValue.ToString());
            //  int.TryParse(cmbState.SelectedValue.ToString(), out stateID);
            loadCbxCities();
        }

        private void cmbCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CityID = Guid.Parse(cmbCity.SelectedValue.ToString());
           // cmbCity.SelectedValue = CityID;
            loadCbxArea();
        }

        private void cmbArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AreaID = Guid.Parse(cmbArea.SelectedValue.ToString());
            cmbArea.SelectedValue = AreaID;
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            loadCmbBranch();
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbBranch.SelectedValue.ToString());
            loadCbxDepartment();
        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepartmentID = Guid.Parse(cmbDepartment.SelectedValue.ToString());
            loadCbxOffice();
        }

        private void cmbOffice_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OfficeID = Guid.Parse(cmbOffice.SelectedValue.ToString());
            loadCbxSection();
        }

        private void cmbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SectionID= Guid.Parse(cmbSection.SelectedValue.ToString());
            
        }

        private void ucAddEmployee_Load(object sender, EventArgs e)
        {

            panelEmployee.Visible = false;
            cmbAdressType.Items.Add("Home");
            cmbAdressType.Items.Add("Office");

            cmbAttendence.Items.Add("Manual");
            cmbAttendence.Items.Add("Biometric");

            //loadCbxCities();
            //clearUserPersonal();
            loadCbxCountries();
            //loadCbxStates();
            loadEmployee();
            loadCbxOrganization();
             
            loadUserId();

            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\EmployeeProfilePics\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
        }

        private void gridUserExperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                AssID = Guid.Parse(gridUserExperties.Rows[rowindex].Cells["AssignId"].Value.ToString());
                ExpID = Guid.Parse(gridUserExperties.Rows[rowindex].Cells["ExpertiesId"].Value.ToString());
                //   int.TryParse(gridUserExperties.Rows[rowindex].Cells["AssignId"].Value.ToString(), out AssID);
                //int.TryParse(gridUserExperties.Rows[rowindex].Cells["ExpertiesId"].Value.ToString(), out ExpID);
                AssignExpertiesBAL obj = new AssignExpertiesBAL();
                AssignExpertiesDAL objDAL = new AssignExpertiesDAL();
                obj.AssignId = AssID;
                obj.ExpertiesId = ExpID;

                objDAL.Delete(obj);
                loadExperties();
                // loadListboxAllExperties();

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < gridAll.Rows.Count; x++)
                {
                    if (Convert.ToBoolean(gridAll.Rows[x].Cells["Select"].Value))
                    {
                        DataGridViewRow row = (DataGridViewRow)gridAll.Rows[x].Clone();

                        for (int y = 0; y < gridAll.Rows[x].Cells.Count; y++)
                        {
                            row.Cells[y].Value = gridAll.Rows[x].Cells[y].Value;
                        }

                        gridSelected.Rows.Add(row);//add
                        gridAll.Rows.RemoveAt(x);
                        x--;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < gridSelected.Rows.Count; x++)
                {
                    if (Convert.ToBoolean(gridSelected.Rows[x].Cells["Select"].Value))
                    {
                        DataGridViewRow row = (DataGridViewRow)gridSelected.Rows[x].Clone();

                        for (int y = 0; y < gridSelected.Rows[x].Cells.Count; y++)
                        {
                            row.Cells[y].Value = gridSelected.Rows[x].Cells[y].Value;
                        }

                        gridAll.Rows.Add(row);
                        gridSelected.Rows.RemoveAt(x);
                        x--;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        
        }

        private void loadTabs()
        {
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[1])
            {


                loadUserEducation();
            }

            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[2])
            {
                loadUserExperience();
            }
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[3])
            {
                loadExperties();

            }
        }

        private void tabControlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlEmployee.SelectedTab == tabAttendence)
            {
                
                panelEmployee.Visible = true;

            }
            else
                panelEmployee.Visible = false;
            loadTabs();
        }
        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }
        private void cmbEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int.TryParse(cmbUser.SelectedValue.ToString(), out UserID);
            EmployeeID = Guid.Parse(cmbEmployee.SelectedValue.ToString());
            loadUserEducation();
            loadUserExperience();
            loadExperties();
            loadEmpoyeeByGrid();
            gridAll.Rows.Clear();
            gridSelected.Rows.Clear();
            loadgridAllExperties();
            loadJobStatus();

            loadCompanyInfo();
            if (EmployeeID != Guid.Empty)
            {
                EnableTab(tabControlEmployee.TabPages[1], true);
                EnableTab(tabControlEmployee.TabPages[2], true);
                EnableTab(tabControlEmployee.TabPages[3], true);
            }
            loadAttendence();
        }

        private void gridUserExperience_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                ExperienceID = Guid.Parse(gridUserExperience.Rows[rowindex].Cells["Experience_id"].Value.ToString());
                EmployeeID = Guid.Parse(gridUserExperience.Rows[rowindex].Cells["User_id"].Value.ToString());
                //int.TryParse(gridUserExperience.Rows[rowindex].Cells["Experience_id"].Value.ToString(), out ExperienceID);
                //int.TryParse(gridUserExperience.Rows[rowindex].Cells["User_id"].Value.ToString(), out UserID);
                cmbEmployee.SelectedValue = EmployeeID;
                try
                {
                    MemoryStream ms = new MemoryStream((byte[])gridUserExperience.CurrentRow.Cells[3].Value);
                    experiencePicbox.Image = Image.FromStream(ms);
                }
                catch { }
                txtJobTitle.Text = gridUserExperience.Rows[rowindex].Cells["Job_title"].Value.ToString();
                txtComapnyName.Text = gridUserExperience.Rows[rowindex].Cells["Company_name"].Value.ToString();
                txtStartDesignation.Text = gridUserExperience.Rows[rowindex].Cells["Start_designation"].Value.ToString();
                txtEndDesignation.Text = gridUserExperience.Rows[rowindex].Cells["End_designation"].Value.ToString();
                dtpStartDate.Text = gridUserExperience.Rows[rowindex].Cells["Start_date"].Value.ToString();
                dtpEndDate.Text = gridUserExperience.Rows[rowindex].Cells["End_date"].Value.ToString();
                txtReason.Text = gridUserExperience.Rows[rowindex].Cells["Resign"].Value.ToString();
                btnSave.LabelText = "Update";
            }
        }

        private void gridUserEducation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                EducationID = Guid.Parse(gridUserEducation.Rows[rowindex].Cells["Education_id"].Value.ToString());

                //int.TryParse(gridUserEducation.Rows[rowindex].Cells["Education_id"].Value.ToString(), out EducationID);
                try
                {
                    MemoryStream ms = new MemoryStream((byte[])gridUserEducation.CurrentRow.Cells[3].Value);
                    DegreePicBox.Image = Image.FromStream(ms);
                }
                catch { }
                //   cmb_User.Text = gridUserEducation.Rows[rowindex].Cells["User_id"].Value.ToString();
                txtBoard.Text = gridUserEducation.Rows[rowindex].Cells["Board"].Value.ToString();
                txtDegree.Text = gridUserEducation.Rows[rowindex].Cells["Specilization"].Value.ToString();
                txtOBT.Text = gridUserEducation.Rows[rowindex].Cells["OBT_CGPA"].Value.ToString();
                txtTotal.Text = gridUserEducation.Rows[rowindex].Cells["Totalmarks_Cgpa"].Value.ToString();
                EmployeeID = Guid.Parse(gridUserEducation.Rows[rowindex].Cells["User_id"].Value.ToString());
                // int.TryParse(gridUserEducation.Rows[rowindex].Cells["User_id"].Value.ToString(), out UserID);
                cmbEmployee.SelectedValue = EmployeeID;


                btnSave.LabelText = "Update";

            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(* .gif)|* .gif|All Files(*.*)|*.*";
                dlg.Title = "Please Select Degree Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    DegreePicBox.ImageLocation = imgLoc;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
            DegreePicBox.Image = null;
        }

        private void btnAddExperincePic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(* .gif)|* .gif|All Files(*.*)|*.*";
                dlg.Title = "Please Select Degree Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLocExperience = dlg.FileName.ToString();
                    experiencePicbox.ImageLocation = imgLocExperience;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRemoveExperiencePic_Click(object sender, EventArgs e)
        {
            experiencePicbox.Image = null;
        }

        private void gridUserEducation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gridUserExperience_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbEmployee.SelectedIndex = -1;
            cmbEmp.SelectedIndex = -1;
            loadUserId();
          
                clearEmployeePersonal();
                loadEmployee();

         
                clearAllEducation();
                loadUserEducation();

            

           clearUserExperience();
                loadUserExperience();
         
                clearCompanyInfo();

                loadCompanyInfo();
          
            gridAll.Rows.Clear();
            gridSelected.Rows.Clear();
            gridUserExperties.DataSource = null;
             
                clearEmployeeAttendence();
                loadAttendence();
            
    

        }

        private void cmbJobStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            JobStatusID = Guid.Parse(cmbJobStatus.SelectedValue.ToString());
        }

        private void gridCompanyInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
               CompanyID = Guid.Parse(gridCompanyInfo.Rows[rowindex].Cells["employeeCompany_id"].Value.ToString());
                JobStatusID = Guid.Parse(gridCompanyInfo.Rows[rowindex].Cells["jobstatus_id"].Value.ToString());
                cmbJobStatus.SelectedValue = JobStatusID;
                EmployeeID = Guid.Parse(gridCompanyInfo.Rows[rowindex].Cells["employee_id"].Value.ToString());
             
         
               txtDesignation.Text = gridCompanyInfo.Rows[rowindex].Cells["designation"].Value.ToString();
               txtSalary.Text = gridCompanyInfo.Rows[rowindex].Cells["salary"].Value.ToString();
                txtScale.Text = gridCompanyInfo.Rows[rowindex].Cells["scale"].Value.ToString();
             
                dtpDateofJoin.Text = gridCompanyInfo.Rows[rowindex].Cells["date_of_join"].Value.ToString();
                dtpLeaveDate.Text = gridCompanyInfo.Rows[rowindex].Cells["leavedate"].Value.ToString();
                 btnSave.LabelText = "Update";
            }
        }

        private void gridAttendence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
               AttendenceID = Guid.Parse(gridAttendence.Rows[rowindex].Cells["Attendence_id"].Value.ToString());

                EmployeeID = Guid.Parse(gridAttendence.Rows[rowindex].Cells["Employee_id"].Value.ToString());
                cmbEmployee.SelectedValue = EmployeeID;
                cmbEmp.SelectedValue = EmployeeID;
                 dtpAbsentAfter.Text = gridAttendence.Rows[rowindex].Cells["absent_after"].Value.ToString();
                dtpBreakEnd.Text = gridAttendence.Rows[rowindex].Cells["break_end"].Value.ToString();
                dtpBreakStart.Text = gridAttendence.Rows[rowindex].Cells["break_start"].Value.ToString();

                dtpGraceTime.Text = gridAttendence.Rows[rowindex].Cells["grace_time"].Value.ToString();
                 dtpShortLeave.Text= gridAttendence.Rows[rowindex].Cells["short_leave"].Value.ToString();
                 dtpTimeIn.Text = gridAttendence.Rows[rowindex].Cells["time_in"].Value.ToString();
                dtpTimeOut.Text = gridAttendence.Rows[rowindex].Cells["time_out"].Value.ToString();


    


                btnSave.LabelText = "Update";

            }
        }

        private void panelEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEmp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EmployeeID = Guid.Parse(cmbEmp.SelectedValue.ToString());
            loadAttendence();
        }

        private void btnTabClear_Click(object sender, EventArgs e)
        {
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[0])
            {
                clearEmployeePersonal();
                loadEmployee();

            }
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[1])
            {
                clearAllEducation();
                loadUserEducation();

            }

            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[2])
            {
                clearUserExperience();
                loadUserExperience();
            }
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[4])
            {
                clearCompanyInfo();

                loadCompanyInfo();
            }
            gridAll.Rows.Clear();
            gridSelected.Rows.Clear();
            gridUserExperties.DataSource = null;
            if (tabControlEmployee.SelectedTab == tabControlEmployee.TabPages[5])
            {
                clearEmployeeAttendence();
                loadAttendence();
            }
        }

        private void cmbOrg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrg.SelectedValue.ToString());
            loadCmbBranch();
        }

        private void cmbOrgBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrgBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbOrgBranch.SelectedValue.ToString());
            loadCbxDepartment();
        }

        private void cmbDept_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepartmentID = Guid.Parse(cmbDept.SelectedValue.ToString());
            loadCbxOffice();
                
         }

        private void cmbDeptOfficce_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OfficeID = Guid.Parse(cmbDeptOfficce.SelectedValue.ToString());
            loadCbxOfficeSection();
        }


        private void Salary(Guid employee_id, string det)
        {
            Employee_SalaryAndLeavesBAL salary = new Employee_SalaryAndLeavesBAL();
            Employee_SalaryAndLeavesDAL SalaryDB = new Employee_SalaryAndLeavesDAL();
            salary.employee_id = employee_id;
            salary.totalSalary = Convert.ToInt32(txtSalary.Text);
            int workingyears = DateTime.Now.Year - dtpDateofJoin.Value.Year;
            int leaveallowed = workingyears * 5;
            if (leaveallowed < 20)
            {
                salary.LeaveIncrement = 5;
            }


            if (workingyears <= 4)
            {
                salary.NoOfMedicalLeaveAllowed = 0;
                salary.RemainingMedicalLeaves = 0;
                salary.NoOfLeaveAllowed = leaveallowed;
                salary.RemainingLeaves = leaveallowed;
            }
            else if (workingyears > 4)
            {
                salary.NoOfLeaveAllowed = 20;
                salary.RemainingLeaves = 20;
                salary.NoOfMedicalLeaveAllowed = 5;
                salary.RemainingMedicalLeaves = 5;
                salary.LeaveIncrement = 0;
            }
            salary.RemainingMonths = 12;
            if (det == "I")
            {
                SalaryDB.Add(salary);
            }
            else
            {
                SalaryDB.Update(salary);
            }
              }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridEmployee_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                //  Convert.ToString(GridEmployee.Rows[rowindex].Cells["User_id"].Value.ToString(), out UserID);
                EmployeeID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["employee_id"].Value.ToString());
                txtFirstName.Text = GridEmployee.Rows[rowindex].Cells["firstname"].Value.ToString();
                txtLastName.Text = GridEmployee.Rows[rowindex].Cells["lastname"].Value.ToString();

                txtCnic.Text = GridEmployee.Rows[rowindex].Cells["CNIC"].Value.ToString();
                txtEmail.Text = GridEmployee.Rows[rowindex].Cells["Email"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(GridEmployee.Rows[rowindex].Cells["dob"].Value.ToString());



                txtPhone.Text = GridEmployee.Rows[rowindex].Cells["phone"].Value.ToString();

                //
                // int.TryParse(GridEmployee.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                CountryID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["country_id"].Value.ToString());
                cmbCountry.SelectedValue = CountryID;
                loadCbxStates();
                //  int.TryParse(GridEmployee.Rows[rowindex].Cells["state_id"].Value.ToString(), out stateID);

                stateID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["state_id"].Value.ToString());
                cmbState.SelectedValue = stateID;
                /// int.TryParse(GridEmployee.Rows[rowindex].Cells["city_id"].Value.ToString(), out CityID);
                ///
                loadCbxCities();
                CityID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["city_id"].Value.ToString());
                cmbCity.SelectedValue = CityID;
                loadCbxArea();

                AreaID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["area_id"].Value.ToString());
                cmbArea.SelectedValue = AreaID;
                cmbAdressType.Text = GridEmployee.Rows[rowindex].Cells["address_type"].Value.ToString();

                txtAdress1.Text = GridEmployee.Rows[rowindex].Cells["address1"].Value.ToString();
                txtAdress2.Text = GridEmployee.Rows[rowindex].Cells["address2"].Value.ToString();
               
                
                OrganizationID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["Organization_id"].Value.ToString());
                cmbOrganization.SelectedValue = OrganizationID;
                
                loadCmbBranch();

                BranchID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["Branch_id"].Value.ToString());
                cmbBranch.SelectedValue = BranchID;
                
                loadCbxDepartment();
                DepartmentID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["dept_id"].Value.ToString());
                cmbDepartment.SelectedValue = DepartmentID;
                loadCbxOffice();

                OfficeID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["office_id"].Value.ToString());
                cmbOffice.SelectedValue = OfficeID;
                loadCbxSection();

                SectionID = Guid.Parse(GridEmployee.Rows[rowindex].Cells["section_id"].Value.ToString());
                cmbSection.SelectedValue = SectionID;

                cmbAttendence.Text = GridEmployee.Rows[rowindex].Cells["attendance_type"].Value.ToString();
                txtRegNo.Text = GridEmployee.Rows[rowindex].Cells["registration"].Value.ToString();
                txtNTN.Text = GridEmployee.Rows[rowindex].Cells["ntn_Number"].Value.ToString();

                string nm = GridEmployee.Rows[rowindex].Cells["profile_PicPath"].Value.ToString();
                filepath = (appPath + (nm));
                ProfilePicBox.ImageLocation = filepath;
                  picname = nm;


                btnSave.LabelText = "Update";
            }
            loadUserEducation();
            loadgridAllExperties();
            loadUserExperience();
            loadEmpoyeeByGrid();
            loadCompanyInfo();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var iName = opFile.SafeFileName; //Image Name(I Don't Use this name instead 'name')
                    filepath = opFile.FileName; //File path
                                                //Make "<WorkOrderNumber>.Jpg"
                                                /*File.Copy(filepath, appPath + (iName));   */ //Copy Image to Path
                                                                                               // File.Delete(/*filepath, */appPath + ("1234.jpg")); //Delete Image from Path
                    ProfilePicBox.ImageLocation = filepath; //Show Image via Dialogbox
                    // string NPath=appPath+name;                         //Exact Path
                    //pictureBox2.Image = Image.FromFile(NPath);         //Get image from path and display in Picture Box
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }

        }

        private void txtNTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRegNo.Focus();

            }
        }

        private void txtRegNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFirstName.Focus();
            }
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLastName.Focus();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCnic.Focus();
            }
        }

        private void txtCnic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDOB.Focus();
            }
        }

        private void dtpDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCountry.Focus();
            }
        }

        private void cmbCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbState.Focus();
            }
        }

        private void cmbState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCity.Focus();
            }
        }

        private void cmbCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbArea.Focus();
            }
        }

        private void cmbArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbOrganization.Focus();
            }
        }

        private void cmbOrganization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBranch.Focus();
            }
        }

        private void cmbBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDepartment.Focus();
            }
        }

        private void cmbDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbOffice.Focus();
            }
        }

        private void cmbOffice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSection.Focus();
            }
        }

        private void cmbSection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbAttendence.Focus();
            }
        }

        private void cmbAttendence_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbAdressType.Focus();
            }
        }

        private void cmbAdressType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdress1.Focus();
            }
        }

        private void txtAdress1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdress2.Focus();
            }
        }

        private void txtDegree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoard.Focus();

            }
        }

        private void txtBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtOBT.Focus();
            }
        }

        private void txtOBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTotal.Focus();
            }
        }

        private void txtJobTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComapnyName.Focus();
            }
        }

        private void txtComapnyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpStartDate.Focus();
            }
        }

        private void dtpStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpEndDate.Focus();
            }
        }

        private void dtpEndDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStartDesignation.Focus();
            }
        }

        private void txtStartDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEndDesignation.Focus();
            }
        }

        private void txtEndDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReason.Focus();
            }
        }
    }
    }


