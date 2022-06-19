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
    public partial class ucAddState : UserControl
    {
         
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid CountryID = Guid.Empty;
        private Guid StateID = Guid.Empty;
        public static bool PerAdd;
        public static bool PerEdit;

        public static bool PerDel;
        public static string pgURL;

        private string AccountType = null;
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

        //Clear
        private void clearAll()
        {
           
            btnSave.Text = "Save";
            txt_Name.Text = "";
            txt_shortName.Text = "";
            txt_Code.Text = "";
            txt_Description.Text = "";
            lblError_Name.Text = "";
            lblErrorName.Text = "";
            lblError_Country.Text = "";
            lblError_Name.Text = "";
           // cbx_Country.SelectedIndex = -1;
            //CountryID = Guid.Empty;
           // StateID = Guid.Empty;
        }
        //Load Countries into ComboBox
        private void loadCbxCountries()
        {
            CountryDAL objDAL = new CountryDAL();
            cbx_Country.DataSource = objDAL.LoadAll();
            cbx_Country.ValueMember = "country_id";
            cbx_Country.DisplayMember = "name";
            cbx_Country.SelectedIndex = -1;
        }
        //Load States
        private void loadStates()//Function
        {
            StateDAL objDAL = new StateDAL();
            StateBAL obj = new StateBAL();
            obj.Country_id =Guid.Parse((cbx_Country.SelectedValue.ToString()));

         //   obj.Country_id = Convert.ToInt32(cbx_Country.SelectedValue);
            gridState.DataSource = objDAL.LoadAll(obj);
            gridState.Columns["state_id"].Visible = false;
            gridState.Columns["country_id"].Visible = false;
            gridState.Columns["edit_by"].Visible = false;
            gridState.Columns["edit_date"].Visible = false;
            gridState.Columns["add_by"].Visible = false;
            gridState.Columns["add_date"].Visible = false;
        }


        //Validation
        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                lblError_Name.Text = "* Required";
                return false;
            }
            else
                lblError_Name.Text = "";

            if (!(cbx_Country.SelectedIndex >= 0))
            {
                lblError_Country.Text = "* Required";
                return false;
            }
            else
                lblError_Country.Text = "";

            return true;
        }




        //LoadCountries into ComboBox
        private void LoadCbxCountries()
        {
            CountryDAL objDAL = new CountryDAL();
            cbx_Country.DataSource = objDAL.LoadAll();
            cbx_Country.ValueMember = "country_id";
            cbx_Country.DisplayMember = "name";
            cbx_Country.SelectedIndex = -1;
        }



        public ucAddState()
        {
            InitializeComponent();
            this.gridState.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridState.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
        }


        private void ucAddState_Load(object sender, EventArgs e)
        {
            //pgURL = "State"; PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
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

          //  loadStates();
            clearAll();
            loadCbxCountries();
        }

        private void cbx_Country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CountryID =  Guid.Parse( cbx_Country.SelectedValue.ToString());
            //int.TryParse(cbx_Country.SelectedValue.ToString(), out CountryID);
            loadStates();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                StateBAL objBAL = new StateBAL();
                objBAL.Name = txt_Name.Text;
                objBAL.Shortname = txt_shortName.Text;
                objBAL.Code = txt_Code.Text;
                objBAL.Description = txt_Description.Text;
                objBAL.Country_id = CountryID;


                StateDAL objDAL = new StateDAL();

                if (StateID != Guid.Empty)
                {
                    objBAL.id = StateID;
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
                loadStates();
              

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {

            if (StateID!=null)
 
            {
                CityBAL objBAL = new CityBAL();
                CityDAL objDAL = new CityDAL();
                objBAL.id = StateID;
                objDAL.Delete(objBAL);
                clearAll();
                loadStates();
            }
            else
            {
                MessageBox.Show("No City selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                StateID = Guid.Parse(gridState.Rows[rowindex].Cells["state_id"].Value.ToString());
             //   int.TryParse(gridCountries.Rows[rowindex].Cells["state_id"].Value.ToString(), out StateID);
                txt_Name.Text = gridState.Rows[rowindex].Cells["Name"].Value.ToString();
                txt_shortName.Text = gridState.Rows[rowindex].Cells["ShortName"].Value.ToString();
                txt_Code.Text = gridState.Rows[rowindex].Cells["Code"].Value.ToString();
                txt_Description.Text = gridState.Rows[rowindex].Cells["Desc"].Value.ToString();
                CountryID =Guid.Parse( gridState.Rows[rowindex].Cells["country_id"].Value.ToString());
              //  int.TryParse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                cbx_Country.SelectedValue = CountryID;
                btnSave.LabelText = "Update";
             }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (StateID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.State ";
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
                if (StateID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE state_id  = " + CountryID;
                        whereAdded = true;
                    }
                    else
                        query += "  Where  state_id= " + CountryID;
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

                gridState.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StateID!=Guid.Empty)

            {
                CityBAL objBAL = new CityBAL();
                CityDAL objDAL = new CityDAL();
                objBAL.id = StateID;
                objDAL.Delete(objBAL);
                clearAll();
                loadStates();
            }
            else
            {
                MessageBox.Show("No City selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void cbx_Country_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Name.Focus();
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
