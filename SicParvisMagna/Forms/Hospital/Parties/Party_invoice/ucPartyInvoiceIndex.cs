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

namespace SicParvisMagna.Forms.Hospital.Parties.Party_invoice
{
    public partial class ucPartyInvoiceIndex : UserControl
    {
        public string pgURL;
        public bool PerView;
        private FormMain formMain;
        public ucPartyInvoiceIndex(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btn_partyIV_Click(object sender, EventArgs e)
        {
            pgURL = "Party Invoice Invoice";
            PermissionDAL.Permission(Program.User_id, pgURL, PerView);


            formMain.formHeadingNonStatic.Text = "Manage Party Invoice";
            pgURL = formMain.formHeadingNonStatic.Text;
            try { PerView = Convert.ToBoolean(PermissionDAL.Permission(Program.User_id, pgURL, PerView).Rows[0]["PerView"].ToString()); }
            catch (Exception r)
            {
                //MessageBox.Show("Error:" + r.Message);
            }
            if (PerView == true)
            {
                formMain.loadPartyInvoiceForm();
            }
            else
            {
                formMain.formHeadingNonStatic.Text = "Permission Denied";
                // FormMain frm = new FormMain(Program.User_name,Program.User_id).formMain;
                formMain.AccessDenied();
            }
            //FormMain.loadPartyInvoiceForm();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
           // formMain.loadPartyIndexForm();
            //FormMain.loadPartyIndexForm();
        }
    }
}
