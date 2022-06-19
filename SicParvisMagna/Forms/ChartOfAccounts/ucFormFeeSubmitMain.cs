using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;
using System.Data.SqlClient;
using SicParvisMagna.Library;
using BasicCRUD.Controllers;

namespace SicParvisMagna.Forms.ChartOfAccounts
{
    public partial class ucFormFeeSubmitMain : UserControl
    {
        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;

        private Guid ClassID = Guid.Empty;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        Guid SessionID = Guid.Empty;
        private Guid DepartmentID = Guid.Empty;
        private object students;
        private object objd;
        public static bool PerAdd;
        public static bool PerDel;
        public static string pgURL;
        public static string AccountType;

        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;

        public ucFormFeeSubmitMain()
        {
            InitializeComponent();
            loadCmbOrganization();
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "MM/yyyy";
            rdbtn_All.Checked = true;
            loadComboSessions();
            staticcon = new SQLCon().getCon();
            staticcmd = new SqlCommand();
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
            //   ClassesDAL objDAL = new ClassesDAL();
            var objDAL = new Department_DAL();
            Department_BAL obj = new Department_BAL();
            obj.branch_id = BranchID;
            cmbDepartment.DataSource = objDAL.LoadAll( obj);
            // cmbClass.DataSource = objDAL.LoadAll();
            cmbDepartment.ValueMember = "dept_id";
            cmbDepartment.DisplayMember = "name";
            cmbDepartment.SelectedIndex = -1;

        }


        public void loadClass()
        {
            ClassDAL objDAL = new ClassDAL();

           
            cmbClass.DataSource = objDAL.LoadByDepartment(DepartmentID);

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

        private bool ValidateForm()
        {
            //if (string.IsNullOrWhiteSpace(txtbClassName.Text))
            //{
            //    lblError_ClassTitle.Text = "Class name required! Hence you must enter the class name. thankyou";
            //    this.ActiveControl = txtbClassName;
            //    txtbClassName.Select();
            //    txtbClassName.Focus();
            //    return false;
            //}
            //else
            //    lblError_ClassTitle.Text = "";

            return true;
        }
        public void searchStudents()
        {
            loaddgvFeeSubmit();
        }

        private void loaddgvFeeSubmit()
        {
            try
            {
                dgvStudFees.Rows.Clear();
                dgvStudFees.Columns.Clear();

                FeeGenerateBAL obj = new FeeGenerateBAL();
                FeeGenerateDAL objd = new FeeGenerateDAL();


                obj.class_id = Guid.Parse(cmbClass.SelectedValue.ToString());
                obj.section_id = Guid.Parse(cmbSection.SelectedValue.ToString());

                obj.fee_month = dtp_Date.Value;
                obj.Session_id = Guid.Parse(cmbSession.SelectedValue.ToString());


                DataTable students = new DataTable();

                if (txtbChallanNo.Text == "")
                {
                    if (rdbtn_All.Checked)
                    {
                        students = objd.getStudentsForFeeSubmittionAll(obj);
                    }
                    else if (rdbtn_paid.Checked)
                    {
                        students = objd.getStudentsForFeeSubmittionPaid(obj);
                    }
                    else if (rdbtn_unpaid.Checked)
                    {
                        students = objd.getStudentsForFeeSubmittionUnpaid(obj);
                    }

                }
                else
                    students = objd.getStudentsForFeeSubmittionByChallan(obj);

                DataGridViewButtonColumn dgc2 = new DataGridViewButtonColumn();
                dgc2.Name = "Submit";
                dgc2.HeaderText = "Submit";
                dgc2.Text = "Submit Fee";
                dgc2.UseColumnTextForButtonValue = true;
                foreach (DataColumn dc in students.Columns)
                {
                    dgvStudFees.Columns.Add(dc.ColumnName, dc.ColumnName);
                }
                foreach (DataRow dr in students.Rows)
                {
                    dgvStudFees.Rows.Add(dr.ItemArray);
                }

                dgvStudFees.Columns.Add(dgc2);
                dgvStudFees.Columns["id"].Visible = false;
                dgvStudFees.Columns["title"].Visible = false;
                dgvStudFees.Columns["title1"].Visible = false;
                dgvStudFees.Columns["arrear"].Visible = false;
                dgvStudFees.Columns["discountAmount"].Visible = false;
                dgvStudFees.Columns["discountPercentage"].Visible = false;
                dgvStudFees.Columns["Total Fee"].Visible = false;
                dgvStudFees.Columns["Net Amount"].Visible = false;
                dgvStudFees.Columns["Submit"].Width = 120;
                dgvStudFees.Columns["challan_no"].Width = 150;

                // loadGridFeeGenerated();
            }
            catch(Exception e)
            {

            }
        }
        
        private bool ValidateFeeGenerate()
        {
            if (cmbClass.SelectedIndex < 0)
            {
                cmbClass.BackColor = Color.Tomato;
                return false;
            }
            else
            {
                cmbClass.BackColor = Color.White;

            }
            if (cmbSection.SelectedIndex < 0)
            {
                cmbClass.BackColor = Color.Tomato;
                return false;
            }
            else
            {
                cmbClass.BackColor = Color.White;

            }


            return true;
        }
        public void clearALL()
        {

        }

        private void cmbSection_DropDown(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex > -1)
            {
                loadSection();
            }
        }

        private void dgvStudFees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Guid challan_no = Guid.Parse(dgvStudFees.Rows[e.RowIndex].Cells["challan_no"].Value.ToString());
                Guid student_id = Guid.Parse(dgvStudFees.Rows[e.RowIndex].Cells["id"].Value.ToString());
                FormFeeSubmitSecondry form = new FormFeeSubmitSecondry(challan_no, student_id);
                form.ShowDialog(this);
                searchStudents();
            }

        }

        private void dgvStudFees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                Guid challan_no = Guid.Parse(dgvStudFees.Rows[e.RowIndex].Cells["challan_no"].Value.ToString());
                Guid student_id = Guid.Parse(dgvStudFees.Rows[e.RowIndex].Cells["id"].Value.ToString());
                FormFeeSubmitSecondry form = new FormFeeSubmitSecondry(challan_no, student_id);
                form.ShowDialog(this);

            }
        }

        private void rdbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            loaddgvFeeSubmit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (rdbtn_StudentFeeReport.Checked)
            //{
            //    FormReport rptview = new FormReport("Fee Status", "FeeStatus");
            //    rptview.ShowDialog(this);
            //}
            //else if (rdbtn_ClassWiseFeeReport.Checked)
            //{
            //    FormReport rptview = new FormReport("Class Wise Fee Status", "ClassWiseFeeStatus");
            //    rptview.ShowDialog(this);
            //}
            //else if (rdbtn_FeeSubmit.Checked)
            //{

            //    FormReport rptview = new FormReport("Fee Reciept", "FeeReciept");
            //    rptview.ShowDialog(this);
            //}
        }

    
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepartmentID = Guid.Parse(cmbDepartment.SelectedValue.ToString());
            loadClass();

        }

        
        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadSection();
        }

        private void rdbtn_paid_CheckedChanged(object sender, EventArgs e)
        {
            loaddgvFeeSubmit();
        }

        private void rdbtn_unpaid_CheckedChanged(object sender, EventArgs e)
        {
            loaddgvFeeSubmit();
        }

        private void ucFormFeeSubmitMain_Load(object sender, EventArgs e)
        {
            pgURL = "Form Fee Submit";
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

            pgURL = "Form Fee Submit";
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

       

        private void cmbOrganization_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            loadCmbBranch();
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbBranch.SelectedValue.ToString());
            loadDepartment();
        }
    }
}
