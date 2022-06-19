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
    public partial class ucFormSection : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
       // private Guid count = Guid.Empty;
        private Guid SectionID = Guid.Empty;
        private Guid ClassID = Guid.Empty;
    

        private Guid UserID = Guid.Empty;

        private Guid OrgID = Guid.Empty;
    //    private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;

        public ucFormSection()
        {
            InitializeComponent();
           
        }


        private void LoadSection()
        {
            AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
            AcademicsSectionBAL objBAL = new AcademicsSectionBAL();
            objBAL.branchid = BranchID;
            gridSection.DataSource = objDAL.LoadByBranch(objBAL);

      
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


        private void Loadallclass()
        {
            ClassDAL objDAL = new ClassDAL();
            ClassBAL objBAL = new ClassBAL();
            objBAL.branchid = BranchID;
            comboBox_class.DataSource = objDAL.LoadByBranch(objBAL);
            comboBox_class.ValueMember = "id";
            comboBox_class.DisplayMember = "title";
            comboBox_class.SelectedIndex = -1;
        }


        //private void Loadclassbybranchid()
        ////{
        //    BranchID=Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
        //    //MessageBox.Show(BranchID.ToString());
        //    ClassDAL objDAL = new ClassDAL();
        //    ClassBAL objBal = new ClassBAL();
        //    objBal.branchid = BranchID;
        //    comboBox_class.DataSource = objDAL.Loadbyinstid(objBal);
        //    comboBox_class.ValueMember = "Orangization_id";
        //    comboBox_class.DisplayMember = "title";
        //    comboBox_class.SelectedIndex = -1;
        //}




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

            //
            if (comboBox_class.SelectedIndex < 0)
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
                AcademicsSectionBAL objBAL = new AcademicsSectionBAL();
                AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
                objBAL.title = txt_title.Text;
                objBAL.urdu_title = txt_Urdu_title.Text;
                objBAL.classid = ClassID;
                objBAL.branchid = BranchID;
                objBAL.OrgId = OrgID;
                objBAL.status = 1;
                      
                if (SectionID == Guid.Empty)
                {
                    
                    objBAL.Add_by = Guid.Empty;
                    objBAL.Add_date = DateTime.Today;
                    //Insert
                    objDAL.Add(objBAL);
                }
                else
                {

                    objBAL.id = SectionID;
                    objBAL.Edit_by = Guid.Empty;
                    objBAL.Edit_date = DateTime.Today;
                    //Update
                    objDAL.Update(objBAL);
                    lblStatus.Text = objBAL.title + " updated successfully";
                }
                LoadSection();
                ClearPartially();
              //  ClearAll();
           //     MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Fill All Required Fields");
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
           
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
        }

        private void ContntLoad(DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SectionID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.section ";
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


                if (!string.IsNullOrEmpty(cmbOrganization.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   OrganizationId like '%" + cmbOrganization.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }


                if (!string.IsNullOrEmpty(cmbOrganizationBranch.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  [branchid] like '%" + cmbOrganizationBranch.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND [branchid] like '%" + cmbOrganizationBranch.Text + "%'";
                }
                if (!string.IsNullOrEmpty(comboBox_class.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  classid like '%" + comboBox_class.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND classid like '%" + comboBox_class.Text + "%'";
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

                gridSection.DataSource = dt;
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





        private void comboBox_class_SelectionChangeCommitted(object sender, EventArgs e)
        {
           ClassID= Guid.Parse(comboBox_class.SelectedValue.ToString());
            
          
        }

        private void combo_Branch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
          BranchID = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
            Loadallclass();
            LoadSection();
         
        }

        public void ClearPartially()
        {

            ClassID = Guid.Empty;
            // status = "";


            //  fee = Guid.Empty;
            //BranchID = Guid.Empty;
            txt_title.Text = "*";
            txt_Urdu_title.Text = "";

            lblError_ClassTitle.Text = "";

            lblError_Class.Text = "*";
            lblError_Branch.Text = "*";
            lblError_Org.Text = "*";
           
            comboBox_class.SelectedIndex = -1;
            cmbOrganizationBranch.SelectedIndex = -1;
            cmbOrganization.SelectedIndex = -1;
            lblStatus.Text = "";
            //            cmbOrganization.SelectedIndex = -1;

            btnSave.Text = "Save";
        }

        private void ClearAll()
        {
            //count = 0;
            gridSection.DataSource = null;
            SectionID = Guid.Empty;
            ClassID = Guid.Empty;
            UserID = Guid.Empty;
            BranchID = Guid.Empty;
            OrgID = Guid.Empty;
            
            cmbOrganization.SelectedIndex = -1;
            lblError_Branch.Text = "";
            lblError_Org.Text = "";
            lblError_Class.Text = "";
            txt_title.Text = "";
            txt_Urdu_title.Text = "";
            cmbOrganizationBranch.SelectedIndex = -1;
            comboBox_class.SelectedIndex = -1;
            btnSave.Text = "Save";

         //   LoadSection();            
        }

        private void gridSection_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                OrgID = Guid.Parse(gridSection.Rows[rowindex].Cells["OrganizationId"].Value.ToString());
                cmbOrganization.SelectedValue = OrgID;
                LoadCmbOrgBranch();
                SectionID = Guid.Parse(gridSection.Rows[rowindex].Cells["id"].Value.ToString());
            txt_title.Text = gridSection.Rows[rowindex].Cells["title"].Value.ToString();
            txt_Urdu_title.Text = gridSection.Rows[rowindex].Cells["urdu_title"].Value.ToString();
                BranchID = Guid.Parse(gridSection.Rows[rowindex].Cells["branchid"].Value.ToString());
                cmbOrganizationBranch.SelectedValue = BranchID;
                Loadallclass();
            ClassID = Guid.Parse(gridSection.Rows[rowindex].Cells["classid"].Value.ToString());
                comboBox_class.SelectedValue = ClassID;
                
           // UserID = Guid.Parse(gridSection.Rows[rowindex].Cells["userid"].Value.ToString());
            // int.TryParse(gridSection.Rows[rowindex].Cells["status"].Value.ToString(), out status);
          
            btnSave.Text = "Update";
            ValidateForm();
        }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (SectionID!= Guid.Empty)
            {
                AcademicsSectionBAL objBAL = new AcademicsSectionBAL();
                AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
                objBAL.id = SectionID;
                objDAL.Delete(objBAL);
                ClearPartially();
                LoadSection();
            }
            else
            {
                lblStatus.Text = " No class selected to delete";
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblError_Branch_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Class_Click(object sender, EventArgs e)
        {

        }

        private void cmbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucAddsection_Load(object sender, EventArgs e)
        {
          LoadCmbOrg();
          
            ClearAll();
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());

            LoadCmbOrgBranch();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }




}
