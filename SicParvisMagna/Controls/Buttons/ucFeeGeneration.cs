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
using System.Data.SqlClient;
using BasicCRUD.Controllers;
using SicParvisMagna.Library;

namespace SicParvisMagna.Forms
{
    public partial class ucFeeGeneration : UserControl
    {
        public bool PerView;

        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;

        private Guid ClassID = Guid.Empty;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        Guid SessionID = Guid.Empty;
        private Guid DepartmentID = Guid.Empty;
        Guid feechallanid = Guid.Empty;
        public static bool PerAdd;
        public static bool PerDel;
        public static string pgURL;
        public static string AccountType;

        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;
        private FormMain formMain;

        public ucFeeGeneration(FormMain formMain)
        {
            InitializeComponent();
            staticcon = new SQLCon().getCon();
            staticcmd = new SqlCommand();
            this.formMain = formMain;
        }

 

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadCmbOrganization()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;
        }

        private void loadCmbBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();

            obj.Parent_id = OrganizationID;

            cmbBranch.DataSource = objDAL.LoadBranch(obj);
            cmbBranch.ValueMember = "Organization_id";
            cmbBranch.DisplayMember = "Title";
            cmbBranch.SelectedIndex = -1;
        }

        public void loadDepartment()
        {
            Department_BAL objBAL = new Department_BAL();
                Department_DAL objDAL = new Department_DAL();
            objBAL.branch_id = BranchID;
            cmbDepartment.DataSource = objDAL.LoadAll(objBAL);
                cmbDepartment.ValueMember = "dept_id";
                cmbDepartment.DisplayMember = "name";
                cmbDepartment.SelectedIndex = -1;


            

        }


        public void loadClass()
        {
             ClassDAL objDAL = new ClassDAL();

            cmbClass.DataSource = objDAL.LoadByDepartment(DepartmentID);
            // cmbClass.DataSource = objDAL.LoadAll();
            cmbClass.ValueMember = "id";
            cmbClass.DisplayMember = "title";
            cmbClass.SelectedIndex = -1;

        }

        public void loadSection()
        {
            Guid.TryParse(cmbClass.SelectedValue.ToString(), out ClassID);
            //MessageBox.Show(BranchID.ToString());

            AcademicsSectionBAL objBAL = new AcademicsSectionBAL();
            AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
            objBAL.classid = ClassID;
            cmbSection.DataSource = objDAL.LoadByClass(objBAL);
            cmbSection.ValueMember = "id";
            cmbSection.DisplayMember = "title";
            cmbSection.SelectedIndex = -1;
        }

        private void loadComboSessions()
        {
            SessionDAL objDAL = new SessionDAL();
            cmbSession.DataSource = objDAL.LoadAll();
            cmbSession.ValueMember = "Session_id";
            cmbSession.DisplayMember = "Session_Name";
            cmbSession.SelectedIndex = -1;
        }
        private void ucFeeGeneration_Load(object sender, EventArgs e)
        {
            pgURL = "Generate Fee";
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
                try { OrganizationID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                loadCmbBranch();
                //
                pnlCmbOrganization.Hide();
                loadGridFeeGenerated_BranchAdmin();
            }

            if (AccountType == "Operator")
            {
                try { OrganizationID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                try { BranchID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Branch_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                loadDepartment();
                //
                pnlCmbOrganization.Hide();
                pnlCmbBranch.Hide();
                loadGridFeeGenerated_Operator();
            }

            try { PerAdd = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["PerAdd"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerAdd == true)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Hide();
            }

            pgURL = "Generate Fee";
            PermissionDAL.DeleteButtonPermission(Program.User_id, pgURL, PerDel);
            try { PerDel = Convert.ToBoolean(PermissionDAL.DeleteButtonPermission(Program.User_id, pgURL, PerDel).Rows[0]["PerDel"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerDel == true)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Hide();
            }
            loadCmbOrganization();
            loadGridHeads();
            //loadDepartment();
            loadComboTypes();
        }
        public void loadComboTypes()
        {
            cmbType.Items.Add("Admission Fee");
            cmbType.Items.Add("Discount");
            cmbType.Items.Add("Paper Fund");
            cmbType.Items.Add("Tution Fee");
            cmbType.Items.Add("Other");

        }
        public void loadGridHeads()
        {
             HeadDAL objd = new HeadDAL();
            dt = objd.getHeadsFee();

            gridHeads.Columns.Clear();
            gridHeads.Rows.Clear();
            gridHeads.DataSource = null;
            foreach (DataColumn dc in dt.Columns)
            {
                gridHeads.Columns.Add(dc.ColumnName, dc.ColumnName);
                gridSelHeads.Columns.Add(dc.ColumnName, dc.ColumnName);
            }
            foreach (DataRow dr in dt.Rows)
            {
                gridHeads.Rows.Add(dr.ItemArray);
            }

            DataGridViewCheckBoxColumn dgc = new DataGridViewCheckBoxColumn();
            dgc.Name = "Select";
            dgc.HeaderText = "Select";

            DataGridViewCheckBoxColumn dgc2 = new DataGridViewCheckBoxColumn();
            dgc2.Name = "Select";
            dgc2.HeaderText = "Select";

            gridHeads.Columns.Add(dgc);
            gridHeads.Columns["Select"].DisplayIndex = 0;
            gridHeads.Columns["Select"].Width = 50;
            gridHeads.Columns["id"].Visible = false;
            gridSelHeads.Columns.Add(dgc2);
            gridSelHeads.Columns["Select"].DisplayIndex = 0;
            gridSelHeads.Columns["Select"].Width = 50;
            gridSelHeads.Columns["id"].Visible = false;

        }

        private void btnMovRight_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < gridHeads.Rows.Count; x++)
            {
                if (Convert.ToBoolean(gridHeads.Rows[x].Cells["Select"].Value))
                {
                    DataGridViewRow row = (DataGridViewRow)gridHeads.Rows[x].Clone();

                    for (int y = 0; y < gridHeads.Rows[x].Cells.Count; y++)
                    {
                        row.Cells[y].Value = gridHeads.Rows[x].Cells[y].Value;
                    }

                    gridSelHeads.Rows.Add(row);
                    gridHeads.Rows.RemoveAt(x);
                    x--;
                }
            }
        }

        private void btnMovLeft_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < gridSelHeads.Rows.Count; x++)
            {
                if (Convert.ToBoolean(gridSelHeads.Rows[x].Cells["Select"].Value))
                {
                    DataGridViewRow row = (DataGridViewRow)gridSelHeads.Rows[x].Clone();

                    for (int y = 0; y < gridSelHeads.Rows[x].Cells.Count; y++)
                    {
                        row.Cells[y].Value = gridSelHeads.Rows[x].Cells[y].Value;
                    }

                    gridHeads.Rows.Add(row);
                    gridSelHeads.Rows.RemoveAt(x);
                    x--;
                }
            }
        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
           DepartmentID = Guid.Parse(cmbDepartment.SelectedValue.ToString());
            loadClass();
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadSection();
        }

        private void cmbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboSessions();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFeeGenerate())
            {
                FeeGenerateBAL obj = new FeeGenerateBAL();
                FeeGenerateDAL objd = new FeeGenerateDAL();
                obj.Organization_id = OrganizationID;
                obj.Branch_id = BranchID;
                obj.Department_id = Guid.Parse(cmbDepartment.SelectedValue.ToString());
                obj.class_id = Guid.Parse(cmbClass.SelectedValue.ToString());
                obj.section_id  = Guid.Parse(cmbSection.SelectedValue.ToString());
                obj.Session_id = SessionID; 
                obj.fee_month = dtp_Date.Value;
                obj.fee_year = dtp_Date.Value;
                obj.challan_given_date = dtp_Given.Value;
                obj.challan_due_date = dtp_Due.Value;
                //
                DataTable dt = new DataTable();

                FeeGenerateDAL objDAL = new FeeGenerateDAL();
                  Guid classid = Guid.Parse(cmbClass.SelectedValue.ToString());
                int month = dtp_Date.Value.Month;
                dt = objDAL.CheckMonthFeeGeneration(classid, month);
                if (dt.Rows.Count== 0)
                {
                    Guid FeeChallan_id = objd.InsertFeeGenerate(obj);
                    DataTable dtclass = objd.getClassById(obj);
                    int class_fee = Convert.ToInt32(dtclass.Rows[0]["fee"].ToString());
                    DataTable students = objd.getStudentsbySession(obj);
                    foreach (DataRow row in students.Rows)
                    {
                        FeeGenerateBAL objStud = new FeeGenerateBAL();
                        objStud.student_id = Guid.Parse(row["id"].ToString());
                        objStud.fee_challan_id = FeeChallan_id;
                        objStud.class_fee = class_fee;
                        objStud.Session_id = SessionID;
                        Guid StudentFeeChallan_id = objd.InsertStudentChallan(objStud);

                        for (int x = 0; x <= gridSelHeads.Rows.Count - 1; x++)
                        {
                            FeeGenerateBAL objStudDetails = new FeeGenerateBAL();
                            objStudDetails.student_challan_id = StudentFeeChallan_id;
                            objStudDetails.head_id = Guid.Parse(gridSelHeads.Rows[x].Cells["id"].Value.ToString());
                            objd.InsertStudentChallanDetail(objStudDetails);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Already Fee Generated of this Month","Error!!!",MessageBoxButtons.OKCancel);
                }
              
            }
            clearALL();
            loadGridFeeGenerated();
        }
        public void loadGridFeeGenerated()
        {
            FeeGenerateDAL objDAL = new FeeGenerateDAL();
            DataTable dtFee = objDAL.getFeeGenerated();
            gridHeads.DataSource = null;
          dgvFees.DataSource = dtFee;
            dgvFees.Columns["id"].Visible = false;
 
            dgvFees.Columns["Organization_id"].Visible = false;
            dgvFees.Columns["Class_id"].Visible = false;
            dgvFees.Columns["Branch_Id"].Visible = false;
            dgvFees.Columns["Department_id"].Visible = false;
            dgvFees.Columns["section_id"].Visible = false;


        }
        public void loadGridFeeGenerated_BranchAdmin()
        {
            FeeGenerateDAL objDAL = new FeeGenerateDAL();
            DataTable dtFee = objDAL.getFeeGenerated();
            gridHeads.DataSource = null;
            dgvFees.DataSource = dtFee;
            dgvFees.Columns["id"].Visible = false;

            dgvFees.Columns["Organization_id"].Visible = false;
            dgvFees.Columns["Class_id"].Visible = false;
            dgvFees.Columns["Branch_Id"].Visible = false;
            dgvFees.Columns["Department_id"].Visible = false;
            dgvFees.Columns["section_id"].Visible = false;
            dgvFees.Columns["Organization"].Visible = false;


        }

        public void loadGridFeeGenerated_Operator()
        {
            FeeGenerateDAL objDAL = new FeeGenerateDAL();
            DataTable dtFee = objDAL.getFeeGenerated();
            gridHeads.DataSource = null;
            dgvFees.DataSource = dtFee;
            dgvFees.Columns["id"].Visible = false;

            dgvFees.Columns["Organization_id"].Visible = false;
            dgvFees.Columns["Class_id"].Visible = false;
            dgvFees.Columns["Branch_Id"].Visible = false;
            dgvFees.Columns["Department_id"].Visible = false;
            dgvFees.Columns["section_id"].Visible = false;
            dgvFees.Columns["Organization"].Visible = false;
            dgvFees.Columns["Branch"].Visible = false;


        }

        private bool ValidateFeeGenerate()
        {
            if (gridSelHeads.RowCount > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please Select a Head ");
                return false;
            }
        }
        public void clearALL()
        {
            cmbClass.SelectedIndex = -1;
            ClassID = Guid.Empty;
            cmbSection.SelectedIndex = -1;
            cmbSession.SelectedIndex = -1;
            SessionID = Guid.Empty;
            DepartmentID = Guid.Empty;
            cmbType.SelectedIndex = -1;
            cmbType.Text = "";
            loadDepartment();
            loadGridHeads();
            loadGridFeeGenerated();
            gridSelHeads.DataSource = null;
            gridSelHeads.Columns.Clear();
            gridSelHeads.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }

        private void dgvFees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {

                feechallanid = Guid.Parse(dgvFees.Rows[e.RowIndex].Cells["id"].Value.ToString());
            }
        }

        private void dgvFees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {

                feechallanid = Guid.Parse(dgvFees.Rows[e.RowIndex].Cells["id"].Value.ToString());
            }
        }

        private void dgvFees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                feechallanid = Guid.Parse(dgvFees.Rows[e.RowIndex].Cells["id"].Value.ToString());
                pgURL = "Fee Head Edit";
                // PermissionDAL.Permission(Program.User_id, pgURL, PerView);
                PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView);

                formMain.formHeadingNonStatic.Text = "Fee Head Edit";
                pgURL = formMain.formHeadingNonStatic.Text;
                try { PerView = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
                catch (Exception r)
                {
                    //MessageBox.Show("Error:" + r.Message);
                }
                if (PerView == true)
                {
                    // formMain.loadOrganizationForm();
                    formMain.loadFeeEditForm(feechallanid);
                    // FormMain.loadFeeHeadForm();
                }
                else
                {
                    formMain.formHeadingNonStatic.Text = "Permission Denied";
                    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                    formMain.AccessDenied();
                }

                
                
            }
        }

        

        private void btnFilter_Click(object sender, EventArgs e)
        {

            try
            {
                var objHeadsDal = new HeadDAL();
                DataTable dt = new DataTable();
                // DataTable tblFiltered = new DataTable();

                if (DepartmentID != Guid.Empty && !string.IsNullOrEmpty(cmbType.Text)) // Dept and Type
                    dt = objHeadsDal.getHeadsFee(DepartmentID, ClassID, cmbType.Text);
                else if (ClassID != Guid.Empty && !string.IsNullOrEmpty(cmbType.Text)) // Class and Type
                    dt = objHeadsDal.getHeadsFee(ClassID, cmbType.Text);
                else if (ClassID != Guid.Empty && string.IsNullOrEmpty(cmbType.Text)) // Class only
                    dt = objHeadsDal.getHeadsFee(ClassID);
                else if (ClassID != Guid.Empty && !string.IsNullOrEmpty(cmbType.Text)) // Type Only
                    dt = objHeadsDal.getHeadsFee(cmbType.Text);
                else if (DepartmentID != Guid.Empty && ClassID != Guid.Empty && string.IsNullOrEmpty(cmbType.Text)) // Dept Only
                    dt = objHeadsDal.getHeadsFeeDept(DepartmentID);

                //if (DepartmentID > 0)
                //{
                //    //var enumer = dt.AsEnumerable();

                //    dt = enumer.Where(row => row.Field<int>("dept_id") == DepartmentID).CopyToDataTable();
                //}
                ////dt.DefaultView.RowFilter = string.Format("[dept_id] = '{0}'", DepartmentID);


                //dgvHeads = new Bunifu.Framework.UI.BunifuCustomDataGrid();
                gridHeads.Columns.Clear();
                gridHeads.Rows.Clear();
                gridHeads.DataSource = null;
                foreach (DataColumn dc in dt.Columns)
                {
                    gridHeads.Columns.Add(dc.ColumnName, dc.ColumnName);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    gridHeads.Rows.Add(dr.ItemArray);
                }

                DataGridViewCheckBoxColumn dgc = new DataGridViewCheckBoxColumn();
                dgc.Name = "Select";
                dgc.HeaderText = "Select";

                gridHeads.Columns.Add(dgc);
                gridHeads.Columns["Select"].DisplayIndex = 0;



            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message);
            }
        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void cmbOrganization_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            loadCmbBranch();
        }

        private void cmbBranch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {

            BranchID = Guid.Parse(cmbBranch.SelectedValue.ToString());
            loadDepartment();
        }

        private void cmbSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SessionID = Guid.Parse(cmbSession.SelectedValue.ToString());
        }
    }

    }

