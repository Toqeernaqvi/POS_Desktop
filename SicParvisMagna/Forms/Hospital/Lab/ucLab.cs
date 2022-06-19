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
    public partial class ucLab : UserControl
    {
        ValidationRegex objvr = new ValidationRegex();
        bool[] var = new bool[11];
        private Guid id = Guid.Empty;
        labDAL objDAL = new labDAL();
        private POSMain formMain;
        public ucLab(POSMain formMain)
        {
            InitializeComponent();
            for (int x = 0; x < var.Length; x++)
                var[x] = false;
            LoadCountry();
            LoadLabType();
            this.formMain = formMain;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formMain.loadLabBackForm();
            //FormMain.loadLabBackForm();
        }
        public void inti()
        {
            for (int x = 0; x < var.Length; x++)
                var[x] = false;
            lblError_name.Text = "Name is Required";

            lblError_ShortName.Text = "";
            lbl_ErrorCode.Text = "";
            lblError_Description.Text = "";
            txt_Name.Text = "";
            txt_shortName.Text = "";
            txt_Description.Text = "";
            txt_code.Text = "";
            txt_National_Tax_Number.Text = "";
            txt_goods_and_service_tax.Text = "";
            txt_Gurranty.Text = "";
            txt_Standard_Report_Number.Text = "";
            txt_phone.Text = "";
            txt_Address.Text = "";
            txt_email.Text = "";
            txt_Bank_account_number.Text = "";
            txt_iban.Text = "";
        }

        private void LoadCountry()
        {
            gridLab.DataSource = objDAL.LoadAll();
            gridLab.Columns[0].HeaderText = "ID";
            gridLab.Columns[0].Visible = false;
            gridLab.Columns[1].HeaderText = "Lab Name";
            gridLab.Columns[2].HeaderText = "Short Name";
            gridLab.Columns[3].HeaderText = "Code";
            gridLab.Columns[4].HeaderText = "Description";
            gridLab.Columns[5].HeaderText = "NTN";
            gridLab.Columns[6].HeaderText = "GST";
            gridLab.Columns[7].HeaderText = "Guarranty";
            gridLab.Columns[8].HeaderText = "STRN";
            gridLab.Columns[9].HeaderText = "Phone";
            gridLab.Columns[10].HeaderText = "Address";
            gridLab.Columns[11].HeaderText = "Email";
            gridLab.Columns[12].HeaderText = "Bank Account No";
            gridLab.Columns[12].Width = 200;
            gridLab.Columns[13].HeaderText = "IBAN";
            gridLab.Columns[14].Width = 200;
            gridLab.Columns["status"].Visible = false;
            gridLab.Columns["Addby"].Visible = false;
            gridLab.Columns["AddDate"].Visible = false;
            gridLab.Columns["Editby"].Visible = false;
            gridLab.Columns["EditDate"].Visible = false;
            gridLab.Columns["Flag"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

        }
        private void ClearAll()
        {
            cmbType.SelectedIndex = -1;
            inti();
            id = Guid.Empty;

            btnSave.LabelText =  "Save";
        }

        private void Valid_it()
        {
            lblError_name.Text = "";
            lblError_ShortName.Text = "";
            lbl_ErrorCode.Text = "";
            lblError_Description.Text = "";
            for (int x = 0; x < var.Length; x++)
            {
                var[x] = true;
            }
        }
        private bool ValidateForm()
        {
            for (int x = 0; x < var.Length; x++)
            {
                if (x != 1)
                    var[x] = true;

                if (!var[x])
                {
                    return false;
                }
            }
            return true;
        }

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                lblError_name.Text = "Required!";
                var[0] = false;
            }
            else
            {
                var[0] = true;
                lblError_name.Text = "";
            }
        }

        private void txt_Name_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Name.Text == "")
            {
                lblError_name.Text = "Required!";
                var[0] = false;
            }
            else
            {
                var[0] = true;
                lblError_name.Text = "";
            }
        }

        private void txt_shortName_Leave(object sender, EventArgs e)
        {
            var[1] = true;
            if (txt_shortName.Text == "")
            {
                lblError_ShortName.Text = "Required!";
                // var[1] = false;
            }
            else
            {
                //  var[1] = true;
                lblError_ShortName.Text = "";
            }
        }

        private void txt_shortName_KeyUp(object sender, KeyEventArgs e)
        {
            var[1] = true;
            if (txt_shortName.Text == "")
            {
                lblError_ShortName.Text = "Required!";
                // var[1] = false;
            }
            else
            {
                //  var[1] = true;
                lblError_ShortName.Text = "";
            }
        }

        private void txt_Description_Leave(object sender, EventArgs e)
        {
            var[3] = true;
            if (!objvr.description(txt_Description.Text, 10, 50))
            {
                lblError_Description.Text = "Invalid Description";
                //  var[3] = false;
            }
            else
            {
                // var[3] = true;
                lblError_Description.Text = "";
            }
        }

        private void txt_Description_KeyUp(object sender, KeyEventArgs e)
        {
            var[3] = true;
            if (!objvr.description(txt_Description.Text, 10, 50))
            {
                lblError_Description.Text = "Invalid Description";
                //  var[3] = false;
            }
            else
            {
                // var[3] = true;
                lblError_Description.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
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

                id = Guid.Parse(gridLab.Rows[rowindex].Cells["lab_id"].Value.ToString());
                txt_Name.Text = gridLab.Rows[rowindex].Cells["name"].Value.ToString();

                txt_shortName.Text = gridLab.Rows[rowindex].Cells["shortname"].Value.ToString();


                txt_code.Text = gridLab.Rows[rowindex].Cells["code"].Value.ToString();

                txt_Description.Text = gridLab.Rows[rowindex].Cells["desctiption"].Value.ToString();

                txt_National_Tax_Number.Text = gridLab.Rows[rowindex].Cells["National_Tax_Number"].Value.ToString();

                txt_goods_and_service_tax.Text = gridLab.Rows[rowindex].Cells["Goods_And_Services_Tax"].Value.ToString();

                txt_Gurranty.Text = gridLab.Rows[rowindex].Cells["Guarranty"].Value.ToString();

                txt_Standard_Report_Number.Text = gridLab.Rows[rowindex].Cells["Standard_Report_Number"].Value.ToString();

                txt_phone.Text = gridLab.Rows[rowindex].Cells["phone"].Value.ToString();

                txt_Address.Text = gridLab.Rows[rowindex].Cells["address"].Value.ToString();

                txt_email.Text = gridLab.Rows[rowindex].Cells["email"].Value.ToString();

                txt_Bank_account_number.Text = gridLab.Rows[rowindex].Cells["Bank_account_number"].Value.ToString();

                txt_iban.Text = gridLab.Rows[rowindex].Cells["International_Account_Number"].Value.ToString();

                cmbType.Text = gridLab.Rows[rowindex].Cells["Type"].Value.ToString();

                Valid_it();
                btnSave.LabelText = "     Update";
            }
        }

        private void gridLab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        public void ValidateCode()
        {
            var[1] = true;
            if (!objvr.alphanumeric(txt_code.Text, 2, 20))
            {
                lbl_ErrorCode.Text = "Invalid Code";
                // var[1] = false;
            }
            else
            {
                //var[1] = true;
                lbl_ErrorCode.Text = "";
            }
        }


        public void ValidateNTN()
        {
            var[2] = true;
            if (!objvr.National_Tax_Number(txt_National_Tax_Number.Text))
            {
                lblError_National_Tax_Number.Text = "Invalid NTN";
                // var[2] = false;
            }
            else
            {
                //var[2] = true;
                lblError_National_Tax_Number.Text = "";
            }
        }
        public void ValidateGST()
        {
            var[3] = true;
            if (!objvr.numeric(txt_goods_and_service_tax.Text, 1, 11))
            {
                lblError_Goods_And_Services_Tax.Text = "Invalid GST";
                // var[3] = false;
            }
            else
            {
                //  var[3] = true;
                lblError_Goods_And_Services_Tax.Text = "";
            }
        }
        public void ValidateGurranty()
        {
            var[4] = true;
            if (!objvr.alphasapce(txt_Gurranty.Text, 3, 11))
            {
                lblError_Gurranty.Text = "Invalid Gurranty";
                //var[4] = false;
            }
            else
            {
                //var[4] = true;
                lblError_Gurranty.Text = "";
            }
        }
        public void ValidateSTN()
        {
            var[5] = true;
            if (!objvr.numeric(txt_Standard_Report_Number.Text, 3, 11))
            {
                lblError_Standard_Report_Number.Text = "Invalid STN";
                // var[5] = false;
            }
            else
            {
                // var[5] = true;
                lblError_Standard_Report_Number.Text = "";
            }
        }
        public void Validatephone()
        {
            var[6] = true;
            if (!objvr.phoneno(txt_phone.Text) || !objvr.tel(txt_phone.Text))
            {
                lblError_phone.Text = "Invalid phone";
                //var[6] = false;
            }
            else
            {
                // var[6] = true;
                lblError_phone.Text = "";
            }
        }
        public void ValidateAddress()
        {
            var[7] = true;
            if (!objvr.address(txt_Address.Text))
            {
                lblError_Address.Text = "Invalid Address";
                //var[7] = false;
            }
            else
            {
                //var[7] = true;
                lblError_Address.Text = "";
            }
        }
        public void ValidateEmail()
        {
            var[8] = true;
            if (!objvr.Email(txt_email.Text))
            {
                lblError_email.Text = "Invalid Email";
                //var[8] = false;
            }
            else
            {
                // var[8] = true;
                lblError_email.Text = "";
            }
        }
        public void ValidateBankaccno()
        {
            var[9] = true;
            if (!objvr.Bank_account_number_pk(txt_Bank_account_number.Text))
            {
                lblError_Bank_account_number.Text = "Invalid Bank Account no";
                // var[9] = false;
            }
            else
            {
                // var[9] = true;
                lblError_Bank_account_number.Text = "";
            }
        }
        public void ValidateInernationalBankAccno()
        {
            var[10] = true;
            if (!objvr.Bank_account_number_iban(txt_iban.Text))
            {
                lblError_IBAN.Text = "Invalid Bank Account no";
                //var[10] = false;
            }
            else
            {
                //var[10] = true;
                lblError_IBAN.Text = "";
            }
        }

        private void txt_phone_KeyUp(object sender, KeyEventArgs e)
        {
            Validatephone();
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            Validatephone();
        }

        private void txt_Address_Leave(object sender, EventArgs e)
        {
            ValidateAddress();
        }

        private void txt_Address_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateAddress();
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void txt_email_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateEmail();
        }

        private void txt_National_Tax_Number_Leave(object sender, EventArgs e)
        {
            ValidateNTN();
        }

        private void txt_National_Tax_Number_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNTN();
        }

        private void txt_goods_and_service_tax_Leave(object sender, EventArgs e)
        {
            ValidateGST();
        }

        private void txt_goods_and_service_tax_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateGST();
        }
        private void txt_Bank_account_number_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateBankaccno();
        }

        private void txt_Bank_account_number_Leave(object sender, EventArgs e)
        {
            ValidateBankaccno();
        }

        private void txt_iban_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateInernationalBankAccno();
        }

        private void txt_iban_Leave(object sender, EventArgs e)
        {
            ValidateInernationalBankAccno();
        }
        

        private void txt_Gurranty_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateGurranty();
        }

        private void txt_Gurranty_Leave(object sender, EventArgs e)
        {
            ValidateGurranty();
        }

        private void txt_Standard_Report_Number_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateSTN();
        }

        private void txt_Standard_Report_Number_Leave(object sender, EventArgs e)
        {
            ValidateSTN();
        }
        private void LoadLabType()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("Owned");
            cmbType.Items.Add("Third Party");
            cmbType.SelectedIndex = -1;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //ValidateForm()
            if (true)
            {
                labBAL objBAL = new labBAL();
                objBAL.name = txt_Name.Text;
                objBAL.shortname = txt_shortName.Text;
                objBAL.desctiption = txt_Description.Text;
                objBAL.code = txt_code.Text;
                objBAL.National_Tax_Number = txt_National_Tax_Number.Text;
                objBAL.Goods_And_Services_Tax = txt_goods_and_service_tax.Text;
                objBAL.Guarranty = txt_Gurranty.Text;
                objBAL.Standard_Report_Number = txt_Standard_Report_Number.Text;
                objBAL.phone = txt_phone.Text;
                objBAL.address = txt_Address.Text;
                objBAL.type = cmbType.Text;
                objBAL.email = txt_email.Text;
                objBAL.Bank_account_number = txt_Bank_account_number.Text;
                objBAL.International_Account_Number = txt_iban.Text;
                // objBAL.Company = txt_Company.Text;
                if (id != Guid.Empty)
                {
                    objBAL.EditDate = DateTime.Now;
                    objBAL.Editby = "Admin";
                    objBAL.lab_id = id;
                    objDAL.Update(objBAL);

                }
                else
                {
                    objBAL.AddDate = DateTime.Now;
                    objBAL.Addby = "Admin";
                    objBAL.Flag = 1;
                    objBAL.status = true;
                    objDAL.Add(objBAL);
                }
                ClearAll();
                LoadCountry();

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
                labBAL objBAL = new labBAL();
                objBAL.lab_id = id;
                objDAL.Delete(objBAL);
                ClearAll();
                LoadCountry();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search();
        }
    }
}
