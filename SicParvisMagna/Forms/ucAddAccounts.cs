using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Library;
using System.Data.SqlClient;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using BasicCRUD.Controllers;
using BasicCRUD.Models;

namespace SicParvisMagna.Forms
{
    public partial class ucAddAccounts : UserControl
    {
        public static Panel formContainer;

        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid AccountID = Guid.Empty;
        private Guid PerID = Guid.Empty;
        private Guid PgID = Guid.Empty;
        private Guid User_id = Guid.Empty;
        private Guid Role_id = Guid.Empty;

        public ucAddAccounts()
        {
            InitializeComponent();
            this.gridPermission.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridPermission.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
            loadCbxAccount();
            // formContainer = this.container;
        }
        private void clearPermission()
        {
            //  for (int x = 0; x < gridPermission.Rows.Count; x++)
            //{ 
            gridPermission.DataSource = null;
            // gridPermission.Rows.Cells["PerEdit"].Value = false;
            //gridPermission.Rows.Cells["PerView"].Value = false;
            //gridPermission.Rows[x].Cells["PerDel"].Value = false;
            cbx_Account.SelectedIndex = -1;
            User_id = Guid.Empty;
            PerID = Guid.Empty;


            //}
        }
        private void loadPermissions()
        {
            PermissionBAL objBAL = new PermissionBAL();
            PermissionDAL objDAL = new PermissionDAL();
            objBAL.RoleID = Role_id;
            gridPermission.DataSource = objDAL.loadByRole(objBAL);

            gridPermission.Columns["PerID"].Visible = false;
            gridPermission.Columns["PerUID"].Visible = false;
            gridPermission.Columns["PgID"].Visible = false;
            gridPermission.Columns["Role_id"].Visible = false;
            gridPermission.Columns["User_id"].Visible = false;
            gridPermission.Columns["Timestamp"].Visible = false;
            gridPermission.Columns["AddBy"].Visible = false;
            gridPermission.Columns["Status"].Visible = false;
            gridPermission.Columns["Flag"].Visible = false;
            gridPermission.Columns["EditBy"].Visible = false;
            gridPermission.Columns["EditDate"].Visible = false;
            gridPermission.Columns["PgURL"].Width = 200;
        }
        private void loadCbxAccount()
        {
            AccountBAL objBAL = new AccountBAL();
            AccountDAL objDAL = new AccountDAL();

            cbx_Account.DataSource = objDAL.LoadAll();
            cbx_Account.ValueMember = "Account_id";
            cbx_Account.DisplayMember = "Title";
            cbx_Account.SelectedIndex = -1;
        }

        public void clearAll()
        {
            txtAccountTitle.Clear();
            txtDescription.Clear();
            btnSave.Text = "Save";
            lblErrorAccountTitle.Text = "";

            loadAccounts();
        }
        private void clearAllPermission()
        {
            //  for (int x = 0; x < gridPermission.Rows.Count; x++)
            //{ 
            gridPermission.DataSource = null;
            // gridPermission.Rows.Cells["PerEdit"].Value = false;
            //gridPermission.Rows.Cells["PerView"].Value = false;
            //gridPermission.Rows[x].Cells["PerDel"].Value = false;
            cbx_Account.SelectedIndex = -1;
            Role_id = Guid.Empty;
            PerID = Guid.Empty;


            //}
        }
        private bool FormValidation()
        {
            bool validated = true;


            //For Accounts title
            if (string.IsNullOrEmpty(txtAccountTitle.Text))
            {
                lblErrorAccountTitle.Text += "  Title  is required!";
                validated = false;
            }
            else
            {
                lblErrorAccountTitle.Text = "";
            }

            if (!Validation.isAlpha(txtAccountTitle.Text, 8))
            {
                if (string.IsNullOrEmpty(txtAccountTitle.Text))
                    lblErrorAccountTitle.Text += "\n";
                lblErrorAccountTitle.Text += "Title Should be in  Alphabets and  MAximum Length 8 chracters!";
                validated = false;
            }
            else
            {
                lblErrorAccountTitle.Text = "";
            }
            //====================================================

            return validated;
        }
        //---===========================
        private bool FormExpertiesValidation()
        {
            bool validated = true;


            //For Expertites title
            if (string.IsNullOrEmpty(txtExpertiesTitle.Text))
            {
                lblErrorExpertiesTitle.Text += "  Title  is required!";
                validated = false;
            }
            else
            {
                lblErrorExpertiesTitle.Text = "";
            }

            if (!Validation.isAlpha(txtExpertiesTitle.Text, 8))
            {
                if (string.IsNullOrEmpty(txtExpertiesTitle.Text))
                    lblErrorExpertiesTitle.Text += "\n";
                lblErrorExpertiesTitle.Text += "Title Should be in  Alphabets and  MAximum Length 8 chracters!";
                validated = false;
            }
            else
            {
                lblErrorExpertiesTitle.Text = "";
            }
            //====================================================

            return validated;
        }

        private void loadAccounts()
        {

            AccountDAL objDAL = new AccountDAL();
            gridAccounts.DataSource = objDAL.LoadAll();
        }
        private void searchUserExperties()
        {
            if (AccountID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.Accounts ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtExpertiesTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'Experties' AND Title like '%" + txtExpertiesTitle.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (AccountID!=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE TYPE = 'Experties' AND   WHERE Account_id  = " + AccountID;
                        whereAdded = true;
                    }
                    else
                        query += "   WHERE TYPE = 'Experties'  AND Account_id = " + AccountID;
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

                gridAccounts.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void searchAccounts()
        {

            if (AccountID!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.Accounts ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtAccountTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'Users' AND Title like '%" + txtAccountTitle.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (AccountID!=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE TYPE = 'Users' AND   WHERE Account_id  = " + AccountID;
                        whereAdded = true;
                    }
                    else
                        query += "   WHERE TYPE = 'Users'  AND Account_id = " + AccountID;
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

                gridAccounts.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[0])
            {
                searchAccounts();
            }
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[1])
            {
                searchUserExperties();
            }
            
        }
        private void saveAccounts()
        {
            if (FormValidation())
            {
                AccountBAL obj = new AccountBAL();
                obj.Title = txtAccountTitle.Text;
                obj.Type = "Users";
                obj.Description = txtDescription.Text;
                AccountDAL objDAL = new AccountDAL();
                if (AccountID != Guid.Empty)
                {

                    obj.Account_id = AccountID;
                    obj.Timestamp = DateTime.Now;
                    obj.Add_by = "Admin";
                    obj.Status = "Active";
                    obj.Flag = 1;
                    objDAL.Update(obj);

                }
                else
                {
                    obj.Timestamp = DateTime.Now;
                    obj.Add_by = "Admin";
                    obj.Status = "Active";
                    obj.Flag = 1;
                   

                    Guid insertedRoleID = objDAL.Add(obj);

                    //PermissionBAL objPerBal = new PermissionBAL();
                    //PermissionDAL objPerDal = new PermissionDAL();
                    //PermissionDAL.AssignPermissions(objPerBal);
                    PagesDAL objPageDal = new PagesDAL();
                    //permission dal
                    PermissionDAL objPerDal = new PermissionDAL();
                    DataTable pages = objPageDal.LoadAll();
                    for (int x = 0; x < pages.Rows.Count; x++)
                    {
                        //permission bal
                        PermissionBAL objPerBal = new PermissionBAL();
                        objPerBal.PgID = Guid.Parse(pages.Rows[x]["pgID"].ToString());
                        objPerBal.RoleID =  insertedRoleID;
                        objPerBal.PerAdd = false;
                        objPerBal.PerEdit = false;
                        objPerBal.PerView = false;
                        objPerBal.PerDel = false;
                        objPerBal.PerUID = "3";
                        objPerBal.AddBy = "Admin";
                        objPerBal.Timestamp = DateTime.Now;
                        objPerBal.Status = "Active";
                        objPerBal.Flag = 1;
                        //permissionsave
                        objPerDal.Add_withRole(objPerBal);
                    }

                    clearAll();
                }   loadAccounts();
            }
        }

        private void saveExperties()
        {
            if (FormExpertiesValidation())
            {
                AccountBAL obj = new AccountBAL();
                obj.Title = txtExpertiesTitle.Text;
                obj.Type = "Experties";
                obj.Description = txtDescription.Text;
                AccountDAL objDAL = new AccountDAL();
                if (AccountID!=Guid.Empty)
                {

                    obj.Account_id = AccountID;
                    obj.Timestamp = DateTime.Now;
                    obj.Add_by = "Admin";
                    obj.Status = "Active";
                    obj.Flag = 1;
                    objDAL.Update(obj);

                }
                else
                {
                    obj.Timestamp = DateTime.Now;
                    obj.Add_by = "Admin";
                    obj.Status = "Active";
                    obj.Flag = 1;
                    objDAL.Add(obj);
                }
            }
            clearExperties();
            loadExperties();
        }
        //...
        private void savePermissions()
        {
            PermissionBAL objBalPC = new PermissionBAL();
            PermissionDAL objDalPC = new PermissionDAL();
            objBalPC.PerID = PerID;
            objDalPC.Delete(objBalPC);
            for (int x = 0; x < gridPermission.Rows.Count; x++)
            {
                // if (Convert.ToBoolean(gridPermission.Rows[x].Cells["PerAdd"].Value) == true)
                //{
                // Create BAL / DAL -- populate and save to table

                PermissionBAL objBalPC2 = new PermissionBAL();
                //objBalPC2.PerUID = "1";
                // objBalPC2.PerID = PerID;
                objBalPC2.PerID = Guid.Parse(gridPermission.Rows[x].Cells["PerID"].Value.ToString());

                //objBalPC2.PerID = Convert.ToInt32(gridPermission.Rows[x].Cells["PerID"].Value);
                objBalPC2.PerAdd = Convert.ToBoolean(gridPermission.Rows[x].Cells["PerAdd"].Value);
                objBalPC2.PerEdit = Convert.ToBoolean(gridPermission.Rows[x].Cells["PerEdit"].Value);
                objBalPC2.PerView = Convert.ToBoolean(gridPermission.Rows[x].Cells["PerView"].Value);
                objBalPC2.PerDel = Convert.ToBoolean(gridPermission.Rows[x].Cells["PerDel"].Value);

                //objBalPC2.AddBy = "Admin";
                //objBalPC2.Timestamp = DateTime.Now;
                // objBalPC2.Status = "active";
                //objBalPC2.Flag = 1;
                objDalPC.Update(objBalPC2);

                //}
            }
            clearAllPermission();
            loadPermissions();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[0])
            {
                saveAccounts();
            }
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[1])
            {
                savePermissions();
               
            }
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[2])
            {
                saveExperties();
            }
        }
        private void loadExperties()
        {

            AccountDAL objDAL = new AccountDAL();
            AssignExpertiesBAL obj = new AssignExpertiesBAL();
            gridExperties.DataSource = objDAL.LoadExpertiesTypeAll(obj);

        }
        public void clearExperties()
        {
            txtExpertiesTitle.Clear();
            txtDescription.Clear();
            btnSave.Text = "Save";
            loadExperties();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[0])
            {
                loadAccounts();
                clearAll();
            }
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[2])
            {
                loadExperties();
                clearExperties();
            }
        }

        private void deleteAccounts()
        {
            if (AccountID!=Guid.Empty)
            {
                AccountBAL objBAL = new AccountBAL();
                AccountDAL objDAL = new AccountDAL();
                objBAL.Account_id = AccountID;
                objDAL.Delete(objBAL);
                loadAccounts();
                clearAll();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteExperties()
        {
            if (AccountID!=Guid.Empty)
            {
                AccountBAL objBAL = new AccountBAL();
                AccountDAL objDAL = new AccountDAL();
                objBAL.Account_id = AccountID;
                objDAL.Delete(objBAL);
                loadExperties();
                clearExperties();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[0])
            {
                deleteAccounts();
            }

            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[2])
            {
                deleteExperties();
            }
        }

        private void gridAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                AccountID =Guid.Parse( gridAccounts.Rows[rowindex].Cells["Account_id"].Value.ToString());
              //  int.TryParse(gridAccounts.Rows[rowindex].Cells["Account_id"].Value.ToString(), out AccountID);
                txtAccountTitle.Text = gridAccounts.Rows[rowindex].Cells["Title"].Value.ToString();
                txtDescription.Text = gridAccounts.Rows[rowindex].Cells["Description"].Value.ToString();



                btnSave.LabelText   = "Update";

            }
        }

        private void ucAddAccounts_Load(object sender, EventArgs e)
        {
            loadAccounts();
            loadExperties();
        }

    

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void gridExperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                AccountID =Guid.Parse( gridExperties.Rows[rowindex].Cells["Account_id"].Value.ToString());
              //  int.TryParse(gridExperties.Rows[rowindex].Cells["Account_id"].Value.ToString(), out AccountID);
                txtExpertiesTitle.Text = gridExperties.Rows[rowindex].Cells["Title"].Value.ToString();
                try
                {
                    txtDescription.Text = gridExperties.Rows[rowindex].Cells["Description"].Value.ToString();
                }
                catch
                {

                }


                btnSave.LabelText= "Update";

            }
        }

       
 
        
        private void cbx_Account_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Guid.TryParse(cbx_Account.SelectedValue.ToString(), out Role_id);
            // int.TryParse(cbx_User.SelectedValue.ToString(), out User_id);
            loadPermissions();
        }

        private void chkBx_Add_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBx_Add.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = false;

                }

            }
        }

        private void chkBx_Edit_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBx_Edit.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerEdit"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerEdit"].Value = false;

                }
            }
        }

        private void chkBx_View_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBx_View.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerView"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerView"].Value = false;

                }

            }
        }

        private void chkBx_Del_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBx_Del.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerDel"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerDel"].Value = false;

                }

            }
        }

        private void chkBx_SelectAll_CheckedChanged_1(object sender, EventArgs e)
        {

            if (chkBx_SelectAll.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = true;
                    gridPermission.Rows[x].Cells["PerEdit"].Value = true;
                    gridPermission.Rows[x].Cells["PerView"].Value = true;
                    gridPermission.Rows[x].Cells["PerDel"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = false;
                    gridPermission.Rows[x].Cells["PerEdit"].Value = false;
                    gridPermission.Rows[x].Cells["PerView"].Value = false;
                    gridPermission.Rows[x].Cells["PerDel"].Value = false;

                }

            }
        }

        private void tabAccountTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[0])
            {
                loadAccounts();
            }
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[1])
            {
                loadPermissions();

            }
            if (tabAccountTypes.SelectedTab == tabAccountTypes.TabPages[2])
            {
                loadExperties();
            }
        }

        private void gridExperties_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                AccountID = Guid.Parse(gridExperties.Rows[rowindex].Cells["Account_id"].Value.ToString());
                //  int.TryParse(gridExperties.Rows[rowindex].Cells["Account_id"].Value.ToString(), out AccountID);
                txtExpertiesTitle.Text = gridExperties.Rows[rowindex].Cells["Title"].Value.ToString();
                try
                {
                    txtDescription.Text = gridExperties.Rows[rowindex].Cells["Description"].Value.ToString();
                }
                catch
                {

                }


                btnSave.LabelText = "Update";

            }
        }
    }
    }

