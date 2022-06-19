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
    public partial class ucFormTestGen : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        // private Guid count = Guid.Empty;

        private Guid testgen_id = Guid.Empty;
        private Guid testcat_id = Guid.Empty;
        private Guid UserID = Guid.Empty;
        private Guid OrgID = Guid.Empty;
        //    private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;



        public ucFormTestGen()
        {
            InitializeComponent();

        }


        private void LoadtestGEN()
        {
            test_genDAL objDAL = new test_genDAL();
            test_genBAL objBAL = new test_genBAL();
            objBAL.test_cat_id = testcat_id;
            gridTestGEN.DataSource = objDAL.LoadbyTestCAT(objBAL);
          
        }
        private void LoadtestCAT()
        {
            test_catDAL objDAL = new test_catDAL();
            test_catBAL objBAL = new test_catBAL();
            objBAL.branchid = BranchID;
            cbx_Cat.DataSource = objDAL.Loadbybranch(objBAL);
         //   cbx_Cat.DataSource = objDAL.LoadBranch(obj);
            cbx_Cat.ValueMember = "id";
            cbx_Cat.DisplayMember = "Title";
            cbx_Cat.SelectedIndex = -1;


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

     



        private bool ValidateForm()
        {
            bool validated = true;


            //For CityName
            if (string.IsNullOrEmpty(txt_title.Text))
            {
                lblError_Title.Text += "  Name required!";
                validated = false;
            }
            else
            {
                lblError_Title.Text = "";
            }

            if (!Validation.isAlphaNumeric(txt_title.Text))
            {
                lblError_Title.Text += "Name Should be in  Alphabets and Numbers!";
                validated = false;
            }
            else
            {
                lblError_Title.Text = "";
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


            if (cbx_Cat.SelectedIndex < 0)
            {
               lblErrorCat.Text += "* Test category is required!";
                validated = false;
            }
            else
            {
                lblErrorCat.Text = "";
            }
            //



            //====================================================

            return validated;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {


            if (ValidateForm())
            {
                test_genBAL objBAL = new test_genBAL();
                test_genDAL  objDAL = new test_genDAL();
                objBAL.test_title = txt_title.Text;
                objBAL.test_desc = txt_desc.Text;
                objBAL.test_cat_id = testcat_id;
                objBAL.branchid = BranchID;
                objBAL.OrgID = OrgID;
                objBAL.userid = UserID;
                objBAL.Due_Date = DateTime.Now;
                objBAL.Start_time = DateTime.Now;
                objBAL.End_time = DateTime.Now;
                objBAL.Relaxation_time = DateTime.Now;
                objBAL.status = "active";

                if (testgen_id==Guid.Empty)
                {

                    objBAL.Add_by = Guid.Empty;
                    objBAL.Add_Date = DateTime.Today;
                    //Insert
                    objDAL.Add(objBAL);
                }
                else
                {

                    objBAL.id = testgen_id;
                    objBAL.Edit_By = Guid.Empty;
                    objBAL.Edit_Date = DateTime.Today;
                    //Update
                    objDAL.Update(objBAL);
                    lblStatus.Text = objBAL.test_title + " updated successfully";
                }
             
                ClearPartially();
                LoadtestCAT();
                //  ClearAll();
                //     MessageBox.Show("Done");
            }
            else
            {
               // MessageBox.Show("Fill All Required Fields");
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
            if (testgen_id != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.test_gen ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txt_title.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   test_title like '%" + txt_title.Text + "%'";
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

                gridTestGEN.DataSource = dt;
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
            // ClassID= Guid.Parse(comboBox_class.SelectedValue.ToString());


        }

        private void combo_Branch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            BranchID = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
            LoadtestCAT();

        }

        public void ClearPartially()
        {
            testgen_id = Guid.Empty;
            testcat_id = Guid.Empty;
            // status = "";


            //  fee = Guid.Empty;
            //BranchID = Guid.Empty;
            txt_title.Text = "";
            //  txt_Urdu_title.Text = "";
            txt_desc.Text = "";
            lblError_Title.Text = "";
            lblErrorCat.Text = "";
            //  lblError_Class.Text = "*";
            lblError_Branch.Text = "*";
            lblError_Org.Text = "*";

            //  comboBox_class.SelectedIndex = -1;
            cmbOrganizationBranch.SelectedIndex = -1;
            cmbOrganization.SelectedIndex = -1;
            cbx_Cat.SelectedIndex = -1;
            lblStatus.Text = "";
            //            cmbOrganization.SelectedIndex = -1;

            btnSave.Text = "Save";
        }

        private void ClearAll()
        {
            //count = 0;
            gridTestGEN.DataSource = null;


            OrgID = Guid.Empty;

            cmbOrganization.SelectedIndex = -1;
            lblError_Branch.Text = "";
            lblError_Org.Text = "";
            lblErrorCat.Text = "";
            lblError_Title.Text = "";
            txt_title.Text = "";
            txt_desc.Text = "";
            cmbOrganizationBranch.SelectedIndex = -1;
            cbx_Cat.SelectedIndex = -1;
            lblStatus.Text = "";
            btnSave.Text = "Save";

            //   LoadSection();            
        }

        private void gridSection_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (testgen_id != Guid.Empty)
            {
                test_genBAL objBAL = new test_genBAL();
                test_genDAL objDAL = new test_genDAL();
                objBAL.id = testgen_id;
                objDAL.Delete(objBAL);
                ClearPartially();
                LoadtestCAT();

            //    lblStatus.Text = objBAL.title + " deleted successfully";
            }
            else
            {
                lblStatus.Text = " No row selected to delete";
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
            
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrgID = Guid.Parse(cmbOrganization.SelectedValue.ToString());

            LoadCmbOrgBranch();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridTestcat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                testgen_id = Guid.Parse(gridTestGEN.Rows[rowindex].Cells["id"].Value.ToString());
                OrgID = Guid.Parse(gridTestGEN.Rows[rowindex].Cells["OrgID"].Value.ToString());
                cmbOrganization.SelectedValue = OrgID;
                LoadCmbOrgBranch();
                txt_title.Text = gridTestGEN.Rows[rowindex].Cells["test_title"].Value.ToString();
                txt_desc.Text = gridTestGEN.Rows[rowindex].Cells["description"].Value.ToString();

                BranchID = Guid.Parse(gridTestGEN.Rows[rowindex].Cells["branchid"].Value.ToString());
                cmbOrganizationBranch.SelectedValue = BranchID;
                LoadtestCAT();
                testcat_id = Guid.Parse(gridTestGEN.Rows[rowindex].Cells["test_cat_id"].Value.ToString());

                cbx_Cat.SelectedValue = testcat_id;
                dtp_dd.Text = gridTestGEN.Rows[rowindex].Cells["Due_Date"].Value.ToString();
                dtp_start.Text = gridTestGEN.Rows[rowindex].Cells["Start_time"].Value.ToString();
                dtp_end.Text = gridTestGEN.Rows[rowindex].Cells["End_time"].Value.ToString();
                dtp_relax.Text = gridTestGEN.Rows[rowindex].Cells["Relaxation_time"].Value.ToString();
                //  UserID = Guid.Parse(gridTestCAT.Rows[rowindex].Cells["userid"].Value.ToString());
                // UserID = Guid.Parse(gridSection.Rows[rowindex].Cells["userid"].Value.ToString());
                // int.TryParse(gridSection.Rows[rowindex].Cells["status"].Value.ToString(), out status);

                btnSave.LabelText = "Update";
                ValidateForm();
            }
        }

        private void ucAddtestcat_Load(object sender, EventArgs e)
        {
           
        }

        private void cbx_Cat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            testcat_id =Guid.Parse(cbx_Cat.SelectedValue.ToString());
            LoadtestGEN();
        }

        private void ucAddtestGen_Load(object sender, EventArgs e)
        {
            ClearAll();
            LoadCmbOrg();

        }
    }
}
