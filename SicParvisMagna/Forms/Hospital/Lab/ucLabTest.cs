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
    public partial class ucLabTest : UserControl
    {
        ValidationRegex objvr = new ValidationRegex();
        bool[] var = new bool[4];
        private Guid id = Guid.Empty;
        lab_testDAL db = new lab_testDAL();
        labDAL lab_db = new labDAL();
        testDAL test_db = new testDAL();

        private POSMain formMain;
        public ucLabTest(POSMain formMain)
        {
            InitializeComponent();
            this.cmbx_Test.SelectedIndexChanged += new System.EventHandler(this.cmbx_Test_SelectedIndexChanged);
            this.cmbx_Test.Leave += new System.EventHandler(this.cmbx_Test_Leave);

            this.cmbx_Lab.SelectedIndexChanged += new System.EventHandler(this.cmbx_Lab_SelectedIndexChanged);
            this.cmbx_Lab.Leave += new System.EventHandler(this.cmbx_Lab_Leave);


            this.txt_Price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Price_KeyUp);
            this.txt_Price.Leave += new System.EventHandler(this.txt_Price_Leave);
            for (int x = 0; x < var.Length; x++)
                var[x] = false;
            LoadGrid();
            LoadTest();
            LoadLab();
            this.formMain = formMain;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formMain.loadLabBackForm();
            //FormMain.loadLabBackForm();
        }
        public void LoadTest()
        {
            cmbx_Test.DataSource = test_db.LoadAll();
            cmbx_Test.DisplayMember = "name";
            cmbx_Test.ValueMember = "test_id";
            cmbx_Test.SelectedIndex = -1;
        }

        //Validation Method
        public bool Validate_cmbx_Test()
        {
            if (cmbx_Test.Text == string.Empty)
            {
                lblError_Test.Text = "*Required";
                return false;
            }
            lblError_Test.Text = "";
            return true;
        }

        //SelectedIndexChanged
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
            cmbx_Lab.DataSource = lab_db.LoadAll();
            cmbx_Lab.DisplayMember = "name";
            cmbx_Lab.ValueMember = "lab_id";
            cmbx_Lab.SelectedIndex = -1;
        }

        //Validation Method
        public bool Validate_cmbx_Lab()
        {
            if (cmbx_Lab.Text == string.Empty)
            {
                lblError_Lab.Text = "*Required";
                return false;
            }
            lblError_Lab.Text = "";
            return true;
        }


        private void cmbx_Lab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

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
                    return true;
                }
                else
                {
                    lblError_Price.Text = "Invalid lblError_Price";
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
        private void LoadGrid()
        {
            gridLabTest.Columns.Clear();
            gridLabTest.Rows.Clear();
            gridLabTest.Columns.Add("lab_test_id", "lab_test_id");
            gridLabTest.Columns.Add("test", "Test");
            gridLabTest.Columns[1].Width = 250;
            gridLabTest.Columns.Add("lab", "Lab");
            gridLabTest.Columns[2].Width = 250;
            gridLabTest.Columns.Add("price", "Price");
            gridLabTest.Columns[0].Visible = false;
            try
            {
                foreach (var item in db.LoadAll())
                {
                    gridLabTest.Rows.Add(item.lab_test_id,
                        test_db.LoadbyId(item.test_id).FirstOrDefault().name,
                        lab_db.LoadbyId(item.lab_id).FirstOrDefault().name,
                        item.price);
                }
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearAll()
        {
            id = Guid.Empty;
            cmbx_Lab.SelectedIndex = -1;
            cmbx_Test.SelectedIndex = -1;
            txt_Price.Text = "";
            lblError_Lab.Text = "";
            lblError_Test.Text = "";
            lblError_Price.Text = "";
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

                id = Guid.Parse(gridLabTest.Rows[rowindex].Cells["lab_test_id"].Value.ToString());
                var labtest = db.LoadbyId(id).FirstOrDefault();
                if (labtest != null)
                {
                    cmbx_Lab.SelectedValue = labtest.lab_id;
                    cmbx_Test.SelectedValue = labtest.test_id;
                    txt_Price.Text = labtest.price.ToString();
                }
                btnSave.LabelText = "     Update";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void gridLabTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void cmbx_Lab_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_Lab();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            bool chkPrice = false;
            //Check Price if already assigned then exception else Save and  update
            if (Validate_cmbx_Test() && Validate_cmbx_Lab() && Validate_txt_Price())
            {

                DataTable dt = new DataTable();
                try { 
                dt = db.findLabTestPrice(Guid.Parse(cmbx_Lab.SelectedValue.ToString()), Guid.Parse(cmbx_Test.SelectedValue.ToString()));
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                     
                        Double price = Convert.ToDouble(dt.Rows[x]["Price"]);
                        Double tempPrice = Double.Parse(txt_Price.Text);
                        if (price == tempPrice)
                        {
                            MessageBox.Show("Test Price is already assigned .");
                            ClearAll();
                            LoadGrid();
                            chkPrice = true;
                        }
                    
                }
                }
                catch { }
                if (chkPrice == false)
                {
                    lab_testBAL objBAL = new lab_testBAL();
                    objBAL.lab_id = Guid.Parse(cmbx_Lab.SelectedValue.ToString());
                    objBAL.test_id = Guid.Parse(cmbx_Test.SelectedValue.ToString());
                    objBAL.price = Convert.ToInt32(txt_Price.Text);
                    objBAL.name = cmbx_Test.Text + " | " + cmbx_Lab.Text;
                    if (id != Guid.Empty)
                    {
                        objBAL.lab_test_id = id;
                        objBAL.EditDate = DateTime.Now;
                        objBAL.Editby = "Admin";
                        objBAL.lab_test_id = id;
                        db.Update(objBAL);

                    }
                    else
                    {

                        objBAL.AddDate = DateTime.Now;
                        objBAL.Addby = "Admin";
                        objBAL.status = true;
                        objBAL.Flag = 1;
                        db.Add(objBAL);
                    }
                    ClearAll();
                    LoadGrid();

                }
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
                lab_testBAL objBAL = new lab_testBAL();
                objBAL.lab_test_id = id;
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
