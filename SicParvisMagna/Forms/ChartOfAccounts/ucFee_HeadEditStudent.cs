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
using SicParvisMagna.Library;
using BasicCRUD.Controllers;

namespace SicParvisMagna.Forms
{
    public partial class ucFeeEditStudent : UserControl
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid FeeChallanDetailID = Guid.Empty;
        private Guid FeeChallanID = Guid.Empty;
        private Guid DepartmentID = Guid.Empty;
        private Guid ClassID = Guid.Empty;
        public static bool PerAdd;
        public static bool PerDel;
        public static string pgURL;
        public static string AccountType;

        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;

        private FormMain formMain;
        public ucFeeEditStudent(Guid challanID)
        {
            InitializeComponent();
            FeeChallanID = challanID;
            loadGridFeeGenerated();
            loadCmbOrganization();
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
            cmbDepartment.DataSource = objDAL.Load();
            // cmbClass.DataSource = objDAL.LoadAll();
            cmbDepartment.ValueMember = "dept_id";
            cmbDepartment.DisplayMember = "name";
            cmbDepartment.SelectedIndex = -1;

        }


        public void loadClass()
        {
            ClassDAL objDAL = new ClassDAL();

            cmbClass.DataSource = objDAL.LoadAll();
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

        public void loadGridFeeGenerated()
        {
            FeeGenerateDAL objDAL = new FeeGenerateDAL();
            FeeGenerateBAL objBAL = new FeeGenerateBAL();

            DataTable dt = new DataTable();
            objBAL.fee_challan_id = FeeChallanID;
            dt = objDAL.getStudentsbyFeeChallan(objBAL);
            dgvStudFees.DataSource = dt;
            dgvStudFees.Columns["id"].Visible = false;
            dgvStudFees.Columns["student_id"].Visible = false;



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

            gridHeads.Rows.Clear();
            gridHeads.Columns.Clear();
            gridSelHeads.Rows.Clear();
            gridSelHeads.Columns.Clear();

            FeeGenerateDAL objdal = new FeeGenerateDAL();
            FeeGenerateBAL objbal = new FeeGenerateBAL();

            objbal.student_challan_detail_id = FeeChallanDetailID;

            dt2 = objdal.getHeadsbyStudentChallanDetails(objbal);

            StringBuilder ids = new StringBuilder();
            foreach (DataRow r in dt2.Rows)
            {
                ids.Append("'" + r["id"].ToString() + "',");
            }

            if (ids.Length <= 0)
            {
                dt = objdal.SelectQuery("select Head.name,Head.description,head.amount,Head.id from head WHERE head.[status] = 'Active'");
            }
            else
            {
                dt = objdal.SelectQuery("select Head.name,Head.description,head.amount,Head.id from head WHERE head.[status] = 'Active' AND head.id NOT IN (" + ids.ToString().Substring(0, ids.Length - 1) + ");");

            }


            foreach (DataColumn dc in dt.Columns)
            {
                gridHeads.Columns.Add(dc.ColumnName, dc.ColumnName);
                gridSelHeads.Columns.Add(dc.ColumnName, dc.ColumnName);
            }
            //dt2
            foreach (DataRow dr in dt2.Rows)
            {
                gridSelHeads.Rows.Add(dr.ItemArray);
            }

            //dt 1
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

        public void clearALL()
        {
            OrganizationID = Guid.Empty;
            BranchID = Guid.Empty;
            DepartmentID = Guid.Empty;
            ClassID = Guid.Empty;
            cmbDepartment.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            cmbOrganization.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            cmbSession.SelectedIndex = -1;
           



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }

        private bool ValidateFeeGenerate()
        {
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateFeeGenerate())
            {
                //   FeeGenerateBAL obj          = new FeeGenerateBAL();
                //obj.class_id                   = Convert.ToInt32(cmbClass.SelectedValue.ToString());
                //obj.section_id                 = Convert.ToInt32(cmbSection.SelectedValue.ToString());
                //obj.fee_month                  = dtp_Date.Value;
                //obj.fee_year                   = dtp_Date.Value;
                //obj.challan_given_date         = dtp_Given.Value;
                //obj.challan_due_date           = dtp_Due.Value;
                //int FeeChallan_id              = objd.InsertFeeGenerate(obj);
                //      DataTable students             = objd.getStudents(obj);
                //   foreach (DataRow row in students.Rows)
                //     {
                FeeGenerateDAL objd = new FeeGenerateDAL();
                FeeGenerateBAL objStud = new FeeGenerateBAL();
                objStud.student_challan_id = FeeChallanDetailID;
                objd.deleteFeeChallanDetail(objStud);

                //objStud.fee_challan_id     = FeeChallan_id;

                //int StudentFeeChallan_id = objd.InsertStudentChallan(objStud);

                for (int x = 0; x <= gridSelHeads.Rows.Count - 1; x++)
                {
                    FeeGenerateBAL objStudDetails = new FeeGenerateBAL();
                    objStudDetails.student_challan_id = FeeChallanDetailID;
                    objStudDetails.head_id = Guid.Parse(gridSelHeads.Rows[x].Cells["id"].Value.ToString());
                    objd.InsertStudentChallanDetail(objStudDetails);
                }
                //     }
            }
            clearALL();
            loadGridFeeGenerated();
        }

         

        private void btnBack_Click(object sender, EventArgs e)
        {
        formMain.loadGenerateFeeForm();
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

        private void dgvStudFees_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FeeChallanDetailID = Guid.Parse(dgvStudFees.Rows[e.RowIndex].Cells["id"].Value.ToString());
                loadGridHeads();
            }
        }

        private void dgvStudFees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FeeChallanDetailID = Guid.Parse(dgvStudFees.Rows[e.RowIndex].Cells["id"].Value.ToString());
                loadGridHeads();
            }
        }

        
        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadCmbBranch();
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadDepartment();                                                                                                                              
        }

        private void cmbDepartment_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            loadClass();
        }

        private void cmbClass_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            loadSection();
        }

        private void cmbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboTypes();
        }

        private void cmbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboSessions();
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
                gridHeads.Columns.Add(dgc);
              

            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message);
            }
        }

        private void ucFeeEditStudent_Load(object sender, EventArgs e)
        {
            pgURL = "Fee Head Edit";
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
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Hide();
            }

            pgURL = "Fee Head Edit";
            PermissionDAL.DeleteButtonPermission(Program.User_id, pgURL, PerDel);
            try { PerDel = Convert.ToBoolean(PermissionDAL.DeleteButtonPermission(Program.User_id, pgURL, PerDel).Rows[0]["PerDel"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            if (PerDel == true)
            {
               //btnDelete.Enabled = true;
            }
            else
            {
               // btnDelete.Hide();
            }
        }

        private void cmbBranch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            loadDepartment();
        }
    }
    }
       