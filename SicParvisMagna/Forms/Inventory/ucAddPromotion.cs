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
using System.Data.SqlClient;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;


namespace SicParvisMagna.Forms
{
    public partial class ucAddPromotion : UserControl
    {
       // private System.Windows.Forms.Panel container;
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid PromID = Guid.Empty;
        private Guid ProID = Guid.Empty;

        public ucAddPromotion()
        {
            InitializeComponent();
        }
        private void loadCbxProduct()
        {
            ProductDAL objDAL = new ProductDAL();
            cbxProduct.DataSource = objDAL.LoadAll();
            cbxProduct.ValueMember = "ProID";
            cbxProduct.DisplayMember = "ProductName";
            cbxProduct.SelectedIndex = -1;
        }
        private void loadPromotion()
        {
            PromotionDAL objDAL = new PromotionDAL();
            gridPromotion.DataSource = objDAL.LoadAll();
            gridPromotion.Columns["Timestamp"].Visible = false;
            gridPromotion.Columns["AddBy"].Visible = false;
            gridPromotion.Columns["Status"].Visible = false;
            gridPromotion.Columns["Flag"].Visible = false;
            gridPromotion.Columns["EditBy"].Visible = false;
            gridPromotion.Columns["EditDate"].Visible = false;
        }

        private void ucAddPromotion_Load(object sender, EventArgs e)
        {
            loadCbxProduct();
            loadPromotion();
            clearAll();
        }
        public void clearAll()
        {
            cbxProduct.SelectedIndex = -1;
            txt_Descrip.Clear();
            loadPromotion();
            btnSave.Text = "Save";
            lblErrorDescrip.Text = "";
        }
        private bool FormValidation()
        {
            bool validated = true;


            //For Accounts title
            if (string.IsNullOrEmpty(txt_Descrip.Text))
            {
                lblErrorDescrip.Text += "  Description  is required!";
                validated = false;
            }
            else
            {
                lblErrorDescrip.Text = "";
            }

            
            return validated;
        }
        private void searchProm()
        {

            if (PromID != null)
            {
                MessageBox.Show("Please unselect/clear User before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query = @" SELECT * FROM Promotion ";
                bool whereAdded = false;

                if (!string.IsNullOrEmpty(txt_Descrip.Text))
                {
                    if (!whereAdded) //whereAdded == false
                    {
                        query += "  WHERE Descrip like '%" + txt_Descrip.Text + "%'";
                        whereAdded = true;
                    }
                    //else
                    // query += "  AND name like '%" + txtFirstName.Text + "%'";
                }
                if (PromID != null)
                {
                    if (!whereAdded)
                    {
                        query += "  WHERE PromID  = " + PromID;
                        whereAdded = true;
                    }
                    else
                        query += "   WHERE PromID = " + PromID;
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

                gridPromotion.DataSource = dt;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mtcPromotion.SelectedTab == mtcPromotion.TabPages[0])
            {
                searchProm();
            }
        }
        private void saveProm()
        {
            if (FormValidation())
            {
                PromotionBAL obj = new PromotionBAL();
                obj.ProID = ProID;
                
                obj.Descrip = txt_Descrip.Text;
                PromotionDAL objDAL = new PromotionDAL();
                if (PromID != Guid.Empty)
                {

                    obj.PromID = PromID;
                    obj.Timestamp = DateTime.Now;
                    obj.AddBy = "Admin";
                    obj.Status = "Active";
                    obj.Flag = 1;
                    objDAL.Update(obj);

                }
                else
                {
                    obj.EditDate = DateTime.Now;
                    obj.EditBy = "Admin";
                    obj.Status = "Active";
                    obj.Flag = 1;
                    objDAL.Add(obj);
                }

                clearAll();
                loadPromotion();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mtcPromotion.SelectedTab == mtcPromotion.TabPages[0])
            {
                saveProm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (mtcPromotion.SelectedTab == mtcPromotion.TabPages[0])
            {
                loadPromotion();
                clearAll();
            }
        }
        private void deleteProm()
        {
            if (PromID != null)
            {
                PromotionBAL objBAL = new PromotionBAL();
                PromotionDAL objDAL = new PromotionDAL();
                objBAL.PromID = PromID;
                objDAL.Delete(objBAL);
                loadPromotion();
                clearAll();
            }
            else
            {
                MessageBox.Show("No Student selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mtcPromotion.SelectedTab == mtcPromotion.TabPages[0])
            {
                deleteProm();
            }
        }

        private void gridPromotion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                PromID = Guid.Parse(gridPromotion.Rows[rowindex].Cells["PromID"].Value.ToString());


                ProID = Guid.Parse(gridPromotion.Rows[rowindex].Cells["ProID"].Value.ToString());
                cbxProduct.SelectedValue = ProID;
                txt_Descrip.Text = gridPromotion.Rows[rowindex].Cells["Descrip"].Value.ToString();


                btnSave.Text = "Update";

            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FormMain.loadBackForm();
          //  container.Controls.Clear();
            //ucInventory form = new ucInventory();
           // form.Dock = DockStyle.Fill;
           // container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";
        }
    }
}
