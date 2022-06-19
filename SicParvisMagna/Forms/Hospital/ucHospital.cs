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

namespace SicParvisMagna.Forms.Hospital
{
    public partial class ucHospital : UserControl
    {
        public string pgURL;
        public bool PerView;
        private FormMain formMain;
        public ucHospital(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btn_medicine_Click(object sender, EventArgs e)
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

        private void btn_party_Click(object sender, EventArgs e)
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
              //  formMain.loadLabIndexForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadLabIndexForm();
        }
    }
}
