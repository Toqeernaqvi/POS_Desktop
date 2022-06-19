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

namespace SicParvisMagna.Forms.PointOfSale
{
	public partial class ucProductParty : UserControl
	{
		ValidationRegex objvr = new ValidationRegex();
		bool[] var = new bool[14];
		private Guid id = Guid.Empty;
		private Guid organization_id = Guid.Empty;
		private Guid branch_id = Guid.Empty;
		PurchasePartyDAL objDAL = new PurchasePartyDAL();
		private FormMain formMain;
        bool validated = true;
		public ucProductParty()
		{
			InitializeComponent();
			for (int x = 0; x < var.Length; x++)
				var[x] = false;
			LoadCountry();
			LoadCmbOrg();
			//this.formMain = formMain;
		}

        private bool FormValidation()
        {
            validated = true;
            // Vendor Name
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                lblError_name.Text += "Name is required!";
                validated = false;
            }
            else
            {
                lblError_name.Text = "";
            }

            if (!Validation.isAlpha(txt_Name.Text, 25))
            {
                if (string.IsNullOrEmpty(txt_Name.Text))
                    lblError_name.Text += "\n";
                lblError_name.Text += "Name Should be in  Alphabets ";
                validated = false;
            }
            else
            {
                lblError_name.Text = "";
            }
            //====================================================
            //for Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {

                lblErrorEmail.Text += "Email is required!";
                validated = false;
            }
            else
            {
                lblErrorEmail.Text = "";
            }

            if (!Validation.isEmail(txtEmail.Text))
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                    lblErrorEmail.Text += "\n";
                lblErrorEmail.Text += "abc@gmail.com ";
                validated = false;
            }
            else
            {
                lblErrorEmail.Text = "";
            }
             

            //for Phone Number
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                lblErrorPhone.Text += "Phone no. is required!";
                validated = false;
            }
            else
            {
                lblErrorPhone.Text = "";
            }

            if (!Validation.isPhoneNumber(txtPhone.Text))
            {
                if (string.IsNullOrEmpty(txtPhone.Text))
                    lblErrorPhone.Text += "\n";
                lblErrorPhone.Text += "03XXXXXXXXX ";
                validated = false;
            }
            else
            {
                lblErrorPhone.Text = "";
            }
            //====================================================

            //for Adress
            if (string.IsNullOrEmpty(txtAdress.Text))
            {

                lblErrorAdress.Text += "Adress is required!";
                validated = false;
            }
            else
            {
                lblErrorAdress.Text = "";
            }

            if (!Validation.isAdress(txtAdress.Text))
            {
                if (string.IsNullOrEmpty(txtAdress.Text))
                    lblErrorAdress.Text += "\n";
                lblErrorAdress.Text += "Special Chracters are not Allowed";
                validated = false;
            }
            else
            {
                lblErrorAdress.Text = "";
            }
            //====================================================




            return validated;
 
        }
		public void inti()
		{
			for (int x = 0; x < var.Length; x++)
				var[x] = false;
			lblError_name.Text = "";
			//lblError_ShortName.Text = "";
			//lbl_ErrorCode.Text = "";
			lblError_Description.Text = "";
			txt_Name.Text = "";
			txt_shortName.Text = "";
 			txt_code.Text = "";
			txt_add.Text = "";
			txt_National_Tax_Number.Text = "";
			txt_goods_and_service_tax.Text = "";
			txt_Gurranty.Text = "";
			txt_Standard_Report_Number.Text = "";
			txtPhone.Text = "";
			txtAdress.Text = "";
			txtEmail.Text = "";
			txt_Bank_account_number.Text = "";
			txt_iban.Text = "";
            lblErrorAdress.Text = "";
            lblErrorEmail.Text = "";
            lblErrorPhone.Text = "";
            lblError_name.Text = "";
		}
		private void LoadCountry()
		{
			//gridParty.DataSource = objDAL.LoadAll();
			//gridParty.Columns[0].HeaderText = "ID";
			//gridParty.Columns[0].Visible = false;
			//gridParty.Columns[1].HeaderText = "Party Name";
			//gridParty.Columns[2].HeaderText = "Short Name";
			//gridParty.Columns[3].HeaderText = "Code";
			//gridParty.Columns[4].HeaderText = "Description";
			//gridParty.Columns[5].HeaderText = "Add";
			//gridParty.Columns[6].HeaderText = "NTN";
			//gridParty.Columns[7].HeaderText = "GST";
			//gridParty.Columns[8].HeaderText = "Guarranty";
			//gridParty.Columns[9].HeaderText = "STRN";
			//gridParty.Columns[10].HeaderText = "Phone";
			//gridParty.Columns[11].HeaderText = "Address";
			//gridParty.Columns[12].HeaderText = "Email";
			//gridParty.Columns[13].HeaderText = "Bank Account No";
			//gridParty.Columns[13].Width = 200;
			//gridParty.Columns[14].HeaderText = "IBAN";
			//gridParty.Columns[14].Width = 200;
			//gridParty.Columns[15].HeaderText = "Organization";
			//gridParty.Columns[16].HeaderText = "Branch";
			//gridParty.Columns["status"].Visible = false;
			//gridParty.Columns["Addby"].Visible = false;
			//gridParty.Columns["AddDate"].Visible = false;
			//gridParty.Columns["Editby"].Visible = false;
			//gridParty.Columns["EditDate"].Visible = false;
			//gridParty.Columns["Flag"].Visible = false;
		}
		private void loadParty()
		{
			PurchasePartyDAL objDAL = new PurchasePartyDAL();
			gridParty.DataSource = objDAL.LoadAll();
			gridParty.Columns["Organization_id"].Visible = false;
			gridParty.Columns["Branch_id"].Visible = false;
			gridParty.Columns["Party_id"].Visible = false;
            gridParty.Columns["Address"].Width = 200;
			//gridParty.Columns["Flag"].Visible = false;
			//gridParty.Columns["EditBy"].Visible = false;
			//gridParty.Columns["EditDate"].Visible = false;
           //// gridParty.Columns["Gurranty"].Visible = false;
           // gridParty.Columns["IBAN"].Visible = false;
           // gridParty.Columns["Description"].Visible = false;
           // gridParty.Columns["Add"].Visible = false;
           //gridParty.Columns["NTN"].Visible = false;
           //gridParty.Columns["GST"].Visible = false;
        }
		private void ClearAll()
		{
			inti();
			id = Guid.Empty;
			loadParty();

			btnSave.LabelText = "Save";
		}

		private void Valid_it()
		{
			lblError_name.Text = "";
			//lblError_ShortName.Text = "";
			//lbl_ErrorCode.Text = "";
			lblError_Description.Text = "";
			for (int x = 0; x < var.Length; x++)
			{
				var[x] = true;
			}
		}
		private bool ValidateForm()
		{
			//for (int x = 0; x < var.Length; x++)
			//{
			//	var[1] = true;
			//	var[2] = true;
   //             var[3] = true;
   //             var[4] = true;
   //             var[5] = true;
			//	var[6] = true;
			//	var[7] = true;
			//	var[8] = true;
			//	var[9] = true;
			//	var[10] = true;
			//	var[11] = true;
			//	var[12] = true;
			//	if (!var[x])
			//	{
			//		return false;
			//	}
			//}
			return true;
		}
		private void LoadCmbOrg()
		{
			OrganizationDAL objDAL = new OrganizationDAL();
			cmbOrganization.DataSource = objDAL.LoadAll();
			cmbOrganization.ValueMember = "Organization_id";
			cmbOrganization.DisplayMember = "Title";
			cmbOrganization.SelectedIndex = -1;
		}

		// 2;// BranchID;

		private void LoadCmbOrgBranch()
		{
			OrganizationDAL objDAL = new OrganizationDAL();
			OrganizationBAL obj = new OrganizationBAL();
			obj.Parent_id = organization_id;
			cmbOrganizationBranch.DataSource = objDAL.LoadBranch(obj);
			cmbOrganizationBranch.ValueMember = "Organization_id";
			cmbOrganizationBranch.DisplayMember = "Title";
			cmbOrganizationBranch.SelectedIndex = -1;
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

		private void txt_shortName_KeyUp(object sender, KeyEventArgs e)
		{
			if (txt_shortName.Text == "")
			{
				//lblError_ShortName.Text = "Required!";
				// var[1] = false;
			}
			else
			{
				//  var[1] = true;
				//lblError_ShortName.Text = "";
			}
		}

		private void txt_shortName_Leave(object sender, EventArgs e)
		{
			if (txt_shortName.Text == "")
			{
				//lblError_ShortName.Text = "Required!";
				// var[1] = false;
			}
			else
			{
				//  var[1] = true;
				//lblError_ShortName.Text = "";
			}
		}

		private void txt_code_Leave(object sender, EventArgs e)
		{
		 
		}

		private void txt_code_KeyUp(object sender, KeyEventArgs e)
		{
			 
		}

		private void txt_Description_Leave(object sender, EventArgs e)
		{
			 
		}

		private void txt_Description_KeyUp(object sender, KeyEventArgs e)
		{
			 
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
			if (!objvr.phoneno(txtPhone.Text))
			{
				//   lblError_phone.Text = "Invalid phone";
				var[6] = true;
			}
			else
			{
				var[6] = true;
			 
			}
		}
		public void ValidateAddress()
		{
			if (!objvr.address(txtAdress.Text))
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
			if (!objvr.Email(txtEmail.Text))
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
		public void validateOrganization()
		{
			if (cmbOrganization.SelectedIndex < 0)
			{
				//lblError_Org.Text += "* Required!";
				var[11] = false;
			}
			else
			{
				//lblError_Org.Text = "";
			}


			if (cmbOrganizationBranch.SelectedIndex < 0)
			{
				//lblError_Branch.Text += "* Required!";
				var[12] = false;
			}
			else
			{
				//lblError_Branch.Text = "";
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

		private void txt_search_KeyUp(object sender, KeyEventArgs e)
		{

		}
		private void Content(DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;
			if (rowindex >= 0)
			{

				id = Guid.Parse(gridParty.Rows[rowindex].Cells["party_id"].Value.ToString());
				txt_Name.Text = gridParty.Rows[rowindex].Cells["name"].Value.ToString();
                LoadCmbOrg();
				organization_id = Guid.Parse(gridParty.Rows[rowindex].Cells["organization_id"].Value.ToString());
                cmbOrganization.SelectedValue = organization_id;
                LoadCmbOrgBranch();
                branch_id = Guid.Parse(gridParty.Rows[rowindex].Cells["branch_id"].Value.ToString());
                cmbOrganizationBranch.SelectedValue = branch_id;

                txt_shortName.Text = gridParty.Rows[rowindex].Cells["shortname"].Value.ToString();


				txt_code.Text = gridParty.Rows[rowindex].Cells["code"].Value.ToString();

 
			//	txt_add.Text = gridParty.Rows[rowindex].Cells["add"].Value.ToString();

			//	txt_National_Tax_Number.Text = gridParty.Rows[rowindex].Cells["National_Tax_Number"].Value.ToString();

////				txt_goods_and_service_tax.Text = gridParty.Rows[rowindex].Cells["Goods_And_Services_Tax"].Value.ToString();

//				txt_Gurranty.Text = gridParty.Rows[rowindex].Cells["Guarranty"].Value.ToString();

//				txt_Standard_Report_Number.Text = gridParty.Rows[rowindex].Cells["Standard_Report_Number"].Value.ToString();

            	txtPhone.Text = gridParty.Rows[rowindex].Cells["phone"].Value.ToString();

				txtAdress.Text = gridParty.Rows[rowindex].Cells["address"].Value.ToString();

				txtEmail.Text = gridParty.Rows[rowindex].Cells["email"].Value.ToString();

				//txt_Bank_account_number.Text = gridParty.Rows[rowindex].Cells["Bank_account_number"].Value.ToString();

				//txt_iban.Text = gridParty.Rows[rowindex].Cells["International_Account_Number"].Value.ToString();




				Valid_it();
				btnSave.LabelText = "Update";
			}

		}

		private void gridParty_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Content(e);
		}
		private void Search()
		{

		}

		private void ucProductParty_Load(object sender, EventArgs e)
		{
			loadParty();
			ClearAll();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (FormValidation())
			{
				PurchasePartyBAL objBAL = new PurchasePartyBAL();
				objBAL.name = txt_Name.Text;
				objBAL.shortname = txt_shortName.Text;
				objBAL.description = "";
				objBAL.code = txt_code.Text;
				objBAL.add = txt_add.Text;
				objBAL.National_Tax_Number = txt_National_Tax_Number.Text;
				objBAL.Goods_And_Services_Tax = txt_goods_and_service_tax.Text;
				objBAL.Guarranty = txt_Gurranty.Text;
				objBAL.Standard_Report_Number = txt_Standard_Report_Number.Text;
				objBAL.phone = txtPhone.Text;
				objBAL.address = txtAdress.Text;
				objBAL.email = txtEmail.Text;
				objBAL.Bank_account_number = txt_Bank_account_number.Text;
				objBAL.Internation_Account_Number = txt_iban.Text;
				objBAL.organization_id = organization_id;
				objBAL.branch_id = branch_id;
				// objBAL.Company = txt_Company.Text;
				if (id != Guid.Empty)
				{
					objBAL.party_id = id;
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
                btnSave.LabelText = "Save";
			}
			else
			{

				MessageBox.Show("Form is not Valid");
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearAll();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (id != Guid.Empty)
			{
				PurchasePartyBAL objBAL = new PurchasePartyBAL();
				objBAL.party_id = id;
				objDAL.Delete(objBAL);
				ClearAll();
				LoadCountry();
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Search();
		}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

		private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
		{
			organization_id = Guid.Parse(cmbOrganization.SelectedValue.ToString());

			LoadCmbOrgBranch();
		}

		private void cmbOrganizationBranch_SelectionChangeCommitted(object sender, EventArgs e)
		{
			branch_id = Guid.Parse(cmbOrganizationBranch.SelectedValue.ToString());
		}

		private void cmbOrganizationBranch_KeyUp(object sender, KeyEventArgs e)
		{
			validateOrganization();
		}

		private void cmbOrganizationBranch_Leave(object sender, EventArgs e)
		{
			validateOrganization();
		}

		private void cmbOrganization_KeyUp(object sender, KeyEventArgs e)
		{
			validateOrganization();
		}

		private void cmbOrganization_Leave(object sender, EventArgs e)
		{
			validateOrganization();
		}

        private void cmbOrganizationBranch_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                txt_Name.Focus();
            }
        }

        private void txt_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
             }
        }

        private void cmbOrganization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbOrganizationBranch.Focus();
            }
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_shortName.Focus();
            }
        }

        private void txt_shortName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_code.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdress.Focus();
            }
        }

        private void ucProductParty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        this.btnSave_Click(sender,e);
                        break;
                    // Other cases ...
                    default:
                        break;
                }
            }
        }

        private void cmbOrganizationBranch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
           Guid.TryParse(cmbOrganizationBranch.SelectedValue.ToString(),out branch_id);

        }
    }
}
