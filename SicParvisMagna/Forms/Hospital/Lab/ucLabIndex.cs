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
using SicParvisMagna.Forms.PointOfSale;

namespace SicParvisMagna.Forms.Hospital.Lab
{
    public partial class ucLabIndex : UserControl
    {
        public string pgURL;
        public bool PerView;
        private POSMain formMain;

      

        public ucLabIndex(POSMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btn_Lab_Click(object sender, EventArgs e)
        {
            //pgURL = "Manage Lab";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            //formMain.formHeadingNonStatic.Text = "Manage Lab";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
                formMain.loadLabForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //    formMain.AccessDenied();
            //}
            //FormMain.loadLabForm();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            //pgURL = "Manage Test";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);
            
            //formMain.formHeadingNonStatic.Text = "Manage Test";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
                formMain.loadTestForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //   // formMain.AccessDenied();
            //}
            //FormMain.loadTestForm();
        }

        private void btn_LabTest_Click(object sender, EventArgs e)
        {
            //pgURL = "Manage Lab Test";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            //formMain.formHeadingNonStatic.Text = "Manage Lab Test";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
                formMain.loadLabTestForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //  //  formMain.AccessDenied();
            //}
            ////FormMain.loadLabTestForm();
        }

        private void btn_LabIV_Click(object sender, EventArgs e)
        {
            //pgURL = "Manage Lab Invoice";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            //formMain.formHeadingNonStatic.Text = "Manage Lab Invoice";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
                formMain.loadLabInvoiceForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //  //  formMain.AccessDenied();
            //}
            ////FormMain.loadLabInvoiceForm();
        }

        private void btn_LabIVIncome_Click(object sender, EventArgs e)
        {
            //pgURL = "Manage Lab Invoice Income";
            //PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            //formMain.formHeadingNonStatic.Text = "Manage Lab Invoice Income";
            //pgURL = formMain.formHeadingNonStatic.Text;
            //try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            //catch (Exception r)
            //{
            //    //MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerView == true)
            //{
                formMain.loadLabInvoiceIncomeForm();
            //}
            //else
            //{
            //    formMain.formHeadingNonStatic.Text = "Permission Denied";
            //    // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
            //  //  formMain.AccessDenied();
            //}
            //FormMain.loadLabInvoiceIncomeForm();
        }

        private void btn_LabIndexBack_Click(object sender, EventArgs e)
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
               // formMain.loadIndexBackForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
               // // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                //formMain.AccessDenied();
            }
            //FormMain.loadIndexBackForm();
        }

        private void btnPatatient_Click(object sender, EventArgs e)
        {
            formMain.loadPatient();
        }

      

        private void btnPatientPrescription_Click(object sender, EventArgs e)
        {
            formMain.loadPatientPrescription();
        }
    }
}
