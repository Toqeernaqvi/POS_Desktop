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
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;

namespace SicParvisMagna.Forms
{
    public partial class ucAddCredntials : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid OrgID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid DomainID = Guid.Empty;
        private Guid AccountID = Guid.Empty;
        private Guid CredentialID = Guid.Empty;
        public ucAddCredntials()
        {
            InitializeComponent();
        }
        private bool FormValidation()
        {
            bool validated = true;


            //For Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblErrorEmail.Text += "Email  required!";
                validated = false;
            }
            else
            {
                lblErrorEmail.Text = "";
            }

            if (!Validation.isEmail(txtEmail.Text))
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                    lblErrorEmail.Text += "\n";
                lblErrorEmail.Text += "abc@example.com";
                validated = false;
            }
            else
            {
                lblErrorEmail.Text = "";
            }
            //====================================================

            //For  Recovery Email
            if (string.IsNullOrEmpty(txtRecoveryEmail.Text))
            {
                label1.Text += "Email  required!";
                validated = false;
            }
            else
            {
                lblErrorEmail.Text = "";
            }

            if (!Validation.isEmail(txtRecoveryEmail.Text))
            {
                if (string.IsNullOrEmpty(txtRecoveryEmail.Text))
                    label1.Text += "\n";
                label1.Text += "abc@example.com";
                validated = false;
            }
            else
            {
                label1.Text = "";
            }
            //====================================================
            //For  password
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblErrorPassword.Text += "Passowrd  required!";
                validated = false;
            }
            else
            {
                lblErrorPassword.Text = "";
            }

            if (!Validation.isPassword(txtPassword.Text))
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                    lblErrorPassword.Text += "\n";
                lblErrorPassword.Text += "alphabets+interger must";
                validated = false;
            }
            else
            {
                lblErrorPassword.Text = "";
            }
            //====================================================
            //For  password
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                lblErrorConfirmPassword.Text += "Passowrd  required!";
                validated = false;
            }
            else
            {
                lblErrorConfirmPassword.Text = "";
            }

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblErrorConfirmPassword.Text = "";
                ;
            }
            else
            {
                lblErrorConfirmPassword.Text = "Password  length 8 digit";
                validated = false;
            }
            //====================================================



            return validated;
        }

        private void loadCredentials()
        {

            CredentialDAL objDAL = new CredentialDAL();
            CredentialBAL obj = new CredentialBAL();
            obj.Organization_id = OrgID;      //0;// cmbOrganizationBranch.SelectedIndex;..
            gridCredentials.DataSource = objDAL.LoadAll(obj);
        }

        private void LoadCmbOrg()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;
        }

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
        private void loadCmbAccount()
        {
            AccountBAL objBAL = new AccountBAL();
            AccountDAL objDAL = new AccountDAL();
            objBAL.Account_id = AccountID;
            cmbAccountType.DataSource = objDAL.LoadDomainTypeAll();
            cmbAccountType.ValueMember = "Account_id";
            cmbAccountType.DisplayMember = "Title";
            cmbAccountType.SelectedIndex = -1;
        }
        private void LoadDomain()
        {
            DomainDAL objDAL = new DomainDAL();
            DomainBAL obj = new DomainBAL();
            obj.Parent_id = BranchID;
            cmbDomain.DataSource = objDAL.LoadAll(obj);
            cmbDomain.ValueMember = "Organization_id";
            cmbDomain.DisplayMember = "Title";
            cmbDomain.SelectedIndex = -1;


        }

        //clear function
        public void clearAll()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtRecoveryEmail.Clear();
            cmbOrganization.Text = "";
            cmbDomain.Text = "";
            cmbOrganizationBranch.Text = "";
            cmbAccountType.Text = "";
            lblErrorConfirmPassword.Text = "";
            lblErrorEmail.Text = "";
            lblErrorPassword.Text = "";
            label1.Text = "";
            btnSave.LabelText = "Save";
            loadCredentials();
        }

        private void ucAddCredntials_Load(object sender, EventArgs e)
        {
            loadCmbAccount();
            LoadCmbOrg();
          //  LoadCmbOrgBranch();
          //  LoadDomain();
          //  loadCredentials();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                CredentialBAL obj = new CredentialBAL();
                obj.Organization_id = OrgID;
                obj.primary_email = txtEmail.Text;
                obj.Recovery_Email = txtRecoveryEmail.Text;
                obj.Password = txtPassword.Text;
                obj.Domain_id = cmbAccountType.Text;
                obj.User_id = Program.User_id;
          
                CredentialDAL objDAL = new CredentialDAL();

                if (CredentialID!=Guid.Empty)
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
                loadCredentials();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OrgID!=Guid.Empty)
            {
                CredentialBAL objBAL = new CredentialBAL();
                CredentialDAL objDAL = new CredentialDAL();
                objBAL.Organization_id = OrgID;
                objDAL.Delete(objBAL);

                clearAll();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (CredentialID!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                string query = @"SELECT * FROM dbo.Credential_Table  ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE primary_email LIKE '" + txtEmail.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                //query = "SELECT * FROM dbo.User_Education
               
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Password like '%" + txtPassword.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Password like '%" + txtPassword.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtRecoveryEmail.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Recovery_Email like '%" + txtRecoveryEmail.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Recovery_Email '%" + txtRecoveryEmail.Text + "%'";
                }

                if (CredentialID!=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE Id = " + CredentialID;
                        whereAdded = true;
                    }
                    else
                        query += "   AND Id  = " + CredentialID;
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

                gridCredentials.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridCredentials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                CredentialID = Guid.Parse(gridCredentials.Rows[rowindex].Cells["Id"].Value.ToString());
                OrgID =Guid.Parse(gridCredentials.Rows[rowindex].Cells["Organization_id"].Value.ToString());
                cmbOrganization.SelectedValue = OrgID;
               // LoadCmbOrg();
                 
              
                txtEmail.Text = gridCredentials.Rows[rowindex].Cells["primary_email"].Value.ToString();
                txtPassword.Text = gridCredentials.Rows[rowindex].Cells["Password"].Value.ToString();
                txtConfirmPassword.Text = gridCredentials.Rows[rowindex].Cells["Password"].Value.ToString();

                txtRecoveryEmail.Text = gridCredentials.Rows[rowindex].Cells["Recovery_Email"].Value.ToString();
                cmbAccountType.Text = gridCredentials.Rows[rowindex].Cells["DomainAccType"].Value.ToString();
                btnSave.LabelText= "Update";

            }
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrgID =Guid.Parse( cmbOrganization.SelectedValue.ToString());
           // int.TryParse(cmbOrganization.SelectedValue.ToString(), out OrgID);
            LoadCmbOrgBranch();
        }

        private void cmbOrganizationBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID=Guid.Parse( cmbOrganizationBranch.SelectedValue.ToString());
           // int.TryParse(cmbOrganizationBranch.SelectedValue.ToString(), out OrgID);
            LoadDomain();
        }

        private void cmbDomain_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DomainID = Guid.Parse(cmbDomain.SelectedValue.ToString());
          //  int.TryParse(cmbDomain.SelectedValue.ToString(), out OrgID);
            loadCredentials();
        }
    }
}
