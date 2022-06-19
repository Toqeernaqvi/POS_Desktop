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

namespace SicParvisMagna.Forms.Hospital.Medicine
{
    public partial class ucReduceStock : UserControl
    {
        int TotalrowIndex = 0; Guid CatagoryId = Guid.Empty, MedicineId = Guid.Empty;
        List<Guid> removed_medicines_id = new List<Guid>();
        List<party_invoice_medicineBAL> removedItemsList = new List<party_invoice_medicineBAL>();
        PricingDAL pricing_DB = new PricingDAL();
        party_invoiceBAL party_invoice = new party_invoiceBAL();
        party_invoiceDAL party_invoice_db = new party_invoiceDAL();
        party_invoice_medicineBAL party_invoice_medicine = new party_invoice_medicineBAL();
        party_invoice_medicineDAL party_invoice_medicine_db = new party_invoice_medicineDAL();
        DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btn_delrow = new DataGridViewButtonColumn();

        DataGridViewComboBoxColumn cmbx_medicine = new DataGridViewComboBoxColumn();
        ValidationRegex objvr = new ValidationRegex();
        private Guid id = Guid.Empty;
        private FormMain formMain;


        public ucReduceStock(FormMain formMain)
        {
            InitializeComponent();
            LoadCatagory();
            this.formMain = formMain;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formMain.loadMedicineBackForm();
            //FormMain.loadMedicineBackForm();
        }
        public void LoadCbxMedicine()
        {
            MedicineDAL objDal = new MedicineDAL();
            cbx_Medicine.DataSource = objDal.LoadAll().Where(m => m.Medicine_Category_id == CatagoryId).ToList();
            cbx_Medicine.ValueMember = "Medicine_id";
            cbx_Medicine.DisplayMember = "name";
            cbx_Medicine.SelectedIndex = -1;
        }

        public void LoadCatagory()
        {
            Medicine_CategoryDAL catDal = new Medicine_CategoryDAL();
            cbx_Catagory.DataSource = catDal.LoadAll();
            cbx_Catagory.ValueMember = "Medicine_Category_id";
            cbx_Catagory.DisplayMember = "name";
            cbx_Catagory.SelectedIndex = -1;
        }
        private void txt_Name_KeyUp(object sender, KeyEventArgs e)
        {
        }

        //ON Leave
        private void txt_Name_Leave(object sender, EventArgs e)
        {
        }
        public void inti()
        {



        }
        public void FillMedicineCat_value()
        {

        }
        public void FillMedicines_in_grid()
        {
            MedicineDAL objDal = new MedicineDAL();
            grid_Medicine.DataSource = objDal.getRemainingMedicineForReduction(MedicineId);
            grid_Medicine.Columns["Invoice Name | Date"].ReadOnly = true;
            grid_Medicine.Columns["Quantity"].ReadOnly = true;
            grid_Medicine.Columns["Pricing_id"].Visible = false;

        }
        public void Load_Grid()
        {
            cmbx_medicine.HeaderText = "Medicines";
            cmbx_medicine.Name = "cmb_item";
            grid_Medicine.Columns.Add(cmbx_medicine);
            MedicineDAL medicine_db = new MedicineDAL();                     ///0   
            cmbx_medicine.DataSource = medicine_db.LoadAll();
            cmbx_medicine.DisplayMember = "shortname";
            cmbx_medicine.ValueMember = "medicine_id";
            grid_Medicine.Columns[0].Width = 250;

            grid_Medicine.Columns.Add("description", "Description");        //1
            grid_Medicine.Columns["description"].Width = 250;
            grid_Medicine.Columns[1].ReadOnly = true;

            grid_Medicine.Columns.Add("price", "Price");             //2
            grid_Medicine.Columns[2].ReadOnly = false;

            grid_Medicine.Columns.Add("quantity", "quantity");          //3
            grid_Medicine.Columns[3].ReadOnly = false;

            grid_Medicine.Columns.Add("discount_percentage", "Discount Percentage");          //4
            grid_Medicine.Columns.Add("discount_amount", "Discount Amount");          //5
            grid_Medicine.Columns[5].ReadOnly = true;
            grid_Medicine.Columns.Add("tax_percentage", "Tax Percentage");          //6
            grid_Medicine.Columns.Add("tax_amount", "tax_amount");          //7
            grid_Medicine.Columns[7].ReadOnly = true;
            grid_Medicine.Columns.Add("net_amount", "Net Amount");          //8  
            grid_Medicine.Columns[8].ReadOnly = true;

            grid_Medicine.Columns.Add(btn_newrow);
            btn_newrow.HeaderText = "Add";                                              //9
            btn_newrow.Text = "Add Invoice Medicine";
            btn_newrow.Name = "btn_newrow";
            btn_newrow.UseColumnTextForButtonValue = true;
            grid_Medicine.Columns[9].Width = 200;
            grid_Medicine.Columns.Add(btn_delrow);                                        //10
            btn_delrow.HeaderText = "Delete";
            btn_delrow.Text = "Delete Invoice Medicine";
            btn_delrow.Name = "btn_delrow";
            btn_delrow.UseColumnTextForButtonValue = true;
            grid_Medicine.Columns[10].Width = 200;

            grid_Medicine.Columns.Add("ID", "ID");  //11
            grid_Medicine.Columns[11].Visible = false;
            grid_Medicine.Columns.Add("Date", "Date");
            grid_Medicine.Columns["Date"].Visible = false;


            grid_Medicine.Columns.Add("packprice", "PackPrice");             //13
            grid_Medicine.Columns["packprice"].ReadOnly = false;        //13
            grid_Medicine.Columns["packprice"].DisplayIndex = 3;

            if (id == Guid.Empty)
                addRow();
        }
        public void addRow()
        {
            string[] row = null;
            if (id != null)
            {
                row = new string[] { null, "", "0", "0", "0", "0", "0", "0", "0", null, null, "0", "0", "0" };
            }
            else
            {
                row = new string[] { null, "", "0", "0", "0", "0", "0", "0", "0", null, null, "0", "0", "0" };
            }
            if (row != null)
                grid_Medicine.Rows.Add(row);
        }
        public void CalculateTotal()
        {
            for (int i = 0; i < grid_Medicine.RowCount; i++)
            {
                double price = 0, quantity = 0, packprice = 0, total = 0, discount_percentage = 0, discount_amount = 0, tax_percentage = 0, tax_amount = 0, net_amount = 0;
                try
                {
                    price = (double)Convert.ToDouble(grid_Medicine.Rows[i].Cells[2].Value.ToString());
                }
                catch (Exception)
                {
                    grid_Medicine.Rows[i].Cells[2].Value = 0;
                }
                try
                {
                    packprice = (double)Convert.ToDouble(grid_Medicine.Rows[i].Cells["packprice"].Value.ToString());
                }
                catch (Exception)
                {
                    grid_Medicine.Rows[i].Cells["packprice"].Value = 0;
                }
                try
                {
                    quantity = Convert.ToDouble(grid_Medicine.Rows[i].Cells[3].Value.ToString());
                }
                catch (Exception)
                {
                    grid_Medicine.Rows[i].Cells[3].Value = 0;
                }
                total = packprice * quantity;
                try
                {
                    discount_percentage = (float)Convert.ToDecimal(grid_Medicine.Rows[i].Cells[4].Value.ToString()) / 100;
                    if (discount_percentage > 1.0)
                    {
                        grid_Medicine.Rows[i].Cells[4].Value = 100;
                        discount_percentage = (float)1.0;
                    }
                }
                catch (Exception)
                {
                    grid_Medicine.Rows[i].Cells[4].Value = 0;
                }
                discount_amount = discount_percentage * total;
                grid_Medicine.Rows[i].Cells[5].Value = discount_amount;

                try
                {
                    tax_percentage = (float)Convert.ToDecimal(grid_Medicine.Rows[i].Cells[6].Value.ToString()) / 100;
                    if (tax_percentage > 1.0)
                    {
                        grid_Medicine.Rows[i].Cells[6].Value = 100;
                        tax_percentage = (float)1.0;
                    }
                }
                catch (Exception)
                {
                    grid_Medicine.Rows[i].Cells[6].Value = 0;
                }
                tax_amount = tax_percentage * total;
                net_amount = (total - discount_amount) + tax_amount;

                grid_Medicine.Rows[i].Cells[7].Value = tax_amount;

                grid_Medicine.Rows[i].Cells[8].Value = net_amount;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private bool Validated()
        {
            if (!(MedicineId != Guid.Empty))
            {
                lblError_Party.Text = "Medicine Required!";
                return false;
            }
            else
                lblError_Party.Text = "";

            return true;
        }
               
        private void ClearAll()
        {
            id = Guid.Empty;
            CatagoryId = Guid.Empty;
            MedicineId = Guid.Empty;
            cbx_Catagory.SelectedIndex = -1;
            cbx_Medicine.SelectedIndex = -1;
            grid_Medicine.Rows.Clear();
            //  inti();
            btnSave.Text = "     Save";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        private void Search()
        {
            if (id != Guid.Empty)
            {
            }
        }

        private void cbx_Medicine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cbx_Medicine.SelectedValue.ToString(), out MedicineId);
            FillMedicines_in_grid();
        }

        private void cbx_Medicine_Leave(object sender, EventArgs e)
        {
            Guid.TryParse(cbx_Medicine.SelectedValue.ToString(), out MedicineId);
            FillMedicines_in_grid();
        }

        private void cbx_Catagory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cbx_Catagory.SelectedValue.ToString(), out CatagoryId);
            LoadCbxMedicine();
        }

        private void cbx_Catagory_Leave(object sender, EventArgs e)
        {
            Guid.TryParse(cbx_Catagory.SelectedValue.ToString(), out CatagoryId);
            LoadCbxMedicine();
        }

        private void grid_Medicine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int rowid = e.RowIndex;
                int reminaing = Convert.ToInt32(grid_Medicine.Rows[rowid].Cells["Remaining Quantity"].Value.ToString());
                int quantity = Convert.ToInt32(grid_Medicine.Rows[rowid].Cells["Quantity"].Value.ToString());
                if (reminaing > quantity)
                {
                    grid_Medicine.Rows[rowid].Cells["Remaining Quantity"].Value = 0;

                    MessageBox.Show("Remaining Quantity can't be greater than Original Quantity");
                }
                if (reminaing < 0)
                {
                    grid_Medicine.Rows[rowid].Cells["Remaining Quantity"].Value = 0;
                    MessageBox.Show("Remaining Quantity can't be Negative");
                }
            }
        }

        private void grid_Medicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }
        private void Content(DataGridViewCellEventArgs e)
        {

            //if (e.ColumnIndex == 2)
            //{
            //    int rowid = e.RowIndex;
            //    int reminaing = Convert.ToInt32(grid_Medicine.Rows[rowid].Cells["Remaining Quantity"].Value.ToString());
            //    int quantity = Convert.ToInt32(grid_Medicine.Rows[rowid].Cells["Quantity"].Value.ToString());
            //    if(reminaing > quantity)
            //    {
            //        //cancel event;
            //        MessageBox.Show("Remaining Quantity can't be greater than Original Quantity");
            //    }
            //    if (reminaing < 0)
            //    {
            //        //cancel event;
            //        MessageBox.Show("Remaining Quantity can't be Negative");
            //    }
            //}

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (Validated())
            {
                PricingDAL objDal = new PricingDAL();
                for (int x = 0; x < grid_Medicine.Rows.Count; x++)
                {
                    PricingBAL objBal = new PricingBAL();
                    objBal.Pricing_id = Guid.Parse(grid_Medicine.Rows[x].Cells["Pricing_id"].Value.ToString());
                    objBal.remaining = Convert.ToInt32(grid_Medicine.Rows[x].Cells["Remaining Quantity"].Value.ToString());
                    objDal.UpdateRemaining(objBal);
                }
                MessageBox.Show("Successfully Updated Stock");


                // ClearAll();

            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        public void LoadPriceQuantity()
        {
            //MedicineDAL medicine_db = new MedicineDAL();
            //for (int i = 0; i < grid_Party_invoice.Rows.Count; i++)
            //{
            //    try
            //    {
            //        int medicine_id = Convert.ToInt32(grid_Party_invoice.Rows[i].Cells[0].Value.ToString());
            //        var medicine = medicine_db.LoadbyId(medicine_id);
            //        if (medicine != Guid.Empty)
            //        {
            //            grid_Party_invoice.Rows[i].Cells[1].Value = medicine.description;
            //            PricingDAL pricingDB = new PricingDAL();
            //            PricingBAL pricing = new PricingBAL();
            //            pricing = pricingDB.LoadAll().Where(m => m.item_id == medicine_id && m.item_type == "Medicine" && m.qty > 0).OrderByDescending(m => m.Date).Take(1).FirstOrDefault();
            //            if (pricing != Guid.Empty)
            //            {
            //                grid_Party_invoice.Rows[i].Cells[2].Value = pricing.price;
            //                grid_Party_invoice.Rows[i].Cells[3].Value = pricing.qty;
            //            }
            //            else
            //            {
            //                grid_Party_invoice.Rows[i].Cells[2].Value = 0;
            //                grid_Party_invoice.Rows[i].Cells[3].Value = 0;
            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {

            //    }

            // }

        }

    }
}
