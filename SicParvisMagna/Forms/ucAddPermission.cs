using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCRUD.Models;
using BasicCRUD.Controllers;
using SicParvisMagna.Controllers;

namespace SicParvisMagna.Forms
{
    public partial class ucAddPermission : UserControl
    {
        private Guid PerID = Guid.Empty;
        private Guid PgID = Guid.Empty;
        private Guid User_id = Guid.Empty;
        public ucAddPermission()
        {
            InitializeComponent();
            this.gridPermission.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridPermission.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
        }
   
        private void clearAll()
        {
            //  for (int x = 0; x < gridPermission.Rows.Count; x++)
            //{ 
            gridPermission.DataSource = null;
            // gridPermission.Rows.Cells["PerEdit"].Value = false;
            //gridPermission.Rows.Cells["PerView"].Value = false;
            //gridPermission.Rows[x].Cells["PerDel"].Value = false;
            cbx_User.SelectedIndex = -1;
            User_id = Guid.Empty;
            PerID = Guid.Empty;


            //}
        }
        private void ucAddPermission_Load(object sender, EventArgs e)
        {
            clearAll();
            // loadPermissions();
            loadCbxUser();
        }
        private void loadPermissions()
        {
            PermissionBAL objBAL = new PermissionBAL();
            PermissionDAL objDAL = new PermissionDAL();
            objBAL.User_id = User_id;
            gridPermission.DataSource = objDAL.loadByUser(objBAL);

            gridPermission.Columns["PerID"].Visible = false;
            gridPermission.Columns["PerUID"].Visible = false;
            gridPermission.Columns["PgID"].Visible = false;
            gridPermission.Columns["User_id"].Visible = false;
            gridPermission.Columns["Timestamp"].Visible = false;
            gridPermission.Columns["AddBy"].Visible = false;
            gridPermission.Columns["Status"].Visible = false;
            gridPermission.Columns["Flag"].Visible = false;
            gridPermission.Columns["EditBy"].Visible = false;
            gridPermission.Columns["EditDate"].Visible = false;
            gridPermission.Columns["PgURL"].Width = 200;

        }
        private void loadCbxUser()
        {
            UserDAL objDAL = new UserDAL();
            cbx_User.DataSource = objDAL.LoadAll();
            cbx_User.ValueMember = "User_id";
            cbx_User.DisplayMember = "User_name";
            cbx_User.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            /*PermissionBAL objBAL = new PermissionBAL();
            PermissionDAL objDAL = new PermissionDAL();

            if (PerID > 0)
            {
                objBAL.PerID = PerID;
                objBAL.EditBy = "Admin";
                objBAL.EditDate = DateTime.Now;
                objBAL.Status = "active";
                objBAL.Flag = 1;
                objDAL.Update(objBAL);

            }
            else
            {
                objBAL.AddBy = "Admin";
                objBAL.Timestamp = DateTime.Now;
                objBAL.Status = "active";
                objBAL.Flag = 1;
                objDAL.Add(objBAL);
            }*/
            PermissionBAL objBalPC = new PermissionBAL();
            PermissionDAL objDalPC = new PermissionDAL();
            objBalPC.PerID = PerID;
            objDalPC.Delete(objBalPC);
            for (int x = 0; x < gridPermission.Rows.Count; x++)
            {
                // if (Convert.ToBoolean(gridPermission.Rows[x].Cells["PerAdd"].Value) == true)
                //{
                // Create BAL / DAL -- populate and save to table

                PermissionBAL objBalPC2 = new PermissionBAL();
                //objBalPC2.PerUID = "1";
                // objBalPC2.PerID = PerID;
                objBalPC2.PerID = Guid.Parse(gridPermission.Rows[x].Cells["PerID"].Value.ToString());

                //objBalPC2.PerID = Convert.ToInt32(gridPermission.Rows[x].Cells["PerID"].Value);
                objBalPC2.PerAdd = Convert.ToBoolean(gridPermission.Rows[x].Cells["PerAdd"].Value);
                objBalPC2.PerEdit = Convert.ToBoolean(gridPermission.Rows[x].Cells["PerEdit"].Value);
                objBalPC2.PerView = Convert.ToBoolean(gridPermission.Rows[x].Cells["PerView"].Value);
                objBalPC2.PerDel = Convert.ToBoolean(gridPermission.Rows[x].Cells["PerDel"].Value);

                //objBalPC2.AddBy = "Admin";
                //objBalPC2.Timestamp = DateTime.Now;
                // objBalPC2.Status = "active";
                //objBalPC2.Flag = 1;
                objDalPC.Update(objBalPC2);

                //}
            }
            clearAll();
            loadPermissions();
        }

        private void chkBx_Add_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_Add.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = false;

                }

            }
        }

        private void chkBx_Edit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_Edit.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerEdit"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerEdit"].Value = false;

                }

            }
        }

        private void chkBx_View_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_View.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerView"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerView"].Value = false;

                }

            }
        }

        private void chkBx_Del_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_Del.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerDel"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerDel"].Value = false;

                }

            }
        }

        private void chkBx_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_SelectAll.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = true;
                    gridPermission.Rows[x].Cells["PerEdit"].Value = true;
                    gridPermission.Rows[x].Cells["PerView"].Value = true;
                    gridPermission.Rows[x].Cells["PerDel"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = false;
                    gridPermission.Rows[x].Cells["PerEdit"].Value = false;
                    gridPermission.Rows[x].Cells["PerView"].Value = false;
                    gridPermission.Rows[x].Cells["PerDel"].Value = false;

                }

            }
        }

        private void cbx_User_SelectionChangeCommitted(object sender, EventArgs e)
        {
            User_id = Guid.Parse(cbx_User.SelectedValue.ToString());

           // int.TryParse(cbx_User.SelectedValue.ToString(), out User_id);
            loadPermissions();
        }

        private void chkBx_View_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBx_View.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerView"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerView"].Value = false;

                }

            }
        }

        private void chkBx_SelectAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBx_SelectAll.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = true;
                    gridPermission.Rows[x].Cells["PerEdit"].Value = true;
                    gridPermission.Rows[x].Cells["PerView"].Value = true;
                    gridPermission.Rows[x].Cells["PerDel"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = false;
                    gridPermission.Rows[x].Cells["PerEdit"].Value = false;
                    gridPermission.Rows[x].Cells["PerView"].Value = false;
                    gridPermission.Rows[x].Cells["PerDel"].Value = false;

                }

            }
        }

        private void chkBx_Edit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBx_Edit.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerEdit"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerEdit"].Value = false;

                }

            }
        }

        private void chkBx_Del_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBx_Del.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerDel"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerDel"].Value = false;

                }

            }
        }

        private void chkBx_Add_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBx_Add.Checked == true)
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = true;

                }

            }
            else
            {
                for (int x = 0; x < gridPermission.Rows.Count; x++)
                {
                    gridPermission.Rows[x].Cells["PerAdd"].Value = false;

                }

            }
        }
    }
}
