using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using SicParvisMagna.Controllers;
using System.Data.SqlClient;
using SicParvisMagna.Library;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms
{
    public partial class ucEmployeeMultipleAttendence : UserControl
    {
        private Guid AttendenceID = Guid.Empty;
        private Guid EmployeeID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid OrganizationID = Guid.Empty;
        private Guid DepartmentID = Guid.Empty;
        private Guid OfficeID = Guid.Empty;
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        public ucEmployeeMultipleAttendence()
        {
            InitializeComponent();
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }



        //load function
        private void ucMultipleEmployeeSalary_Load(object sender, EventArgs e)
        {
            loadCbxOrg();

        }



        //Employee Attendence
        private void searchEmployeeAttendence()
        {
            if (AttendenceID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                gridMultipleAttendence.DataSource = null;

                string query = @" select  employee_id ,firstname as First_Name  ,lastname as Last_Name from Employee_PersonalInfo";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtReg.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE  registration LIKE '%" + txtReg.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                //query = "SELECT * FROM dbo.User_Education ";
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE firstname like '%" + txtName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND firstname like '%" + txtName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(cmbOrg.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Organization_id  =   '" + cmbOrg.SelectedValue + "'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Organization_id  =  '" + cmbOrg.SelectedValue + "'";
                }

                //
                if (!string.IsNullOrEmpty(cmbOrgBranch.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Branch_id like  = '"+ cmbOrgBranch.SelectedValue+"'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Branch_id  = '"+cmbOrgBranch.SelectedValue +"'";
                }

                //
                if (!string.IsNullOrEmpty(cmbDept.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE dept_id  =  '" + cmbDept.SelectedValue + "'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND dept_id  = '" + cmbDept.SelectedValue + "'";
                }
                //
                if (!string.IsNullOrEmpty(cmbDeptOfficce.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE office_id  =  '" + cmbDeptOfficce.SelectedValue + "'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND office_id  = '" + cmbDeptOfficce.SelectedValue + "'";
                }
                //
                if (!string.IsNullOrEmpty(cmbOfficeSection.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE section_id  =  '" + cmbOfficeSection.SelectedValue + "'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND section_id   =  '" + cmbOfficeSection.SelectedValue + "'";
                }

                //if (EmployeeID != Guid.Empty)
                //{
                //    if (!whereAdded)
                //    {
                //        query += "   WHERE  employee_id = '" + EmployeeID + "'";
                //        whereAdded = true;
                //    }
                //    else
                //        query += "   AND employee_id   =  '" + EmployeeID + "'";
                //}

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

           //     EmployeeID = Guid.Parse(dt.Rows[0]["employee_id"].ToString());


                gridMultipleAttendence.DataSource = dt;
                 LoadGrid();
                gridMultipleAttendence.Columns.Move(07, 01);
                this.gridMultipleAttendence.Columns[01].Width = 100;
                gridMultipleAttendence.Columns.Move(08, 02);
                this.gridMultipleAttendence.Columns[02].Width = 100;
                gridMultipleAttendence.Columns.Move(09, 03);
                this.gridMultipleAttendence.Columns[03].Width = 100;

                //   gridMultipleAttendence.DataSource = objDal.LoadEmployData(EmployeeID);

                //  gridMultipleAttendence.Columns.Move(01, 03);


            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //
        private void loadCbxDept()
        {
            Department_BAL objBAL = new Department_BAL();
            Department_DAL objDAL = new Department_DAL();
            objBAL.branch_id = BranchID;
            cmbDept.DataSource = objDAL.LoadAll(objBAL);
            cmbDept.ValueMember = "dept_id";
            cmbDept.DisplayMember = "name";
            cmbDept.SelectedIndex = -1;
        }
        //
        private void loadCbxOrg()
        {
            OrganizationBAL objBAL = new OrganizationBAL();
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrg.DataSource = objDAL.LoadAll();
            cmbOrg.ValueMember = "Organization_id";
            cmbOrg.DisplayMember = "Title";
            cmbOrg.SelectedIndex = -1;
        }
        //
        private void loadCmbOrgBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();

            obj.Parent_id = OrganizationID;//   Guid.Parse(cmbOrganization.SelectedValue.ToString());
            cmbOrgBranch.DataSource = objDAL.LoadBranch(obj);
            cmbOrgBranch.ValueMember = "Organization_id";
            cmbOrgBranch.DisplayMember = "Title";
            cmbOrgBranch.SelectedIndex = -1;
        }
        //
        private void loadCbxDeptOffice()
        {
            Office_BAL objBAL = new Office_BAL();
            Office_DAL objDAL = new Office_DAL();
            objBAL.dept_id = DepartmentID;
            cmbDeptOfficce.DataSource = objDAL.LoadAll(objBAL);

            cmbDeptOfficce.ValueMember = "office_id";
            cmbDeptOfficce.DisplayMember = "name";
            cmbDeptOfficce.SelectedIndex = -1;
        }
        //
        private void loadCbxOfficeSection()
        {
            SectionBAL objBAL = new SectionBAL();
            SectionDAL objDAL = new SectionDAL();
            objBAL.Office_id = OfficeID;
            cmbOfficeSection.DataSource = objDAL.LoadAll(objBAL);
            cmbOfficeSection.ValueMember = "section_id";
            cmbOfficeSection.DisplayMember = "name";
            cmbOfficeSection.SelectedIndex = -1;
        }

        private void cmbOrg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrg.SelectedValue.ToString());
            loadCmbOrgBranch();
        }

        private void cmbOrgBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbOrgBranch.SelectedValue.ToString());
            loadCbxDept();
        }

        private void cmbDept_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepartmentID = Guid.Parse(cmbDept.SelectedValue.ToString());
            loadCbxDeptOffice();
        }

        private void cmbDeptOfficce_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OfficeID = Guid.Parse(cmbDeptOfficce.SelectedValue.ToString());
            loadCbxOfficeSection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchEmployeeAttendence();
        }

        private void gridMultipleAttendence_Click(object sender, EventArgs e)
        {

        }

        private void btnTabClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            gridMultipleAttendence.DataSource = null;
            txtReg.Clear();
            txtName.Clear();
            cmbOrg.SelectedIndex = -1;
            cmbOrgBranch.SelectedIndex = -1;
            cmbDept.SelectedIndex = -1;
            cmbDeptOfficce.SelectedIndex = -1;
            cmbOfficeSection.SelectedIndex = -1;
            btnSave.LabelText = "Save";
            lblStatus.Text = "";
        }
        private void clearSave()
        {
            gridMultipleAttendence.DataSource = null;
            txtReg.Clear();
            txtName.Clear();
            cmbOrg.SelectedIndex = -1;
            cmbOrgBranch.SelectedIndex = -1;
            cmbDept.SelectedIndex = -1;
            cmbDeptOfficce.SelectedIndex = -1;
            cmbOfficeSection.SelectedIndex = -1;
            btnSave.LabelText = "Save";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeAttendenceBAL obj = new EmployeeAttendenceBAL();
            for (int i = 0; i < gridMultipleAttendence.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(gridMultipleAttendence.Rows[i].Cells[0].Value))
                    {
                        
                        EmployeeID = Guid.Parse(gridMultipleAttendence.Rows[i].Cells[1].Value.ToString());
                        EmployeeAttendenceBAL objBAL = new EmployeeAttendenceBAL();
                        EmployeeAttendenceDAL objDAL = new EmployeeAttendenceDAL();
                        objBAL.Employee_id = EmployeeID;
                        objBAL.AddDate = dtpMultipleAttendence.Value;
                        objDAL.Delete(objBAL);

                        //for loop on columns i.e 7 times
                        // to insert 7 records in attendance database
                        for (int x = 0; x < 5; x++)
                        {
                            EmployAttendanceDAL objDal = new EmployAttendanceDAL();
                            EmployeAttendenceBAL ob = new EmployeAttendenceBAL();
                            EmployeePersonalInfoDAL empDal = new EmployeePersonalInfoDAL();
                            EmployeePersonalInfoBAL empBal = new EmployeePersonalInfoBAL();
                            ob.employid = EmployeeID;
                            ob.date = dtpMultipleAttendence.Value;
                            try {
                                if (x == 0)
                                {
                                    ob.timein = DateTime.Parse(gridMultipleAttendence.Rows[i].Cells[4].Value.ToString());
                                    ob.type = "Temp-In";
                                    ob.status = "Temp-In";

                                }
                                else if (x == 1)
                                {
                                    ob.timein = DateTime.Parse(gridMultipleAttendence.Rows[i].Cells[5].Value.ToString());
                                    ob.type = "Temp-out";


                                }
                                else if (x == 2)
                                {
                                    ob.timein = DateTime.Parse(gridMultipleAttendence.Rows[i].Cells[6].Value.ToString());
                                    ob.type = "Time-In";
                                    

                                }
                                else if (x == 3)
                                {
                                    ob.timein = DateTime.Parse(gridMultipleAttendence.Rows[i].Cells[7].Value.ToString());
                                    ob.type = "Time-Out";

                                }
                                else if (x == 4)
                                {
                                    ob.timein = DateTime.Parse(gridMultipleAttendence.Rows[i].Cells[8].Value.ToString());
                                    ob.type = "Half-Leave";

                                }
                                else if (x == 5)
                                {
                                    ob.timein = DateTime.Parse(gridMultipleAttendence.Rows[i].Cells[9].Value.ToString());
                                    ob.type = "Overtime";

                                }
                                ob.status = "Present";
                                objDal.TimeIn(ob);
                            }
                            catch { }

                        }
                       
                     
                    }
            
                }
                catch { }
                
            }
            lblStatus.Text = "Records Saved Successfully!";
            clearSave();
        }

        private void LoadGrid()
        {
            for (int x = 0; x < gridMultipleAttendence.RowCount; x++)
            {
                EmployeeID = Guid.Parse(gridMultipleAttendence.Rows[x].Cells["employee_id"].Value.ToString());
                EmployAttendanceDAL objDAL = new EmployAttendanceDAL();
                DateTime date = dtpMultipleAttendence.Value;
                DataTable dt = objDAL.LoadEmployData_ByID(EmployeeID,date);
                foreach (DataRow row in dt.Rows)
                {
                    string type = row["type"].ToString();
                    DateTime Time = DateTime.Parse(row["time_in"].ToString());

                    if (type == "Temp-In")
                    {
                        this.gridMultipleAttendence.Rows[x].Cells[1].Value = Time;
                    }
                    else if (type == "Temp-Out")
                    {
                        this.gridMultipleAttendence.Rows[x].Cells[2].Value = Time;
                    }
                    else if (type == "Time-In")
                    {
                        this.gridMultipleAttendence.Rows[x].Cells[3].Value = Time;
                    }
                    else if (type == "Time-Out")
                    {
                        this.gridMultipleAttendence.Rows[x].Cells[4].Value = Time;
                    }
                    else if (type == "Half-Leave")
                    {
                        this.gridMultipleAttendence.Rows[x].Cells[5].Value = Time;
                    }
                    else if (type == "Overtime")
                    {
                        this.gridMultipleAttendence.Rows[x].Cells[6].Value = Time;
                    }

                }
            }
        }

        private void txtReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbOrg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



       
        