using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCRUD.Controllers;

namespace SicParvisMagna.Controls.Buttons
{
    public partial class ManageOrganizations : UserControl
    {
        public string pgURL;
        public bool PerView;
        bool LinkExpanded = false;
        private FormMain formMain;

        public ManageOrganizations(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;

        }

        private void btnOrganizarions_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 290;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 43;
                LinkExpanded = false;
            }
        }

        private void btnOrganization_Click(object sender, EventArgs e)
        {
            pgURL = "Organizations";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);

            
            //formMain.formHeadingNonStatic.Text = "Organizations";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //  //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
            //    formMain.loadOrganizationForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //   // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //    formMain.AccessDenied();
            //}

            formMain.loadOrganizationForm();
        }
       
        private void btnBranch_Click(object sender, EventArgs e)
        {
            //pgURL = "Branches";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            //formMain.formHeadingNonStatic.Text = "Branches";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
            //    formMain.loadBranchForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //    formMain.AccessDenied();
            //}
            formMain.loadBranchForm();
        }

        private void btnDomain_Click(object sender, EventArgs e)
        {
            pgURL = "Domains";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "Domains";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                formMain.loadDomainForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadDomainForm();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //pgURL = "Departments";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            //formMain.formHeadingNonStatic.Text = "Departments";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
            //    formMain.loadDepartmentForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //    formMain.AccessDenied();
            //}
           formMain.loadDepartmentForm();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //pgURL = "Offices";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            //formMain.formHeadingNonStatic.Text = "Offices";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
            //    formMain.loadOfficeForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //    formMain.AccessDenied();
            //}
            formMain.loadOfficeForm();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //pgURL = "Sections";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            //formMain.formHeadingNonStatic.Text = "Sections";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
            //    formMain.loadSectionForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //    formMain.AccessDenied();
            //}
            formMain.loadSectionForm();
        }
    }
}
