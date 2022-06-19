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
    public partial class ucAddOrganization : UserControl
    {
        public static bool PerAdd;
        public static bool PerEdit;

        public static bool PerDel;
        public static string pgURL;

        private string AccountType = null;
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private string appPath;
        private string filepath;
        private string picname;
        private Guid OrgID = Guid.Empty;

        private bool FormValidation()
        {
            bool validated = true;


            //For Accounts title
            if (string.IsNullOrEmpty(txtOrganizationTitle.Text))
            {
                lblErrorOrganizationTitle.Text += "  Name  is required!";
                validated = false;
            }
            else
            {
                lblErrorOrganizationTitle.Text = "";
            }

            if (!Validation.isAlpha(txtOrganizationTitle.Text, 15))
            {
                if (string.IsNullOrEmpty(txtOrganizationTitle.Text))
                    lblErrorOrganizationTitle.Text += "\n";
                lblErrorOrganizationTitle.Text += "Name Should be in  Alphabets and  MAximum Length 15 chracters!";
                validated = false;
            }
            else
            {
                lblErrorOrganizationTitle.Text = "";
            }
            //====================================================

            return validated;
        }
        private void loadOrganization()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            gridOrganization.DataSource = objDAL.LoadAll();
            gridOrganization.Columns["Organization_id"].Visible = false;
            gridOrganization.Columns["Parent_id"].Visible = false;
         //   gridOrganization.Columns["Image"].Visible = false;
            ////gridOrganization.Columns["Update_Date"].Visible = false;
            //gridOrganization.Columns["Regestrar_Name"].Visible = false;
            //gridOrganization.Columns["Tech_Persoan_Name"].Visible = false;
            //gridOrganization.Columns["Regestration_Email"].Visible = false;
            //gridOrganization.Columns["Name_Server1"].Visible = false;
            //gridOrganization.Columns["Name_Server2"].Visible = false;
            //gridOrganization.Columns["Name_Server3"].Visible = false;
            //gridOrganization.Columns["Name_Server4"].Visible = false;
            //gridOrganization.Columns["NameServer5"].Visible = false;
           // gridOrganization.Columns["HeaderPicturePath"].Visible = false;
            gridOrganization.Columns["User_id"].Visible = false;
            gridOrganization.Columns["Timestamp"].Visible = false;
            gridOrganization.Columns["Add_by"].Visible = false;
            gridOrganization.Columns["Status"].Visible = false;
            gridOrganization.Columns["Flag"].Visible = false;
        }

        public ucAddOrganization()
        {
            InitializeComponent();
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\OrganizationImages\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            this.gridOrganization.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridOrganization.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
        }
    
        public void clearAll()
        {
            txtOrganizationTitle.Clear();
            txtDescription.Clear();
            btnSave.LabelText = "Save";
            lblErrorOrganizationTitle.Text = "";
            loadOrganization();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                OrganizationBAL obj = new OrganizationBAL();
                obj.Title = txtOrganizationTitle.Text;
                obj.Type = "Organization";
                obj.Description = txtDescription.Text;
                OrganizationDAL objDAL = new OrganizationDAL();
           

                if (OrgID!=Guid.Empty)
                {
                    try
                    {
                        string newpic = (picname) + Guid.NewGuid() + (".jpg");
                        obj.HeaderPicturePath = newpic;
                        File.Copy(filepath, appPath + newpic);
                        File.Delete(appPath + (picname));

                        obj.Organization_id = OrgID;
                        obj.Timestamp = DateTime.Now;
                        obj.Add_by = "Admin";
                        obj.Status = "Active";
                        obj.Flag = 1;
                        objDAL.Update(obj);
                     
                    }
                    catch(Exception e1)
                    {
                        obj.Organization_id = OrgID;
                        obj.Timestamp = DateTime.Now;
                        obj.Add_by = "Admin";
                        obj.Status = "Active";
                        obj.Flag = 1;
                        objDAL.Update(obj);
                    }
                }
                else
                {
                    try
                    {
                        obj.HeaderPicturePath =txtOrganizationTitle.Text+ picname + (".jpg");
                        File.Copy(filepath, appPath + (picname) + (".jpg"));
                        obj.Timestamp = DateTime.Now;
                        obj.Add_by = "Admin";
                        obj.Status = "Active";
                        obj.Flag = 1;
                        objDAL.Add(obj);
                    }
                    catch
                    {
                        obj.Timestamp = DateTime.Now;
                        obj.Add_by = "Admin";
                        obj.Status = "Active";
                        obj.Flag = 1;
                        objDAL.Add(obj);
                    }
                }

                clearAll();
                loadOrganization();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loadOrganization();
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (OrgID!=Guid.Empty)
            {
                OrganizationBAL objBAL = new OrganizationBAL();
                OrganizationDAL objDAL = new OrganizationDAL();
                objBAL.Organization_id = OrgID;
                objDAL.Delete(objBAL);
                loadOrganization();
                clearAll();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridOrganization_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                OrgID = Guid.Parse(gridOrganization.Rows[rowindex].Cells["Organization_id"].Value.ToString());
               // int.TryParse(gridOrganization.Rows[rowindex].Cells["Organization_id"].Value.ToString(), out OrgID);
                txtOrganizationTitle.Text = gridOrganization.Rows[rowindex].Cells["Title"].Value.ToString();
                txtDescription.Text = gridOrganization.Rows[rowindex].Cells["Description"].Value.ToString();
            string nm = gridOrganization.Rows[rowindex].Cells["HeaderPicturePath"].Value.ToString();
                filepath = (appPath + (nm));
                OrgPicbox.ImageLocation = filepath;

                picname = nm;


                btnSave.LabelText = "Update";

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (OrgID!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM Organization  ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtOrganizationTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE TYPE = 'ORGANIZATION' AND Title like '%" + txtOrganizationTitle.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (OrgID != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE TYPE = 'ORGANIZATION' AND   WHERE Organization_id  = " + OrgID;
                        whereAdded = true;
                    }
                    else
                        query += "   WHERE TYPE = 'ORGANIZATION'  AND Organization_id  = " + OrgID;
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

                gridOrganization.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ucAddOrganization_Load(object sender, EventArgs e)
        {

            //pgURL = "Organizations"; PermissionDAL.SaveButtonPermission(Program.User_id, pgURL, PerAdd);
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

            loadOrganization();
            clearAll();
            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\OrganizationImages\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddExperincePic_Click(object sender, EventArgs e)
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var iName = opFile.SafeFileName; //Image Name(I Don't Use this name instead 'name')
                    filepath = opFile.FileName; //File path
                                                //Make "<WorkOrderNumber>.Jpg"
                                                /*File.Copy(filepath, appPath + (iName));   */ //Copy Image to Path
                                                                                               // File.Delete(/*filepath, */appPath + ("1234.jpg")); //Delete Image from Path
                    OrgPicbox.ImageLocation = filepath; //Show Image via Dialogbox
                    // string NPath=appPath+name;                         //Exact Path
                    //pictureBox2.Image = Image.FromFile(NPath);         //Get image from path and display in Picture Box
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void txtOrganizationTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }
    }
    }
