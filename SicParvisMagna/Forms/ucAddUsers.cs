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
using BasicCRUD.Controllers;
using BasicCRUD.Models;

namespace SicParvisMagna.Forms
{

    
    public partial class ucAddUsers : UserControl
    {
        public static Guid userid = Program.User_id;

        private Guid CountryID = Guid.Empty;
        private Guid stateID = Guid.Empty;
        private Guid CityID = Guid.Empty;
        private Guid AreaID = Guid.Empty;
        private Guid UserID = Guid.Empty;
        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;


        public static bool PerAdd;
        public static bool PerDel;
        public static string pgURL;
        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;


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
 

        public ucAddUsers()
        {
            InitializeComponent();
            staticcon = new SQLCon().getCon();
            staticcmd = new SqlCommand();
           // formHeading = lblFormHeading;
        }
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        //PermissionDAL.ButtonPermission(userid, pgURL, PerAdd, PerDel)
        //PermissionDAL objDAL = new PermissionDAL();
        //objDAL.SaveButtonPermission(userid, pgURL, PerAdd)

        
       
        
        public static DataTable SaveButtonPermission(Guid userid, string pgURL, Boolean PerAdd)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                staticcon.Open();
                staticcmd.Connection = staticcon;
                staticcmd.CommandType = CommandType.StoredProcedure;
                staticcmd.CommandText = "sp_Permission_SaveButtonPermission";
                staticcmd.Parameters.Clear();
                staticcmd.Parameters.AddWithValue("@Userid", userid);
                staticcmd.Parameters.AddWithValue("@pgURL", pgURL);
                staticcmd.Parameters.AddWithValue("@PerAdd", PerAdd);
               
                staticcmd.ExecuteNonQuery();
                staticcon.Close();
                da.SelectCommand = staticcmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public static DataTable DeleteButtonPermission(Guid userid, string pgURL, Boolean PerDel)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                staticcon.Open();
                staticcmd.Connection = staticcon;
                staticcmd.CommandType = CommandType.StoredProcedure;
                staticcmd.CommandText = "sp_Permission_DeleteButtonPermission";
                staticcmd.Parameters.Clear();
                staticcmd.Parameters.AddWithValue("@Userid", userid);
                staticcmd.Parameters.AddWithValue("@pgURL", pgURL);
                staticcmd.Parameters.AddWithValue("@PerAdd", PerDel);

                staticcmd.ExecuteNonQuery();
                staticcon.Close();
                da.SelectCommand = staticcmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
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




            //User Name
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                lblErrorUserName.Text += "UserName is required!";
                validated = false;
            }
            else
            {
                lblErrorUserName.Text = "";
            }

            if (!Validation.isAlpha(txtUserName.Text, 25))
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                    lblErrorUserName.Text += "\n";
                lblErrorUserName.Text += "UserName Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorUserName.Text = "";
            }
            //====================================================


            //Father Name
            if (string.IsNullOrEmpty(txtFatherName.Text))
            {
                lblErrorFatherName.Text += "FatherName is required!";
                validated = false;
            }
            else
            {
                lblErrorFatherName.Text = "";
            }

            if (!Validation.isAlpha(txtFatherName.Text, 25))
            {
                if (string.IsNullOrEmpty(txtFatherName.Text))
                    lblErrorFatherName.Text += "\n";
                lblErrorFatherName.Text += "FatherName Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblErrorFatherName.Text = "";
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
                    lblErrorCnic.Text += "\n";//hyphens are not added (they are removed from code)
                lblErrorCnic.Text += "Cnic  Should be numeric! Do not use hyphens";
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
            //for Password
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblErrorPassword.Text += "password is required!";
                validated = false;
                btnSeePassword.Hide();
            }
            else
            {
                lblErrorPassword.Text = "";
                btnSeePassword.Show();
            }

            if (!Validation.isPassword(txtPassword.Text))
            {
                //if (string.IsNullOrEmpty(txtPassword.Text))
                //    lblErrorPassword.Text += "\n";
                //lblErrorPassword.Text += "Password maximum 8 chraxcters";
                //validated = false;
                btnSeePassword.Hide();
            }
            else
            {
                lblErrorPassword.Text = "";
                btnSeePassword.Show();
            }
            //====================================================
            //For  Retype password
            if (string.IsNullOrEmpty(txtRetypePassword.Text))
            {
                lblErrorRetypePassword.Text += "Passowrd  required!";
                validated = false;
                btnSeeRetypePassword.Hide();
            }
            else
            {
                lblErrorRetypePassword.Text = "";
                btnSeeRetypePassword.Show();
            }

            if (txtPassword.Text == txtRetypePassword.Text)
            {
                lblErrorRetypePassword.Text = "";
                btnSeeRetypePassword.Show();
            }
            else
            {
                lblErrorRetypePassword.Text += "Password  doesn't match";
                validated = false;
                btnSeeRetypePassword.Hide();
            }
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
            if (string.IsNullOrEmpty(txtAdress.Text))
            {

                lblErrorAdress.Text += "Adress is required!";
                validated = false;
            }
            else
            {
                lblErrorAdress.Text = "";
            }

            if (!Validation.isAdress(txtAdress.Text))
            {
                if (string.IsNullOrEmpty(txtAdress.Text))
                    lblErrorAdress.Text += "\n";
                lblErrorAdress.Text += "Special Chracters are not Allowed";
                validated = false;
            }
            else
            {
                lblErrorAdress.Text = "";
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
        ////-------------------------------------------------------------------------------------------
        ///-----------------------------------------------------------------------------------------
        ///---------------------------------SEARCHING------------------------------------------
        ///
        private void searchUserPersonal()
        {
                if(UserID!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM [Users] ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtFirstName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE First_name like '%" + txtFirstName.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtLastName.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Last_name like '%" + txtLastName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Last_name like '%" + txtLastName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtUserName.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE User_name like '%" + txtUserName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND User_name like '%" + txtUserName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtFatherName.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Father_name like '%" + txtFatherName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Father_name like '%" + txtFatherName.Text + "%'";
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
                if (!string.IsNullOrEmpty(txtContact.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE contact like '%" + txtContact.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND contact like '%" + txtContact.Text + "%'";
                }
                if (!string.IsNullOrEmpty(cmbGender.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Gender like '%" + cmbGender.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Gender like '%" + cmbGender.Text + "%'";
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
                if (!string.IsNullOrEmpty(txtAdress.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Adress like '%" + txtAdress.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Adress like '%" + txtAdress.Text + "%'";
                }
                if (!string.IsNullOrEmpty(cmbOrganization.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Account_type like '%" + cmbOrganization.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Account_type like '%" + cmbOrganization.Text + "%'";
                }
                if (UserID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE User_id  = " + UserID;
                        whereAdded = true;
                    }
                    else
                        query += "   AND User_id  = " + UserID;
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

                GridUser.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //User Education
        private void searchUserEducation()
        {
            if (EducationID!=Guid.Empty)
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
                if (UserID!=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE User_id = '" + UserID+"'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND User_id  = '" + UserID + "'";
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
//User Experience
        private void searchUserExperience()
        {
            if (ExperienceID!= Guid.Empty)
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

                if (ExperienceID!= Guid.Empty)
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
        //_________________________________________________SAVE FUNCTIONS___________________________
        //___________________________________________________________________________________________________
        //___________________________________________________________________________________________________
        private void saveUserPersonal()
        {
            UserBAL objBAL = new UserBAL();

            if (FormValidation())
            {
                objBAL.First_name = txtFirstName.Text;
                objBAL.Last_name = txtLastName.Text;
                objBAL.User_name = txtUserName.Text;
                objBAL.Father_name = txtFatherName.Text;
                objBAL.Cnic = txtCnic.Text;
                objBAL.Email = txtEmail.Text;
                //for Generate hash password
                string hash = generateHash(txtRetypePassword.Text);
                objBAL.password = hash;
                objBAL.contact = txtContact.Text;
                objBAL.Phone = txtPhone.Text;
                objBAL.DOB = DateTime.Parse(dtpDOB.Text);
                objBAL.Account_type = cmbAccount.Text;
                objBAL.country_id = CountryID;
                objBAL.city_id = CityID;
                objBAL.state_id = stateID;
                objBAL.Area_id = AreaID;
                objBAL.Timestamp = DateTime.Now;
                objBAL.Add_by = "Admin";
                objBAL.Status = "Activate";
                objBAL.Flag = 1;
                objBAL.FirstTimeLogin = 1;
                objBAL.Adress = txtAdress.Text;
                objBAL.Gender = cmbGender.Text;
                objBAL.Organization_id = OrganizationID;
                objBAL.Branch_id = BranchID;
                objBAL.Employee_id = Guid.Empty;


                //
                UserDAL objDAL = new UserDAL();


                if (UserID !=Guid.Empty)
                {
                    objBAL.User_id = UserID;


                    objDAL.Update(objBAL);



                }
                else
                {

                  Guid insertedUserID =  objDAL.Add(objBAL);

                    //PermissionBAL objPerBal = new PermissionBAL();
                    //PermissionDAL objPerDal = new PermissionDAL();
                    //PermissionDAL.AssignPermissions(objPerBal);
                    Guid RoleID = Guid.Empty;
                    Guid.TryParse(cmbAccount.SelectedValue.ToString(), out RoleID);
                    PermissionBAL objj = new PermissionBAL();
                    objj.RoleID = RoleID;
                    PagesDAL objPageDal = new PagesDAL();
                        //permission dal
                    PermissionDAL objPerDal = new PermissionDAL();
                    PermissionBAL objPerBal = new PermissionBAL();

                    DataTable pages = objPageDal.LoadAll();
                    DataTable PerByRoles = objPerDal.loadByRole(objj);
                    if (rdCustomPermissions.Checked)
                    {
                        for (int x = 0; x < pages.Rows.Count; x++)
                        {
                            //permission bal
                            objPerBal.PgID = Guid.Parse(pages.Rows[x]["pgID"].ToString());
                            objPerBal.User_id = insertedUserID;
                            objPerBal.PerAdd = false;
                            objPerBal.PerEdit = false;
                            objPerBal.PerView = false;
                            objPerBal.PerDel = false;
                            objPerBal.PerUID = "2";
                            objPerBal.AddBy = "Admin";
                            objPerBal.Timestamp = DateTime.Now;
                            objPerBal.Status = "Active";
                            objPerBal.Flag = 1;
                            //permissionsave
                            objPerDal.Add(objPerBal);
                            //objPerBal.User_id

                        }
                        // for loop
                        // PermissionBAL   */
                    }
                    else if (rdRoleBased.Checked)
                    {
                        for (int x = 0; x <  PerByRoles.Rows.Count; x++)
                        {
                            objPerBal.RoleID = RoleID;
                            objPerBal.User_id = insertedUserID; 
                            objPerDal.UpdateUserId_Roles(objPerBal);

                        }

                    }
                }

                clearUserPersonal();
                loadUsers();
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
                    obj.User_id = UserID;
                    obj.Board = txtBoard.Text;
                    obj.Specilization = txtDegree.Text;
                    obj.OBT_CGPA = txtOBT.Text;
                    obj.Totalmarks_Cgpa = txtTotal.Text;
                    float ans = (float.Parse(txtOBT.Text) / float.Parse(txtTotal.Text)) * 100;
                    obj.Percentage = ans.ToString() + "%";
                    UserEducationDAL objDAL = new UserEducationDAL();
                    if (EducationID!=Guid.Empty)
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
                obj.User_id = UserID;
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
                if (ExperienceID!=Guid.Empty)
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
        //User Experties
        private void saveUserExperties()
        {
            AssignExpertiesBAL obj;
            AssignExpertiesDAL objDal = new AssignExpertiesDAL();
            for (int i = 0; i < gridSelected.Rows.Count; i++)
            {

                obj = new AssignExpertiesBAL();
               
                obj.ExpertiesId = Guid.Parse(gridSelected.Rows[i].Cells["Account_id"].Value.ToString());
                obj.UserId = UserID;
                obj.Timestamp = DateTime.Now;
                obj.Addby = "Admin";
                obj.Status = "Active";
                obj.Flag = 1;


                objDal.Add(obj);
                loadExperties();
            }
        }
        /*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
         * @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
         * @@@@@@@@@@@@@@CLEAR FUNCTION@@@@@@@@@@@@@@@@@@@@@@@@@@@*/
        public void clearUserPersonal()
        {
            btnSeePassword.Show();
            btnSeeRetypePassword.Show();
            btnSave.LabelText = "Save";

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            txtCnic.Text = "";
            txtPassword.Text = "";
            txtRetypePassword.Text = "";
            txtPhone.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtAdress.Text = "";
            dtpDOB.Text = "";
            cmbOrganization.Text = "";
            cmbCountry.SelectedIndex = -1;

            cmbState.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            cmbOrganization.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbAccount.SelectedIndex = -1;
            cmbGender.Text = "";
            btnSave.Text = "Save";
            loadUsers();
            CountryID = Guid.Empty;
            CityID = Guid.Empty;
            stateID = Guid.Empty;
            AccountID = Guid.Empty;
            UserID = Guid.Empty;
            lblErrorFirstName.Text = "";
            lblErrorLastName.Text = "";
            lblErrorUserName.Text = "";
            lblErrorFatherName.Text = "";
            lblErrorEmail.Text = "";
            lblErrorPassword.Text = "";
            lblErrorRetypePassword.Text = "";
            lblErrorPhone.Text = "";
            lblErrorCnic.Text = "";
            lblErrorAdress.Text = "";

        }

        //
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
            gridUserEducation.DataSource = null;
            gridUserEducation.Rows.Clear();
            loadUserEducation();
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
            gridUserExperience.DataSource = null;
            gridUserExperience.Rows.Clear();
            lblErrorCompanyName.Text = "";
            lblErrorJobTitle.Text = "";
            lblErrorStartDesignation.Text = "";
            lblErrorEndDesignation.Text = "";
 
            loadUserExperience();

        }

        /*#############################################################################
         * ################################################################################
         * ###############################DELETE FUNCTION##################################*/
        private void deleteUserPersonal()
        {

            if (UserID!=Guid.Empty)
            {
                UserBAL objBAL = new UserBAL();
                UserDAL objDAL = new UserDAL();
                //

                objBAL.User_id = UserID;


                objDAL.Delete(objBAL);
                clearUserPersonal();

            }
            else
            {
                MessageBox.Show("No User selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Delete Education
        private void deleteUserEducation()
        {
            if (EducationID!=Guid.Empty)
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
            if (ExperienceID!=Guid.Empty)
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
        ///$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        ///$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        ///$$$$$$$$$$$$$$$  LOAD   FUNCTION$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        //Load functions
        private void loadUsers()
        {
            UserDAL objDAL = new UserDAL();
            GridUser.DataSource = objDAL.LoadAll();

            GridUser.Columns["User_id"].Visible = false;
            GridUser.Columns["country_id"].Visible = false;
            GridUser.Columns["state_id"].Visible = false;
            GridUser.Columns["city_id"].Visible = false;
            GridUser.Columns["Area_id"].Visible = false;
            GridUser.Columns["Organization_id"].Visible = false;
            GridUser.Columns["Branch_id"].Visible = false;
            GridUser.Columns["Employee_id"].Visible = false;
            //GridUser.Columns["dept_id"].Visible = false;
            //GridUser.Columns["section_id"].Visible = false;
            //GridUser.Columns["office_id"].Visible = false;
            GridUser.Columns["Flag"].Visible = false;
            GridUser.Columns["Add_by"].Visible = false;
            GridUser.Columns["TimeStamp"].Visible = false;
            GridUser.Columns["Editby"].Visible = false;
            GridUser.Columns["EditDate"].Visible = false;
            GridUser.Columns["FirstTimeLogin"].Visible = false;
            GridUser.Columns["Status"].Visible = false;

        }
        private void loadUserId( )
        {
            UserDAL objDAL = new UserDAL();
            cmbUser.DataSource = objDAL.LoadAll();
            cmbUser.ValueMember = "User_id";
            cmbUser.DisplayMember = "User_name";
            cmbUser.SelectedIndex = -1;
        }
 

        private void loadUserByGrid()
        {
            UserDAL objDAL = new UserDAL();
            UserBAL obj = new UserBAL();
            obj.User_id = UserID;
            GridUser.DataSource = objDAL.LoadByUser(obj);
          
         
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
            obj.City_id = CityID;
            cmbArea.DataSource = objDAL.LoadByCity(obj);
            cmbArea.ValueMember = "area_id";
            cmbArea.DisplayMember = "name";
            cmbArea.SelectedIndex = -1;

        }
        private void loadCmbBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();

            obj.Parent_id = Guid.Parse(cmbOrganization.SelectedValue.ToString());

            cmbBranch.DataSource = objDAL.LoadBranch(obj);
            cmbBranch.ValueMember = "Organization_id";
            cmbBranch.DisplayMember = "Title";
            cmbBranch.SelectedIndex = -1;
        }

        //
        private void loadCbxOrganization()
        {
            OrganizationBAL objBAL = new OrganizationBAL();
            OrganizationDAL objDAL = new OrganizationDAL();

            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;
        }
        private void loadCbxAccount()
        {
            AccountBAL objBAL = new AccountBAL();
            AccountDAL objDAL = new AccountDAL();

            cmbAccount.DataSource = objDAL.LoadAll();
            cmbAccount.ValueMember = "Account_id";
            cmbAccount.DisplayMember = "Title";
            cmbAccount.SelectedIndex = -1;
        }



        private void loadUserExperience()
        {
            UserExperienceDAL objDAL = new UserExperienceDAL();
            UserExperienceBAL obj = new UserExperienceBAL();
            obj.User_id = UserID;//Convert.ToInt32(cmbUserExperience.SelectedValue);
            gridUserExperience.DataSource = objDAL.LoadByID(obj);
            gridUserExperience.Columns["Experience_id"].Visible = false;
            gridUserExperience.Columns["User_id"].Visible = false;
            gridUserExperience.Columns["TimeStamp"].Visible = false;
            gridUserExperience.Columns["Add_by"].Visible = false;
            gridUserExperience.Columns["Status"].Visible = false;
            gridUserExperience.Columns["Flag"].Visible = false;
        }

        private void loadExperties()//Function
        {
            AssignExpertiesDAL objDAL = new AssignExpertiesDAL();
            AssignExpertiesBAL obj = new AssignExpertiesBAL();
            obj.UserId = UserID;//Convert.ToInt32(cmbUserExperties.SelectedValue);
           
            gridUserExperties.DataSource = objDAL.LoadByUserID(obj);
        }
     
        private void loadUserEducation()
        {
            UserEducationDAL objDAL = new UserEducationDAL();
            UserEducationBAL obj = new UserEducationBAL();
            obj.User_id = UserID;//Convert.ToInt32(cmb_User.SelectedValue);
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
           
            OBJ.UserId = UserID;
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
        /////////////////////////////

        //Generate Hash
        static string generateHash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


       
        ///Clear ALL
        

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
      if(UserID!=Guid.Empty)
            {
                UserBAL objBAL = new UserBAL();
                UserDAL objDAL = new UserDAL();
                //

                objBAL.User_id = UserID;


                objDAL.Delete(objBAL);
                clearUserPersonal();

            }
            else
            {
                MessageBox.Show("No User selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbUser.SelectedIndex = -1;
       
            loadUserId();
            
                clearUserPersonal();
                loadUsers();

            
          
                clearAllEducation();
                loadUserEducation();

            

          
                clearUserExperience();
                loadUserExperience();
            
            gridAll.Rows.Clear();
            gridSelected.Rows.Clear();
            gridUserExperties.DataSource = null;

        

    }
       
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //Delete button
            //User Personal
            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserPersonal"])
            {
                deleteUserPersonal();

            }
            //User Education
            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserEducation"])
            {
                deleteUserEducation();

            }

            //User Experience
            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserExperience"])
            {
                deleteUserExperience();

            }

        }
        
        
       
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Button
            //User Personal
            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserPersonal"])
            {
                saveUserPersonal();
            }

           else  if (tabControlUser.SelectedTab == tabControlUser.TabPages[1])
            {
                saveUserEducation();
            }

          else   if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserExperience"])
            {
                saveUserExperience();
            }
         else    if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserExperties"])
            {
                saveUserExperties();
            }

        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserPersonal"])
            {
                searchUserPersonal();
            }
            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserEducation"])
            {
                searchUserEducation();
            }
            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserExperience"])
            {
                searchUserExperience();
            }


        }

        private void GridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
               //  Convert.ToString(GridUser.Rows[rowindex].Cells["User_id"].Value.ToString(), out UserID);
                UserID = Guid.Parse(GridUser.Rows[rowindex].Cells["User_id"].Value.ToString());
                txtFirstName.Text = GridUser.Rows[rowindex].Cells["First_name"].Value.ToString();
                txtLastName.Text = GridUser.Rows[rowindex].Cells["Last_name"].Value.ToString();
                txtUserName.Text = GridUser.Rows[rowindex].Cells["User_name"].Value.ToString();
                txtFatherName.Text = GridUser.Rows[rowindex].Cells["Father_name"].Value.ToString();
                txtCnic.Text = GridUser.Rows[rowindex].Cells["Cnic"].Value.ToString();
                txtEmail.Text = GridUser.Rows[rowindex].Cells["Email"].Value.ToString();
               
                txtContact.Text = GridUser.Rows[rowindex].Cells["contact"].Value.ToString();

                txtPhone.Text = GridUser.Rows[rowindex].Cells["Phone"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(GridUser.Rows[rowindex].Cells["DOB"].Value.ToString());

                //
                // int.TryParse(GridUser.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                CountryID = Guid.Parse(GridUser.Rows[rowindex].Cells["country_id"].Value.ToString());
                cmbCountry.SelectedValue = CountryID;
                loadCbxStates();
                //  int.TryParse(GridUser.Rows[rowindex].Cells["state_id"].Value.ToString(), out stateID);
            
                stateID = Guid.Parse(GridUser.Rows[rowindex].Cells["state_id"].Value.ToString());
                cmbState.SelectedValue = stateID;
                /// int.TryParse(GridUser.Rows[rowindex].Cells["city_id"].Value.ToString(), out CityID);
                ///
                loadCbxCities();
                CityID = Guid.Parse(GridUser.Rows[rowindex].Cells["city_id"].Value.ToString());
                cmbCity.SelectedValue = CityID;

                loadCbxArea();
                AreaID = Guid.Parse(GridUser.Rows[rowindex].Cells["area_id"].Value.ToString());

                cmbArea.SelectedValue = AreaID;
                txtAdress.Text = GridUser.Rows[rowindex].Cells["Adress"].Value.ToString();
                cmbGender.Text = GridUser.Rows[rowindex].Cells["Gender"].Value.ToString();
                cmbAccount.Text= GridUser.Rows[rowindex].Cells["Account_type"].Value.ToString();
                OrganizationID = Guid.Parse(GridUser.Rows[rowindex].Cells["Organization_id"].Value.ToString());
                cmbOrganization.SelectedValue = OrganizationID;
                loadCmbBranch();
 
                BranchID = Guid.Parse(GridUser.Rows[rowindex].Cells["Branch_id"].Value.ToString());
                cmbBranch.SelectedValue = BranchID;
                btnSave.LabelText = "Update";
            }
            loadUserEducation();
            loadgridAllExperties();
            loadUserExperience();
            loadUserByGrid();
            //
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
            cmbCity.SelectedValue = CityID;
            // int.TryParse(cmbCity.SelectedValue.ToString(), out CityID);
            loadCbxArea();
        }

        private void cmbAccountType_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // cmbAccountType.SelectedValue = AccountID;
            AccountID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            //int.TryParse(cmbAccountType.SelectedValue.ToString(), out AccountID);

        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }
        /////////////////////////////////////////////
        private void ucAddUsers_Load(object sender, EventArgs e)
        {
            //pgURL = "Users";
            // try { PerAdd = Convert.ToBoolean(PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd).Rows[0]["PerAdd"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerAdd == true)
            //{
            //    btnSave.Enabled = true;//save button
            //}
            //else
            //{
            //    btnSave.Hide();
            //}

            //pgURL = "Users";
            //PermissionDAL.DeleteButtonPermission(Program.User_id, pgURL, PerDel);
            //try { PerDel = Convert.ToBoolean(PermissionDAL.DeleteButtonPermission(Program.User_id, pgURL, PerDel).Rows[0]["PerDel"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerDel == true)
            //{
            //    btnDelete.Enabled = true;
            //}
            //else
            //{
            //    btnDelete.Hide();
            //}




            cmbGender.Items.Add("Male");
                cmbGender.Items.Add("Female");
                cmbGender.Items.Add("Others");
            cmbAccount.Visible = false;
            lblRoleType.Visible = false;

            loadCbxAccount();
 
                //loadCbxCities();
                //clearUserPersonal();
                loadCbxCountries();
                //loadCbxStates();
              loadUsers();
            loadCbxOrganization();
            loadUserId();
            if (UserID==Guid.Empty)
            {
                EnableTab(tabControlUser.TabPages[1], false);
                EnableTab(tabControlUser.TabPages[2], false);
                EnableTab(tabControlUser.TabPages[3], false);
             }
           
         if (tabControlUser.SelectedTab == tabControlUser.TabPages[1])
            {
                
                 loadUserEducation();
            }

           if (tabControlUser.SelectedTab == tabControlUser.TabPages[2])
            {
                 
            }
           if (tabControlUser.SelectedTab == tabControlUser.TabPages[3])
            {
              
            }


        }
       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
 

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                ExperienceID = Guid.Parse(gridUserExperience.Rows[rowindex].Cells["Experience_id"].Value.ToString());
                UserID = Guid.Parse(gridUserExperience.Rows[rowindex].Cells["User_id"].Value.ToString());
                //int.TryParse(gridUserExperience.Rows[rowindex].Cells["Experience_id"].Value.ToString(), out ExperienceID);
                //int.TryParse(gridUserExperience.Rows[rowindex].Cells["User_id"].Value.ToString(), out UserID);
                cmbUser.SelectedValue = UserID;
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
                UserID = Guid.Parse(gridUserEducation.Rows[rowindex].Cells["User_id"].Value.ToString());
               // int.TryParse(gridUserEducation.Rows[rowindex].Cells["User_id"].Value.ToString(), out UserID);
                cmbUser.SelectedValue = UserID;


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
       
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UserID = Guid.Parse(cmbUser.SelectedValue.ToString());
          //  int.TryParse(cmbUser.SelectedValue.ToString(), out UserID);
            loadUserExperience();
        }

     
        private void gridUserExperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (tabControlUser.SelectedTab == tabControlUser.TabPages[1])
            {

           
                loadUserEducation();
            }

            if (tabControlUser.SelectedTab == tabControlUser.TabPages[2])
            {
              
            }
            if (tabControlUser.SelectedTab == tabControlUser.TabPages[3])
            {
             

            }
        }
        private void tabControlUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //            if (tabControl.SelectedTab == tabControl.TabPages[0])
            //                do something...
            //if (tabControl.SelectedTab == tabControl.TabPages[1])
            //                do something else...
            //if (tabControl.SelectedTab == tabControl.TabPages[2])
            //                do something else...

            loadTabs();
        }

   

        private void gridUserExperience_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gridUserEducation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperience_SelectionChangeCommitted(object sender, EventArgs e)
        {
              loadUserExperience();
        }

        private void gridUserExperience_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperience_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            loadUserExperience();
        }

        private void gridUserExperience_DataError_2(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int.TryParse(cmbUser.SelectedValue.ToString(), out UserID);
            UserID = Guid.Parse(cmbUser.SelectedValue.ToString());
            loadUserEducation();
            loadUserExperience();
            loadExperties();
            loadUserByGrid();
            gridAll.Rows.Clear();
            gridSelected.Rows.Clear();
            loadgridAllExperties();
            if (UserID !=Guid.Empty)
            {
                EnableTab(tabControlUser.TabPages[1], true);
                EnableTab(tabControlUser.TabPages[2], true);
                EnableTab(tabControlUser.TabPages[3], true);
            }
        }

        
 

        private void cmbArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AreaID = Guid.Parse(cmbArea.SelectedValue.ToString());
        }

        private void cmbOrganization_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            loadCmbBranch();
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbBranch.SelectedValue.ToString());
        }

        private void btnTabClear_Click(object sender, EventArgs e)
        {
            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserPersonal"])
            {
                clearUserPersonal();
                loadUsers();

            }
            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserEducation"])
            {
                clearAllEducation();
                loadUserEducation();

            }

            if (tabControlUser.SelectedTab == tabControlUser.TabPages["tabUserExperience"])
            {
                clearUserExperience();
                loadUserExperience();
            }
            gridAll.Rows.Clear();
            gridSelected.Rows.Clear();
            gridUserExperties.DataSource = null;

        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtRetypePassword.UseSystemPasswordChar = false;
        }

        private void txtRetypePassword_TextChanged(object sender, EventArgs e)
        {
            txtRetypePassword.UseSystemPasswordChar = true;
        }

        private void txtRetypePassword_Click(object sender, EventArgs e)
        {
            txtRetypePassword.UseSystemPasswordChar = true;
        }

        private void cmbCountry_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
                 Guid.TryParse(cmbCountry.SelectedValue.ToString(), out CountryID);
            loadCbxStates();
        }

        private void cmbState_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Guid.TryParse(cmbState.SelectedValue.ToString(), out stateID);
            loadCbxCities();
        }

        private void cmbCity_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Guid.TryParse(cmbCity.SelectedValue.ToString(), out CityID);
            loadCbxArea();
        }

        private void cmbArea_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Guid.TryParse(cmbArea.SelectedValue.ToString(), out AreaID);
 
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cmbOrganization.SelectedValue.ToString(), out OrganizationID);
            loadCmbBranch();
        }

        private void cmbBranch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Guid.TryParse(cmbBranch.SelectedValue.ToString(), out BranchID);
         
        }

        private void rdRoleBased_CheckedChanged(object sender, EventArgs e)
        {
            cmbAccount.Visible = true;
            lblRoleType.Visible = true;
        }

        private void rdCustomPermissions_CheckedChanged(object sender, EventArgs e)
        {
            cmbAccount.Visible = false;
            lblRoleType.Visible = false;
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
                txtUserName.Focus();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFatherName.Focus();
            }
        }

        private void txtFatherName_KeyDown(object sender, KeyEventArgs e)
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
               txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRetypePassword.Focus();
            }
        }

        private void txtRetypePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbGender.Focus();
            }
        }

        private void cmbGender_KeyDown(object sender, KeyEventArgs e)
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
                txtContact.Focus();
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
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
                dtpDOB.Focus();
            }
        }

        private void dtpDOB_KeyDown(object sender, KeyEventArgs e)
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
               txtAdress.Focus();
            }
        }
    }
}

