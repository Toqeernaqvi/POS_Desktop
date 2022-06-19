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

namespace SicParvisMagna.Forms.Hospital.Medicine
{
    public partial class ucMedicineIndex : UserControl
    {
        public string pgURL;
        public bool PerView;
        private FormMain formMain;
        public ucMedicineIndex(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btn_medicine_Click(object sender, EventArgs e)
        {
          //  formMain.loadMedicineForm();
            //FormMain.loadMedicineForm();
        }

        private void btn_HCC_Click(object sender, EventArgs e)
        {
            formMain.loadHCCBalanceForm();
            //FormMain.loadHCCBalanceForm();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
           // formMain.loadReduceStockForm();
            //FormMain.loadReduceStockForm();
        }

        private void btn_Back_Click(object sender, EventArgs e)
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
        }
    }
}
