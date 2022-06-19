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
    public partial class Marksheet : UserControl
    {
        private static string pgURL;
        private  bool PerView;

        private FormMain parentFormMain;
        bool LinkExpanded = false;
        public Marksheet(FormMain parentForm)
        {
            InitializeComponent();
            this.parentFormMain = parentForm;
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 100;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 47;
                LinkExpanded = false;
            }
        }

        private void btnManualAttendence_Click(object sender, EventArgs e)
        {
            pgURL = "Marksheets";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            parentFormMain.formHeadingNonStatic.Text = "Marksheets";
            pgURL = parentFormMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                parentFormMain.loadMarksheetLoadForm();
            }
            else
            {
                parentFormMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                parentFormMain.AccessDenied();
            }
           // parentFormMain.loadMarksheetLoadForm();
        }
    }
}
