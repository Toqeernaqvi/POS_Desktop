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

namespace SicParvisMagna.Forms
{

    
    public partial class ucIssueListing : UserControl
    {
        private Guid Issueid = Guid.Empty;

        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();


        private FormMain parentForm;
        
        public ucIssueListing(FormMain frm)
        {
            InitializeComponent();
            parentForm = frm;
        }
        public ucIssueListing()
        {
            InitializeComponent();
//            parentForm = frm;
        }


        private void loadOpenIssues()
        {
            IssueDAL objDAL = new IssueDAL();

            gridOpenIssues.DataSource = objDAL.LoadOpen();
            gridOpenIssues.Columns["ViewIssues"].DisplayIndex = gridOpenIssues.Columns.Count - 1;
            gridOpenIssues.Columns["Issue_Id"].Visible = false;
            opentab.Text = "Opened Issues (" + gridOpenIssues.Rows.Count + ")";
        }
        private void loadCloseIssues()
        {
            IssueDAL objDAL = new IssueDAL();

            gridClosedIssues.DataSource = objDAL.LoadOpen();
            if (gridClosedIssues.Columns.Count > 0)
                gridClosedIssues.Columns["ViewIssue"].DisplayIndex = gridClosedIssues.Columns.Count - 1;
            gridClosedIssues.Columns["Issue_Id"].Visible = false;
            closetab.Text = "Closed Issue (" + gridClosedIssues.Rows.Count + ")";
        }





        private void LoadAll()
        {
            IssueDAL objDAL = new IssueDAL();

            gridAllIssues.DataSource = objDAL.LoadAll();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
     
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            

        }
       
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //Delete button
            //User Personal
          

        }
        
        
       
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
         




        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {

           


        }

        private void GridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (e.ColumnIndex == 0)
            {

               if( Guid.TryParse(gridOpenIssues.Rows[rowindex].Cells["Issue_id"].Value.ToString(), out Issueid))
                parentForm.loadCommentsForm(Issueid);
                //else 
                    //Shoe error
                //  FormCity f5 = new FormCity();

                //  f5.Show();

                // dataGridView1 selectedRow = (dataGridView1)((LinkButton)e.CommandSource).NamingContainer;
            }
            //
        }

        private void cmbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
          //  cmbCountry.SelectedValue = CountryID;
          
        }

        private void cmbState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cmbState.SelectedValue = stateID;
          
        }

        private void cmbCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
          

        }

        private void cmbAccountType_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void EnableTab(TabPage page, bool enable)
        {
           // foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }
        /////////////////////////////////////////////
        private void ucAddUsers_Load(object sender, EventArgs e)
        {
            loadGrids();


        }

        public void loadGrids()
        {
            loadOpenIssues();
            loadCloseIssues();
            LoadAll();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
 

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void gridUserEducation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (e.ColumnIndex == 0)
            {

               Guid.TryParse(gridClosedIssues.Rows[rowindex].Cells["Issue_id"].Value.ToString(), out Issueid);
               // Issueid = Guid.Parse(gridClosedIssues.Rows[rowindex].Cells["Issue_id"].Value.ToString());
                //  FormCity f5 = new FormCity();
                //  f5.Show();
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
          

        }

        private void btnAddExperincePic_Click(object sender, EventArgs e)
        {
            

        }

        private void btnRemoveExperiencePic_Click(object sender, EventArgs e)
        {
            experiencePicbox.Image = null;

        }
       
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

     
        private void gridUserExperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

           
            
        }
        private void loadTabs()
        {
          
        }
        private void tabControlUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //            if (tabControl.SelectedTab == tabControl.TabPages[0])
            //                do something...
            //if (tabControl.SelectedTab == tabControl.TabPages[1])
            //                do something else...
            //if (tabControl.SelectedTab == tabControl.TabPages[2])
            //                do something else...

          
        }

   

        private void gridUserExperience_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gridUserEducation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperience_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void gridUserExperience_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperience_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
        }

        private void gridUserExperience_DataError_2(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbUserExperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int.TryParse(cmbUser.SelectedValue.ToString(), out UserID);
         
        }

        private void gridAllIssues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (e.ColumnIndex == 0)
            {

                Guid.TryParse(gridAllIssues.Rows[rowindex].Cells["Issue_id"].Value.ToString(), out Issueid);
                //  FormCity f5 = new FormCity();
                //  f5.Show();
            }
        }

        private void gridOpenIssues_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int col = e.ColumnIndex;
            int row = e.RowIndex;
            //gridOpenedIssues
           Guid issueID = Guid.Parse(gridOpenIssues.Rows[row].Cells["Issue_id"].Value.ToString());
            ucComments f5 = new ucComments(parentForm, issueID);
            f5.Show();
        }

        private void opentab_Click(object sender, EventArgs e)
        {
            IssueDAL objDAL = new IssueDAL();
            gridOpenIssues.DataSource = objDAL.LoadOpen();
        }

        private void closetab_Click(object sender, EventArgs e)
        {
            IssueDAL objDAL = new IssueDAL();
            gridOpenIssues.DataSource = objDAL.LoadClose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Issue_tab where Title like '" + txt_searchbox.Text + "%'", con);

            DataTable dt = new DataTable();

            da.Fill(dt);
            gridAllIssues.DataSource = dt;

        }
    }
}

