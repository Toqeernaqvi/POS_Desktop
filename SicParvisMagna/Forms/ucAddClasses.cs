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
    public partial class ucAddClasses : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        // Validations v = new Validations();
        public Guid count = Guid.Empty;
        public Guid ClassID = Guid.Empty;
        //private int status = 0;
        public Guid UserID = Guid.Empty;
        private Guid OrgID = Guid.Empty;
        private Guid OrganizationID = Guid.Empty;
        // private int fee;
        public Guid BranchID = Guid.Empty;
        public ucAddClasses()
        {
            InitializeComponent();
        }

        private void ucAddClasses_Load(object sender, EventArgs e)
        {
            //LoadClass();
            // LoadallBranch();
            LoadCmbOrg();
            ClearAll();

        }


        private void LoadClass()
        {
            ClassDAL objDAL = new ClassDAL();
            gridClass.DataSource = objDAL.LoadAll();

            //LoadallBranch();
        }

        //private void LoadallBranch()
        //{
        //    _1BranchDAL objDAL = new _1BranchDAL();
        //    cmbOrganization.DataSource = objDAL.LoadAll_DT();
        //    cmbOrganization.ValueMember = "Organization_id";
        //    cmbOrganization.DisplayMember = "title";
        //    cmbOrganization.SelectedIndex = -1;
        //}


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


        public void ClearAll()
        {
            count = Guid.Empty;
            ClassID = Guid.Empty;
            // status = "";

            UserID = Guid.Empty;
            //  fee = Guid.Empty;
            BranchID = Guid.Empty;

            txt_title.Text = "";
            txt_Urdu_title.Text = "";
            txt_fee.Text = "";
            cmbOrganization.SelectedIndex = -1;
            cmbOrganizationBranch.SelectedIndex = -1;
            combolevel.SelectedIndex = -1;
            btnSave.Text = "Save";
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

            if (!Validation.isAlpha(txt_title.Text, 20))
            {
                if (string.IsNullOrEmpty(txt_title.Text))
                    lblError_ClassTitle.Text += "\n";
                lblError_ClassTitle.Text += "Name Should be in  Alphabets and  MAximum Length 20 chracters!";
                validated = false;
            }
            else
            {
                lblError_ClassTitle.Text = "";
            }



            if (string.IsNullOrEmpty(cmbOrganization.Text))
            {
                lblError_Branch.Text += "Branch   is required!";
                validated = false;
            }
            else
            {
                lblError_Branch.Text = "";
            }
            if (!Validation.isBoard(cmbOrganization.Text, 7))
            {
                if (string.IsNullOrEmpty(cmbOrganization.Text))
                    lblError_Branch.Text += "\n";
                lblError_Branch.Text += "select a Branch!";
                validated = false;
            }
            else
            {
                lblError_Branch.Text = "";
            }
            //
            if (string.IsNullOrEmpty(combolevel.Text))
            {
                lbl_levelError.Text += "level   is required!";
                validated = false;
            }
            else
            {
                lbl_levelError.Text = "";
            }
            if (!Validation.isBoard(combolevel.Text, 7))
            {
                if (string.IsNullOrEmpty(combolevel.Text))
                    lbl_levelError.Text += "\n";
                lbl_levelError.Text += "select a level!";
                validated = false;
            }
            else
            {
                lbl_levelError.Text = "";
            }


            //====================================================

            return validated;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateForm())


            {
                ClassBAL objBAL = new ClassBAL();
                ClassDAL objDAL = new ClassDAL();
                objBAL.title = txt_title.Text;
                objBAL.organizationid= OrgID;
                objBAL.branchid = BranchID;
               // objBAL.userid = UserID;
                objBAL.status = "active";
                objBAL.fee = txt_fee.Text;
                objBAL.urdu_title = txt_Urdu_title.Text;

                objBAL.class_level = combolevel.Text;


                if (ClassID == Guid.Empty)
                {
                    objBAL.Add_by = Program.User_id;
                    objBAL.timestamp = DateTime.Today;
                    //Insert
                    objDAL.Add(objBAL);
                }
                else
                {
                    // objBAL.id = ClassID;
                    objBAL.Add_by = Program.User_id;
                    objBAL.timestamp = DateTime.Today;
                    //Update
                    objDAL.Update(objBAL);
                }
                LoadClass();
                ClearAll();
                 
            }
            else
            {
                MessageBox.Show("Fill All Required Fields");
            }

        }







        private void gridClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)

            {
                OrgID = Guid.Parse(gridClass.Rows[rowindex].Cells["Organization_id"].Value.ToString());
                //  int.TryParse(gridDomain.Rows[rowindex].Cells["Organization_id"].Value.ToString(), out OrgID);
                cmbOrganization.SelectedValue = OrgID;
                BranchID = Guid.Parse(gridClass.Rows[rowindex].Cells["Parent_id"].Value.ToString());
                // int.TryParse(gridDomain.Rows[rowindex].Cells["Parent_id"].Value.ToString(), out BranchID);
                cmbOrganizationBranch.SelectedValue = BranchID;

                ClassID = Guid.Parse(gridClass.Rows[rowindex].Cells["id"].Value.ToString());

                txt_title.Text = gridClass.Rows[rowindex].Cells["title"].Value.ToString();
                txt_Urdu_title.Text = gridClass.Rows[rowindex].Cells["urdu_title"].Value.ToString();

                txt_fee.Text = gridClass.Rows[rowindex].Cells["fee"].Value.ToString();

               // BranchID = Guid.Parse(gridClass.Rows[rowindex].Cells["branchid"].Value.ToString());
                UserID = Guid.Parse(gridClass.Rows[rowindex].Cells["userid"].Value.ToString());
                //  int.TryParse(gridClass.Rows[rowindex].Cells["status"].Value.ToString(), out status);

                combolevel.Text = gridClass.Rows[rowindex].Cells["class_level"].Value.ToString();
                cmbOrganization.SelectedValue = BranchID;

                btnSave.Text = "  Update";
                ValidateForm();
            }
        }

        private void gridClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void combo_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // int.TryParse(combo_Branch.SelectedValue.ToString(), out BranchID);
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (OrgID != null)
            {
                OrganizationBAL objBAL = new OrganizationBAL();
                OrganizationDAL objDAL = new OrganizationDAL();
                objBAL.Organization_id = OrgID;
                objDAL.Delete(objBAL);

                ClearAll();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContntLoad(DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ClassID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.classes ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txt_title.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  title like '%" + txt_title.Text + "%'";
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

                gridClass.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

            gridClass.DataSource = null;
            lblError_ClassTitle.Text = "";
            lblError_UrduTitle.Text = "";
            lblError_Fees.Text = "";
            lblError_Branch.Text = "";
            lbl_levelError.Text = "";
            //  LblError_desc.Text = "";

            ClearAll();
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            //int.TryParse(cmbOrganization.SelectedValue.ToString(), out OrgID);
            LoadCmbOrgBranch();
        }

        private void cmbOrganizationBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
            LoadClass();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (ClassID != Guid.Empty)
            {
                ClassBAL objBAL = new ClassBAL();
                ClassDAL objDAL = new ClassDAL();
                objBAL.id = ClassID;
                objDAL.Delete(objBAL);
                ClearAll();
                //  ClearAll();
                //    LoadSubjects();
              //  lblErrorStatus.Text = objBAL.title + " deleted successfully";
            }
            else
            {
                MessageBox.Show("Please Select a section Row or Cell to Delete");
            }
        }

        private void gridClass_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)

            {

                ClassID = Guid.Parse(gridClass.Rows[rowindex].Cells["id"].Value.ToString());
                OrgID = Guid.Parse(gridClass.Rows[rowindex].Cells["organizationid"].Value.ToString());
                cmbOrganization.SelectedValue = OrgID;
                LoadCmbOrgBranch();

                BranchID = Guid.Parse(gridClass.Rows[rowindex].Cells["branchid"].Value.ToString());
             
                cmbOrganizationBranch.SelectedValue = BranchID;


                txt_title.Text = gridClass.Rows[rowindex].Cells["title"].Value.ToString();
                txt_Urdu_title.Text = gridClass.Rows[rowindex].Cells["urdu_title"].Value.ToString();

                txt_fee.Text = gridClass.Rows[rowindex].Cells["fee"].Value.ToString();

                // BranchID = Guid.Parse(gridClass.Rows[rowindex].Cells["branchid"].Value.ToString());
               // UserID = Guid.Parse(gridClass.Rows[rowindex].Cells["userid"].Value.ToString());
                //  int.TryParse(gridClass.Rows[rowindex].Cells["status"].Value.ToString(), out status);

                combolevel.Text = gridClass.Rows[rowindex].Cells["class_level"].Value.ToString();
           //     cmbOrganization.SelectedValue = BranchID;

                btnSave.Text = " Update";
                ValidateForm();
            }
        }



        //    private void ucAddClasses_Load(object sender, EventArgs e)
        //    {
        //        LoadClass();
        //        LoadallBranch();
        //        ClearAll();

        //    }

        //}
    }
}
