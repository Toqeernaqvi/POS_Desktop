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
    public partial class ucAddLabels : UserControl
    {
        private Guid LABID = Guid.Empty;
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        private Guid CountryID = Guid.Empty;
        public ucAddLabels()
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
           

            if (string.IsNullOrEmpty(btn_bkcolor.Text))
            {
                LblError_bkcolor.Text += "Select a background color!";
                validated = false;
            }
            else
            {
                LblError_bkcolor.Text = "";
            }
            if (!Validation.isBoard(btn_bkcolor.Text, 7))
            {
                if (string.IsNullOrEmpty(btn_bkcolor.Text))
                    LblError_bkcolor.Text += "\n";
                LblError_bkcolor.Text += "";
                validated = false;
            }
            else
            {
                LblError_bkcolor.Text = "";
            }

            if (string.IsNullOrEmpty(btn_forecolor.Text))
            {
                LblError_forecolor.Text += "Select a fore color!";
                validated = false;
            }
            else
            {
                LblError_forecolor.Text = "";
            }
            if (!Validation.isBoard(btn_forecolor.Text, 7))
            {
                if (string.IsNullOrEmpty(btn_forecolor.Text))
                    LblError_forecolor.Text += "\n";
                LblError_forecolor.Text += "";
                validated = false;
            }
            else
            {
                LblError_forecolor.Text = "";
            }




            return validated;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!FormValidation())
            {
                {
                    



                    LabelBAL objBAL = new LabelBAL();
                    objBAL.name = txt_Name.Text;
                    objBAL.description = txt_Description.Text;
                    objBAL.color_code = colorDialog1.Color.ToString();


                    LabelDAL objDAL = new LabelDAL();

                    if (LABID != Guid.Empty)
                    {
                        objBAL.label_id = LABID;
                        objBAL.Addby = "Admin";
                        objBAL.status = "Active";
                        objBAL.flag = "1";

                        objBAL.timestampp = DateTime.Now;
                        objDAL.Update(objBAL);

                    }
                    else
                    {

                        objBAL.Addby = "Admin";
                        objBAL.status = "Active";
                        objBAL.flag = "1";
                        objBAL.timestampp = DateTime.Now;
                        objDAL.Add(objBAL);
                    }
                    clearAll();
                    loadlabels();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            loadlabels();
            lblErrorName.Text = "";
        
            LblError_bkcolor.Text = "";
            LblError_forecolor.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (LABID != Guid.Empty)
            {
                MessageBox.Show("Please unselect/clear Issue before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query = @" SELECT * FROM [label_tab] ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txt_Name.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += " WHERE name like '%" + txt_Name.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND name like '%" + txt_Name.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txt_Description.Text))
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE description like '%" + txt_Description.Text + "%'";
                        whereAdded = true;
                    }
                    else
                        query += "  AND description like '%" + txt_Description.Text + "%'";
                }

                
                ////if (LABID != Guid.Empty)
                ////{
                ////    if (!whereAdded)
                ////    {
                ////        query += "   WHERE label_id  = " + LABID;
                ////        whereAdded = true;
                ////    }
                ////    else
                ////        query += "   AND label_id  = " + LABID;
                ////}
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

                grid_labels.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LABID != null)
            {
                LabelBAL objBAL = new LabelBAL();
                LabelDAL objDAL = new LabelDAL();
                objBAL.label_id = LABID;
                objDAL.Delete(objBAL);
                clearAll();
                loadlabels();
            }
            else
            {
                MessageBox.Show("No Label selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucAddCountry_Load(object sender, EventArgs e)
        {
            loadlabels();
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
                LABID = Guid.Parse(grid_labels.Rows[rowindex].Cells["label_id"].Value.ToString());
                txt_Name.Text = grid_labels.Rows[rowindex].Cells["name"].Value.ToString();

                txt_Description.Text = grid_labels.Rows[rowindex].Cells["description"].Value.ToString();




                btnSave.LabelText = "Update";
            }
        }

        private void btn_bkcolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txt_Name.BackColor = colorDialog1.Color;
        }

        private void clearAll()
        {
            btnSave.Text = "Save";
            txt_Name.Clear();
            txt_Description.Text = "";
            txt_Name.BackColor = Color.FromKnownColor(KnownColor.Window);
          //  txt_Name.ForeColor = Color.FromKnownColor(KnownColor.Window);

            LABID = Guid.Empty;
        }


        private void loadlabels()
        {
            LabelDAL objDAL = new LabelDAL();
            grid_labels.DataSource = objDAL.LoadAll();
        }

        private void btn_forecolor_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            txt_Name.ForeColor = colorDialog2.Color;
        }
    }
}
