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
    public partial class ucFeeHead : UserControl
    {
        private Guid HeadID = Guid.Empty;
        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid ClassID = Guid.Empty;
        private Guid DepartmentID = Guid.Empty;
        public static bool PerAdd;
        public static bool PerDel;
        public static string pgURL;
        public static string AccountType;
    
        private static SqlConnection staticcon;
        private static SqlCommand staticcmd;


        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        public ucFeeHead()
        {
            InitializeComponent();
            staticcon = new SQLCon().getCon();
            staticcmd = new SqlCommand();
        }

        public void loadGrid()
        {
            //   dgvSearch.Rows.Clear();
            DataTable dt = new DataTable();
            HeadDAL objd = new HeadDAL();
            dt = objd.getHeads();
            gridHead.DataSource = dt;

        }
        public void loadGrid_SuperAdmin()
        {
            //   dgvSearch.Rows.Clear();
            DataTable dt = new DataTable();
            HeadDAL objd = new HeadDAL();
            dt = objd.getHeads_SuperAdmin();
            gridHead.DataSource = dt;
            gridHead.Columns["Organization_id"].Visible = false;
            gridHead.Columns["Class_id"].Visible = false;
            gridHead.Columns["Branch_Id"].Visible = false;
            gridHead.Columns["Department_id"].Visible = false;
            gridHead.Columns["id"].Visible = false;
        }
        public void loadGrid_BranchAdmin()
        {
            //   dgvSearch.Rows.Clear();
            DataTable dt = new DataTable();
            HeadDAL objd = new HeadDAL();
            dt = objd.getHeads_BranchAdmin(OrganizationID);
            gridHead.DataSource = dt;
            gridHead.Columns["Organization"].Visible = false;
            gridHead.Columns["id"].Visible = false;

            gridHead.Columns["Organization_id"].Visible = false;
            gridHead.Columns["Class_id"].Visible = false;
            gridHead.Columns["Branch_Id"].Visible = false;
            gridHead.Columns["Department_id"].Visible = false;

        }
        public void loadGrid_Operator()
        {
            //   dgvSearch.Rows.Clear();
            DataTable dt = new DataTable();
            HeadDAL objd = new HeadDAL();
            dt = objd.getHeads_Operator(BranchID);
            gridHead.DataSource = dt;
            gridHead.Columns["id"].Visible = false;

            gridHead.Columns["Organization"].Visible = false;
            gridHead.Columns["Branch"].Visible = false;
            gridHead.Columns["Organization_id"].Visible = false;
            gridHead.Columns["Class_id"].Visible = false;
            gridHead.Columns["Branch_Id"].Visible = false;
            gridHead.Columns["Department_id"].Visible = false;

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
            cmbClass.DataSource = objDAL.LoadByDepartment(DepartmentID);
            cmbClass.ValueMember = "id";
            cmbClass.DisplayMember = "title";
            cmbClass.SelectedIndex = -1;
        }
        public void clearAll()
        {
            txtName.Clear();
            txtShortName.Clear();
            txtCode.Clear();
            txtDescription.Clear();
            txtAmount.Clear();
            HeadID = Guid.Empty;
            cmbOrganization.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
                HeadBAL obj = new HeadBAL();
                HeadDAL objd = new HeadDAL();

                obj.id = HeadID;
            obj.Organization_id = OrganizationID;
            obj.Branch_id = BranchID;
            obj.Department_id = DepartmentID;
            obj.Class_id = ClassID;
            obj.Type = cmbType.Text;
                obj.Name = txtName.Text;
                obj.ShortName = txtShortName.Text;
                obj.Code = txtCode.Text;
                obj.Description = txtDescription.Text;
                obj.Ammount = Convert.ToInt32(txtAmount.Text);
            if (HeadID != Guid.Empty)
            {
                objd.UpdateHead(obj);
                pgURL = "Manage Fee Head";
                PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
                //for Account Type
                try { AccountType = (PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Account_type"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }

                if (AccountType == "Super Admin")
                {
                    loadGrid_SuperAdmin();

                }

                if (AccountType == "Branch Admin")
                {
                    //for  Branch Admin
                    try { OrganizationID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                    catch (Exception r)
                    {
                        MessageBox.Show("Error:" + r.Message);
                    }
                    loadGrid_BranchAdmin();
                    loadCbxBranch();
                    

                }

                if (AccountType == "Operator")
                {
                    //for  Branch Admin
                    try { BranchID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Branch_id"].ToString()); }
                    catch (Exception r)
                    {
                        MessageBox.Show("Error:" + r.Message);
                    }
                    loadGrid_Operator();
                     
                }
                }
                else

                objd.InsertHead(obj);

             
            clearAll();
            loadGrid();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (HeadID!=Guid.Empty)
            {
                HeadBAL obj = new HeadBAL();
                HeadDAL objd = new HeadDAL();

                obj.id = HeadID;
                objd.SuspendHead(obj);
                loadGrid();
            }
        }

        private void gridHead_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > 0)
            {
               HeadID= Guid.Parse(gridHead.Rows[index].Cells["id"].Value.ToString());
                loadCbxClass();
                ClassID = Guid.Parse(gridHead.Rows[index].Cells["class_id"].Value.ToString());
                cmbClass.SelectedValue = ClassID;
                loadCbxOrganization();
                OrganizationID = Guid.Parse(gridHead.Rows[index].Cells["Organization_id"].Value.ToString());
                cmbOrganization.SelectedValue = OrganizationID;

                loadCbxBranch();
                BranchID = Guid.Parse(gridHead.Rows[index].Cells["Branch_id"].Value.ToString());
                cmbBranch.SelectedValue = BranchID;

                loadCbxDepartment();
                DepartmentID = Guid.Parse(gridHead.Rows[index].Cells["Department_id"].Value.ToString());
                cmbDepartment.SelectedValue = DepartmentID;

                cmbType.Text = gridHead.Rows[index].Cells["Type"].Value.ToString();
                txtName.Text = gridHead.Rows[index].Cells["Name"].Value.ToString();
                txtShortName.Text = gridHead.Rows[index].Cells["Short_Name"].Value.ToString();
                txtCode.Text = gridHead.Rows[index].Cells["Code"].Value.ToString();
                txtDescription.Text = gridHead.Rows[index].Cells["Description"].Value.ToString();
                txtAmount.Text = gridHead.Rows[index].Cells["Amount"].Value.ToString();
                //
                //loadCbxBranch();
                //loadCbxDepartment();
                
            }
            btnSave.LabelText = "Update";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            loadGrid();
        }

        private void ucFeeHead_Load(object sender, EventArgs e)
        {
            pgURL = "Manage Fee Head";
            PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
            //for Account Type
            try { AccountType = (PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Account_type"].ToString()); }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
            }
            
            if (AccountType == "Super Admin")
            {
                loadGrid_SuperAdmin();

            }

            if (AccountType == "Branch Admin")
            {
                //for  Branch Admin
                try { OrganizationID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                loadGrid_BranchAdmin();
                loadCbxBranch();
                pnlCmbOrganization.Hide();
                 
            }

            if (AccountType == "Operator")
            {
                //for  Branch Admin
                try { BranchID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Branch_id"].ToString()); }
                catch (Exception r)
                {
                    MessageBox.Show("Error:" + r.Message);
                }
                loadGrid_Operator();
                loadCbxDepartment();
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

            pgURL = "Manage Fee Head";
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

            clearAll();
            //loadGrid();
            loadCbxOrganization();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (HeadID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @"SELECT * FROM  Head";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   name like '%" + txtName.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtShortName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   shortname like '%" + txtShortName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND shortname like '%" + txtShortName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtDescription.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  description like '%" + txtDescription.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND description like '%" + txtDescription.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtCode.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  code like '%" + txtCode.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND code like '%" + txtCode.Text + "%'";
                }
                if (HeadID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE id  = " + HeadID;
                        whereAdded = true;
                    }
                    else
                        query += "  Where  id = " + HeadID;
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

                gridHead.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
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
            loadCbxClass();
           
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClassID = Guid.Parse(cmbClass.SelectedValue.ToString());
            cmbType.Items.Add("Tution Fee");

        }
    }
}
