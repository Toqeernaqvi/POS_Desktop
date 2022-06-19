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
    public partial class ucFormSession : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

      
        private Guid OrganizationID = Guid.Empty;
        private Guid Classid = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid Sessionid = Guid.Empty;
         SessionDAL obj = new SessionDAL();
        public ucFormSession()
        {
            InitializeComponent();
           
        }


        //private void LoadClass()
        //{
        //    ClassDAL objDAL = new ClassDAL();
        //    cmb_class.DataSource = objDAL.LoadAll();
        //    cmb_class.ValueMember = "id";
        //    cmb_class.DisplayMember = "title";
        //    cmb_class.SelectedIndex = -1;

        //    //LoadallBranch();
        //}
        private void LoadSessions()
        {
            SessionDAL obj = new SessionDAL();
            SessionBAL objBAL = new SessionBAL();
            objBAL.BranchId = BranchID;
            gridSessions.DataSource = obj.LoadByBranch(objBAL);
        }
    

       

        private void ucAddClasses_Load(object sender, EventArgs e)
        {
            ClearAll();
         //   LoadSessions();
            LoadCmbOrg();
          //  LoadClass();
         //   LoadCmbOrgBranch();

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
            obj.Parent_id = OrganizationID;
            cmbOrganizationBranch.DataSource = objDAL.LoadBranch(obj);
            cmbOrganizationBranch.ValueMember = "Organization_id";
            cmbOrganizationBranch.DisplayMember = "Title";
            cmbOrganizationBranch.SelectedIndex = -1;
        }





        private bool ValidateForm()
        {
            bool validated = true;


            //For CityName
            if (string.IsNullOrEmpty(txtbSession_Name.Text))
            {
                lblError_ClassTitle.Text += "  Name required!";
                validated = false;
            }
            else
            {
                lblError_ClassTitle.Text = "";
            }

            if (!Validation.isAlphaNumeric(txtbSession_Name.Text))
            {
                lblError_ClassTitle.Text += "Name Should be in  Alphabets and Numbers!";
                validated = false;
            }
            else
            {
                lblError_ClassTitle.Text = "";
            }


            if (cmbOrganization.SelectedIndex < 0)
            {
                lblError_Org.Text += "* Organization is required!";
                validated = false;
            }
            else
            {
                lblError_Org.Text = "";
            }


            if (cmbOrganizationBranch.SelectedIndex < 0)
            {
                lblError_Branch.Text += "* Branch is required!";
                validated = false;
            }
            else
            {
                lblError_Branch.Text = "";
            }

            //if (cmb_class.SelectedIndex < 0)
            //{
            //    LlblError_class.Text += "* class is required!";
            //    validated = false;
            //}
            //else
            //{
            //    LlblError_class.Text = "";
            //}


            //====================================================

            return validated;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            


             if (ValidateForm())
            {
                SessionBAL objBAL = new SessionBAL();
                objBAL.Session_Name = txtbSession_Name.Text;
                objBAL.OrgId = OrganizationID;
                objBAL.BranchId = BranchID;
                objBAL.UrduName = txt_urdu.Text;
                objBAL.status = 1;
           //     objBAL.ClassId = Classid;

                if (Sessionid==Guid.Empty)
                {

                  

                    objBAL.Add_by = Guid.Empty;
                    objBAL.Add_date = DateTime.Today;
                    obj.Add(objBAL);
                  
                    lblStatus.Text = objBAL.Session_Name + " saved successfully";
                }
                else
                {
                    objBAL.id = Sessionid;
                    objBAL.Edit_by = Guid.Empty;
                    objBAL.Edit_date = DateTime.Today;

                    obj.Update(objBAL);
                    lblStatus.Text = objBAL.Session_Name + " updated successfully";
                }
                ClearPartially();
                ClearAll();
               
            }
            else
            {
             //   MessageBox.Show("Fill All Required Fields");
            }
        }


        public void ClearPartially()
        {

            Sessionid = Guid.Empty;
         
            txtbSession_Name.Text = "";
            Classid = Guid.Empty;
            txt_urdu.Text = "";
            lblError_ClassTitle.Text = "";
            lblError_Branch.Text = "";
            lblError_Org.Text = "";
          //  LlblError_class.Text = "";
            lblStatus.Text = "";
            cmbOrganization.SelectedIndex = -1;
            cmbOrganizationBranch.SelectedIndex = -1;


            btnSave.Text = "Save";
        }
        private void ClearAll()
        {
            lblError_ClassTitle.Text = "";
            lblError_Branch.Text = "";
            lblError_Org.Text = "";
            lblStatus.Text = "";
            gridSessions.DataSource = null;
            txtbSession_Name.Text = "";
            txt_urdu.Text = "";
            cmbOrganization.SelectedIndex = -1;
            cmbOrganizationBranch.SelectedIndex = -1;
            Sessionid = Guid.Empty;
            OrganizationID = Guid.Empty;
            BranchID = Guid.Empty;
            txt_urdu.Text = "";
            btnSave.Text = "     Save";
          //  LoadSessions();


        }




        private void gridClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void combo_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // int.TryParse(combo_Branch.SelectedValue.ToString(), out BranchID);
           
           // ValidateForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
        }

        private void ContntLoad(DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Sessionid != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.Sessions ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtbSession_Name.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   Session_Name like '%" + txtbSession_Name.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(cmbOrganization.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   OrgId like '%" + cmbOrganization.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(cmbOrganizationBranch.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   BranchId like '%" + cmbOrganizationBranch.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
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

                gridSessions.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
           
        }





       // private void comboBox_class_SelectionChangeCommitted(object sender, EventArgs e)
       

        //private void combo_Branch_SelectionChangeCommitted_1(object sender, EventArgs e)
       
    

        private void gridSection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (Sessionid!= null)
            {
                SessionBAL objBAL = new SessionBAL();
                SessionDAL objDAL = new SessionDAL();
                objBAL.id = Sessionid;
                objDAL.Delete(objBAL);
                ClearPartially();
                //LoadSessions();
            }
            else
            {
                MessageBox.Show("Please Select a section Row or Cell to Delete");
            }
        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            //int.TryParse(cmbOrganization.SelectedValue.ToString(), out OrgID);
            LoadCmbOrgBranch();
        }

        private void cmbOrganizationBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
            //LoadClass();
            LoadSessions();
        }

        private void gridSession_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {

                Sessionid = Guid.Parse(gridSessions.Rows[rowindex].Cells["Session_id"].Value.ToString());
                txt_urdu.Text = gridSessions.Rows[rowindex].Cells["UrduName"].Value.ToString();
                txtbSession_Name.Text = gridSessions.Rows[rowindex].Cells["Session_Name"].Value.ToString();
                OrganizationID = Guid.Parse(gridSessions.Rows[rowindex].Cells["OrgId"].Value.ToString());
                cmbOrganization.SelectedValue = OrganizationID;
                LoadCmbOrgBranch();
                BranchID = Guid.Parse(gridSessions.Rows[rowindex].Cells["BranchId"].Value.ToString());
                cmbOrganizationBranch.SelectedValue = BranchID;
              


              //  Classid = Guid.Parse(gridSessions.Rows[rowindex].Cells["ClassId"].Value.ToString());
                btnSave.Text = "     Update";
            }
        }

        private void cmb_class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Classid = Guid.Parse(cmb_class.SelectedValue.ToString());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }




}

