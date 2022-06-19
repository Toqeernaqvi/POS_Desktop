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
    public partial class ucTest : UserControl
    {
        ValidationRegex objvr = new ValidationRegex();
        bool[] var = new bool[4];
        private Guid id = Guid.Empty;
        testDAL objDAL = new testDAL();
        private POSMain formMain;
        public ucTest(POSMain formMain)
        {
            InitializeComponent();
            for (int x = 0; x < var.Length; x++)
                var[x] = false;
            LoadCountry();
            Valid_it();
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
        }

        private void LoadCountry()
        {
            gridTest.DataSource = objDAL.LoadAll();
            gridTest.Columns[0].HeaderText = "ID";
            gridTest.Columns[0].Visible = false;
            gridTest.Columns[1].HeaderText = "Test Name";
            gridTest.Columns[2].HeaderText = "Short Name";
            gridTest.Columns[3].HeaderText = "Code";
            gridTest.Columns[4].HeaderText = "Description";

            gridTest.Columns["status"].Visible = false;
            gridTest.Columns["Addby"].Visible = false;
            gridTest.Columns["AddDate"].Visible = false;
            gridTest.Columns["Editby"].Visible = false;
            gridTest.Columns["EditDate"].Visible = false;
            gridTest.Columns["Flag"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearAll()
        {
            inti();
            id = Guid.Empty;

            btnSave.LabelText = "     Save";
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
                // var[1] = true;
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
            var[3] = true;
            if (!objvr.description(txt_Description.Text, 10, 50))
            {
                lblError_Description.Text = "Invalid Description";
                //  var[3] = false;
            }
            else
            {
                //  var[3] = true;
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
            //gridTest.DataSource = objDAL.Search(txt_search.Text);
            //     gridTest.Columns[0].HeaderText = "ID";
            //gridTest.Columns[0].Visible = false;
            //gridTest.Columns[1].HeaderText = "Lab Name";
            //gridTest.Columns[2].HeaderText = "Short Name";
            //gridTest.Columns[3].HeaderText = "Code";
            //gridTest.Columns[4].HeaderText = "Description";
            //gridTest.Columns[5].HeaderText = "NTN";
            //gridTest.Columns[6].HeaderText = "GST";
            //gridTest.Columns[7].HeaderText = "Guarranty";
            //gridTest.Columns[8].HeaderText = "STRN";
            //gridTest.Columns[9].HeaderText = "Phone";
            //gridTest.Columns[10].HeaderText = "Address";
            //gridTest.Columns[11].HeaderText = "Email";
            //gridTest.Columns[12].HeaderText = "Bank Account No";
            //gridTest.Columns[12].Width = 200;
            //gridTest.Columns[13].HeaderText = "IBAN";
            //gridTest.Columns[14].Width = 200;
            //gridTest.Columns["status"].Visible = false;
            //gridTest.Focus();
        }
        private void Content(DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {

                id = Guid.Parse(gridTest.Rows[rowindex].Cells["test_id"].Value.ToString());
                txt_Name.Text = gridTest.Rows[rowindex].Cells["name"].Value.ToString();

                txt_shortName.Text = gridTest.Rows[rowindex].Cells["shortname"].Value.ToString();


                txt_code.Text = gridTest.Rows[rowindex].Cells["code"].Value.ToString();

                txt_Description.Text = gridTest.Rows[rowindex].Cells["description"].Value.ToString();





                Valid_it();
                btnSave.LabelText = "     Update";
            }
            
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

        private void gridTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Valid_it();
            if (ValidateForm())
            {
                testBAL objBAL = new testBAL();
                objBAL.name = txt_Name.Text;
                objBAL.shortname = txt_shortName.Text;
                objBAL.description = txt_Description.Text;
                objBAL.code = txt_code.Text;

                // objBAL.Company = txt_Company.Text;
                if (id != Guid.Empty)
                {
                    objBAL.test_id = id;
                    objBAL.EditDate = DateTime.Now;
                    objBAL.Editby = "Admin";


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (id != Guid.Empty)
            {
                testBAL objBAL = new testBAL();
                objBAL.test_id = id;
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
