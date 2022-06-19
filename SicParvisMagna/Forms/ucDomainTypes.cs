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
using SicParvisMagna.Controllers;
using System.Data.SqlClient;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms
{
    public partial class ucDomainTypes : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid AccountID = Guid.Empty;

        private bool FormValidation()
        {
            bool validated = true;


            //For Accounts title
            if (string.IsNullOrEmpty(txtAccountTitle.Text))
            {
                lblErrorAccountTitle.Text += "  Title  is required!";
                validated = false;
            }
            else
            {
                lblErrorAccountTitle.Text = "";
            }

            if (!Validation.isAlpha(txtAccountTitle.Text, 8))
            {
                if (string.IsNullOrEmpty(txtAccountTitle.Text))
                    lblErrorAccountTitle.Text += "\n";
                lblErrorAccountTitle.Text += "Title Should be in  Alphabets and  MAximum Length 8 chracters!";
                validated = false;
            }
            else
            {
                lblErrorAccountTitle.Text = "";
            }
            //====================================================

            return validated;
        }

        private void loadAccounts()
        {

            AccountDAL objDAL = new AccountDAL();
            gridAccounts.DataSource = objDAL.LoadDomainTypeAll();
        }

        public ucDomainTypes()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            txtAccountTitle.Clear();
            txtDescription.Clear();
            btnSave.LabelText = "Save";
            lblErrorAccountTitle.Text = "";
            loadAccounts();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                AccountBAL obj = new AccountBAL();
                obj.Title = txtAccountTitle.Text;
                obj.Type = "DomainType";
                obj.Description = txtDescription.Text;
                AccountDAL objDAL = new AccountDAL();
                if (AccountID!=Guid.Empty)
                {

                    obj.Account_id = AccountID;
                    obj.Timestamp = DateTime.Now;
                    obj.Add_by = "Admin";
                    obj.Status = "Active";
                    obj.Flag = 1;
                    objDAL.Update(obj);

                }
                else
                {
                    obj.Timestamp = DateTime.Now;
                    obj.Add_by = "Admin";
                    obj.Status = "Active";
                    obj.Flag = 1;
                    objDAL.Add(obj);
                }

                clearAll();
                loadAccounts();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loadAccounts();
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AccountID!=Guid.Empty)
            {
                AccountBAL objBAL = new AccountBAL();
                AccountDAL objDAL = new AccountDAL();
                objBAL.Account_id = AccountID;
                objDAL.Delete(objBAL);
                loadAccounts();
                clearAll();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                AccountID = Guid.Parse(gridAccounts.Rows[rowindex].Cells["Account_id"].Value.ToString());
              //  int.TryParse(gridAccounts.Rows[rowindex].Cells["Account_id"].Value.ToString(), out AccountID);
                txtAccountTitle.Text = gridAccounts.Rows[rowindex].Cells["Title"].Value.ToString();
                txtDescription.Text = gridAccounts.Rows[rowindex].Cells["Description"].Value.ToString();



                btnSave.LabelText = "Update";

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (AccountID!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.Accounts ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtAccountTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'DomainType' AND Title like '%" + txtAccountTitle.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (AccountID!=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE TYPE = 'DomainType' AND   WHERE Account_id  = " + AccountID;
                        whereAdded = true;
                    }
                    else
                        query += "   WHERE TYPE = 'DomainType'  AND Account_id = " + AccountID;
                }

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                da.SelectCommand = cmd;
                da.Fill(dt);

                gridAccounts.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ucDomainTypes_Load(object sender, EventArgs e)
        {
            loadAccounts();
        }
    }
}
