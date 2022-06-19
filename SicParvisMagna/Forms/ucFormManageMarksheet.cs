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

namespace SicParvisMagna.Forms
{
    public partial class ucFormManageMarksheet : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        private int status = 0;
        private Guid userID = Guid.Empty;
        private Guid TeacherID = Guid.Empty;
        private Guid SectionID = Guid.Empty;
        private Guid SubjectID = Guid.Empty;
        private Guid testCATid = Guid.Empty;
        private Guid testGENid = Guid.Empty;
        private Guid OrganizationID = Guid.Empty;
        private Guid Classid = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid Sessionid = Guid.Empty;
        //    private Guid stu_id = Guid.Empty; 
        private string Detect = string.Empty;
        private bool testExist = false, loadTest = false;
        private DateTime resultDate;

        public object NavigationService { get; private set; }
        private FormMain formMain;

        public ucFormManageMarksheet(FormMain formMain)
        {
            InitializeComponent();
            InitGrid();
        }

        public ucFormManageMarksheet(Guid ClsID, Guid sctID, string det, Guid SessionID, Guid SubjectID, Guid orgid, Guid brch_id, Guid tstCATid, Guid tstGENid, FormMain formMain)
        {
            InitializeComponent();
            InitGrid();
            Detect = det;
            Classid = ClsID;
            SectionID = sctID;
            OrganizationID = orgid;

            this.formMain = formMain;
            BranchID = brch_id;
            this.testCATid = tstCATid;
            this.testGENid = tstGENid;
            Loadsubjectbyb_c();
            this.Sessionid = SessionID;
            this.SubjectID = SubjectID;
            testExist = false;
            LoadResults();
            loadTest = false;

        }


        public ucFormManageMarksheet(Guid ClsID, Guid sctID, Guid tcat, Guid tgen, string det, Guid SessionID, Guid SubjectID)
        {
            InitializeComponent();
            InitGrid();
            testCATid = tcat;
            testGENid = tgen;
            Detect = det;
            Classid = ClsID;
            SectionID = sctID;
            Loadsubjectbyb_c();

            this.SubjectID = SubjectID;
            this.Sessionid = SessionID;
            testExist = true;
            LoadResults();
            loadTest = true;
        }

        private void initializeComboBoxValues(bool initTest)
        {
            cmb_sec.SelectedValue = Sessionid;
            cmb_sub.SelectedValue = SubjectID;
            cmb_teach.SelectedValue = TeacherID;

            // LoadAllTeachers();
            if (initTest)
            {
                cmb_testcat.SelectedValue = testCATid;
                cmb_test.SelectedValue = testGENid;
            }
            // combo
        }
        public class Item
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }
        public enum DataEnum
        {
            PASS,
            FAIL,
            ABSENT,
            LEAVE,
            INACTIVE
        }

        private void InitGrid()
        {
            DataGridViewComboBoxColumn remarks = new DataGridViewComboBoxColumn();
            //var list11 = new List<string>() { "PASS", "FAIL", "ABSENT" };
            //remarks.Items.Add("PASS");
            //remarks.Items.Add("FAIL");
            //remarks.Items.Add("ABSENT");

            //DataTable dt = new DataTable();
            //dt.Columns.Add("id");
            //dt.Columns.Add("value");

            //dt.Rows.Add("PASS", "PASS");
            //dt.Rows.Add("FAIL", "FAIL");
            //dt.Rows.Add("ABSENT", "ABSENT");

            //remarks.ValueType = typeof(DataEnum);
            List<Item> items = new List<Item>();
            items.Add(new Item() { Name = "PASS", Id = 1 });
            items.Add(new Item() { Name = "FAIL", Id = 2 });
            items.Add(new Item() { Name = "ABSENT", Id = 3 });
            items.Add(new Item() { Name = "LEAVE", Id = 4 });
            items.Add(new Item() { Name = "INACTIVE", Id = 5 });
            remarks.DataSource = items;
            remarks.ValueMember = "Id";
            remarks.DisplayMember = "Name";
            remarks.HeaderText = "remarks";
            remarks.DataPropertyName = "remarks";
            remarks.Name = "remarks";
            gridMarksheet.Columns.Add(remarks);
            //   gridMarksheet1.Columns.Add(remarks);
            gridMarksheet.DataError += new DataGridViewDataErrorEventHandler(dgvCombo_DataError);


        }

        void dgvCombo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // (No need to write anything in here)
        }


        private void LoadResults()
        {
            if (Detect == "New" && !testExist)
            {

                Result_DAL objDAL = new Result_DAL();
                Result_BAL objBAL = new Result_BAL();
                objBAL.classid = Classid;
                objBAL.sectionid = SectionID;
                objBAL.Session_id = Sessionid;
                DataTable dt = objDAL.LoadbyC_S(objBAL);
                dt.Columns.Add("Obt_marks", typeof(Double));
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    try { dt.Rows[x][4] = 0; } catch { }
                }

                gridMarksheet.DataSource = dt;

                gridMarksheet.Columns["Student Name"].DisplayIndex = 0;
                gridMarksheet.Columns["Roll no"].DisplayIndex = 1;
                gridMarksheet.Columns["Class"].DisplayIndex = 2;
                gridMarksheet.Columns["Obt_marks"].DisplayIndex = 3;
                gridMarksheet.Columns["Obt_marks"].HeaderText = "Obtained Marks";

                gridMarksheet.Columns["remarks"].DisplayIndex = 4;
                gridMarksheet.Columns["remarks"].HeaderText = "Remarks";
                gridMarksheet.Columns["id"].DisplayIndex = 5;
                gridMarksheet.Columns["id"].Visible = false;


                LoadallTestCAT();

                if (testCATid != Guid.Empty && testGENid != Guid.Empty)
                {
                    cmb_testcat.SelectedValue = testCATid;
                    LoadallTestGEN();
                    cmb_test.SelectedValue = testGENid;

                }


                gridMarksheet1.Hide();
                gridMarksheet.Show();
                gridMarksheet.RefreshEdit();

            }

            else if (Detect == "Update")
            {

                loadExistingTestGridStudent();

            }

        }

        private void loadExistingTestGridStudent()
        {
            Result_DAL objDAL = new Result_DAL();
            Result_BAL objBAL = new Result_BAL();
            objBAL.classid = Classid;
            objBAL.sectionid = SectionID;
            objBAL.test_cat_id = testCATid;
            objBAL.test_id = testGENid;
            objBAL.OrganizationId = OrganizationID;
            objBAL.branchid = BranchID;
            objBAL.Session_id = Sessionid;
            objBAL.SubjectId = SubjectID;
            // objBAL.teacherid = TeacherID;
            cmb_session.SelectedValue = Sessionid;

            gridMarksheet1.DataSource = objDAL.LoadbyClassSectionSubjectSessionTest(objBAL);
            // = ExistingRecordsDT;

            if (gridMarksheet1.Rows.Count > 0)
            {

                TeacherID = Guid.Parse(gridMarksheet1.Rows[0].Cells["teacher_id"].Value.ToString());
                DateTime.TryParse(gridMarksheet1.Rows[0].Cells["date"].Value.ToString(), out resultDate);
                txt_PM.Text = gridMarksheet1.Rows[0].Cells["passing_marks"].Value.ToString();
                txt_TM.Text = gridMarksheet1.Rows[0].Cells["totalmarks"].Value.ToString();

            }
            gridMarksheet1.Columns["Student Name"].DisplayIndex = 0;
            gridMarksheet1.Columns["Roll no"].DisplayIndex = 1;
            gridMarksheet1.Columns["Class"].DisplayIndex = 2;
            gridMarksheet1.Columns["Obtain Marks"].DisplayIndex = 3;
            gridMarksheet1.Columns["Remarks"].DisplayIndex = 4;
            gridMarksheet1.Columns["id"].DisplayIndex = 5;
            gridMarksheet1.Columns["teacher_id"].Visible = false;
            gridMarksheet1.Columns["totalmarks"].Visible = false;
            //  gridMarksheet1.Columns[""].Visible = true;
            gridMarksheet.Hide();
            gridMarksheet1.Show();
            fillfields();
        }


        private void fillfields()
        {
            Loadsubjectbyb_c();

            //  Result_DAL objDAL = new Result_DAL();
            //  Result_BAL objBAL = objDAL.gethidevalues(Classid, SectionID, testCATid, testGENid);
            cmb_sub.SelectedValue = SubjectID;


            LoadallTestCAT();
            cmb_testcat.SelectedValue = testCATid;

            LoadallTestGEN();
            cmb_test.SelectedValue = testGENid;


            //   text_TotalMarks.Text;
            LoadAllTeachers();
            cmb_teach.SelectedValue = TeacherID;
            cmb_session.SelectedValue = Sessionid;
            cmb_sub.SelectedValue = SubjectID;
            //LoadAllTeachers();
            try { dtp1.Value = resultDate; } catch { MessageBox.Show("Datetime could not be loaded properly for this marksheet"); }
            btnSave.Text = "     Update";
        }

        private void Loadsubjectbyb_c()
        {
            //MessageBox.Show(BranchID.ToString());
            var objDAL = new SubjectDAL();
            var objBal = new SubjectBAL();
            objBal.classid = Classid;
            cmb_sub.DataSource = objDAL.LoadByBranch(objBal);
            cmb_sub.ValueMember = "id";
            cmb_sub.DisplayMember = "title";
            cmb_sub.SelectedIndex = -1;
        }


        private void LoadallTestCAT()
        {
            test_catDAL objDAL = new test_catDAL();
            test_catBAL objBAL = new test_catBAL();
            //    objBAL.branchid = BranchID;
            cmb_testcat.DataSource = objDAL.LoadAll();
            cmb_testcat.ValueMember = "id";
            cmb_testcat.DisplayMember = "title";
            cmb_testcat.SelectedIndex = -1;
        }
        private void LoadallTestGEN()
        {

            test_genDAL objDAL = new test_genDAL();
            test_genBAL objBAL = new test_genBAL();
            //objBAL.test_cat_id = testCATid;
            cmb_test.DataSource = objDAL.LoadAll();
            cmb_test.ValueMember = "id";
            cmb_test.DisplayMember = "test_title";
            cmb_test.SelectedIndex = -1;
        }
        private void LoadAllTeachers()
        {
            //// This line is stopping Teachers from loading when adding marks for new class/section. replace with load all teachers temporarily 
            teachersDAL objDAL = new teachersDAL();
            teachersBAL objBAL = new teachersBAL();
            cmb_teach.DataSource = objDAL.LoadAll();
            cmb_teach.ValueMember = "id";
            cmb_teach.DisplayMember = "name";
            cmb_teach.SelectedIndex = -1;
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
            cmb_sec.DataSource = objDAL.LoadByBranch(objBAL);

            cmb_sec.ValueMember = "id";
            cmb_sec.DisplayMember = "title";
            cmb_sec.SelectedIndex = -1;


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
            obj.Parent_id = OrganizationID;
            cmbOrganizationBranch.DataSource = objDAL.LoadBranch(obj);
            cmbOrganizationBranch.ValueMember = "Organization_id";
            cmbOrganizationBranch.DisplayMember = "Title";
            cmbOrganizationBranch.SelectedIndex = -1;
        }


        private void Insert()
        {
            try
            {
                bool isDuplicate = true;
                foreach (DataGridViewRow row in gridMarksheet.Rows)
                {
                    Result_DAL objDAL = new Result_DAL();
                    Result_BAL objBAL = new Result_BAL();
                    Guid id;
                    float Obt_marks = 0;
                    int passingMarks = 0;

                    id = Guid.Parse(gridMarksheet.Rows[row.Index].Cells["id"].Value.ToString());

                    objBAL.id = Guid.Empty;
                    TeacherID = Guid.Parse(cmb_teach.SelectedValue.ToString());
                    objBAL.teacherid = TeacherID;
                    objBAL.teachername = cmb_teach.Text;
                    objBAL.classid = Classid;
                    objBAL.sectionid = SectionID;
                    objBAL.Session_id = Sessionid;
                    objBAL.studentid = id;

                    objBAL.OrganizationId = OrganizationID;

                    objBAL.branchid = BranchID;
                    //  SubjectID = Guid.Parse(cmb_sub.SelectedValue.ToString());
                    objBAL.SubjectId = SubjectID;

                    testCATid = Guid.Parse(cmb_testcat.SelectedValue.ToString());
                    objBAL.test_cat_id = testCATid;

                    testGENid = Guid.Parse(cmb_test.SelectedValue.ToString());

                    objBAL.test_id = testGENid;

                    //int PM;
                    //int.TryParse(txt_PM.Text, out PM);
                    //objBAL.passing_marks = PM;
                    int totalmarks;

                    int.TryParse(txt_TM.Text, out totalmarks);
                    objBAL.TotalMarks = totalmarks;
                    //int.TryParse(gridMarksheet.Rows[row.Index].Cells["passing_marks"].Value.ToString(), out passingMarks);
                    //objBAL.passing_marks= passingMarks;
                    float.TryParse(gridMarksheet.Rows[row.Index].Cells["Obt_marks"].Value.ToString(), out Obt_marks);
                    objBAL.ObtainedMarks = Obt_marks;

                    if (gridMarksheet.Rows[row.Index].Cells["Remarks"].Value == null)
                        objBAL.Remarks = "";
                    else if (gridMarksheet.Rows[row.Index].Cells["Remarks"].Value.ToString() == "1")
                        objBAL.Remarks = "PASS";
                    else if (gridMarksheet.Rows[row.Index].Cells["Remarks"].Value.ToString() == "2")
                        objBAL.Remarks = "FAIL";
                    else if (gridMarksheet.Rows[row.Index].Cells["Remarks"].Value.ToString() == "3")
                        objBAL.Remarks = "ABSENT";
                    else if (gridMarksheet.Rows[row.Index].Cells["Remarks"].Value.ToString() == "4")
                        objBAL.Remarks = "LEAVE";
                    else if (gridMarksheet.Rows[row.Index].Cells["Remarks"].Value.ToString() == "5")
                        objBAL.Remarks = "INACTIVE";
                    else
                        objBAL.Remarks = gridMarksheet.Rows[row.Index].Cells["Remarks"].Value.ToString();

                    objBAL.userid = userID;
                    objBAL.std_tst = Guid.NewGuid().ToString();
                    objBAL.status = status;
                    objBAL.Date = dtp1.Value;
                    objBAL.Local = true;
                    objBAL.Web = false;

                    objBAL.Add_by = Guid.Empty;
                    objBAL.Add_Date = DateTime.Today;
                    //Insert
                    if (isDuplicate)
                    {
                        Result_DAL objdal = new Result_DAL();
                        DataTable dt = objdal.getExistingTest(Sessionid, Classid, SectionID, SubjectID, testCATid, testGENid);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("A MarkSheet already exists, Loading up that one now", "Error!");
                            Detect = "Update";
                            LoadResults();
                            return;
                        }
                        else
                            isDuplicate = false;
                    }

                    objDAL.Add(objBAL);

                    //objBAL.Edit_By = comboBox_user.Text;
                    //objBAL.Edit_Date = DateTime.Today;
                    ////Insert
                    //objDAL.Update(objBAL);
                }
                MessageBox.Show("MarkSheet Created Now you can Edit/Update it");
                Detect = "Update";
                LoadResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Inner Exception: " + ex.InnerException);
            }
        }

        private void Update()
        {

            try
            {
                foreach (DataGridViewRow row in gridMarksheet1.Rows)
                {
                    Result_DAL objDAL = new Result_DAL();
                    Result_BAL objBAL = new Result_BAL();
                    Guid id;
                    float Obt_marks = 0;
                    //       int passingMarks = 0;

                    id = Guid.Parse(gridMarksheet1.Rows[row.Index].Cells["id"].Value.ToString());

                    objBAL.id = Guid.Empty;

                    TeacherID = Guid.Parse(cmb_teach.SelectedValue.ToString());

                    objBAL.teacherid = TeacherID;
                    objBAL.teachername = cmb_teach.Text;

                    objBAL.classid = Classid;
                    objBAL.sectionid = SectionID;
                    objBAL.Session_id = Sessionid;
                    objBAL.studentid = id;

                    SubjectID = Guid.Parse(cmb_sub.SelectedValue.ToString());
                    objBAL.SubjectId = SubjectID;


                    testCATid = Guid.Parse(cmb_testcat.SelectedValue.ToString());

                    objBAL.test_cat_id = testCATid;
                    testGENid = Guid.Parse(cmb_test.SelectedValue.ToString());

                    objBAL.test_id = testGENid;

                    //int PM;
                    //int.TryParse(txt_PM.Text, out PM);
                    //objBAL.passing_marks = PM;
                    int totalmarks;
                    int.TryParse(txt_TM.Text, out totalmarks);
                    objBAL.TotalMarks = totalmarks;
                    float.TryParse(gridMarksheet1.Rows[row.Index].Cells["Obtain Marks"].Value.ToString(), out Obt_marks);
                    objBAL.ObtainedMarks = Obt_marks;
                    //int.TryParse(gridMarksheet1.Rows[row.Index].Cells["passing_marks"].Value.ToString(), out passingMarks);
                    //objBAL.passing_marks = passingMarks;
                    objBAL.Remarks = gridMarksheet1.Rows[row.Index].Cells["Remarks"].Value.ToString();
                    objBAL.userid = userID;
                    objBAL.std_tst = Guid.NewGuid().ToString();
                    objBAL.status = status;
                    objBAL.Date = dtp1.Value;
                    objBAL.Local = true;
                    objBAL.Web = false;

                    //objBAL.Add_by = comboBox_user.Text;
                    //objBAL.Add_Date = DateTime.Today;
                    ////Insert
                    //objDAL.Add(objBAL);

                    objBAL.Edit_By = Guid.Empty;
                    objBAL.Edit_Date = DateTime.Now;
                    //Update
                    objDAL.Update(objBAL);

                }
                Detect = "Update";
                LoadResults();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Add Obtain Marks and Remarks");

            }

        }
        private void LoadSessions()
        {
            SessionDAL obj = new SessionDAL();
            SessionBAL objBAL = new SessionBAL();
            objBAL.BranchId = BranchID;
            cmb_session.DataSource = obj.LoadByBranch(objBAL);
        }
        // 2;// BranchID;

        //private bool ValidateForm()
        //{
        //    //bool validated = true;


        ////For CityName
        //if (string.IsNullOrEmpty(txtbSession_Name.Text))
        //{
        //    lblError_sess.Text += "  Name required!";
        //    validated = false;
        //}
        //else
        //
        //    lblError_sess.Text = "";
        //}

        //if (!Validation.isAlphaNumeric(txtbSession_Name.Text))
        //{
        //    lblError_sess.Text += "Name Should be in  Alphabets and Numbers!";
        //    validated = false;
        //}
        //else
        //{
        //    lblError_sess.Text = "";
        //}


        //if (cmbOrganization.SelectedIndex < 0)
        //{
        //    lblError_Org.Text += "* Organization is required!";
        //    validated = false;
        //}
        //else
        //{
        //    lblError_Org.Text = "";
        //}


        //if (cmbOrganizationBranch.SelectedIndex < 0)
        //{
        //    lblError_Branch.Text += "* Branch is required!";
        //    validated = false;
        //}
        //else
        //{
        //    lblError_Branch.Text = "";
        //}

        ////if (cmb_class.SelectedIndex < 0)
        ////{
        ////    LlblError_class.Text += "* class is required!";
        ////    validated = false;
        ////}
        ////else
        ////{
        ////    LlblError_class.Text = "";
        ////}


        ////====================================================

        // return validated;

        //}
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validate())


            {
                if (Detect == "New")
                {
                    Insert();
                }
                else if (Detect == "Update")
                {
                    Update();
                }

            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }

            // MessageBox.Show("Done");
        }
        public void ClearPartially()
        {

            lblError_teach.Text = "";
            lblError_testCat.Text = "";
            lblError_test.Text = "";
            lblError_TM.Text = "";
            cmb_teach.Text = "";
            cmb_test.Text = "";
            cmb_testcat.Text = "";
            txt_PM.Text = "";
            txt_TM.Text = "";
            btnSave.Text = "Save";
        }
        private void ClearAll()
        {
            lblError_teach.Text = "";
            lblError_testCat.Text = "";
            lblError_test.Text = "";
            lblError_TM.Text = "";
            cmb_teach.Text = "";
            cmb_test.Text = "";
            cmb_testcat.Text = "";
            txt_PM.Text = "";
            txt_TM.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Detect == "New")
            {

            }
            else if (Detect == "Update")
            {
                foreach (DataGridViewRow row in gridMarksheet1.Rows)
                {
                    //String header = gridMarksheet.Columns[i].HeaderText;

                    //String cellText = row.Cells[i].Value.ToString();
                    Guid id;
                    id = Guid.Parse(gridMarksheet1.Rows[row.Index].Cells["id"].Value.ToString());

                    ///////////////////////////Insertion/////////////////////////////
                    Result_DAL objDAL = new Result_DAL();
                    Result_BAL objBAL = new Result_BAL();
                    objBAL.id = id;
                    objDAL.Delete(objBAL);
                    Detect = "New";
                }
                MessageBox.Show("Deleted");
                this.Hide();



            }
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            //int.TryParse(cmbOrganization.SelectedValue.ToString(), out OrgID);
            // LoadCmbOrgBranch();
        }

        private void cmbOrganizationBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
            //LoadClass();

            LoadSessions();
        }

        private void cmb_class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Classid = Guid.Parse(cmb_class.SelectedValue.ToString());
        }

        private void cmb_testcat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            testCATid = Guid.Parse(cmb_testcat.SelectedValue.ToString());
            LoadallTestGEN();
        }

        private void cmb_test_SelectionChangeCommitted(object sender, EventArgs e)
        {
            testGENid = Guid.Parse(cmb_test.SelectedValue.ToString());
        }

        private void cmb_sub_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SubjectID = Guid.Parse(cmb_sub.SelectedValue.ToString());
        }

        private void gridMarksheet_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            int iColumn = gridMarksheet.CurrentCell.ColumnIndex;
            int iRow = gridMarksheet.CurrentCell.RowIndex;

            if (iColumn == 1)
            {
                if (gridMarksheet.RowCount > (iRow + 1))
                {
                    gridMarksheet.CurrentCell = gridMarksheet[0, iRow + 1];
                }
                else
                {
                    btnSave.Focus();
                }
            }
            else
            {
                gridMarksheet.CurrentCell = gridMarksheet[1, iRow];
            }
        }

        private void gridMarksheet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //e. = true;
                int iColumn = gridMarksheet.CurrentCell.ColumnIndex;
                int iRow = gridMarksheet.CurrentCell.RowIndex;

                if (iColumn == 1)
                {
                    if (gridMarksheet.RowCount > (iRow + 1))
                    {
                        gridMarksheet.CurrentCell = gridMarksheet[0, iRow + 1];
                    }
                    else
                    {
                        btnSave.Focus();
                    }
                }
                else
                {
                    gridMarksheet.CurrentCell = gridMarksheet[1, iRow];
                }
            }
            catch (Exception ex)
            {
                //      RadMessageBox.Show("Exception: " + ex);
            }
        }

        private void gridMarksheet_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridMarksheet.Rows.Count > 0 && gridMarksheet.Columns[e.ColumnIndex].Name != "remarks")
                {
                    float obtainedMarks, passingMarks;
                    string obtainedMarksfromGrid = (string)gridMarksheet.Rows[e.RowIndex].Cells["Obt_marks"].Value;
                    float.TryParse(obtainedMarksfromGrid, out obtainedMarks);
                    float.TryParse(txt_PM.Text, out passingMarks);

                    if (gridMarksheet.Rows[e.RowIndex].Cells["remarks"].Value == null || (string)gridMarksheet.Rows[e.RowIndex].Cells["remarks"].Value == "PASS" || (string)gridMarksheet.Rows[e.RowIndex].Cells["remarks"].Value == "FAIL")
                    {


                        DataGridViewComboBoxCell cell = gridMarksheet.Rows[e.RowIndex].Cells["remarks"] as DataGridViewComboBoxCell;

                        //       cell.Value = cell.Items[0];

                        if (obtainedMarks >= passingMarks)
                        {
                            cell.Value = "PASS";
                            //gridMarksheet.Rows[e.RowIndex].Cells["remarks"].Value = "PASS";
                        }
                        else
                        {
                            cell.Value = "FAIL";
                            // gridMarksheet.Rows[e.RowIndex].Cells["remarks"].Value = "FAIL";
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void ucFormManageMarksheet_Load(object sender, EventArgs e)
        {
            //  ClearAll();
            LoadAllTeachers();
            initializeComboBoxValues(loadTest);
            // LoadCmbOrg();
        }

        private void cmb_teach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TeacherID = Guid.Parse(cmb_teach.SelectedValue.ToString());
            LoadallTestCAT();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            formMain.loadMarksheetLoadForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        



    }
}
