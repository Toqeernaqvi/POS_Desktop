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
    public partial class ucAddCity : UserControl
    {
        public static bool PerAdd;
        public static bool PerEdit;

        public static bool PerDel;
        public static string pgURL;

        private string AccountType = null;
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid CountryID = Guid.Empty;
        private Guid stateID = Guid.Empty;
        private Guid CityID = Guid.Empty;
        public ucAddCity()
        {
            InitializeComponent();
            this.gridCity.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridCity.AlternatingRowsDefaultCellStyle.BackColor =
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
 
        private void clear()
        {
            btnSave.Text = "Save";
            txt_Name.Text = "";
            txt_shortName.Text = "";
            txt_Code.Text = "";
            txt_Description.Text = "";
            lblError_Name.Text = "";
       
        }
        private void clearAll()
        {
            lblErrorName.Text = "";
            btnSave.Text = "Save";
            txt_Name.Text = "";
            txt_shortName.Text = "";
            txt_Code.Text = "";
            txt_Description.Text = "";
            lblError_Name.Text = "";
             cbx_Country.SelectedIndex = -1;
            cbx_State.SelectedIndex = -1;
            CountryID = Guid.Empty;
            CityID = Guid.Empty;
           stateID = Guid.Empty;
        }
        private void loadCbxCountries()
        {
            CountryDAL objDAL = new CountryDAL();
            cbx_Country.DataSource = objDAL.LoadAll();
            cbx_Country.ValueMember = "country_id";
            cbx_Country.DisplayMember = "name";
            cbx_Country.SelectedIndex = -1;
        }

        private void loadCbxStates()
        {
            StateDAL objDAL = new StateDAL();
            StateBAL obj = new StateBAL();

            obj.Country_id =Guid.Parse(  cbx_Country.SelectedValue.ToString());
        //    obj.Country_id = Convert.ToInt32(cbx_Country.SelectedValue);
            cbx_State.DataSource = objDAL.LoadAll(obj);
            cbx_State.ValueMember = "state_id";
            cbx_State.DisplayMember = "name";
            cbx_State.SelectedIndex = -1;
        }


        private void loadCities()
        {
            CityDAL objDAL = new CityDAL();
            CityBAL obj = new CityBAL();
            obj.State_id = stateID;  //Guid.Parse(cbx_State.SelectedValue.ToString());
          //  obj.State_id = Convert.ToInt32(cbx_State.SelectedValue);
            gridCity.DataSource = objDAL.LoadByState(obj);
            gridCity.Columns["city_id"].Visible = false;
            gridCity.Columns["state_id"].Visible = false;
            gridCity.Columns["country_id"].Visible = false;
            gridCity.Columns["edit_by"].Visible = false;
            gridCity.Columns["edit_date"].Visible = false;
            gridCity.Columns["add_by"].Visible = false;
            gridCity.Columns["add_date"].Visible = false;
        }
        private void ucAddCity_Load(object sender, EventArgs e)
        {
            //pgURL = "City"; PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
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

           // loadCities();
            clearAll();
            loadCbxCountries();
          //  loadCbxStates();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (FormValidation())
            {
                CityBAL objBAL = new CityBAL();
                objBAL.Name = txt_Name.Text;
                objBAL.Shortname = txt_shortName.Text;
                objBAL.Code = txt_Code.Text;
                objBAL.Description = txt_Description.Text;
                objBAL.Country_id = CountryID;
                objBAL.State_id = stateID;


                CityDAL objDAL = new CityDAL();

                if (CityID!=Guid.Empty)
                {
                    objBAL.id = CityID;
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
                clear();
                loadCities();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CityID!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.City ";
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
                if (CityID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE city_id  = " + CityID;
                        whereAdded = true;
                    }
                    else
                        query += "  Where  city_id = " + CityID;
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

                gridCity.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CityID!=Guid.Empty)
            {
                CityBAL objBAL = new CityBAL();
                CityDAL objDAL = new CityDAL();
                objBAL.id = CityID;
                objDAL.Delete(objBAL);
                clearAll();
                loadCities();
            }
            else
            {
                MessageBox.Show("No City selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CountryID = Guid.Parse(cbx_Country.SelectedValue.ToString());

       //     int.TryParse(cbx_Country.SelectedValue.ToString(), out CountryID);
            loadCbxStates();
        }

        private void cbx_State_SelectionChangeCommitted(object sender, EventArgs e)
        {
            stateID = Guid.Parse(cbx_State.SelectedValue.ToString());
          //  int.TryParse(cbx_State.SelectedValue.ToString(), out stateID);
            loadCities();
        }

        private void gridCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                CityID = Guid.Parse(gridCity.Rows[rowindex].Cells["city_id"].Value.ToString());
               // int.TryParse(gridCountries.Rows[rowindex].Cells["city_id"].Value.ToString(), out CityID);
                txt_Name.Text = gridCity.Rows[rowindex].Cells["Name"].Value.ToString();
                 txt_shortName.Text = gridCity.Rows[rowindex].Cells["ShortName"].Value.ToString();
                txt_Code.Text = gridCity.Rows[rowindex].Cells["Code"].Value.ToString();
                txt_Description.Text = gridCity.Rows[rowindex].Cells["Desc"].Value.ToString();
                CountryID = Guid.Parse(gridCity.Rows[rowindex].Cells["country_id"].Value.ToString());
               // int.TryParse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                cbx_Country.SelectedValue = CountryID;
                stateID = Guid.Parse(gridCity.Rows[rowindex].Cells["state_id"].Value.ToString());
               // int.TryParse(gridCountries.Rows[rowindex].Cells["state_id"].Value.ToString(), out stateID);
                cbx_State.SelectedValue = stateID;

                btnSave.LabelText = "Update";
            }
        }

        private void cbx_Country_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbx_State.Focus();
            }
        }

        private void cbx_State_KeyDown(object sender, KeyEventArgs e)
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
