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
    public partial class ucFormSubjects : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        // private Guid count = Guid.Empty;
        //   private Guid count = 0;
        private Guid SubjectID = Guid.Empty;
        private Guid ClassID = Guid.Empty;

        private Guid OrgID = Guid.Empty;
      
      
        private Guid BranchID = Guid.Empty;

        public ucFormSubjects()
        {
            InitializeComponent();
           
           // Loadallclass();
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
        private void LoadSubjects()
        {
            SubjectDAL objDAL = new SubjectDAL();
            SubjectBAL objBAL = new SubjectBAL();


            objBAL.branchid = BranchID;
            gridSubject.DataSource = objDAL.LoadByBranch(objBAL);
            
        }


        //private void LoadallBranch()
        //{
        //    _1BranchDAL objDAL = new _1BranchDAL();
        //    cmbOrganizationBranch.DataSource = objDAL.LoadAll_DT();
        //    cmbOrganizationBranch.ValueMember = "Organization_id";
        //    cmbOrganizationBranch.DisplayMember = "title";
        //    cmbOrganizationBranch.SelectedIndex = -1;
        //}

        private void ucAddClasses_Load(object sender, EventArgs e)
        {
           // LoadSubjects();
        //    Loadallclass();
            LoadCmbOrg();
            //ClearAll();
            //LoadCmbOrgBranch();
        }

        

        private void Loadallclass()
        {
            ClassDAL objDAL = new ClassDAL();
            ClassBAL objBAL = new ClassBAL();
            objBAL.branchid = BranchID;
            cmb_class.DataSource = objDAL.LoadByBranch(objBAL);
            cmb_class.ValueMember = "id";
            cmb_class.DisplayMember = "title";
            cmb_class.SelectedIndex = -1;
        }

     




        private bool ValidateForm()
        {
            bool validated = true;


            //For CityName
            if (string.IsNullOrEmpty(txt_title.Text))
            {
                lblError_ClassTitle.Text += "  Name required!";
                validated = false;
            }
            else
            {
                lblError_ClassTitle.Text = "";
            }

            if (!Validation.isAlphaNumeric(txt_title.Text))
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


            if (cmb_class.SelectedIndex < 0)
            {
                lblError_Class.Text += "* Class Level is required!";
                validated = false;
            }
            else
            {
                lblError_Class.Text = "";
            }

            //====================================================

            return validated;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {



            if (ValidateForm())
            {
                SubjectBAL objBAL = new SubjectBAL();
                SubjectDAL objDAL = new SubjectDAL();
                objBAL.title = txt_title.Text;
                objBAL.classid = ClassID;
                objBAL.branchid = BranchID;
                objBAL.orgID = OrgID;

                objBAL.status = 1;
                objBAL.urdu_title = txt_Urdu_title.Text;
            
                if (SubjectID == Guid.Empty)
                {
                    objBAL.Add_by = Guid.Empty;
                    objBAL.Add_date = DateTime.Today;

                    objDAL.Add(objBAL);
                    lblErrorStatus.Text = objBAL.title + " saved successfully";
                }
                else
                {
                    objBAL.id = SubjectID;
                    objBAL.Edit_by = Guid.Empty;
                    objBAL.Edit_date = DateTime.Today;

                    objDAL.Update(objBAL);
                    lblErrorStatus.Text = objBAL.title + " Updated successfully";
                }

                ClearPartially();
                //LoadSubjects();
                // MessageBox.Show("Done");
            }
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
           
          //  ValidateForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
        }

        private void ContntLoad(DataGridViewCellEventArgs e)
        {

        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SubjectID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.subjects ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txt_title.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   title like '%" + txt_title.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

              
                if (!string.IsNullOrEmpty(cmbOrganizationBranch.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  branchid like '%" + cmbOrganizationBranch.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    //    query += "  AND branchid like '%" + cmbOrganizationBranch.Text + "%'";
                }
                if (!string.IsNullOrEmpty(cmb_class.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  classid like '%" + cmb_class.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    //    query += "  AND classid like '%" + cmb_class.Text + "%'";
                }

                if (!string.IsNullOrEmpty(cmbOrganization.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  orgID like '%" + cmbOrganization.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    //    query += "  AND orgID like '%" + cmbOrganization.Text + "%'";
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

                gridSubject.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
          //  LoadSubjects();
        }





        private void comboBox_class_SelectionChangeCommitted(object sender, EventArgs e)
        {
           ClassID= Guid.Parse(cmb_class.SelectedValue.ToString());
            
            
        }

        private void combo_Branch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
          BranchID = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
            Loadallclass();
            LoadSubjects();
        }


        public void ClearPartially()
        {

           
            
            txt_title.Text = "";
            txt_Urdu_title.Text = "";
          

            lblError_ClassTitle.Text = "";

            lblError_Branch.Text = "";
            lblError_Org.Text = "";
            lblError_Class.Text = "";
            cmb_class.SelectedIndex = -1;
            lblErrorStatus.Text = "";
            cmbOrganization.SelectedIndex = -1;
            cmbOrganizationBranch.SelectedIndex = -1;
            cmb_class.SelectedIndex = -1;
           

            btnSave.Text = "Save";
        }
        private void ClearAll()
        {
            //count = 0;
            gridSubject.DataSource = null;
            SubjectID = Guid.Empty;
            ClassID = Guid.Empty;
            OrgID = Guid.Empty;
          
            BranchID = Guid.Empty;
            lblError_ClassTitle.Text = "";

            lblError_Branch.Text = "";
            lblError_Org.Text = "";
            lblError_Class.Text = "";
        
            txt_title.Text = "";
            txt_Urdu_title.Text = "";
            cmbOrganization.SelectedIndex = -1;
            cmbOrganizationBranch.SelectedIndex = -1;
            cmb_class.SelectedIndex = -1;
            btnSave.Text = "Save";
            
            
        }

        private void gridSection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (SubjectID!= Guid.Empty)
            {
                SubjectBAL objBAL = new SubjectBAL();
                SubjectDAL objDAL = new SubjectDAL();
                objBAL.id = SubjectID;
                objDAL.Delete(objBAL);
                ClearPartially();
              //  ClearAll();
            //    LoadSubjects();
                lblErrorStatus.Text = objBAL.title + " deleted successfully";
            }
            else
            {
                MessageBox.Show("Please Select a section Row or Cell to Delete");
            }
        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            //int.TryParse(cmbOrganization.SelectedValue.ToString(), out OrgID);
            LoadCmbOrgBranch();
        }

        private void gridSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                SubjectID = Guid.Parse(gridSubject.Rows[rowindex].Cells["id"].Value.ToString());
                txt_title.Text = gridSubject.Rows[rowindex].Cells["title"].Value.ToString();
                txt_Urdu_title.Text = gridSubject.Rows[rowindex].Cells["UrduTitle"].Value.ToString();
                OrgID = Guid.Parse(gridSubject.Rows[rowindex].Cells["orgID"].Value.ToString());
                cmbOrganization.SelectedValue = OrgID;
                LoadCmbOrgBranch();

                BranchID = Guid.Parse(gridSubject.Rows[rowindex].Cells["branchid"].Value.ToString());
                cmbOrganizationBranch.SelectedValue = BranchID;
                Loadallclass();
                ClassID = Guid.Parse(gridSubject.Rows[rowindex].Cells["classid"].Value.ToString());
                cmb_class.SelectedValue = ClassID;
                btnSave.Text = "Update";
                ValidateForm();
            }
        }
    }




}
