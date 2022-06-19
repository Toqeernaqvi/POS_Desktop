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
using SicParvisMagna.Library;
using System.Data.SqlClient;
using SicParvisMagna.Controllers;

namespace SicParvisMagna.Forms
{
    public partial class ucAddDomain : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        private Guid OrgID = Guid.Empty;
        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;

        private bool FormValidation()
        {
            bool validated = true;


            //For  title
            if (string.IsNullOrEmpty(txtDomainTitle.Text))
            {
                lblErrorTitle.Text += "  Title  is required!";
                validated = false;
            }
            else
            {
                lblErrorTitle.Text = "";
            }

            if (!Validation.isAlpha(txtDomainTitle.Text, 15))
            {
                if (string.IsNullOrEmpty(txtDomainTitle.Text))
                    lblErrorTitle.Text += "\n";
                lblErrorTitle.Text += "Title Should be in  Alphabets and  MAximum Length 15 chracters!";
                validated = false;
            }
            else
            {
                lblErrorTitle.Text = "";
            }
            //====================================================

            //For  Technical Person Name
            if (string.IsNullOrEmpty(txtTechPerson.Text))
            {
                lblErrorTechnicalPersonName.Text += "  Name  is required!";
                validated = false;
            }
            else
            {
                lblErrorTechnicalPersonName.Text = "";
            }

            if (!Validation.isAlpha(txtTechPerson.Text, 15))
            {
                if (string.IsNullOrEmpty(txtTechPerson.Text))
                    lblErrorTechnicalPersonName.Text += "\n";
                lblErrorTechnicalPersonName.Text += "Title Should be in  Alphabets and  MAximum Length 15 chracters!";
                validated = false;
            }
            else
            {
                lblErrorTechnicalPersonName.Text = "";
            }
            //====================================================
            //For  Regestration Person Name
            if (string.IsNullOrEmpty(txtRegestrarName.Text))
            {
                lblErrorRegestrarName.Text += "  Name  is required!";
                validated = false;
            }
            else
            {
                lblErrorRegestrarName.Text = "";
            }

            if (!Validation.isAlpha(txtRegestrarName.Text, 25))
            {
                if (string.IsNullOrEmpty(txtRegestrarName.Text))
                    lblErrorRegestrarName.Text += "\n";
                lblErrorRegestrarName.Text += "Name Should be in  Alphabets and  MAximum Length 25 chracters!";
                validated = false;
            }
            else
            {
                lblErrorRegestrarName.Text = "";
            }
            //====================================================
            //For  Regestration Email
            if (string.IsNullOrEmpty(txtRegestrationEmail.Text))
            {
                lblErrorRegestrationEmail.Text += " Email required!";
                validated = false;
            }
            else
            {
                lblErrorRegestrationEmail.Text = "";
            }

            if (!Validation.isEmail(txtRegestrationEmail.Text))
            {
                if (string.IsNullOrEmpty(txtRegestrationEmail.Text))
                    lblErrorRegestrationEmail.Text += "\n";
                lblErrorRegestrationEmail.Text += "abc@example.com";
                validated = false;
            }
            else
            {
                lblErrorRegestrationEmail.Text = "";
            }
            //====================================================
            //====================================================
            //For  NameServer
            if (string.IsNullOrEmpty(txtNameServer1.Text))
            {
                lblErrorNameServer1.Text += "  Name  is required!";
                validated = false;
            }
            else
            {
                lblErrorNameServer1.Text = "";
            }

            if (!Validation.isAlpha(txtNameServer1.Text, 25))
            {
                if (string.IsNullOrEmpty(txtNameServer1.Text))
                    lblErrorNameServer1.Text += "\n";
                lblErrorNameServer1.Text += "Name Should be in  Alphabets and  MAximum Length 25 chracters!";
                validated = false;
            }
            else
            {
                lblErrorNameServer1.Text = "";
            }
            //====================================================


            return validated;
        }

        private void loadDomain()
        {

            DomainDAL objDAL = new DomainDAL();
            DomainBAL obj = new DomainBAL();
            obj.Parent_id = BranchID;        //0;// cmbOrganizationBranch.SelectedIndex;..
            gridDomain.DataSource = objDAL.LoadAll(obj);
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
            obj.Parent_id = OrgID;
            cmbOrganizationBranch.DataSource = objDAL.LoadBranch(obj);
            cmbOrganizationBranch.ValueMember = "Organization_id";
            cmbOrganizationBranch.DisplayMember = "Title";
            cmbOrganizationBranch.SelectedIndex = -1;
        }



        //ckear function
        public void clearAll()
        {
            btnSave.LabelText = "Save";
            txtRegestrarName.Clear();
            txtRegestrationEmail.Clear();
            txtShortName.Clear();
            txtTechPerson.Clear();
            txtDescription.Clear();
            txtNameServer1.Clear();
            txtNameServer2.Clear();
            txtNameServer3.Clear();
            txtNameServer4.Clear();
            txtNameServer5.Clear();
            txtDomainTitle.Clear();
            dtpExpiryDate.Text = "";
            dtpRegestrationDate.Text = "";
            dtpUpdateDate.Text = "";
            btnSave.Text = "Save";
            cmbOrganization.Text = "";
             lblErrorNameServer1.Text = "";
            lblErrorRegestrarName.Text = "";
             lblErrorRegestrationEmail.Text = "";
            lblErrorTechnicalPersonName.Text = "";
            lblErrorTitle.Text = "";
             cmbOrganizationBranch.Text = "";
            gridDomain.DataSource = null;



        }



        public ucAddDomain()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {


                DomainBAL obj = new DomainBAL();
                //obj.Parent_id = cmbOrganizationBranch.SelectedIndex; //issue 0 is parent id and organization id also
                obj.Parent_id = BranchID;
                obj.Title = txtDomainTitle.Text;
                obj.Short_Name = txtShortName.Text;
                obj.Type = "Domain";
                obj.Regestration_Date = DateTime.Parse(dtpRegestrationDate.Text);
                obj.Expiry_Date = DateTime.Parse(dtpExpiryDate.Text);
                obj.Update_Date = DateTime.Parse(dtpUpdateDate.Text);
                obj.Tech_Persoan_Name = txtTechPerson.Text;
                obj.Regestrar_Name = txtRegestrarName.Text;
                obj.Regestration_Email = txtRegestrationEmail.Text;
                obj.Name_Server1 = txtNameServer1.Text;
                obj.Name_Server2 = txtNameServer2.Text;
                obj.Name_Server3 = txtNameServer3.Text;
                obj.Name_Server4 = txtNameServer4.Text;
                obj.Name_Server5 = txtNameServer5.Text;
                obj.Description = txtDescription.Text;

                DomainDAL objDAL = new DomainDAL();

                if (OrganizationID!=Guid.Empty)
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
                OrganizationBAL objBAL = new OrganizationBAL();
                OrganizationDAL objDAL = new OrganizationDAL();
                objBAL.Organization_id = OrgID;
                objDAL.Delete(objBAL);

                clearAll();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucAddDomain_Load(object sender, EventArgs e)
        {
            clearAll();
         //   LoadCmbOrgBranch();
            LoadCmbOrg();
           // loadDomain();
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            //int.TryParse(cmbOrganization.SelectedValue.ToString(), out OrgID);
            LoadCmbOrgBranch();
        }

        private void gridDomain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                OrgID = Guid.Parse(gridDomain.Rows[rowindex].Cells["Organization_id"].Value.ToString());
                //  int.TryParse(gridDomain.Rows[rowindex].Cells["Organization_id"].Value.ToString(), out OrgID);
                cmbOrganization.SelectedValue = OrgID;
                BranchID = Guid.Parse(gridDomain.Rows[rowindex].Cells["Parent_id"].Value.ToString());
               // int.TryParse(gridDomain.Rows[rowindex].Cells["Parent_id"].Value.ToString(), out BranchID);
                cmbOrganizationBranch.SelectedValue = BranchID;

                txtDomainTitle.Text = gridDomain.Rows[rowindex].Cells["Title"].Value.ToString();
                txtShortName.Text = gridDomain.Rows[rowindex].Cells["Short_Name"].Value.ToString();
                dtpRegestrationDate.Text = gridDomain.Rows[rowindex].Cells["Regestration_Date"].Value.ToString();
                dtpExpiryDate.Text = gridDomain.Rows[rowindex].Cells["Expiry_Date"].Value.ToString();
                dtpUpdateDate.Text = gridDomain.Rows[rowindex].Cells["Update_Date"].Value.ToString();
                txtTechPerson.Text = gridDomain.Rows[rowindex].Cells["Tech_Persoan_Name"].Value.ToString();
                txtRegestrarName.Text = gridDomain.Rows[rowindex].Cells["Tech_Persoan_Name"].Value.ToString();
                txtRegestrationEmail.Text = gridDomain.Rows[rowindex].Cells["Regestration_Email"].Value.ToString();
                txtNameServer1.Text = gridDomain.Rows[rowindex].Cells["Name_Server1"].Value.ToString();
                txtNameServer2.Text = gridDomain.Rows[rowindex].Cells["Name_Server2"].Value.ToString();
                txtNameServer3.Text = gridDomain.Rows[rowindex].Cells["Name_Server3"].Value.ToString();
                txtNameServer4.Text = gridDomain.Rows[rowindex].Cells["Name_Server4"].Value.ToString();
                txtNameServer5.Text = gridDomain.Rows[rowindex].Cells["Name_Server5"].Value.ToString();
                txtDescription.Text = gridDomain.Rows[rowindex].Cells["Description"].Value.ToString();

                btnSave.LabelText = "Update";

              

            }
        }

        private void cmbOrganizationBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
           // int.TryParse(cmbOrganizationBranch.SelectedValue.ToString(), out BranchID);
           
            loadDomain();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (OrgID!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM Organization  ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtDomainTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "WHERE TYPE = 'DOMAIN' AND Title like '%" + txtDomainTitle.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtShortName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'DOMAIN' AND Short_Name like '%" + txtShortName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Short_Name like '%" + txtShortName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtRegestrarName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'DOMAIN' AND Regestrar_Name like '%" + txtRegestrarName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Regestrar_Name like '%" + txtRegestrarName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtTechPerson.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'DOMAIN' AND Tech_Persoan_Name like '%" + txtTechPerson.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Tech_Persoan_Name like '%" + txtTechPerson.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtDomainTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'DOMAIN' AND Regestration_Email like '%" + txtRegestrationEmail.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Regestration_Email like '%" + txtRegestrationEmail.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtNameServer1.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'DOMAIN' AND Name_Server1 like '%" + txtNameServer1.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Name_Server1 like '%" + txtNameServer1.Text + "%'";
                }

                if (OrgID!=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE TYPE = 'DOMAIN' AND   WHERE Organization_id  = " + OrgID;
                        whereAdded = true;
                    }
                    else
                        query += "   WHERE TYPE = 'DOMAIN'  AND Organization_id  = " + OrgID;
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

                gridDomain.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
    
    }
    }
}
