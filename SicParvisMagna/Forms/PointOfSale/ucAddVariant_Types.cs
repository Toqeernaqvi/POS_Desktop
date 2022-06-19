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
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class ucAddVariant_Types : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        private Guid VariantID = Guid.Empty;
        private Guid Variant_Type_Id = Guid.Empty;
        public ucAddVariant_Types()
        {
            InitializeComponent();
         
            this.gridVariantTypes.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gridVariantTypes.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
        }

        private void clearAll()
        {
            txtDescription.Clear();
            txtTitle.Clear();
            btnSave.LabelText = "Save";
            cmbVariant.SelectedIndex = -1;
            gridVariantTypes.DataSource = null;
          
        }

        private void loadCmbVariant()
        {
            VariantsDAL objDAL = new VariantsDAL();
            cmbVariant.DataSource = objDAL.LoadAll();
            cmbVariant.DisplayMember = "Title";
            cmbVariant.ValueMember = "Variant_id";
            cmbVariant.SelectedIndex = -1;
        }

        private void loadVariantType(Guid id)
        {
            VariantTypeDAL objDAL = new VariantTypeDAL();
            gridVariantTypes.DataSource = objDAL.LoadByVariant(id);
            gridVariantTypes.Columns["Variant_Type_Id"].Visible = false;
            gridVariantTypes.Columns["ShortName"].Visible = false;

            gridVariantTypes.Columns["Variant_id"].Visible = false;
            gridVariantTypes.Columns["AddBy"].Visible = false;
            gridVariantTypes.Columns["AddDate"].Visible = false;
            gridVariantTypes.Columns["EditBy"].Visible = false;
            gridVariantTypes.Columns["EditDate"].Visible = false;
            gridVariantTypes.Columns["Flag"].Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                VariantTypesBAL objBAL = new VariantTypesBAL();//models
                objBAL.Title = txtTitle.Text;
                objBAL.ShortName = "";
                 objBAL.Description = txtDescription.Text;
                objBAL.Flag = 1;
                objBAL.Variant_Id = VariantID;



                VariantTypeDAL objDAL = new VariantTypeDAL();

                if ( Variant_Type_Id != Guid.Empty)
                {
                    objBAL.Variant_Type_Id = Variant_Type_Id;
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
                clearAll();
                loadCmbVariant();
             }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            loadCmbVariant();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if ( Variant_Type_Id != Guid.Empty)
            {
                VariantTypesBAL objBAL = new VariantTypesBAL();
                VariantTypeDAL objDAL = new VariantTypeDAL();
                objBAL.Variant_Type_Id =  Variant_Type_Id;
                objDAL.Delete(objBAL);
                clearAll();
                 
            }
            else
            {
                MessageBox.Show("No Variant selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridVariantTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                 Variant_Type_Id = Guid.Parse( gridVariantTypes.Rows[rowindex].Cells["Variant_Type_Id"].Value.ToString());

                VariantID = Guid.Parse(gridVariantTypes.Rows[rowindex].Cells["Variant_id"].Value.ToString());
                //   int.TryParse(gridCountries.Rows[rowindex].Cells["country_id"].Value.ToString(), out CountryID);
                txtTitle.Text = gridVariantTypes.Rows[rowindex].Cells["Title"].Value.ToString();
                 txtDescription.Text = gridVariantTypes.Rows[rowindex].Cells["Description"].Value.ToString();

                btnSave.LabelText = "Update";
            }
        }

        private void cmbVariant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cmbVariant.SelectedValue.ToString(),out  VariantID);
            loadVariantType(VariantID);
            
        }

        private void ucAddVariant_Types_Load(object sender, EventArgs e)
        {
            loadCmbVariant();
        }
    }
}
