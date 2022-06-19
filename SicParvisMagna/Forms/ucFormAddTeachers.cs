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
    public partial class ucFormAddTeachers : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private string filepath;
        private string appPath;

        // private Guid stuID = Guid.Empty;
        // private Guid CountryID = Guid.Empty;
        //private Guid stateID = Guid.Empty;
        //private Guid CityID = Guid.Empty;
        //   private Guid AreaID = Guid.Empty;
        private Guid teachID = Guid.Empty;
        private Guid OrgID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        //  private Guid sessionid = Guid.Empty;
        // private Guid sectionid = Guid.Empty;
        //private Guid subjectid = Guid.Empty;
        //private Guid classid = Guid.Empty;

        public ucFormAddTeachers()
        {
            InitializeComponent();
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\TeacherImages\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
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

        private void LoadAllTeachers()
        {
            //// This line is stopping Teachers from loading when adding marks for new class/section. replace with load all teachers temporarily 
            teachersDAL objDAL = new teachersDAL();
            teachersBAL objBAL = new teachersBAL();
            objBAL.branchid = BranchID;
            gridTeachers.DataSource = objDAL.LoadByBranch(objBAL);

        }

        public void ClearPartially()
        {


            // status = "";


            //  fee = Guid.Empty;
            //BranchID = Guid.Empty;
            OrgID = Guid.Empty;

            filepath = string.Empty;
            DegreePicBox.Image = null;
            lblErrorFirstName.Text = "";

            lblError_father.Text = "";
            lblError_Org.Text = "";
            lblError_Branch.Text = "";

            txt_father.Text = "";
            txtCnic.Text = "";
            txtPhone.Text = "";

            cmbGender.SelectedIndex = -1;

            //  fee = Guid.Empty;
            BranchID = Guid.Empty;

            cmbOrganization.SelectedIndex = -1;

            //   cbx_status.SelectedIndex = -1;
            txtFirstName.Text = "";

            comboBox_branch.SelectedIndex = -1;

            cmbGender.Text = "";
            txtAdress.Text = "";
            dtpDOB.Text = "";

            btnSave.Text = "Save";
        }



        public void ClearAll()
        {


            OrgID = Guid.Empty;

            filepath = string.Empty;
            DegreePicBox.Image = null;
            lblErrorFirstName.Text = "";

            lblError_father.Text = "";
            lblError_Org.Text = "";
            lblError_Branch.Text = "";

            txt_father.Text = "";
            txtCnic.Text = "";
            txtPhone.Text = "";

            cmbGender.SelectedIndex = -1;

            //  fee = Guid.Empty;
            BranchID = Guid.Empty;

            cmbOrganization.SelectedIndex = -1;

            //   cbx_status.SelectedIndex = -1;
            txtFirstName.Text = "";

            comboBox_branch.SelectedIndex = -1;

            cmbGender.Text = "";
            txtAdress.Text = "";
            dtpDOB.Text = "";

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
                teachersBAL objBAL = new teachersBAL();
                teachersDAL objDAL = new teachersDAL();
                objBAL.name = txtFirstName.Text;

                objBAL.fathername = txt_father.Text;

                objBAL.OrganizationId = OrgID;

                objBAL.branchid = BranchID;

                string picname = txtCnic.Text + (".jpg");
                objBAL.img = picname;
                try
                {
                    File.Copy(filepath, appPath + (picname));
                }
                catch { }


                objBAL.status = 1;

                objBAL.cnic = txtCnic.Text;
                objBAL.adress = txtAdress.Text;


                objBAL.mobile = txtPhone.Text;


                objBAL.img = picname;
                objBAL.gender = cmbGender.Text;
                objBAL.d_b = DateTime.Now;






                if (teachID == Guid.Empty)
                {
                    objBAL.Add_by = "user";
                    objBAL.Add_Date = DateTime.Now;


                    //Insert
                    objDAL.Add(objBAL);
                    lblStatus.Text = objBAL.name + " saved successfully";
                }
                else
                {
                    objBAL.id = teachID;

                    objBAL.Edit_By = "editor";
                    objBAL.Edit_Date = DateTime.Now;

                    objDAL.Update(objBAL);
                    lblStatus.Text = objBAL.name + " updated successfully";
                }

                ClearPartially();
                LoadAllTeachers();

                // MessageBox.Show("Done");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (teachID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.teachers ";
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

                gridTeachers.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ucFormAddTeachers_Load(object sender, EventArgs e)
        {
            LoadCmbOrg();

        }
        private void ucAddUsers_Load(object sender, EventArgs e)
        {
          
          //  LoadCmbOrg();
           // ClearAll();
            //  LoadStudent();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (teachID != null)
            {
                teachersBAL objBAL = new teachersBAL();
                teachersDAL objDAL = new teachersDAL();
                objBAL.id = teachID;
                objDAL.Delete(objBAL);

                ClearPartially();
                //   LoadStudent();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                teachID = Guid.Parse(gridTeachers.Rows[rowindex].Cells["id"].Value.ToString());
                OrgID = Guid.Parse(gridTeachers.Rows[rowindex].Cells["OrganizationId"].Value.ToString());
                cmbOrganization.SelectedValue = OrgID;
                LoadCmbOrgBranch();


                BranchID = Guid.Parse(gridTeachers.Rows[rowindex].Cells["branchid"].Value.ToString());
               comboBox_branch.SelectedValue = BranchID;

                txtFirstName.Text = gridTeachers.Rows[rowindex].Cells["name"].Value.ToString();
                txt_father.Text = gridTeachers.Rows[rowindex].Cells["fathername"].Value.ToString();
                txtCnic.Text = gridTeachers.Rows[rowindex].Cells["cnic"].Value.ToString();
                txtPhone.Text = gridTeachers.Rows[rowindex].Cells["mobile"].Value.ToString();
                txtAdress.Text = gridTeachers.Rows[rowindex].Cells["adress"].Value.ToString();
                cmbGender.Text = gridTeachers.Rows[rowindex].Cells["gender"].Value.ToString();
                dtpDOB.Text = gridTeachers.Rows[rowindex].Cells["d_b"].Value.ToString();
                // UserID = Guid.Parse(gridSection.Rows[rowindex].Cells["userid"].Value.ToString());
                // int.TryParse(gridSection.Rows[rowindex].Cells["status"].Value.ToString(), out status);
                
                btnSave.LabelText = "Update";
                Validate();
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
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

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            LoadCmbOrgBranch();
        }

        private void comboBox_branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(comboBox_branch.SelectedValue.ToString());
            LoadAllTeachers();
        }


    }
}
