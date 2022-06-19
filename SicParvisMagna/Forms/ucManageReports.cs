using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using System.Data.SqlClient;
using SicParvisMagna.Library;

namespace SicParvisMagna.Forms
{
    public partial class ucManageReports : UserControl
    {
        private Guid id = Guid.Empty;
        private string ReportName;
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public ucManageReports()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {

            reportsDAL objDAL = new reportsDAL();
            gridReport.DataSource = objDAL.LoadAll();
        }
        private void clearAll()
        {
            txtHeaderText.Clear();
            txtHeaderTitle.Clear();
            txtReportName.Clear();
            btnSave.LabelText = "Save";
        }
        private void ucAddReports_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReportBAL obj = new ReportBAL();
            obj.HeaderText = txtHeaderText.Text;
            obj.HeaderTitle = txtHeaderTitle.Text;
            obj.ReportName = txtReportName.Text;
            reportsDAL objDAL = new reportsDAL();
            if (id != Guid.Empty)
            {
                obj.id = id;
                obj.ReportName = ReportName;
                objDAL.Update(obj);
            }
            else
            {
                objDAL.Add(obj);
               
            }
            clearAll();
            loadGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != Guid.Empty)
            {
                ReportBAL obj = new ReportBAL();
                reportsDAL objDAL = new reportsDAL();
                obj.id = id;
                objDAL.Delete(obj);
            }
            clearAll();
            loadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (id != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" select ReportName,HeaderTitle,HeaderText from Reports  ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txtReportName.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE ReportName   like '%" + txtReportName.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtHeaderTitle.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE HeaderTitle   like '%" + txtHeaderTitle.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  WHERE HeaderTitle   like '%" + txtHeaderTitle.Text + "%'";
                }
                //
                if (!string.IsNullOrEmpty(txtHeaderText.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE HeaderText   like '%" + txtHeaderText.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  WHERE HeaderText   like '%" + txtHeaderText+ "%'";
                }

                if (id != Guid.Empty)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE id  = " + id;
                        whereAdded = true;
                    }
                    else
                        query += "   WHERE id   = " + id;
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

                gridReport.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                ReportBAL obj = new ReportBAL();
                id = Guid.Parse(gridReport.Rows[rowindex].Cells["id"].Value.ToString());
                txtHeaderText.Text = gridReport.Rows[rowindex].Cells["HeaderText"].Value.ToString();
                txtHeaderTitle.Text = gridReport.Rows[rowindex].Cells["HeaderTitle"].Value.ToString();
                 txtReportName.Text = gridReport.Rows[rowindex].Cells["ReportName"].Value.ToString();
                txtReportName.ReadOnly = true;

                btnSave.LabelText = "Update";

            }
        }
    }
}
