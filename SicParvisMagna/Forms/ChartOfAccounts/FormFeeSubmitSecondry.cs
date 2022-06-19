using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms.ChartOfAccounts
{
    public partial class FormFeeSubmitSecondry : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        private Guid StudentID = Guid.Empty;
        private Guid FeeChallanID = Guid.Empty;
        private Int64 num;
        public FormFeeSubmitSecondry(Guid challanID, Guid studentID)
        {
            InitializeComponent();
            FeeChallanID = challanID;
            StudentID = studentID;
            loadGridFeeGenerated();
        }
        public void loadGridFeeGenerated()
        {
            FeeGenerateDAL objDAL = new FeeGenerateDAL();
            FeeGenerateBAL objBAL = new FeeGenerateBAL();

            DataTable dt = new DataTable();
            objBAL.student_challan_id = FeeChallanID;
            dt = objDAL.getStudentChallanForFeeSubmittion(objBAL);

            lblChallan.Text += dt.Rows[0]["challan_no"].ToString();
            lblTotalAmount.Text = dt.Rows[0]["Total"].ToString();
            try { lblPendingFee.Text = dt.Rows[0]["arrear"].ToString(); } catch { lblPendingFee.Text = "0"; }
            lblArrear.Text += "0";
            try
            { lblGrandTotal.Text = (Convert.ToInt32(lblTotalAmount.Text) + Convert.ToInt32(lblPendingFee.Text)).ToString(); }
            catch { lblGrandTotal.Text = "0"; }
        }

        private bool ValidateForm()
        {
            //if (string.IsNullOrWhiteSpace(txtbClassName.Text))
            //{
            //    lblError_ClassTitle.Text = "Class name required! Hence you must enter the class name. thankyou";
            //    this.ActiveControl = txtbClassName;
            //    txtbClassName.Select();
            //    txtbClassName.Focus();
            //    return false;
            //}
            //else
            //    lblError_ClassTitle.Text = "";

            return true;
        }

        private bool ValidateFeeGenerate()
        {
            return true;
        }
        public void clearALL()
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            num = (((Convert.ToInt64(lblTotalAmount.Text) + (Convert.ToInt64(lblPendingFee.Text))) - Convert.ToInt64(numericUpDown1.Value)));
            lblArrear.Text = "Arrear: " + num;

        }

       

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateFeeGenerate())
            {
                FeeGenerateDAL objd = new FeeGenerateDAL();
                FeeGenerateBAL objStud = new FeeGenerateBAL();

                objStud.arrear = Convert.ToInt32(num);
                objStud.deposited_amount = Convert.ToInt32(numericUpDown1.Value.ToString());
                objStud.student_id = StudentID;
                objStud.student_challan_id = FeeChallanID;
                objStud.RecieptNumber = txtReciept.Text;

                objd.saveStudentFee(objStud);

                MessageBox.Show("Fee Submitted!", "Fee Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
