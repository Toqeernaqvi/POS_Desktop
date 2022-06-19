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

namespace SicParvisMagna.Forms
{
    public partial class ucChartOfAccounts : UserControl
    {
        public string pgURL;
        public bool PerView;
        bool LinkExpanded = false;
        private FormMain formMain;
        public ucChartOfAccounts(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btnManageFeeHeads_Click(object sender, EventArgs e)
        {
            pgURL = "Manage Fee Head";
            // PermissionDAL.Permission(Program.User_id, pgURL, PerView);
            PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView);

            formMain.formHeadingNonStatic.Text = "Manage Fee Head";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
               // formMain.loadOrganizationForm();
                formMain.loadFeeHeadForm();
               // FormMain.loadFeeHeadForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }

           
        }

        private void btnDepartmentClass_Click(object sender, EventArgs e)
        {
            pgURL = "Manage Department Classes";
            // PermissionDAL.Permission(Program.User_id, pgURL, PerView);
            PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView);

            formMain.formHeadingNonStatic.Text = "Manage Department Classes";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                // formMain.loadOrganizationForm();
                formMain.loadManageDepartmentClassesForm();
                // FormMain.loadFeeHeadForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }

            
        }

        private void btnGenerateFee_Click(object sender, EventArgs e)
        {
            pgURL = "Generate Fee";
            // PermissionDAL.Permission(Program.User_id, pgURL, PerView);
            PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView);

            formMain.formHeadingNonStatic.Text = "Generate Fee";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                // formMain.loadOrganizationForm();
                formMain.loadGenerateFeeForm();
                // FormMain.loadFeeHeadForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }


             
        }

        private void btnFormFeeSubmit_Click(object sender, EventArgs e)
        {
            pgURL = "Form Fee Submit";
            // PermissionDAL.Permission(Program.User_id, pgURL, PerView);
            PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView);

            formMain.formHeadingNonStatic.Text = "Form Fee Submit";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                // formMain.loadOrganizationForm();
                formMain.loadFormFeeSubmit();
                // FormMain.loadFeeHeadForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
        }

        private void btnFeeChallanReport_Click(object sender, EventArgs e)
        {
            
                FormReport rptview = new FormReport("Fee Generate", "FeeGenerate");
                rptview.ShowDialog(this);
            

            

        }

        private void btnFeeChallanGroupReport_Click(object sender, EventArgs e)
        {
            FormReport rptview = new FormReport("Fee Generate", "FeeGenerate2");
            rptview.ShowDialog(this);
        }

        private void btnManageArrearAndAccounts_Click(object sender, EventArgs e)
        {
            pgURL = "Manage Arrear And Discounts";
            // PermissionDAL.Permission(Program.User_id, pgURL, PerView);
            PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView);

            formMain.formHeadingNonStatic.Text = "Manage Arrear And Discounts";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                // formMain.loadOrganizationForm();
                formMain.loadManageArrearAndDiscount();
                // FormMain.loadFeeHeadForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
        }
    }
}
