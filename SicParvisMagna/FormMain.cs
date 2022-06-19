 
using SicParvisMagna.Forms;
using SicParvisMagna.Reports.UserControls;
using SicParvisMagna.Forms.Hospital;
using SicParvisMagna.Forms.Hospital.Lab;
using SicParvisMagna.Forms.Hospital.Medicine;
using SicParvisMagna.Forms.Hospital.Parties;
using SicParvisMagna.Forms.Hospital.Parties.Party_invoice;
using SicParvisMagna.Forms.Hospital.Patient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using BasicCRUD.Models;
using BasicCRUD.Controllers;
using SicParvisMagna.Library;
using SicParvisMagna.Forms.Inventory;
using SicParvisMagna.Forms.ChartOfAccounts;
using SicParvisMagna.Forms.PointOfSale;
using SicParvisMagna.Forms.Attendance;

namespace SicParvisMagna
{
    public partial class FormMain : Form
    {

      
        //public static string username ;
        private SqlConnection con = new SQLCon().getCon();
        private static SqlConnection staticcon;
        private SqlCommand cmd = new SqlCommand();
        private static SqlCommand staticcmd;

        private Guid userid;
        private string username;
        public static Panel formContainer;
        public Label formHeadingNonStatic;
        public static Label formHeading;
        public static bool PerView;
        public static string pgURL;
        public FormMain formMain
        {
            get
            {
                return this;
            }
        }
        public FormMain(String username, Guid userid)
        {
            InitializeComponent();
            this.username = username;
            this.userid = userid;
            lblMainHeader.Text = username;
            formContainer = this.container;
            staticcon = new SQLCon().getCon();
            staticcmd = new SqlCommand();
            formHeading = lblFormHeading;
            formHeadingNonStatic = lblFormHeading;
        }



        public static DataTable Permission(Guid userid, string pgURL, Boolean PerView)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                staticcon.Open();
                staticcmd.Connection = staticcon;
                staticcmd.CommandType = CommandType.StoredProcedure;
                staticcmd.CommandText = "sp_Permission_LoadPagesPermission";
                staticcmd.Parameters.Clear();
                staticcmd.Parameters.AddWithValue("@Userid", userid);
                staticcmd.Parameters.AddWithValue("@pgURL", pgURL);
                staticcmd.Parameters.AddWithValue("@PerView", PerView);
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




        public static void loadClassform()
        {
            
                formContainer.Controls.Clear();
                ucAddClasses form = new ucAddClasses();

                formHeading.Text = "Manage Classes";
                form.Dock = DockStyle.Fill;

                formContainer.Controls.Add(form);
            
        }

        public static void loadPromote_Studentform()
        {

            formContainer.Controls.Clear();
            //FormPromoteStud form = new FormPromoteStud();

            //formHeading.Text = "Manage Promotion";
            //form.Dock = DockStyle.Fill;

            //formContainer.Controls.Add(form);

        }
        public static void loadTeachersform()
        {
            formContainer.Controls.Clear();
            ucFormAddTeachers form = new ucFormAddTeachers();

            formHeading.Text = "Manage Teachers";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadTestCatform()
        {
            formContainer.Controls.Clear();
            ucFormTestCat form = new ucFormTestCat();

            formHeading.Text = "Manage Test Categories";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadTestGenform()
        {
            formContainer.Controls.Clear();
            ucFormTestGen form = new ucFormTestGen();

            formHeading.Text = "Manage Test Generate";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        public void loadMarksheetLoadForm()
        {
            formContainer.Controls.Clear();
            ucFormLoadMarksheet form = new ucFormLoadMarksheet(this);

          //  formHeading.Text = "Marksheet";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadMarksheetManageForm(Guid ClsID, Guid sctID, string det, Guid SessionID, Guid SubjectID, Guid orgid, Guid brch_id, Guid tstCATid, Guid tstGENid)
        {
            formContainer.Controls.Clear();
            ucFormManageMarksheet form = new ucFormManageMarksheet(ClsID, sctID, det, SessionID, SubjectID, orgid, brch_id, tstCATid, tstGENid, this);

          //  formHeading.Text = "Marksheet Manage";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        //public void loadMrksheetback()
        //{

        //    formContainer.Controls.Clear();
        //    ucFormLoadMarksheet form = new ucFormLoadMarksheet(this);


        //    form.Dock = DockStyle.Fill;

        //    formContainer.Controls.Add(form);
        //    formHeading.Text = "Marksheet Manage";
        //}
        public void LoadEditorMarksheetform(Guid ClassID, Guid SectionID, string status, Guid SessionId, Guid SubId, Guid OrgID, Guid BranchID, Guid testCATid, Guid testGENid)
        {
            formContainer.Controls.Clear();
            ucFormManageMarksheet form = new ucFormManageMarksheet(ClassID, SectionID, status, SessionId, SubId, OrgID, BranchID, testCATid, testGENid, this);

            //formHeading.Text = "Marksheet";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadStudentForm()
        {

            formContainer.Controls.Clear();
            ucFormAddStudents form = new ucFormAddStudents();

            formHeading.Text = "Manage Students";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);

        }
                        
        public static void loadCommentForm(Guid IssueId)
        {
            formContainer.Controls.Clear();
            ucComments form = new ucComments();

            formHeading.Text = "Manage Comments";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        public void AccessDenied()
        {
            container.Controls.Clear();
            ucAccessDenied form = new ucAccessDenied();

            //  formHeading.Text = "Permission Denied";
            form.Dock = DockStyle.Fill;

            container.Controls.Add(form);
        }


        public static void loadSectionform()
        {
            formContainer.Controls.Clear();
            ucFormSection form = new ucFormSection();

            formHeading.Text = "Manage Sections";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadSessionform()
        {
            formContainer.Controls.Clear();
            ucFormSession form = new ucFormSession();

            formHeading.Text = "Manage Sessions";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }


        public static void loadSubjectform()
        {
            formContainer.Controls.Clear();
            ucFormSubjects form = new ucFormSubjects();

            formHeading.Text = "Manage Subjects";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        public static void loadIssueform()
        {
            formContainer.Controls.Clear();
            ucAddIssues form = new ucAddIssues();

            formHeading.Text = "Manage Issues";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        public static void loadIssueListingForm()
        {
            formContainer.Controls.Clear();
            ucIssueListing form = new ucIssueListing();

            formHeading.Text = "Listing";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        
        public  void loadCityForm()
        {
            formContainer.Controls.Clear();
            ucAddCity form = new ucAddCity();

            //formHeading.Text = "Manage Cities";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadCountryForm()
        {
            formContainer.Controls.Clear();
            ucAddCountry form = new ucAddCountry();
            form.Dock = DockStyle.Fill;
            //formHeading.Text = "Manage Country";
            formContainer.Controls.Add(form);
        }
        public static void loadReportAttendence()
        {
            formContainer.Controls.Clear();
            reportMultipleAttendence form = new reportMultipleAttendence();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Reports";
            formContainer.Controls.Add(form);
        }
        public static void loadReportMonthlyAttendence()
        {
            formContainer.Controls.Clear();
            reportMonthlyAttendence form = new reportMonthlyAttendence();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Reports";
            formContainer.Controls.Add(form);
        }
        public static void loadReportMonthlyAttendencePercentage()
        {
            formContainer.Controls.Clear();
            reportMonthlyAttendencePercentage form = new reportMonthlyAttendencePercentage();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Reports";
            formContainer.Controls.Add(form);
        }

        public static void loadReportMonthlyAttendence2()
        {
            formContainer.Controls.Clear();
            reportMonthlyAttendence2 form = new reportMonthlyAttendence2();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Reports";
            formContainer.Controls.Add(form);
        }
        
        public static void ManageReports()
        {
            formContainer.Controls.Clear();
            ucManageReports form = new ucManageReports();
            form.Dock = DockStyle.Fill;
            formHeading.Text = "Manage Reports";
            formContainer.Controls.Add(form);
        }
        public  void loadStateForm()
        {
            formContainer.Controls.Clear();
           ucAddState form = new ucAddState();
            //formHeading.Text = "Manage States";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public  void loadAreaForm()
        {
            formContainer.Controls.Clear();
            ucAddArea form = new ucAddArea();
           // formHeading.Text = "Manage Areas";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public  void loadOrganizationForm()
        {
            formContainer.Controls.Clear();
           ucAddOrganization form = new ucAddOrganization();
           // formHeading.Text = "Manage Organizations";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public  void loadBranchForm()
        {
            formContainer.Controls.Clear();
            ucAddBranch form = new ucAddBranch();
            //formHeading.Text = "Manage  Branches";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public  void loadDomainForm()
        {
            formContainer.Controls.Clear();
            ucAddDomain form = new ucAddDomain();
           // formHeading.Text = "Manage  Domains";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public  void loadDepartmentForm()
        {
            formContainer.Controls.Clear();
            ucAddDepartment form = new ucAddDepartment();
            //formHeading.Text = "Manage  Departments";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadOfficeForm()
        {
            formContainer.Controls.Clear();
            ucAddOffice form = new ucAddOffice();
            //formHeading.Text = "Manage  Offices";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public  void loadSectionForm()
        {
            formContainer.Controls.Clear();
            ucAddSection form = new ucAddSection();
            //formHeading.Text = "Manage  Sections";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadPermissionForm()
        {
            formContainer.Controls.Clear();
            ucAddPermission form = new ucAddPermission();
            formHeading.Text = "Manage Permissions";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadChangePasswordForm()
        {
            formContainer.Controls.Clear();
            ucChangePassword form = new ucChangePassword();
            formHeading.Text = "Change Password";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        //publc static void loadFormReport()
        public static void loadDomainTypes()
        {
            formContainer.Controls.Clear();
            ucDomainTypes form = new ucDomainTypes();
            formHeading.Text = "Domain Types";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public static void loadAccounts()
        {
            formContainer.Controls.Clear();
            ucAddAccounts form = new ucAddAccounts();
            formHeading.Text = "Manage User Accounts";
            form.Dock = DockStyle.Fill;


            formContainer.Controls.Add(form);
        }
        public static void loadEmployeeReports()
        {
            formContainer.Controls.Clear();
            ucEmployeeReports form = new ucEmployeeReports();
            formHeading.Text = "Reports";
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
        }
        public FormMain(String username)
        {
            InitializeComponent();
            this.username = username;
            lblMainHeader.Text = username;
        }
        public static void loadManualAttendenceForm()
        {
            formContainer.Controls.Clear();
            ucEmployeeAttendence form = new ucEmployeeAttendence();
            formHeading.Text = "Manage Attendence";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadManageManualAttendence()
        {
            formContainer.Controls.Clear();
            ucManualAttendenceForm form = new ucManualAttendenceForm();
            //  formHeading.Text = "Manage Fee Head";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        public void loadClasswiseMonthlyAttendanceReport()
        {
            formContainer.Controls.Clear();
            ucClasswiseMonthlyAttendanceReport form = new ucClasswiseMonthlyAttendanceReport();
            //  formHeading.Text = "Manage Fee Head";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadStudentwiseMonthlyAttendanceReport()
        {
            formContainer.Controls.Clear();
            ucStudentwiseMonthlyAttendanceReport form = new ucStudentwiseMonthlyAttendanceReport();
            //  formHeading.Text = "Manage Fee Head";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadDepartmentwiseAttendanceReport()
        {
            formContainer.Controls.Clear();
            ucDepartmentwiseAttendanceReport form = new ucDepartmentwiseAttendanceReport();
            //  formHeading.Text = "Manage Fee Head";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadMultipleAttendance()
        {
            formContainer.Controls.Clear();
            ucEmployeeMultipleAttendence form = new ucEmployeeMultipleAttendence();
            //  formHeading.Text = "Manage Fee Head";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadManageDepartmentClassesForm()
        {
            formContainer.Controls.Clear();
            ucManageDepartmentClasses form = new ucManageDepartmentClasses();
            // formHeading.Text = "Assign Department classes";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucHome f = new ucHome();
        

            this.container.Controls.Add(f);
        }
        public   void loadFeeHeadForm()
        {
            formContainer.Controls.Clear();
            ucFeeHead form = new ucFeeHead();
          //  formHeading.Text = "Manage Fee Head";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        

        public   void loadGenerateFeeForm()
        {
            formContainer.Controls.Clear();
            //ucFeeGeneration form = new ucFeeGeneration(this);
            //formHeading.Text = "Manage Fee";
            //form.Dock = DockStyle.Fill;

            //formContainer.Controls.Add(form);
        }
        public   void loadFormFeeSubmit()
        {
            formContainer.Controls.Clear();
            ucFormFeeSubmitMain form = new ucFormFeeSubmitMain();
           // formHeading.Text ="Form Fee Submit ";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
        public void loadManageArrearAndDiscount()
        {
            formContainer.Controls.Clear();
            ucManageArrearAndDiscounts form = new ucManageArrearAndDiscounts();
            // formHeading.Text ="Form Fee Submit ";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        public   void loadFeeEditForm(Guid feechallanid)
        {
            formContainer.Controls.Clear();
            ucFeeEditStudent form = new ucFeeEditStudent(feechallanid);
           // formHeading.Text = "Manage Fee";
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidebarToggle_Click(object sender, EventArgs e)
        {
            if(panelSidebar.Width == 50)
            {
                //panelSidebar.Visible = false;
                panelSidebar.Width = 260;
                panelSidebarParent.Width = 270;
               // panelTopRight.Visible = false;
               // animSideBar.ShowSync(panelSidebar);
               // animPanelTopRight.ShowSync(panelTopRight);
            }
            else
            {
             //   panelSidebar.Visible = false;
                panelSidebar.Width = 50;
                panelSidebarParent.Width = 60;
                //  panelTopRight.Visible = false;
                //animPanelTopRight.ShowSync(panelTopRight);
              //  animSideBar.ShowSync(panelSidebar);
           //     animLogo.HideSync(pbLogo);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOpenClass_Click(object sender, EventArgs e)
        {
        }


        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpenStudent_Click(object sender, EventArgs e)
        {
            ////container.Controls.Clear();
            ////ucStudentBoard ucClass = new ucStudentBoard();
            ////container.Controls.Add(ucClass);
        }

        private void btnOpenTeacher_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOpenFee_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenHome_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenAttendance_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
            Environment.Exit(0);
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHeaderLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frm = new FormLogin();
            frm.Show();
        }

        private void lblMainHeader_Click(object sender, EventArgs e)
        {
        }

        private void btnHeaderProfile_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void dropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblMainHeader_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frm = new FormLogin();
            frm.Show();
        }

        private void btnHeaderLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frm = new FormLogin();
            frm.Show();
        }

        private void btnHeaderProfile_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {

            Application.Exit();
            Environment.Exit(0);
        }

        private void btnMinimize_Click_2(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
                    }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //1024, 768
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Size = new Size(1024, 728);
            }

            else
            {
                System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
                this.MaximizedBounds = Screen.GetWorkingArea(this);
                this.WindowState = FormWindowState.Maximized;
                //WindowState = FormWindowState.Maximized;
            }
        }

        private void homeExpandable1_Load(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            //pgURL = "Users";
            //lblFormHeading.Text = pgURL;
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            ////formMain.formHeadingNonStatic.Text = "Country";
            ////pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
            //    container.Controls.Clear();
            //    ucAddUsers form = new ucAddUsers();
            //    form.Dock = DockStyle.Fill;
            //    container.Controls.Add(form);
            //    //lblFormHeading.Text = "Users";
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //    formMain.AccessDenied();

            //}

            container.Controls.Clear();
            ucAddUsers form = new ucAddUsers();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Users";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddAccounts form = new ucAddAccounts();
            form.Dock = DockStyle.Fill;
            lblFormHeading.Text = "Accounts";

            container.Controls.Add(form);
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddCity form = new ucAddCity();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "City";

        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddCountry form = new ucAddCountry();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Country";

        }

        private void btnState_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddState form = new ucAddState();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "State";

        }

        private void btnOrganization_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddOrganization form = new ucAddOrganization();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Organizations";

        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
                ucAddBranch form = new ucAddBranch();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Branches";

        }

        private void btnDomain_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddDomain form = new ucAddDomain();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Domains";

        }

        private void btnAddCredentials_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddCredntials form = new ucAddCredntials();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Credentials";

        }

        private void btnDomainType_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucDomainTypes form = new ucDomainTypes();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Add Domain Type";

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucHome form = new ucHome();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Home";

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucChangePassword form = new ucChangePassword();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Change Password";

        }

        private void bunifuFlatButton3_Click_2(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddPermission form = new ucAddPermission();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Permissions";
        }

        private void bunifuFlatButton2_Click_2(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddLabels form = new ucAddLabels();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "labels";
        }

        private void bunifuFlatButton3_Click_3(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddOffice form = new ucAddOffice();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Offices";
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddSection form = new ucAddSection();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Section";
        }
        public static void loadAddLabelsform()
        {
            formContainer.Controls.Clear();
            ucAddLabels form = new ucAddLabels();

            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);

            formHeading.Text = "Create Labels";
        }
            
           

        private void manageOrganizations1_Load(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddPromotion form = new ucAddPromotion();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Promotion";
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucInventory form = new ucInventory();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Inventory";
        }

        private void btnOrganization_Load(object sender, EventArgs e)
        {

        }

        /*private void btn_Invoice_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucInvoice form = new ucInvoice();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Invoice";
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddCustomer form = new ucAddCustomer();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Customer";
        }

        private void btn_CusIV_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucCustomerInvoice form = new ucCustomerInvoice();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage CustomerInvoice";
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucProduct form = new ucProduct();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Product";
        }*/
        public static void loadProductForm()
        {
            formContainer.Controls.Clear();
            ucProduct form = new ucProduct();
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage Product";
        }
        public static void loadSupplierForm()
        {
            formContainer.Controls.Clear();
            ucAddSupplier form = new ucAddSupplier();
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage Supplier";
        }
        public static void loadInvoiceForm()
        {
            formContainer.Controls.Clear();
            ucInvoice form = new ucInvoice();
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage Invoice";
        }
        
        public static void loadMultipleAttendence()
        {

            formContainer.Controls.Clear();
            ucEmployeeMultipleAttendence form = new ucEmployeeMultipleAttendence();
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
             formHeading.Text = "Manage Employee Attendence";
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddEmployee form = new ucAddEmployee();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Employees";
        }
        //public static void loadCustomerInvoiceForm()
        //{
        //    formContainer.Controls.Clear();
        //    //ucCustomerInvoice form = new ucCustomerInvoice();
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    formHeading.Text = "Manage Customer Invoice";
        //}
        public static void loadPromotionForm()
        {
            formContainer.Controls.Clear();
            ucAddPromotion form = new ucAddPromotion();
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage Promotion";
        }
        public static void loadBackForm()
        {
          
        }

        private void bunifuFlatButton3_Click_4(object sender, EventArgs e)
        {
            loadIssuesForm();
        }
        public void loadIssuesForm()
        {
            container.Controls.Clear();
            ucAddIssues form = new ucAddIssues();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Issues";
        }

        private void bunifuFlatButton4_Click_2(object sender, EventArgs e)
        {
            loadIssuesListingForm();
        }
        public void loadIssuesListingForm()
        {
            container.Controls.Clear();
            ucIssueListing form = new ucIssueListing(this);
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Issues";
        }
        public void loadCommentsForm(Guid IssueId)
        {
            container.Controls.Clear();
            ucComments form = new ucComments(this,IssueId);
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Comments";
        }

        private void homeExpandable1_Load_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_5(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucAddClasses form = new ucAddClasses();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Add Classes";
        }

        private void bunifuFlatButton4_Click_3(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucFormSection form = new ucFormSection();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Sections";
        }

        private void btnEmployeeSalary_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucEmployeeSalary form = new ucEmployeeSalary();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Employee Salary";
        }
        

        

        private void btnReports_Click(object sender, EventArgs e)
        {
           

        }

        private void employeeReports_Load(object sender, EventArgs e)
        {
            //container.Controls.Clear();
            //ucAddReports form = new ucAddReports();
            //form.Dock = DockStyle.Fill;
            //container.Controls.Add(form);
            //lblFormHeading.Text = "Manage  Reports";
        }

       
        private void bunifuFlatButton4_Click_4(object sender, EventArgs e)
        {
            FormSQLBackup f = new FormSQLBackup();
            f.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            FormSetting f = new FormSetting();
            f.Show();
        }

        private void btnManageSalary_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ucEmployeeSalary form = new ucEmployeeSalary();
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            lblFormHeading.Text = "Manage Employee Salary";

        }
        //public  void loadLabForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucLab form = new ucLab(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    //formHeading.Text = "Manage Lab";
        //}
        //public  void loadLabInvoiceForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucLab_Invoice form = new ucLab_Invoice(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    //formHeading.Text = "Manage Lab Invoice";
        //}
        //public  void loadLabInvoiceIncomeForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucLab_InvoiceIncome form = new ucLab_InvoiceIncome(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    //formHeading.Text = "Manage Lab Invoice Income";
        //}
        //public  void loadLabTestForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucLabTest form = new ucLabTest(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    //formHeading.Text = "Manage Lab test";
        //}
        //public  void loadTestForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucTest form = new ucTest(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    //formHeading.Text = "Manage Test";
        //}
        //public void loadMedicineForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucMedicine form = new ucMedicine(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    formHeading.Text = "Manage Medicine";
        //}
        //public  void loadReduceStockForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucReduceStock form = new ucReduceStock(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    formHeading.Text = "Manage Stock";
        //}
        public void loadHCCBalanceForm()
        {
            formContainer.Controls.Clear();
            ucHCC_Balance form = new ucHCC_Balance(this);
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage HCC";
        }
        public  void loadPartyForm()
        {
            formContainer.Controls.Clear();
            ucParty form = new ucParty(this);
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage Party";
        }
        public  void loadPartyInvoiceForm()
        {
            formContainer.Controls.Clear();
            ucPartyInvoice form = new ucPartyInvoice(this);
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage Party Invoice";
        }
        public static void loadPatientForm()
        {
            //formcontainer.controls.clear();
            //ucpatient form = new ucpatient();
            //form.dock = dockstyle.fill;
            //formcontainer.controls.add(form);
            //formheading.text = "manage patients";
        }
        public static void loadCustomerInvoiceForm()
        {
            formContainer.Controls.Clear();
            //  ucCustomerInvoice form = new ucCustomerInvoice();
            //    form.Dock = DockStyle.Fill;
            //formContainer.Controls.Add(form);
            formHeading.Text = "Manage Customer Invoice";
        }

        public static void loadPatientPrescriptionForm()
        {
            //formContainer.Controls.Clear();
            //ucPatient_prescription form = new ucPatient_prescription();
            //form.Dock = DockStyle.Fill;
            //formContainer.Controls.Add(form);
            //formHeading.Text = "Manage Patient Prescription";
        }
        public  void loadMedicineIndexForm()
        {
            formContainer.Controls.Clear();
            ucMedicineIndex form = new ucMedicineIndex(this);
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            //formHeading.Text = "Medicine Index";
        }
        //public void loadLabIndexForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucLabIndex form = new ucLabIndex(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //   // formHeading.Text = "Lab Index";
        //}
        //public  void loadPartyIndexForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucPartyIndex form = new ucPartyIndex(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    //formHeading.Text = "Party Index";
        //}
        //public  void loadPartyInvoiceIndexForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucPartyInvoiceIndex form = new ucPartyInvoiceIndex(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    formHeading.Text = "Party Invoice Index";
        //}
        //public void loadPatientIndexForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucPatientIndex form = new ucPatientIndex(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    //formHeading.Text = "Patient Index";
        //}
        //public  void loadLabBackForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucLabIndex form = new ucLabIndex(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    formHeading.Text = "Lab Index";
        //}
        public  void loadIndexBackForm()
        {
            formContainer.Controls.Clear();
            ucHospital form = new ucHospital(this);
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
           // formHeading.Text = "Hospital Index";
        }
        public void loadMedicineBackForm()
        {
            formContainer.Controls.Clear();
            ucMedicineIndex form = new ucMedicineIndex(this);
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Medicine Index";
        }
        public  void loadPatientBackForm()
        {
            formContainer.Controls.Clear();
            ucPatientIndex form = new ucPatientIndex();
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Patient Index";
        }
        //public  void loadPartyBackForm()
        //{
        //    formContainer.Controls.Clear();
        //    ucLabIndex form = new ucLabIndex(this);
        //    form.Dock = DockStyle.Fill;
        //    formContainer.Controls.Add(form);
        //    formHeading.Text = "Party Index";
        //}
        public  void loadPartyIVBackForm()
        {
            formContainer.Controls.Clear();
            ucPartyInvoiceIndex form = new ucPartyInvoiceIndex(this);
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Party Invoice Index";
        }

        private void btnChartOfAccounts_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucChartOfAccounts form = new ucChartOfAccounts(this);
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Chart Of Accounts";
        }

        private void btnEmployeeSalry_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucEmployeeSalary form = new ucEmployeeSalary();
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage Employee Salary";
        }

        private void bunifuFlatButton4_Click_5(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucFormAddStudents form = new ucFormAddStudents();
            form.Dock = DockStyle.Fill;
            formContainer.Controls.Add(form);
            formHeading.Text = "Manage Students";
        }
        private void teachers1_Load(object sender, EventArgs e)
        {

        }
 
        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            FormSetting f = new FormSetting();
            f.Show();
        }

        private void location2_Load(object sender, EventArgs e)
        {

        }
    }
}
