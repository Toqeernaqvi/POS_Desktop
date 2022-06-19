using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SicParvisMagna.Library;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms
{
    public partial class ucAddIssues : UserControl
    {

        public Guid Issid = Guid.Empty;

        private Guid DeptID = Guid.Empty;
        //SQL Objects
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        //ab ok hai
        public ucAddIssues()
        {
            InitializeComponent();
        }


        private bool FormValidation()
        {
            bool validated = true;



            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                lblErrorName.Text += " Title  is required!";
                validated = false;
            }
            else
            {
                lblErrorName.Text = "";
            }

            if (!Validation.isAlpha(txt_Name.Text, 4))
            {
                if (string.IsNullOrEmpty(txt_Name.Text))
                    lblErrorName.Text += "\n";
                lblErrorName.Text += "";
                validated = false;
            }
            else
            {
                lblError_Name.Text = "";
            }
            //====================================================

            //For Board
          

            //if (string.IsNullOrEmpty(cmb_dept.Text))
            //{
            //    LblError_dept.Text += "Department   is required!";
            //    validated = false;
            //}
            //else
            //{
            //    LblError_dept.Text = "";
            //}
            //if (!Validation.isBoard(cmb_dept.Text, 7))
            //{
            //    if (string.IsNullOrEmpty(cmb_dept.Text))
            //        LblError_dept.Text += "\n";
            //    LblError_dept.Text += "select a department!";
            //    validated = false;
            //}
            //else
            //{
            //    LblError_dept.Text = "";
            //}


            return validated;
        }

      



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                {
                    IssueBAL objBAL = new IssueBAL();
                    objBAL.Title = txt_Name.Text;
                    objBAL.descript = txt_Description.Text;
                    objBAL.due_date = DateTime.Now;
                    objBAL.Addby = "Admin";
                    objBAL.status = "Active";
                    objBAL.flag = 1;
                   objBAL.dept_id = Guid.Empty;





                    IssueDAL objDAL = new IssueDAL();

                    if (Issid!=Guid.Empty)
                    {
                        objBAL.Issue_id = Issid;
                        objBAL.Addby = "Admin";
                        objBAL.status = "Active";
                        //objBAL.dept_id = 1;
                        objBAL.flag = 1;
                        objBAL.timestampp = DateTime.Now;
                        objDAL.Update(objBAL);

                    }
                    else
                    {
                        objBAL.Addby = "Admin";
                        objBAL.status = "Active";
                        objBAL.flag = 1;
                        objBAL.timestampp = DateTime.Now;
                        Issid = objDAL.Add(objBAL);
                    }


                    Issue_labelsBAL obj;
                    Issue_labelDAL OBJ = new Issue_labelDAL();

                    obj = new Issue_labelsBAL();
                    obj.Issue_id = Issid;

                    OBJ.DeleteByIssue(obj);

                    for (int x = 0; x < grid_selectedLabels.Rows.Count; x++)
                    {
                        obj = new Issue_labelsBAL();
                        obj.Issue_id = Issid;
                        obj.label_id = Guid.Parse(grid_selectedLabels.Rows[x].Cells["label_id"].Value.ToString());
                        obj.addby = "Admin";
                        obj.status = "Active";
                        obj.flag = 1;
                        obj.timestampp = DateTime.Now;
                        OBJ.Add(obj);
                    }


                    clearAll();
                    loadIssues();

                }
            }
        }

        private void loadIssues()
        {
            IssueDAL objDAL = new IssueDAL();

            gridIssues.DataSource = objDAL.LoadAll();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            grid_selectedLabels.Rows.Clear();
            lblErrorName.Text = "";
          //  LblError_desc.Text = "";
            LblError_dept.Text = "";
            clearAll();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (Issid!=Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear Issue before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM [Issue_tab] ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txt_Name.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE Title like '%" + txt_Name.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND Title like '%" + txt_Name.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txt_Description.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE descript like '%" + txt_Description.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND descript like '%" + txt_Description.Text + "%'";
                }


                if (!string.IsNullOrEmpty(cmb_dept.Text))
                {
                    if (!whereAdded)
                    {
                        query += "   WHERE dept_id like '%" + cmb_dept.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "   AND dept_id like '%" + cmb_dept.Text + "%'";
                }


                //if (Issid != null)
                //{
                //    if (!whereAdded)
                //    {
                //        query += "   WHERE Issue_id  = " + Issid;
                //        whereAdded = true;
                //    }
                //    else
                //        query += "   AND Issue_id  = " + Issid;
                //}

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

                gridIssues.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (Issid!=null)
            {
                IssueBAL objBAL = new IssueBAL();
                IssueDAL objDAL = new IssueDAL();
                objBAL.Issue_id = Issid;
                objDAL.Delete(objBAL);
                clearAll();
                loadIssues();
            }
            else
            {
                MessageBox.Show("No Issue selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucAddCountry_Load(object sender, EventArgs e)
        {
            loadIssues();
            LoadIssueLabels();
           // loadCbxDepts();
            clearAll();
        }

        private void gridCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridCountries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                Issid = Guid.Parse(gridIssues.Rows[rowindex].Cells["Issue_id"].Value.ToString());
                txt_Name.Text = gridIssues.Rows[rowindex].Cells["Title"].Value.ToString();
                txt_Description.Text = gridIssues.Rows[rowindex].Cells["descript"].Value.ToString();
                DT1.Text = gridIssues.Rows[rowindex].Cells["due_date"].Value.ToString();



                DeptID = Guid.Parse(gridIssues.Rows[rowindex].Cells["dept_id"].Value.ToString());
              //  cmb_dept.SelectedValue = DeptID;

                btnSave.LabelText = "Update";
                loadIssuelabels_ByIssID();
            }
        }

       
        private void clearAll()
        {
            btnSave.Text = "Save";
            txt_Name.Text = "";
            txt_Description.Text = "";
          //  DT = DateTime.Now;      
            cmb_dept.selectedIndex = -1;
         
            Issid =Guid.Empty;
         
            DeptID = Guid.Empty;
        }


        private void loadlabels()
        {
            LabelDAL objDAL = new LabelDAL();
            gridIssues.DataSource = objDAL.LoadAll();
        }

      

        private void LoadIssueLabels()
        {
            LabelDAL objDAL = new LabelDAL();


            DataTable dt_AllLabels = objDAL.LoadAllIssuelabels();
            DataTable dt_selectedLabels = dt_AllLabels.Clone();


            foreach (DataColumn dc in dt_AllLabels.Columns)
            {
                grid_Assignlabels.Columns.Add(dc.ColumnName, dc.ColumnName);
                grid_selectedLabels.Columns.Add(dc.ColumnName, dc.ColumnName);
            }


            foreach (DataRow dr in dt_AllLabels.Rows)
            {
                grid_Assignlabels.Rows.Add(dr.ItemArray);
            }

            DataGridViewCheckBoxColumn dgc = new DataGridViewCheckBoxColumn();
            dgc.Name = "Select";
            dgc.HeaderText = "Select";

            DataGridViewCheckBoxColumn dgc2 = new DataGridViewCheckBoxColumn();
            dgc2.Name = "Select";
            dgc2.HeaderText = "Select";

            grid_Assignlabels.Columns.Add(dgc);
            grid_Assignlabels.Columns["Select"].DisplayIndex = 0;

            grid_selectedLabels.Columns.Add(dgc2);
            grid_selectedLabels.Columns["Select"].DisplayIndex = 0;
            //    gridSelected.Rows.Clear();

        }
        private void loadIssuelabels_ByIssID()
        {
            Issue_labelDAL ObjDal = new Issue_labelDAL();
            Issue_labelsBAL obj = new Issue_labelsBAL();
            obj.Issue_id = Issid;

            DataTable dt_Loadbyissueid = ObjDal.LoadIss_labels_byIssueid(obj);

            if (dt_Loadbyissueid.Rows.Count > 0)
                foreach (DataRow dr in dt_Loadbyissueid.Rows)
                {
                    grid_selectedLabels.Rows.Add(dr.ItemArray);
                }


        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < grid_Assignlabels.Rows.Count; x++)
                {
                    if (Convert.ToBoolean(grid_Assignlabels.Rows[x].Cells["Select"].Value))
                    {
                        DataGridViewRow row = (DataGridViewRow)grid_Assignlabels.Rows[x].Clone();

                        for (int y = 0; y < grid_Assignlabels.Rows[x].Cells.Count; y++)
                        {
                            row.Cells[y].Value = grid_Assignlabels.Rows[x].Cells[y].Value;
                        }

                        grid_selectedLabels.Rows.Add(row);
                        grid_Assignlabels.Rows.RemoveAt(x);
                        x--;
                    }
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < grid_selectedLabels.Rows.Count; x++)
                {
                    if (Convert.ToBoolean(grid_selectedLabels.Rows[x].Cells["Select"].Value))
                    {
                        DataGridViewRow row = (DataGridViewRow)grid_selectedLabels.Rows[x].Clone();

                        for (int y = 0; y < grid_selectedLabels.Rows[x].Cells.Count; y++)
                        {
                            row.Cells[y].Value = grid_selectedLabels.Rows[x].Cells[y].Value;
                        }

                        grid_Assignlabels.Rows.Add(row);
                        grid_selectedLabels.Rows.RemoveAt(x);
                        x--;
                    }
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
