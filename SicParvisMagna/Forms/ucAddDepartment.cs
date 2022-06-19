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
    public partial class ucAddDepartment : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid companyID = Guid.Empty;
        private Guid branchID = Guid.Empty;
        private Guid departmentID = Guid.Empty;
        public ucAddDepartment()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtpTimeOut.Format = DateTimePickerFormat.Custom;
            dtpTimeOut.CustomFormat = " hh:mm:ss";
        }
        private void loadGridDepartment()
        {
            Department_DAL objDAL = new Department_DAL();
            Department_BAL obj = new Department_BAL();
            obj.branch_id = branchID;
            gridDepartment.DataSource = objDAL.LoadAll(obj);

            gridDepartment.Columns["dept_id"].Visible = false;
            gridDepartment.Columns["company_id"].Visible = false;
            gridDepartment.Columns["branch_id"].Visible = false;
            gridDepartment.Columns["web"].Visible = false;
            gridDepartment.Columns["local"].Visible = false;
            gridDepartment.Columns["add_by"].Visible = false;
            gridDepartment.Columns["edit_by"].Visible = false;
            gridDepartment.Columns["edit_date"].Visible = false;
            gridDepartment.Columns["add_date"].Visible = false;
        }
        private void loadCmbCompany()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbCompany.DataSource = objDAL.LoadAll();
            cmbCompany.ValueMember = "Organization_id";
            cmbCompany.DisplayMember = "Title";
            cmbCompany.SelectedIndex = -1;
        }

        private void loadCmbBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();

            obj.Parent_id = Guid.Parse(cmbCompany.SelectedValue.ToString());
            
            cmbBranch.DataSource = objDAL.LoadBranch(obj);
            cmbBranch.ValueMember = "Organization_id";
            cmbBranch.DisplayMember = "Title";
            cmbBranch.SelectedIndex = -1;
        }

        private void clearAll()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtShortName.Text = "";
            txtCode.Text = "";
            dtpAbsentAfter.Text = "";
            dtpBreakEnd.Text = "";
            dtpGraceTime.Text = "";
            dtpShortLeave.Text = "";
            dtpTimeIn.Text = "";
            dtpTimeOut.Text = "";
            lblErrorName.Text = "";
            lblErrorCode.Text = "";
 
        }

        private void clear()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtShortName.Text = "";
            txtCode.Text = "";
           
            cmbCompany.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;

            gridDepartment.DataSource = null;
            dtpAbsentAfter.Value = DateTime.Now;
            dtpBreakEnd.Value = DateTime.Now;
            dtpBreakStart.Value = DateTime.Now;
            dtpGraceTime.Value = DateTime.Now;
            dtpShortLeave.Value = DateTime.Now;
            dtpTimeIn.Value = DateTime.Now;
            dtpTimeOut.Value = DateTime.Now;
        


        }
        private bool FormValidation()
        {
            bool validated = true;


            //For Name
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                lblErrorName.Text += "  Name required!";
                validated = false;
            }
            else
            {
                lblErrorName.Text = "";
            }

            if (!Validation.isAlpha(txtTitle.Text, 20))
            {
                if (string.IsNullOrEmpty(txtTitle.Text))
                    lblErrorName.Text += "\n";
                lblErrorName.Text += "Name Should be in  Alphabets and  MAximum Length 20 chracters!";
                validated = false;
            }
            else
            {
                lblErrorName.Text = "";
            }
            //====================================================
            //For Code
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                lblErrorCode.Text += "  Name required!";
                validated = false;
            }
            else
            {
                lblErrorCode.Text = "";
            }

            if (!Validation.isNumber(txtCode.Text))
            {
                if (string.IsNullOrEmpty(txtCode.Text))
                    lblErrorCode.Text += "\n";
                lblErrorCode.Text += "Code must be integer!";
                validated = false;
            }
            else
            {
                lblErrorCode.Text = "";
            }
            //====================================================



            return validated;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(FormValidation())
            {
                Department_BAL objBAL = new Department_BAL();
                objBAL.name = txtTitle.Text;
                objBAL.shortName = txtShortName.Text;
                objBAL.code = txtCode.Text;
                objBAL.desc = txtDescription.Text;
                objBAL.company_id = companyID;
                objBAL.branch_id = branchID;
                objBAL.time_in = Convert.ToDateTime(dtpTimeIn.Text);
                objBAL.time_out = Convert.ToDateTime(dtpTimeOut.Text);
                objBAL.break_start = Convert.ToDateTime(dtpBreakStart.Text);
                objBAL.break_end = Convert.ToDateTime(dtpBreakEnd.Text);
                objBAL.grace_time = Convert.ToDateTime(dtpGraceTime.Text);
                objBAL.short_leave = Convert.ToDateTime(dtpShortLeave.Text);
                objBAL.absent_after = Convert.ToDateTime(dtpAbsentAfter.Text);
                objBAL.local = true;
                objBAL.web = true;


                Department_DAL obj = new Department_DAL();
                if (departmentID != Guid.Empty)
                {
                    objBAL.Editby = "Admin";
                    objBAL.EditDate = DateTime.Now;
                    objBAL.dept_id = departmentID;
                    obj.Update(objBAL);

                }
                else
                {
                    objBAL.AddDate = DateTime.Now;
                    objBAL.Addby = "Toqeer";
                    obj.Add(objBAL);
                }


            }

            clearAll();
            loadGridDepartment();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (departmentID != Guid.Empty)
            {
                Department_BAL objBAL = new Department_BAL();
                Department_DAL objDAL = new Department_DAL();
                objBAL.dept_id = departmentID;
                objDAL.Delete(objBAL);
                clearAll();
           
            }
            else
            {
                MessageBox.Show("No Area selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearAll();
            loadGridDepartment();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (departmentID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.Department";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   name like '%" + txtTitle.Text + "%'";
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
                        query += "  WHERE  [desc] like '%" + txtDescription.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND [desc] like '%" + txtDescription.Text + "%'";
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
                if (departmentID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE dept_id  = " + departmentID;
                        whereAdded = true;
                    }
                    else
                        query += "  Where  dept_id = " + departmentID;
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

                gridDepartment.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void gridDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                departmentID = Guid.Parse(gridDepartment.Rows[rowindex].Cells["dept_id"].Value.ToString());
                // int.TryParse(gridCountries.Rows[rowindex].Cells["city_id"].Value.ToString(), out CityID);
                txtTitle.Text = gridDepartment.Rows[rowindex].Cells["name"].Value.ToString();
                txtShortName.Text = gridDepartment.Rows[rowindex].Cells["shortname"].Value.ToString();
                txtCode.Text = gridDepartment.Rows[rowindex].Cells["code"].Value.ToString();
                txtDescription.Text = gridDepartment.Rows[rowindex].Cells["desc"].Value.ToString();
                companyID = Guid.Parse(gridDepartment.Rows[rowindex].Cells["company_id"].Value.ToString());
                 cmbCompany.SelectedValue = companyID;
                branchID = Guid.Parse(gridDepartment.Rows[rowindex].Cells["branch_id"].Value.ToString());
                 cmbBranch.SelectedValue = branchID;

                dtpTimeIn.Text = gridDepartment.Rows[rowindex].Cells["time_in"].Value.ToString();
                dtpTimeOut.Text = gridDepartment.Rows[rowindex].Cells["time_out"].Value.ToString();
                dtpBreakStart.Text = gridDepartment.Rows[rowindex].Cells["break_start"].Value.ToString();
                dtpBreakEnd.Text = gridDepartment.Rows[rowindex].Cells["break_end"].Value.ToString();
                dtpGraceTime.Text = gridDepartment.Rows[rowindex].Cells["grace_time"].Value.ToString();
                dtpShortLeave.Text = gridDepartment.Rows[rowindex].Cells["short_leave"].Value.ToString();
            dtpAbsentAfter.Text = gridDepartment.Rows[rowindex].Cells["absent_after"].Value.ToString();


                btnSave.LabelText = "Update";
                
            }
        }

        private void ucAddDepartment_Load(object sender, EventArgs e)
        {
            loadCmbCompany();
        }

        private void cmbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            companyID = Guid.Parse(cmbCompany.SelectedValue.ToString());
            loadCmbBranch();
             
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            branchID = Guid.Parse(cmbBranch.SelectedValue.ToString());
            loadGridDepartment();
           
        }

        private void cmbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBranch.Focus();
            }
        }

        private void cmbBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTitle.Focus();
            }
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtShortName.Focus();
            }
        }

        private void txtShortName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCode.Focus();
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }
    }
}

