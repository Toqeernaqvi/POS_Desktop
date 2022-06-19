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
using Telerik.WinControls.UI;
using System.Web.UI.WebControls;
using Telerik.WinControls;
using System.Configuration;
using BasicCRUD.Controllers;

namespace SicParvisMagna.Forms
{
    public partial class ucAddBranch : UserControl
    {
        public static bool PerAdd;
        public static bool PerEdit;

        public static bool PerDel;
        public static string pgURL;

        private string AccountType = null;
         private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid OrgID =Guid.Empty;
        private Guid OrganizationID = Guid.Empty;

        private bool FormValidation()
        {
            bool validated = true;


            //For Accounts title
            if (string.IsNullOrEmpty(txtBranchTitle.Text))
            {
                lblErrorBranchTitle.Text += "  Name  is required!";
                validated = false;
            }
            else
            {
                lblErrorBranchTitle.Text = "";
            }

            if (!Validation.isAlpha(txtBranchTitle.Text, 15))
            {
                if (string.IsNullOrEmpty(txtBranchTitle.Text))
                    lblErrorBranchTitle.Text += "\n";
                lblErrorBranchTitle.Text += "Name Should be in  Alphabets and  MAximum Length 15 chracters!";
                validated = false;
            }
            else
            {
                lblErrorBranchTitle.Text = "";
            }
            //====================================================

            return validated;
        }

        private void loadOrganization()
        {

            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();
            obj.Parent_id = Guid.Parse(cmbOrganization.SelectedValue.ToString());
           // obj.Parent_id = Convert.ToInt32(cmbOrganization.SelectedValue);
            gridBranch.DataSource = objDAL.LoadBranch(obj);
            gridBranch.Columns["Organization_id"].Visible = false;
            gridBranch.Columns["Parent_id"].Visible = false;
            //gridBranch.Columns["Regestration_Date"].Visible = false;
            //gridBranch.Columns["Update_Date"].Visible = false;
            //gridBranch.Columns["Regestrar_Name"].Visible = false;
            //gridBranch.Columns["Tech_Persoan_Name"].Visible = false;
            //gridBranch.Columns["Regestration_Email"].Visible = false;
            //gridBranch.Columns["Name_Server1"].Visible = false;
            //gridBranch.Columns["Name_Server2"].Visible = false;
            //gridBranch.Columns["Name_Server3"].Visible = false;
            //gridBranch.Columns["Name_Server4"].Visible = false;
            //gridBranch.Columns["NameServer5"].Visible = false;
            //gridBranch.Columns["HeaderPicturePath"].Visible = false;
            gridBranch.Columns["User_id"].Visible = false;
            gridBranch.Columns["Timestamp"].Visible = false;
            gridBranch.Columns["Add_by"].Visible = false;
            gridBranch.Columns["Status"].Visible = false;
            gridBranch.Columns["Flag"].Visible = false;
        }

        //
        private void LoadCmbOrg()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;
        }
        //
        public void clearAll()
        {
            txtBranchTitle.Clear();
            txtDescription.Clear();
            btnSave.Text = "Save";
            cmbOrganization.Text = "";
            lblErrorBranchTitle.Text = "";
            loadOrganization();
        }
        public ucAddBranch()
        {
            InitializeComponent();
            this.gridBranch.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridBranch.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
    
    }

        private void ucAddBranch_Load(object sender, EventArgs e)
        {
            //pgURL = "Organizations"; PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
            ////for Account Type
            //try { AccountType = (PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Account_type"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}

            //if (AccountType == "Super Admin")
            //{


            //}
            //else if (AccountType == "Branch Admin")
            //{
            //    try { OrganizationID = Guid.Parse(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Organization_id"].ToString()); }
            //    catch (Exception r)
            //    {
            //        MessageBox.Show("Error:" + r.Message);
            //    }

            //}
            //else
            //{

            //    POSMain.loadAccessDenied();
            //}
            //try { PerAdd = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["PerAdd"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerAdd == true)
            //{
            //    btnSave.Enabled = true;
            //}
            //else
            //{
            //    btnSave.Hide();
            //}
            //try { PerEdit = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerEdit).Rows[0]["PerEdit"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerEdit == true)
            //{
            //    btnSave.Enabled = true;
            //}
            //else
            //{
            //    btnSave.Hide();
            //}
            //try { PerDel = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerDel).Rows[0]["PerDel"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerDel == true)
            //{
            //    btnDelete.Enabled = true;
            //}
            //else
            //{
            //    btnDelete.Hide();
            //}

            LoadCmbOrg();
            cmbOrganization.SelectedValue = OrganizationID;
           // loadOrganization();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (FormValidation())
            {
                OrganizationBAL obj = new OrganizationBAL();
                obj.Parent_id = Guid.Parse(cmbOrganization.SelectedValue.ToString());
               // obj.Parent_id = Convert.ToInt32(cmbOrganization.SelectedValue);
                obj.Title = txtBranchTitle.Text;
                obj.Type = "Branch";
                obj.Description = txtDescription.Text;
                OrganizationDAL objDAL = new OrganizationDAL();

                if (OrgID !=Guid.Empty)
                {

                    obj.Organization_id = OrgID;
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

                clearAll();
                loadOrganization();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loadOrganization();
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OrgID!=Guid.Empty)
            {
                OrganizationBAL objBAL = new OrganizationBAL();
                OrganizationDAL objDAL = new OrganizationDAL();
                objBAL.Organization_id = OrgID;
                objDAL.Delete(objBAL);
                loadOrganization();
                clearAll();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridOrganization_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                OrgID = Guid.Parse(gridBranch.Rows[rowindex].Cells["Organization_id"].Value.ToString());
                //int.TryParse(gridOrganization.Rows[rowindex].Cells["Organization_id"].Value.ToString(), out OrgID);
                cmbOrganization.SelectedValue = OrgID;
                txtBranchTitle.Text = gridBranch.Rows[rowindex].Cells["Title"].Value.ToString();
                txtDescription.Text = gridBranch.Rows[rowindex].Cells["Description"].Value.ToString();



                btnSave.LabelText = "Update";

            }
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            //Int32.TryParse(cmbOrganization.SelectedValue.ToString(), out OrganizationID);
            loadOrganization();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (OrgID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM Organization  ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtBranchTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'Branch' AND Title like '%" + txtBranchTitle.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (OrgID!=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE TYPE = 'Branch' AND   WHERE Organization_id  = " + OrgID;
                        whereAdded = true;
                    }
                    else
                        query += "   WHERE TYPE = 'Branch'  AND Organization_id  = " + OrgID;
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

                gridBranch.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbOrganization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBranchTitle.Focus();
            }
        }

        private void txtBranchTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }
    }
}
