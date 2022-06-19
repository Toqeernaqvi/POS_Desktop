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
    public partial class ucAddSupplier : UserControl
    {
        private System.Windows.Forms.Panel container;
        private Guid CountryID = Guid.Empty;
        private Guid stateID = Guid.Empty;
        private Guid CityID = Guid.Empty;
        private Guid UserID = Guid.Empty;
        private Guid AccountID = Guid.Empty;
        private Guid ContID = Guid.Empty;

        public ucAddSupplier()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        /*
         * *************************************
         * **********************************
         ****VALIDATION*****************
         * *****************************
         ***********************************/
        //-->customer
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
            //for Password
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblErrorPassword.Text += "password is required!";
                validated = false;
            }
            else
            {
                lblErrorPassword.Text = "";
            }

            if (!Validation.isPassword(txtPassword.Text))
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                    lblErrorPassword.Text += "\n";
                lblErrorPassword.Text += "Password maximum 8 chraxcters";
                validated = false;
            }
            else
            {
                lblErrorPassword.Text = "";
            }
            //====================================================
            //For  Retype password
            if (string.IsNullOrEmpty(txtRetypePassword.Text))
            {
                lblErrorRetypePassword.Text += "Passowrd  required!";
                validated = false;
            }
            else
            {
                lblErrorRetypePassword.Text = "";
            }

            if (txtPassword.Text == txtRetypePassword.Text)
            {
                lblErrorRetypePassword.Text = "";
                ;
            }
            else
            {
                lblErrorRetypePassword.Text += "Password  doesn't match";
                validated = false;
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
        private bool FormCustomerContactValidation()
        {
            bool validated = true;
            //for Phone Number
            if (string.IsNullOrEmpty(txtContact.Text))
            {
                lblErrorContact.Text += "Phone no. is required!";
                validated = false;
            }
            else
            {
                lblErrorContact.Text = "";
            }

            if (!Validation.isPhoneNumber(txtContact.Text))
            {
                if (string.IsNullOrEmpty(txtContact.Text))
                    lblErrorContact.Text += "\n";
                lblErrorContact.Text += "03XXXXXXXXX ";
                validated = false;
            }
            else
            {
                lblErrorContact.Text = "";
            }
            return validated;
        }
        private void searchUserPersonal()
        {
            if (UserID != null)
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
                /*if (!string.IsNullOrEmpty(cmbAccountType.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Account_type like '%" + cmbAccountType.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND Account_type like '%" + cmbAccountType.Text + "%'";
                }*/
                if (UserID != null)
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
        private void searchContact()
        {
            if (ContID != null)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM Contact ";
                bool whereAdded = false;
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
                if (!string.IsNullOrEmpty(cbxSupplier.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE User_id like '%" + cbxSupplier.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND User_id like '%" + cbxSupplier.Text + "%'";
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
        private void saveUserPersonal()
        {
            SupplierBAL objBAL = new SupplierBAL();

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
                objBAL.Account_type = "Supplier";
                objBAL.country_id = CountryID;
                objBAL.city_id = CityID;
                objBAL.state_id = stateID;
                objBAL.Timestamp = DateTime.Now;
                objBAL.Add_by = "Admin";
                objBAL.Status = "Activate";
                objBAL.Flag = 1;
                objBAL.FirstTimeLogin = 1;
                objBAL.Adress = txtAdress.Text;
                objBAL.Gender = cmbGender.Text;



                //
                SupplierDAL objDAL = new SupplierDAL();



                if (UserID != null)
                {
                    objBAL.User_id = UserID;


                    objDAL.Update(objBAL);



                }
                else
                {

                    objDAL.Add(objBAL);
                }

                clearUserPersonal();
                loadUsers();
            }
        }
        public void clearUserPersonal()
        {
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
            //cmbAccountType.Text = "";
            cmbCountry.SelectedIndex = -1;

            cmbState.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            // cmbAccountType.SelectedIndex = -1;
            cmbGender.Text = "";
            btnSave.Text = "Save";
            loadUsers();
            CountryID = Guid.Empty;
            CityID = Guid.Empty;
            stateID = Guid.Empty;
            // AccountID = 0;
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
        private void saveContact()
        {
            if (FormCustomerContactValidation())
            {
                CustomerContactBAL objBAL = new CustomerContactBAL();
                objBAL.Number = txt_Contact.Text;
                objBAL.Descrip = txt_Descrip.Text;
                objBAL.User_id = UserID;


                CustomerContactDAL objDAL = new CustomerContactDAL();

                if (ContID != null)
                {
                    objBAL.ContID = ContID;
                    objBAL.EditBy = "Admin";
                    objBAL.EditDate = DateTime.Now;
                    objBAL.Status = "Active";
                    objBAL.Flag = 1;
                    objDAL.Update(objBAL);

                }
                else
                {
                    objBAL.AddBy = "Admin";
                    objBAL.AddDate = DateTime.Now;
                    objBAL.Status = "Active";
                    objBAL.Flag = 1;
                    objDAL.Add(objBAL);
                }
                clearAllContacts();
                loadContacts();

            }
        }
        private void deleteUserPersonal()
        {

            if (UserID != Guid.Empty)
            {
                SupplierBAL objBAL = new SupplierBAL();
                SupplierDAL objDAL = new SupplierDAL();
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
        private void deleteContact()
        {
            if (ContID != Guid.Empty)
            {
                SupplierContactBAL objBAL = new SupplierContactBAL();
                SupplierContactDAL objDAL = new SupplierContactDAL();
                objBAL.ContID = ContID;
                objDAL.Delete(objBAL);
                clearAllContacts();
                loadContacts();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadUsers()
        {
            SupplierDAL objDAL = new SupplierDAL();
            GridUser.DataSource = objDAL.LoadAll();
            GridUser.Columns["Timestamp"].Visible = false;
            GridUser.Columns["Add_by"].Visible = false;
            GridUser.Columns["Status"].Visible = false;
            GridUser.Columns["Flag"].Visible = false;
            GridUser.Columns["EditBy"].Visible = false;
            GridUser.Columns["EditDate"].Visible = false;
        }



        /*private void loadUserByGrid()
        {
            CustomerDAL objDAL = new CustomerDAL();
            CustomerBAL obj = new CustomerBAL();
            obj.User_id = UserID;
            GridUser.DataSource = objDAL.LoadByUser(obj);


        }*/
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
        private void loadCbxGender()
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
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

        }
        /*private void loadCbxAccount()
        {
            AccountBAL objBAL = new AccountBAL();
            AccountDAL objDAL = new AccountDAL();

            cmbAccount.DataSource = objDAL.LoadAll();
            cmbAccount.ValueMember = "Account_id";
            cmbAccount.DisplayMember = "Title";
            cmbAccount.SelectedIndex = -1;
        }*/
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
        private void loadCbxUser()
        {
            CustomerDAL objDAL = new CustomerDAL();
            cbxSupplier.DataSource = objDAL.LoadAll();
            cbxSupplier.ValueMember = "User_id";
            cbxSupplier.DisplayMember = "First_name";
            cbxSupplier.SelectedIndex = -1;
        }
        private void loadContacts()
        {
            SupplierContactDAL objDAL = new SupplierContactDAL();
            gridContact.DataSource = objDAL.LoadAll();
            gridContact.Columns["Timestamp"].Visible = false;
            gridContact.Columns["AddBy"].Visible = false;
            gridContact.Columns["Status"].Visible = false;
            gridContact.Columns["Flag"].Visible = false;
            gridContact.Columns["EditBy"].Visible = false;
            gridContact.Columns["EditDate"].Visible = false;
        }
        private void clearAllContacts()
        {
            btnSave.Text = "Save";
            txt_Contact.Text = "";
            txt_Descrip.Text = "";
            lblErrorContact.Text = "";
            cbxSupplier.SelectedIndex = -1;
            ContID = Guid.Empty;
            UserID = Guid.Empty;
        }
        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }
        private void ucAddSupplier_Load(object sender, EventArgs e)
        {
            loadCbxCountries();
           // loadCbxStates();
           // loadCbxArea();
           // loadCbxCities();
            loadCbxGender();
            loadContacts();
            loadUsers();
            if (UserID == null)
            {
                EnableTab(mtcSupplier.TabPages["Supplier"], false);
                EnableTab(mtcSupplier.TabPages["Contact"], false);

            }

            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Supplier"])
            {

                loadUsers();
            }

            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Contact"])
            {
                loadContacts();
            }
        }

        private void gridContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                ContID = Guid.Parse(gridContact.Rows[rowindex].Cells["ContID"].Value.ToString());
                txt_Contact.Text = gridContact.Rows[rowindex].Cells["Number"].Value.ToString();
                txt_Descrip.Text = gridContact.Rows[rowindex].Cells["Descrip"].Value.ToString();

                UserID = Guid.Parse(gridContact.Rows[rowindex].Cells["User_id"].Value.ToString());
                cbxSupplier.SelectedValue = UserID;

                btnSave.Text = "Update";
            }
        }

        private void GridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                UserID = Guid.Parse(GridUser.Rows[rowindex].Cells["User_id"].Value.ToString());
                txtFirstName.Text = GridUser.Rows[rowindex].Cells["First_name"].Value.ToString();
                txtLastName.Text = GridUser.Rows[rowindex].Cells["Last_name"].Value.ToString();
                txtUserName.Text = GridUser.Rows[rowindex].Cells["User_name"].Value.ToString();
                txtFatherName.Text = GridUser.Rows[rowindex].Cells["Father_name"].Value.ToString();
                txtCnic.Text = GridUser.Rows[rowindex].Cells["Cnic"].Value.ToString();
                txtEmail.Text = GridUser.Rows[rowindex].Cells["Email"].Value.ToString();
                txtPassword.Text = GridUser.Rows[rowindex].Cells["password"].Value.ToString();
                txtContact.Text = GridUser.Rows[rowindex].Cells["contact"].Value.ToString();
                txtPhone.Text = GridUser.Rows[rowindex].Cells["Phone"].Value.ToString();
                //
                CountryID = Guid.Parse(GridUser.Rows[rowindex].Cells["country_id"].Value.ToString());
                cmbCountry.SelectedValue = CountryID;
                stateID = Guid.Parse(GridUser.Rows[rowindex].Cells["state_id"].Value.ToString());
                cmbState.SelectedValue = stateID;
                CityID = Guid.Parse(GridUser.Rows[rowindex].Cells["city_id"].Value.ToString());
                cmbCity.SelectedValue = CityID;
                txtAdress.Text = GridUser.Rows[rowindex].Cells["Adress"].Value.ToString();
                cmbGender.Text = GridUser.Rows[rowindex].Cells["Gender"].Value.ToString();
                //                cmbAccountType.Text = GridUser.Rows[rowindex].Cells["Account_type"].Value.ToString();

                btnSave.Text = "Update";

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Supplier"])
            {
                searchUserPersonal();
            }

            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Contacts"])
            {
                searchContact();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Supplier"])
            {
                deleteUserPersonal();
            }

            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Contacts"])
            {
                deleteContact();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Supplier"])
            {
                saveUserPersonal();
            }

            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Contacts"])
            {
                clearAllContacts();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Supplier"])
            {
                saveUserPersonal();
            }

            if (mtcSupplier.SelectedTab == mtcSupplier.TabPages["Contacts"])
            {
                saveContact();
            }
        }

        private void cmbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CountryID = Guid.Parse(cmbCountry.SelectedValue.ToString());
            //   int.TryParse(cmbCountry.SelectedValue.ToString(), out CountryID);
            loadCbxStates();
        }

        private void cmbState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            stateID = Guid.Parse(cmbState.SelectedValue.ToString());
            //  int.TryParse(cmbState.SelectedValue.ToString(), out stateID);
            loadCbxCities();
        }

        private void cmbCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CityID = Guid.Parse(cmbCity.SelectedValue.ToString());
            cmbCity.SelectedValue = CityID;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FormMain.loadBackForm();
           // container.Controls.Clear();
           // ucInventory form = new ucInventory();
           // form.Dock = DockStyle.Fill;
           // container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }
    }
}
