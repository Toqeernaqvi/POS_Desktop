using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Library;
using System.Data.SqlClient;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms.Hospital.Medicine
{
    public partial class ucHCC_Balance : UserControl
    {
        private int ClassID = 0;
        Validations v = new Validations();
        private int count = 0;
        private int status = 0;
        private int SectionID = 0;
        private int testCATid = 0;
        private int testGENid = 0;
        private bool h_s = false;
        private int teacherId = 0;
        private int SessionID = 0;

        private FormMain formMain;
        public ucHCC_Balance(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formMain.loadMedicineBackForm();
            //FormMain.loadMedicineBackForm();
        }
        private bool ValidateForm()
        {
            //   bool var2;
            //var2 = v.required(comboBox_Secion.Text);
            //if (!var2)
            //{
            //    lblError_section.Text = "*Required";
            //    count++;
            //}
            //else
            //{
            //    lblError_section.Text = "";

            //    count = 100;
            //}

            //if (var1 && var2)
            //{
            //    return false;
            //}
            return true;
        }
        private void btn_LoadREcords_Click(object sender, EventArgs e)
        {
            if (SearchValidation())
            {
               // FormReport Form = new FormReport("Top Students - Montly Report", "TopStudentInAllDept", dtp_Month.Value, dtp_Month.Value);
               // Form.Show();
            }
        }

        private bool SearchValidation()
        {
            return true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            HCC_Balance_BAL objBal = new HCC_Balance_BAL();
            HCC_Balance_DAL objDal = new HCC_Balance_DAL();
            objBal.date = dtp_Month.Value;

            objDal.CloseMonth(objBal);
            MessageBox.Show("Successfully closed month " + dtp_Month.Value.ToString("MM"));
        }
    }
}
