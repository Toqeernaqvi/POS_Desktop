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
    public partial class Test : UserControl
    {
        public string pgURL;
        public bool PerView;
        bool LinkExpanded = false;
        private FormMain formMain;

        public Test(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btnOpenHome_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 215;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 43;
                LinkExpanded = false;
            }
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            pgURL = "City";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "City";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                formMain.loadCityForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadCityForm();
        }

        private void btnState_Click(object sender, EventArgs e)
        {

            pgURL = "State";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "State";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                formMain.loadStateForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadStateForm();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
           FormMain.loadTestCatform();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
           FormMain.loadTestGenform();
        }
    }
 }
