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
namespace SicParvisMagna.Forms.Hospital.Lab
{
    public partial class ucLab_InvoiceIncome : UserControl
    {
        ValidationRegex objvr = new ValidationRegex();
        bool[] var = new bool[4];
        private Guid id = Guid.Empty;
        lab_invoiceincomeDAL db = new lab_invoiceincomeDAL();
        lab_testDAL lab_test_db = new lab_testDAL();
        patient_basicDAL patient_basic_db = new patient_basicDAL();
        DateTime testDate;
        private POSMain formMain;
        public ucLab_InvoiceIncome(POSMain formMain)
        {
            InitializeComponent();
            this.cmbx_Patient.SelectedIndexChanged += new System.EventHandler(this.cmbx_Test_SelectedIndexChanged);
            this.cmbx_Patient.Leave += new System.EventHandler(this.cmbx_Test_Leave);

            this.cmbx_LabTest.SelectedIndexChanged += new System.EventHandler(this.cmbx_Lab_SelectedIndexChanged);
            this.cmbx_LabTest.Leave += new System.EventHandler(this.cmbx_Lab_Leave);


            this.txt_Price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Price_KeyUp);
            this.txt_Price.Leave += new System.EventHandler(this.txt_Price_Leave);


            this.txt_Discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Discount_KeyUp);
            this.txt_Discount.Leave += new System.EventHandler(this.txt_Discount_Leave);

            for (int x = 0; x < var.Length; x++)
                var[x] = false;
            LoadGrid();
            LoadPatient();
            LoadLab();
            this.formMain = formMain;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formMain.loadLabBackForm();
            //FormMain.loadLabBackForm();
        }
        public void LoadPatient()
        {
            cmbx_Patient.DataSource = patient_basic_db.LoadAll();
            cmbx_Patient.DisplayMember = "patient_name";
            cmbx_Patient.ValueMember = "patient_id";
            cmbx_Patient.SelectedIndex = -1;
        }

        //Validation Method
        public bool Validate_cmbx_Test()
        {
            if (cmbx_Patient.Text == string.Empty)
            {
                lblError_Patient.Text = "*Required";
                return false;
            }
            lblError_Patient.Text = "";
            return true;
        }
        private void cmbx_Test_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_Test();
        }

        //ON Leave
        private void cmbx_Test_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_Test();
        }

        public void LoadLab()
        {
            cmbx_LabTest.DataSource = lab_test_db.LoadAll();
            cmbx_LabTest.DisplayMember = "name";
            cmbx_LabTest.ValueMember = "lab_test_id";
            cmbx_LabTest.SelectedIndex = -1;
        }

        //Validation Method
        public bool Validate_cmbx_Lab()
        {
            if (cmbx_LabTest.Text == string.Empty)
            {
                lblError_LabTest.Text = "*Required";
                return false;
            }
            lblError_LabTest.Text = "";
            //CalculateNetTotal();
            return true;
        }

        //SelectedIndexChanged
        private void cmbx_Lab_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_Lab();
        }

        //ON Leave
        private void cmbx_Lab_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_Lab();
        }


        //Validation Method
        public bool Validate_txt_Price()
        {
            if (txt_Price.Text == string.Empty)
            {
                lblError_Price.Text = "*Required";
                return false;
            }
            else
            {
                string pattern = "^[0-9]{1,11}$";
                System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(txt_Price.Text, pattern);
                if (result.Success)
                {
                    lblError_Price.Text = "";
                    // CalculateNetTotal();
                    return true;
                }
                else
                {
                    lblError_Price.Text = "Invalid Price";
                    return false;
                }
            }
        }

        private void txt_Price_Leave(object sender, EventArgs e)
        {
            Validate_txt_Price();
        }

        private void txt_Price_KeyUp(object sender, KeyEventArgs e)
        {
            Validate_txt_Price();
        }
        public bool Validate_txt_Discount()
        {
            //  if (txt_Discount.Text == string.Empty)
            //    {
            //        lblError_Discount.Text = "*Required";
            //       return false;
            //   }
            //   else
            //   {
            // string pattern = "^[0-9]{1,3}$";
            //   System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(txt_Discount.Text, pattern);
            //   if (result.Success)
            //   {
            //      if (Convert.ToInt32(txt_Discount.Text) <= 100)
            //       {
            //           lblError_Discount.Text = "";
            ///            CalculateNetTotal();
            return true;
            //        }
            //         else
            //           {
            //              lblError_Discount.Text = "Maximum discount is 100";
            //              return false;
            //           }
            //       }
            //      else
            //       {
            //         lblError_Discount.Text = "Invalid Discount";
            //           return false;
            //       }
            //    }
        }

        private void txt_Discount_Leave(object sender, EventArgs e)
        {
            Validate_txt_Discount();
        }

        private void txt_Discount_KeyUp(object sender, KeyEventArgs e)
        {
            Validate_txt_Discount();
        }
        public void CalculateNetTotal()
        {
            try
            {
                double price = Convert.ToDouble(txt_Price.Text);
                double discount = (Convert.ToDouble(txt_DiscountAmt.Text));
                txt_NetAmount.Text = (price - discount).ToString();
            }
            catch (Exception)
            {

                txt_NetAmount.Text = "0";
            }

        }
        private void LoadGrid()
        {
            gridLabIVIncome.Columns.Clear();
            gridLabIVIncome.Rows.Clear();
            gridLabIVIncome.Columns.Add("lab_invoice_income_id", "lab_invoice_income_id");
            gridLabIVIncome.Columns.Add("patient", "Patient");
            gridLabIVIncome.Columns[1].Width = 250;
            gridLabIVIncome.Columns.Add("LabTest", "Lab Test");
            gridLabIVIncome.Columns[2].Width = 250;
            gridLabIVIncome.Columns.Add("price", "Price");
            gridLabIVIncome.Columns.Add("discount", "Discount Percentage (%)");
            gridLabIVIncome.Columns.Add("discountAmt", "Discount Amount");
            gridLabIVIncome.Columns.Add("netAmount", "Total");
            gridLabIVIncome.Columns.Add("welfarediscount", "Welfare Discount");
            gridLabIVIncome.Columns.Add("nettotaal", "Net Total");
            gridLabIVIncome.Columns.Add("description", "Description");
            gridLabIVIncome.Columns["description"].Width = 250;
            gridLabIVIncome.Columns[0].Visible = false;

            foreach (var item in db.LoadAll())
            {
                gridLabIVIncome.Rows.Add(
                    item.lab_invoice_income_id,
                    patient_basic_db.LoadbyId(item.patient_id).FirstOrDefault().patient_name,
                    lab_test_db.LoadbyId(item.lab_test_id).FirstOrDefault().name,
                    item.price,
                    item.discount,
                    item.discountAmt,
                    item.netAmount,
                    item.welfarediscount,
                    item.nettotal,
                    item.description
                    );
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearAll()
        {
            id = Guid.Empty;
            cmbx_LabTest.SelectedIndex = -1;
            cmbx_Patient.SelectedIndex = -1;
            txt_Price.Text = "0";
            txt_Discount.Text = "0";
            txt_DiscountAmt.Text = "0";
            txt_WelfareDiscount.Text = "0";
            txt_NetTotal.Text = "0";
            txt_NetAmount.Text = "0";
            txt_Description.Text = "";
            txt_Patient_Name.Text = "";
            lblError_LabTest.Text = "";
            lblError_NetTotal.Text = "";
            lblError_WelfareDiscount.Text = "";
            lblError_LabTest.Text = "";
            lblError_Patient.Text = "";
            lblError_Price.Text = "";
            lblError_Discount.Text = "";
            lblError_NetAmount.Text = "";
            LoadPatient();
            testDate = new DateTime();

            btnSave.LabelText = "     Save";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }
        private void Search()
        {
            //gridVoucherCategory.DataSource = objDAL.Search(txt_search.Text);
            //     gridVoucherCategory.Columns[0].HeaderText = "ID";
            //gridVoucherCategory.Columns[0].Visible = false;
            //gridVoucherCategory.Columns[1].HeaderText = "Lab Name";
            //gridVoucherCategory.Columns[2].HeaderText = "Short Name";
            //gridVoucherCategory.Columns[3].HeaderText = "Code";
            //gridVoucherCategory.Columns[4].HeaderText = "Description";
            //gridVoucherCategory.Columns[5].HeaderText = "NTN";
            //gridVoucherCategory.Columns[6].HeaderText = "GST";
            //gridVoucherCategory.Columns[7].HeaderText = "Guarranty";
            //gridVoucherCategory.Columns[8].HeaderText = "STRN";
            //gridVoucherCategory.Columns[9].HeaderText = "Phone";
            //gridVoucherCategory.Columns[10].HeaderText = "Address";
            //gridVoucherCategory.Columns[11].HeaderText = "Email";
            //gridVoucherCategory.Columns[12].HeaderText = "Bank Account No";
            //gridVoucherCategory.Columns[12].Width = 200;
            //gridVoucherCategory.Columns[13].HeaderText = "IBAN";
            //gridVoucherCategory.Columns[14].Width = 200;
            //gridVoucherCategory.Columns["status"].Visible = false;
            //gridVoucherCategory.Focus();
        }
        private void Content(DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {

                Guid.TryParse(gridLabIVIncome.Rows[rowindex].Cells["lab_invoice_income_id"].Value.ToString(), out id);
                var lab_invoice = db.LoadbyId(id).FirstOrDefault();
                if (lab_invoice != null)
                {
                    cmbx_LabTest.SelectedValue = lab_invoice.lab_test_id;
                    cmbx_Patient.SelectedValue = lab_invoice.patient_id;
                    txt_Price.Text = lab_invoice.price.ToString();
                    txt_Discount.Text = lab_invoice.discount.ToString();
                    txt_DiscountAmt.Text = lab_invoice.discountAmt.ToString();
                    txt_NetTotal.Text = lab_invoice.nettotal.ToString();
                    txt_WelfareDiscount.Text = lab_invoice.welfarediscount.ToString();
                    txt_NetAmount.Text = lab_invoice.netAmount.ToString();
                    txt_Description.Text = lab_invoice.description;
                    dateTimePicker1.Value = lab_invoice.Date;
                    // testDate = lab_invoice.Date;
                }
                btnSave.LabelText = "     Update";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void gridLabIVIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void cmbx_LabTest_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Validate_cmbx_Lab())
            {
                Guid lab_test_id = Guid.Parse(cmbx_LabTest.SelectedValue.ToString());
                txt_Price.Text = lab_test_db.LoadbyId(lab_test_id).FirstOrDefault().price.ToString();

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            patient_basicBAL patient_basic = new patient_basicBAL();
            patient_basicDAL patient_basic_db = new patient_basicDAL();

            patient_basic.patient_name = txt_Patient_Name.Text;
            patient_basic.patient_record_no = txt_Patient_Name.Text;
            cmbx_Patient.DataSource = null;
            cmbx_Patient.DataSource = patient_basic_db.Search(patient_basic);
            cmbx_Patient.DisplayMember = "concati";
            cmbx_Patient.ValueMember = "patient_id";
            cmbx_Patient.SelectedIndex = -1;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (Validate_cmbx_Test() && Validate_cmbx_Lab() && Validate_txt_Price())
            {
                lab_invoiceincomeBAL objBAL = new lab_invoiceincomeBAL();
                objBAL.lab_test_id = Guid.Parse(cmbx_LabTest.SelectedValue.ToString());
                objBAL.patient_id = Guid.Parse(cmbx_Patient.SelectedValue.ToString());
                objBAL.price = (int)Convert.ToDecimal(txt_Price.Text);
                objBAL.discount = (int)Convert.ToDecimal(txt_Discount.Text);
                objBAL.discountAmt = (int)Convert.ToDecimal(txt_DiscountAmt.Text);
                objBAL.welfarediscount = (int)Convert.ToDecimal(txt_WelfareDiscount.Text);
                objBAL.nettotal = (int)Convert.ToDecimal(txt_NetTotal.Text);
                objBAL.netAmount = (int)Convert.ToDecimal(txt_NetAmount.Text);
                objBAL.description = txt_Description.Text;
                objBAL.Date = dateTimePicker1.Value;

                if (id != Guid.Empty)
                {
                    objBAL.lab_invoice_income_id = id;
                    objBAL.Editby = "Admin";
                    objBAL.EditDate = DateTime.Now;
                    db.Update(objBAL);
                }
                else
                {
                    objBAL.Addby = "Admin";
                    objBAL.AddDate = DateTime.Now;
                    objBAL.Flag = 1;
                    objBAL.status = true;
                    db.Add(objBAL);
                }

                ClearAll();
                LoadGrid();

            }
            else
            {

                MessageBox.Show("Form is not Valid");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (id != Guid.Empty)
            {
                lab_invoiceincomeBAL objBAL = new lab_invoiceincomeBAL();
                objBAL.lab_invoice_income_id = id;
                db.Delete(objBAL);
                ClearAll();
                LoadGrid();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search();
        }
    }
}
