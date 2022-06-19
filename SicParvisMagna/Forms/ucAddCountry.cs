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
using Telerik.WinControls.UI;
using System.Web.UI.WebControls;
using Telerik.WinControls;
using System.Configuration;
using BasicCRUD.Controllers;


namespace SicParvisMagna.Forms
{
    public partial class ucAddCountry : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public static bool PerAdd;
        public static bool PerEdit;

        public static bool PerDel;
        public static string pgURL;

        private string AccountType = null;
        private Guid CountryID = Guid.Empty;
        public ucAddCountry()
        {
            InitializeComponent();
            this.gridCountries.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridCountries.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
        }
         //
        private bool FormValidation()
        {
            bool validated = true;


            //For CityName
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                lblErrorName.Text += "  Name required!";
                validated = false;
            }
            else
            {
                lblErrorName.Text = "";
            }

            if (!Validation.isAlpha(txt_Name.Text, 20))
            {
                if (string.IsNullOrEmpty(txt_Name.Text))
                    lblErrorName.Text += "\n";
                lblErrorName.Text += "Name Should be in  Alphabets and  MAximum Length 20 chracters!";
                validated = false;
            }
            else
            {
                lblErrorName.Text = "";
            }
            //====================================================

            return validated;
        }
 
        private void clearAll()
        {
            btnSave.Text = "Save";
            txt_Name.Text = "";  //txt_Name.Clear();
            txt_shortName.Text = "";
            txt_Code.Text = "";
            txt_Description.Text = "";
            lblError_Name.Text = "";
            lblErrorCode.Text = "";
            lblErrorName.Text = "";
            CountryID = Guid.Empty;
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                lblError_Name.Text = "* Required";
                return false;
            }
            else
                lblError_Name.Text = "";

            return true;
        }

        private void loadCountries()
        {
            CountryDAL objDAL = new CountryDAL();
            gridCountries.DataSource = objDAL.LoadAll();
            gridCountries.Columns["country_id"].Visible = false;
            gridCountries.Columns["edit_by"].Visible = false;
            gridCountries.Columns["edit_date"].Visible = false;
            gridCountries.Columns["add_by"].Visible = false;
            gridCountries.Columns["add_date"].Visible = false;
         }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {

                CountryBAL objBAL = new CountryBAL();//models
                objBAL.Name = txt_Name.Text;
                objBAL.Shortname = txt_shortName.Text;
                objBAL.Code = txt_Code.Text;
                objBAL.Description = txt_Description.Text;


                CountryDAL objDAL = new CountryDAL();

                if (CountryID != Guid.Empty)
                {
                    objBAL.id = CountryID;
                    objBAL.Edit_By = "Admin";
                    objBAL.Edit_Date = DateTime.Now;
                    objDAL.Update(objBAL);

                }
                else
                {
                    objBAL.Add_by = "Admin";
                    objBAL.Add_Date = DateTime.Now;
                    objDAL.Add(objBAL);
                }
                clearAll();
                loadCountries();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            loadCountries();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CountryID!= Guid.Empty)
            {
                CountryBAL objBAL = new CountryBAL();
                CountryDAL objDAL = new CountryDAL();
                objBAL.id = CountryID;
                objDAL.Delete(objBAL);
                clearAll();
                loadCountries();
            }
            else
            {
                MessageBox.Show("No Country selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void ucAddCountry_Load(object sender, EventArgs e)
        { 
              //pgURL = "Country"; PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
            ////for Account Type
            //try { AccountType = (PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["Account_type"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}

            //if (AccountType == "Super Admin")
            //{


            //}

            //else
            //{

            //    POSMain.loadAccessDenied();
            //}
            //try { PerAdd = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerAdd).Rows[0]["PerAdd"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerAdd == true)
            //{
            //    btnSave.Enabled = true;
            //}
            //else
            //{
            //    btnSave.Hide();
            //}
            //try { PerEdit = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerEdit).Rows[0]["PerEdit"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerEdit == true)
            //{
            //    btnSave.Enabled = true;
            //}
            //else
            //{
            //    btnSave.Hide();
            //}
            //try { PerDel = Convert.ToBoolean(PermissionDAL.Permission_Level(Program.User_id, pgURL, PerDel).Rows[0]["PerDel"].ToString()); }
            //catch (Exception r)
            //{
            //    MessageBox.Show("Error:" + r.Message);
            //}
            //if (PerDel == true)
            //{
            //    btnDelete.Enabled = true;
            //}
            //else
            //{
            //    btnDelete.Hide();
            //}

        

            loadCountries();
            clearAll();
        }

 private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CountryID!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.Country ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txt_Name.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   name like '%" + txt_Name.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txt_shortName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE   shortname like '%" + txt_shortName.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND shortname like '%" + txt_shortName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txt_Description.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  [desc] like '%" + txt_Description.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND [desc] like '%" + txt_Description.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txt_Code.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE  code like '%" + txt_Code.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND code like '%" + txt_Code.Text + "%'";
                }
                if (CountryID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE country_id  = " + CountryID;
                        whereAdded = true;
                    }
                    else
                        query += "  Where  country_id = " + CountryID;
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

                 gridCountries.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void gridCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                CountryID = Guid.Parse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString());
             //   int.TryParse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                txt_Name.Text = gridCountries.Rows[rowindex].Cells["name"].Value.ToString();
                txt_shortName.Text = gridCountries.Rows[rowindex].Cells["shortname"].Value.ToString();
                txt_Code.Text = gridCountries.Rows[rowindex].Cells["code"].Value.ToString();
                txt_Description.Text = gridCountries.Rows[rowindex].Cells["desc"].Value.ToString();

                btnSave.LabelText = "Update";
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
                txt_Code.Focus();
            }
        }

        private void txt_Code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Description.Focus();
            }
        }
    }
}
