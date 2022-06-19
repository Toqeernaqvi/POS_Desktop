using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SicParvisMagna.Library;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using BasicCRUD.Controllers;

namespace SicParvisMagna.Forms
{
    public partial class ucFormLoadMarksheet : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid Id = Guid.Empty;
        private Guid SectionID = Guid.Empty;
        private Guid ClassID = Guid.Empty;
        private Guid SubId = Guid.Empty;
        private Guid SessionId = Guid.Empty;
        // private Guid UserID = Guid.Empty;
        private Guid testCATid = Guid.Empty;
        private Guid testGENid = Guid.Empty;
        private Guid teachID = Guid.Empty;
        private bool testHidden = false;
        private FormMain parentFormMain;
        private Guid OrgID = Guid.Empty;
        private static string pgURL;
        private static bool PerAdd;
        private static bool PerDel;
        private static bool PerEdit;
        private static string AccountType;
    
     //   public bool PerView;
        private Guid BranchID = Guid.Empty;

        public ucFormLoadMarksheet(FormMain parentFormMain)
        {
            InitializeComponent();
            Loadallclass();
            LoadSession();

            this.parentFormMain = parentFormMain;
        }
        private void Loadtestcat()
        {
            test_catDAL objDAL = new test_catDAL();
            test_catBAL objBAL = new test_catBAL();
            //  objBAL.branchid = BranchID;
            gridloadMarksheet.DataSource = objDAL.LoadAll();



        }
        private void LoadGenetest()
        {
            test_genDAL objDAL = new test_genDAL();
            test_genBAL objBAL = new test_genBAL();
            //  objBAL.branchid = BranchID;
            gridloadMarksheet.DataSource = objDAL.LoadbyTestCAT(objBAL);

        }

        private void LoadAllTeachers()
        {
            //// This line is stopping Teachers from loading when adding marks for new class/section. replace with load all teachers temporarily 
            teachersDAL objDAL = new teachersDAL();

            teachersBAL objBAL = new teachersBAL();
            gridloadMarksheet.DataSource = objDAL.LoadAll();

        }
        private void LoadSubjects()
        {
            SubjectDAL objDAL = new SubjectDAL();
            SubjectBAL objBAL = new SubjectBAL();
            objBAL.branchid = BranchID;
            cmb_sub.DataSource = objDAL.LoadByBranch(objBAL);

            cmb_sub.ValueMember = "id";
            cmb_sub.DisplayMember = "title";
            cmb_sub.SelectedIndex = -1;

        }
        private void LoadSection()
        {
            AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
            AcademicsSectionBAL objBAL = new AcademicsSectionBAL();
            objBAL.branchid = BranchID;
            cmb_section.DataSource = objDAL.LoadByBranch(objBAL);

            cmb_section.ValueMember = "id";
            cmb_section.DisplayMember = "title";
            cmb_section.SelectedIndex = -1;


        }

        private void LoadSession()
        {
            SessionDAL objDAL = new SessionDAL();
            SessionBAL objBAL = new SessionBAL();
            objBAL.BranchId = BranchID;
            cmb_session.DataSource = objDAL.LoadByBranch(objBAL);

            cmb_session.ValueMember = "Session_id";
            cmb_session.DisplayMember = "Session_Name";
            cmb_session.SelectedIndex = -1;


        }

        private void LoadCmbOrg()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;
        }

        // 2;// BranchID;

        private void LoadCmbOrgBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();
            obj.Parent_id = OrgID;
            cmbOrganizationBranch.DataSource = objDAL.LoadBranch(obj);
            cmbOrganizationBranch.ValueMember = "Organization_id";
            cmbOrganizationBranch.DisplayMember = "Title";
            cmbOrganizationBranch.SelectedIndex = -1;
        }


        private void Loadallclass()
        {
            ClassDAL objDAL = new ClassDAL();
            ClassBAL objBAL = new ClassBAL();
            objBAL.branchid = BranchID;
         //   comboBox_class.DataSource = objDAL.LoadbyBranch(objBAL);
            comboBox_class.ValueMember = "id";
            comboBox_class.DisplayMember = "title";
            comboBox_class.SelectedIndex = -1;
        }


        private void searchExistingTest()
        {
            if (ValidateForm())
            {
                Result_DAL objdal = new Result_DAL();
                DataTable dt = objdal.getExistingTest(SessionId, ClassID, SectionID, SubId);
                if (dt.Rows.Count > 0)
                {
                    gridloadMarksheet.DataSource = dt;

                    gridloadMarksheet.Columns["class_id"].Visible = false;
                    gridloadMarksheet.Columns["section_id"].Visible = false;
                    gridloadMarksheet.Columns["session_id"].Visible = false;
                    gridloadMarksheet.Columns["subject_id"].Visible = false;
                    gridloadMarksheet.Columns["test_cat_id"].Visible = false;
                    gridloadMarksheet.Columns["test_id"].Visible = false;

                }
                else
                {
                    //.Text = "No Records Found";
                    gridloadMarksheet.DataSource = null;
                }
            }
        }

        private void Loadsubjectbyb_c()
        {
            //MessageBox.Show(BranchID.ToString());
            var objDAL = new SubjectDAL();
            var objBal = new SubjectBAL();
            objBal.classid = ClassID;
            cmb_sub.DataSource = objDAL.LoadByBranch(objBal);
            cmb_sub.ValueMember = "id";
            cmb_sub.DisplayMember = "title";
            cmb_sub.SelectedIndex = -1;
        }


       

        private bool ValidateForm()
        {
            bool validated = true;


            //For CityName


            if (cmb_session.SelectedIndex < 0)
            {
                lblError_session.Text += "* Required!";
                validated = false;
            }
            else
            {
                lblError_session.Text = "";
            }


            if (cmb_section.SelectedIndex < 0)
            {
                LblError_section.Text += "* Required!";
                validated = false;
            }
            else
            {
                LblError_section.Text = "";
            }


            if (cmbOrganization.SelectedIndex < 0)
            {
                lblError_Org.Text += "* Required!";
                validated = false;
            }
            else
            {
                lblError_Org.Text = "";
            }


            if (cmbOrganizationBranch.SelectedIndex < 0)
            {
                lblError_Branch.Text += "* Required!";
                validated = false;
            }
            else
            {
                lblError_Branch.Text = "";
            }

            //
            if (comboBox_class.SelectedIndex < 0)
            {
                lblError_Class.Text += "* Required!";
                validated = false;
            }
            else
            {
                lblError_Class.Text = "";
            }


            if (cmb_sub.SelectedIndex < 0)
            {
                LblError_sub.Text += "* Required!";
                validated = false;
            }
            else
            {
                LblError_sub.Text = "";
            }


            //====================================================

            return validated;
        }

        private void comboBox_class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClassID = Guid.Parse(comboBox_class.SelectedValue.ToString());
            // LoadSection();
        }

        private void combo_Branch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
            Loadallclass();
            LoadSection();
            LoadSession();
            LoadSubjects();
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());

            LoadCmbOrgBranch();
        }

        private void cmb_session_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SessionId = Guid.Parse(cmb_session.SelectedValue.ToString());
        }

        private void cmb_section_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SectionID = Guid.Parse(cmb_section.SelectedValue.ToString());
            //   LoadSession();
        }

        private void cmb_sub_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SubId = Guid.Parse(cmb_sub.SelectedValue.ToString());

            searchExistingTest();
            //  searchExistingTest();
        }

        private void gridloadMarksheet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pgURL = "Marksheets";
            PermissionDAL.EditButtonPermission(Program.User_id, pgURL, PerEdit);
            //for Account Type
            try { PerEdit = Convert.ToBoolean(PermissionDAL.EditButtonPermission(Program.User_id, pgURL, PerEdit).Rows[0]["Account_type"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }

            if (PerEdit = true)
            {
                int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                //Id = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["id"].Value.ToString());
                OrgID = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["OrganizationId"].Value.ToString());
                cmbOrganization.SelectedValue = OrgID;

                LoadCmbOrgBranch();
                BranchID = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["branchid"].Value.ToString());
                //     cmbOrganizationBranch.SelectedValue = BranchID;

                SectionID = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["section_id"].Value.ToString());
                SessionId = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["session_id"].Value.ToString());
                Loadallclass();
                ClassID = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["class_id"].Value.ToString());
                comboBox_class.SelectedValue = ClassID;
                LoadSubjects();

                SubId = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["subject_id"].Value.ToString());

                testCATid = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["test_cat_id"].Value.ToString());

                testGENid = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["test_id"].Value.ToString());

                //teachID = Guid.Parse(gridloadMarksheet.Rows[rowindex].Cells["teacher_id"].Value.ToString());

                // UserID = Guid.Parse(gridSection.Rows[rowindex].Cells["userid"].Value.ToString());
                // int.TryParse(gridSection.Rows[rowindex].Cells["status"].Value.ToString(), out status);
                try
                {
                    
                        parentFormMain.loadMarksheetManageForm(ClassID, SectionID, "Update", SessionId, SubId, OrgID, BranchID, testCATid, testGENid);
                        // ucFormManageMarkSheet mms = new ucFormManageMarkSheet(ClassID, SectionID, "Update", SessionId, SubId, OrgID, BranchID, testCATid, testGENid);//
                        //     mms.Show();
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                ValidateForm();
            }
            }
            else
            {
                MessageBox.Show("you are not authorized!!");
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            pgURL = "Marksheets";
            PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
            
            try { PerAdd = Convert.ToBoolean(PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd).Rows[0]["PerAdd"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerAdd = true)
            {
                if (ValidateForm())
                {
                    SectionID = Guid.Parse(cmb_section.SelectedValue.ToString());
                    ClassID = Guid.Parse(comboBox_class.SelectedValue.ToString());
                    Result_DAL objdal = new Result_DAL();
                    parentFormMain.LoadEditorMarksheetform(ClassID, SectionID, "New", SessionId, SubId, OrgID, BranchID, testCATid, testGENid);//

                }
            }
            //if (ValidateForm())
            //{
            //    SectionID = Guid.Parse(cmb_section.SelectedValue.ToString());
            //    ClassID = Guid.Parse(comboBox_class.SelectedValue.ToString());
            //    Result_DAL objdal = new Result_DAL();
            //    parentFormMain.LoadEditorMarksheetform(ClassID, SectionID, "New", SessionId, SubId, OrgID, BranchID, testCATid, testGENid);//

            //}
            else
            {
                MessageBox.Show("You are unauthorized");
            }
        }

        private void ucFormLoadMarksheet_Load(object sender, EventArgs e)
        {
            LoadCmbOrg();
            pgURL = "Marksheets";
            PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
            //for Account Type
            try { AccountType = (PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Account_type"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }

            if (AccountType == "Super Admin")
            {
                //

            }

            if (AccountType == "Branch Admin")
            {
                //for  Branch Admin
                try { OrgID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                LoadCmbOrgBranch();
                //
               pnlcmbOrganization.Hide();
            }

            if (AccountType == "Operator")
            {
                try { OrgID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                try { BranchID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Branch_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
               // loadDepartment();
                //
                pnlcmbOrganization.Hide();
                pnlcmbBranch.Hide();
            }

            try { PerAdd = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["PerAdd"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerAdd == true)
            {
                //btnSave.Enabled = true;
            }
            else
            {
                // btnSave.Hide();
            }

            pgURL = "Marksheets";
            PermissionDAL.DeleteButtonPermission(Program.User_id, pgURL, PerDel);
            try { PerDel = Convert.ToBoolean(PermissionDAL.DeleteButtonPermission(Program.User_id, pgURL, PerDel).Rows[0]["PerDel"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerDel == true)
            {
                // btnDelete.Enabled = true;
            }
            else
            {
                // btnDelete.Hide();
            }



        }
    }
}
