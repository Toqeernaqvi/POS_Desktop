using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SicParvisMagna.Library;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;
using System.Data.SqlClient;
using System.IO;

namespace SicParvisMagna.Forms.Hospital.Parties
{
    public partial class ucParty : UserControl
    {
        ValidationRegex objvr = new ValidationRegex();
        bool[] var = new bool[11];
        private Guid id = Guid.Empty;
        PartyDAL objDAL = new PartyDAL();
        private FormMain formMain;
        public ucParty(FormMain formMain)
        {
            InitializeComponent();
            for (int x = 0; x < var.Length; x++)
                var[x] = false;
            LoadCountry();
            this.formMain = formMain;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
           // formMain.loadPartyIndexForm();
            //FormMain.loadPartyIndexForm();
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
            txt_add.Text = "";
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
            gridParty.DataSource = objDAL.LoadAll();
            gridParty.Columns[0].HeaderText = "ID";
            gridParty.Columns[0].Visible = false;
            gridParty.Columns[1].HeaderText = "Party Name";
            gridParty.Columns[2].HeaderText = "Short Name";
            gridParty.Columns[3].HeaderText = "Code";
            gridParty.Columns[4].HeaderText = "Description";
            gridParty.Columns[5].HeaderText = "Add";
            gridParty.Columns[6].HeaderText = "NTN";
            gridParty.Columns[7].HeaderText = "GST";
            gridParty.Columns[8].HeaderText = "Guarranty";
            gridParty.Columns[9].HeaderText = "STRN";
            gridParty.Columns[10].HeaderText = "Phone";
            gridParty.Columns[11].HeaderText = "Address";
            gridParty.Columns[12].HeaderText = "Email";
            gridParty.Columns[13].HeaderText = "Bank Account No";
            gridParty.Columns[13].Width = 200;
            gridParty.Columns[14].HeaderText = "IBAN";
            gridParty.Columns[14].Width = 200;
            gridParty.Columns["status"].Visible = false;
            gridParty.Columns["Addby"].Visible = false;
            gridParty.Columns["AddDate"].Visible = false;
            gridParty.Columns["Editby"].Visible = false;
            gridParty.Columns["EditDate"].Visible = false;
            gridParty.Columns["Flag"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void loadParty()
        {
            PartyDAL objDAL = new PartyDAL();
            gridParty.DataSource = objDAL.LoadAll();
            gridParty.Columns["AddDate"].Visible = false;
            gridParty.Columns["AddBy"].Visible = false;
            gridParty.Columns["Status"].Visible = false;
            gridParty.Columns["Flag"].Visible = false;
            gridParty.Columns["EditBy"].Visible = false;
            gridParty.Columns["EditDate"].Visible = false;
        }
        private void ClearAll()
        {
            inti();
            id = Guid.Empty;
            loadParty();

            btnSave.Text = "Save";
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
                var[1] = true;
                var[2] = true;
                var[4] = true;
                var[5] = true;
                var[6] = true;
                var[7] = true;
                var[8] = true;
                var[9] = true;
                var[10] = true;
                if (!var[x])
                {
                    return false;
                }
            }
            return true;
        }

        private void txt_Name_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Name.Text == "")
            {
                lblError_name.Text = "Required!";
                var[0] = true;
            }
            else
            {
                var[0] = true;
                lblError_name.Text = "";
            }
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

        private void txt_shortName_Leave(object sender, EventArgs e)
        {
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

        private void txt_code_Leave(object sender, EventArgs e)
        {
            ValidateCode();
        }

        private void txt_code_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateCode();
        }

        private void txt_Description_Leave(object sender, EventArgs e)
        {
            if (!objvr.description(txt_Description.Text, 10, 50))
            {
                //   lblError_Description.Text = "Invalid Description";
                var[3] = true;
            }
            else
            {
                var[3] = true;
                lblError_Description.Text = "";
            }
        }

        private void txt_Description_KeyUp(object sender, KeyEventArgs e)
        {
            if (!objvr.description(txt_Description.Text, 10, 50))
            {
                //   lblError_Description.Text = "Invalid Description";
                var[3] = true;
            }
            else
            {
                var[3] = true;
                lblError_Description.Text = "";
            }
        }
        public void ValidateCode()
        {
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

        public void ValidateAdd()
        {
            if (!objvr.alphanumeric(txt_add.Text, 2, 20))
            {
                lblError_add.Text = "Invalid Add";
                var[1] = true;
            }
            else
            {
                var[1] = true;
                lblError_add.Text = "";
            }
        }
        public void ValidateNTN()
        {
            if (!objvr.National_Tax_Number(txt_National_Tax_Number.Text))
            {
                lblError_National_Tax_Number.Text = "Invalid NTN";
                var[2] = true;
            }
            else
            {
                var[2] = true;
                lblError_National_Tax_Number.Text = "";
            }
        }
        public void ValidateGST()
        {
            if (!objvr.numeric(txt_goods_and_service_tax.Text, 1, 11))
            {
                lblError_Goods_And_Services_Tax.Text = "Invalid GST";
                var[3] = true;
            }
            else
            {
                var[3] = true;
                lblError_Goods_And_Services_Tax.Text = "";
            }
        }
        public void ValidateGurranty()
        {
            if (!objvr.alphasapce(txt_Gurranty.Text, 3, 11))
            {
                lblError_Gurranty.Text = "Invalid Gurranty";
                var[4] = true;
            }
            else
            {
                var[4] = true;
                lblError_Gurranty.Text = "";
            }
        }
        public void ValidateSTN()
        {
            if (!objvr.numeric(txt_Standard_Report_Number.Text, 3, 11))
            {
                lblError_Standard_Report_Number.Text = "Invalid STN";
                var[5] = true;
            }
            else
            {
                var[5] = true;
                lblError_Standard_Report_Number.Text = "";
            }
        }
        public void Validatephone()
        {
            if (!objvr.phoneno(txt_phone.Text))
            {
                //   lblError_phone.Text = "Invalid phone";
                var[6] = true;
            }
            else
            {
                var[6] = true;
                lblError_phone.Text = "";
            }
        }
        public void ValidateAddress()
        {
            if (!objvr.address(txt_Address.Text))
            {
                //    lblError_Address.Text = "Invalid Address";
                var[7] = true;
            }
            else
            {
                var[7] = true;
                lblError_Address.Text = "";
            }
        }
        public void ValidateEmail()
        {
            if (!objvr.Email(txt_email.Text))
            {
                //    lblError_email.Text = "Invalid Email";
                var[8] = true;
            }
            else
            {
                var[8] = true;
                lblError_email.Text = "";
            }
        }
        public void ValidateBankaccno()
        {
            if (!objvr.Bank_account_number_pk(txt_Bank_account_number.Text))
            {
                lblError_Bank_account_number.Text = "Invalid Bank Account no";
                var[9] = true;
            }
            else
            {
                var[9] = true;
                lblError_Bank_account_number.Text = "";
            }
        }
        public void ValidateInernationalBankAccno()
        {
            if (!objvr.Bank_account_number_iban(txt_iban.Text))
            {
                lblError_IBAN.Text = "Invalid Bank Account no";
                var[10] = true;
            }
            else
            {
                var[10] = true;
                lblError_IBAN.Text = "";
            }
        }

        private void txt_add_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateAdd();
        }

        private void txt_add_Leave(object sender, EventArgs e)
        {
            ValidateAdd();
        }

        private void txt_National_Tax_Number_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNTN();
        }

        private void txt_National_Tax_Number_Leave(object sender, EventArgs e)
        {
            ValidateNTN();
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

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            Validatephone();
        }

        private void txt_phone_KeyUp(object sender, KeyEventArgs e)
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

        private void txt_goods_and_service_tax_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateGST();
        }

        private void txt_goods_and_service_tax_Leave(object sender, EventArgs e)
        {
            ValidateGST();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
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

        private void Content(DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {

                id = Guid.Parse(gridParty.Rows[rowindex].Cells["p_id"].Value.ToString());
                txt_Name.Text = gridParty.Rows[rowindex].Cells["name"].Value.ToString();

                txt_shortName.Text = gridParty.Rows[rowindex].Cells["shortname"].Value.ToString();


                txt_code.Text = gridParty.Rows[rowindex].Cells["code"].Value.ToString();

                txt_Description.Text = gridParty.Rows[rowindex].Cells["description"].Value.ToString();

                txt_add.Text = gridParty.Rows[rowindex].Cells["add"].Value.ToString();

                txt_National_Tax_Number.Text = gridParty.Rows[rowindex].Cells["National_Tax_Number"].Value.ToString();

                txt_goods_and_service_tax.Text = gridParty.Rows[rowindex].Cells["Goods_And_Services_Tax"].Value.ToString();

                txt_Gurranty.Text = gridParty.Rows[rowindex].Cells["Guarranty"].Value.ToString();

                txt_Standard_Report_Number.Text = gridParty.Rows[rowindex].Cells["Standard_Report_Number"].Value.ToString();

                txt_phone.Text = gridParty.Rows[rowindex].Cells["phone"].Value.ToString();

                txt_Address.Text = gridParty.Rows[rowindex].Cells["address"].Value.ToString();

                txt_email.Text = gridParty.Rows[rowindex].Cells["email"].Value.ToString();

                txt_Bank_account_number.Text = gridParty.Rows[rowindex].Cells["Bank_account_number"].Value.ToString();

                txt_iban.Text = gridParty.Rows[rowindex].Cells["International_Account_Number"].Value.ToString();




                Valid_it();
                btnSave.Text = "     Update";
            }
        }

        private void gridParty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }
        private void Search()
        {

        }

        private void ucParty_Load(object sender, EventArgs e)
        {
            loadParty();
            ClearAll();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PartyBAL objBAL = new PartyBAL();
                objBAL.name = txt_Name.Text;
                objBAL.shortname = txt_shortName.Text;
                objBAL.description = txt_Description.Text;
                objBAL.code = txt_code.Text;
                objBAL.add = txt_add.Text;
                objBAL.National_Tax_Number = txt_National_Tax_Number.Text;
                objBAL.Goods_And_Services_Tax = txt_goods_and_service_tax.Text;
                objBAL.Guarranty = txt_Gurranty.Text;
                objBAL.Standard_Report_Number = txt_Standard_Report_Number.Text;
                objBAL.phone = txt_phone.Text;
                objBAL.address = txt_Address.Text;
                objBAL.email = txt_email.Text;
                objBAL.Bank_account_number = txt_Bank_account_number.Text;
                objBAL.Internation_Account_Number = txt_iban.Text;
                // objBAL.Company = txt_Company.Text;
                if (id != Guid.Empty)
                {
                    objBAL.p_id = id;
                    objBAL.EditDate = DateTime.Now;
                    objBAL.Editby = "Admin";
                    objDAL.Update(objBAL);


                }
                else
                {

                    objBAL.AddDate = DateTime.Now;
                    objBAL.Addby = "Admin";
                    objBAL.Flag = 1;
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
                PartyBAL objBAL = new PartyBAL();
                objBAL.p_id = id;
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
