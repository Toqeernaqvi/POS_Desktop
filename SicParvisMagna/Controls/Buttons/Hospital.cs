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
    public partial class Hospital : UserControl
    {
        public string pgURL;
        public bool PerView;
        bool LinkExpanded = false;
        private FormMain formMain;
        public Hospital(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btn_Hospital_Click(object sender, EventArgs e)
        {
            pgURL = "Hospital";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "Hospital";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                formMain.loadIndexBackForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadIndexBackForm();
            if (LinkExpanded == false)
            {
                this.Height = 265;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 45;
                LinkExpanded = false;
            }
        }

        private void btn_Lab_Click(object sender, EventArgs e)
        {
            pgURL = "Lab";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "Lab";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
               // formMain.loadLabIndexForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadLabIndexForm();
        }

        private void btn_Medicine_Click(object sender, EventArgs e)
        {
            pgURL = "Medicine";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "Medicine";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                formMain.loadMedicineIndexForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadMedicineIndexForm();
        }

        private void btn_Party_Click(object sender, EventArgs e)
        {
            pgURL = "Party";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "Party";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
               // formMain.loadPartyIndexForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadPartyIndexForm();
        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            pgURL = "Patient";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "Patient";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
              //  formMain.loadPatientIndexForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadPatientIndexForm();
        }
    }
}
