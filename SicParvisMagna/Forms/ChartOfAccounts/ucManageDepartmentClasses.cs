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

namespace SicParvisMagna.Forms.Inventory
{
    public partial class ucManageDepartmentClasses : UserControl
    {

        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid ClassID = Guid.Empty;
        private Guid DepartmentID = Guid.Empty;
        private Guid DeptClassId = Guid.Empty;
        public static bool PerAdd;
        public static bool PerDel;
        public static string pgURL;
        public static string AccountType;

        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;

        public ucManageDepartmentClasses()
        {
            InitializeComponent();
            staticcon = new SQLCon().getCon();
            staticcmd = new SqlCommand();
        }
         
        private void clearAll()
        {
            cmbOrganization.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            OrganizationID = Guid.Empty;
            BranchID = Guid.Empty;
            DepartmentID = Guid.Empty;
            ClassID = Guid.Empty;
            gridDeptClasses.DataSource = null;
        }
        
        private void loadCbxOrganization()
        {
            OrganizationBAL objBAL = new OrganizationBAL();
            OrganizationDAL objDAL = new OrganizationDAL();

            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;


        }
        private void loadCbxBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();

            obj.Parent_id = OrganizationID;//   Guid.Parse(cmbOrganization.SelectedValue.ToString());

            cmbBranch.DataSource = objDAL.LoadBranch(obj);
            cmbBranch.ValueMember = "Organization_id";
            cmbBranch.DisplayMember = "Title";
            cmbBranch.SelectedIndex = -1;


        }

        private void loadCbxDepartment()
        {
            Department_BAL objBAL = new Department_BAL();
            Department_DAL objDAL = new Department_DAL();
            objBAL.branch_id = BranchID;
            cmbDepartment.DataSource = objDAL.LoadAll(objBAL);
            cmbDepartment.ValueMember = "dept_id";
            cmbDepartment.DisplayMember = "name";
            cmbDepartment.SelectedIndex = -1;


        }

        private void loadCbxClass()
        {
            ClassBAL objBAL = new ClassBAL();
            ClassDAL objDAL = new ClassDAL();
            cmbClass.DataSource = objDAL.LoadAll();
            cmbClass.ValueMember = "id";
            cmbClass.DisplayMember = "title";
            cmbClass.SelectedIndex = -1;
        }
        private void ucManageDepartmentClasses_Load(object sender, EventArgs e)
        {
            pgURL = "Manage Department Classes";
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
                LoadGrid();
            }

            if (AccountType == "Branch Admin")
            {
                //for  Branch Admin
                try { OrganizationID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                loadCbxBranch();
                //
                PnlCmbOrganization.Hide();
                LoadGrid_BranchOperator();
            }

            if (AccountType == "Operator")
            {
                try { OrganizationID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                try {  BranchID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Branch_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                loadCbxDepartment();
               //
                PnlCmbOrganization.Hide();
                pnlCmbBranch.Hide();
                LoadGrid_Operator();
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

            pgURL = "Manage Department Classes";
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
            loadCbxOrganization();
            loadCbxClass();
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrganizationID= Guid.Parse(cmbOrganization.SelectedValue.ToString());
            loadCbxBranch();
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbBranch.SelectedValue.ToString());
            loadCbxDepartment();
        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepartmentID = Guid.Parse(cmbDepartment.SelectedValue.ToString());
            LoadClass();

        }
        private void LoadGrid()
        {
            DepartmentClassDAL objDAL = new DepartmentClassDAL();
            gridDeptClasses.DataSource = objDAL.LoadAll();
            gridDeptClasses.Columns["id"].Visible = false;

            gridDeptClasses.Columns["Organization_id"].Visible = false;
            gridDeptClasses.Columns["Class_id"].Visible = false;
            gridDeptClasses.Columns["Branch_Id"].Visible = false;
            gridDeptClasses.Columns["dept_id"].Visible = false;
        }
        private void LoadGrid_BranchOperator()
        {
            DepartmentClassDAL objDAL = new DepartmentClassDAL();
            gridDeptClasses.DataSource = objDAL.LoadAll();
            gridDeptClasses.Columns["id"].Visible = false;
            gridDeptClasses.Columns["Organization"].Visible = false;

            gridDeptClasses.Columns["Organization_id"].Visible = false;
            gridDeptClasses.Columns["Class_id"].Visible = false;
            gridDeptClasses.Columns["Branch_Id"].Visible = false;
            gridDeptClasses.Columns["dept_id"].Visible = false;
        }
        private void  LoadGrid_Operator()
        {
            DepartmentClassDAL objDAL = new DepartmentClassDAL();
            gridDeptClasses.DataSource = objDAL.LoadAll();
            gridDeptClasses.Columns["id"].Visible = false;
            gridDeptClasses.Columns["Organization"].Visible = false;
            gridDeptClasses.Columns["Branch"].Visible = false;

            gridDeptClasses.Columns["Organization_id"].Visible = false;
            gridDeptClasses.Columns["Class_id"].Visible = false;
            gridDeptClasses.Columns["Branch_Id"].Visible = false;
            gridDeptClasses.Columns["dept_id"].Visible = false;
        }

        private void LoadClass()
        {
            LoadGrid();

            //LoadallBranch();
        }
        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClassID = Guid.Parse(cmbClass.SelectedValue.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DepartmentClassBAL objBAL = new DepartmentClassBAL();
            DepartmentClassDAL objDAL = new DepartmentClassDAL();

             objBAL.class_id = ClassID;
            objBAL.Organzation_id = OrganizationID;
            objBAL.Branch_id = BranchID;
             objBAL.dept_id = DepartmentID;
            objBAL.Local = true;
            objBAL.Web = false;
            if (DeptClassId == Guid.Empty)
            {
                objBAL.Add_by = "User";
                objBAL.Add_Date = DateTime.Today;
                //Insert
                objDAL.Add(objBAL);
            }
            else
            {

                objBAL.Edit_By = "User";
                objBAL.Edit_Date = DateTime.Today;
                //Update
                objDAL.Update(objBAL);
                pgURL = "Manage Department Classes";
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
                    LoadGrid();
                }

                if (AccountType == "Branch Admin")
                {
                    //for  Branch Admin
                    try { OrganizationID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                    catch (Exception r)
                    {
                        MessageBox.Show("Error:" + r.Message);
                    }
                    loadCbxBranch();
                    //
                    PnlCmbOrganization.Hide();
                    LoadGrid_BranchOperator();
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
                    loadCbxDepartment();
                    //
                    PnlCmbOrganization.Hide();
                    pnlCmbBranch.Hide();
                    LoadGrid_Operator();
                }


            }

            clearAll();

           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeptClassId != Guid.Empty)
            {
                DepartmentClassBAL objBAL = new DepartmentClassBAL();
                DepartmentClassDAL objDal = new DepartmentClassDAL();
                objBAL.id = DeptClassId;
                objDal.Delete(objBAL);
                clearAll();
            }
            else
            {
                MessageBox.Show("No Class  selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridHead_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
               

                DeptClassId = Guid.Parse(gridDeptClasses.Rows[rowindex].Cells["id"].Value.ToString());
                ClassID = Guid.Parse(gridDeptClasses.Rows[rowindex].Cells["class_id"].Value.ToString());
                OrganizationID = Guid.Parse(gridDeptClasses.Rows[rowindex].Cells["Organization_id"].Value.ToString());
                BranchID = Guid.Parse(gridDeptClasses.Rows[rowindex].Cells["Branch_id"].Value.ToString());
                DepartmentID = Guid.Parse(gridDeptClasses.Rows[rowindex].Cells["dept_id"].Value.ToString());

                cmbClass.SelectedValue = ClassID;
                cmbOrganization.SelectedValue = OrganizationID;
                cmbBranch.SelectedValue = BranchID;
                cmbDepartment.SelectedValue = DepartmentID;
                btnSave.LabelText = "Update";
            }
        }
    }
}
