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
    public partial class ucAddArea : UserControl
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
        private Guid AreaID = Guid.Empty;
        public ucAddArea()
        {
            InitializeComponent();
            this.gridArea.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridArea.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;


        }
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
            btnSave.Text = "Save";
            txt_Name.Text = "";
            txt_shortName.Text = "";
            txt_Code.Text = "";
            txt_Description.Text = "";
            lblErrorName.Text = "";
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

            obj.Country_id = Guid.Parse(cbx_Country.SelectedValue.ToString());
            //    obj.Country_id = Convert.ToInt32(cbx_Country.SelectedValue);
            cbx_State.DataSource = objDAL.LoadAll(obj);
            cbx_State.ValueMember = "state_id";
            cbx_State.DisplayMember = "name";
            cbx_State.SelectedIndex = -1;
        }


        private void loadCbxCities()
        {
            CityDAL objDAL = new CityDAL();
            CityBAL obj = new CityBAL();
            obj.State_id = stateID;  //Guid.Parse(cbx_State.SelectedValue.ToString());
                                     //  obj.State_id = Convert.ToInt32(cbx_State.SelectedValue);
            cmbCity.DataSource= objDAL.LoadByState(obj);
            cmbCity.ValueMember = "city_id";
            cmbCity.DisplayMember = "name";
            cmbCity.SelectedIndex = -1;
         }

        private void loadArea()
        {
            AreaDAL objDAL = new AreaDAL();
            AreaBAL obj = new AreaBAL();
            obj.City_id = CityID;
            gridArea.DataSource = objDAL.LoadByCity(obj);
            gridArea.Columns["city_id"].Visible = false;
            gridArea.Columns["city_id"].Visible = false;
            gridArea.Columns["state_id"].Visible = false;
            gridArea.Columns["country_id"].Visible = false;
           ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                AreaBAL objBAL = new AreaBAL();
                objBAL.Name = txt_Name.Text;
                objBAL.Shortname = txt_shortName.Text;
                objBAL.Code = txt_Code.Text;
                objBAL.Description = txt_Description.Text;
                objBAL.Country_id = CountryID;
                objBAL.State_id = stateID;
                objBAL.City_id = CityID;


                AreaDAL objDAL = new AreaDAL();

                if (AreaID != Guid.Empty)
                {
                    objBAL.Area_id = AreaID;
                    objDAL.Update(objBAL);

                }
                else
                {
              
                    objDAL.Add(objBAL);
                }
                clear();
                loadArea();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AreaID!=Guid.Empty)
            {
                AreaBAL objBAL = new AreaBAL();
                AreaDAL objDAL = new AreaDAL();
                objBAL.Area_id = AreaID;
                objDAL.Delete(objBAL);
                clearAll();
                loadArea();
            }
            else
            {
                MessageBox.Show("No Area selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (AreaID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM dbo.Area ";
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
                if (AreaID !=Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE Area_id  = " + AreaID;
                        whereAdded = true;
                    }
                    else
                        query += "  Where  Area_id = " + CityID;
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

                gridArea.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cbx_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CountryID = Guid.Parse(cbx_Country.SelectedValue.ToString());

             loadCbxStates();
        }

        private void cbx_State_SelectionChangeCommitted(object sender, EventArgs e)
        {
            stateID = Guid.Parse(cbx_State.SelectedValue.ToString());
             loadCbxCities();
        }

        private void cmbCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CityID = Guid.Parse(cmbCity.SelectedValue.ToString());
             loadArea();
        }

        private void gridArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                AreaID = Guid.Parse(gridArea.Rows[rowindex].Cells["city_id"].Value.ToString());
                // int.TryParse(gridCountries.Rows[rowindex].Cells["city_id"].Value.ToString(), out CityID);
                txt_Name.Text = gridArea.Rows[rowindex].Cells["Name"].Value.ToString();
                txt_shortName.Text = gridArea.Rows[rowindex].Cells["ShortName"].Value.ToString();
                txt_Code.Text = gridArea.Rows[rowindex].Cells["Code"].Value.ToString();
                txt_Description.Text = gridArea.Rows[rowindex].Cells["Desc"].Value.ToString();
                CountryID = Guid.Parse(gridArea.Rows[rowindex].Cells["country_id"].Value.ToString());
                // int.TryParse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                cbx_Country.SelectedValue = CountryID;
                stateID = Guid.Parse(gridArea.Rows[rowindex].Cells["state_id"].Value.ToString());
                // int.TryParse(gridCountries.Rows[rowindex].Cells["state_id"].Value.ToString(), out stateID);
                cbx_State.SelectedValue = stateID;

                btnSave.LabelText = "Update";
            }
        }

        private void ucAddArea_Load(object sender, EventArgs e)
        {

            //pgURL = "Area"; PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
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
           // loadArea();
            loadCbxCountries();
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
                cmbCity.Focus();
            }
        }

        private void cmbCity_KeyDown(object sender, KeyEventArgs e)
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
