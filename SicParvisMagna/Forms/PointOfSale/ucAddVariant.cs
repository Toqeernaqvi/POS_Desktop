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

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class ucAddVariant : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid VariantID = Guid.Empty;

        public ucAddVariant()
        {
            InitializeComponent();
            this.gridVariants.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridVariants.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
        }

        private void ClearAll()
        {
            btnSave.Text = "Save";
            txtTitle.Clear();
            txtDescription.Clear();
            txtShortName.Clear();
        }

        private void loadVariants()
        {
            VariantsDAL objDAL = new VariantsDAL();
            gridVariants.DataSource = objDAL.LoadAll();
            gridVariants.Columns["Variant_id"].Visible = false;
            gridVariants.Columns["AddBy"].Visible = false;
            gridVariants.Columns["AddDate"].Visible = false;
            gridVariants.Columns["EditBy"].Visible = false;
            gridVariants.Columns["EditDate"].Visible = false;
            gridVariants.Columns["Flag"].Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                VariantBAL objBAL = new VariantBAL();//models
                objBAL.Title = txtTitle.Text;
                objBAL.ShortName = txtShortName.Text;
                objBAL.Description = txtDescription.Text;
                objBAL.Flag = 1;


                VariantsDAL objDAL = new VariantsDAL();

                if (VariantID != Guid.Empty)
                {
                    objBAL.Variant_Id = VariantID;
                    objBAL.EditBy = "Admin";
                    objBAL.EditDate = DateTime.Now;
                    objDAL.Update(objBAL);

                }
                else
                {
                    objBAL.AddBy = "Admin";
                    objBAL.AddDate = DateTime.Now;
                    objDAL.Add(objBAL);
                }
                ClearAll();
                loadVariants();
            }
            catch { }
    }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            loadVariants();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (VariantID != Guid.Empty)
            {
                VariantBAL objBAL = new VariantBAL();
                VariantsDAL objDAL = new VariantsDAL();
                objBAL.Variant_Id = VariantID;
                objDAL.Delete(objBAL);
                ClearAll();
                loadVariants();
            }
            else
            {
                MessageBox.Show("No Variant selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridVariants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                VariantID = Guid.Parse(gridVariants.Rows[rowindex].Cells["Variant_id"].Value.ToString());
                //   int.TryParse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                txtTitle.Text = gridVariants.Rows[rowindex].Cells["Title"].Value.ToString();
                txtShortName.Text = gridVariants.Rows[rowindex].Cells["ShortName"].Value.ToString();
                 txtDescription.Text = gridVariants.Rows[rowindex].Cells["Description"].Value.ToString();

                btnSave.LabelText = "Update";
            }
        }

        private void ucAddVariant_Load(object sender, EventArgs e)
        {
            loadVariants();
        }

        private void btnAddVariantType_Click(object sender, EventArgs e)
        {
            POSMain.loadVariantTypes();
        }
    }
}
