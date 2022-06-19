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

    
    public partial class ucFormAddStudents : UserControl
    {

        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private string filepath;
        private string appPath;

        private Guid stuID = Guid.Empty;
        private Guid CountryID = Guid.Empty;
        private Guid stateID = Guid.Empty;
        private Guid CityID = Guid.Empty;
        private Guid AreaID = Guid.Empty;
        private Guid OrgID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid sessionid = Guid.Empty;
        private Guid sectionid = Guid.Empty;
        private Guid subjectid = Guid.Empty;
        private Guid classid = Guid.Empty;
     

        public ucFormAddStudents()
        {
            InitializeComponent();
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\StudentImages\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
        }
      
        private void LoadStudent()
        {
            StudentDAL objDAL = new StudentDAL();
            StudentBAL objBAL = new StudentBAL();
            objBAL.branchid = BranchID;
            gridStudent.DataSource = objDAL.LoadByBranch(objBAL);

        }
       
      


        private void LoadCmbOrg()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;
        }


        private void LoadCmbOrgBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();
            obj.Parent_id = OrgID;
            comboBox_branch.DataSource = objDAL.LoadBranch(obj);
            comboBox_branch.ValueMember = "Organization_id";
            comboBox_branch.DisplayMember = "Title";
            comboBox_branch.SelectedIndex = -1;
        }

        private void loadCbxCountries()
        {
            CountryDAL objDAL = new CountryDAL();
            cbx_Country.DataSource = objDAL.LoadAll();
            cbx_Country.ValueMember = "country_id";
            cbx_Country.DisplayMember = "name";
            cbx_Country.SelectedIndex = -1;
        }

        private void loadCbxStates()
        {
            StateDAL objDAL = new StateDAL();
            StateBAL obj = new StateBAL();

            obj.Country_id = CountryID;
            //    obj.Country_id = Convert.ToInt32(cbx_Country.SelectedValue);
            cbx_State.DataSource = objDAL.LoadAll(obj);
            cbx_State.ValueMember = "state_id";
            cbx_State.DisplayMember = "name";
            cbx_State.SelectedIndex = -1;
        }


        private void loadCbxCities()
        {
            CityDAL objDAL = new CityDAL();
            CityBAL obj = new CityBAL();
            obj.State_id = stateID;  //Guid.Parse(cbx_State.SelectedValue.ToString());
                                     //  obj.State_id = Convert.ToInt32(cbx_State.SelectedValue);
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
            cbx_Area.ValueMember = "ID";
            cbx_Area.DisplayMember = "name";
            cbx_Area.DataSource = objDAL.LoadByCity(obj);
            cbx_Area.SelectedIndex = -1;

        }

        private void LoadSection()
        {
            AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
            AcademicsSectionBAL objBAL = new AcademicsSectionBAL();
            objBAL.classid = classid;
            comboBox_section.DataSource = objDAL.LoadByClass(objBAL);
            comboBox_section.ValueMember = "id";
            comboBox_section.DisplayMember = "title";
            comboBox_section.SelectedIndex = -1;

        }


        private void LoadSessions()
        {

            SessionDAL objDAL = new SessionDAL();
            SessionBAL objBAL = new SessionBAL();
            objBAL.BranchId = BranchID;
            comboBox_Session.DataSource = objDAL.LoadByBranch(objBAL);

            comboBox_Session.DataSource = objDAL.LoadAll();
            comboBox_Session.ValueMember = "Session_id";
            comboBox_Session.DisplayMember = "Session_Name";
            comboBox_Session.SelectedIndex = -1;
            
        }

       

        private void LoadClass()
        {
            ClassDAL objDAL = new ClassDAL();
            ClassBAL objBAL = new ClassBAL();
            objBAL.branchid = BranchID;
            comboBox_class.DataSource = objDAL.LoadByBranch(objBAL);
            comboBox_class.ValueMember = "id";
            comboBox_class.DisplayMember = "title";
            comboBox_class.SelectedIndex = -1;
            
        }
        public void ClearPartially()
        {

            stuID = Guid.Empty;
            // status = "";


            //  fee = Guid.Empty;
            //BranchID = Guid.Empty;
            txtFirstName.Text = "";
            txt_father.Text = "";
            txtUserName.Text = "";
            txt_UN.Text = "";
            txt_UFN.Text = "";
            txt_urduAdd.Text = "";
            txt_RegNo.Text = "";
            txt_RollNo.Text = "";
            txt_UN.Text = "";
            txt_urduAdd.Text = "";
            txt_UFN.Text = "";
            txtPhone.Text = "";
            txtCnic.Text="";
            txtAdress.Text = "";
            lblErrorFirstName.Text = "";
            lblErrorUserName.Text = "";
            lblError_father.Text = "";
            lblError_Org.Text = "";
            lblError_Branch.Text = "";
            lblError_country.Text = "";
            lblError_reg.Text = "";
            lblError_roll.Text = "";
            lblError_sect.Text = "";
            lblError_sess.Text = "";
            lbl_levelError.Text = "";
            lblError_AD.Text = "";
            lblStatus.Text = "";
            lblErrorCnic.Text = "";


            cmbOrganization.SelectedIndex = -1;
            comboBox_class.SelectedIndex = -1;
            cbx_Area.SelectedIndex = -1;
            cbx_Country.SelectedIndex = -1;
            cbx_State.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            dtpDOB.Text = "";
            dtp_AD.Text = "";
            DegreePicBox.Image = null;
            txtCnic.Text = "";
            txtPhone.Text = "";
            //     cbx_status.SelectedIndex = -1;
            comboBox_branch.SelectedIndex = -1;
            comboBox_class.SelectedIndex = -1;
            comboBox_section.SelectedIndex = -1;
            comboBox_Session.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            filepath = string.Empty;
            //            cmbOrganization.SelectedIndex = -1;

            btnSave.Text = "Save";
        }



        public void ClearAll()
        {
            
            classid = Guid.Empty;
            OrgID = Guid.Empty;
            sectionid = Guid.Empty;
            subjectid = Guid.Empty;
            sessionid = Guid.Empty;
            CountryID = Guid.Empty;
            CityID = Guid.Empty;
            stateID = Guid.Empty;
            filepath = string.Empty;
            DegreePicBox.Image = null;
            lblErrorFirstName.Text = "";
            lblErrorUserName.Text = "";
            lblError_father.Text = "";
            lblError_Org.Text = "";
            lblError_Branch.Text = "";
            lblError_country.Text = "";
            lblError_reg.Text = "";
            lblError_roll.Text = "";
            lblError_sect.Text = "";
            lblError_sess.Text = "";
            lbl_levelError.Text = "";
            lblError_AD.Text = "";
            txtCnic.Text = "";
            txtPhone.Text = "";
            txt_UN.Text = "";
            txt_UFN.Text = "";
            txt_urduAdd.Text = "";

            txt_urduAdd.Text = "";

            comboBox_class.SelectedIndex = -1;
            comboBox_section.SelectedIndex = -1;
            comboBox_Session.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;

            //  fee = Guid.Empty;
            BranchID = Guid.Empty;
            gridStudent.DataSource = null;    
            cmbOrganization.SelectedIndex = -1;
            comboBox_class.SelectedIndex = -1;
            cbx_Area.SelectedIndex = -1;
            cbx_Country.SelectedIndex = -1;
            cbx_State.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            dtpDOB.Text="";
            dtp_AD.Text = "";
         //   cbx_status.SelectedIndex = -1;
            txtFirstName.Text = "";
            txt_UN.Text = "";
            comboBox_branch.SelectedIndex = -1;
            txtUserName.Text = "";
            txt_RegNo.Text = "";
            txt_RollNo.Text = "";
            cmbGender.Text = "";
            txtAdress.Text = "";
            dtpDOB.Text = "";
            dtp_AD.Text = "";
            btnSave.Text = "Save";
        }


        //LoadAllUsers();

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

            if (!Validation.isAlphaNumeric(txtFirstName.Text))
            {
                lblErrorFirstName.Text += "Name Should be in  Alphabets and Numbers!";
                validated = false;
            }
            else
            {
                lblErrorFirstName.Text = "";
            }
            //====================================================

            //Last Name

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

            if (!Validation.isAlphaNumeric(txtUserName.Text))
            {
                lblErrorUserName.Text += "UserName Should be in  Alphabets and Numbers!";
                validated = false;
            }
            else
            {
                lblErrorUserName.Text = "";
            }
            //====================================================


            //Father Name

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

            //if (!Validation.isCnic(txtCnic.Text))
            //{
            //    if (string.IsNullOrEmpty(txtCnic.Text))
            //        lblErrorCnic.Text += "\n";
            //    lblErrorCnic.Text += "Cnic  Should be numeric!";
            //    validated = false;
            //}
            //else
            //{
            //    lblErrorCnic.Text = "";
            //}
            //====================================================

            //for Email
           
            //====================================================
            //for Password
           
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

        //private void saveUserPersonal()
        //{
        //    UserBAL objBAL = new UserBAL();

        //    if (FormValidation())
        //    {
        //        objBAL.First_name = txtFirstName.Text;

        //        objBAL.User_name = txtUserName.Text;

        //        objBAL.Cnic = txtCnic.Text;




        //        objBAL.Phone = txtPhone.Text;
        //        objBAL.DOB = DateTime.Parse(dtpDOB.Text);
        //        objBAL.Account_type = cmbAccount.Text;
        //        objBAL.country_id = CountryID;
        //        objBAL.city_id = CityID;
        //        objBAL.state_id = stateID;
        //        objBAL.Area_id = AreaID;
        //        objBAL.Timestamp = DateTime.Now;
        //        objBAL.Add_by = "Admin";
        //        objBAL.Status = "Activate";
        //        objBAL.Flag = 1;
        //        objBAL.FirstTimeLogin = 1;
        //        objBAL.Adress = txtAdress.Text;
        //        objBAL.Gender = cmbGender.Text;
        //        objBAL.Organization_id = OrgID;
        //        objBAL.Branch_id = BranchID;
        //        objBAL.Employee_id = Guid.Empty;


        //        //
        //        UserDAL objDAL = new UserDAL();


        //        if (UserID != Guid.Empty)
        //        {
        //            objBAL.User_id = UserID;


        //            objDAL.Update(objBAL);



        //        }
        //        else
        //        {

        //            objDAL.Add(objBAL);
        //        }

        //        clearUserPersonal();

        //    }
        //}




        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())


            {
                StudentBAL objBAL = new StudentBAL();
                StudentDAL objDAL = new StudentDAL();
                objBAL.name = txtFirstName.Text;
                objBAL.urdu_fname = txt_UFN.Text;
                objBAL.fathername = txt_father.Text;

                objBAL.Organization = OrgID;

                objBAL.branchid = BranchID;

                string picname = txtCnic.Text + (".jpg");
                objBAL.img = picname;
                try
                {
                    File.Copy(filepath, appPath + (picname));
                }
                catch { }


                objBAL.status = 1;
                objBAL.urdu_name = txt_UN.Text;
                objBAL.cnic = txtCnic.Text;
                objBAL.address = txtAdress.Text;
                objBAL.addresurdu = txt_urduAdd.Text;

                objBAL.mobile = txtPhone.Text;
             
                objBAL.country_id = CountryID;
            
                objBAL.state_id = stateID;
                objBAL.city_id = CityID;
                objBAL.area_id = AreaID;
                objBAL.section = sectionid;
                objBAL.Session_id = sessionid;
                objBAL.subjects = subjectid;
                objBAL.classid = classid;
                objBAL.img = picname;
                objBAL.gender = cmbGender.Text;
                objBAL.d_b = DateTime.Now;
                objBAL.d_a = DateTime.Now;
                objBAL.rollno = txt_RollNo.Text;
                objBAL.registration = txt_RegNo.Text;


 



                if (stuID == Guid.Empty)
                {
                    objBAL.Add_by = Guid.Empty;
                    objBAL.Add_Date = DateTime.Today;


                    //Insert
                    objDAL.Add(objBAL);
                    lblStatus.Text = objBAL.name + " saved successfully";
                }
                else
                {
                    objBAL.id = stuID;

                    objBAL.Edit_By = Guid.Empty;
                    objBAL.Edit_Date = DateTime.Today;
                    
                    objDAL.Update(objBAL);
                    lblStatus.Text = objBAL.name + " updated successfully";
                }

                ClearPartially();
                LoadStudent();

                // MessageBox.Show("Done");
            }
        


        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (stuID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.students ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtFirstName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   name like '%" + txtFirstName.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(cmbOrganization.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   OrganizationId like '%" + cmbOrganization.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
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

                gridStudent.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void GridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {

            CountryID = Guid.Parse(cbx_Country.SelectedValue.ToString());
            loadCbxStates();

        }

        private void cmbState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            stateID = Guid.Parse(cbx_State.SelectedValue.ToString());
            loadCbxCities();
        }

        private void cmbCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CityID = Guid.Parse(cmbCity.SelectedValue.ToString());
            loadCbxArea();
        }

        private void cmbAccountType_SelectionChangeCommitted(object sender, EventArgs e)
        {
          

        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void EnableTab(TabPage page, bool enable)
        { 
}
            
        /////////////////////////////////////////////
        private void ucAddUsers_Load(object sender, EventArgs e)
        {
            ClearAll();
            LoadCmbOrg();
            loadCbxArea();
            loadCbxCountries();
            loadCbxStates();
            LoadSection();
            LoadClass();
            LoadSessions();
          //  LoadStudent();


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
           
        }

        private void gridUserEducation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
  //          DegreePicBox.Image = null;
//
        }

        private void btnAddExperincePic_Click(object sender, EventArgs e)
        {
            
     

        }

        private void btnRemoveExperiencePic_Click(object sender, EventArgs e)
        {
//            experiencePicbox.Image = null;

        }
       
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

     
        private void gridUserExperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    for (int x = 0; x < gridAll.Rows.Count; x++)
            //    {
            //        if (Convert.ToBoolean(gridAll.Rows[x].Cells["Select"].Value))
            //        {
            //            DataGridViewRow row = (DataGridViewRow)gridAll.Rows[x].Clone();

            //            for (int y = 0; y < gridAll.Rows[x].Cells.Count; y++)
            //            {
            //                row.Cells[y].Value = gridAll.Rows[x].Cells[y].Value;
            //            }

            //            gridSelected.Rows.Add(row);//add
            //            gridAll.Rows.RemoveAt(x);
            //            x--;
            //        }
            //    }
            //}
            //catch (Exception e1)
            //{
            //    MessageBox.Show(e1.Message);
            //}
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    for (int x = 0; x < gridSelected.Rows.Count; x++)
            //    {
            //        if (Convert.ToBoolean(gridSelected.Rows[x].Cells["Select"].Value))
            //        {
            //            DataGridViewRow row = (DataGridViewRow)gridSelected.Rows[x].Clone();

            //            for (int y = 0; y < gridSelected.Rows[x].Cells.Count; y++)
            //            {
            //                row.Cells[y].Value = gridSelected.Rows[x].Cells[y].Value;
            //            }

            //       //     gridAll.Rows.Add(row);
            //           // gridSelected.Rows.RemoveAt(x);
            //            x--;
            //        }
            //    }
            //}
            //catch (Exception e1)
            //{
            //    MessageBox.Show(e1.Message);
            //}
        }
      
        private void tabControlUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //            if (tabControl.SelectedTab == tabControl.TabPages[0])
            //                do something...
            //if (tabControl.SelectedTab == tabControl.TabPages[1])
            //                do something else...
            //if (tabControl.SelectedTab == tabControl.TabPages[2])
            //                do something else...

          
        }

   

        private void gridUserExperience_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gridUserEducation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperience_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void gridUserExperience_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperience_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
        }

        private void gridUserExperience_DataError_2(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void cmbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        
 

        private void cmbArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AreaID = Guid.Parse(cbx_Area.SelectedValue.ToString());
        }

        private void cmbOrganization_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            LoadCmbOrgBranch();
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(comboBox_branch.SelectedValue.ToString());
            LoadClass();
            LoadStudent();
        }

        private void btnTabClear_Click(object sender, EventArgs e)
        {
           
       

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (stuID!=null)
            {
                StudentBAL objBAL = new StudentBAL();
                StudentDAL objDAL = new StudentDAL();
                objBAL.id = stuID;
                objDAL.Delete(objBAL);

                ClearPartially();
             //   LoadStudent();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void tabUserPersonal_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrorFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblSectionTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrorLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrorUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrorFatherName_Click(object sender, EventArgs e)
        {

        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorCnic_Click(object sender, EventArgs e)
        {

        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrorEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrorPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorRetypePassword_Click(object sender, EventArgs e)
        {

        }

        private void txtRetypePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrorPhone_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel21_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel23_Click(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CountryID = Guid.Parse(cbx_Country.SelectedValue.ToString());
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel24_Click(object sender, EventArgs e)
        {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel27_Click(object sender, EventArgs e)
        {

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel29_Click(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel30_Click(object sender, EventArgs e)
        {

        }

        private void cmbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
//OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  BranchID = Guid.Parse(comboBox_branch.SelectedValue.ToString());
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorAdress_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel33_Click(object sender, EventArgs e)
        {

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void GridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)

            {
                string nm = gridStudent.Rows[rowindex].Cells["img"].Value.ToString();
                filepath = (appPath + (nm));
                DegreePicBox.ImageLocation = filepath;

                stuID = Guid.Parse(gridStudent.Rows[rowindex].Cells["id"].Value.ToString());
                OrgID = Guid.Parse(gridStudent.Rows[rowindex].Cells["OrganizationId"].Value.ToString());
                cmbOrganization.SelectedValue = OrgID;

                //  int.TryParse(gridDomain.Rows[rowindex].Cells["Organization_id"].Value.ToString(), out OrgID);
                // cmbOrganization.SelectedValue = OrgID;
                LoadCmbOrgBranch();
                BranchID = Guid.Parse(gridStudent.Rows[rowindex].Cells["branchid"].Value.ToString());
                comboBox_branch.SelectedValue = BranchID;


                LoadClass();
                LoadSection();
                LoadSessions();                
                // int.TryParse(gridDomain.Rows[rowindex].Cells["Parent_id"].Value.ToString(), out BranchID);
                // comboBox_branch.SelectedValue = BranchID;

                classid = Guid.Parse(gridStudent.Rows[rowindex].Cells["class"].Value.ToString());
                comboBox_class.SelectedValue = classid;

                txtFirstName.Text = gridStudent.Rows[rowindex].Cells["name"].Value.ToString();
                txt_UN.Text = gridStudent.Rows[rowindex].Cells["urdu_name"].Value.ToString();
                txt_UFN.Text = gridStudent.Rows[rowindex].Cells["urdu_fname"].Value.ToString();
                txt_father.Text = gridStudent.Rows[rowindex].Cells["fathername"].Value.ToString();
                txtUserName.Text = gridStudent.Rows[rowindex].Cells["name"].Value.ToString();//Baad mai change krna hai
                txtPhone.Text = gridStudent.Rows[rowindex].Cells["mobile"].Value.ToString();
                txtCnic.Text = gridStudent.Rows[rowindex].Cells["cnic"].Value.ToString();
                //txt_RegNo.Text = gridStudent.Rows[rowindex].Cells["registration"].Value.ToString();
                //txt_RollNo.Text = gridStudent.Rows[rowindex].Cells["rollno"].Value.ToString();
                txtAdress.Text = gridStudent.Rows[rowindex].Cells["address"].Value.ToString();
                cmbGender.Text = gridStudent.Rows[rowindex].Cells["gender"].Value.ToString();
                txt_urduAdd.Text= gridStudent.Rows[rowindex].Cells["addresurdu"].Value.ToString();
                txt_RollNo.Text = gridStudent.Rows[rowindex].Cells["rollno"].Value.ToString();
                txt_RegNo.Text = gridStudent.Rows[rowindex].Cells["registration"].Value.ToString();

                LoadSection();
                sectionid = Guid.Parse(gridStudent.Rows[rowindex].Cells["section"].Value.ToString());
                comboBox_section.SelectedValue = sectionid;

               
                LoadSessions();
                sessionid = Guid.Parse(gridStudent.Rows[rowindex].Cells["session"].Value.ToString());
                comboBox_Session.SelectedValue = sessionid;

                subjectid = Guid.Parse(gridStudent.Rows[rowindex].Cells["subjects"].Value.ToString());
                
                loadCbxCountries();
                CountryID = Guid.Parse(gridStudent.Rows[rowindex].Cells["country_id"].Value.ToString());
                cbx_Country.SelectedValue = CountryID;
                
                loadCbxStates();
                stateID = Guid.Parse(gridStudent.Rows[rowindex].Cells["state_id"].Value.ToString());
                cbx_State.SelectedValue = stateID;

                loadCbxCities();
                CityID = Guid.Parse(gridStudent.Rows[rowindex].Cells["city_id"].Value.ToString());
                cmbCity.SelectedValue = CityID;

                loadCbxArea();
                AreaID = Guid.Parse(gridStudent.Rows[rowindex].Cells["area_id"].Value.ToString());
                cbx_Area.SelectedValue = AreaID;


                dtpDOB.Text = gridStudent.Rows[rowindex].Cells["d_b"].Value.ToString();
                dtp_AD.Text = gridStudent.Rows[rowindex].Cells["d_a"].Value.ToString();






                // BranchID = Guid.Parse(gridClass.Rows[rowindex].Cells["branchid"].Value.ToString());
                // UserID = Guid.Parse(gridStudent.Rows[rowindex].Cells["userid"].Value.ToString());
                //  int.TryParse(gridClass.Rows[rowindex].Cells["status"].Value.ToString(), out status);


                //  cmbOrganization.SelectedValue = BranchID;

                btnSave.LabelText = "Update";


                FormValidation();
            }
        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_section_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_Session_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbx_Country_MarginChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            classid = Guid.Parse(comboBox_class.SelectedValue.ToString());
            LoadSection();
           
        }

        private void comboBox_section_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sectionid = Guid.Parse(comboBox_section.SelectedValue.ToString());
            LoadSessions();

        }

        private void comboBox_Session_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            sessionid = Guid.Parse(comboBox_Session.SelectedValue.ToString());
           
            
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddPic_Click_1(object sender, EventArgs e)
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var iName = opFile.SafeFileName; //Image Name(I Don't Use this name instead 'name')
                    filepath = opFile.FileName; //File path //Make "<WorkOrderNumber>.Jpg"
                    /*File.Copy(filepath, appPath + (iName));   */ //Copy Image to Path
                    // File.Delete(/*filepath, */appPath + ("1234.jpg")); //Delete Image from Path
                    DegreePicBox.ImageLocation = filepath; //Show Image via Dialogbox
                    // string NPath=appPath+name;                         //Exact Path
                    //pictureBox2.Image = Image.FromFile(NPath);         //Get image from path and display in Picture Box
                    if (btnSave.Text == "     Update")
                    {
                     //   utcount = 100;
                    }
                }
                catch (Exception exp)
                {
                 //   lblError_PIC.Text = "Unable to open file " + exp.Message;
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void txt_UFN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

